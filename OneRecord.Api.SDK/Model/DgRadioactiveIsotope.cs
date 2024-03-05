using System.Runtime.Serialization;

namespace OneRecord.Api.SDK.Model;

[DataContract(Name = "DgRadioactiveIsotope")]
public partial class DgRadioactiveIsotope :LogisticsObject
{
    [DataMember(Name = "cargo:contentOfDgProductRadioactive", EmitDefaultValue = false)]
    public DgProductRadioactive ContentOfDgProductRadioactive { get; set; }

    [DataMember(Name = "cargo:activityLevelMeasure", EmitDefaultValue = false)]
    public string ActivityLevelMeasure { get; set; }

    [DataMember(Name = "cargo:criticalitySafetyIndexNumeric", EmitDefaultValue = false)]
    public string CriticalitySafetyIndexNumeric { get; set; }

    [DataMember(Name = "cargo:isotopeId", EmitDefaultValue = false)]
    public string IsotopeId { get; set; }

    [DataMember(Name = "cargo:isotopeName", EmitDefaultValue = false)]
    public string HttpsCargoisotopeName { get; set; }

    [DataMember(Name = "cargo:lowDispersibleIndicator", EmitDefaultValue = true)]
    public bool LowDispersibleIndicator { get; set; }

    [DataMember(Name = "cargo:physicalChemicalForm", EmitDefaultValue = false)]
    public string PhysicalChemicalForm { get; set; }

    [DataMember(Name = "cargo:specialFormIndicator", EmitDefaultValue = true)]
    public bool SpecialFormIndicator { get; set; }
}
