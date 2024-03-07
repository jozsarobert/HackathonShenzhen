using System.Runtime.Serialization;

namespace Reelables.Api.SDK.Model;

[DataContract(Name = "GatewayInput")]
public class GatewayInput
{
    [DataMember(Name = "isStatic", EmitDefaultValue = true)]
    public bool IsStatic { get; set; }

    [DataMember(Name = "latitude", EmitDefaultValue = false)]
    public float Latitude { get; set; }

    [DataMember(Name = "rssiFilter", EmitDefaultValue = false)]
    public SpaceGatewayRssiFilter RssiFilter { get; set; }

    [DataMember(Name = "longitude", EmitDefaultValue = false)]
    public float Longitude { get; set; }

   
}