using System.Runtime.Serialization;

namespace OneRecord.Data.Model.Model;

[DataContract(Name = "LogisticsObject")]
public partial class LogisticsObject : EntityBase
{
    [DataMember(Name = "cargo:companyIdentifier", EmitDefaultValue = false)]
    public string CompanyIdentifier { get; set; }

    [DataMember(Name = "cargo:skeletonIndicator", EmitDefaultValue = false)]
    public bool SkeletonIndicator { get; set; }
}
