using System.Runtime.Serialization;

namespace OneRecord.Data.Model.Model;

[DataContract(Name = "Context")]
public class Context
{
    [DataMember(Name = "cargo")]
    public string Cargo { get; set; }

    [DataMember(Name = "api")]
    public string Api { get; set; }

    [DataMember(Name = "@vocab")]
    public string Vocab { get; set; }
}