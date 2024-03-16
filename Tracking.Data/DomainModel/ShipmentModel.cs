namespace Tracking.Data.DomainModel
{
    public class ShipmentModel
    {
        public string Id { get; set; }
        public string WaybillNumber { get; set; }
        public List<FlightModel> Shipment { get; set; }
        public List<string> Pieces { get; set; }
        public bool HasAlert { get; set; }
    }
}