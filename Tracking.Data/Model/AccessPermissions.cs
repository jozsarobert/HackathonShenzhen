using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Tracking.Data.Model;

[DataContract(Name = "AccessPermissions")]
public partial class AccessPermissions : EntityBase
{
    [DataMember(Name = "api:hasLogisticsAgent", EmitDefaultValue = false)]
    public LogisticsAgent HasLogisticsAgent { get; set; }

    [DataMember(Name = "api:hasLogisticsObject", EmitDefaultValue = false)]
    public LogisticsObject HasLogisticsObject { get; set; }

    [DataMember(Name = "api:hasPermission", EmitDefaultValue = false)]
    public List<Permission> HasPermission { get; set; }

}
