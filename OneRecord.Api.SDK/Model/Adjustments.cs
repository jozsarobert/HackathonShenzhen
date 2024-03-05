using System.Runtime.Serialization;

namespace OneRecord.Api.SDK.Model;

[DataContract(Name = "Adjustments")]
public partial class Adjustments : EntityBase
{
    [DataMember(Name = "cargo:correctionNumber", EmitDefaultValue = false)]
    public int CorrectionNumber { get; set; }

    [DataMember(Name = "cargo:correctionSerialNumber", EmitDefaultValue = false)]
    public string CorrectionSerialNumber { get; set; }

    [DataMember(Name = "cargo:reasonsForAdjustments", EmitDefaultValue = false)]
    public string ReasonsForAdjustments { get; set; }
}
