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
    public partial class AssetGroup : IEquatable<AssetGroup>
    {
        /// <summary>
        /// Unique identifier of the Facility. Example: &#39;d290f1ee-6c54-4b01-90e6-d701748f0851&#39;
        /// </summary>
        /// <value>Unique identifier of the Facility. Example: &#39;d290f1ee-6c54-4b01-90e6-d701748f0851&#39;</value>
        [RegularExpression("^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}$")]
        [MaxLength(36)]
        [DataMember(Name="facilityId", EmitDefaultValue=false)]
        public Guid FacilityId { get; set; }

        /// <summary>
        /// Number of Assets that need to be present for the Asset Group to be deemed available. Default 3
        /// </summary>
        /// <value>Number of Assets that need to be present for the Asset Group to be deemed available. Default 3</value>
        [Range(1, 2147483647)]
        [DataMember(Name="availabilityThreshold", EmitDefaultValue=true)]
        public int AvailabilityThreshold { get; set; }

        /// <summary>
        /// The name of the Asset Group. Example: &#39;an-asset-group
        /// </summary>
        /// <value>The name of the Asset Group. Example: &#39;an-asset-group</value>
        [Required]
        [RegularExpression("^[a-zA-Z0-9!@#$&()\\-`.+,/\" ]*$")]
        [MaxLength(500)]
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Indicate whether the Asset Group is deemed to be available (see availabilityThreshold property)
        /// </summary>
        /// <value>Indicate whether the Asset Group is deemed to be available (see availabilityThreshold property)</value>
        [DataMember(Name="available", EmitDefaultValue=true)]
        public bool Available { get; set; }

        /// <summary>
        /// Number of Assets currently available. Example: 102
        /// </summary>
        /// <value>Number of Assets currently available. Example: 102</value>
        [Range(0, 2147483647)]
        [DataMember(Name="count", EmitDefaultValue=true)]
        public int Count { get; set; }

        /// <summary>
        /// Unique identifier of the Asset Group. Example: &#39;an-asset-group&#39;
        /// </summary>
        /// <value>Unique identifier of the Asset Group. Example: &#39;an-asset-group&#39;</value>
        [Required]
        [RegularExpression("^[a-zA-Z0-9!@#$&()\\-`.+,/\" ]*$")]
        [MaxLength(500)]
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Unique identifier of the Workspace. Example: &#39;d290f1ee-6c54-4b01-90e6-d701748f0851&#39;
        /// </summary>
        /// <value>Unique identifier of the Workspace. Example: &#39;d290f1ee-6c54-4b01-90e6-d701748f0851&#39;</value>
        [Required]
        [RegularExpression("^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}$")]
        [MaxLength(36)]
        [DataMember(Name="workspaceId", EmitDefaultValue=false)]
        public Guid WorkspaceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssetGroup {\n");
            sb.Append("  FacilityId: ").Append(FacilityId).Append("\n");
            sb.Append("  AvailabilityThreshold: ").Append(AvailabilityThreshold).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Available: ").Append(Available).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  WorkspaceId: ").Append(WorkspaceId).Append("\n");
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
            return obj.GetType() == GetType() && Equals((AssetGroup)obj);
        }

        /// <summary>
        /// Returns true if AssetGroup instances are equal
        /// </summary>
        /// <param name="other">Instance of AssetGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssetGroup other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    FacilityId == other.FacilityId ||
                    FacilityId != null &&
                    FacilityId.Equals(other.FacilityId)
                ) && 
                (
                    AvailabilityThreshold == other.AvailabilityThreshold ||
                    
                    AvailabilityThreshold.Equals(other.AvailabilityThreshold)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Available == other.Available ||
                    
                    Available.Equals(other.Available)
                ) && 
                (
                    Count == other.Count ||
                    
                    Count.Equals(other.Count)
                ) && 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    WorkspaceId == other.WorkspaceId ||
                    WorkspaceId != null &&
                    WorkspaceId.Equals(other.WorkspaceId)
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
                    if (FacilityId != null)
                    hashCode = hashCode * 59 + FacilityId.GetHashCode();
                    
                    hashCode = hashCode * 59 + AvailabilityThreshold.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    
                    hashCode = hashCode * 59 + Available.GetHashCode();
                    
                    hashCode = hashCode * 59 + Count.GetHashCode();
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (WorkspaceId != null)
                    hashCode = hashCode * 59 + WorkspaceId.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(AssetGroup left, AssetGroup right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AssetGroup left, AssetGroup right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
