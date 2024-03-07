using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Reelables.Api.SDK.Model;


[DataContract(Name = "WorkspaceSpacesInput_spaces_inner")]
public class WorkspaceSpacesInputSpacesInner
{
    [JsonConstructor]
    protected WorkspaceSpacesInputSpacesInner() { }
    
    [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
    public string Name { get; set; }

    [DataMember(Name = "gatewayId", EmitDefaultValue = false)]
    public string GatewayId { get; set; }
}