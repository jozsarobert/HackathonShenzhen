using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace OneRecord.Api.SDK.Model;

[DataContract(Name = "ServerInformation")]
public partial class ServerInformation : IEquatable<ServerInformation>, IValidatableObject
{
    public ServerInformation(string httpsId = default(string), List<string> httpsType = default(List<string>), Organization httpsApihasDataHolder = default(Organization), List<string> httpsApihasServerEndpoint = default(List<string>), List<string> httpsApihasSupportedApiVersion = default(List<string>), List<string> httpsApihasSupportedContentType = default(List<string>), List<string> httpsApihasSupportedEncoding = default(List<string>), List<string> httpsApihasSupportedLanguage = default(List<string>), List<string> httpsApihasSupportedOntology = default(List<string>))
    {
        this.Id = httpsId;
        this.Type = httpsType;
        this.HttpsApihasDataHolder = httpsApihasDataHolder;
        this.HttpsApihasServerEndpoint = httpsApihasServerEndpoint;
        this.HttpsApihasSupportedApiVersion = httpsApihasSupportedApiVersion;
        this.HttpsApihasSupportedContentType = httpsApihasSupportedContentType;
        this.HttpsApihasSupportedEncoding = httpsApihasSupportedEncoding;
        this.HttpsApihasSupportedLanguage = httpsApihasSupportedLanguage;
        this.HttpsApihasSupportedOntology = httpsApihasSupportedOntology;
    }

    [DataMember(Name = "@id", EmitDefaultValue = false)]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name = "@type", EmitDefaultValue = false)]
    public List<string> Type { get; set; }

    /// <summary>
    /// Gets or Sets ApihasDataHolder
    /// </summary>
    [DataMember(Name = "api:hasDataHolder", EmitDefaultValue = false)]
    public Organization HttpsApihasDataHolder { get; set; }

    /// <summary>
    /// Gets or Sets ApihasServerEndpoint
    /// </summary>
    [DataMember(Name = "api:hasServerEndpoint", EmitDefaultValue = false)]
    public List<string> HttpsApihasServerEndpoint { get; set; }

    /// <summary>
    /// Gets or Sets ApihasSupportedApiVersion
    /// </summary>
    [DataMember(Name = "api:hasSupportedApiVersion", EmitDefaultValue = false)]
    public List<string> HttpsApihasSupportedApiVersion { get; set; }

    /// <summary>
    /// Gets or Sets ApihasSupportedContentType
    /// </summary>
    [DataMember(Name = "api:hasSupportedContentType", EmitDefaultValue = false)]
    public List<string> HttpsApihasSupportedContentType { get; set; }

    /// <summary>
    /// Gets or Sets ApihasSupportedEncoding
    /// </summary>
    [DataMember(Name = "api:hasSupportedEncoding", EmitDefaultValue = false)]
    public List<string> HttpsApihasSupportedEncoding { get; set; }

    /// <summary>
    /// Gets or Sets ApihasSupportedLanguage
    /// </summary>
    [DataMember(Name = "api:hasSupportedLanguage", EmitDefaultValue = false)]
    public List<string> HttpsApihasSupportedLanguage { get; set; }

    /// <summary>
    /// Gets or Sets ApihasSupportedOntology
    /// </summary>
    [DataMember(Name = "api:hasSupportedOntology", EmitDefaultValue = false)]
    public List<string> HttpsApihasSupportedOntology { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class ServerInformation {\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  ApihasDataHolder: ").Append(HttpsApihasDataHolder).Append("\n");
        sb.Append("  ApihasServerEndpoint: ").Append(HttpsApihasServerEndpoint).Append("\n");
        sb.Append("  ApihasSupportedApiVersion: ").Append(HttpsApihasSupportedApiVersion).Append("\n");
        sb.Append("  ApihasSupportedContentType: ").Append(HttpsApihasSupportedContentType).Append("\n");
        sb.Append("  ApihasSupportedEncoding: ").Append(HttpsApihasSupportedEncoding).Append("\n");
        sb.Append("  ApihasSupportedLanguage: ").Append(HttpsApihasSupportedLanguage).Append("\n");
        sb.Append("  ApihasSupportedOntology: ").Append(HttpsApihasSupportedOntology).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }

    /// <summary>
    /// Returns the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public virtual string ToJson()
    {
        return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
    }

    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="input">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object input)
    {
        return this.Equals(input as ServerInformation);
    }

    /// <summary>
    /// Returns true if ServerInformation instances are equal
    /// </summary>
    /// <param name="input">Instance of ServerInformation to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ServerInformation input)
    {
        if (input == null)
        {
            return false;
        }
        return 
            (
                this.Id == input.Id ||
                (this.Id != null &&
                this.Id.Equals(input.Id))
            ) && 
            (
                this.Type == input.Type ||
                this.Type != null &&
                input.Type != null &&
                this.Type.SequenceEqual(input.Type)
            ) && 
            (
                this.HttpsApihasDataHolder == input.HttpsApihasDataHolder ||
                (this.HttpsApihasDataHolder != null &&
                this.HttpsApihasDataHolder.Equals(input.HttpsApihasDataHolder))
            ) && 
            (
                this.HttpsApihasServerEndpoint == input.HttpsApihasServerEndpoint ||
                this.HttpsApihasServerEndpoint != null &&
                input.HttpsApihasServerEndpoint != null &&
                this.HttpsApihasServerEndpoint.SequenceEqual(input.HttpsApihasServerEndpoint)
            ) && 
            (
                this.HttpsApihasSupportedApiVersion == input.HttpsApihasSupportedApiVersion ||
                this.HttpsApihasSupportedApiVersion != null &&
                input.HttpsApihasSupportedApiVersion != null &&
                this.HttpsApihasSupportedApiVersion.SequenceEqual(input.HttpsApihasSupportedApiVersion)
            ) && 
            (
                this.HttpsApihasSupportedContentType == input.HttpsApihasSupportedContentType ||
                this.HttpsApihasSupportedContentType != null &&
                input.HttpsApihasSupportedContentType != null &&
                this.HttpsApihasSupportedContentType.SequenceEqual(input.HttpsApihasSupportedContentType)
            ) && 
            (
                this.HttpsApihasSupportedEncoding == input.HttpsApihasSupportedEncoding ||
                this.HttpsApihasSupportedEncoding != null &&
                input.HttpsApihasSupportedEncoding != null &&
                this.HttpsApihasSupportedEncoding.SequenceEqual(input.HttpsApihasSupportedEncoding)
            ) && 
            (
                this.HttpsApihasSupportedLanguage == input.HttpsApihasSupportedLanguage ||
                this.HttpsApihasSupportedLanguage != null &&
                input.HttpsApihasSupportedLanguage != null &&
                this.HttpsApihasSupportedLanguage.SequenceEqual(input.HttpsApihasSupportedLanguage)
            ) && 
            (
                this.HttpsApihasSupportedOntology == input.HttpsApihasSupportedOntology ||
                this.HttpsApihasSupportedOntology != null &&
                input.HttpsApihasSupportedOntology != null &&
                this.HttpsApihasSupportedOntology.SequenceEqual(input.HttpsApihasSupportedOntology)
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
            int hashCode = 41;
            if (this.Id != null)
            {
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
            }
            if (this.Type != null)
            {
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
            }
            if (this.HttpsApihasDataHolder != null)
            {
                hashCode = (hashCode * 59) + this.HttpsApihasDataHolder.GetHashCode();
            }
            if (this.HttpsApihasServerEndpoint != null)
            {
                hashCode = (hashCode * 59) + this.HttpsApihasServerEndpoint.GetHashCode();
            }
            if (this.HttpsApihasSupportedApiVersion != null)
            {
                hashCode = (hashCode * 59) + this.HttpsApihasSupportedApiVersion.GetHashCode();
            }
            if (this.HttpsApihasSupportedContentType != null)
            {
                hashCode = (hashCode * 59) + this.HttpsApihasSupportedContentType.GetHashCode();
            }
            if (this.HttpsApihasSupportedEncoding != null)
            {
                hashCode = (hashCode * 59) + this.HttpsApihasSupportedEncoding.GetHashCode();
            }
            if (this.HttpsApihasSupportedLanguage != null)
            {
                hashCode = (hashCode * 59) + this.HttpsApihasSupportedLanguage.GetHashCode();
            }
            if (this.HttpsApihasSupportedOntology != null)
            {
                hashCode = (hashCode * 59) + this.HttpsApihasSupportedOntology.GetHashCode();
            }
            return hashCode;
        }
    }

    /// <summary>
    /// To validate all properties of the instance
    /// </summary>
    /// <param name="httpsValidationContext">Validation context</param>
    /// <returns>Validation Result</returns>
    IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext httpsValidationContext)
    {
        yield break;
    }
}
