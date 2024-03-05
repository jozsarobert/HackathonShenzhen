using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Tracking.Data.Model;

[DataContract(Name = "Operation")]
public partial class Operation : EntityBase
{
    [DataMember(Name = "api:o", EmitDefaultValue = false)]
    public List<OperationObject> Objects { get; set; }

    [DataMember(Name = "api:op", EmitDefaultValue = false)]
    public PatchOperation PatchOperation { get; set; }

    [DataMember(Name = "api:p", EmitDefaultValue = false)]
    public string Predicate { get; set; }

    [DataMember(Name = "api:s", EmitDefaultValue = false)]
    public string Subject { get; set; }
}
