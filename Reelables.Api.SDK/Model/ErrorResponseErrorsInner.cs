using System.Runtime.Serialization;

namespace Reelables.Api.SDK.Model;

[DataContract(Name = "ErrorResponse_errors_inner")]
public class ErrorResponseErrorsInner
{

    [DataMember(Name = "code", EmitDefaultValue = false)]
    public string Code { get; set; }

    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }

    [DataMember(Name = "detail", EmitDefaultValue = false)]
    public string Detail { get; set; }

    [DataMember(Name = "title", EmitDefaultValue = false)]
    public string Title { get; set; }

    [DataMember(Name = "status", EmitDefaultValue = false)]
    public string Status { get; set; }

}