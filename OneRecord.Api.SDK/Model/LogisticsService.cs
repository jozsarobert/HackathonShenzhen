using System.Collections.Generic;
using System.Runtime.Serialization;

namespace OneRecord.Api.SDK.Model;

[DataContract(Name = "LogisticsService")]
public partial class LogisticsService : LogisticsObject
{
    [DataMember(Name = "cargo:activitySequences", EmitDefaultValue = false)]
    public List<ActivitySequence> ActivitySequences { get; set; }

    [DataMember(Name = "cargo:contactDetails", EmitDefaultValue = false)]
    public List<ContactDetail> ContactDetails { get; set; }

    [DataMember(Name = "cargo:contactPersons", EmitDefaultValue = false)]
    public List<Person> ContactPersons { get; set; }
}
