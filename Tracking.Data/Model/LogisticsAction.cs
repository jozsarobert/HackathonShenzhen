using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Tracking.Data.Model;

[DataContract(Name = "LogisticsAction")]
public partial class LogisticsAction : LogisticsObject
{
    [DataMember(Name = "cargo:contactDetails", EmitDefaultValue = false)]
    public List<ContactDetail> ContactDetails { get; set; }

    [DataMember(Name = "cargo:contactPersons", EmitDefaultValue = false)]
    public List<Person> ContactPersons { get; set; }

    [DataMember(Name = "cargo:locationOfPerformance", EmitDefaultValue = false)]
    public Location LocationOfPerformance { get; set; }

    [DataMember(Name = "cargo:servedActivity", EmitDefaultValue = false)]
    public LogisticsActivity ServedActivity { get; set; }

    [DataMember(Name = "cargo:actionEndTime", EmitDefaultValue = false)]
    public DateTime ActionEndTime { get; set; }

    [DataMember(Name = "cargo:actionStartTime", EmitDefaultValue = false)]
    public DateTime ActionStartTime { get; set; }

    [DataMember(Name = "cargo:actionTimeType", EmitDefaultValue = false)]
    public string ActionTimeType { get; set; }
}
