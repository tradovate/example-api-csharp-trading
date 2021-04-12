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
    /// PlaceOsoResult
    /// </summary>
    [DataContract]
        public partial class PlaceOsoResult :  IEquatable<PlaceOsoResult>, IValidatableObject
    {
        /// <summary>
        /// AccountClosed, AdvancedTrailingStopUnsupported, AnotherCommandPending, BackMonthProhibited, ExecutionProviderNotConfigured, ExecutionProviderUnavailable, InvalidContract, InvalidPrice, LiquidationOnly, LiquidationOnlyBeforeExpiration, MaxOrderQtyIsNotSpecified, MaxOrderQtyLimitReached, MaxPosLimitMisconfigured, MaxPosLimitReached, MaxTotalPosLimitReached, MultipleAccountPlanRequired, NoQuote, NotEnoughLiquidity, OtherExecutionRelated, ParentRejected, RiskCheckTimeout, SessionClosed, Success, TooLate, TradingLocked, TrailingStopNonOrderQtyModify, Unauthorized, UnknownReason, Unsupported
        /// </summary>
        /// <value>AccountClosed, AdvancedTrailingStopUnsupported, AnotherCommandPending, BackMonthProhibited, ExecutionProviderNotConfigured, ExecutionProviderUnavailable, InvalidContract, InvalidPrice, LiquidationOnly, LiquidationOnlyBeforeExpiration, MaxOrderQtyIsNotSpecified, MaxOrderQtyLimitReached, MaxPosLimitMisconfigured, MaxPosLimitReached, MaxTotalPosLimitReached, MultipleAccountPlanRequired, NoQuote, NotEnoughLiquidity, OtherExecutionRelated, ParentRejected, RiskCheckTimeout, SessionClosed, Success, TooLate, TradingLocked, TrailingStopNonOrderQtyModify, Unauthorized, UnknownReason, Unsupported</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum FailureReasonEnum
        {
            /// <summary>
            /// Enum AccountClosed for value: AccountClosed
            /// </summary>
            [EnumMember(Value = "AccountClosed")]
            AccountClosed = 1,
            /// <summary>
            /// Enum AdvancedTrailingStopUnsupported for value: AdvancedTrailingStopUnsupported
            /// </summary>
            [EnumMember(Value = "AdvancedTrailingStopUnsupported")]
            AdvancedTrailingStopUnsupported = 2,
            /// <summary>
            /// Enum AnotherCommandPending for value: AnotherCommandPending
            /// </summary>
            [EnumMember(Value = "AnotherCommandPending")]
            AnotherCommandPending = 3,
            /// <summary>
            /// Enum BackMonthProhibited for value: BackMonthProhibited
            /// </summary>
            [EnumMember(Value = "BackMonthProhibited")]
            BackMonthProhibited = 4,
            /// <summary>
            /// Enum ExecutionProviderNotConfigured for value: ExecutionProviderNotConfigured
            /// </summary>
            [EnumMember(Value = "ExecutionProviderNotConfigured")]
            ExecutionProviderNotConfigured = 5,
            /// <summary>
            /// Enum ExecutionProviderUnavailable for value: ExecutionProviderUnavailable
            /// </summary>
            [EnumMember(Value = "ExecutionProviderUnavailable")]
            ExecutionProviderUnavailable = 6,
            /// <summary>
            /// Enum InvalidContract for value: InvalidContract
            /// </summary>
            [EnumMember(Value = "InvalidContract")]
            InvalidContract = 7,
            /// <summary>
            /// Enum InvalidPrice for value: InvalidPrice
            /// </summary>
            [EnumMember(Value = "InvalidPrice")]
            InvalidPrice = 8,
            /// <summary>
            /// Enum LiquidationOnly for value: LiquidationOnly
            /// </summary>
            [EnumMember(Value = "LiquidationOnly")]
            LiquidationOnly = 9,
            /// <summary>
            /// Enum LiquidationOnlyBeforeExpiration for value: LiquidationOnlyBeforeExpiration
            /// </summary>
            [EnumMember(Value = "LiquidationOnlyBeforeExpiration")]
            LiquidationOnlyBeforeExpiration = 10,
            /// <summary>
            /// Enum MaxOrderQtyIsNotSpecified for value: MaxOrderQtyIsNotSpecified
            /// </summary>
            [EnumMember(Value = "MaxOrderQtyIsNotSpecified")]
            MaxOrderQtyIsNotSpecified = 11,
            /// <summary>
            /// Enum MaxOrderQtyLimitReached for value: MaxOrderQtyLimitReached
            /// </summary>
            [EnumMember(Value = "MaxOrderQtyLimitReached")]
            MaxOrderQtyLimitReached = 12,
            /// <summary>
            /// Enum MaxPosLimitMisconfigured for value: MaxPosLimitMisconfigured
            /// </summary>
            [EnumMember(Value = "MaxPosLimitMisconfigured")]
            MaxPosLimitMisconfigured = 13,
            /// <summary>
            /// Enum MaxPosLimitReached for value: MaxPosLimitReached
            /// </summary>
            [EnumMember(Value = "MaxPosLimitReached")]
            MaxPosLimitReached = 14,
            /// <summary>
            /// Enum MaxTotalPosLimitReached for value: MaxTotalPosLimitReached
            /// </summary>
            [EnumMember(Value = "MaxTotalPosLimitReached")]
            MaxTotalPosLimitReached = 15,
            /// <summary>
            /// Enum MultipleAccountPlanRequired for value: MultipleAccountPlanRequired
            /// </summary>
            [EnumMember(Value = "MultipleAccountPlanRequired")]
            MultipleAccountPlanRequired = 16,
            /// <summary>
            /// Enum NoQuote for value: NoQuote
            /// </summary>
            [EnumMember(Value = "NoQuote")]
            NoQuote = 17,
            /// <summary>
            /// Enum NotEnoughLiquidity for value: NotEnoughLiquidity
            /// </summary>
            [EnumMember(Value = "NotEnoughLiquidity")]
            NotEnoughLiquidity = 18,
            /// <summary>
            /// Enum OtherExecutionRelated for value: OtherExecutionRelated
            /// </summary>
            [EnumMember(Value = "OtherExecutionRelated")]
            OtherExecutionRelated = 19,
            /// <summary>
            /// Enum ParentRejected for value: ParentRejected
            /// </summary>
            [EnumMember(Value = "ParentRejected")]
            ParentRejected = 20,
            /// <summary>
            /// Enum RiskCheckTimeout for value: RiskCheckTimeout
            /// </summary>
            [EnumMember(Value = "RiskCheckTimeout")]
            RiskCheckTimeout = 21,
            /// <summary>
            /// Enum SessionClosed for value: SessionClosed
            /// </summary>
            [EnumMember(Value = "SessionClosed")]
            SessionClosed = 22,
            /// <summary>
            /// Enum Success for value: Success
            /// </summary>
            [EnumMember(Value = "Success")]
            Success = 23,
            /// <summary>
            /// Enum TooLate for value: TooLate
            /// </summary>
            [EnumMember(Value = "TooLate")]
            TooLate = 24,
            /// <summary>
            /// Enum TradingLocked for value: TradingLocked
            /// </summary>
            [EnumMember(Value = "TradingLocked")]
            TradingLocked = 25,
            /// <summary>
            /// Enum TrailingStopNonOrderQtyModify for value: TrailingStopNonOrderQtyModify
            /// </summary>
            [EnumMember(Value = "TrailingStopNonOrderQtyModify")]
            TrailingStopNonOrderQtyModify = 26,
            /// <summary>
            /// Enum Unauthorized for value: Unauthorized
            /// </summary>
            [EnumMember(Value = "Unauthorized")]
            Unauthorized = 27,
            /// <summary>
            /// Enum UnknownReason for value: UnknownReason
            /// </summary>
            [EnumMember(Value = "UnknownReason")]
            UnknownReason = 28,
            /// <summary>
            /// Enum Unsupported for value: Unsupported
            /// </summary>
            [EnumMember(Value = "Unsupported")]
            Unsupported = 29        }
        /// <summary>
        /// AccountClosed, AdvancedTrailingStopUnsupported, AnotherCommandPending, BackMonthProhibited, ExecutionProviderNotConfigured, ExecutionProviderUnavailable, InvalidContract, InvalidPrice, LiquidationOnly, LiquidationOnlyBeforeExpiration, MaxOrderQtyIsNotSpecified, MaxOrderQtyLimitReached, MaxPosLimitMisconfigured, MaxPosLimitReached, MaxTotalPosLimitReached, MultipleAccountPlanRequired, NoQuote, NotEnoughLiquidity, OtherExecutionRelated, ParentRejected, RiskCheckTimeout, SessionClosed, Success, TooLate, TradingLocked, TrailingStopNonOrderQtyModify, Unauthorized, UnknownReason, Unsupported
        /// </summary>
        /// <value>AccountClosed, AdvancedTrailingStopUnsupported, AnotherCommandPending, BackMonthProhibited, ExecutionProviderNotConfigured, ExecutionProviderUnavailable, InvalidContract, InvalidPrice, LiquidationOnly, LiquidationOnlyBeforeExpiration, MaxOrderQtyIsNotSpecified, MaxOrderQtyLimitReached, MaxPosLimitMisconfigured, MaxPosLimitReached, MaxTotalPosLimitReached, MultipleAccountPlanRequired, NoQuote, NotEnoughLiquidity, OtherExecutionRelated, ParentRejected, RiskCheckTimeout, SessionClosed, Success, TooLate, TradingLocked, TrailingStopNonOrderQtyModify, Unauthorized, UnknownReason, Unsupported</value>
        [DataMember(Name="failureReason", EmitDefaultValue=false)]
        public FailureReasonEnum? FailureReason { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PlaceOsoResult" /> class.
        /// </summary>
        /// <param name="failureReason">AccountClosed, AdvancedTrailingStopUnsupported, AnotherCommandPending, BackMonthProhibited, ExecutionProviderNotConfigured, ExecutionProviderUnavailable, InvalidContract, InvalidPrice, LiquidationOnly, LiquidationOnlyBeforeExpiration, MaxOrderQtyIsNotSpecified, MaxOrderQtyLimitReached, MaxPosLimitMisconfigured, MaxPosLimitReached, MaxTotalPosLimitReached, MultipleAccountPlanRequired, NoQuote, NotEnoughLiquidity, OtherExecutionRelated, ParentRejected, RiskCheckTimeout, SessionClosed, Success, TooLate, TradingLocked, TrailingStopNonOrderQtyModify, Unauthorized, UnknownReason, Unsupported.</param>
        /// <param name="failureText">failureText.</param>
        /// <param name="orderId">orderId.</param>
        /// <param name="oso1Id">oso1Id.</param>
        /// <param name="oso2Id">oso2Id.</param>
        public PlaceOsoResult(FailureReasonEnum? failureReason = default(FailureReasonEnum?), string failureText = default(string), long? orderId = default(long?), long? oso1Id = default(long?), long? oso2Id = default(long?))
        {
            this.FailureReason = failureReason;
            this.FailureText = failureText;
            this.OrderId = orderId;
            this.Oso1Id = oso1Id;
            this.Oso2Id = oso2Id;
        }
        

        /// <summary>
        /// Gets or Sets FailureText
        /// </summary>
        [DataMember(Name="failureText", EmitDefaultValue=false)]
        public string FailureText { get; set; }

        /// <summary>
        /// Gets or Sets OrderId
        /// </summary>
        [DataMember(Name="orderId", EmitDefaultValue=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// Gets or Sets Oso1Id
        /// </summary>
        [DataMember(Name="oso1Id", EmitDefaultValue=false)]
        public long? Oso1Id { get; set; }

        /// <summary>
        /// Gets or Sets Oso2Id
        /// </summary>
        [DataMember(Name="oso2Id", EmitDefaultValue=false)]
        public long? Oso2Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlaceOsoResult {\n");
            sb.Append("  FailureReason: ").Append(FailureReason).Append("\n");
            sb.Append("  FailureText: ").Append(FailureText).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  Oso1Id: ").Append(Oso1Id).Append("\n");
            sb.Append("  Oso2Id: ").Append(Oso2Id).Append("\n");
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
            return this.Equals(input as PlaceOsoResult);
        }

        /// <summary>
        /// Returns true if PlaceOsoResult instances are equal
        /// </summary>
        /// <param name="input">Instance of PlaceOsoResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlaceOsoResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FailureReason == input.FailureReason ||
                    (this.FailureReason != null &&
                    this.FailureReason.Equals(input.FailureReason))
                ) && 
                (
                    this.FailureText == input.FailureText ||
                    (this.FailureText != null &&
                    this.FailureText.Equals(input.FailureText))
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.Oso1Id == input.Oso1Id ||
                    (this.Oso1Id != null &&
                    this.Oso1Id.Equals(input.Oso1Id))
                ) && 
                (
                    this.Oso2Id == input.Oso2Id ||
                    (this.Oso2Id != null &&
                    this.Oso2Id.Equals(input.Oso2Id))
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
                if (this.FailureReason != null)
                    hashCode = hashCode * 59 + this.FailureReason.GetHashCode();
                if (this.FailureText != null)
                    hashCode = hashCode * 59 + this.FailureText.GetHashCode();
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.Oso1Id != null)
                    hashCode = hashCode * 59 + this.Oso1Id.GetHashCode();
                if (this.Oso2Id != null)
                    hashCode = hashCode * 59 + this.Oso2Id.GetHashCode();
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
