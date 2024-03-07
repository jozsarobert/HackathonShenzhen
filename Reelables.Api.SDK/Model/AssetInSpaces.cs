using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Reelables.Api.SDK.Model;

[DataContract(Name = "AssetInSpaces")]
public class AssetInSpaces
{
    [JsonConstructor]
    protected AssetInSpaces() { }

    [DataMember(Name = "nextToken", EmitDefaultValue = false)]
    public string NextToken { get; set; }

    [DataMember(Name = "items", IsRequired = true, EmitDefaultValue = true)]
    public List<AssetInSpace> Items { get; set; }


}