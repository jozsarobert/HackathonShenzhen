using System.Collections.Generic;
using System.Runtime.Serialization;

namespace OneRecord.Api.SDK.Model;

[DataContract(Name = "LogisticsEventCollection")]
public partial class LogisticsEventCollection : EntityBase
{
    [DataMember(Name = "api:hasItem", EmitDefaultValue = false)]
    public List<LogisticsEvent> HasItem { get; set; }

    [DataMember(Name = "api:hasTotalItem", EmitDefaultValue = false)]
    public int HasTotalItem { get; set; }
}
