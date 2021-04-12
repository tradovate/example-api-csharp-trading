/* 
 * 
 * Tradovate API, MarketData Samples
 *
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Tradovate.MarketData.Services.Model;

namespace Tradovate.MarketData.Models
{
    [DataContract]
    public class ChartData
    {
        [DataMember(Name = "charts", EmitDefaultValue = false)]
        public List<Chart> Charts { get; set; }
    }

    [DataContract]
    public class Chart
    {
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public int Id { get; set; }

        [DataMember(Name = "td", EmitDefaultValue = true)]
        public int TradeDate { get; set; }

        [DataMember(Name = "bars", EmitDefaultValue = false)]
        public List<Bar> Bars { get; set; }
    }

    [DataContract]
    public class Bar
    {
        [DataMember(Name = "timestamp", EmitDefaultValue = false)]
        public DateTime? Timestamp { get; set; }

        [DataMember(Name = "open", EmitDefaultValue = false)]
        public double? Open { get; set; }

        [DataMember(Name = "high", EmitDefaultValue = false)]
        public double? High { get; set; }

        [DataMember(Name = "low", EmitDefaultValue = false)]
        public double? Low { get; set; }

        [DataMember(Name = "close", EmitDefaultValue = false)]
        public double? Close { get; set; }

        [DataMember(Name = "upVolume", EmitDefaultValue = false)]
        public int? UpVolume { get; set; }

        [DataMember(Name = "downVolume", EmitDefaultValue = false)]
        public int? DownVolume { get; set; }

        [DataMember(Name = "upTicks", EmitDefaultValue = false)]
        public int? UpTicks { get; set; }

        [DataMember(Name = "downTicks", EmitDefaultValue = false)]
        public int? DownTicks { get; set; }

        [DataMember(Name = "histogram", EmitDefaultValue = false)]
        public BarHistogram Histogram { get; set; }

        [DataMember(Name = "bidVolume", EmitDefaultValue = false)]
        public int? BidVolume { get; set; }

        [DataMember(Name = "offerVolume", EmitDefaultValue = false)]
        public int? OfferVolume { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Bar {\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Open: ").Append(Open).Append("\n");
            sb.Append("  High: ").Append(High).Append("\n");
            sb.Append("  Low: ").Append(Low).Append("\n");
            sb.Append("  Close: ").Append(Close).Append("\n");
            sb.Append("  UpVolume: ").Append(UpVolume).Append("\n");
            sb.Append("  DownVolume: ").Append(DownVolume).Append("\n");
            sb.Append("  UpTicks: ").Append(UpTicks).Append("\n");
            sb.Append("  DownTicks: ").Append(DownTicks).Append("\n");
            sb.Append("  Histogram: ").Append(Histogram).Append("\n");
            sb.Append("  BidVolume: ").Append(BidVolume).Append("\n");
            sb.Append("  OfferVolume: ").Append(OfferVolume).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

    [DataContract]
    public class BarHistogram
    {
        [DataMember(Name = "ts", EmitDefaultValue = false)]
        public double? TickSize { get; set; }

        [DataMember(Name = "h", EmitDefaultValue = false)]
        public Dictionary<int, int[]> H { get; set; }

        public override string ToString()
        {
            var h = H?
                .OrderBy((item) => item.Key)?
                .Select((item) => $"[{item.Key}:bid={item.Value[0]},offer={item.Value[1]}]")?
                .Aggregate(new StringBuilder(), (accum, s) => accum.Append(s))?
                .ToString();

            var sb = new StringBuilder();
            sb.Append("class BarHistogram {\n");
            sb.Append("  TickSize: ").Append(TickSize).Append("\n");
            sb.Append("  H: ").Append(h).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

    [DataContract]
    public class HistogramData
    {
        [DataMember(Name = "histograms", EmitDefaultValue = false)]
        public List<Histogram> Histograms { get; set; }
    }

    [DataContract]
    public class DOMData
    {
        [DataMember(Name = "doms", EmitDefaultValue = false)]
        public List<DOM> Doms { get; set; }
    }

    [DataContract]
    public class QuoteData
    {
        [DataMember(Name = "quotes", EmitDefaultValue = false)]
        public List<Quote> Quotes { get; set; }
    }

    [DataContract]
    public class Quote
    {
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        [DataMember(Name = "timestamp", EmitDefaultValue = false)]
        public DateTime Timestamp { get; set; }

        [DataMember(Name = "contractId", EmitDefaultValue = false)]
        public int ContractId { get; set; }

        [DataMember(Name = "entries", EmitDefaultValue = false)]
        public QuoteEntries Entries { get; set; }
    }

    [DataContract]
    public class PriceRecord
    {
        [DataMember(Name = "price", EmitDefaultValue = false)]
        public double? Price { get; set; }

        [DataMember(Name = "size", EmitDefaultValue = false)]
        public int? Size { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PriceRecord {\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

    [DataContract]
    public class QuoteEntries
    {
        [DataMember(EmitDefaultValue = false)]
        public PriceRecord Bid { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public PriceRecord Offer { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public PriceRecord Trade { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public PriceRecord OpeningPrice { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public PriceRecord SettlementPrice { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public PriceRecord TotalTradeVolume { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public PriceRecord EmptyBook { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public PriceRecord OpenInterest { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public PriceRecord HighPrice { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public PriceRecord LowPrice { get; set; }
    }
}