using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Reelables.Api.SDK.Model;

[DataContract(Name = "ErrorResponse")]
public class ErrorResponse
{
    [JsonConstructor]
    protected ErrorResponse() { }
    
    [DataMember(Name = "errors", IsRequired = true, EmitDefaultValue = true)]
    public List<ErrorResponseErrorsInner> Errors { get; set; }
}