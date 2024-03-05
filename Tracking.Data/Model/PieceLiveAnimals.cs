using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Tracking.Data.Model;

[DataContract(Name = "PieceLiveAnimals")]
public partial class PieceLiveAnimals : Piece
{
    [DataMember(Name = "cargo:associatedEpermit", EmitDefaultValue = false)]
    public EpermitConsignment AssociatedEpermit { get; set; }

    [DataMember(Name = "cargo:exportTradeCountry", EmitDefaultValue = false)]
    public Country ExportTradeCountry { get; set; }

    [DataMember(Name = "cargo:originTradeCountry", EmitDefaultValue = false)]
    public Country OriginTradeCountry { get; set; }

    [DataMember(Name = "cargo:acquisitionDateTime", EmitDefaultValue = false)]
    public DateTime AcquisitionDateTime { get; set; }

    [DataMember(Name = "cargo:annualQuotaQuantity", EmitDefaultValue = false)]
    public int AnnualQuotaQuantity { get; set; }

    [DataMember(Name = "cargo:categoryCode", EmitDefaultValue = false)]
    public List<string> CategoryCode { get; set; }

    [DataMember(Name = "cargo:goodsTypeCode", EmitDefaultValue = false)]
    public string GoodsTypeCode { get; set; }

    [DataMember(Name = "cargo:goodsTypeExtensionCode", EmitDefaultValue = false)]
    public string GoodsTypeExtensionCode { get; set; }

    [DataMember(Name = "cargo:originReferencePermitDateTime", EmitDefaultValue = false)]
    public DateTime OriginReferencePermitDateTime { get; set; }

    [DataMember(Name = "cargo:originReferencePermitId", EmitDefaultValue = false)]
    public string OriginReferencePermitId { get; set; }

    [DataMember(Name = "cargo:originReferencePermitTypeCode", EmitDefaultValue = false)]
    public string OriginReferencePermitTypeCode { get; set; }

    [DataMember(Name = "cargo:quantityAnimals", EmitDefaultValue = false)]
    public int QuantityAnimals { get; set; }

    [DataMember(Name = "cargo:speciesCommonName", EmitDefaultValue = false)]
    public List<string> SpeciesCommonName { get; set; }

    [DataMember(Name = "cargo:speciesScientificName", EmitDefaultValue = false)]
    public List<string> SpeciesScientificName { get; set; }

    [DataMember(Name = "cargo:specimenDescription", EmitDefaultValue = false)]
    public string SpecimenDescription { get; set; }

    [DataMember(Name = "cargo:specimenTypeCode", EmitDefaultValue = false)]
    public string SpecimenTypeCode { get; set; }
    public string EpermitConsignmentId { get;  set; }
}
