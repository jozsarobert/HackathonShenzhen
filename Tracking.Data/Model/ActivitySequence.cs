using System.Runtime.Serialization;

namespace Tracking.Data.Model;

[DataContract(Name = "ActivitySequence")]
public partial class ActivitySequence : EntityBase
{
    [DataMember(Name = "cargo:activity", EmitDefaultValue = false)]
    public LogisticsActivity Activity { get; set; }

    [DataMember(Name = "cargo:sequenceNumber", EmitDefaultValue = false)]
    public string SequenceNumber { get; set; }
}
