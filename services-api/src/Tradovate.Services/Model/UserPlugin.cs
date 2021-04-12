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
    /// UserPlugin
    /// </summary>
    [DataContract]
        public partial class UserPlugin :  IEquatable<UserPlugin>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserPlugin" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="userId">userId (required).</param>
        /// <param name="timestamp">timestamp (required).</param>
        /// <param name="planPrice">planPrice (required).</param>
        /// <param name="creditCardTransactionId">creditCardTransactionId.</param>
        /// <param name="cashBalanceLogId">cashBalanceLogId.</param>
        /// <param name="creditCardId">creditCardId.</param>
        /// <param name="accountId">accountId.</param>
        /// <param name="pluginName">pluginName (required).</param>
        /// <param name="approval">approval (required).</param>
        /// <param name="entitlementId">entitlementId.</param>
        /// <param name="startDate">startDate (required).</param>
        /// <param name="expirationDate">expirationDate.</param>
        /// <param name="paidAmount">paidAmount (required).</param>
        /// <param name="autorenewal">autorenewal.</param>
        /// <param name="planCategories">planCategories.</param>
        public UserPlugin(long? id = default(long?), long? userId = default(long?), DateTime? timestamp = default(DateTime?), double? planPrice = default(double?), long? creditCardTransactionId = default(long?), long? cashBalanceLogId = default(long?), long? creditCardId = default(long?), long? accountId = default(long?), string pluginName = default(string), bool? approval = default(bool?), long? entitlementId = default(long?), TradeDate startDate = default(TradeDate), TradeDate expirationDate = default(TradeDate), double? paidAmount = default(double?), bool? autorenewal = default(bool?), string planCategories = default(string))
        {
            // to ensure "userId" is required (not null)
            if (userId == null)
            {
                throw new InvalidDataException("userId is a required property for UserPlugin and cannot be null");
            }
            else
            {
                this.UserId = userId;
            }
            // to ensure "timestamp" is required (not null)
            if (timestamp == null)
            {
                throw new InvalidDataException("timestamp is a required property for UserPlugin and cannot be null");
            }
            else
            {
                this.Timestamp = timestamp;
            }
            // to ensure "planPrice" is required (not null)
            if (planPrice == null)
            {
                throw new InvalidDataException("planPrice is a required property for UserPlugin and cannot be null");
            }
            else
            {
                this.PlanPrice = planPrice;
            }
            // to ensure "pluginName" is required (not null)
            if (pluginName == null)
            {
                throw new InvalidDataException("pluginName is a required property for UserPlugin and cannot be null");
            }
            else
            {
                this.PluginName = pluginName;
            }
            // to ensure "approval" is required (not null)
            if (approval == null)
            {
                throw new InvalidDataException("approval is a required property for UserPlugin and cannot be null");
            }
            else
            {
                this.Approval = approval;
            }
            // to ensure "startDate" is required (not null)
            if (startDate == null)
            {
                throw new InvalidDataException("startDate is a required property for UserPlugin and cannot be null");
            }
            else
            {
                this.StartDate = startDate;
            }
            // to ensure "paidAmount" is required (not null)
            if (paidAmount == null)
            {
                throw new InvalidDataException("paidAmount is a required property for UserPlugin and cannot be null");
            }
            else
            {
                this.PaidAmount = paidAmount;
            }
            this.Id = id;
            this.CreditCardTransactionId = creditCardTransactionId;
            this.CashBalanceLogId = cashBalanceLogId;
            this.CreditCardId = creditCardId;
            this.AccountId = accountId;
            this.EntitlementId = entitlementId;
            this.ExpirationDate = expirationDate;
            this.Autorenewal = autorenewal;
            this.PlanCategories = planCategories;
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
        /// Gets or Sets PluginName
        /// </summary>
        [DataMember(Name="pluginName", EmitDefaultValue=false)]
        public string PluginName { get; set; }

        /// <summary>
        /// Gets or Sets Approval
        /// </summary>
        [DataMember(Name="approval", EmitDefaultValue=false)]
        public bool? Approval { get; set; }

        /// <summary>
        /// Gets or Sets EntitlementId
        /// </summary>
        [DataMember(Name="entitlementId", EmitDefaultValue=false)]
        public long? EntitlementId { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public TradeDate StartDate { get; set; }

        /// <summary>
        /// Gets or Sets ExpirationDate
        /// </summary>
        [DataMember(Name="expirationDate", EmitDefaultValue=false)]
        public TradeDate ExpirationDate { get; set; }

        /// <summary>
        /// Gets or Sets PaidAmount
        /// </summary>
        [DataMember(Name="paidAmount", EmitDefaultValue=false)]
        public double? PaidAmount { get; set; }

        /// <summary>
        /// Gets or Sets Autorenewal
        /// </summary>
        [DataMember(Name="autorenewal", EmitDefaultValue=false)]
        public bool? Autorenewal { get; set; }

        /// <summary>
        /// Gets or Sets PlanCategories
        /// </summary>
        [DataMember(Name="planCategories", EmitDefaultValue=false)]
        public string PlanCategories { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserPlugin {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  PlanPrice: ").Append(PlanPrice).Append("\n");
            sb.Append("  CreditCardTransactionId: ").Append(CreditCardTransactionId).Append("\n");
            sb.Append("  CashBalanceLogId: ").Append(CashBalanceLogId).Append("\n");
            sb.Append("  CreditCardId: ").Append(CreditCardId).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  PluginName: ").Append(PluginName).Append("\n");
            sb.Append("  Approval: ").Append(Approval).Append("\n");
            sb.Append("  EntitlementId: ").Append(EntitlementId).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  PaidAmount: ").Append(PaidAmount).Append("\n");
            sb.Append("  Autorenewal: ").Append(Autorenewal).Append("\n");
            sb.Append("  PlanCategories: ").Append(PlanCategories).Append("\n");
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
            return this.Equals(input as UserPlugin);
        }

        /// <summary>
        /// Returns true if UserPlugin instances are equal
        /// </summary>
        /// <param name="input">Instance of UserPlugin to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserPlugin input)
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
                    this.PluginName == input.PluginName ||
                    (this.PluginName != null &&
                    this.PluginName.Equals(input.PluginName))
                ) && 
                (
                    this.Approval == input.Approval ||
                    (this.Approval != null &&
                    this.Approval.Equals(input.Approval))
                ) && 
                (
                    this.EntitlementId == input.EntitlementId ||
                    (this.EntitlementId != null &&
                    this.EntitlementId.Equals(input.EntitlementId))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.ExpirationDate == input.ExpirationDate ||
                    (this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(input.ExpirationDate))
                ) && 
                (
                    this.PaidAmount == input.PaidAmount ||
                    (this.PaidAmount != null &&
                    this.PaidAmount.Equals(input.PaidAmount))
                ) && 
                (
                    this.Autorenewal == input.Autorenewal ||
                    (this.Autorenewal != null &&
                    this.Autorenewal.Equals(input.Autorenewal))
                ) && 
                (
                    this.PlanCategories == input.PlanCategories ||
                    (this.PlanCategories != null &&
                    this.PlanCategories.Equals(input.PlanCategories))
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
                if (this.PluginName != null)
                    hashCode = hashCode * 59 + this.PluginName.GetHashCode();
                if (this.Approval != null)
                    hashCode = hashCode * 59 + this.Approval.GetHashCode();
                if (this.EntitlementId != null)
                    hashCode = hashCode * 59 + this.EntitlementId.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.ExpirationDate != null)
                    hashCode = hashCode * 59 + this.ExpirationDate.GetHashCode();
                if (this.PaidAmount != null)
                    hashCode = hashCode * 59 + this.PaidAmount.GetHashCode();
                if (this.Autorenewal != null)
                    hashCode = hashCode * 59 + this.Autorenewal.GetHashCode();
                if (this.PlanCategories != null)
                    hashCode = hashCode * 59 + this.PlanCategories.GetHashCode();
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
