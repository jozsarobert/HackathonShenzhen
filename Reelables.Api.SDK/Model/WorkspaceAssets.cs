using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Reelables.Api.SDK.Model;

[DataContract(Name = "WorkspaceAssets")]
public class WorkspaceAssets
{
    [JsonConstructor]
    protected WorkspaceAssets() { }

    [DataMember(Name = "total", EmitDefaultValue = false)]
    public int Total { get; set; }

    [DataMember(Name = "nextToken", EmitDefaultValue = false)]
    public string NextToken { get; set; }

    [DataMember(Name = "items", IsRequired = true, EmitDefaultValue = true)]
    public List<Asset> Items { get; set; }
}