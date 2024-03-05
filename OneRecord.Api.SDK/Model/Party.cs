using System.Collections.Generic;
using System.Runtime.Serialization;

namespace OneRecord.Api.SDK.Model;

/// <summary>
/// Party
/// </summary>
[DataContract(Name = "Party")]
public partial class Party : EntityBase
{
    [DataMember(Name = "cargo:organization", EmitDefaultValue = false)]
    public Organization Organization { get; set; }


    [DataMember(Name = "cargo:otherIdentifiers", EmitDefaultValue = false)]
    public List<OtherIdentifier> OtherIdentifiers { get; set; }


    [DataMember(Name = "cargo:partyDetails", EmitDefaultValue = false)]
    public Company PartyDetails { get; set; }


    [DataMember(Name = "cargo:role", EmitDefaultValue = false)]
    public string Role { get; set; }

}
