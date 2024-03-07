using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Reelables.Api.SDK.Model;

[DataContract(Name = "Temperature")]
public class Temperature
{
    [JsonConstructor]
    protected Temperature() { }
    
    [DataMember(Name = "degreesCelcius", IsRequired = true, EmitDefaultValue = true)]
    public float DegreesCelcius { get; set; }

    [DataMember(Name = "timestamp", IsRequired = true, EmitDefaultValue = true)]
    public DateTime Timestamp { get; set; }

    [DataMember(Name = "numberReadings", EmitDefaultValue = false)]
    public int NumberReadings { get; set; }
}