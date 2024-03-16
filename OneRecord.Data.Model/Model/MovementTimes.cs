using System.Runtime.Serialization;

namespace OneRecord.Data.Model.Model
{
    [DataContract(Name = "MovementTimes")]
    public partial class MovementTimes : EntityBase
    {
        [DataMember(Name = "cargo:direction", EmitDefaultValue = false)]
        public string Direction { get; set; }

        [DataMember(Name = "cargo:movementMilestone", EmitDefaultValue = false)]
        public string MovementMilestone { get; set; }

        [DataMember(Name = "cargo:movementTimeType", EmitDefaultValue = false)]
        public string MovementTimeType { get; set; }

        [DataMember(Name = "cargo:movementTimestamp", EmitDefaultValue = false)]
        public DateTime MovementTimestamp { get; set; }
    }
}
