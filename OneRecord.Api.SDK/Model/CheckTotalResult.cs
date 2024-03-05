using System.Runtime.Serialization;

namespace OneRecord.Api.SDK.Model;

[DataContract(Name = "CheckTotalResult")]
public partial class CheckTotalResult : LogisticsObject
{
    [DataMember(Name = "cargo:certifiedByActor", EmitDefaultValue = false)]
    public Person CertifiedByActor { get; set; }

    [DataMember(Name = "cargo:resultValue", EmitDefaultValue = false)]
    public Value ResultValue { get; set; }

    [DataMember(Name = "cargo:checkRemark", EmitDefaultValue = false)]
    public string CheckRemark { get; set; }

    [DataMember(Name = "cargo:passed", EmitDefaultValue = true)]
    public bool Passed { get; set; }
}
