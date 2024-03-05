using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Tracking.Data.Model;

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
