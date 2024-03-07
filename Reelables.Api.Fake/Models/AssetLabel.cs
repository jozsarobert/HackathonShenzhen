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
    public partial class AssetLabel : IEquatable<AssetLabel>
    {
        /// <summary>
        /// Label BLE identifier. Example: 123
        /// </summary>
        /// <value>Label BLE identifier. Example: 123</value>
        [Required]
        [Range(0, 2147483647)]
        [DataMember(Name="bleId", EmitDefaultValue=true)]
        public int BleId { get; set; }

        /// <summary>
        /// Label NFC identifier. Example: &#39;0000007B&#39;
        /// </summary>
        /// <value>Label NFC identifier. Example: &#39;0000007B&#39;</value>
        [Required]
        [RegularExpression("^[a-zA-Z0-9]*$")]
        [MaxLength(20)]
        [DataMember(Name="nfcId", EmitDefaultValue=false)]
        public string NfcId { get; set; }

        /// <summary>
        /// Date that the Label was linked to the Asset, in UTC. Example: &#39;2019-07-21T17:32:28Z&#39;
        /// </summary>
        /// <value>Date that the Label was linked to the Asset, in UTC. Example: &#39;2019-07-21T17:32:28Z&#39;</value>
        [Required]
        [RegularExpression("^[0-9TZ:-]*$")]
        [MaxLength(20)]
        [DataMember(Name="addedOn", EmitDefaultValue=false)]
        public DateTime AddedOn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssetLabel {\n");
            sb.Append("  BleId: ").Append(BleId).Append("\n");
            sb.Append("  NfcId: ").Append(NfcId).Append("\n");
            sb.Append("  AddedOn: ").Append(AddedOn).Append("\n");
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
            return obj.GetType() == GetType() && Equals((AssetLabel)obj);
        }

        /// <summary>
        /// Returns true if AssetLabel instances are equal
        /// </summary>
        /// <param name="other">Instance of AssetLabel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssetLabel other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    BleId == other.BleId ||
                    
                    BleId.Equals(other.BleId)
                ) && 
                (
                    NfcId == other.NfcId ||
                    NfcId != null &&
                    NfcId.Equals(other.NfcId)
                ) && 
                (
                    AddedOn == other.AddedOn ||
                    AddedOn != null &&
                    AddedOn.Equals(other.AddedOn)
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
                    
                    hashCode = hashCode * 59 + BleId.GetHashCode();
                    if (NfcId != null)
                    hashCode = hashCode * 59 + NfcId.GetHashCode();
                    if (AddedOn != null)
                    hashCode = hashCode * 59 + AddedOn.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(AssetLabel left, AssetLabel right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AssetLabel left, AssetLabel right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
