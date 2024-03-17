namespace Tracking.Api.Dto
{

    //shipments with alerts
    public class AlertDto
    {
        public string FlightNo { get; set; }
        public string OriginCode { get; set; }
        public string DestinationCode { get; set; }
        public DateTime DepartureTime { get; set; }
        public int PiecesCount { get; set; }
    }
}