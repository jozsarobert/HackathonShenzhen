using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Reelables.Api.SDK.Model;

[DataContract(Name = "ConsignmentGateways")]
public class ConsignmentGateways
{
    [JsonConstructor]
    protected ConsignmentGateways() { }

        
    [DataMember(Name = "nextToken", EmitDefaultValue = false)]
    public string NextToken { get; set; }

    [DataMember(Name = "items", IsRequired = true, EmitDefaultValue = true)]
    public List<Gateway> Items { get; set; }
}