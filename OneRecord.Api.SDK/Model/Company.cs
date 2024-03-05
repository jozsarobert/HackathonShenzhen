using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace OneRecord.Api.SDK.Model;

[DataContract(Name = "Company")]
public partial class Company : Organization 
{ 
    [DataMember(Name = "cargo:iataCargoAgentCode", EmitDefaultValue = false)]
    public string HttpsCargoiataCargoAgentCode { get; set; }

    [DataMember(Name = "cargo:iataCargoAgentLocationIdentifier", EmitDefaultValue = false)]
    public string HttpsCargoiataCargoAgentLocationIdentifier { get; set; }
}
