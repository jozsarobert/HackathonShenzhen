using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Reelables.Api.SDK.Model;

[DataContract(Name = "PrintJobStatuses")]
public class PrintJobStatuses
{
    [JsonConstructor]
    protected PrintJobStatuses() { }

    [DataMember(Name = "nextToken", EmitDefaultValue = false)]
    public string NextToken { get; set; }

    [DataMember(Name = "items", IsRequired = true, EmitDefaultValue = true)]
    public List<PrintJobStatus> Items { get; set; }

}