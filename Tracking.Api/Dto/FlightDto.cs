using Tracking.Data.DomainModel;

namespace Tracking.Api.Dto
{
    public class FlightDto
    {
        public string FlightNo { get; set; }
        public string OriginCode { get; set; }
        public DateTime DepartureDateTime { get; set; }
        public string DestinationlCode { get; set; }
        public DateTime ArrivalDateTime { get; set; }
        public List<ShipmentDto> Shipments { get; }
    }
}
