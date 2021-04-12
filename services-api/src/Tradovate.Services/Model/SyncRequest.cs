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
    /// SyncRequest
    /// </summary>
    [DataContract]
        public partial class SyncRequest :  IEquatable<SyncRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SyncRequest" /> class.
        /// </summary>
        /// <param name="users">users.</param>
        /// <param name="accounts">accounts.</param>
        /// <param name="splitResponses">splitResponses.</param>
        public SyncRequest(List<int?> users = default(List<int?>), List<int?> accounts = default(List<int?>), bool? splitResponses = default(bool?))
        {
            this.Users = users;
            this.Accounts = accounts;
            this.SplitResponses = splitResponses;
        }
        
        /// <summary>
        /// Gets or Sets Users
        /// </summary>
        [DataMember(Name="users", EmitDefaultValue=false)]
        public List<int?> Users { get; set; }

        /// <summary>
        /// Gets or Sets Accounts
        /// </summary>
        [DataMember(Name="accounts", EmitDefaultValue=false)]
        public List<int?> Accounts { get; set; }

        /// <summary>
        /// Gets or Sets SplitResponses
        /// </summary>
        [DataMember(Name="splitResponses", EmitDefaultValue=false)]
        public bool? SplitResponses { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SyncRequest {\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
            sb.Append("  Accounts: ").Append(Accounts).Append("\n");
            sb.Append("  SplitResponses: ").Append(SplitResponses).Append("\n");
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
            return this.Equals(input as SyncRequest);
        }

        /// <summary>
        /// Returns true if SyncRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SyncRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SyncRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Users == input.Users ||
                    this.Users != null &&
                    input.Users != null &&
                    this.Users.SequenceEqual(input.Users)
                ) && 
                (
                    this.Accounts == input.Accounts ||
                    this.Accounts != null &&
                    input.Accounts != null &&
                    this.Accounts.SequenceEqual(input.Accounts)
                ) && 
                (
                    this.SplitResponses == input.SplitResponses ||
                    (this.SplitResponses != null &&
                    this.SplitResponses.Equals(input.SplitResponses))
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
                if (this.Users != null)
                    hashCode = hashCode * 59 + this.Users.GetHashCode();
                if (this.Accounts != null)
                    hashCode = hashCode * 59 + this.Accounts.GetHashCode();
                if (this.SplitResponses != null)
                    hashCode = hashCode * 59 + this.SplitResponses.GetHashCode();
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