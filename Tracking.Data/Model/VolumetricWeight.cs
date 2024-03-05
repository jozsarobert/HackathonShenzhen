using System.Runtime.Serialization;

namespace Tracking.Data.Model;

[DataContract(Name = "VolumetricWeight")]
public partial class VolumetricWeight : EntityBase
{
    [DataMember(Name = "cargo:chargeableWeight", EmitDefaultValue = false)]
    public Value ChargeableWeight { get; set; }

    [DataMember(Name = "cargo:conversionFactor", EmitDefaultValue = false)]
    public Value ConversionFactor { get; set; }
}
