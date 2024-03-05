using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace OneRecord.Api.SDK.Response;

public class PieceResponse : LogisticsObjectReponse
{
    [JsonProperty("@type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets UldReference
    /// </summary>
    [DataMember(Name = "cargo:uldReference", EmitDefaultValue = false)]
    [JsonProperty("uldReference")]
    public UldReponse UldReference { get; set; }
}
