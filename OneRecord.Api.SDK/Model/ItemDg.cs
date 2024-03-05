using System.Runtime.Serialization;

namespace OneRecord.Api.SDK.Model;

[DataContract(Name = "ItemDg")]
public partial class ItemDg : Item
{
    [DataMember(Name = "cargo:emergencyContact", EmitDefaultValue = false)]
    public Person EmergencyContact { get; set; }

    [DataMember(Name = "cargo:netWeightMeasure", EmitDefaultValue = false)]
    public Value NetWeightMeasure { get; set; }

    [DataMember(Name = "cargo:reportableQuantity", EmitDefaultValue = false)]
    public string ReportableQuantity { get; set; }

    [DataMember(Name = "cargo:supplementaryInfoPrefix", EmitDefaultValue = false)]
    public string SupplementaryInfoPrefix { get; set; }

    [DataMember(Name = "cargo:supplementaryInfoSuffix", EmitDefaultValue = false)]
    public string SupplementaryInfoSuffix { get; set; }

  
}
