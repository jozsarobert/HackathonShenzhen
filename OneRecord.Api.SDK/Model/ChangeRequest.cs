using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace OneRecord.Api.SDK.Model;

[DataContract(Name = "ChangeRequest")]
public partial class ChangeRequest : EntityBase
{
    [DataMember(Name = "api:hasError", EmitDefaultValue = false)]
    public List<Error> HttpsApihasError { get; set; }

    [DataMember(Name = "api:hasRequestStatus", EmitDefaultValue = false)]
    public RequestStatus HttpsApihasRequestStatus { get; set; }

    [DataMember(Name = "api:isRequestedBy", EmitDefaultValue = false)]
    public Organization HttpsApiisRequestedBy { get; set; }

    [DataMember(Name = "api:isRevokedBy", EmitDefaultValue = false)]
    public Organization HttpsApiisRevokedBy { get; set; }

    [DataMember(Name = "api:isRequestedAt", EmitDefaultValue = false)]
    public DateTime HttpsApiisRequestedAt { get; set; }

    [DataMember(Name = "api:isRevokedAt", EmitDefaultValue = false)]
    public DateTime HttpsApiisRevokedAt { get; set; }

    [DataMember(Name = "api:hasAccessDelegation", EmitDefaultValue = false)]
    public AccessDelegation HttpsApihasAccessDelegation { get; set; }

    [DataMember(Name = "api:hasChange", EmitDefaultValue = false)]
    public Change HttpsApihasChange { get; set; }

    [DataMember(Name = "api:hasSubscription", EmitDefaultValue = false)]
    public Subscription HttpsApihasSubscription { get; set; }
}
