using System.Runtime.Serialization;

namespace OneRecord.Data.Model.Model
{

    [DataContract(Name = "Loading")]
    public partial class Loading : LogisticsAction
    {
        [DataMember(Name = "cargo:loadedPieces", EmitDefaultValue = false)]
        public List<Piece> LoadedPieces { get; set; }

        [DataMember(Name = "cargo:onTransportMeans", EmitDefaultValue = false)]
        public TransportMeans OnTransportMeans { get; set; }

        [DataMember(Name = "cargo:loadingPositionIdentifier", EmitDefaultValue = false)]
        public string LoadingPositionIdentifier { get; set; }

        [DataMember(Name = "cargo:loadingType", EmitDefaultValue = false)]
        public string LoadingType { get; set; }
    }
}
