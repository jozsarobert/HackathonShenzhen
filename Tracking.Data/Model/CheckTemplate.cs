using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Tracking.Data.Model;

[DataContract(Name = "CheckTemplate")]
public partial class CheckTemplate : LogisticsObject
{
    [DataMember(Name = "cargo:involvedParties", EmitDefaultValue = false)]
    public List<Party> InvolvedParties { get; set; }

    [DataMember(Name = "cargo:legacyTemplate", EmitDefaultValue = false)]
    public ExternalReference LegacyTemplate { get; set; }

    [DataMember(Name = "cargo:questions", EmitDefaultValue = false)]
    public List<Question> Questions { get; set; }

    [DataMember(Name = "cargo:date", EmitDefaultValue = false)]
    public DateTime Date { get; set; }

    [DataMember(Name = "cargo:name", EmitDefaultValue = false)]
    public string Name { get; set; }

    [DataMember(Name = "cargo:templatePurpose", EmitDefaultValue = false)]
    public string TemplatePurpose { get; set; }

    [DataMember(Name = "cargo:version", EmitDefaultValue = false)]
    public string Version { get; set; }
}
