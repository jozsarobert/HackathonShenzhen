using System.Runtime.Serialization;

namespace Tracking.Data.Model;

[DataContract(Name = "Geolocation")]
public partial class Geolocation : EntityBase
{
    [DataMember(Name = "cargo:elevation", EmitDefaultValue = false)]
    public Value Elevation { get; set; }

    [DataMember(Name = "cargo:geolocationUnit", EmitDefaultValue = false)]
    public string GeolocationUnit { get; set; }

    [DataMember(Name = "cargo:latitude", EmitDefaultValue = false)]
    public double Latitude { get; set; }

    [DataMember(Name = "cargo:longitude", EmitDefaultValue = false)]
    public double Longitude { get; set; }
}
