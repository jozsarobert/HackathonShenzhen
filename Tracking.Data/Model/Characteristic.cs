using System.Runtime.Serialization;

namespace Tracking.Data.Model;

[DataContract(Name = "Characteristic")]
public partial class Characteristic : EntityBase
{
    [DataMember(Name = "cargo:ofProduct", EmitDefaultValue = false)]
    public Product OfProduct { get; set; }

    [DataMember(Name = "cargo:characteristicType", EmitDefaultValue = false)]
    public string CharacteristicType { get; set; }

    [DataMember(Name = "cargo:textualValue", EmitDefaultValue = false)]
    public string TextualValue { get; set; }
}
