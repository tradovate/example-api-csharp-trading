/*
 *
 * Tradovate API, Samples
 *
*/

using System;
using System.Threading;
using System.Threading.Tasks;
using Tradovate.Services.Client;
using Tradovate.Services.Model;
using Tradovate.Services.Api;

namespace Tradovate
{
    class Program
    {
        static string AccessToken;
        static long MyUserId;
        static string MyUsername, MyPassword;
        static string DemoUrl, LiveUrl;

        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Please specify username and password as arguments");
                return;
            }

            MyUsername = args[0];
            MyPassword = args[1];
            var password = args[1];
            LiveUrl = "https://live-api-d.tradovate.com/v1";
            DemoUrl = "https://demo-api-d.tradovate.com/v1";

            var accessTokenResponse = Authentication.GetAccessToken(LiveUrl, MyUsername, password);
            AccessToken = accessTokenResponse.AccessToken;
            MyUserId = accessTokenResponse.UserId ?? 0;

            // RestApiExample();
            TradingViaWebSocketExample();
            // AccountRiskLimits();

            // Authenticated user should be "OrganizationAdmin" to successfully proceed the next samples
            // Please uncomment the next line
            // OrganizationExample();

            Thread.Sleep(3000);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        private static void WebsocketClient_DataUpdated(object sender, DataUpdate e)
        {
            Console.WriteLine(e.ToString());
            if (e.Entity is ExecutionReport)
            {
                Trading.ShowOrderDetails(e.Entity as ExecutionReport);
            }
            else if (e.Entity is Order)
            {
                Trading.ShowOrderDetails(e.Entity as Order);
            }
            if (e.Entity is CommandReport)
            {
                Trading.ShowOrderDetails(e.Entity as CommandReport);
            }
        }

        private static void WebsocketClient_Closed(object sender, EventArgs e)
        {
            Console.WriteLine("WebsocketClient_Closed");
        }

        private static void RestApiExample()
        {
            // Via REST API
            Console.WriteLine("CALLING SERVICES VIA REST API");
            Configuration.Default = new Configuration();
            Configuration.Default.BasePath = DemoUrl;
            Configuration.Default.AccessToken = AccessToken;

            var account = Accounting.GetAccount(MyUserId);
            Accounting.ShowAccountActivities(account);

            var feesApi = new FeesApi();
            var availablePlans = feesApi.TradovateSubscriptionPlanList();
            foreach (var plan in availablePlans)
            {
                Console.WriteLine(plan);
            }
        }

        static WebSocketClient InitializeWebSocket(bool liveEnvironment)
        {
            Configuration.Default = new Configuration();
            Configuration.Default.AccessToken = AccessToken;
            WebSocketClient websocketClient = new WebSocketClient(liveEnvironment ? LiveUrl : DemoUrl);
            Configuration.Default.ApiClient.RestClient = websocketClient;
            return websocketClient;
        }

        private static void TradingViaWebSocketExample()
        {
            Console.WriteLine("\nCALLING SERVICES VIA WEBSOCKET");
            WebSocketClient websocketClient = InitializeWebSocket(false);
            websocketClient.DataUpdated += WebsocketClient_DataUpdated;
            websocketClient.Closed += WebsocketClient_Closed;
            websocketClient.Opened += (sender, e) =>
            {
                Console.WriteLine("WebsocketClient_Opened");
                Task.Run(() =>
                {
                    Accounting.StartRealtimeUpdates();

                    Accounting.PrepopulateCache();
                    // ContractLibrary.PrepopulateCache();

                    Thread.Sleep(3000);
                    var symbol = "ESM1";
                    Log.Write($"SHOW {symbol} SPECIFICATIONS");
                    ContractLibrary.ContractSpec(symbol);

                    Thread.Sleep(3000);
                    var account = Accounting.GetAccount(0);
                    var orderQty = 1;
                    Log.Write($"PLACE BUY {orderQty} {symbol} MKT ORDER");
                    Trading.PlaceOrder(account, PlaceOrder.ActionEnum.Buy, orderQty, symbol, PlaceOrder.OrderTypeEnum.Market);

                    Thread.Sleep(3000);
                    Log.Write($"PLACE SELL {orderQty} {symbol} MKT ORDER");
                    Trading.PlaceOrder(account, PlaceOrder.ActionEnum.Sell, orderQty, symbol, PlaceOrder.OrderTypeEnum.Market);

                    Thread.Sleep(300000);
                    websocketClient.Close();
                });
            };
            Thread.Sleep(13000);
        }

        private static void AccountRiskLimits()
        {
            Configuration.Default = new Configuration();
            Configuration.Default.BasePath = DemoUrl;
            Configuration.Default.AccessToken = AccessToken;

            var account = Accounting.GetAccount(MyUserId);

            Console.WriteLine("\nSHOWING ACCOUNT RISK LIMITS");
            Risks.ShowRiskLimits(account);
            Risks.SetMaxOverallPositionLimit(account, 9);
            Risks.SetDailyLossLimit(account, 1210.0);
            // Risks.DeleteMaxOverallPositionLimit(account);
        }
    }
 }
