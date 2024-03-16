using System.Runtime.Serialization;

namespace OneRecord.Data.Model.Model;

[DataContract(Name = "Value")]
public partial class Value
{
    [DataMember(Name = "cargo:numericalValue", EmitDefaultValue = false)]
    public double NumericalValue { get; set; }

    [DataMember(Name = "cargo:unit", EmitDefaultValue = false)]
    public string Unit { get; set; }

    public Dimensions Dimensions { get; set; }
    public string DimensionId { get; set; }
}
