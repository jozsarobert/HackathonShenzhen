using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Reelables.Api.SDK.Model;

[DataContract(Name = "WorkspacePrinterInput")]
public class WorkspacePrinterInput
{
    [JsonConstructor]
    protected WorkspacePrinterInput() { }

    [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
    public string Name { get; set; }
}