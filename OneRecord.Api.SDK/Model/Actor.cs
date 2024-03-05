using System.Runtime.Serialization;

namespace OneRecord.Api.SDK.Model;

[DataContract(Name = "Actor")]
public partial class Actor : LogisticsAgent
{
    [DataMember(Name = "cargo:associatedOrganization", EmitDefaultValue = false)]
    public Organization AssociatedOrganization { get; set; }

}
