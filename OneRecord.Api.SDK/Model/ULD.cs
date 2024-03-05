using System.Runtime.Serialization;

namespace OneRecord.Api.SDK.Model;

[DataContract(Name = "ULD")]
public class ULD : LoadingUnit
{
    /// <summary>
    /// Gets or Sets Context
    /// </summary>
    [DataMember(Name = "@context", EmitDefaultValue = true)]
    public Context Context = new Context
    {
        Cargo = "cargo:"
    };

    [DataMember(Name = "cargo:uldSerialNumber", EmitDefaultValue = false)]
    public string UldSerialNumber { get; set; }
}
