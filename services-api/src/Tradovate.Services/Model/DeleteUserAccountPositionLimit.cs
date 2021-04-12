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
    /// DeleteUserAccountPositionLimit
    /// </summary>
    [DataContract]
        public partial class DeleteUserAccountPositionLimit :  IEquatable<DeleteUserAccountPositionLimit>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteUserAccountPositionLimit" /> class.
        /// </summary>
        /// <param name="userAccountPositionLimitId">userAccountPositionLimitId (required).</param>
        public DeleteUserAccountPositionLimit(long? userAccountPositionLimitId = default(long?))
        {
            // to ensure "userAccountPositionLimitId" is required (not null)
            if (userAccountPositionLimitId == null)
            {
                throw new InvalidDataException("userAccountPositionLimitId is a required property for DeleteUserAccountPositionLimit and cannot be null");
            }
            else
            {
                this.UserAccountPositionLimitId = userAccountPositionLimitId;
            }
        }
        
        /// <summary>
        /// Gets or Sets UserAccountPositionLimitId
        /// </summary>
        [DataMember(Name="userAccountPositionLimitId", EmitDefaultValue=false)]
        public long? UserAccountPositionLimitId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteUserAccountPositionLimit {\n");
            sb.Append("  UserAccountPositionLimitId: ").Append(UserAccountPositionLimitId).Append("\n");
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
            return this.Equals(input as DeleteUserAccountPositionLimit);
        }

        /// <summary>
        /// Returns true if DeleteUserAccountPositionLimit instances are equal
        /// </summary>
        /// <param name="input">Instance of DeleteUserAccountPositionLimit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeleteUserAccountPositionLimit input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserAccountPositionLimitId == input.UserAccountPositionLimitId ||
                    (this.UserAccountPositionLimitId != null &&
                    this.UserAccountPositionLimitId.Equals(input.UserAccountPositionLimitId))
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
                if (this.UserAccountPositionLimitId != null)
                    hashCode = hashCode * 59 + this.UserAccountPositionLimitId.GetHashCode();
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