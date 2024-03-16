using System.Runtime.Serialization;

namespace OneRecord.Data.Model.Model;

[DataContract(Name = "PhysicalLogisticsObject")]
public partial class PhysicalLogisticsObject : LogisticsObject
{
    [DataMember(Name = "cargo:attachedIotDevices", EmitDefaultValue = false)]
    public List<IotDevice> AttachedIotDevices { get; set; }

    [DataMember(Name = "cargo:involvedInActions", EmitDefaultValue = false)]
    public List<LogisticsAction> InvolvedInActions { get; set; }
}
