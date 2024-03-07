using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Reelables.Api.SDK.Model;

[DataContract(Name = "AssetInSpace")]
public class AssetInSpace 
{
    [JsonConstructor]
    protected AssetInSpace() { }
       
    [DataMember(Name = "spaceName", IsRequired = true, EmitDefaultValue = true)]
    public string SpaceName { get; set; }

    [DataMember(Name = "spaceId", IsRequired = true, EmitDefaultValue = true)]
    public string SpaceId { get; set; }

    [DataMember(Name = "hasExited", EmitDefaultValue = true)]
    public bool HasExited { get; set; }

    [DataMember(Name = "enteredOn", IsRequired = true, EmitDefaultValue = true)]
    public DateTime EnteredOn { get; set; }

    [DataMember(Name = "exitedOn", EmitDefaultValue = false)]
    public DateTime ExitedOn { get; set; }    
}