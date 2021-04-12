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
    /// CashBalance
    /// </summary>
    [DataContract]
        public partial class CashBalance :  IEquatable<CashBalance>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CashBalance" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="accountId">accountId (required).</param>
        /// <param name="timestamp">timestamp (required).</param>
        /// <param name="tradeDate">tradeDate (required).</param>
        /// <param name="currencyId">currencyId (required).</param>
        /// <param name="amount">amount (required).</param>
        /// <param name="realizedPnL">realizedPnL.</param>
        /// <param name="weekRealizedPnL">weekRealizedPnL.</param>
        public CashBalance(long? id = default(long?), long? accountId = default(long?), DateTime? timestamp = default(DateTime?), TradeDate tradeDate = default(TradeDate), long? currencyId = default(long?), double? amount = default(double?), double? realizedPnL = default(double?), double? weekRealizedPnL = default(double?))
        {
            // to ensure "accountId" is required (not null)
            if (accountId == null)
            {
                throw new InvalidDataException("accountId is a required property for CashBalance and cannot be null");
            }
            else
            {
                this.AccountId = accountId;
            }
            // to ensure "timestamp" is required (not null)
            if (timestamp == null)
            {
                throw new InvalidDataException("timestamp is a required property for CashBalance and cannot be null");
            }
            else
            {
                this.Timestamp = timestamp;
            }
            // to ensure "tradeDate" is required (not null)
            if (tradeDate == null)
            {
                throw new InvalidDataException("tradeDate is a required property for CashBalance and cannot be null");
            }
            else
            {
                this.TradeDate = tradeDate;
            }
            // to ensure "currencyId" is required (not null)
            if (currencyId == null)
            {
                throw new InvalidDataException("currencyId is a required property for CashBalance and cannot be null");
            }
            else
            {
                this.CurrencyId = currencyId;
            }
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new InvalidDataException("amount is a required property for CashBalance and cannot be null");
            }
            else
            {
                this.Amount = amount;
            }
            this.Id = id;
            this.RealizedPnL = realizedPnL;
            this.WeekRealizedPnL = weekRealizedPnL;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets AccountId
        /// </summary>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public long? AccountId { get; set; }

        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Gets or Sets TradeDate
        /// </summary>
        [DataMember(Name="tradeDate", EmitDefaultValue=false)]
        public TradeDate TradeDate { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyId
        /// </summary>
        [DataMember(Name="currencyId", EmitDefaultValue=false)]
        public long? CurrencyId { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public double? Amount { get; set; }

        /// <summary>
        /// Gets or Sets RealizedPnL
        /// </summary>
        [DataMember(Name="realizedPnL", EmitDefaultValue=false)]
        public double? RealizedPnL { get; set; }

        /// <summary>
        /// Gets or Sets WeekRealizedPnL
        /// </summary>
        [DataMember(Name="weekRealizedPnL", EmitDefaultValue=false)]
        public double? WeekRealizedPnL { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CashBalance {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  TradeDate: ").Append(TradeDate).Append("\n");
            sb.Append("  CurrencyId: ").Append(CurrencyId).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  RealizedPnL: ").Append(RealizedPnL).Append("\n");
            sb.Append("  WeekRealizedPnL: ").Append(WeekRealizedPnL).Append("\n");
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
            return this.Equals(input as CashBalance);
        }

        /// <summary>
        /// Returns true if CashBalance instances are equal
        /// </summary>
        /// <param name="input">Instance of CashBalance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CashBalance input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.TradeDate == input.TradeDate ||
                    (this.TradeDate != null &&
                    this.TradeDate.Equals(input.TradeDate))
                ) && 
                (
                    this.CurrencyId == input.CurrencyId ||
                    (this.CurrencyId != null &&
                    this.CurrencyId.Equals(input.CurrencyId))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.RealizedPnL == input.RealizedPnL ||
                    (this.RealizedPnL != null &&
                    this.RealizedPnL.Equals(input.RealizedPnL))
                ) && 
                (
                    this.WeekRealizedPnL == input.WeekRealizedPnL ||
                    (this.WeekRealizedPnL != null &&
                    this.WeekRealizedPnL.Equals(input.WeekRealizedPnL))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.AccountId != null)
                    hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.TradeDate != null)
                    hashCode = hashCode * 59 + this.TradeDate.GetHashCode();
                if (this.CurrencyId != null)
                    hashCode = hashCode * 59 + this.CurrencyId.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.RealizedPnL != null)
                    hashCode = hashCode * 59 + this.RealizedPnL.GetHashCode();
                if (this.WeekRealizedPnL != null)
                    hashCode = hashCode * 59 + this.WeekRealizedPnL.GetHashCode();
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
