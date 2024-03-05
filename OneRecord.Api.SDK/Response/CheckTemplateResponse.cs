using OneRecord.Api.SDK.Model;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace OneRecord.Api.SDK.Response;

public class CheckTemplateResponse : LogisticsObjectReponse
{
    [JsonProperty("@type")]
    public string TypeString { get; set; }

    /// <summary>
    /// Gets or Sets CargoinvolvedParties
    /// </summary>
    [DataMember(Name = "cargo:involvedParties", EmitDefaultValue = false)]
    [JsonProperty("involvedParties")]
    public List<Party> InvolvedParties { get; set; }

    /// <summary>
    /// Gets or Sets CargolegacyTemplate
    /// </summary>
    [DataMember(Name = "cargo:legacyTemplate", EmitDefaultValue = false)]
    [JsonProperty("legacyTemplate")]

    public ExternalReference LegacyTemplate { get; set; }

    /// <summary>
    /// Gets or Sets Cargoquestions
    /// </summary>
    [DataMember(Name = "cargo:questions", EmitDefaultValue = false)]
    [JsonProperty("questions")]
    public List<QuestionResponse> Questions { get; set; }

    /// <summary>
    /// Gets or Sets Cargodate
    /// </summary>
    [DataMember(Name = "cargo:date", EmitDefaultValue = false)]
    public DateTime Date { get; set; }

    /// <summary>
    /// Gets or Sets Cargoname
    /// </summary>
    [DataMember(Name = "cargo:name", EmitDefaultValue = false)]
    [JsonProperty("Name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets CargotemplatePurpose
    /// </summary>
    [DataMember(Name = "cargo:templatePurpose", EmitDefaultValue = false)]
    public string TemplatePurpose { get; set; }

    /// <summary>
    /// Gets or Sets Cargoversion
    /// </summary>
    [DataMember(Name = "cargo:version", EmitDefaultValue = false)]
    public string Version { get; set; }
}
