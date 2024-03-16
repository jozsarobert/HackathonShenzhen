using System.Runtime.Serialization;

namespace OneRecord.Data.Model.Model
{
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

        [DataMember(Name = "cargo:issuedForWaybill", EmitDefaultValue = false)]
        public Waybill IssuedForWaybill { get; set; }

        [DataMember(Name = "cargo:bookingStatus", EmitDefaultValue = false)]
        public string? BookingStatus { get; set; }

        [DataMember(Name = "cargo:waybillPrefix", EmitDefaultValue = false)]
        public string WaybillPrefix { get; set; }

        [DataMember(Name = "cargo:waybillNumber", EmitDefaultValue = false)]
        public string WaybillNumber { get; set; }

    }
}
