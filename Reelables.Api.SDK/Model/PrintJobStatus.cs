using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Reelables.Api.SDK.Model;

[DataContract(Name = "PrintJobStatus")]
public class PrintJobStatus
{

    [JsonConstructor]
    protected PrintJobStatus() { }

    [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
    public DateTime CreatedAt { get; set; }

    [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
    public string Status { get; set; }
}