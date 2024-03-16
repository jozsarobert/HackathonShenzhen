using System.Runtime.Serialization;

namespace Tracking.Data.Model;

[DataContract(Name = "Booking")]
public partial class Booking : LogisticsService
{
    public Booking()
    {
        Type = new List<string>
        {
            "cargo:Booking"
        };
    }

    [DataMember(Name = "cargo:bookingRequest", EmitDefaultValue = false)]
    public BookingRequest BookingRequest { get; set; }

    [DataMember(Name = "cargo:updateBookingOptionRequests", EmitDefaultValue = false)]
    public BookingOptionRequest UpdateBookingOptionRequests { get; set; }

    [DataMember(Name = "cargo:issuedForWaybill", EmitDefaultValue = false)]
    public Waybill IssuedForWaybill { get; set; }

    [DataMember(Name = "cargo:bookingStatus", EmitDefaultValue = false)]
    public string BookingStatus { get; set; }

    [DataMember(Name = "cargo:waybillPrefix", EmitDefaultValue = false)]
    public string WaybillPrefix { get; set; }

    [DataMember(Name = "cargo:waybillNumber", EmitDefaultValue = false)]
    public string WaybillNumber { get; set; }

    public string BookingRequestId { get; internal set; }
}
