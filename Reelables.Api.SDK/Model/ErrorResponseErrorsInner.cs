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
    /// ErrorResponseErrorsInner
    /// </summary>
    [DataContract(Name = "ErrorResponse_errors_inner")]
    public partial class ErrorResponseErrorsInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponseErrorsInner" /> class.
        /// </summary>
        /// <param name="code">An application-specific error code, expressed as a string value.</param>
        /// <param name="id">A unique identifier for this particular occurrence of the problem.</param>
        /// <param name="detail">A human-readable explanation specific to this occurrence of the problem.</param>
        /// <param name="title">A short, human-readable summary of the problem.</param>
        /// <param name="status">The HTTP status code applicable to this problem, expressed as a string value.</param>
        public ErrorResponseErrorsInner(string code = default(string), string id = default(string), string detail = default(string), string title = default(string), string status = default(string))
        {
            this.Code = code;
            this.Id = id;
            this.Detail = detail;
            this.Title = title;
            this.Status = status;
        }

        /// <summary>
        /// An application-specific error code, expressed as a string value
        /// </summary>
        /// <value>An application-specific error code, expressed as a string value</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// A unique identifier for this particular occurrence of the problem
        /// </summary>
        /// <value>A unique identifier for this particular occurrence of the problem</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// A human-readable explanation specific to this occurrence of the problem
        /// </summary>
        /// <value>A human-readable explanation specific to this occurrence of the problem</value>
        [DataMember(Name = "detail", EmitDefaultValue = false)]
        public string Detail { get; set; }

        /// <summary>
        /// A short, human-readable summary of the problem
        /// </summary>
        /// <value>A short, human-readable summary of the problem</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// The HTTP status code applicable to this problem, expressed as a string value
        /// </summary>
        /// <value>The HTTP status code applicable to this problem, expressed as a string value</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ErrorResponseErrorsInner {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Detail: ").Append(Detail).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            // Code (string) maxLength
            if (this.Code != null && this.Code.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Code, length must be less than 100.", new [] { "Code" });
            }

            if (this.Code != null) {
                // Code (string) pattern
                Regex regexCode = new Regex(@"^[a-zA-Z0-9!@#$&()\-`.+,/""]*$", RegexOptions.CultureInvariant);
                if (!regexCode.Match(this.Code).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Code, must match a pattern of " + regexCode, new [] { "Code" });
                }
            }

            // Id (string) maxLength
            if (this.Id != null && this.Id.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, length must be less than 100.", new [] { "Id" });
            }

            if (this.Id != null) {
                // Id (string) pattern
                Regex regexId = new Regex(@"^[a-zA-Z0-9!@#$&()\-`.+,/""]*$", RegexOptions.CultureInvariant);
                if (!regexId.Match(this.Id).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, must match a pattern of " + regexId, new [] { "Id" });
                }
            }

            // Detail (string) maxLength
            if (this.Detail != null && this.Detail.Length > 500)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Detail, length must be less than 500.", new [] { "Detail" });
            }

            if (this.Detail != null) {
                // Detail (string) pattern
                Regex regexDetail = new Regex(@"^[a-zA-Z0-9!@#$&()\-`.+,/"" ]*$", RegexOptions.CultureInvariant);
                if (!regexDetail.Match(this.Detail).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Detail, must match a pattern of " + regexDetail, new [] { "Detail" });
                }
            }

            // Title (string) maxLength
            if (this.Title != null && this.Title.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Title, length must be less than 100.", new [] { "Title" });
            }

            if (this.Title != null) {
                // Title (string) pattern
                Regex regexTitle = new Regex(@"^[a-zA-Z0-9!@#$&()\-`.+,/"" ]*$", RegexOptions.CultureInvariant);
                if (!regexTitle.Match(this.Title).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Title, must match a pattern of " + regexTitle, new [] { "Title" });
                }
            }

            // Status (string) maxLength
            if (this.Status != null && this.Status.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Status, length must be less than 3.", new [] { "Status" });
            }

            if (this.Status != null) {
                // Status (string) pattern
                Regex regexStatus = new Regex(@"^[0-9]*$", RegexOptions.CultureInvariant);
                if (!regexStatus.Match(this.Status).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Status, must match a pattern of " + regexStatus, new [] { "Status" });
                }
            }

            yield break;
        }
    }

}
