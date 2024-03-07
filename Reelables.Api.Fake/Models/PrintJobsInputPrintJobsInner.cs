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
/// 
/// </summary>
[DataContract]
public partial class PrintJobsInputPrintJobsInner : IEquatable<PrintJobsInputPrintJobsInner>
{
    /// <summary>
    /// Unique identifier of the Asset to print. Example: &#39;00Es43YBJfNRXNSvLmni&#39;
    /// </summary>
    /// <value>Unique identifier of the Asset to print. Example: &#39;00Es43YBJfNRXNSvLmni&#39;</value>
    [Required]
    [RegularExpression("^[-_A-Za-z0-9]*$")]
    [MaxLength(20)]
    [DataMember(Name="assetId", EmitDefaultValue=false)]
    public string AssetId { get; set; }

    /// <summary>
    /// Indicate whether to replace the existing Label, in the case where the Asset is already linked to a Label
    /// </summary>
    /// <value>Indicate whether to replace the existing Label, in the case where the Asset is already linked to a Label</value>
    [DataMember(Name="replaceExistingLabel", EmitDefaultValue=true)]
    public bool ReplaceExistingLabel { get; set; }

    /// <summary>
    /// Dynamic object that is used to pass any params for the POrint Template
    /// </summary>
    /// <value>Dynamic object that is used to pass any params for the POrint Template</value>
    [DataMember(Name="templateParams", EmitDefaultValue=false)]
    public Dictionary<string, Object> TemplateParams { get; set; }

    /// <summary>
    /// The indentifier of the Print Template
    /// </summary>
    /// <value>The indentifier of the Print Template</value>
    [RegularExpression("^template[0-9]*$")]
    [MaxLength(12)]
    [DataMember(Name="templateId", EmitDefaultValue=false)]
    public string TemplateId { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PrintJobsInputPrintJobsInner {\n");
        sb.Append("  AssetId: ").Append(AssetId).Append("\n");
        sb.Append("  ReplaceExistingLabel: ").Append(ReplaceExistingLabel).Append("\n");
        sb.Append("  TemplateParams: ").Append(TemplateParams).Append("\n");
        sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
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
        return obj.GetType() == GetType() && Equals((PrintJobsInputPrintJobsInner)obj);
    }

    /// <summary>
    /// Returns true if PrintJobsInputPrintJobsInner instances are equal
    /// </summary>
    /// <param name="other">Instance of PrintJobsInputPrintJobsInner to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PrintJobsInputPrintJobsInner other)
    {
        if (other is null) return false;
        if (ReferenceEquals(this, other)) return true;

        return 
            (
                AssetId == other.AssetId ||
                AssetId != null &&
                AssetId.Equals(other.AssetId)
            ) && 
            (
                ReplaceExistingLabel == other.ReplaceExistingLabel ||
                    
                ReplaceExistingLabel.Equals(other.ReplaceExistingLabel)
            ) && 
            (
                TemplateParams == other.TemplateParams ||
                TemplateParams != null &&
                other.TemplateParams != null &&
                TemplateParams.SequenceEqual(other.TemplateParams)
            ) && 
            (
                TemplateId == other.TemplateId ||
                TemplateId != null &&
                TemplateId.Equals(other.TemplateId)
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
            if (AssetId != null)
                hashCode = hashCode * 59 + AssetId.GetHashCode();
                    
            hashCode = hashCode * 59 + ReplaceExistingLabel.GetHashCode();
            if (TemplateParams != null)
                hashCode = hashCode * 59 + TemplateParams.GetHashCode();
            if (TemplateId != null)
                hashCode = hashCode * 59 + TemplateId.GetHashCode();
            return hashCode;
        }
    }

    #region Operators
#pragma warning disable 1591

    public static bool operator ==(PrintJobsInputPrintJobsInner left, PrintJobsInputPrintJobsInner right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(PrintJobsInputPrintJobsInner left, PrintJobsInputPrintJobsInner right)
    {
        return !Equals(left, right);
    }

#pragma warning restore 1591
    #endregion Operators
}