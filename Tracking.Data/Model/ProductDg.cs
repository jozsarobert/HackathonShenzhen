using System.Runtime.Serialization;

namespace Tracking.Data.Model;


[DataContract(Name = "ProductDg")]
public partial class ProductDg : Product
{
    [DataMember(Name = "cargo:dgRadioactiveMaterial", EmitDefaultValue = false)]
    public DgProductRadioactive DgRadioactiveMaterial { get; set; }

    [DataMember(Name = "cargo:additionalHazardClassificationId", EmitDefaultValue = false)]
    public string AdditionalHazardClassificationId { get; set; }

    [DataMember(Name = "cargo:authorizationInformation", EmitDefaultValue = false)]
    public string AuthorizationInformation { get; set; }

    [DataMember(Name = "cargo:explosiveCompatibilityGroupCode", EmitDefaultValue = false)]
    public string ExplosiveCompatibilityGroupCode { get; set; }

    [DataMember(Name = "cargo:hazardClassificationId", EmitDefaultValue = false)]
    public string HazardClassificationId { get; set; }

    [DataMember(Name = "cargo:packagingDangerLevelCode", EmitDefaultValue = false)]
    public string PackagingDangerLevelCode { get; set; }

    [DataMember(Name = "cargo:packingInstructionNumber", EmitDefaultValue = false)]
    public string PackingInstructionNumber { get; set; }

    [DataMember(Name = "cargo:properShippingName", EmitDefaultValue = false)]
    public string ProperShippingName { get; set; }

    [DataMember(Name = "cargo:specialProvisionId", EmitDefaultValue = false)]
    public string SpecialProvisionId { get; set; }

    [DataMember(Name = "cargo:technicalName", EmitDefaultValue = false)]
    public string TechnicalName { get; set; }

    [DataMember(Name = "cargo:unNumber", EmitDefaultValue = false)]
    public string UnNumber { get; set; }
    public string DgProductRadioactiveId { get; internal set; }
}
