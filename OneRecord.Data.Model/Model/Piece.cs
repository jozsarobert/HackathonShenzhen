using System.Runtime.Serialization;

namespace OneRecord.Data.Model.Model
{
    [DataContract(Name = "Piece")]
    public partial class Piece : PhysicalLogisticsObject
    {
        public Piece()
        {
            Type = new List<string>
            {
                "cargo:Piece"
            };
        }

        [DataMember(Name = "@context", EmitDefaultValue = true)]
        public Context Context = new Context
        {
            Cargo = "cargo:"
        };

        [DataMember(Name = "cargo:containedPieces", EmitDefaultValue = false)]
        public List<Piece> ContainedPieces { get; set; }

        [DataMember(Name = "cargo:contentProductionCountry", EmitDefaultValue = false)]
        public string ContentProductionCountry { get; set; }

        [DataMember(Name = "cargo:dimensions", EmitDefaultValue = false)]
        public Dimensions Dimensions { get; set; }

        [DataMember(Name = "cargo:grossWeight", EmitDefaultValue = false)]
        public Value GrossWeight { get; set; }

        [DataMember(Name = "cargo:ofShipment", EmitDefaultValue = false)]
        public Shipment OfShipment { get; set; }

        [DataMember(Name = "cargo:loadType", EmitDefaultValue = false)]
        public string LoadType { get; set; }

        [DataMember(Name = "cargo:fulfillsUldTypeCode", EmitDefaultValue = false)]
        public string FulfillsUldTypeCode { get; set; }

        [DataMember(Name = "cargo:packageMarkCoded", EmitDefaultValue = false)]
        public string PackageMarkCoded { get; set; }

        [DataMember(Name = "cargo:specialHandlingCodes", EmitDefaultValue = false)]
        public List<string> SpecialHandlingCodes { get; set; }

        [DataMember(Name = "cargo:coload", EmitDefaultValue = true)]
        public bool Coload { get; set; }

        [DataMember(Name = "cargo:goodsDescription", EmitDefaultValue = false)]
        public string GoodsDescription { get; set; }

        [DataMember(Name = "cargo:nvdForCarriage", EmitDefaultValue = true)]
        public bool NvdForCarriage { get; set; }

        [DataMember(Name = "cargo:nvdForCustoms", EmitDefaultValue = true)]
        public bool NvdForCustoms { get; set; }

        [DataMember(Name = "cargo:packagedeIdentifier", EmitDefaultValue = false)]
        public string PackagedeIdentifier { get; set; }

        [DataMember(Name = "cargo:slac", EmitDefaultValue = false)]
        public int Slac { get; set; }

        [DataMember(Name = "cargo:stackable", EmitDefaultValue = true)]
        public bool Stackable { get; set; }

        [DataMember(Name = "cargo:turnable", EmitDefaultValue = true)]
        public bool Turnable { get; set; }

        [DataMember(Name = "cargo:upid", EmitDefaultValue = false)]
        public string Upid { get; set; }

        [DataMember(Name = "cargo:upid", EmitDefaultValue = false)]
        public TemperatureInstructions TemperatureInstructions { get; set; }
    }

}
