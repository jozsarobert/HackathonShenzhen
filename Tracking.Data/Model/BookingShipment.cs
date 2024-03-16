using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Tracking.Data.Model;

[DataContract(Name = "BookingShipment")]
public partial class BookingShipment : LogisticsObject
{
    [DataMember(Name = "cargo:forBookingOptionRequest", EmitDefaultValue = false)]
    public List<BookingOptionRequest> ForBookingOptionRequest { get; set; }

    [DataMember(Name = "cargo:temperatureInstructions", EmitDefaultValue = false)]
    public TemperatureInstructions TemperatureInstructions { get; set; }

    [DataMember(Name = "cargo:pieceGroup", EmitDefaultValue = false)]
    public PieceGroup PieceGroup { get; set; }

    [DataMember(Name = "cargo:expectedCommodity", EmitDefaultValue = false)]
    public string ExpectedCommodity { get;set; }

    [DataMember(Name = "cargo:specialHandlingCodes", EmitDefaultValue = false)]
    public List<string> SpecialHandlingCodes { get; set; }

    [DataMember(Name = "cargo:expectedHScode", EmitDefaultValue = false)]
    public string ExpectedHSCode { get; set; }

    [DataMember(Name = "cargo:specialServiceRequests", EmitDefaultValue = false)]
    public List<string> SpecialServiceRequests { get; set; }

    [DataMember(Name = "cargo:textualHandlingInstructions", EmitDefaultValue = false)]
    public List<string> TextualHandlingInstructions { get; set; }

    [DataMember(Name = "cargo:consolidationIndicator", EmitDefaultValue = false)]
    public bool ConsolidationIndicator { get; set; }


    //[DataMember(Name = "cargo:totalDimensions", EmitDefaultValue = false)]
    //public Dimensions TotalDimensions { get; set; }

    //[DataMember(Name = "cargo:totalGrossWeight", EmitDefaultValue = false)]
    //public Value TotalGrossWeight { get; set; }

    //[DataMember(Name = "cargo:totalVolumetricWeight", EmitDefaultValue = false)]
    //public VolumetricWeight TotalVolumetricWeight { get; set; }

    //[DataMember(Name = "cargo:goodsDescription", EmitDefaultValue = false)]
    //public string GoodsDescription { get; set; }

    //[DataMember(Name = "cargo:loadType", EmitDefaultValue = false)]
    //public string LoadType { get; set; }

    //[DataMember(Name = "cargo:totalPieceCount", EmitDefaultValue = false)]
    //public int TotalPieceCount { get; set; }
}
