using OneRecord.Data.Model.Model;

namespace Tracking.Api.Dto
{
    public class ShipmentDto
    {
        public int Id { get; set; }
        public string WaybillNumber { get; set; }
        public List<FlightDto> Flights { get; set; }
        public List<PieceDto> Pieces { get; set; }
        public bool HasAlert => Pieces.Any(x => x.HasAlert);
    }
}