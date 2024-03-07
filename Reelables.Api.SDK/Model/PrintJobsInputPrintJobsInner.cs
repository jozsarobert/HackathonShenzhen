using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Reelables.Api.SDK.Model;

[DataContract(Name = "PrintJobsInput_printJobs_inner")]
public class PrintJobsInputPrintJobsInner
{
 
    [JsonConstructor]
    protected PrintJobsInputPrintJobsInner() { }

    [DataMember(Name = "assetId", IsRequired = true, EmitDefaultValue = true)]
    public string AssetId { get; set; }

    [DataMember(Name = "replaceExistingLabel", EmitDefaultValue = true)]
    public bool ReplaceExistingLabel { get; set; }

    [DataMember(Name = "templateParams", EmitDefaultValue = false)]
    public Dictionary<string, Object> TemplateParams { get; set; }

    [DataMember(Name = "templateId", EmitDefaultValue = false)]
    public string TemplateId { get; set; }
}