using System.Runtime.Serialization;

namespace OneRecord.Api.SDK.Model;

[DataContract(Name = "ErrorDetail")]
public partial class ErrorDetail : EntityBase 
{ 
    [DataMember(Name = "api:hasCode", EmitDefaultValue = false)]
    public string HasCode { get; set; }

    [DataMember(Name = "api:hasMessage", EmitDefaultValue = false)]
    public string HasMessage { get; set; }

    [DataMember(Name = "api:hasProperty", EmitDefaultValue = false)]
    public string HasProperty { get; set; }

    [DataMember(Name = "api:hasResource", EmitDefaultValue = false)]
    public string HasResource { get; set; }
}
