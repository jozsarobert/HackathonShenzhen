using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Reelables.Api.SDK.Model;

[DataContract(Name = "FacilityAssetGroups")]
public class FacilityAssetGroups
{

    [JsonConstructor]
    protected FacilityAssetGroups() { }
    
    [DataMember(Name = "nextToken", EmitDefaultValue = false)]
    public string NextToken { get; set; }

    [DataMember(Name = "items", IsRequired = true, EmitDefaultValue = true)]
    public List<AssetGroup> Items { get; set; }
}