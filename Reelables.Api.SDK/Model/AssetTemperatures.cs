using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Reelables.Api.SDK.Model;

[DataContract(Name = "AssetTemperatures")]
public class AssetTemperatures
{
    [JsonConstructor]
    protected AssetTemperatures() { }
       
    [DataMember(Name = "nextToken", EmitDefaultValue = false)]
    public string NextToken { get; set; }

    [DataMember(Name = "items", IsRequired = true, EmitDefaultValue = true)]
    public List<Temperature> Items { get; set; }

     
}