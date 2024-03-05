using System.Runtime.Serialization;

namespace OneRecord.Api.SDK.Model;

[DataContract(Name = "ContactDetail")]
public partial class ContactDetail : EntityBase
{
    [DataMember(Name = "cargo:contactDetailType", EmitDefaultValue = false)]
    public string HttpsCargocontactDetailType { get; set; }

    [DataMember(Name = "cargo:textualValue", EmitDefaultValue = false)]
    public string HttpsCargotextualValue { get; set; }
}
