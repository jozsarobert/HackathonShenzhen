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
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Reelables.Api.Fake.Models;

/// <summary>
/// This is an error
/// </summary>
[DataContract]
public partial class ErrorResponse : IEquatable<ErrorResponse>
{
    /// <summary>
    /// Gets or Sets Errors
    /// </summary>
    [Required]
    [DataMember(Name="errors", EmitDefaultValue=false)]
    public List<ErrorResponseErrorsInner> Errors { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ErrorResponse {\n");
        sb.Append("  Errors: ").Append(Errors).Append("\n");
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
        return obj.GetType() == GetType() && Equals((ErrorResponse)obj);
    }

    /// <summary>
    /// Returns true if ErrorResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of ErrorResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ErrorResponse other)
    {
        if (other is null) return false;
        if (ReferenceEquals(this, other)) return true;

        return 
        (
            Errors == other.Errors ||
            Errors != null &&
            other.Errors != null &&
            Errors.SequenceEqual(other.Errors)
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
            if (Errors != null)
                hashCode = hashCode * 59 + Errors.GetHashCode();
            return hashCode;
        }
    }

    #region Operators
#pragma warning disable 1591

    public static bool operator ==(ErrorResponse left, ErrorResponse right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(ErrorResponse left, ErrorResponse right)
    {
        return !Equals(left, right);
    }

#pragma warning restore 1591
    #endregion Operators
}