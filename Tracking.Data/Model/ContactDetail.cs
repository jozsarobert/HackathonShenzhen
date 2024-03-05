using System.Runtime.Serialization;

namespace Tracking.Data.Model;

[DataContract(Name = "ContactDetail")]
public partial class ContactDetail : EntityBase
{
    [DataMember(Name = "cargo:contactDetailType", EmitDefaultValue = false)]
    public string ContactDetailType { get; set; }

    [DataMember(Name = "cargo:textualValue", EmitDefaultValue = false)]
    public string TextualValue { get; set; }
}
