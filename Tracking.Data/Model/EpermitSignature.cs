using System;
using System.Runtime.Serialization;

namespace Tracking.Data.Model;

[DataContract(Name = "EpermitSignature")]
public partial class EpermitSignature : LogisticsObject
{
    [DataMember(Name = "cargo:forEpermit", EmitDefaultValue = false)]
    public LiveAnimalsEpermit ForEpermit { get; set; }

    [DataMember(Name = "cargo:signatoryCompany", EmitDefaultValue = false)]
    public Company SignatoryCompany { get; set; }

    [DataMember(Name = "cargo:securityStampId", EmitDefaultValue = false)]
    public string SecurityStampId { get; set; }

    [DataMember(Name = "cargo:signatoryRole", EmitDefaultValue = false)]
    public string SignatoryRole { get; set; }

    [DataMember(Name = "cargo:signatureDate", EmitDefaultValue = false)]
    public DateTime SignatureDate { get; set; }

    [DataMember(Name = "cargo:signatureStatement", EmitDefaultValue = false)]
    public string SignatureStatement { get; set; }

    [DataMember(Name = "cargo:signatureTypeCode", EmitDefaultValue = false)]
    public string SignatureTypeCode { get; set; }
}
