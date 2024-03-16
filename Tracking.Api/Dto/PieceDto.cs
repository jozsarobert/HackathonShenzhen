using Tracking.Data.DomainModel;

namespace Tracking.Api.Dto
{
    public class PieceDto
    {
        public string Id { get; set; }
        public double? CurrentTemperature { get; set; }
        public bool IsTemperatureControlled { get; set; }
        public string Location { get; set; }
        public Weight Weight { get; set; }
        public Volume Volume { get; set; }
        public FlightModel Flight { get; set; }
        public string? AlertType { get; set; }
        public List<MeasuredTemperature> TemperatureHistory { get; set; }
    }
}