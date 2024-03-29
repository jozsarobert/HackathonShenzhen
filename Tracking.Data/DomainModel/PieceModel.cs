﻿namespace Tracking.Data.DomainModel
{
    public class PieceModel
    {
        public int Id { get; set; }
        public double? CurrentTemperature { get; set; }
        public bool IsTemperatureControlled { get; set; }
        public string Location { get; set; }
        public Weight Weight { get; set; }
        public Volume Volume { get; set; }
        public FlightModel Flight { get; set; }
        public string AlertType { get; set; }
        public List<MeasuredTemperature> TemperatureHistory {get;set;}
        public double? MinTemperature { get;set; }   
        public double? MaxTemperature { get;set; }
    }
}