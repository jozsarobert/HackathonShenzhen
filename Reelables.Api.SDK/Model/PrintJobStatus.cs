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
    /// PrintJobStatus
    /// </summary>
    [DataContract(Name = "PrintJobStatus")]
    public partial class PrintJobStatus : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrintJobStatus" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PrintJobStatus() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PrintJobStatus" /> class.
        /// </summary>
        /// <param name="createdAt">Date that the Print Job status was created, in UTC. Example: &#39;2019-07-21T17:32:28Z&#39; (required).</param>
        /// <param name="status">The status of the Print Job (required).</param>
        public PrintJobStatus(DateTime createdAt = default(DateTime), string status = default(string))
        {
            this.CreatedAt = createdAt;
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new ArgumentNullException("status is a required property for PrintJobStatus and cannot be null");
            }
            this.Status = status;
        }

        /// <summary>
        /// Date that the Print Job status was created, in UTC. Example: &#39;2019-07-21T17:32:28Z&#39;
        /// </summary>
        /// <value>Date that the Print Job status was created, in UTC. Example: &#39;2019-07-21T17:32:28Z&#39;</value>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// The status of the Print Job
        /// </summary>
        /// <value>The status of the Print Job</value>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PrintJobStatus {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            // CreatedAt (DateTime) maxLength
            if (this.CreatedAt != null && this.CreatedAt.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CreatedAt, length must be less than 20.", new [] { "CreatedAt" });
            }

            if (this.CreatedAt != null) {
                // CreatedAt (DateTime) pattern
                Regex regexCreatedAt = new Regex(@"^[0-9TZ:-]*$", RegexOptions.CultureInvariant);
                if (!regexCreatedAt.Match(this.CreatedAt).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CreatedAt, must match a pattern of " + regexCreatedAt, new [] { "CreatedAt" });
                }
            }

            // Status (string) maxLength
            if (this.Status != null && this.Status.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Status, length must be less than 100.", new [] { "Status" });
            }

            if (this.Status != null) {
                // Status (string) pattern
                Regex regexStatus = new Regex(@"^[a-zA-Z0-9!@#$&()\-`.+,/"" ]*$", RegexOptions.CultureInvariant);
                if (!regexStatus.Match(this.Status).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Status, must match a pattern of " + regexStatus, new [] { "Status" });
                }
            }

            yield break;
        }
    }

}
