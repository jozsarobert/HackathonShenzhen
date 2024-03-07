using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Reelables.Api.SDK.Model;

[DataContract(Name = "PrintJobsInput")]
public class PrintJobsInput
{

    [JsonConstructor]
    protected PrintJobsInput() { }

    [DataMember(Name = "printJobs", IsRequired = true, EmitDefaultValue = true)]
    public List<PrintJobsInputPrintJobsInner> PrintJobs { get; set; }
}