using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Tracking.Data.Model;

[DataContract(Name = "Subscription")]
public partial class Subscription : EntityBase
{
    [DataMember(Name = "api:hasSubscriber", EmitDefaultValue = false)]
    public Organization HasSubscriber { get; set; }

    [DataMember(Name = "api:hasTopicType", EmitDefaultValue = false)]
    public TopicType HasTopicType { get; set; }

    [DataMember(Name = "api:expiresAt", EmitDefaultValue = false)]
    public DateTime ExpiresAt { get; set; }

    [DataMember(Name = "api:hasContentType", EmitDefaultValue = false)]
    public List<string> HasContentType { get; set; }

    [DataMember(Name = "api:hasDescription", EmitDefaultValue = false)]
    public string HasDescription { get; set; }

    [DataMember(Name = "api:hasTopic", EmitDefaultValue = false)]
    public string HasTopic { get; set; }

    [DataMember(Name = "api:notifyRequestStatusChange", EmitDefaultValue = false)]
    public List<string> NotifyRequestStatusChange { get; set; }

    [DataMember(Name = "api:sendLogisticsObjectBody", EmitDefaultValue = false)]
    public List<string> SendLogisticsObjectBody { get; set; }

    [DataMember(Name = "api:includeSubscriptionEventType", EmitDefaultValue = false)]
    public List<string> IncludeSubscriptionEventType { get; set; }
}
