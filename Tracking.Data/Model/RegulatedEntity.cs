using System;
using System.Runtime.Serialization;

namespace Tracking.Data.Model;

[DataContract(Name = "RegulatedEntity")]
public partial class RegulatedEntity : EntityBase
{
    [DataMember(Name = "cargo:regulatedEntityIdentifier", EmitDefaultValue = false)]
    public string RegulatedEntityIdentifier { get; set; }

    //[DataMember(Name = "cargo:identifier", EmitDefaultValue = false)]
    //public Company Identifier { get; set; }

    [DataMember(Name = "cargo:owningOrganization", EmitDefaultValue = false)]
    public Organization OwningOrganization { get; set; }

    [DataMember(Name = "cargo:regulatedEntityCategory", EmitDefaultValue = false)]
    public string RegulatedEntityCategory { get; set; }

    [DataMember(Name = "cargo:regulatedEntityExpiryDate", EmitDefaultValue = false)]
    public DateTime RegulatedEntityExpiryDate { get; set; }
}
