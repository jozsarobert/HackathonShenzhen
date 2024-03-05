using System.Runtime.Serialization;

namespace Tracking.Data.Model;

[DataContract(Name = "ULD")]
public class ULD : LoadingUnit
{
    [DataMember(Name = "@context", EmitDefaultValue = true)]
    public Context Context = new Context
    {
        Cargo = "cargo:"
    };

    [DataMember(Name = "cargo:uldSerialNumber", EmitDefaultValue = false)]
    public string UldSerialNumber { get; set; }
}
