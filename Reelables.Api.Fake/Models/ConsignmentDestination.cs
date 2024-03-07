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
public partial class ConsignmentDestination : IEquatable<ConsignmentDestination>
{
    /// <summary>
    /// Name of the destination. Example: LHR
    /// </summary>
    /// <value>Name of the destination. Example: LHR</value>
    [MaxLength(500)]
    [DataMember(Name="name", EmitDefaultValue=false)]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Facility
    /// </summary>
    [DataMember(Name="facility", EmitDefaultValue=false)]
    public Facility Facility { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConsignmentDestination {\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Facility: ").Append(Facility).Append("\n");
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
        return obj.GetType() == GetType() && Equals((ConsignmentDestination)obj);
    }

    /// <summary>
    /// Returns true if ConsignmentDestination instances are equal
    /// </summary>
    /// <param name="other">Instance of ConsignmentDestination to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConsignmentDestination other)
    {
        if (other is null) return false;
        if (ReferenceEquals(this, other)) return true;

        return 
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) && 
            (
                Facility == other.Facility ||
                Facility != null &&
                Facility.Equals(other.Facility)
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
            if (Name != null)
                hashCode = hashCode * 59 + Name.GetHashCode();
            if (Facility != null)
                hashCode = hashCode * 59 + Facility.GetHashCode();
            return hashCode;
        }
    }

    #region Operators
#pragma warning disable 1591

    public static bool operator ==(ConsignmentDestination left, ConsignmentDestination right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(ConsignmentDestination left, ConsignmentDestination right)
    {
        return !Equals(left, right);
    }

#pragma warning restore 1591
    #endregion Operators
}