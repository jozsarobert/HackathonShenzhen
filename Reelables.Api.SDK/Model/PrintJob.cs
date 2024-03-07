
using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Reelables.Api.SDK.Model;


[DataContract(Name = "PrintJob")]
public class PrintJob
{

    [JsonConstructor]
    protected PrintJob() { }
    
    [DataMember(Name = "origin", IsRequired = true, EmitDefaultValue = true)]
    public string Origin { get; set; }

    [DataMember(Name = "replaceExistingLabel", EmitDefaultValue = true)]
    public bool ReplaceExistingLabel { get; set; }

    [DataMember(Name = "includeCutLine", EmitDefaultValue = true)]
    public bool IncludeCutLine { get; set; }

    [DataMember(Name = "templateId", EmitDefaultValue = false)]
    public string TemplateId { get; set; }

    [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
    public DateTime CreatedAt { get; set; }

    [DataMember(Name = "isSuccessful", EmitDefaultValue = true)]
    public bool IsSuccessful { get; set; }

    [DataMember(Name = "assetId", IsRequired = true, EmitDefaultValue = true)]
    public string AssetId { get; set; }

    [DataMember(Name = "failureReason", EmitDefaultValue = false)]
    public string FailureReason { get; set; }

    [DataMember(Name = "printerId", IsRequired = true, EmitDefaultValue = true)]
    public string PrinterId { get; set; }

    [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
    public Guid Id { get; set; }

    [DataMember(Name = "workspaceId", IsRequired = true, EmitDefaultValue = true)]
    public Guid WorkspaceId { get; set; }

    [DataMember(Name = "updatedAt", EmitDefaultValue = false)]
    public DateTime UpdatedAt { get; set; }

    [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
    public string Status { get; set; }

    [DataMember(Name = "isComplete", EmitDefaultValue = true)]
    public bool IsComplete { get; set; }
}