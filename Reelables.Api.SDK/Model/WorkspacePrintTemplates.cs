using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Reelables.Api.SDK.Model;

[DataContract(Name = "WorkspacePrintTemplates")]
public class WorkspacePrintTemplates
{

    [JsonConstructor]
    protected WorkspacePrintTemplates() { }

    [DataMember(Name = "items", IsRequired = true, EmitDefaultValue = true)]
    public List<WorkspacePrintTemplate> Items { get; set; }
}