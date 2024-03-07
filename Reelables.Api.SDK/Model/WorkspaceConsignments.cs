using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Reelables.Api.SDK.Model;

[DataContract(Name = "WorkspaceConsignments")]
public class WorkspaceConsignments
{
    [JsonConstructor]
    protected WorkspaceConsignments() { }
   

    [DataMember(Name = "nextToken", EmitDefaultValue = false)]
    public string NextToken { get; set; }

    [DataMember(Name = "items", IsRequired = true, EmitDefaultValue = true)]
    public List<Consignment> Items { get; set; }
}