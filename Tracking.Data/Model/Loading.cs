using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Tracking.Data.Model;


[DataContract(Name = "Loading")]
public partial class Loading : LogisticsAction
{
    [DataMember(Name = "cargo:loadedMaterials", EmitDefaultValue = false)]
    public List<LoadingMaterial> LoadedMaterials { get; set; }

    [DataMember(Name = "cargo:loadedPieces", EmitDefaultValue = false)]
    public List<Piece> LoadedPieces { get; set; }

    [DataMember(Name = "cargo:loadedUnits", EmitDefaultValue = false)]
    public List<LoadingUnit> LoadedUnits { get; set; }

    [DataMember(Name = "cargo:onTransportMeans", EmitDefaultValue = false)]
    public TransportMeans OnTransportMeans { get; set; }

    [DataMember(Name = "cargo:loadingPositionIdentifier", EmitDefaultValue = false)]
    public string LoadingPositionIdentifier { get; set; }

    [DataMember(Name = "cargo:loadingType", EmitDefaultValue = false)]
    public string LoadingType { get; set; }
}
