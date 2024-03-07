using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Reelables.Api.SDK.Model;

[DataContract(Name = "Gateway")]
public class Gateway
{

    [JsonConstructor]
    protected Gateway() { }
    
    [DataMember(Name = "shortId", EmitDefaultValue = false)]
    public string ShortId { get; set; }

    [DataMember(Name = "gatewayId", IsRequired = true, EmitDefaultValue = true)]
    public string GatewayId { get; set; }

    [DataMember(Name = "addedOn", EmitDefaultValue = false)]
    public DateTime AddedOn { get; set; }

    [DataMember(Name = "productName", EmitDefaultValue = false)]
    public string ProductName { get; set; }

    [DataMember(Name = "manufacturer", IsRequired = true, EmitDefaultValue = true)]
    public string Manufacturer { get; set; }
}