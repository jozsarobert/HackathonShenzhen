using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Reelables.Api.SDK.Model;


[DataContract(Name = "ConsignmentInput_gateways_inner")]
public class ConsignmentInputGatewaysInner
{

    [JsonConstructor]
    protected ConsignmentInputGatewaysInner() { }

    [DataMember(Name = "registerGateway", EmitDefaultValue = true)]
    public bool RegisterGateway { get; set; }

    [DataMember(Name = "deviceId", IsRequired = true, EmitDefaultValue = true)]
    public string DeviceId { get; set; }

    [DataMember(Name = "productName", EmitDefaultValue = false)]
    public string ProductName { get; set; }

    [DataMember(Name = "manufacturer", IsRequired = true, EmitDefaultValue = true)]
    public ConsignmentInputGatewaysInnerManufacturer Manufacturer { get; set; }
}