/*
 * Reelables API
 *
 * RESTful API for communicating with the Reelables Platform.
 *
 * The version of the OpenAPI document: 1.2.7
 * Contact: team@reelables.com
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Org.OpenAPITools.Converters;

namespace Org.OpenAPITools.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class Workspaces : IEquatable<Workspaces>
    {
        /// <summary>
        /// Pagination token
        /// </summary>
        /// <value>Pagination token</value>
        [RegularExpression("^[a-zA-Z0-9!@#$&()\\-`.+,/\"]*$")]
        [MaxLength(5000)]
        [DataMember(Name="nextToken", EmitDefaultValue=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [Required]
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<Workspace> Items { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Workspaces {\n");
            sb.Append("  NextToken: ").Append(NextToken).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((Workspaces)obj);
        }

        /// <summary>
        /// Returns true if Workspaces instances are equal
        /// </summary>
        /// <param name="other">Instance of Workspaces to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Workspaces other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    NextToken == other.NextToken ||
                    NextToken != null &&
                    NextToken.Equals(other.NextToken)
                ) && 
                (
                    Items == other.Items ||
                    Items != null &&
                    other.Items != null &&
                    Items.SequenceEqual(other.Items)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (NextToken != null)
                    hashCode = hashCode * 59 + NextToken.GetHashCode();
                    if (Items != null)
                    hashCode = hashCode * 59 + Items.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Workspaces left, Workspaces right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Workspaces left, Workspaces right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
