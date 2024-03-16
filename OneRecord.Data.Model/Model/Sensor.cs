using System.Runtime.Serialization;

namespace OneRecord.Data.Model.Model
{
    [DataContract(Name = "Sensor")]
    public partial class Sensor : PhysicalLogisticsObject
    {
        [DataMember(Name = "cargo:measurements", EmitDefaultValue = false)]
        public List<Measurement> Measurements { get; set; }

        [DataMember(Name = "cargo:partOfIotDevice", EmitDefaultValue = false)]
        public IotDevice PartOfIotDevice { get; set; }

        [DataMember(Name = "cargo:description", EmitDefaultValue = false)]
        public string Description { get; set; }

        [DataMember(Name = "cargo:name", EmitDefaultValue = false)]
        public string Name { get; set; }

        [DataMember(Name = "cargo:sensorType", EmitDefaultValue = false)]
        public string SensorType { get; set; }

        [DataMember(Name = "cargo:serialNumber", EmitDefaultValue = false)]
        public string SerialNumber { get; set; }
        public string IotDeviceId { get; internal set; }
    }
}
