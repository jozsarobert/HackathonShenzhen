using System.Runtime.Serialization;

namespace OneRecord.Api.SDK.Model;

[DataContract(Name = "PieceDg")]
public partial class PieceDg : Piece
{
    //??? duplicated in spec
    //[DataMember(Name = "qvalueNumeric", EmitDefaultValue = false)]
    //public double HttpsQvalueNumeric { get; set; }

    [DataMember(Name = "cargo:dgDeclaration", EmitDefaultValue = false)]
    public DgDeclaration DgDeclaration { get; set; }

    [DataMember(Name = "cargo:allPackedInOneIndicator", EmitDefaultValue = true)]
    public bool AllPackedInOneIndicator { get; set; }

    [DataMember(Name = "cargo:overpackCriticalitySafetyIndexNumeric", EmitDefaultValue = false)]
    public string OverpackCriticalitySafetyIndexNumeric { get; set; }

    [DataMember(Name = "cargo:overpackIndicator", EmitDefaultValue = true)]
    public bool OverpackIndicator { get; set; }

    [DataMember(Name = "cargo:overpackT1", EmitDefaultValue = true)]
    public bool OverpackT1 { get; set; }

    [DataMember(Name = "cargo:overpackTypeCode", EmitDefaultValue = true)]
    public bool OverpackTypeCode { get; set; }

    [DataMember(Name = "cargo:qValueNumeric", EmitDefaultValue = false)]
    public double QValueNumeric { get; set; }
}
