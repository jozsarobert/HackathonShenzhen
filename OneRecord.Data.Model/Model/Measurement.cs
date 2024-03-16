using System.Runtime.Serialization;

namespace OneRecord.Data.Model.Model;

[DataContract(Name = "Measurement")]
public partial class Measurement : EntityBase
{
    [DataMember(Name = "cargo:measurementValue", EmitDefaultValue = false)]
    public Value MeasurementValue { get; set; }

    [DataMember(Name = "cargo:recordedGeolocation", EmitDefaultValue = false)]
    public Geolocation RecordedGeolocation { get; set; }

    [DataMember(Name = "cargo:measurementTimestamp", EmitDefaultValue = false)]
    public DateTime MeasurementTimestamp { get; set; }
}
