using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace OneRecord.Api.SDK.Model;

[DataContract(Name = "ExternalReference")]
public partial class ExternalReference : LogisticsObject
{
    [DataMember(Name = "cargo:linkedLogisticObjects", EmitDefaultValue = false)]
    public List<LogisticsObject> LinkedLogisticObjects { get; set; }

    [DataMember(Name = "cargo:locationOfCreation", EmitDefaultValue = false)]
    public Location LocationOfCreation { get; set; }

    [DataMember(Name = "cargo:originator", EmitDefaultValue = false)]
    public Company Originator { get; set; }

    [DataMember(Name = "cargo:checksum", EmitDefaultValue = false)]
    public string Checksum { get; set; }

    [DataMember(Name = "cargo:documentIdentifier", EmitDefaultValue = false)]
    public string DocumentIdentifier { get; set; }

    [DataMember(Name = "cargo:documentLink", EmitDefaultValue = false)]
    public string DocumentLink { get; set; }

    [DataMember(Name = "cargo:documentName", EmitDefaultValue = false)]
    public string DocumentName { get; set; }

    [DataMember(Name = "cargo:documentType", EmitDefaultValue = false)]
    public string DocumentType { get; set; }

    [DataMember(Name = "cargo:documentVersion", EmitDefaultValue = false)]
    public string DocumentVersion { get; set; }

    [DataMember(Name = "cargo:validFrom", EmitDefaultValue = false)]
    public DateTime ValidFrom { get; set; }

    [DataMember(Name = "cargo:validUntil", EmitDefaultValue = false)]
    public DateTime ValidUntil { get; set; }
}
