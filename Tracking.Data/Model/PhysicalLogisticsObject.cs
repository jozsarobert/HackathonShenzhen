using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Tracking.Data.Model;

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
