/*
 * Reelables API
 *
 * RESTful API for communicating with the Reelables Platform.
 *
 * The version of the OpenAPI document: 1.2.7
 * Contact: team@reelables.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Location
    /// </summary>
    [DataContract(Name = "Location")]
    public partial class Location : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Location" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Location() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Location" /> class.
        /// </summary>
        /// <param name="coordinate">coordinate (required).</param>
        /// <param name="error">The horrizontal error in metres.</param>
        /// <param name="timestamp">Timestamp of the location. Example: &#39;2019-07-21T17:32:28Z&#39; (required).</param>
        public Location(Coordinate coordinate = default(Coordinate), int error = default(int), DateTime timestamp = default(DateTime))
        {
            // to ensure "coordinate" is required (not null)
            if (coordinate == null)
            {
                throw new ArgumentNullException("coordinate is a required property for Location and cannot be null");
            }
            this.Coordinate = coordinate;
            this.Timestamp = timestamp;
            this.Error = error;
        }

        /// <summary>
        /// Gets or Sets Coordinate
        /// </summary>
        [DataMember(Name = "coordinate", IsRequired = true, EmitDefaultValue = true)]
        public Coordinate Coordinate { get; set; }

        /// <summary>
        /// The horrizontal error in metres
        /// </summary>
        /// <value>The horrizontal error in metres</value>
        [DataMember(Name = "error", EmitDefaultValue = false)]
        public int Error { get; set; }

        /// <summary>
        /// Timestamp of the location. Example: &#39;2019-07-21T17:32:28Z&#39;
        /// </summary>
        /// <value>Timestamp of the location. Example: &#39;2019-07-21T17:32:28Z&#39;</value>
        [DataMember(Name = "timestamp", IsRequired = true, EmitDefaultValue = true)]
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Location {\n");
            sb.Append("  Coordinate: ").Append(Coordinate).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Error (int) maximum
            if (this.Error > (int)1000000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Error, must be a value less than or equal to 1000000.", new [] { "Error" });
            }

            // Error (int) minimum
            if (this.Error < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Error, must be a value greater than or equal to 0.", new [] { "Error" });
            }

            // Timestamp (DateTime) maxLength
            if (this.Timestamp != null && this.Timestamp.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Timestamp, length must be less than 20.", new [] { "Timestamp" });
            }

            if (this.Timestamp != null) {
                // Timestamp (DateTime) pattern
                Regex regexTimestamp = new Regex(@"^[0-9TZ:-]*$", RegexOptions.CultureInvariant);
                if (!regexTimestamp.Match(this.Timestamp).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Timestamp, must match a pattern of " + regexTimestamp, new [] { "Timestamp" });
                }
            }

            yield break;
        }
    }

}
