using System.Runtime.Serialization;

namespace OneRecord.Data.Model.Model
{
    [DataContract(Name = "TransportMeans")]
    public partial class TransportMeans : PhysicalLogisticsObject
    {
        [DataMember(Name = "cargo:operatedTransportMovements", EmitDefaultValue = false)]
        public List<TransportMovement> OperatedTransportMovements { get; set; }

        //[DataMember(Name = "cargo:transportOrganization", EmitDefaultValue = false)]
        //public Company TransportOrganization { get; set; }

        [DataMember(Name = "cargo:typicalCo2Coefficient", EmitDefaultValue = false)]
        public Value TypicalCo2Coefficient { get; set; }

        [DataMember(Name = "cargo:typicalFuelConsumption", EmitDefaultValue = false)]
        public Value TypicalFuelConsumption { get; set; }

        [DataMember(Name = "cargo:vehicleModel", EmitDefaultValue = false)]
        public string VehicleModel { get; set; }

        [DataMember(Name = "cargo:vehicleRegistration", EmitDefaultValue = false)]
        public string VehicleRegistration { get; set; }

        [DataMember(Name = "cargo:vehicleSize", EmitDefaultValue = false)]
        public string VehicleSize { get; set; }

        [DataMember(Name = "cargo:vehicleType", EmitDefaultValue = false)]
        public string VehicleType { get; set; }
    }
}
