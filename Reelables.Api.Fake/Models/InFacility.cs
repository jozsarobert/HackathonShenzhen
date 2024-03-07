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
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Reelables.Api.Fake.Models;

/// <summary>
/// 
/// </summary>
[DataContract]
public partial class InFacility : IEquatable<InFacility>
{
    /// <summary>
    /// Indicate whether the item has exited the Facility
    /// </summary>
    /// <value>Indicate whether the item has exited the Facility</value>
    [DataMember(Name="hasExited", EmitDefaultValue=true)]
    public bool HasExited { get; set; }

    /// <summary>
    /// Unique identifier of the Facility. Example: &#39;d290f1ee-6c54-4b01-90e6-d701748f0851&#39;
    /// </summary>
    /// <value>Unique identifier of the Facility. Example: &#39;d290f1ee-6c54-4b01-90e6-d701748f0851&#39;</value>
    [Required]
    [RegularExpression("^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}$")]
    [MaxLength(36)]
    [DataMember(Name="facilityId", EmitDefaultValue=false)]
    public string FacilityId { get; set; }

    /// <summary>
    /// Date that the item entered the Facility. Example: &#39;2023-07-21T17:32:28Z&#39;
    /// </summary>
    /// <value>Date that the item entered the Facility. Example: &#39;2023-07-21T17:32:28Z&#39;</value>
    [Required]
    [RegularExpression("^[0-9TZ:-]*$")]
    [MaxLength(20)]
    [DataMember(Name="enteredOn", EmitDefaultValue=false)]
    public DateTime EnteredOn { get; set; }

    /// <summary>
    /// The name of the Facility
    /// </summary>
    /// <value>The name of the Facility</value>
    [Required]
    [RegularExpression("^[a-zA-Z0-9!@#$&()\\-`.+,/\" ]*$")]
    [MaxLength(500)]
    [DataMember(Name="facilityName", EmitDefaultValue=false)]
    public string FacilityName { get; set; }

    /// <summary>
    /// Date that the item exited the Facility. Example: &#39;2023-07-21T17:32:28Z&#39;
    /// </summary>
    /// <value>Date that the item exited the Facility. Example: &#39;2023-07-21T17:32:28Z&#39;</value>
    [RegularExpression("^[0-9TZ:-]*$")]
    [MaxLength(20)]
    [DataMember(Name="exitedOn", EmitDefaultValue=false)]
    public DateTime ExitedOn { get; set; }

    /// <summary>
    /// A facility identifier relevant to the user
    /// </summary>
    /// <value>A facility identifier relevant to the user</value>
    [MaxLength(500)]
    [DataMember(Name="userFacilityId", EmitDefaultValue=false)]
    public string UserFacilityId { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class InFacility {\n");
        sb.Append("  HasExited: ").Append(HasExited).Append("\n");
        sb.Append("  FacilityId: ").Append(FacilityId).Append("\n");
        sb.Append("  EnteredOn: ").Append(EnteredOn).Append("\n");
        sb.Append("  FacilityName: ").Append(FacilityName).Append("\n");
        sb.Append("  ExitedOn: ").Append(ExitedOn).Append("\n");
        sb.Append("  UserFacilityId: ").Append(UserFacilityId).Append("\n");
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
        return obj.GetType() == GetType() && Equals((InFacility)obj);
    }

    /// <summary>
    /// Returns true if InFacility instances are equal
    /// </summary>
    /// <param name="other">Instance of InFacility to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(InFacility other)
    {
        if (other is null) return false;
        if (ReferenceEquals(this, other)) return true;

        return 
            (
                HasExited == other.HasExited ||
                    
                HasExited.Equals(other.HasExited)
            ) && 
            (
                FacilityId == other.FacilityId ||
                FacilityId != null &&
                FacilityId.Equals(other.FacilityId)
            ) && 
            (
                EnteredOn == other.EnteredOn ||
                EnteredOn != null &&
                EnteredOn.Equals(other.EnteredOn)
            ) && 
            (
                FacilityName == other.FacilityName ||
                FacilityName != null &&
                FacilityName.Equals(other.FacilityName)
            ) && 
            (
                ExitedOn == other.ExitedOn ||
                ExitedOn != null &&
                ExitedOn.Equals(other.ExitedOn)
            ) && 
            (
                UserFacilityId == other.UserFacilityId ||
                UserFacilityId != null &&
                UserFacilityId.Equals(other.UserFacilityId)
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
                    
            hashCode = hashCode * 59 + HasExited.GetHashCode();
            if (FacilityId != null)
                hashCode = hashCode * 59 + FacilityId.GetHashCode();
            if (EnteredOn != null)
                hashCode = hashCode * 59 + EnteredOn.GetHashCode();
            if (FacilityName != null)
                hashCode = hashCode * 59 + FacilityName.GetHashCode();
            if (ExitedOn != null)
                hashCode = hashCode * 59 + ExitedOn.GetHashCode();
            if (UserFacilityId != null)
                hashCode = hashCode * 59 + UserFacilityId.GetHashCode();
            return hashCode;
        }
    }

    #region Operators
#pragma warning disable 1591

    public static bool operator ==(InFacility left, InFacility right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(InFacility left, InFacility right)
    {
        return !Equals(left, right);
    }

#pragma warning restore 1591
    #endregion Operators
}