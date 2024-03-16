using System.Runtime.Serialization;

namespace OneRecord.Data.Model.Model;

[DataContract(Name = "LogisticsObject")]
public partial class LogisticsObject : EntityBase
{
    //[DataMember(Name = "cargo:checks", EmitDefaultValue = false)]
    //public List<Check> Checks { get; set; }

    //[DataMember(Name = "cargo:events", EmitDefaultValue = false)]
    //public List<LogisticsEvent> Events { get; set; }

    //[DataMember(Name = "cargo:externalReferences", EmitDefaultValue = false)]
    //public List<ExternalReference> ExternalReferences { get; set; }

    [DataMember(Name = "cargo:companyIdentifier", EmitDefaultValue = false)]
    public string CompanyIdentifier { get; set; }

    [DataMember(Name = "cargo:skeletonIndicator", EmitDefaultValue = false)]
    public bool SkeletonIndicator { get; set; }
}
