using System.Runtime.Serialization;

namespace Tracking.Data.Model;

[DataContract(Name = "Actor")]
public partial class Actor : LogisticsAgent
{
    [DataMember(Name = "cargo:associatedOrganization", EmitDefaultValue = false)]
    public Organization AssociatedOrganization { get; set; }

}
