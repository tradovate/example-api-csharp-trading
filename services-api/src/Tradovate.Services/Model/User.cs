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
    /// User
    /// </summary>
    [DataContract]
        public partial class User :  IEquatable<User>, IValidatableObject
    {
        /// <summary>
        /// Active, Closed, Initiated, TemporaryLocked, UnconfirmedEmail
        /// </summary>
        /// <value>Active, Closed, Initiated, TemporaryLocked, UnconfirmedEmail</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum StatusEnum
        {
            /// <summary>
            /// Enum Active for value: Active
            /// </summary>
            [EnumMember(Value = "Active")]
            Active = 1,
            /// <summary>
            /// Enum Closed for value: Closed
            /// </summary>
            [EnumMember(Value = "Closed")]
            Closed = 2,
            /// <summary>
            /// Enum Initiated for value: Initiated
            /// </summary>
            [EnumMember(Value = "Initiated")]
            Initiated = 3,
            /// <summary>
            /// Enum TemporaryLocked for value: TemporaryLocked
            /// </summary>
            [EnumMember(Value = "TemporaryLocked")]
            TemporaryLocked = 4,
            /// <summary>
            /// Enum UnconfirmedEmail for value: UnconfirmedEmail
            /// </summary>
            [EnumMember(Value = "UnconfirmedEmail")]
            UnconfirmedEmail = 5        }
        /// <summary>
        /// Active, Closed, Initiated, TemporaryLocked, UnconfirmedEmail
        /// </summary>
        /// <value>Active, Closed, Initiated, TemporaryLocked, UnconfirmedEmail</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name (required).</param>
        /// <param name="timestamp">timestamp (required).</param>
        /// <param name="email">email (required).</param>
        /// <param name="status">Active, Closed, Initiated, TemporaryLocked, UnconfirmedEmail (required).</param>
        /// <param name="professional">professional (required).</param>
        /// <param name="organizationId">organizationId.</param>
        /// <param name="linkedUserId">Linked Live.</param>
        /// <param name="foreignIntroducingBrokerId">foreignIntroducingBrokerId.</param>
        public User(long? id = default(long?), string name = default(string), DateTime? timestamp = default(DateTime?), string email = default(string), StatusEnum status = default(StatusEnum), bool? professional = default(bool?), long? organizationId = default(long?), long? linkedUserId = default(long?), long? foreignIntroducingBrokerId = default(long?))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for User and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "timestamp" is required (not null)
            if (timestamp == null)
            {
                throw new InvalidDataException("timestamp is a required property for User and cannot be null");
            }
            else
            {
                this.Timestamp = timestamp;
            }
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new InvalidDataException("email is a required property for User and cannot be null");
            }
            else
            {
                this.Email = email;
            }
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for User and cannot be null");
            }
            else
            {
                this.Status = status;
            }
            // to ensure "professional" is required (not null)
            if (professional == null)
            {
                throw new InvalidDataException("professional is a required property for User and cannot be null");
            }
            else
            {
                this.Professional = professional;
            }
            this.Id = id;
            this.OrganizationId = organizationId;
            this.LinkedUserId = linkedUserId;
            this.ForeignIntroducingBrokerId = foreignIntroducingBrokerId;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }


        /// <summary>
        /// Gets or Sets Professional
        /// </summary>
        [DataMember(Name="professional", EmitDefaultValue=false)]
        public bool? Professional { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationId
        /// </summary>
        [DataMember(Name="organizationId", EmitDefaultValue=false)]
        public long? OrganizationId { get; set; }

        /// <summary>
        /// Linked Live
        /// </summary>
        /// <value>Linked Live</value>
        [DataMember(Name="linkedUserId", EmitDefaultValue=false)]
        public long? LinkedUserId { get; set; }

        /// <summary>
        /// Gets or Sets ForeignIntroducingBrokerId
        /// </summary>
        [DataMember(Name="foreignIntroducingBrokerId", EmitDefaultValue=false)]
        public long? ForeignIntroducingBrokerId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class User {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Professional: ").Append(Professional).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  LinkedUserId: ").Append(LinkedUserId).Append("\n");
            sb.Append("  ForeignIntroducingBrokerId: ").Append(ForeignIntroducingBrokerId).Append("\n");
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
            return this.Equals(input as User);
        }

        /// <summary>
        /// Returns true if User instances are equal
        /// </summary>
        /// <param name="input">Instance of User to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(User input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Professional == input.Professional ||
                    (this.Professional != null &&
                    this.Professional.Equals(input.Professional))
                ) && 
                (
                    this.OrganizationId == input.OrganizationId ||
                    (this.OrganizationId != null &&
                    this.OrganizationId.Equals(input.OrganizationId))
                ) && 
                (
                    this.LinkedUserId == input.LinkedUserId ||
                    (this.LinkedUserId != null &&
                    this.LinkedUserId.Equals(input.LinkedUserId))
                ) && 
                (
                    this.ForeignIntroducingBrokerId == input.ForeignIntroducingBrokerId ||
                    (this.ForeignIntroducingBrokerId != null &&
                    this.ForeignIntroducingBrokerId.Equals(input.ForeignIntroducingBrokerId))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Professional != null)
                    hashCode = hashCode * 59 + this.Professional.GetHashCode();
                if (this.OrganizationId != null)
                    hashCode = hashCode * 59 + this.OrganizationId.GetHashCode();
                if (this.LinkedUserId != null)
                    hashCode = hashCode * 59 + this.LinkedUserId.GetHashCode();
                if (this.ForeignIntroducingBrokerId != null)
                    hashCode = hashCode * 59 + this.ForeignIntroducingBrokerId.GetHashCode();
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