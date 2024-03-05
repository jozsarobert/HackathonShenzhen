using System.Collections.Generic;
using System.Runtime.Serialization;

namespace OneRecord.Api.SDK.Model;

[DataContract(Name = "PackagingType")]
public partial class PackagingType : LogisticsObject
{
    [DataMember(Name = "cargo:appliedOnPieces", EmitDefaultValue = false)]
    public List<Piece> AappliedOnPieces { get; set; }

    [DataMember(Name = "cargo:description", EmitDefaultValue = false)]
    public string Description { get; set; }

    [DataMember(Name = "cargo:typeCode", EmitDefaultValue = false)]
    public string TypeCode { get; set; }

}
