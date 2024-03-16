using OneRecord.Data.Model.Model;

namespace Tracking.Api.Dto
{
    public class ShipmmentDto
    {
        public string Id { get; set; }
        public string WaybillNumber { get; set; }
        public List<FlightDto> Flights { get; set; }
        public DateTime DepartureDate {  get; set; }
        public List<string> Pieces { get; set; }
        public bool HasAlert { get; set; }
    }
}