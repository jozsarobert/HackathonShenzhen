using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Reelables.Api.SDK.Model;

[DataContract(Name = "WorkspacePrintTemplate")]
public class WorkspacePrintTemplate
{

    [JsonConstructor]
    protected WorkspacePrintTemplate() { }
  
    [DataMember(Name = "requiredParams", EmitDefaultValue = false)]
    public List<string> RequiredParams { get; set; }

    [DataMember(Name = "templateId", IsRequired = true, EmitDefaultValue = true)]
    public string TemplateId { get; set; }

    [DataMember(Name = "workspaceId", IsRequired = true, EmitDefaultValue = true)]
    public Guid WorkspaceId { get; set; }
}