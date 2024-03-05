using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Tracking.Data.Model;

[DataContract(Name = "LogisticsEvent")]
public partial class LogisticsEvent : EntityBase
{
    [DataMember(Name = "cargo:externalReferences", EmitDefaultValue = false)]
    public List<ExternalReference> ExternalReferences { get; set; }

    [DataMember(Name = "cargo:linkedObject", EmitDefaultValue = false)]
    public LogisticsObject LinkedObject { get; set; }

    [DataMember(Name = "cargo:recordedAtLocation", EmitDefaultValue = false)]
    public Location RecordedAtLocation { get; set; }

    [DataMember(Name = "cargo:recordedBy", EmitDefaultValue = false)]
    public Organization RecordedBy { get; set; }

    [DataMember(Name = "cargo:recordedByActor", EmitDefaultValue = false)]
    public Actor RecordedByActor { get; set; }

    [DataMember(Name = "cargo:creationDate", EmitDefaultValue = false)]
    public DateTime CreationDate { get; set; }

    [DataMember(Name = "cargo:eventCode", EmitDefaultValue = false)]
    public string EventCode { get; set; }

    [DataMember(Name = "cargo:eventDate", EmitDefaultValue = false)]
    public DateTime EventDate { get; set; }

    [DataMember(Name = "cargo:eventName", EmitDefaultValue = false)]
    public string EventName { get; set; }

    [DataMember(Name = "cargo:eventTimeType", EmitDefaultValue = false)]
    public string EeventTimeType { get; set; }
}
