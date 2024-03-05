using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Tracking.Data.Model;

[DataContract(Name = "Shipment")]
public partial class Shipment : LogisticsObject
{
    [DataMember(Name = "@context", EmitDefaultValue = true)]
    public Context Context = new Context
    {
        Cargo = "cargo:"
    };

    [DataMember(Name = "cargo:attachedIotDevices", EmitDefaultValue = false)]
    public List<IotDevice> AttachedIotDevices { get; set; }

    [DataMember(Name = "cargo:involvedInActions", EmitDefaultValue = false)]
    public List<LogisticsAction> InvolvedInActions { get; set; }

    [DataMember(Name = "cargo:deliveryLocation", EmitDefaultValue = false)]
    public Location DeliveryLocation { get; set; }

    [DataMember(Name = "cargo:insurance", EmitDefaultValue = false)]
    public Insurance Insurance { get; set; }

    [DataMember(Name = "cargo:involvedParties", EmitDefaultValue = false)]
    public List<Party> InvolvedParties { get; set; }

    [DataMember(Name = "cargo:shipmentOfPieces", EmitDefaultValue = false)]
    public List<Piece> ShipmentOfPieces { get; set; }

    [DataMember(Name = "cargo:totalDimensions", EmitDefaultValue = false)]
    public List<Dimensions> TotalDimensions { get; set; }

    [DataMember(Name = "cargo:totalGrossWeight", EmitDefaultValue = false)]
    public Value TotalGrossWeight { get; set; }

    [DataMember(Name = "cargo:totalVolumetricWeight", EmitDefaultValue = false)]
    public VolumetricWeight TotalVolumetricWeight { get; set; }

    [DataMember(Name = "cargo:waybill", EmitDefaultValue = false)]
    public Waybill Waybill { get; set; }

    [DataMember(Name = "cargo:deliveryDate", EmitDefaultValue = false)]
    public DateTime DeliveryDate { get; set; }

    [DataMember(Name = "cargo:goodsDescription", EmitDefaultValue = false)]
    public string GoodsDescription { get; set; }

    [DataMember(Name = "cargo:incoterms", EmitDefaultValue = false)]
    public string Incoterms { get; set; }

    [DataMember(Name = "cargo:otherChargesIndicator", EmitDefaultValue = false)]
    public string OtherChargesIndicator { get; set; }

    [DataMember(Name = "cargo:totalSLAC", EmitDefaultValue = false)]
    public int TotalSlac { get; set; }

    [DataMember(Name = "cargo:weightValuationIndicator", EmitDefaultValue = false)]
    public string WeightValuationIndicator { get; set; }
}
