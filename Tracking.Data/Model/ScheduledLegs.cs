using System;
using System.Runtime.Serialization;

namespace Tracking.Data.Model;

[DataContract(Name = "ScheduledLegs")]
public partial class ScheduledLegs : EntityBase
{
    [DataMember(Name = "cargo:arrivalLocation", EmitDefaultValue = false)]
    public Location ArrivalLocation { get; set; }

    [DataMember(Name = "cargo:departureLocation", EmitDefaultValue = false)]
    public Location DepartureLocation { get; set; }

    [DataMember(Name = "cargo:arrivalDate", EmitDefaultValue = false)]
    public DateTime ArrivalDate { get; set; }

    [DataMember(Name = "cargo:departureDate", EmitDefaultValue = false)]
    public DateTime DepartureDate { get; set; }

    [DataMember(Name = "cargo:legSequenceNumber", EmitDefaultValue = false)]
    public int LegSequenceNumber { get; set; }

    [DataMember(Name = "cargo:transportIdentifier", EmitDefaultValue = false)]
    public string TransportIdentifier { get; set; }
}
