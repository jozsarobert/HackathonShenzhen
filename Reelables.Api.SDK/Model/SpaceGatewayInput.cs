using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Reelables.Api.SDK.Model;

[DataContract(Name = "SpaceGatewayInput")]
public class SpaceGatewayInput
{
    [JsonConstructor]
    protected SpaceGatewayInput() { }

    [DataMember(Name = "isStatic", EmitDefaultValue = true)]
    public bool IsStatic { get; set; }

    [DataMember(Name = "replaceExistingGateway", EmitDefaultValue = true)]
    public bool ReplaceExistingGateway { get; set; }

    [DataMember(Name = "latitude", EmitDefaultValue = false)]
    public float Latitude { get; set; }

    [DataMember(Name = "rssiFilter", EmitDefaultValue = false)]
    public SpaceGatewayInputRssiFilter RssiFilter { get; set; }

    [DataMember(Name = "gatewayId", IsRequired = true, EmitDefaultValue = true)]
    public string GatewayId { get; set; }

    [DataMember(Name = "longitude", EmitDefaultValue = false)]
    public float Longitude { get; set; }
}