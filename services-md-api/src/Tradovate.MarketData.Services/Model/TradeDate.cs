/* 
 * Tradovate MarketData API
 *
 * Tradovate MarketData API provides an access to the complete set of Tradovate market data functionality.
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
using SwaggerDateConverter = Tradovate.MarketData.Services.Client.SwaggerDateConverter;

namespace Tradovate.MarketData.Services.Model
{
    /// <summary>
    /// TradeDate
    /// </summary>
    [DataContract]
        public partial class TradeDate :  IEquatable<TradeDate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TradeDate" /> class.
        /// </summary>
        /// <param name="year">year (required).</param>
        /// <param name="month">month (required).</param>
        /// <param name="day">day (required).</param>
        public TradeDate(int? year = default(int?), int? month = default(int?), int? day = default(int?))
        {
            // to ensure "year" is required (not null)
            if (year == null)
            {
                throw new InvalidDataException("year is a required property for TradeDate and cannot be null");
            }
            else
            {
                this.Year = year;
            }
            // to ensure "month" is required (not null)
            if (month == null)
            {
                throw new InvalidDataException("month is a required property for TradeDate and cannot be null");
            }
            else
            {
                this.Month = month;
            }
            // to ensure "day" is required (not null)
            if (day == null)
            {
                throw new InvalidDataException("day is a required property for TradeDate and cannot be null");
            }
            else
            {
                this.Day = day;
            }
        }
        
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
        /// Gets or Sets Day
        /// </summary>
        [DataMember(Name="day", EmitDefaultValue=false)]
        public int? Day { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TradeDate {\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  Month: ").Append(Month).Append("\n");
            sb.Append("  Day: ").Append(Day).Append("\n");
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
            return this.Equals(input as TradeDate);
        }

        /// <summary>
        /// Returns true if TradeDate instances are equal
        /// </summary>
        /// <param name="input">Instance of TradeDate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TradeDate input)
        {
            if (input == null)
                return false;

            return 
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
                    this.Day == input.Day ||
                    (this.Day != null &&
                    this.Day.Equals(input.Day))
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
                if (this.Year != null)
                    hashCode = hashCode * 59 + this.Year.GetHashCode();
                if (this.Month != null)
                    hashCode = hashCode * 59 + this.Month.GetHashCode();
                if (this.Day != null)
                    hashCode = hashCode * 59 + this.Day.GetHashCode();
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
