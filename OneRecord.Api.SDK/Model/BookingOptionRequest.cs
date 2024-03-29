using System.Collections.Generic;
using System.Runtime.Serialization;

namespace OneRecord.Api.SDK.Model;


[DataContract(Name = "BookingOptionRequest")]
public partial class BookingOptionRequest : LogisticsObject
{
    [DataMember(Name = "cargo:bookingOption", EmitDefaultValue = false)]
    public List<BookingOption> BookingOption { get; set; }


    [DataMember(Name = "cargo:bookingShipmentDetails", EmitDefaultValue = false)]
    public BookingShipment BookingShipmentDetails { get; set; }

    [DataMember(Name = "cargo:ratingsPreference", EmitDefaultValue = false)]
    public Ratings RatingsPreference { get; set; }

    [DataMember(Name = "cargo:routingPreference", EmitDefaultValue = false)]
    public Routing RoutingPreference { get; set; }

    [DataMember(Name = "cargo:shipmentDetails", EmitDefaultValue = false)]
    public Shipment ShipmentDetails { get; set; }

    [DataMember(Name = "cargo:timePreferences", EmitDefaultValue = false)]
    public BookingTimes TimePreferences { get; set; }

    [DataMember(Name = "cargo:transportMovement", EmitDefaultValue = false)]
    public TransportMovement TransportMovement { get; set; }

    [DataMember(Name = "cargo:unitsPreference", EmitDefaultValue = false)]
    public Value UnitsPreference { get; set; }

    [DataMember(Name = "cargo:allotment", EmitDefaultValue = false)]
    public string Allotment { get; set; }

    [DataMember(Name = "cargo:expectedCommodities", EmitDefaultValue = false)]
    public List<string> ExpectedCommodities { get; set; }

    [DataMember(Name = "cargo:requestedHandling", EmitDefaultValue = false)]
    public List<string> RequestedHandling { get; set; }

    [DataMember(Name = "cargo:shipmentSecurityStatus", EmitDefaultValue = false)]
    public string ShipmentSecurityStatus { get; set; }
}
