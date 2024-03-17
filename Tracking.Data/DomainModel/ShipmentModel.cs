namespace Tracking.Data.DomainModel
{
    public class ShipmentModel
    {
        public int Id { get; set; }
        public string WaybillNumber { get; set; }
        public List<FlightModel> Flights { get; set; }
        public List<int> PieceIds { get; set; }
    }
}