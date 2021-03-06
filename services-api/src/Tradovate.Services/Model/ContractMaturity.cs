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
    /// ContractMaturity
    /// </summary>
    [DataContract]
        public partial class ContractMaturity :  IEquatable<ContractMaturity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContractMaturity" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="productId">productId (required).</param>
        /// <param name="expirationMonth">expirationMonth (required).</param>
        /// <param name="expirationDate">expirationDate (required).</param>
        /// <param name="firstIntentDate">firstIntentDate.</param>
        /// <param name="underlyingId">Underlying.</param>
        /// <param name="isFront">isFront (required).</param>
        public ContractMaturity(long? id = default(long?), long? productId = default(long?), int? expirationMonth = default(int?), DateTime? expirationDate = default(DateTime?), DateTime? firstIntentDate = default(DateTime?), long? underlyingId = default(long?), bool? isFront = default(bool?))
        {
            // to ensure "productId" is required (not null)
            if (productId == null)
            {
                throw new InvalidDataException("productId is a required property for ContractMaturity and cannot be null");
            }
            else
            {
                this.ProductId = productId;
            }
            // to ensure "expirationMonth" is required (not null)
            if (expirationMonth == null)
            {
                throw new InvalidDataException("expirationMonth is a required property for ContractMaturity and cannot be null");
            }
            else
            {
                this.ExpirationMonth = expirationMonth;
            }
            // to ensure "expirationDate" is required (not null)
            if (expirationDate == null)
            {
                throw new InvalidDataException("expirationDate is a required property for ContractMaturity and cannot be null");
            }
            else
            {
                this.ExpirationDate = expirationDate;
            }
            // to ensure "isFront" is required (not null)
            if (isFront == null)
            {
                throw new InvalidDataException("isFront is a required property for ContractMaturity and cannot be null");
            }
            else
            {
                this.IsFront = isFront;
            }
            this.Id = id;
            this.FirstIntentDate = firstIntentDate;
            this.UnderlyingId = underlyingId;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets ProductId
        /// </summary>
        [DataMember(Name="productId", EmitDefaultValue=false)]
        public long? ProductId { get; set; }

        /// <summary>
        /// Gets or Sets ExpirationMonth
        /// </summary>
        [DataMember(Name="expirationMonth", EmitDefaultValue=false)]
        public int? ExpirationMonth { get; set; }

        /// <summary>
        /// Gets or Sets ExpirationDate
        /// </summary>
        [DataMember(Name="expirationDate", EmitDefaultValue=false)]
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Gets or Sets FirstIntentDate
        /// </summary>
        [DataMember(Name="firstIntentDate", EmitDefaultValue=false)]
        public DateTime? FirstIntentDate { get; set; }

        /// <summary>
        /// Underlying
        /// </summary>
        /// <value>Underlying</value>
        [DataMember(Name="underlyingId", EmitDefaultValue=false)]
        public long? UnderlyingId { get; set; }

        /// <summary>
        /// Gets or Sets IsFront
        /// </summary>
        [DataMember(Name="isFront", EmitDefaultValue=false)]
        public bool? IsFront { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContractMaturity {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  ExpirationMonth: ").Append(ExpirationMonth).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  FirstIntentDate: ").Append(FirstIntentDate).Append("\n");
            sb.Append("  UnderlyingId: ").Append(UnderlyingId).Append("\n");
            sb.Append("  IsFront: ").Append(IsFront).Append("\n");
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
            return this.Equals(input as ContractMaturity);
        }

        /// <summary>
        /// Returns true if ContractMaturity instances are equal
        /// </summary>
        /// <param name="input">Instance of ContractMaturity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContractMaturity input)
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
                    this.ProductId == input.ProductId ||
                    (this.ProductId != null &&
                    this.ProductId.Equals(input.ProductId))
                ) && 
                (
                    this.ExpirationMonth == input.ExpirationMonth ||
                    (this.ExpirationMonth != null &&
                    this.ExpirationMonth.Equals(input.ExpirationMonth))
                ) && 
                (
                    this.ExpirationDate == input.ExpirationDate ||
                    (this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(input.ExpirationDate))
                ) && 
                (
                    this.FirstIntentDate == input.FirstIntentDate ||
                    (this.FirstIntentDate != null &&
                    this.FirstIntentDate.Equals(input.FirstIntentDate))
                ) && 
                (
                    this.UnderlyingId == input.UnderlyingId ||
                    (this.UnderlyingId != null &&
                    this.UnderlyingId.Equals(input.UnderlyingId))
                ) && 
                (
                    this.IsFront == input.IsFront ||
                    (this.IsFront != null &&
                    this.IsFront.Equals(input.IsFront))
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
                if (this.ProductId != null)
                    hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.ExpirationMonth != null)
                    hashCode = hashCode * 59 + this.ExpirationMonth.GetHashCode();
                if (this.ExpirationDate != null)
                    hashCode = hashCode * 59 + this.ExpirationDate.GetHashCode();
                if (this.FirstIntentDate != null)
                    hashCode = hashCode * 59 + this.FirstIntentDate.GetHashCode();
                if (this.UnderlyingId != null)
                    hashCode = hashCode * 59 + this.UnderlyingId.GetHashCode();
                if (this.IsFront != null)
                    hashCode = hashCode * 59 + this.IsFront.GetHashCode();
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
