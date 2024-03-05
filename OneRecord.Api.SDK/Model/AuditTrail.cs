using System.Collections.Generic;
using System.Runtime.Serialization;

namespace OneRecord.Api.SDK.Model;

[DataContract(Name = "AuditTrail")]
public partial class AuditTrail : EntityBase 
{ 
    [DataMember(Name = "api:hasChangeRequest", EmitDefaultValue = false)]
    public List<ChangeRequest> HasChangeRequest { get; set; }

    [DataMember(Name = "api:hasLatestRevision", EmitDefaultValue = false)]
    public int HasLatestRevision { get; set; }
}
