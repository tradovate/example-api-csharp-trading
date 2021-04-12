/*
 *
 * Tradovate API, Samples.
 * Order placement
 *
*/

using System;
using System.Linq;
using Tradovate.Services.Api;
using Tradovate.Services.Model;

namespace Tradovate
{
    static class Trading
    {
        public static async void PlaceOrder(Account account, PlaceOrder.ActionEnum action, int orderQty, string symbol, PlaceOrder.OrderTypeEnum orderType, double? price = null, double? stopPrice = null)
        {
            var ordersApi = new OrdersApi();
            var request = new PlaceOrder(accountSpec: account.Name,
                action: action,
                symbol: symbol,
                orderQty: orderQty,
                orderType: orderType,
                price: price,
                stopPrice: stopPrice,
                timeInForce: Services.Model.PlaceOrder.TimeInForceEnum.Day,
                text: "Sample" /*, isAutomated: true, customTag50: "MyTag50"*/);
            var response = await ordersApi.PlaceOrderAsync(request);
            Console.WriteLine($"{request} -> {response}");
        }

        static string GetOrderVersionDescription(Order order, Contract contract, OrderVersion orderVersion)
        {
            string orderPrice;

            switch (orderVersion.OrderType)
            {
                case OrderVersion.OrderTypeEnum.Market:
                    orderPrice = "MKT";
                    break;
                case OrderVersion.OrderTypeEnum.Limit:
                case OrderVersion.OrderTypeEnum.MIT:
                    orderPrice = $"{orderVersion.OrderType} {orderVersion.Price}";
                    break;
                case OrderVersion.OrderTypeEnum.Stop:
                    orderPrice = $"{orderVersion.OrderType} {orderVersion.StopPrice}";
                    break;
                case OrderVersion.OrderTypeEnum.StopLimit:
                    orderPrice = $"STOP {orderVersion.StopPrice} LIMIT {orderVersion.Price}";
                    break;
                case OrderVersion.OrderTypeEnum.TrailingStop:
                    orderPrice = $"TRAIL.STOP {orderVersion.StopPrice} with {orderVersion.PegDifference}";
                    break;
                case OrderVersion.OrderTypeEnum.TrailingStopLimit:
                    orderPrice = $"TRAIL.STOP {orderVersion.StopPrice} LIMIT {orderVersion.Price} with {orderVersion.PegDifference}";
                    break;
                default:
                    orderPrice = orderVersion.OrderType.ToString();
                    break;
            }

            return $"{order.Action} {orderVersion.OrderQty} {contract.Name} @ {orderPrice}";
        }

        static string GetCommandDescription(Order order, Contract contract, Command command)
        {
            if (command.CommandType == Command.CommandTypeEnum.Cancel)
            {
                return "Cancel";
            }
            var ordersApi = new OrdersApi();
            var description = GetOrderVersionDescription(order, contract, ordersApi.OrderVersionItem(command.Id));
            if (command.CommandType == Command.CommandTypeEnum.Modify)
            {
                return $"Modify to {description}";
            }
            return description;
        }

        static string GetFillDescription(Fill fill)
        {
            var description = $"Fill: {fill.Qty} @ {fill.Price}";
            if (fill.Active == false)
            {
                return $"{description} - Inactive";
            }
            return description;
        }

        static string GetExecutionReportDescription(ExecutionReport executionReport)
        {
            string description;
            if (executionReport.OrdStatus == ExecutionReport.OrdStatusEnum.Working && executionReport.CumQty > 0)
            {
                description = "Partially Filled";
            }
            else
            {
                description = executionReport.OrdStatus.ToString();
            }
            if (executionReport.CumQty > 0)
            {
                description += $", cum. filled qty: {executionReport.CumQty} @ {executionReport.AvgPx}";
            }
            return $"Status Update: {description}";
        }

        static string GetCommandReportDescription(CommandReport commandReport)
        {
            string description = $"Command Updated: #{commandReport.CommandId} - {commandReport.CommandStatus}";
            if (commandReport.RejectReason.HasValue)
            {
                description += $" - {commandReport.RejectReason}";
            }

            if (commandReport.Text != null)
            {
                description += $" - {commandReport.Text}";
            }
            return description;
        }

        public static void ShowOrderDetails(ExecutionReport executionReport)
        {
            var ordersApi = new OrdersApi();
            ShowOrderDetails(ordersApi.OrderItem(executionReport.OrderId));
        }

        public static void ShowOrderDetails(CommandReport commandReport)
        {
            var ordersApi = new OrdersApi();
            var command = ordersApi.CommandItem(commandReport.CommandId);
            ShowOrderDetails(ordersApi.OrderItem(command.OrderId));
        }

        public static async void ShowOrderDetails(Order order)
        {
            Log.Write($"SHOW ORDER DETAILS FOR {order.Id}");
            var ordersApi = new OrdersApi();
            var orderCommands = ordersApi.CommandDependents(order.Id);
            var currentCommand = orderCommands.LastOrDefault(command => command.CommandType == Command.CommandTypeEnum.New || command.CommandType == Command.CommandTypeEnum.Modify && (command.CommandStatus == Command.CommandStatusEnum.AtExecution || command.CommandStatus == Command.CommandStatusEnum.OnHold || command.CommandStatus == Command.CommandStatusEnum.ExecutionSuspended));
            if (currentCommand != null)
            {
                var currentOrderVersion = ordersApi.OrderVersionItem(currentCommand.Id);
                var fills = ordersApi.FillDependents(order.Id);
                var commandIds = orderCommands.Select(command => command.Id).ToList();
                var executionReports = ordersApi.ExecutionReportLDependents(commandIds);
                var commandReports = ordersApi.CommandReportLDependents(commandIds);

                var contractLibraryApi = new ContractLibraryApi();
                var contract = await contractLibraryApi.ContractItemAsync(order.ContractId);
                var contractMaturity = await contractLibraryApi.ContractMaturityItemAsync(contract.ContractMaturityId);
                var product = await contractLibraryApi.ProductItemAsync(contractMaturity.ProductId);

                var lines = orderCommands.Select(command => new
                {
                    Id = command.Id,
                    Timestamp = command.Timestamp,
                    Text = GetCommandDescription(order, contract, command)
                })
                .Concat(
                    fills.Select(fill => new
                    {
                        Id = fill.Id,
                        Timestamp = fill.Timestamp,
                        Text = GetFillDescription(fill)
                    }))
                .Concat(
                    commandReports.Select(commandReport => new
                    {
                        Id = commandReport.Id,
                        Timestamp = commandReport.Timestamp,
                        Text = GetCommandReportDescription(commandReport)
                    }))
                .Concat(
                    executionReports.Select(executionReport => new
                    {
                        Id = executionReport.Id,
                        Timestamp = executionReport.Timestamp,
                        Text = GetExecutionReportDescription(executionReport)
                    }));

                string orderStatus;

                switch (order.OrdStatus)
                {
                    case Order.OrdStatusEnum.Working:
                        var totalFilled = fills.Where(fill => fill.Active == true).Sum(fill => fill.Qty);
                        if (totalFilled > 0)
                        {
                            orderStatus = "Partially Filled";
                        }
                        else
                        {
                            orderStatus = order.OrdStatus.ToString();
                        }
                        break;
                    default:
                        orderStatus = order.OrdStatus.ToString();
                        break;
                }

                string accountHolderEmail;
                var accountingApi = new AccountingApi();
                var account = await accountingApi.AccountItemAsync(order.AccountId);
                try
                {
                    // CTA should look through trading permissions
                    var allTradingPermissions = await accountingApi.TradingPermissionListAsync();
                    var tradingPermission = allTradingPermissions.First(x => x.AccountId == account.Id && x.Status == TradingPermission.StatusEnum.Approved);
                    accountHolderEmail = tradingPermission.AccountHolderEmail;
                }
                catch
                {
                    // Organization Admin or actual owner of the account has access to User entity
                    var userApi = new UsersApi();
                    var user = await userApi.UserItemAsync(account.UserId);
                    accountHolderEmail = user.Email;
                }

                Log.Write($"Order #{order.Id} {GetOrderVersionDescription(order, contract, currentOrderVersion)} - {orderStatus}, Acc: #{account.Name}, Email: #{accountHolderEmail}");
                foreach (var line in lines.OrderBy(x => x.Id).ThenBy(x => x.Timestamp))
                {
                    Console.WriteLine($"{line.Timestamp} #{line.Id}: {line.Text}");
                }
                Console.WriteLine();
            }
        }
    }
}