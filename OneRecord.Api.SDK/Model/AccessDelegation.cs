#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System.Collections.Generic;
using System.Runtime.Serialization;

namespace OneRecord.Api.SDK.Model;

[DataContract(Name = "AccessDelegation")]
public partial class AccessDelegation : EntityBase
{
    [DataMember(Name = "api:hasLogisticsObject", EmitDefaultValue = false)]
    public List<LogisticsObject> HasLogisticsObject { get; set; }

    [DataMember(Name = "api:hasPermission", EmitDefaultValue = false)]
    public List<Permission> HasPermission { get; set; }

    [DataMember(Name = "api:isRequestedFor", EmitDefaultValue = false)]
    public List<Organization> IsRequestedFor { get; set; }

    [DataMember(Name = "api:hasDescription", EmitDefaultValue = false)]
    public string HasDescription { get; set; }

    [DataMember(Name = "api:notifyRequestStatusChange", EmitDefaultValue = true)]
    public bool NotifyRequestStatusChange { get; set; }
}
