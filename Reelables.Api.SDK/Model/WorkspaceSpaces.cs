using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Reelables.Api.SDK.Model;

[DataContract(Name = "WorkspaceSpaces")]
public class WorkspaceSpaces
{
    [JsonConstructor]
    protected WorkspaceSpaces() { }

    [DataMember(Name = "total", EmitDefaultValue = false)]
    public int Total { get; set; }

    [DataMember(Name = "nextToken", EmitDefaultValue = false)]
    public string NextToken { get; set; }

    [DataMember(Name = "items", IsRequired = true, EmitDefaultValue = true)]
    public List<Space> Items { get; set; }
}