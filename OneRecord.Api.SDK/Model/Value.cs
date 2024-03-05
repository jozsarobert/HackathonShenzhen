using System.Runtime.Serialization;

namespace OneRecord.Api.SDK.Model;

[DataContract(Name = "Value")]
public partial class Value :EntityBase
{ 
    [DataMember(Name = "cargo:numericalValue", EmitDefaultValue = false)]
    public double NumericalValue { get; set; }

    [DataMember(Name = "cargo:unit", EmitDefaultValue = false)]
    public string Unit { get; set; }
}
