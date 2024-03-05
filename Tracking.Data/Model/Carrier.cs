using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Tracking.Data.Model;

[DataContract(Name = "Carrier")]
public partial class Carrier : Company
{
    [DataMember(Name = "cargo:airlineCode", EmitDefaultValue = false)]
    public string AirlineCode { get; set; }

    [DataMember(Name = "cargo:prefix", EmitDefaultValue = false)]
    public string Prefix { get; set; }
}
