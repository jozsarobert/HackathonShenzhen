using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Reelables.Api.SDK.Model;


[DataContract(Name = "Location")]
public class Location
{

    [JsonConstructor]
    protected Location() { }
   
    [DataMember(Name = "coordinate", IsRequired = true, EmitDefaultValue = true)]
    public Coordinate Coordinate { get; set; }

    [DataMember(Name = "error", EmitDefaultValue = false)]
    public int Error { get; set; }

    [DataMember(Name = "timestamp", IsRequired = true, EmitDefaultValue = true)]
    public DateTime Timestamp { get; set; }

}