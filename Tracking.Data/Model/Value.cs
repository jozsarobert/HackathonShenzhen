using System.Runtime.Serialization;

namespace Tracking.Data.Model;

[DataContract(Name = "Value")]
public partial class Value
{
    [DataMember(Name = "cargo:numericalValue", EmitDefaultValue = false)]
    public double NumericalValue { get; set; }

    [DataMember(Name = "cargo:unit", EmitDefaultValue = false)]
    public string Unit { get; set; }
}
