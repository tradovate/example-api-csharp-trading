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
    /// Entitlement
    /// </summary>
    [DataContract]
        public partial class Entitlement :  IEquatable<Entitlement>, IValidatableObject
    {
        /// <summary>
        /// Month, Quarter, Week, Year
        /// </summary>
        /// <value>Month, Quarter, Week, Year</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum DurationUnitsEnum
        {
            /// <summary>
            /// Enum Month for value: Month
            /// </summary>
            [EnumMember(Value = "Month")]
            Month = 1,
            /// <summary>
            /// Enum Quarter for value: Quarter
            /// </summary>
            [EnumMember(Value = "Quarter")]
            Quarter = 2,
            /// <summary>
            /// Enum Week for value: Week
            /// </summary>
            [EnumMember(Value = "Week")]
            Week = 3,
            /// <summary>
            /// Enum Year for value: Year
            /// </summary>
            [EnumMember(Value = "Year")]
            Year = 4        }
        /// <summary>
        /// Month, Quarter, Week, Year
        /// </summary>
        /// <value>Month, Quarter, Week, Year</value>
        [DataMember(Name="durationUnits", EmitDefaultValue=false)]
        public DurationUnitsEnum? DurationUnits { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Entitlement" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="title">title (required).</param>
        /// <param name="price">price (required).</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="discontinuedDate">discontinuedDate.</param>
        /// <param name="name">name (required).</param>
        /// <param name="duration">duration.</param>
        /// <param name="durationUnits">Month, Quarter, Week, Year.</param>
        /// <param name="autorenewal">autorenewal.</param>
        public Entitlement(long? id = default(long?), string title = default(string), double? price = default(double?), TradeDate startDate = default(TradeDate), TradeDate discontinuedDate = default(TradeDate), string name = default(string), int? duration = default(int?), DurationUnitsEnum? durationUnits = default(DurationUnitsEnum?), bool? autorenewal = default(bool?))
        {
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new InvalidDataException("title is a required property for Entitlement and cannot be null");
            }
            else
            {
                this.Title = title;
            }
            // to ensure "price" is required (not null)
            if (price == null)
            {
                throw new InvalidDataException("price is a required property for Entitlement and cannot be null");
            }
            else
            {
                this.Price = price;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Entitlement and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            this.Id = id;
            this.StartDate = startDate;
            this.DiscontinuedDate = discontinuedDate;
            this.Duration = duration;
            this.DurationUnits = durationUnits;
            this.Autorenewal = autorenewal;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public double? Price { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public TradeDate StartDate { get; set; }

        /// <summary>
        /// Gets or Sets DiscontinuedDate
        /// </summary>
        [DataMember(Name="discontinuedDate", EmitDefaultValue=false)]
        public TradeDate DiscontinuedDate { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Duration
        /// </summary>
        [DataMember(Name="duration", EmitDefaultValue=false)]
        public int? Duration { get; set; }


        /// <summary>
        /// Gets or Sets Autorenewal
        /// </summary>
        [DataMember(Name="autorenewal", EmitDefaultValue=false)]
        public bool? Autorenewal { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Entitlement {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  DiscontinuedDate: ").Append(DiscontinuedDate).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  DurationUnits: ").Append(DurationUnits).Append("\n");
            sb.Append("  Autorenewal: ").Append(Autorenewal).Append("\n");
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
            return this.Equals(input as Entitlement);
        }

        /// <summary>
        /// Returns true if Entitlement instances are equal
        /// </summary>
        /// <param name="input">Instance of Entitlement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Entitlement input)
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
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.DiscontinuedDate == input.DiscontinuedDate ||
                    (this.DiscontinuedDate != null &&
                    this.DiscontinuedDate.Equals(input.DiscontinuedDate))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
                ) && 
                (
                    this.DurationUnits == input.DurationUnits ||
                    (this.DurationUnits != null &&
                    this.DurationUnits.Equals(input.DurationUnits))
                ) && 
                (
                    this.Autorenewal == input.Autorenewal ||
                    (this.Autorenewal != null &&
                    this.Autorenewal.Equals(input.Autorenewal))
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
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.DiscontinuedDate != null)
                    hashCode = hashCode * 59 + this.DiscontinuedDate.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Duration != null)
                    hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.DurationUnits != null)
                    hashCode = hashCode * 59 + this.DurationUnits.GetHashCode();
                if (this.Autorenewal != null)
                    hashCode = hashCode * 59 + this.Autorenewal.GetHashCode();
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
