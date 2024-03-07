using System.Runtime.Serialization;

namespace Reelables.Api.SDK.Model;

[DataContract(Name = "Consignment_destination")]
public class ConsignmentDestination 
{
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }

    [DataMember(Name = "facility", EmitDefaultValue = false)]
    public Facility Facility { get; set; }
}