using System.Collections.Generic;
using System.Runtime.Serialization;

namespace OneRecord.Api.SDK.Model;

[DataContract(Name = "Change")]
public partial class Change : EntityBase
{
    [DataMember(Name = "@context", EmitDefaultValue = true)]
    public Context Context = new Context
    {
        Cargo = "cargo:",
        Api = "api:"
    };

    [DataMember(Name = "api:hasLogisticsObject", EmitDefaultValue = false)]
    public LogisticsObject HasLogisticsObject { get; set; }

    [DataMember(Name = "api:hasOperation", EmitDefaultValue = false)]
    public List<Operation> HasOperation { get; set; }

    [DataMember(Name = "api:hasDescription", EmitDefaultValue = false)]
    public string HasDescription { get; set; }

    [DataMember(Name = "api:hasRevision", EmitDefaultValue = false)]
    public Revision HasRevision { get; set; }

    [DataMember(Name = "api:notifyRequestStatusChange", EmitDefaultValue = false)]
    public bool NotifyRequestStatusChange { get; set; }
}
