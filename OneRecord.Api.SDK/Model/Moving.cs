using System.Runtime.Serialization;

namespace OneRecord.Api.SDK.Model;

[DataContract(Name = "Moving")]
public partial class Moving : LogisticsAction
{
    [DataMember(Name = "cargo:movementType", EmitDefaultValue = false)]
    public string MovementType { get; set; }
}
