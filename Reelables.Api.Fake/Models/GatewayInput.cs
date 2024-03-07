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
    public partial class GatewayInput : IEquatable<GatewayInput>
    {
        /// <summary>
        /// Indicate whether the Gateway is statically located
        /// </summary>
        /// <value>Indicate whether the Gateway is statically located</value>
        [DataMember(Name="isStatic", EmitDefaultValue=true)]
        public bool IsStatic { get; set; }

        /// <summary>
        /// Latitude value of the coordinate. Example: 51.123
        /// </summary>
        /// <value>Latitude value of the coordinate. Example: 51.123</value>
        [Range(-90, 90)]
        [DataMember(Name="latitude", EmitDefaultValue=true)]
        public float Latitude { get; set; }

        /// <summary>
        /// Gets or Sets RssiFilter
        /// </summary>
        [DataMember(Name="rssiFilter", EmitDefaultValue=false)]
        public SpaceGatewayRssiFilter RssiFilter { get; set; }

        /// <summary>
        /// Longitude value of the coordinate. Example: -0.123
        /// </summary>
        /// <value>Longitude value of the coordinate. Example: -0.123</value>
        [Range(-180, 180)]
        [DataMember(Name="longitude", EmitDefaultValue=true)]
        public float Longitude { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GatewayInput {\n");
            sb.Append("  IsStatic: ").Append(IsStatic).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  RssiFilter: ").Append(RssiFilter).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
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
            return obj.GetType() == GetType() && Equals((GatewayInput)obj);
        }

        /// <summary>
        /// Returns true if GatewayInput instances are equal
        /// </summary>
        /// <param name="other">Instance of GatewayInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GatewayInput other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    IsStatic == other.IsStatic ||
                    
                    IsStatic.Equals(other.IsStatic)
                ) && 
                (
                    Latitude == other.Latitude ||
                    
                    Latitude.Equals(other.Latitude)
                ) && 
                (
                    RssiFilter == other.RssiFilter ||
                    RssiFilter != null &&
                    RssiFilter.Equals(other.RssiFilter)
                ) && 
                (
                    Longitude == other.Longitude ||
                    
                    Longitude.Equals(other.Longitude)
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
                    
                    hashCode = hashCode * 59 + IsStatic.GetHashCode();
                    
                    hashCode = hashCode * 59 + Latitude.GetHashCode();
                    if (RssiFilter != null)
                    hashCode = hashCode * 59 + RssiFilter.GetHashCode();
                    
                    hashCode = hashCode * 59 + Longitude.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(GatewayInput left, GatewayInput right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(GatewayInput left, GatewayInput right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
