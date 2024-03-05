using System.Collections.Generic;
using System.Runtime.Serialization;

namespace OneRecord.Api.SDK.Model;

[DataContract(Name = "Carrier")]
public partial class Carrier : Company
{
    [DataMember(Name = "cargo:airlineCode", EmitDefaultValue = false)]
    public string HttpsCargoairlineCode { get; set; }

    [DataMember(Name = "cargo:prefix", EmitDefaultValue = false)]
    public string HttpsCargoprefix { get; set; }
}
