using System.Collections.Generic;
using System.Runtime.Serialization;

namespace OneRecord.Api.SDK.Model;

[DataContract(Name = "Organization")]
public partial class Organization : LogisticsAgent
{
    [DataMember(Name = "cargo:basedAtLocation", EmitDefaultValue = false)]
    public Location BasedAtLocation { get; set; }

    [DataMember(Name = "cargo:contactPersons", EmitDefaultValue = false)]
    public List<Actor> ContactPersons { get; set; }

    [DataMember(Name = "cargo:otherIdentifiers", EmitDefaultValue = false)]
    public List<OtherIdentifier> OtherIdentifiers { get; set; }

    [DataMember(Name = "cargo:parentOrganization", EmitDefaultValue = false)]
    public Organization ParentOrganization { get; set; }

    [DataMember(Name = "cargo:subOrganization", EmitDefaultValue = false)]
    public List<Organization> SubOrganization { get; set; }

    [DataMember(Name = "cargo:name", EmitDefaultValue = false)]
    public string Name { get; set; }

    [DataMember(Name = "cargo:shortName", EmitDefaultValue = false)]
    public string ShortName { get; set; }
}
