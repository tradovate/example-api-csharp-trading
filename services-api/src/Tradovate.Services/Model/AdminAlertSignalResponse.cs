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
    /// AdminAlertSignalResponse
    /// </summary>
    [DataContract]
        public partial class AdminAlertSignalResponse :  IEquatable<AdminAlertSignalResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdminAlertSignalResponse" /> class.
        /// </summary>
        /// <param name="errorText">Non-empty if the request failed.</param>
        /// <param name="adminAlertSignal">adminAlertSignal.</param>
        public AdminAlertSignalResponse(string errorText = default(string), AdminAlertSignal adminAlertSignal = default(AdminAlertSignal))
        {
            this.ErrorText = errorText;
            this.AdminAlertSignal = adminAlertSignal;
        }
        
        /// <summary>
        /// Non-empty if the request failed
        /// </summary>
        /// <value>Non-empty if the request failed</value>
        [DataMember(Name="errorText", EmitDefaultValue=false)]
        public string ErrorText { get; set; }

        /// <summary>
        /// Gets or Sets AdminAlertSignal
        /// </summary>
        [DataMember(Name="adminAlertSignal", EmitDefaultValue=false)]
        public AdminAlertSignal AdminAlertSignal { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdminAlertSignalResponse {\n");
            sb.Append("  ErrorText: ").Append(ErrorText).Append("\n");
            sb.Append("  AdminAlertSignal: ").Append(AdminAlertSignal).Append("\n");
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
            return this.Equals(input as AdminAlertSignalResponse);
        }

        /// <summary>
        /// Returns true if AdminAlertSignalResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AdminAlertSignalResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdminAlertSignalResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ErrorText == input.ErrorText ||
                    (this.ErrorText != null &&
                    this.ErrorText.Equals(input.ErrorText))
                ) && 
                (
                    this.AdminAlertSignal == input.AdminAlertSignal ||
                    (this.AdminAlertSignal != null &&
                    this.AdminAlertSignal.Equals(input.AdminAlertSignal))
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
                if (this.ErrorText != null)
                    hashCode = hashCode * 59 + this.ErrorText.GetHashCode();
                if (this.AdminAlertSignal != null)
                    hashCode = hashCode * 59 + this.AdminAlertSignal.GetHashCode();
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
