#pragma warning disable VSSpell001 // Spell Check
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

using System.Runtime.Serialization;

namespace OneRecord.Data.Model.Model
{
    [DataContract(Name = "Shipment")]
    public partial class Shipment : LogisticsObject
    {
        public Shipment()
        {
            Type = new List<string>
            {
                "cargo:Shipment"
            };
        }

        [DataMember(Name = "@context", EmitDefaultValue = true)]
        public Context Context = new Context
        {
            Cargo = "cargo:"
        };

        [DataMember(Name = "cargo:waybill", EmitDefaultValue = false)]
        public Waybill Waybill { get; set; }

        [DataMember(Name = "cargo:pieces", EmitDefaultValue = false)]
        public List<Piece> Pieces { get; set; }

        [DataMember(Name = "cargo:totalGrossWeight", EmitDefaultValue = false)]
        public Value TotalGrossWeight { get; set; }

        [DataMember(Name = "cargo:totalDimensions", EmitDefaultValue = false)]
        public List<Dimensions> TotalDimensions { get; set; }

        [DataMember(Name = "cargo:incoterms", EmitDefaultValue = false)]
        public string Incoterms { get; set; }

        [DataMember(Name = "cargo:specialHandlingCodes", EmitDefaultValue = false)]
        public List<string> SpecialHandlingCodes { get; set; }

        [DataMember(Name = "cargo:goodsDescription", EmitDefaultValue = false)]
        public string GoodsDescription { get; set; }

        [DataMember(Name = "cargo:textualHandlingInstructions", EmitDefaultValue = false)]
        public List<string> TextualHandlingInstructions { get; set; }
    }
}
