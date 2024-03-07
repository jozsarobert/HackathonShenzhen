using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Reelables.Api.SDK.Model;

[DataContract(Name = "Coordinate")]
public class Coordinate
{
    [JsonConstructor]
    protected Coordinate() { }

    [DataMember(Name = "latitude", IsRequired = true, EmitDefaultValue = true)]
    public float Latitude { get; set; }

    [DataMember(Name = "longitude", IsRequired = true, EmitDefaultValue = true)]
    public float Longitude { get; set; }
}