using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Tracking.Data.Model;

[DataContract(Name = "BookingOption")]
public partial class BookingOption : LogisticsObject
{
    public BookingOption()
    {
        Type = new List<string>
        {
            "cargo:BookingOption"
        };
    }
    public string BookingRequestId { get; internal set; }

    [DataMember(Name = "cargo:carrier", EmitDefaultValue = false)]
    public Carrier Carrier { get; set; }

    [DataMember(Name = "cargo:forBookingRequest", EmitDefaultValue = false)]
    public BookingRequest ForBookingRequest { get; set; }

    [DataMember(Name = "cargo:forBookingOptionRequest", EmitDefaultValue = false)]
    public BookingOptionRequest ForBookingOptionRequest { get; set; }

    [DataMember(Name = "cargo:price", EmitDefaultValue = false)]
    public Price Price { get; set; }

    [DataMember(Name = "cargo:unitsPreference", EmitDefaultValue = false)]
    public UnitsPreference UnitsPreference { get; set; }

    [DataMember(Name = "cargo:carrierProduct", EmitDefaultValue = false)]
    public CarrierProduct CarrierProduct { get; set; }

    [DataMember(Name = "cargo:bookingTimes", EmitDefaultValue = false)]
    public BookingTimes BookingTimes { get; set; }

    [DataMember(Name = "cargo:transportLegs", EmitDefaultValue = false)]
    public List<TransportLegs> TransportLegs { get; set; }

    [DataMember(Name = "cargo:stationRemarks", EmitDefaultValue = false)]
    public List<StationRemarks> StationRemarks { get; set; }

    [DataMember(Name = "cargo:statusBookingOption", EmitDefaultValue = false)]
    public string StatusBookingOption { get; set; }

    [DataMember(Name = "cargo:additionalInformation", EmitDefaultValue = false)]
    public string AdditionalInformation { get; set; }

    [DataMember(Name = "cargo:alternatives", EmitDefaultValue = false)]
    public List<string> Alternatives { get; set; }

    [DataMember(Name = "cargo:offerValidFrom", EmitDefaultValue = false)]
    public DateTime OfferValidFrom { get; set; }

    [DataMember(Name = "cargo:offerValidUntil", EmitDefaultValue = false)]
    public DateTime OfferValidUntil { get; set; }

    [DataMember(Name = "cargo:requestMatch", EmitDefaultValue = true)]
    public bool RequestMatch { get; set; }




    //[DataMember(Name = "cargo:carrierProductInfo", EmitDefaultValue = false)]
    //public CarrierProduct CarrierProductInfo { get; set; }

    //[DataMember(Name = "cargo:fromCarrier", EmitDefaultValue = false)]
    //public Carrier FromCarrier { get; set; }

    //[DataMember(Name = "cargo:involvedParties", EmitDefaultValue = false)]
    //public List<Party> InvolvedParties { get; set; }

    //[DataMember(Name = "cargo:requestRef", EmitDefaultValue = false)]
    //public BookingOptionRequest RequestRef { get; set; }

    //[DataMember(Name = "cargo:routing", EmitDefaultValue = false)]
    //public Routing Routing { get; set; }

    //[DataMember(Name = "cargo:transportMovement", EmitDefaultValue = false)]
    //public TransportMovement TransportMovement { get; set; }

    //[DataMember(Name = "cargo:bookingOptionStatus", EmitDefaultValue = false)]
    //public string BookingOptionStatus { get; set; }

    //[DataMember(Name = "cargo:proposedWaybillNumber", EmitDefaultValue = false)]
    //public string ProposedWaybillNumber { get; set; }

    //[DataMember(Name = "cargo:shipmentSecurityStatus", EmitDefaultValue = false)]
    //public string ShipmentSecurityStatus { get; set; }

    //[DataMember(Name = "cargo:validFrom", EmitDefaultValue = false)]
    //public DateTime ValidFrom { get; set; }

    //[DataMember(Name = "cargo:validUntil", EmitDefaultValue = false)]
    //public DateTime ValidUntil { get; set; }
}
