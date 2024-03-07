using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Reelables.Api.SDK.Model;


[DataContract(Name = "WorkspaceAssetsInput_assets_inner")]
public class WorkspaceAssetsInputAssetsInner
{
    [JsonConstructor]
    protected WorkspaceAssetsInputAssetsInner() { }

    [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
    public string Name { get; set; }

    [DataMember(Name = "nfcId", EmitDefaultValue = false)]
    public string NfcId { get; set; }

  
}