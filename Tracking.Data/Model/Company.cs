using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Tracking.Data.Model;

[DataContract(Name = "Company")]
public partial class Company : Organization
{
    [DataMember(Name = "cargo:iataCargoAgentCode", EmitDefaultValue = false)]
    public string AgentCode { get; set; }

    [DataMember(Name = "cargo:iataCargoAgentLocationIdentifier", EmitDefaultValue = false)]
    public string AgentLocationIdentifier { get; set; }
}
