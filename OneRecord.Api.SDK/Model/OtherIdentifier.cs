using System.Runtime.Serialization;

namespace OneRecord.Api.SDK.Model;

[DataContract(Name = "OtherIdentifier")]
public partial class OtherIdentifier : EntityBase
{
    [DataMember(Name = "cargo:otherIdentifierType", EmitDefaultValue = false)]
    public string OtherIdentifierType { get; set; }

    [DataMember(Name = "cargo:textualValue", EmitDefaultValue = false)]
    public string TextualValue { get; set; }
}
