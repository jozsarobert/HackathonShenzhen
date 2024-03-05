using System.Runtime.Serialization;

namespace OneRecord.Api.SDK.Model;

[DataContract(Name = "OperationObject")]
public partial class OperationObject : EntityBase
{ 
    [DataMember(Name = "api:hasDatatype", EmitDefaultValue = false)]
    public string HasDatatype { get; set; }

    [DataMember(Name = "api:hasValue", EmitDefaultValue = false)]
    public string HasValue { get; set; }
}
