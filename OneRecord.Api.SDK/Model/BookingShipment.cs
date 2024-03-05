using System.Collections.Generic;
using System.Runtime.Serialization;

namespace OneRecord.Api.SDK.Model;

[DataContract(Name = "BookingShipment")]
public partial class BookingShipment : LogisticsObject
{
    [DataMember(Name = "cargo:bookingOptionRequest", EmitDefaultValue = false)]
    public List<BookingOptionRequest> BookingOptionRequest { get; set; }

    [DataMember(Name = "cargo:totalDimensions", EmitDefaultValue = false)]
    public Dimensions TotalDimensions { get; set; }

    [DataMember(Name = "cargo:totalGrossWeight", EmitDefaultValue = false)]
    public Value TotalGrossWeight { get; set; }

    [DataMember(Name = "cargo:totalVolumetricWeight", EmitDefaultValue = false)]
    public VolumetricWeight TotalVolumetricWeight { get; set; }

    [DataMember(Name = "cargo:goodsDescription", EmitDefaultValue = false)]
    public string GoodsDescription { get; set; }

    [DataMember(Name = "cargo:loadType", EmitDefaultValue = false)]
    public string LoadType { get; set; }

    [DataMember(Name = "cargo:totalPieceCount", EmitDefaultValue = false)]
    public int TotalPieceCount { get; set; }
}
