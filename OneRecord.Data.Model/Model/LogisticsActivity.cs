using System.Runtime.Serialization;

namespace OneRecord.Data.Model.Model;

[DataContract(Name = "LogisticsActivity")]
public partial class LogisticsActivity : LogisticsObject
{
    [DataMember(Name = "cargo:servedServices", EmitDefaultValue = false)]
    public List<LogisticsService> ServedServices { get; set; }

    [DataMember(Name = "cargo:executionStatus", EmitDefaultValue = false)]
    public string ExecutionStatus { get; set; }
}
