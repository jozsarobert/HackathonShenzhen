using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Tracking.Data.Model;

[DataContract(Name = "Routing")]
public partial class Routing : LogisticsObject
{
    [DataMember(Name = "cargo:excludedViaPoints", EmitDefaultValue = false)]
    public List<Location> ExcludedViaPoints { get; set; }

    [DataMember(Name = "cargo:forBookingOptionRequest", EmitDefaultValue = false)]
    public BookingOptionRequest ForBookingOptionRequest { get; set; }

    [DataMember(Name = "cargo:forBookingOptions", EmitDefaultValue = false)]
    public BookingOption ForBookingOptions { get; set; }

    [DataMember(Name = "cargo:scheduledLegs", EmitDefaultValue = false)]
    public List<ScheduledLegs> ScheduledLegs { get; set; }

    [DataMember(Name = "cargo:aircraftPossibilityCode", EmitDefaultValue = false)]
    public string AircraftPossibilityCode { get; set; }

    [DataMember(Name = "cargo:latestArrivalDateTime", EmitDefaultValue = false)]
    public DateTime LatestArrivalDateTime { get; set; }

    [DataMember(Name = "cargo:maxConnections", EmitDefaultValue = false)]
    public int MaxConnections { get; set; }

    [DataMember(Name = "cargo:onlineInd", EmitDefaultValue = true)]
    public bool OnlineInd { get; set; }

    [DataMember(Name = "cargo:rfsInd", EmitDefaultValue = true)]
    public bool FsInd { get; set; }
    public string BookingOptionId { get; internal set; }
    public string BookingOptionRequestId { get; internal set; }
}
