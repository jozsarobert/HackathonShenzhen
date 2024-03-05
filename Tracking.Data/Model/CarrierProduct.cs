using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Tracking.Data.Model;

[DataContract(Name = "CarrierProduct")]
public partial class CarrierProduct : EntityBase
{
    [DataMember(Name = "cargo:serviceLevelCode", EmitDefaultValue = false)]
    public string ServiceLevelCode { get; set; }

    [DataMember(Name = "cargo:productCode", EmitDefaultValue = false)]
    public string ProductCode { get; set; }

    [DataMember(Name = "cargo:productDescription", EmitDefaultValue = false)]
    public string ProductDescription { get; set; }
}
