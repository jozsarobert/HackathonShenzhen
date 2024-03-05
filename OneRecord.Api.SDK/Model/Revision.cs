using System.Runtime.Serialization;

namespace OneRecord.Api.SDK.Model;

[DataContract(Name = "Revision")]
public class Revision
{
    [DataMember(Name = "@value", EmitDefaultValue = false)]
    public int Value { get; set; }

    [DataMember(Name = "@type", EmitDefaultValue = false)]
    public string Type { get; set; }
}