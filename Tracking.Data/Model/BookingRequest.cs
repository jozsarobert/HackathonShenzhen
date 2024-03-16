using System.Runtime.Serialization;

namespace Tracking.Data.Model;

[DataContract(Name = "BookingRequest")]
public partial class BookingRequest : LogisticsObject
{
    public BookingRequest()
    {
        Type = new List<string>
        {
            "cargo:BookingRequest"
        };
    }

    [DataMember(Name = "cargo:booking", EmitDefaultValue = false)]
    public Booking Booking { get; set; }

    [DataMember(Name = "cargo:bookingOption", EmitDefaultValue = false)]
    public BookingOption BookingOption { get; set; }
}
