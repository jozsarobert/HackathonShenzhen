using System.Runtime.Serialization;

namespace Reelables.Api.SDK.Model;

[DataContract(Name = "Consignment_deactivated_where")]
public class ConsignmentDeactivatedWhere
{
    [DataMember(Name = "facility", EmitDefaultValue = false)]
    public Facility Facility { get; set; }
             
}