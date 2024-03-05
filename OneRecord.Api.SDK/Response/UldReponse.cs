using System.Runtime.Serialization;
using Newtonsoft.Json;
using OneRecord.Api.SDK.Model;

namespace OneRecord.Api.SDK.Response;

[DataContract]
public class UldReponse : LoadingUnitResponse
{
    /// <summary>
    /// Gets or Sets Context
    /// </summary>
    [DataMember(Name = "@context", EmitDefaultValue = true)]
    [JsonProperty("@context")]
    public Context Context { get; set;}
      

    [DataMember(Name = "uldSerialNumber", EmitDefaultValue = false)]
    [JsonProperty("uldSerialNumber")]

    public string UldSerialNumber { get; set; }
}
