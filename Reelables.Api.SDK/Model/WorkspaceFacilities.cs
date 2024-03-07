using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Reelables.Api.SDK.Model;

[DataContract(Name = "WorkspaceFacilities")]
public class WorkspaceFacilities
{

    [JsonConstructor]
    protected WorkspaceFacilities() { }

    [DataMember(Name = "nextToken", EmitDefaultValue = false)]
    public string NextToken { get; set; }

    [DataMember(Name = "items", IsRequired = true, EmitDefaultValue = true)]
    public List<Facility> Items { get; set; }

   
}