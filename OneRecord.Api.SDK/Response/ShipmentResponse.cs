using OneRecord.Api.SDK.Model;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace OneRecord.Api.SDK.Response;

public class ShipmentResponse : LogisticsObjectReponse
{
    [JsonProperty("@type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets Context
    /// </summary>
    [DataMember(Name = "@context", EmitDefaultValue = true)]
    [JsonProperty("@context")]
    public Context Context { get; set; }

    /// <summary>
    /// Gets or Sets AttachedIotDevices
    /// </summary>
    [DataMember(Name = "cargo:attachedIotDevices", EmitDefaultValue = false)]
    [JsonProperty("attachedIotDevices")]
    public List<IotDevice> AttachedIotDevices { get; set; }

    /// <summary>
    /// Gets or Sets InvolvedInActions
    /// </summary>
    [DataMember(Name = "cargo:involvedInActions", EmitDefaultValue = false)]
    [JsonProperty("involvedInActions")]
    public List<LogisticsAction> InvolvedInActions { get; set; }

    /// <summary>
    /// Gets or Sets DeliveryLocation
    /// </summary>
    [DataMember(Name = "cargo:deliveryLocation", EmitDefaultValue = false)]
    [JsonProperty("deliveryLocation")]
    public Location DeliveryLocation { get; set; }

    /// <summary>
    /// Gets or Sets Insurance
    /// </summary>
    [DataMember(Name = "cargo:insurance", EmitDefaultValue = false)]
    [JsonProperty("insurance")]
    public Insurance Insurance { get; set; }

    /// <summary>
    /// Gets or Sets InvolvedParties
    /// </summary>
    [DataMember(Name = "cargo:involvedParties", EmitDefaultValue = false)]
    [JsonProperty("involvedParties")]
    public List<Party> InvolvedParties { get; set; }

    /// <summary>
    /// Gets or Sets ShipmentOfPieces
    /// </summary>
    [DataMember(Name = "cargo:shipmentOfPieces", EmitDefaultValue = false)]
    [JsonProperty("shipmentOfPieces")]
    public List<PieceResponse> ShipmentOfPieces { get; set; }

    /// <summary>
    /// Gets or Sets TotalDimensions
    /// </summary>
    [DataMember(Name = "cargo:totalDimensions", EmitDefaultValue = false)]
    [JsonProperty("totalDimensions")]
    public List<Dimensions> TotalDimensions { get; set; }

    /// <summary>
    /// Gets or Sets TotalGrossWeight
    /// </summary>
    [DataMember(Name = "cargo:totalGrossWeight", EmitDefaultValue = false)]
    [JsonProperty("totalGrossWeight")]
    public Value TotalGrossWeight { get; set; }

    /// <summary>
    /// Gets or Sets CargototalVolumetricWeight
    /// </summary>
    [DataMember(Name = "cargo:totalVolumetricWeight", EmitDefaultValue = false)]
    [JsonProperty("totalVolumetricWeight")]
    public VolumetricWeight TotalVolumetricWeight { get; set; }

    /// <summary>
    /// Gets or Sets Waybill
    /// </summary>
    [DataMember(Name = "cargo:waybill", EmitDefaultValue = false)]
    [JsonProperty("waybill")]
    public WaybillResponse Waybill { get; set; }

    /// <summary>
    /// Gets or Sets DeliveryDate
    /// </summary>
    [DataMember(Name = "cargo:deliveryDate", EmitDefaultValue = false)]
    [JsonProperty("deliveryDate")]
    public DateTime DeliveryDate { get; set; }

    /// <summary>
    /// Gets or Sets GoodsDescription
    /// </summary>
    [DataMember(Name = "cargo:goodsDescription", EmitDefaultValue = false)]
    [JsonProperty("goodsDescription")]
    public string GoodsDescription { get; set; }

    /// <summary>
    /// Gets or Sets Incoterms
    /// </summary>
    [DataMember(Name = "cargo:incoterms", EmitDefaultValue = false)]
    [JsonProperty("incoterms")]
    public string Incoterms { get; set; }

    /// <summary>
    /// Gets or Sets OtherChargesIndicator
    /// </summary>
    [DataMember(Name = "cargo:otherChargesIndicator", EmitDefaultValue = false)]
    [JsonProperty("otherChargesIndicator")]
    public string OtherChargesIndicator { get; set; }

    /// <summary>
    /// Gets or Sets TotalSlac
    /// </summary>
    [DataMember(Name = "cargo:totalSLAC", EmitDefaultValue = false)]
    [JsonProperty("totalSLAC")]
    public int TotalSlac { get; set; }

    /// <summary>
    /// Gets or Sets WeightValuationIndicator
    /// </summary>
    [DataMember(Name = "cargo:weightValuationIndicator", EmitDefaultValue = false)]
    [JsonProperty("weightValuationIndicator")]
    public string WeightValuationIndicator { get; set; }
}
