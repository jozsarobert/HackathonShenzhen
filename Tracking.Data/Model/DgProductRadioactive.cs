using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Tracking.Data.Model;

[DataContract(Name = "DgProductRadioactive")]
public partial class DgProductRadioactive : LogisticsObject
{
    [DataMember(Name = "cargo:forProductDg", EmitDefaultValue = false)]
    public ProductDg ForProductDg { get; set; }

    [DataMember(Name = "cargo:isotopes", EmitDefaultValue = false)]
    public List<DgRadioactiveIsotope> Isotopes { get; set; }

    [DataMember(Name = "cargo:dgRaTypeCode", EmitDefaultValue = false)]
    public string DgRaTypeCode { get; set; }

    [DataMember(Name = "cargo:fissileExceptionIndicator", EmitDefaultValue = true)]
    public bool FissileExceptionIndicator { get; set; }

    [DataMember(Name = "cargo:fissileExceptionReference", EmitDefaultValue = false)]
    public string FissileExceptionReference { get; set; }

    [DataMember(Name = "cargo:transportIndexNumeric", EmitDefaultValue = false)]
    public int TransportIndexNumeric { get; set; }
}
