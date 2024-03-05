using System.Runtime.Serialization;

namespace OneRecord.Api.SDK.Model;

[DataContract(Name = "Booking")]
public partial class Booking : LogisticsService
{
    [DataMember(Name = "cargo:forBookingRequest", EmitDefaultValue = false)]
    public BookingRequest ForBookingRequest { get; set; }

    [DataMember(Name = "cargo:issuedForWaybill", EmitDefaultValue = false)]
    public Waybill IssuedForWaybill { get; set; }
}
