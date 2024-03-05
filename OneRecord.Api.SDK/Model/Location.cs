using System.Collections.Generic;
using System.Runtime.Serialization;

namespace OneRecord.Api.SDK.Model;

[DataContract(Name = "Location")]
public partial class Location : PhysicalLogisticsObject
{
    [DataMember(Name = "cargo:address", EmitDefaultValue = false)]
    public Address Address { get; set; }

    [DataMember(Name = "cargo:forActions", EmitDefaultValue = false)]
    public List<LogisticsAction> ForActions { get; set; }

    [DataMember(Name = "cargo:geolocation", EmitDefaultValue = false)]
    public Geolocation Geolocation { get; set; }

    [DataMember(Name = "cargo:code", EmitDefaultValue = false)]
    public string Code { get; set; }

    [DataMember(Name = "cargo:locationName", EmitDefaultValue = false)]
    public string LocationName { get; set; }

    [DataMember(Name = "cargo:locationType", EmitDefaultValue = false)]
    public string LocationType { get; set; }
}
