using System.Collections.Generic;
using System.Runtime.Serialization;

namespace OneRecord.Api.SDK.Model;

[DataContract(Name = "PhysicalLogisticsObject")]
public partial class PhysicalLogisticsObject : LogisticsObject 
{ 
    [DataMember(Name = "cargo:attachedIotDevices", EmitDefaultValue = false)]
    public List<IotDevice> AttachedIotDevices { get; set; }

    [DataMember(Name = "cargo:involvedInActions", EmitDefaultValue = false)]
    public List<LogisticsAction> InvolvedInActions { get; set; }

    [DataMember(Name = "cargo:transportOrganization", EmitDefaultValue = false)]
    public Organization TransportOrganization { get; set; }
}
