using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Tracking.Data.Model;

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
