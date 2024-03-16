using System;
using System.Runtime.Serialization;

namespace Tracking.Data.Model;

[DataContract(Name = "TransportLegs")]
public class TransportLegs : LogisticsObject
{
    public TransportLegs()
    {
        Type = new List<string>
        {
            "cargo:TransportLegs",
            "cargo:LogisticsObject"
        };
    }

    [DataMember(Name = "@context", EmitDefaultValue = true)]
    public Context Context = new Context
    {
        Cargo = "cargo:"
    };

    [DataMember(Name = "cargo:arrivalLocation", EmitDefaultValue = false)]
    public Location ArrivalLocation { get; set; }

    [DataMember(Name = "cargo:departureLocation", EmitDefaultValue = false)]
    public Location DepartureLocation { get; set; }

    [DataMember(Name = "cargo:transportIdentifier", EmitDefaultValue = false)]
    public string TransportIdentifier { get; set; }

    [DataMember(Name = "cargo:departureDate", EmitDefaultValue = false)]
    public DateTime DepartureDate { get; set; }

    [DataMember(Name = "cargo:legNumber", EmitDefaultValue = false)]
    public int LegNumber { get; set; }
}
