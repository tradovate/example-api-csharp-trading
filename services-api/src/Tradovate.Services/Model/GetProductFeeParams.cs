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
    /// GetProductFeeParams
    /// </summary>
    [DataContract]
        public partial class GetProductFeeParams :  IEquatable<GetProductFeeParams>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetProductFeeParams" /> class.
        /// </summary>
        /// <param name="productIds">productIds (required).</param>
        public GetProductFeeParams(List<int?> productIds = default(List<int?>))
        {
            // to ensure "productIds" is required (not null)
            if (productIds == null)
            {
                throw new InvalidDataException("productIds is a required property for GetProductFeeParams and cannot be null");
            }
            else
            {
                this.ProductIds = productIds;
            }
        }
        
        /// <summary>
        /// Gets or Sets ProductIds
        /// </summary>
        [DataMember(Name="productIds", EmitDefaultValue=false)]
        public List<int?> ProductIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetProductFeeParams {\n");
            sb.Append("  ProductIds: ").Append(ProductIds).Append("\n");
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
            return this.Equals(input as GetProductFeeParams);
        }

        /// <summary>
        /// Returns true if GetProductFeeParams instances are equal
        /// </summary>
        /// <param name="input">Instance of GetProductFeeParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetProductFeeParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProductIds == input.ProductIds ||
                    this.ProductIds != null &&
                    input.ProductIds != null &&
                    this.ProductIds.SequenceEqual(input.ProductIds)
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
                if (this.ProductIds != null)
                    hashCode = hashCode * 59 + this.ProductIds.GetHashCode();
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
