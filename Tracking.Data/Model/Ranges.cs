using System.Runtime.Serialization;

namespace Tracking.Data.Model;

[DataContract(Name = "Ranges")]
public partial class Ranges : EntityBase
{
    [DataMember(Name = "cargo:amount", EmitDefaultValue = false)]
    public double Amount { get; set; }

    [DataMember(Name = "cargo:maximumQuantity", EmitDefaultValue = false)]
    public double MaximumQuantity { get; set; }

    [DataMember(Name = "cargo:minimumQuantity", EmitDefaultValue = false)]
    public double MinimumQuantity { get; set; }

    [DataMember(Name = "cargo:rateClassCode", EmitDefaultValue = false)]
    public string RateClassCode { get; set; }

    [DataMember(Name = "cargo:ratingType", EmitDefaultValue = false)]
    public string RatingType { get; set; }

    [DataMember(Name = "cargo:scr", EmitDefaultValue = false)]
    public string Scr { get; set; }

    [DataMember(Name = "cargo:unitBasis", EmitDefaultValue = false)]
    public string UnitBasis { get; set; }
}
