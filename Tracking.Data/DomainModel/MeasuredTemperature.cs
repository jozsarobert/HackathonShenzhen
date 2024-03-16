namespace Tracking.Data.DomainModel
{
    public class MeasuredTemperature
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public DateTime Timestamp { get; set; }
    }
}