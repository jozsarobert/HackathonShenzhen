using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Reelables.Api.SDK.Model;

[DataContract(Name = "WorkspacePrinter")]
public class WorkspacePrinter
{

    [JsonConstructor]
    protected WorkspacePrinter() { }
    
    [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
    public string Name { get; set; }

    [DataMember(Name = "printerId", IsRequired = true, EmitDefaultValue = true)]
    public string PrinterId { get; set; }

    [DataMember(Name = "isOnline", EmitDefaultValue = true)]
    public bool IsOnline { get; set; }

    [DataMember(Name = "addedOn", EmitDefaultValue = false)]
    public DateTime AddedOn { get; set; }

    [DataMember(Name = "workspaceId", IsRequired = true, EmitDefaultValue = true)]
    public Guid WorkspaceId { get; set; }
}