using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Tracking.Data.Model;

[DataContract(Name = "Error")]
public partial class Error : EntityBase
{
    [DataMember(Name = "api:hasErrorDetail", EmitDefaultValue = false)]
    public List<ErrorDetail> HasErrorDetail { get; set; }

    [DataMember(Name = "api:hasTitle", EmitDefaultValue = false)]
    public string HasTitle { get; set; }
}
