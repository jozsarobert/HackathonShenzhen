using System.Runtime.Serialization;

namespace OneRecord.Data.Model.Model
{
    [DataContract(Name = "LogisticsService")]
    public partial class LogisticsService : LogisticsObject
    {
        [DataMember(Name = "cargo:activitySequences", EmitDefaultValue = false)]
        public List<ActivitySequence> ActivitySequences { get; set; }
    }
}
