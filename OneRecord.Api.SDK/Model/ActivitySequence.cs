using System.Runtime.Serialization;

namespace OneRecord.Api.SDK.Model;

[DataContract(Name = "ActivitySequence")]
public partial class ActivitySequence: EntityBase
{
    [DataMember(Name = "cargo:activity", EmitDefaultValue = false)]
    public LogisticsActivity Activity { get; set; }

    [DataMember(Name = "cargo:sequenceNumber", EmitDefaultValue = false)]
    public string SequenceNumber { get; set; }
}
