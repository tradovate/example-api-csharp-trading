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
    /// MarketDataSubscription
    /// </summary>
    [DataContract]
        public partial class MarketDataSubscription :  IEquatable<MarketDataSubscription>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarketDataSubscription" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="userId">userId (required).</param>
        /// <param name="timestamp">timestamp (required).</param>
        /// <param name="planPrice">planPrice (required).</param>
        /// <param name="creditCardTransactionId">creditCardTransactionId.</param>
        /// <param name="cashBalanceLogId">cashBalanceLogId.</param>
        /// <param name="creditCardId">creditCardId.</param>
        /// <param name="accountId">accountId.</param>
        /// <param name="marketDataSubscriptionPlanId">marketDataSubscriptionPlanId (required).</param>
        /// <param name="year">year (required).</param>
        /// <param name="month">month (required).</param>
        /// <param name="renewalCreditCardId">renewalCreditCardId.</param>
        /// <param name="renewalAccountId">renewalAccountId.</param>
        public MarketDataSubscription(long? id = default(long?), long? userId = default(long?), DateTime? timestamp = default(DateTime?), double? planPrice = default(double?), long? creditCardTransactionId = default(long?), long? cashBalanceLogId = default(long?), long? creditCardId = default(long?), long? accountId = default(long?), long? marketDataSubscriptionPlanId = default(long?), int? year = default(int?), int? month = default(int?), long? renewalCreditCardId = default(long?), long? renewalAccountId = default(long?))
        {
            // to ensure "userId" is required (not null)
            if (userId == null)
            {
                throw new InvalidDataException("userId is a required property for MarketDataSubscription and cannot be null");
            }
            else
            {
                this.UserId = userId;
            }
            // to ensure "timestamp" is required (not null)
            if (timestamp == null)
            {
                throw new InvalidDataException("timestamp is a required property for MarketDataSubscription and cannot be null");
            }
            else
            {
                this.Timestamp = timestamp;
            }
            // to ensure "planPrice" is required (not null)
            if (planPrice == null)
            {
                throw new InvalidDataException("planPrice is a required property for MarketDataSubscription and cannot be null");
            }
            else
            {
                this.PlanPrice = planPrice;
            }
            // to ensure "marketDataSubscriptionPlanId" is required (not null)
            if (marketDataSubscriptionPlanId == null)
            {
                throw new InvalidDataException("marketDataSubscriptionPlanId is a required property for MarketDataSubscription and cannot be null");
            }
            else
            {
                this.MarketDataSubscriptionPlanId = marketDataSubscriptionPlanId;
            }
            // to ensure "year" is required (not null)
            if (year == null)
            {
                throw new InvalidDataException("year is a required property for MarketDataSubscription and cannot be null");
            }
            else
            {
                this.Year = year;
            }
            // to ensure "month" is required (not null)
            if (month == null)
            {
                throw new InvalidDataException("month is a required property for MarketDataSubscription and cannot be null");
            }
            else
            {
                this.Month = month;
            }
            this.Id = id;
            this.CreditCardTransactionId = creditCardTransactionId;
            this.CashBalanceLogId = cashBalanceLogId;
            this.CreditCardId = creditCardId;
            this.AccountId = accountId;
            this.RenewalCreditCardId = renewalCreditCardId;
            this.RenewalAccountId = renewalAccountId;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public long? UserId { get; set; }

        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Gets or Sets PlanPrice
        /// </summary>
        [DataMember(Name="planPrice", EmitDefaultValue=false)]
        public double? PlanPrice { get; set; }

        /// <summary>
        /// Gets or Sets CreditCardTransactionId
        /// </summary>
        [DataMember(Name="creditCardTransactionId", EmitDefaultValue=false)]
        public long? CreditCardTransactionId { get; set; }

        /// <summary>
        /// Gets or Sets CashBalanceLogId
        /// </summary>
        [DataMember(Name="cashBalanceLogId", EmitDefaultValue=false)]
        public long? CashBalanceLogId { get; set; }

        /// <summary>
        /// Gets or Sets CreditCardId
        /// </summary>
        [DataMember(Name="creditCardId", EmitDefaultValue=false)]
        public long? CreditCardId { get; set; }

        /// <summary>
        /// Gets or Sets AccountId
        /// </summary>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public long? AccountId { get; set; }

        /// <summary>
        /// Gets or Sets MarketDataSubscriptionPlanId
        /// </summary>
        [DataMember(Name="marketDataSubscriptionPlanId", EmitDefaultValue=false)]
        public long? MarketDataSubscriptionPlanId { get; set; }

        /// <summary>
        /// Gets or Sets Year
        /// </summary>
        [DataMember(Name="year", EmitDefaultValue=false)]
        public int? Year { get; set; }

        /// <summary>
        /// Gets or Sets Month
        /// </summary>
        [DataMember(Name="month", EmitDefaultValue=false)]
        public int? Month { get; set; }

        /// <summary>
        /// Gets or Sets RenewalCreditCardId
        /// </summary>
        [DataMember(Name="renewalCreditCardId", EmitDefaultValue=false)]
        public long? RenewalCreditCardId { get; set; }

        /// <summary>
        /// Gets or Sets RenewalAccountId
        /// </summary>
        [DataMember(Name="renewalAccountId", EmitDefaultValue=false)]
        public long? RenewalAccountId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MarketDataSubscription {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  PlanPrice: ").Append(PlanPrice).Append("\n");
            sb.Append("  CreditCardTransactionId: ").Append(CreditCardTransactionId).Append("\n");
            sb.Append("  CashBalanceLogId: ").Append(CashBalanceLogId).Append("\n");
            sb.Append("  CreditCardId: ").Append(CreditCardId).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  MarketDataSubscriptionPlanId: ").Append(MarketDataSubscriptionPlanId).Append("\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  Month: ").Append(Month).Append("\n");
            sb.Append("  RenewalCreditCardId: ").Append(RenewalCreditCardId).Append("\n");
            sb.Append("  RenewalAccountId: ").Append(RenewalAccountId).Append("\n");
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
            return this.Equals(input as MarketDataSubscription);
        }

        /// <summary>
        /// Returns true if MarketDataSubscription instances are equal
        /// </summary>
        /// <param name="input">Instance of MarketDataSubscription to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MarketDataSubscription input)
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
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.PlanPrice == input.PlanPrice ||
                    (this.PlanPrice != null &&
                    this.PlanPrice.Equals(input.PlanPrice))
                ) && 
                (
                    this.CreditCardTransactionId == input.CreditCardTransactionId ||
                    (this.CreditCardTransactionId != null &&
                    this.CreditCardTransactionId.Equals(input.CreditCardTransactionId))
                ) && 
                (
                    this.CashBalanceLogId == input.CashBalanceLogId ||
                    (this.CashBalanceLogId != null &&
                    this.CashBalanceLogId.Equals(input.CashBalanceLogId))
                ) && 
                (
                    this.CreditCardId == input.CreditCardId ||
                    (this.CreditCardId != null &&
                    this.CreditCardId.Equals(input.CreditCardId))
                ) && 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.MarketDataSubscriptionPlanId == input.MarketDataSubscriptionPlanId ||
                    (this.MarketDataSubscriptionPlanId != null &&
                    this.MarketDataSubscriptionPlanId.Equals(input.MarketDataSubscriptionPlanId))
                ) && 
                (
                    this.Year == input.Year ||
                    (this.Year != null &&
                    this.Year.Equals(input.Year))
                ) && 
                (
                    this.Month == input.Month ||
                    (this.Month != null &&
                    this.Month.Equals(input.Month))
                ) && 
                (
                    this.RenewalCreditCardId == input.RenewalCreditCardId ||
                    (this.RenewalCreditCardId != null &&
                    this.RenewalCreditCardId.Equals(input.RenewalCreditCardId))
                ) && 
                (
                    this.RenewalAccountId == input.RenewalAccountId ||
                    (this.RenewalAccountId != null &&
                    this.RenewalAccountId.Equals(input.RenewalAccountId))
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
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.PlanPrice != null)
                    hashCode = hashCode * 59 + this.PlanPrice.GetHashCode();
                if (this.CreditCardTransactionId != null)
                    hashCode = hashCode * 59 + this.CreditCardTransactionId.GetHashCode();
                if (this.CashBalanceLogId != null)
                    hashCode = hashCode * 59 + this.CashBalanceLogId.GetHashCode();
                if (this.CreditCardId != null)
                    hashCode = hashCode * 59 + this.CreditCardId.GetHashCode();
                if (this.AccountId != null)
                    hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.MarketDataSubscriptionPlanId != null)
                    hashCode = hashCode * 59 + this.MarketDataSubscriptionPlanId.GetHashCode();
                if (this.Year != null)
                    hashCode = hashCode * 59 + this.Year.GetHashCode();
                if (this.Month != null)
                    hashCode = hashCode * 59 + this.Month.GetHashCode();
                if (this.RenewalCreditCardId != null)
                    hashCode = hashCode * 59 + this.RenewalCreditCardId.GetHashCode();
                if (this.RenewalAccountId != null)
                    hashCode = hashCode * 59 + this.RenewalAccountId.GetHashCode();
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
