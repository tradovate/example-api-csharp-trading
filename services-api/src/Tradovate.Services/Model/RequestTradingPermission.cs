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
    /// RequestTradingPermission
    /// </summary>
    [DataContract]
        public partial class RequestTradingPermission :  IEquatable<RequestTradingPermission>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestTradingPermission" /> class.
        /// </summary>
        /// <param name="accountId">accountId (required).</param>
        /// <param name="ctaContact">ctaContact (required).</param>
        /// <param name="ctaEmail">ctaEmail (required).</param>
        public RequestTradingPermission(long? accountId = default(long?), string ctaContact = default(string), string ctaEmail = default(string))
        {
            // to ensure "accountId" is required (not null)
            if (accountId == null)
            {
                throw new InvalidDataException("accountId is a required property for RequestTradingPermission and cannot be null");
            }
            else
            {
                this.AccountId = accountId;
            }
            // to ensure "ctaContact" is required (not null)
            if (ctaContact == null)
            {
                throw new InvalidDataException("ctaContact is a required property for RequestTradingPermission and cannot be null");
            }
            else
            {
                this.CtaContact = ctaContact;
            }
            // to ensure "ctaEmail" is required (not null)
            if (ctaEmail == null)
            {
                throw new InvalidDataException("ctaEmail is a required property for RequestTradingPermission and cannot be null");
            }
            else
            {
                this.CtaEmail = ctaEmail;
            }
        }
        
        /// <summary>
        /// Gets or Sets AccountId
        /// </summary>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public long? AccountId { get; set; }

        /// <summary>
        /// Gets or Sets CtaContact
        /// </summary>
        [DataMember(Name="ctaContact", EmitDefaultValue=false)]
        public string CtaContact { get; set; }

        /// <summary>
        /// Gets or Sets CtaEmail
        /// </summary>
        [DataMember(Name="ctaEmail", EmitDefaultValue=false)]
        public string CtaEmail { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RequestTradingPermission {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  CtaContact: ").Append(CtaContact).Append("\n");
            sb.Append("  CtaEmail: ").Append(CtaEmail).Append("\n");
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
            return this.Equals(input as RequestTradingPermission);
        }

        /// <summary>
        /// Returns true if RequestTradingPermission instances are equal
        /// </summary>
        /// <param name="input">Instance of RequestTradingPermission to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RequestTradingPermission input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.CtaContact == input.CtaContact ||
                    (this.CtaContact != null &&
                    this.CtaContact.Equals(input.CtaContact))
                ) && 
                (
                    this.CtaEmail == input.CtaEmail ||
                    (this.CtaEmail != null &&
                    this.CtaEmail.Equals(input.CtaEmail))
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
                if (this.AccountId != null)
                    hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.CtaContact != null)
                    hashCode = hashCode * 59 + this.CtaContact.GetHashCode();
                if (this.CtaEmail != null)
                    hashCode = hashCode * 59 + this.CtaEmail.GetHashCode();
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
