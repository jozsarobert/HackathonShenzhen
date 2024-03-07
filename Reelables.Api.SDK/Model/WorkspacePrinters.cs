using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Reelables.Api.SDK.Model;

[DataContract(Name = "WorkspacePrinters")]
public class WorkspacePrinters
{
    [JsonConstructor]
    protected WorkspacePrinters() { }

    [DataMember(Name = "nextToken", EmitDefaultValue = false)]
    public string NextToken { get; set; }

    [DataMember(Name = "items", IsRequired = true, EmitDefaultValue = true)]
    public List<WorkspacePrinter> Items { get; set; }

  
}