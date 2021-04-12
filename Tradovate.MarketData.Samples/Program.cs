/* 
 * 
 * Tradovate API, MarketData Samples
 *
*/

using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tradovate.MarketData.Models;
using Tradovate.MarketData.Services.Api;
using Tradovate.MarketData.Services.Client;
using Tradovate.MarketData.Services.Model;
using Tradovate.Services.Api;
using Tradovate.Services.Model;

namespace Tradovate.MarketData
{
    class Program
    {
        static void Main(string[] args)
        { 
            var Username = args[0];
            var Password = args[1];

            var accessTokenResponse = GetAccessToken("https://live-api-d.tradovate.com/v1", Username, Password);
            var AccessToken = accessTokenResponse.AccessToken;

            ConsumingQuotes(AccessToken);
            ConsumingDOM(AccessToken);
            ConsumingHistograms(AccessToken);
            ConsumingCharts(AccessToken);
        }

        /// <summary>
        /// Demonstrates how to work with quote data. 
        /// </summary>
        static void ConsumingQuotes(string accessToken)
        {
            var scenario = new Scenario("Consuming quotes")
                .InitializeAPI(
                    () =>
                    {
                        var cfg = new Configuration();
                        cfg.AccessToken = accessToken;

                        return new Tradovate.MarketData.Services.Api.PricesApi(cfg);
                    })
                .InitializeClient(
                    init: () => new WSClient("https://md-api-d.tradovate.com/v1"),
                    opened: (sender, e) =>
                    {
                        Log.Write("WebSocket opened.");
                    },
                    closed: (sender, e) =>
                    {
                        Log.Write("WebSocket closed.");
                    })
                .Request("Subscribe for ESM0 quotes",
                    init: () =>
                    {
                        // The contract ESM0 is specified by contract symbol
                        return new SubscribeQuote("ESM0");
                    },
                    sender: (api, request) => api.SubscribeQuoteAsyncWithHttpInfo(request),
                    responseHandler: (request, response) =>
                    {
                        Log.Write($"{request} -> {response.Data}");
                    },
                    dataHandler: message =>
                    {
                        switch (message.e)
                        {
                            case "md":
                                Log.Write("MD event:");
                                var json = message.d as JObject;
                                var data = json.ToObject<QuoteData>();
                                data?.Quotes?.ForEach(quote =>
                                {
                                    Log.Write($"  CONTRACT: {quote.ContractId}");
                                    Log.Write($"  TIMESTAMP: {quote.Timestamp}");
                                    Log.Write($"  BID: {quote.Entries.Bid}");
                                    Log.Write($"  OFFER: {quote.Entries.Offer}");
                                    Log.Write($"  TRADE: {quote.Entries.Trade}");
                                    Log.Write($"  EMPTY BOOK: {quote.Entries.EmptyBook}");
                                    Log.Write($"  HIGH PRICE: {quote.Entries.HighPrice}");
                                    Log.Write($"  LOW PRICE: {quote.Entries.LowPrice}");
                                    Log.Write($"  OPENING PRICE: {quote.Entries.OpeningPrice}");
                                    Log.Write($"  OPEN INTEREST: {quote.Entries.OpenInterest}");
                                    Log.Write($"  SETTLEMENT PRICE: {quote.Entries.SettlementPrice}");
                                    Log.Write($"  TOTAL TRADE VOLUME: {quote.Entries.TotalTradeVolume}");
                                });
                                break;
                        }
                    })
                .ProcessingWhile(TimeSpan.FromSeconds(15))
                .Request("Unsubscribe from ESM0 quotes",
                    init: () =>
                    {
                        // The contract ESM0 is specified by contract ID
                        return new UnsubscribeQuote("1751847");
                    },
                    sender: (api, request) => api.UnsubscribeQuoteAsyncWithHttpInfo(request),
                    responseHandler: (request, response) =>
                    {
                        Log.Write($"{request} -> {response.Data}");
                    });

            scenario.Run();
        }

        /// <summary>
        /// Demonstrates how to work with DOM data. 
        /// </summary>
        static void ConsumingDOM(string accessToken)
        {
            var scenario = new Scenario("Consuming DOM")
                .InitializeAPI(
                    () =>
                    {
                        var cfg = new Configuration();
                        cfg.AccessToken = accessToken;

                        return new Tradovate.MarketData.Services.Api.PricesApi(cfg);
                    })
                .InitializeClient(
                    init: () => new WSClient("https://md-api-d.tradovate.com/v1"),
                    opened: (sender, e) =>
                    {
                        Log.Write("WebSocket opened.");
                    },
                    closed: (sender, e) =>
                    {
                        Log.Write("WebSocket closed.");
                    })
                .Request("Subscribe for ESM0 DOM",
                    init: () =>
                    {
                        // The contract ESM0 is specified by contract symbol
                        return new SubscribeDOM("ESM0");
                    },
                    sender: (api, request) => api.SubscribeDOMAsyncWithHttpInfo(request),
                    responseHandler: (request, response) =>
                    {
                        Log.Write($"{request} -> {response.Data}");
                    },
                    dataHandler: message =>
                    {
                        switch (message.e)
                        {
                            case "md":
                                Log.Write("MD event:");
                                var json = message.d as JObject;
                                var data = json.ToObject<DOMData>();
                                data?.Doms?.ForEach(dom =>
                                {
                                    Log.Write($"  CONTRACT: {dom.ContractId}");
                                    Log.Write($"  TIMESTAMP: {dom.Timestamp}");
                                    Log.Write("  BIDS:");
                                    Console.WriteLine(string.Join("\n", dom.Bids.Select(x => $"  {x}")));
                                    Log.Write("  OFFERS:");
                                    Console.WriteLine(string.Join("\n", dom.Offers.Select(x => $"  {x}")));
                                });
                                break;
                        }
                    })
                .ProcessingWhile(TimeSpan.FromSeconds(15))
                .Request("Unsubscribe from ESM0 DOM",
                    init: () =>
                    {
                        // The contract ESM0 is specified by contract ID
                        return new UnsubscribeDOM("1751847");
                    },
                    sender: (api, request) => api.UnsubscribeDOMAsyncWithHttpInfo(request),
                    responseHandler: (request, response) =>
                    {
                        Log.Write($"{request} -> {response.Data}");
                    });

            scenario.Run();
        }

        /// <summary>
        /// Demonstrates how to work with histogram data. 
        /// </summary>
        static void ConsumingHistograms(string accessToken)
        {
            var scenario = new Scenario("Consuming histograms")
                .InitializeAPI(
                    () =>
                    {
                        var cfg = new Configuration();
                        cfg.AccessToken = accessToken;

                        return new Tradovate.MarketData.Services.Api.PricesApi(cfg);
                    })
                .InitializeClient(
                    init: () => new WSClient("https://md-api-d.tradovate.com/v1"),
                    opened: (sender, e) =>
                    {
                        Log.Write("WebSocket opened.");
                    },
                    closed: (sender, e) =>
                    {
                        Log.Write("WebSocket closed.");
                    })
                .Request("Subscribe for ESM0 histograms",
                    init: () => new SubscribeHistogram("ESM0"),
                    sender: (api, request) => api.SubscribeHistogramAsyncWithHttpInfo(request),
                    responseHandler: (request, response) =>
                    {
                        Log.Write($"{request} -> {response.Data}");
                    },
                    dataHandler: message =>
                    {
                        switch (message.e)
                        {
                            case "md":
                                Log.Write("MD event:");
                                var json = message.d as JObject;
                                var data = json.ToObject<HistogramData>();
                                data?.Histograms?.ForEach(histogram =>
                                {
                                    Log.Write($"  CONTRACT: {histogram.ContractId}");
                                    Log.Write($"  TIMESTAMP: {histogram.Timestamp}");
                                    Log.Write($"  REFRESH: {histogram.Refresh}");
                                    Log.Write($"  TRADE DATE: {histogram.TradeDate}");
                                    Log.Write($"  BASE: {histogram.Base}");

                                    var items = histogram.Items as JObject;
                                    if (items != null)
                                    {
                                        Log.Write("  ITEMS:");
                                        var pairs = items.ToObject<SortedDictionary<int, int>>();
                                        Console.WriteLine(string.Join("\n", pairs.Select(x => $"  {x}")));
                                    }
                                });
                                break;
                        }
                    })
                .ProcessingWhile(TimeSpan.FromSeconds(15))
                .Request("Unsubscribe from ESM0 histograms",
                    init: () => new UnsubscribeHistogram("1751847"),
                    sender: (api, request) => api.UnsubscribeHistogramAsyncWithHttpInfo(request),
                    responseHandler: (request, response) =>
                    {
                        Log.Write($"{request} -> {response.Data}");
                    });

            scenario.Run();
        }

        /// <summary>
        /// Demonstrates how to work with chart data. 
        /// </summary>
        static void ConsumingCharts(string accessToken)
        {
            int? subscriptionId = 0;

            var scenario = new Scenario("Consuming charts")
                .InitializeAPI(
                    () =>
                    {
                        var cfg = new Configuration();
                        cfg.AccessToken = accessToken;

                        return new Tradovate.MarketData.Services.Api.PricesApi(cfg);
                    })
                .InitializeClient(
                    init: () => new WSClient("https://md-api-d.tradovate.com/v1"),
                    opened: (sender, e) =>
                    {
                        Log.Write("WebSocket opened.");
                    },
                    closed: (sender, e) =>
                    {
                        Log.Write("WebSocket closed.");
                    })
                .Request("Get chart for ESM0",
                    init: () =>
                    {
                        var description = new ChartDescription(ChartDescription.UnderlyingTypeEnum.MinuteBar, 15, ChartDescription.ElementSizeUnitEnum.UnderlyingUnits, withHistogram: true);
                        var timeRange = new ChartTimeRange(asMuchAsElements: 66);
                        return new GetChart("ESM0", description, timeRange);
                    },
                    sender: (api, request) => api.GetChartAsyncWithHttpInfo(request),
                    responseHandler: (request, response) =>
                    {
                        Log.Write($"{request} -> {response.Data}");
                        subscriptionId = response.Data.RealtimeId; // Store real-time subscription ID to properly cancel the subscription
                    },
                    dataHandler: message =>
                    {
                        switch (message.e)
                        {
                            case "chart":
                                Log.Write("CHART event:");
                                var json = message.d as JObject;
                                var data = json.ToObject<ChartData>();
                                data?.Charts?.ForEach(chart =>
                                {
                                    Log.Write($"  ID: {chart.Id}");
                                    Log.Write($"  TD: {chart.TradeDate}");
                                    if (chart.Bars != null)
                                    {
                                        Log.Write("  BARS:");
                                        Console.WriteLine(string.Join("\n", chart.Bars.Select(x => $"  {x}")));
                                    }
                                });
                                break;
                        }
                    })
                .ProcessingWhile(TimeSpan.FromSeconds(15))
                .Request($"Cancel chart subscription",
                    init: () => new CancelChart(subscriptionId ?? 0),
                    sender: (api, request) => api.CancelChartAsyncWithHttpInfo(request),
                    responseHandler: (request, response) =>
                    {
                        Log.Write($"{request} -> {response.Data}");
                    });

            scenario.Run();
        }

        static AccessTokenResponse GetAccessToken(string basePath, string username, string password)
        {
            var apiInstance = new AuthenticationApi(basePath);
            var body = new AccessTokenRequest(name: username, password: password, appId: "Tradovate.MarketData.SampleApp", appVersion: "0.1.0");
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            AccessTokenResponse result = apiInstance.AccessTokenRequest(body);
            Debug.WriteLine(result);
            return result;
        }
    }
}