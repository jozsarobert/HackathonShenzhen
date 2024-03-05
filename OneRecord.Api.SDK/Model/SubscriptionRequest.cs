using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace OneRecord.Api.SDK.Model;


[DataContract(Name = "SubscriptionRequest")]
public partial class SubscriptionRequest : EntityBase
{
    [DataMember(Name = "api:hasError", EmitDefaultValue = false)]
    public List<Error> HasError { get; set; }

    [DataMember(Name = "api:hasRequestStatus", EmitDefaultValue = false)]
    public RequestStatus HasRequestStatus { get; set; }

    [DataMember(Name = "api:isRequestedBy", EmitDefaultValue = false)]
    public Organization IsRequestedBy { get; set; }

    [DataMember(Name = "api:isRevokedBy", EmitDefaultValue = false)]
    public Organization IsRevokedBy { get; set; }

    [DataMember(Name = "api:isRequestedAt", EmitDefaultValue = false)]
    public DateTime IsRequestedAt { get; set; }

    [DataMember(Name = "api:isRevokedAt", EmitDefaultValue = false)]
    public DateTime IsRevokedAt { get; set; }

    [DataMember(Name = "api:hasAccessDelegation", EmitDefaultValue = false)]
    public AccessDelegation HasAccessDelegation { get; set; }

    [DataMember(Name = "api:hasChange", EmitDefaultValue = false)]
    public Change HasChange { get; set; }

    [DataMember(Name = "api:hasSubscription", EmitDefaultValue = false)]
    public Subscription HasSubscription { get; set; }
}
