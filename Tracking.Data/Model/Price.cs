using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Tracking.Data.Model;

[DataContract(Name = "Price")]
public partial class Price : LogisticsObject
{
    [DataMember(Name = "cargo:forBookingOptionRequest", EmitDefaultValue = false)]
    public BookingOptionRequest ForBookingOptionRequest { get; set; }

    [DataMember(Name = "cargo:forBookingOptions", EmitDefaultValue = false)]
    public BookingOption ForBookingOptions { get; set; }

    [DataMember(Name = "cargo:ratings", EmitDefaultValue = false)]
    public List<Ratings> Ratings { get; set; }

    [DataMember(Name = "cargo:carrierChargeCode", EmitDefaultValue = false)]
    public string CarrierChargeCode { get; set; }

    [DataMember(Name = "cargo:grandTotal", EmitDefaultValue = false)]
    public double GrandTotal { get; set; }

    [DataMember(Name = "cargo:validUntil", EmitDefaultValue = false)]
    public List<DateTime> ValidUntil { get; set; }
    public string BookingOptionId { get; internal set; }
}
