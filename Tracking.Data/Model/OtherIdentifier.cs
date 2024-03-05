using System.Runtime.Serialization;

namespace Tracking.Data.Model;

[DataContract(Name = "OtherIdentifier")]
public partial class OtherIdentifier : EntityBase
{
    [DataMember(Name = "cargo:otherIdentifierType", EmitDefaultValue = false)]
    public string OtherIdentifierType { get; set; }

    [DataMember(Name = "cargo:textualValue", EmitDefaultValue = false)]
    public string TextualValue { get; set; }
}
