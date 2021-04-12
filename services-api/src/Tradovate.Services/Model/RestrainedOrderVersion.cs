/* 
 * Tradovate API
 *
 * Tradovate API provides an access to the complete set of robust Tradovate functionality.
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Tradovate.Services.Client.SwaggerDateConverter;

namespace Tradovate.Services.Model
{
    /// <summary>
    /// RestrainedOrderVersion
    /// </summary>
    [DataContract]
        public partial class RestrainedOrderVersion :  IEquatable<RestrainedOrderVersion>, IValidatableObject
    {
        /// <summary>
        /// Buy, Sell
        /// </summary>
        /// <value>Buy, Sell</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ActionEnum
        {
            /// <summary>
            /// Enum Buy for value: Buy
            /// </summary>
            [EnumMember(Value = "Buy")]
            Buy = 1,
            /// <summary>
            /// Enum Sell for value: Sell
            /// </summary>
            [EnumMember(Value = "Sell")]
            Sell = 2        }
        /// <summary>
        /// Buy, Sell
        /// </summary>
        /// <value>Buy, Sell</value>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public ActionEnum Action { get; set; }
        /// <summary>
        /// Limit, MIT, Market, QTS, Stop, StopLimit, TrailingStop, TrailingStopLimit
        /// </summary>
        /// <value>Limit, MIT, Market, QTS, Stop, StopLimit, TrailingStop, TrailingStopLimit</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum OrderTypeEnum
        {
            /// <summary>
            /// Enum Limit for value: Limit
            /// </summary>
            [EnumMember(Value = "Limit")]
            Limit = 1,
            /// <summary>
            /// Enum MIT for value: MIT
            /// </summary>
            [EnumMember(Value = "MIT")]
            MIT = 2,
            /// <summary>
            /// Enum Market for value: Market
            /// </summary>
            [EnumMember(Value = "Market")]
            Market = 3,
            /// <summary>
            /// Enum QTS for value: QTS
            /// </summary>
            [EnumMember(Value = "QTS")]
            QTS = 4,
            /// <summary>
            /// Enum Stop for value: Stop
            /// </summary>
            [EnumMember(Value = "Stop")]
            Stop = 5,
            /// <summary>
            /// Enum StopLimit for value: StopLimit
            /// </summary>
            [EnumMember(Value = "StopLimit")]
            StopLimit = 6,
            /// <summary>
            /// Enum TrailingStop for value: TrailingStop
            /// </summary>
            [EnumMember(Value = "TrailingStop")]
            TrailingStop = 7,
            /// <summary>
            /// Enum TrailingStopLimit for value: TrailingStopLimit
            /// </summary>
            [EnumMember(Value = "TrailingStopLimit")]
            TrailingStopLimit = 8        }
        /// <summary>
        /// Limit, MIT, Market, QTS, Stop, StopLimit, TrailingStop, TrailingStopLimit
        /// </summary>
        /// <value>Limit, MIT, Market, QTS, Stop, StopLimit, TrailingStop, TrailingStopLimit</value>
        [DataMember(Name="orderType", EmitDefaultValue=false)]
        public OrderTypeEnum OrderType { get; set; }
        /// <summary>
        /// Day, FOK, GTC, GTD, IOC
        /// </summary>
        /// <value>Day, FOK, GTC, GTD, IOC</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TimeInForceEnum
        {
            /// <summary>
            /// Enum Day for value: Day
            /// </summary>
            [EnumMember(Value = "Day")]
            Day = 1,
            /// <summary>
            /// Enum FOK for value: FOK
            /// </summary>
            [EnumMember(Value = "FOK")]
            FOK = 2,
            /// <summary>
            /// Enum GTC for value: GTC
            /// </summary>
            [EnumMember(Value = "GTC")]
            GTC = 3,
            /// <summary>
            /// Enum GTD for value: GTD
            /// </summary>
            [EnumMember(Value = "GTD")]
            GTD = 4,
            /// <summary>
            /// Enum IOC for value: IOC
            /// </summary>
            [EnumMember(Value = "IOC")]
            IOC = 5        }
        /// <summary>
        /// Day, FOK, GTC, GTD, IOC
        /// </summary>
        /// <value>Day, FOK, GTC, GTD, IOC</value>
        [DataMember(Name="timeInForce", EmitDefaultValue=false)]
        public TimeInForceEnum? TimeInForce { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RestrainedOrderVersion" /> class.
        /// </summary>
        /// <param name="action">Buy, Sell (required).</param>
        /// <param name="clOrdId">clOrdId.</param>
        /// <param name="orderType">Limit, MIT, Market, QTS, Stop, StopLimit, TrailingStop, TrailingStopLimit (required).</param>
        /// <param name="price">price.</param>
        /// <param name="stopPrice">stopPrice.</param>
        /// <param name="maxShow">maxShow.</param>
        /// <param name="pegDifference">pegDifference.</param>
        /// <param name="timeInForce">Day, FOK, GTC, GTD, IOC.</param>
        /// <param name="expireTime">expireTime.</param>
        /// <param name="text">text.</param>
        public RestrainedOrderVersion(ActionEnum action = default(ActionEnum), string clOrdId = default(string), OrderTypeEnum orderType = default(OrderTypeEnum), double? price = default(double?), double? stopPrice = default(double?), int? maxShow = default(int?), double? pegDifference = default(double?), TimeInForceEnum? timeInForce = default(TimeInForceEnum?), DateTime? expireTime = default(DateTime?), string text = default(string))
        {
            // to ensure "action" is required (not null)
            if (action == null)
            {
                throw new InvalidDataException("action is a required property for RestrainedOrderVersion and cannot be null");
            }
            else
            {
                this.Action = action;
            }
            // to ensure "orderType" is required (not null)
            if (orderType == null)
            {
                throw new InvalidDataException("orderType is a required property for RestrainedOrderVersion and cannot be null");
            }
            else
            {
                this.OrderType = orderType;
            }
            this.ClOrdId = clOrdId;
            this.Price = price;
            this.StopPrice = stopPrice;
            this.MaxShow = maxShow;
            this.PegDifference = pegDifference;
            this.TimeInForce = timeInForce;
            this.ExpireTime = expireTime;
            this.Text = text;
        }
        

        /// <summary>
        /// Gets or Sets ClOrdId
        /// </summary>
        [DataMember(Name="clOrdId", EmitDefaultValue=false)]
        public string ClOrdId { get; set; }


        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public double? Price { get; set; }

        /// <summary>
        /// Gets or Sets StopPrice
        /// </summary>
        [DataMember(Name="stopPrice", EmitDefaultValue=false)]
        public double? StopPrice { get; set; }

        /// <summary>
        /// Gets or Sets MaxShow
        /// </summary>
        [DataMember(Name="maxShow", EmitDefaultValue=false)]
        public int? MaxShow { get; set; }

        /// <summary>
        /// Gets or Sets PegDifference
        /// </summary>
        [DataMember(Name="pegDifference", EmitDefaultValue=false)]
        public double? PegDifference { get; set; }


        /// <summary>
        /// Gets or Sets ExpireTime
        /// </summary>
        [DataMember(Name="expireTime", EmitDefaultValue=false)]
        public DateTime? ExpireTime { get; set; }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestrainedOrderVersion {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  ClOrdId: ").Append(ClOrdId).Append("\n");
            sb.Append("  OrderType: ").Append(OrderType).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  StopPrice: ").Append(StopPrice).Append("\n");
            sb.Append("  MaxShow: ").Append(MaxShow).Append("\n");
            sb.Append("  PegDifference: ").Append(PegDifference).Append("\n");
            sb.Append("  TimeInForce: ").Append(TimeInForce).Append("\n");
            sb.Append("  ExpireTime: ").Append(ExpireTime).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestrainedOrderVersion);
        }

        /// <summary>
        /// Returns true if RestrainedOrderVersion instances are equal
        /// </summary>
        /// <param name="input">Instance of RestrainedOrderVersion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestrainedOrderVersion input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.ClOrdId == input.ClOrdId ||
                    (this.ClOrdId != null &&
                    this.ClOrdId.Equals(input.ClOrdId))
                ) && 
                (
                    this.OrderType == input.OrderType ||
                    (this.OrderType != null &&
                    this.OrderType.Equals(input.OrderType))
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.StopPrice == input.StopPrice ||
                    (this.StopPrice != null &&
                    this.StopPrice.Equals(input.StopPrice))
                ) && 
                (
                    this.MaxShow == input.MaxShow ||
                    (this.MaxShow != null &&
                    this.MaxShow.Equals(input.MaxShow))
                ) && 
                (
                    this.PegDifference == input.PegDifference ||
                    (this.PegDifference != null &&
                    this.PegDifference.Equals(input.PegDifference))
                ) && 
                (
                    this.TimeInForce == input.TimeInForce ||
                    (this.TimeInForce != null &&
                    this.TimeInForce.Equals(input.TimeInForce))
                ) && 
                (
                    this.ExpireTime == input.ExpireTime ||
                    (this.ExpireTime != null &&
                    this.ExpireTime.Equals(input.ExpireTime))
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.ClOrdId != null)
                    hashCode = hashCode * 59 + this.ClOrdId.GetHashCode();
                if (this.OrderType != null)
                    hashCode = hashCode * 59 + this.OrderType.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.StopPrice != null)
                    hashCode = hashCode * 59 + this.StopPrice.GetHashCode();
                if (this.MaxShow != null)
                    hashCode = hashCode * 59 + this.MaxShow.GetHashCode();
                if (this.PegDifference != null)
                    hashCode = hashCode * 59 + this.PegDifference.GetHashCode();
                if (this.TimeInForce != null)
                    hashCode = hashCode * 59 + this.TimeInForce.GetHashCode();
                if (this.ExpireTime != null)
                    hashCode = hashCode * 59 + this.ExpireTime.GetHashCode();
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
