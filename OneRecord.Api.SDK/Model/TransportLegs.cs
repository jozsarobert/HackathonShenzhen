using System;
using System.Runtime.Serialization;

namespace OneRecord.Api.SDK.Model;

[DataContract(Name = "TransportLegs")]
public class TransportLegs : LogisticsObject
{
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
