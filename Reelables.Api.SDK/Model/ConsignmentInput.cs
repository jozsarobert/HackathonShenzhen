using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Reelables.Api.SDK.Model;


[DataContract(Name = "ConsignmentInput")]
public class ConsignmentInput
{
    [JsonConstructor]
    protected ConsignmentInput() { }
  
    [DataMember(Name = "pieces", IsRequired = true, EmitDefaultValue = true)]
    public List<ConsignmentInputPiecesInner> Pieces { get; set; }

    [DataMember(Name = "trackingRef", IsRequired = true, EmitDefaultValue = true)]
    public string TrackingRef { get; set; }

    [DataMember(Name = "gateways", EmitDefaultValue = false)]
    public List<ConsignmentInputGatewaysInner> Gateways { get; set; }

}