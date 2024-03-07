using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Reelables.Api.SDK.Model;

[DataContract(Name = "WorkspaceAssetsInput")]
public class WorkspaceAssetsInput
{
    [JsonConstructor]
    protected WorkspaceAssetsInput() { }
    
    [DataMember(Name = "assets", IsRequired = true, EmitDefaultValue = true)]
    public List<WorkspaceAssetsInputAssetsInner> Assets { get; set; }
}