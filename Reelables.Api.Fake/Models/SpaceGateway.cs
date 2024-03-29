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
public partial class SpaceGateway : IEquatable<SpaceGateway>
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
    /// Indicate whether there are pending commands for the Gateway
    /// </summary>
    /// <value>Indicate whether there are pending commands for the Gateway</value>
    [DataMember(Name="hasPendingCommands", EmitDefaultValue=true)]
    public bool HasPendingCommands { get; set; }

    /// <summary>
    /// Gets or Sets RssiFilter
    /// </summary>
    [DataMember(Name="rssiFilter", EmitDefaultValue=false)]
    public SpaceGatewayRssiFilter RssiFilter { get; set; }

    /// <summary>
    /// Gateway identifier. Example: &#39;e00fce315222e588e1d7482b&#39;
    /// </summary>
    /// <value>Gateway identifier. Example: &#39;e00fce315222e588e1d7482b&#39;</value>
    [Required]
    [RegularExpression("^[-_A-Za-z0-9]*$")]
    [MaxLength(50)]
    [DataMember(Name="gatewayId", EmitDefaultValue=false)]
    public string GatewayId { get; set; }

    /// <summary>
    /// Date that the Gateway was linked to the Space, in UTC. Example: &#39;2019-07-21T17:32:28Z&#39;
    /// </summary>
    /// <value>Date that the Gateway was linked to the Space, in UTC. Example: &#39;2019-07-21T17:32:28Z&#39;</value>
    [Required]
    [RegularExpression("^[0-9TZ:-]*$")]
    [MaxLength(20)]
    [DataMember(Name="addedOn", EmitDefaultValue=false)]
    public DateTime AddedOn { get; set; }

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
        sb.Append("class SpaceGateway {\n");
        sb.Append("  IsStatic: ").Append(IsStatic).Append("\n");
        sb.Append("  Latitude: ").Append(Latitude).Append("\n");
        sb.Append("  HasPendingCommands: ").Append(HasPendingCommands).Append("\n");
        sb.Append("  RssiFilter: ").Append(RssiFilter).Append("\n");
        sb.Append("  GatewayId: ").Append(GatewayId).Append("\n");
        sb.Append("  AddedOn: ").Append(AddedOn).Append("\n");
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
        return obj.GetType() == GetType() && Equals((SpaceGateway)obj);
    }

    /// <summary>
    /// Returns true if SpaceGateway instances are equal
    /// </summary>
    /// <param name="other">Instance of SpaceGateway to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SpaceGateway other)
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
                HasPendingCommands == other.HasPendingCommands ||
                    
                HasPendingCommands.Equals(other.HasPendingCommands)
            ) && 
            (
                RssiFilter == other.RssiFilter ||
                RssiFilter != null &&
                RssiFilter.Equals(other.RssiFilter)
            ) && 
            (
                GatewayId == other.GatewayId ||
                GatewayId != null &&
                GatewayId.Equals(other.GatewayId)
            ) && 
            (
                AddedOn == other.AddedOn ||
                AddedOn != null &&
                AddedOn.Equals(other.AddedOn)
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
                    
            hashCode = hashCode * 59 + HasPendingCommands.GetHashCode();
            if (RssiFilter != null)
                hashCode = hashCode * 59 + RssiFilter.GetHashCode();
            if (GatewayId != null)
                hashCode = hashCode * 59 + GatewayId.GetHashCode();
            if (AddedOn != null)
                hashCode = hashCode * 59 + AddedOn.GetHashCode();
                    
            hashCode = hashCode * 59 + Longitude.GetHashCode();
            return hashCode;
        }
    }

    #region Operators
#pragma warning disable 1591

    public static bool operator ==(SpaceGateway left, SpaceGateway right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(SpaceGateway left, SpaceGateway right)
    {
        return !Equals(left, right);
    }

#pragma warning restore 1591
    #endregion Operators
}