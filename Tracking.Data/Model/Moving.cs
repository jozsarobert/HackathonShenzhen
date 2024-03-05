using System.Runtime.Serialization;

namespace Tracking.Data.Model;

[DataContract(Name = "Moving")]
public partial class Moving : LogisticsAction
{
    [DataMember(Name = "cargo:movementType", EmitDefaultValue = false)]
    public string MovementType { get; set; }
}
