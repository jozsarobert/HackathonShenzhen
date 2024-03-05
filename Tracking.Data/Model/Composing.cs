using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Tracking.Data.Model;

[DataContract(Name = "Composing")]
public partial class Composing : LogisticsAction
{
    [DataMember(Name = "cargo:composedMaterials", EmitDefaultValue = false)]
    public List<LoadingMaterial> ComposedMaterials { get; set; }

    [DataMember(Name = "cargo:composedPieces", EmitDefaultValue = false)]
    public List<Piece> ComposedPieces { get; set; }

    [DataMember(Name = "cargo:loadingUnit", EmitDefaultValue = false)]
    public LoadingUnit LoadingUnit { get; set; }

    [DataMember(Name = "cargo:compositionType", EmitDefaultValue = false)]
    public string CompositionType { get; set; }
}
