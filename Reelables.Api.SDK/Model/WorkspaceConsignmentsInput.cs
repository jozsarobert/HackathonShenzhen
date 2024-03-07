using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Reelables.Api.SDK.Model;

[DataContract(Name = "WorkspaceConsignmentsInput")]
public class WorkspaceConsignmentsInput
{
    [JsonConstructor]
    protected WorkspaceConsignmentsInput() { }

    [DataMember(Name = "consignments", IsRequired = true, EmitDefaultValue = true)]
    public List<ConsignmentInput> Consignments { get; set; }
}