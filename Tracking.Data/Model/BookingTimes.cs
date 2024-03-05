using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Tracking.Data.Model;

[DataContract(Name = "BookingTimes")]
public partial class BookingTimes : EntityBase
{
    [DataMember(Name = "cargo:forBookingOptionRequest", EmitDefaultValue = false)]
    public BookingOptionRequest ForBookingOptionRequest { get; set; }

    [DataMember(Name = "cargo:forBookingOptions", EmitDefaultValue = false)]
    public BookingOption ForBookingOptions { get; set; }

    [DataMember(Name = "cargo:earliestAcceptanceTime", EmitDefaultValue = false)]
    public DateTime EarliestAcceptanceTime { get; set; }

    [DataMember(Name = "cargo:latestAcceptanceTime", EmitDefaultValue = false)]
    public DateTime LatestAcceptanceTime { get; set; }

    [DataMember(Name = "cargo:latestArrivalTime", EmitDefaultValue = false)]
    public DateTime LatestArrivalTime { get; set; }

    [DataMember(Name = "cargo:timeOfAvailability", EmitDefaultValue = false)]
    public DateTime TimeOfAvailability { get; set; }

    [DataMember(Name = "cargo:totalTransitTime", EmitDefaultValue = false)]
    public string TotalTransitTime { get; set; }
    public string BookingOptionId { get;  set; }
    public string BookingOptionRequestId { get; set; }
}
