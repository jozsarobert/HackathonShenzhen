using System.Runtime.Serialization;

namespace OneRecord.Data.Model.Model;

[DataContract(Name = "LogisticsActivity")]
public partial class LogisticsActivity : LogisticsObject
{

    //TODO fix it later
    //[DataMember(Name = "cargo:checkActions", EmitDefaultValue = false)]
    //public List<Check> CheckActions { get; set; }

    //[DataMember(Name = "cargo:contactDetails", EmitDefaultValue = false)]
    //public List<ContactDetail> ContactDetails { get; set; }

    //[DataMember(Name = "cargo:contactPersons", EmitDefaultValue = false)]
    //public List<Person> ContactPersons { get; set; }

    [DataMember(Name = "cargo:servedServices", EmitDefaultValue = false)]
    public List<LogisticsService> ServedServices { get; set; }

    [DataMember(Name = "cargo:executionStatus", EmitDefaultValue = false)]
    public string ExecutionStatus { get; set; }
}
