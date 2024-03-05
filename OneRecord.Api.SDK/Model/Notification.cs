using System.Collections.Generic;
using System.Runtime.Serialization;

namespace OneRecord.Api.SDK.Model;

[DataContract(Name = "Notification")]
public partial class Notification : EntityBase
{
    [DataMember(Name = "api:hasEventType", EmitDefaultValue = false)]
    public NotificationEventType HasEventType { get; set; }

    [DataMember(Name = "api:hasLogisticsObject", EmitDefaultValue = false)]
    public LogisticsObject HasLogisticsObject { get; set; }

    [DataMember(Name = "api:hasLogisticsObjectType", EmitDefaultValue = false)]
    public string HasLogisticsObjectType { get; set; }

    [DataMember(Name = "api:isTriggeredBy", EmitDefaultValue = false)]
    public ActionRequest IsTriggeredBy { get; set; }

    [DataMember(Name = "api:hasChangedProperty", EmitDefaultValue = false)]
    public List<string> HasChangedProperty { get; set; }
}
