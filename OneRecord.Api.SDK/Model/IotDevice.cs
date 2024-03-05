using System.Collections.Generic;
using System.Runtime.Serialization;

namespace OneRecord.Api.SDK.Model;

[DataContract(Name = "IotDevice")]
public partial class IotDevice : PhysicalLogisticsObject
{
    [DataMember(Name = "cargo:attachedToObject", EmitDefaultValue = false)]
    public PhysicalLogisticsObject AttachedToObject { get; set; }

    [DataMember(Name = "cargo:connectedSensors", EmitDefaultValue = false)]
    public List<Sensor> ConnectedSensors { get; set; }

    [DataMember(Name = "cargo:manufacturer", EmitDefaultValue = false)]
    public Company Manufacturer { get; set; }

    [DataMember(Name = "cargo:associatedObject", EmitDefaultValue = false)]
    public string AssociatedObject { get; set; }

    [DataMember(Name = "cargo:description", EmitDefaultValue = false)]
    public string Description { get; set; }

    [DataMember(Name = "cargo:deviceModel", EmitDefaultValue = false)]
    public string DeviceModel { get; set; }

    [DataMember(Name = "cargo:name", EmitDefaultValue = false)]
    public string Name { get; set; }

    [DataMember(Name = "cargo:serialNumber", EmitDefaultValue = false)]
    public string SerialNumber { get; set; }
}
