using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Reelables.Api.SDK.Model;

[DataContract(Name = "SpaceGateway")]
public class SpaceGateway
{
    [JsonConstructor]
    protected SpaceGateway() { }

    [DataMember(Name = "isStatic", EmitDefaultValue = true)]
    public bool IsStatic { get; set; }

    [DataMember(Name = "latitude", EmitDefaultValue = false)]
    public float Latitude { get; set; }

    [DataMember(Name = "hasPendingCommands", EmitDefaultValue = true)]
    public bool HasPendingCommands { get; set; }

    [DataMember(Name = "rssiFilter", EmitDefaultValue = false)]
    public SpaceGatewayRssiFilter RssiFilter { get; set; }

    [DataMember(Name = "gatewayId", IsRequired = true, EmitDefaultValue = true)]
    public string GatewayId { get; set; }

    [DataMember(Name = "addedOn", IsRequired = true, EmitDefaultValue = true)]
    public DateTime AddedOn { get; set; }

    [DataMember(Name = "longitude", EmitDefaultValue = false)]
    public float Longitude { get; set; }
}