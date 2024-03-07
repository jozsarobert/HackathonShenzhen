using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Reelables.Api.SDK.Model;

[DataContract(Name = "Workspace")]
public class Workspace
{

    [JsonConstructor]
    protected Workspace() { }

    [DataMember(Name = "printers", EmitDefaultValue = false)]
    public WorkspacePrinters Printers { get; set; }

    [DataMember(Name = "assets", EmitDefaultValue = false)]
    public WorkspaceAssets Assets { get; set; }

    [DataMember(Name = "printTemplates", EmitDefaultValue = false)]
    public WorkspacePrintTemplates PrintTemplates { get; set; }

    [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
    public string Name { get; set; }

    [DataMember(Name = "spaces", EmitDefaultValue = false)]
    public WorkspaceSpaces Spaces { get; set; }

    [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
    public Guid Id { get; set; }
}