using Newtonsoft.Json;
using OneRecord.Api.SDK.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace OneRecord.Api.SDK.Response;

[DataContract]
public class LogisticsObjectReponse
{
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name = "@id", EmitDefaultValue = false)]
    [JsonProperty("@id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name = "@type", EmitDefaultValue = false)]
    [JsonProperty("@type")]
    public List<string> Type { get; set; }

    /// <summary>
    /// Gets or Sets Cargochecks
    /// </summary>
    [DataMember(Name = "checks", EmitDefaultValue = false)]
    [JsonProperty("checks")]
    public List<Check> Checks { get; set; }

    /// <summary>
    /// Gets or Sets Cargoevents
    /// </summary>
    [DataMember(Name = "events", EmitDefaultValue = false)]
    [JsonProperty("events")]
    public List<LogisticsEvent> Events { get; set; }

    /// <summary>
    /// Gets or Sets CargoexternalReferences
    /// </summary>
    [DataMember(Name = "externalReferences", EmitDefaultValue = false)]
    [JsonProperty("externalReferences")]
    public List<ExternalReference> ExternalReferences { get; set; }

    /// <summary>
    /// Gets or Sets CargocompanyIdentifier
    /// </summary>
    [DataMember(Name = "companyIdentifier", EmitDefaultValue = false)]
    [JsonProperty("companyIdentifier")]
    public string CompanyIdentifier { get; set; }

    /// <summary>
    /// Gets or Sets CargoskeletonIndicator
    /// </summary>
    [DataMember(Name = "skeletonIndicator", EmitDefaultValue = false)]
    [JsonProperty("skeletonIndicator")]
    public bool SkeletonIndicator { get; set; }
}
