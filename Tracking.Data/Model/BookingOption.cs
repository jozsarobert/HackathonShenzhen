using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Tracking.Data.Model;

[DataContract(Name = "BookingOption")]
public partial class BookingOption : LogisticsObject
{
    [DataMember(Name = "cargo:bookingTimes", EmitDefaultValue = false)]
    public BookingTimes BookingTimes { get; set; }

    [DataMember(Name = "cargo:carrierProductInfo", EmitDefaultValue = false)]
    public CarrierProduct CarrierProductInfo { get; set; }

    [DataMember(Name = "cargo:forBookingRequest", EmitDefaultValue = false)]
    public BookingRequest ForBookingRequest { get; set; }

    [DataMember(Name = "cargo:fromCarrier", EmitDefaultValue = false)]
    public Carrier FromCarrier { get; set; }

    [DataMember(Name = "cargo:involvedParties", EmitDefaultValue = false)]
    public List<Party> InvolvedParties { get; set; }

    [DataMember(Name = "cargo:price", EmitDefaultValue = false)]
    public Price Price { get; set; }

    [DataMember(Name = "cargo:requestRef", EmitDefaultValue = false)]
    public BookingOptionRequest RequestRef { get; set; }

    [DataMember(Name = "cargo:routing", EmitDefaultValue = false)]
    public Routing Routing { get; set; }

    [DataMember(Name = "cargo:transportMovement", EmitDefaultValue = false)]
    public TransportMovement TransportMovement { get; set; }

    [DataMember(Name = "cargo:bookingOptionStatus", EmitDefaultValue = false)]
    public string BookingOptionStatus { get; set; }

    [DataMember(Name = "cargo:proposedWaybillNumber", EmitDefaultValue = false)]
    public string ProposedWaybillNumber { get; set; }

    [DataMember(Name = "cargo:requestMatchInd", EmitDefaultValue = true)]
    public bool RequestMatchInd { get; set; }

    [DataMember(Name = "cargo:shipmentSecurityStatus", EmitDefaultValue = false)]
    public string ShipmentSecurityStatus { get; set; }

    [DataMember(Name = "cargo:validFrom", EmitDefaultValue = false)]
    public DateTime ValidFrom { get; set; }

    [DataMember(Name = "cargo:validUntil", EmitDefaultValue = false)]
    public DateTime ValidUntil { get; set; }

    [DataMember(Name = "cargo:transportLegs", EmitDefaultValue = false)]
    public List<TransportLegs> TransportLegs { get; set; }
    public string BookingRequestId { get; internal set; }
}
