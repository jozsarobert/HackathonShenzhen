using System.Runtime.Serialization;

namespace OneRecord.Data.Model.Model;

[DataContract(Name = "LogisticsAction")]
public partial class LogisticsAction : LogisticsObject
{
    [DataMember(Name = "cargo:servedActivity", EmitDefaultValue = false)]
    public LogisticsActivity ServedActivity { get; set; }

    [DataMember(Name = "cargo:actionEndTime", EmitDefaultValue = false)]
    public DateTime ActionEndTime { get; set; }

    [DataMember(Name = "cargo:actionStartTime", EmitDefaultValue = false)]
    public DateTime ActionStartTime { get; set; }

    [DataMember(Name = "cargo:actionTimeType", EmitDefaultValue = false)]
    public string ActionTimeType { get; set; }
}
