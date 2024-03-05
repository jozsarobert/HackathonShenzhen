using System.Runtime.Serialization;

namespace OneRecord.Api.SDK.Model;

[DataContract(Name = "Characteristic")]
public partial class Characteristic : EntityBase
{
    [DataMember(Name = "cargo:ofProduct", EmitDefaultValue = false)]
    public Product HttpsCargoofProduct { get; set; }

    [DataMember(Name = "cargo:characteristicType", EmitDefaultValue = false)]
    public string HttpsCargocharacteristicType { get; set; }

    [DataMember(Name = "cargo:textualValue", EmitDefaultValue = false)]
    public string HttpsCargotextualValue { get; set; }
}
