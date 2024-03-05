using System.Collections.Generic;
using System.Runtime.Serialization;

namespace OneRecord.Api.SDK.Model;

[DataContract(Name = "LoadingUnit")]
public partial class LoadingUnit : PhysicalLogisticsObject
{
    [DataMember(Name = "cargo:loadedPiecesOnLoadingUnit", EmitDefaultValue = false)]
    public List<Piece> LoadedPiecesOnLoadingUnit { get; set; }

    [DataMember(Name = "cargo:tareWeight", EmitDefaultValue = false)]
    public Value TareWeight { get; set; }

    [DataMember(Name = "cargo:remarks", EmitDefaultValue = false)]
    public string Remarks { get; set; }
}
