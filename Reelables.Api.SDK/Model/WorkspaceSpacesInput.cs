using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Reelables.Api.SDK.Model;

[DataContract(Name = "WorkspaceSpacesInput")]
public class WorkspaceSpacesInput
{
    [JsonConstructor]
    protected WorkspaceSpacesInput() { }

    [DataMember(Name = "spaces", IsRequired = true, EmitDefaultValue = true)]
    public List<WorkspaceSpacesInputSpacesInner> Spaces { get; set; }
}