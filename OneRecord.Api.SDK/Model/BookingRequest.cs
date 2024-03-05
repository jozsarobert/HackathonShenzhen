using System.Runtime.Serialization;

namespace OneRecord.Api.SDK.Model;

[DataContract(Name = "BookingRequest")]
public partial class BookingRequest : LogisticsObject
{ 
    [DataMember(Name = "cargo:booking", EmitDefaultValue = false)]
    public Booking Booking { get; set; }

    [DataMember(Name = "cargo:bookingOption", EmitDefaultValue = false)]
    public BookingOption BookingOption { get; set; }
}
