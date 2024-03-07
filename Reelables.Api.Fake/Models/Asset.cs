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
    public partial class Asset : IEquatable<Asset>
    {
        /// <summary>
        /// Gets or Sets InSpaces
        /// </summary>
        [DataMember(Name="inSpaces", EmitDefaultValue=false)]
        public List<AssetInSpace> InSpaces { get; set; }

        /// <summary>
        /// Gets or Sets Temperatures
        /// </summary>
        [DataMember(Name="temperatures", EmitDefaultValue=false)]
        public AssetTemperatures Temperatures { get; set; }

        /// <summary>
        /// The name of the Asset
        /// </summary>
        /// <value>The name of the Asset</value>
        [Required]
        [RegularExpression("^[a-zA-Z0-9!@#$&()\\-`.+,/\" ]*$")]
        [MaxLength(500)]
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Locations
        /// </summary>
        [DataMember(Name="locations", EmitDefaultValue=false)]
        public AssetLocations Locations { get; set; }

        /// <summary>
        /// Unique identifier of the Asset. Example: &#39;00Es43YBJfNRXNSvLmni&#39;
        /// </summary>
        /// <value>Unique identifier of the Asset. Example: &#39;00Es43YBJfNRXNSvLmni&#39;</value>
        [Required]
        [RegularExpression("^[-_A-Za-z0-9]*$")]
        [MaxLength(20)]
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public AssetLabel Label { get; set; }

        /// <summary>
        /// Date that the Asset was created, in UTC. Example: &#39;2019-07-21T17:32:28Z&#39;
        /// </summary>
        /// <value>Date that the Asset was created, in UTC. Example: &#39;2019-07-21T17:32:28Z&#39;</value>
        [RegularExpression("^[0-9TZ:-]*$")]
        [MaxLength(20)]
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Unique identifier of the Workspace that the Asset belongs to. Example: &#39;d290f1ee-6c54-4b01-90e6-d701748f0851&#39;
        /// </summary>
        /// <value>Unique identifier of the Workspace that the Asset belongs to. Example: &#39;d290f1ee-6c54-4b01-90e6-d701748f0851&#39;</value>
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
            sb.Append("class Asset {\n");
            sb.Append("  InSpaces: ").Append(InSpaces).Append("\n");
            sb.Append("  Temperatures: ").Append(Temperatures).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Locations: ").Append(Locations).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Asset)obj);
        }

        /// <summary>
        /// Returns true if Asset instances are equal
        /// </summary>
        /// <param name="other">Instance of Asset to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Asset other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    InSpaces == other.InSpaces ||
                    InSpaces != null &&
                    other.InSpaces != null &&
                    InSpaces.SequenceEqual(other.InSpaces)
                ) && 
                (
                    Temperatures == other.Temperatures ||
                    Temperatures != null &&
                    Temperatures.Equals(other.Temperatures)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Locations == other.Locations ||
                    Locations != null &&
                    Locations.Equals(other.Locations)
                ) && 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    Label == other.Label ||
                    Label != null &&
                    Label.Equals(other.Label)
                ) && 
                (
                    CreatedOn == other.CreatedOn ||
                    CreatedOn != null &&
                    CreatedOn.Equals(other.CreatedOn)
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
                    if (InSpaces != null)
                    hashCode = hashCode * 59 + InSpaces.GetHashCode();
                    if (Temperatures != null)
                    hashCode = hashCode * 59 + Temperatures.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Locations != null)
                    hashCode = hashCode * 59 + Locations.GetHashCode();
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (Label != null)
                    hashCode = hashCode * 59 + Label.GetHashCode();
                    if (CreatedOn != null)
                    hashCode = hashCode * 59 + CreatedOn.GetHashCode();
                    if (WorkspaceId != null)
                    hashCode = hashCode * 59 + WorkspaceId.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Asset left, Asset right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Asset left, Asset right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
