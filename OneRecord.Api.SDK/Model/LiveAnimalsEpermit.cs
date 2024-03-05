using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace OneRecord.Api.SDK.Model;

[DataContract(Name = "LiveAnimalsEpermit")]
public partial class LiveAnimalsEpermit : LogisticsObject
{
    [DataMember(Name = "cargo:consignee", EmitDefaultValue = false)]
    public Company Consignee { get; set; }

    [DataMember(Name = "cargo:consignments", EmitDefaultValue = false)]
    public List<EpermitConsignment> Consignments { get; set; }

    [DataMember(Name = "cargo:signatures", EmitDefaultValue = false)]
    public List<EpermitSignature> Signatures { get; set; }

    [DataMember(Name = "cargo:copyIndicator", EmitDefaultValue = true)]
    public bool CopyIndicator { get; set; }

    [DataMember(Name = "cargo:epermitNumber", EmitDefaultValue = false)]
    public string EpermitNumber { get; set; }

    [DataMember(Name = "cargo:permitTypeCode", EmitDefaultValue = false)]
    public string ErmitTypeCode { get; set; }

    [DataMember(Name = "cargo:permitTypeOtherDescription", EmitDefaultValue = false)]
    public string PermitTypeOtherDescription { get; set; }

    [DataMember(Name = "cargo:specialConditions", EmitDefaultValue = false)]
    public string SpecialConditions { get; set; }

    [DataMember(Name = "cargo:transactionPurpose", EmitDefaultValue = false)]
    public string TransactionPurpose { get; set; }

    [DataMember(Name = "cargo:transactionPurposeCode", EmitDefaultValue = false)]
    public string TransactionPurposeCode { get; set; }

    [DataMember(Name = "cargo:transportContractId", EmitDefaultValue = false)]
    public string TransportContractId { get; set; }

    [DataMember(Name = "cargo:transportContractTypeCode", EmitDefaultValue = false)]
    public string TransportContractTypeCode { get; set; }

    [DataMember(Name = "cargo:validFrom", EmitDefaultValue = false)]
    public DateTime ValidFrom { get; set; }

    [DataMember(Name = "cargo:validUntil", EmitDefaultValue = false)]
    public DateTime ValidUntil { get; set; }
}
