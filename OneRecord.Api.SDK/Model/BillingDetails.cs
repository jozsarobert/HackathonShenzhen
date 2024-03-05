using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace OneRecord.Api.SDK.Model;

[DataContract(Name = "BillingDetails")]
public partial class BillingDetails : LogisticsObject
{
    [DataMember(Name = "cargo:adjustments", EmitDefaultValue = false)]
    public List<Adjustments> Adjustments { get; set; }

    [DataMember(Name = "cargo:detailedWaybill", EmitDefaultValue = false)]
    public Waybill DetailedWaybill { get; set; }

    [DataMember(Name = "cargo:taxDueAgent", EmitDefaultValue = false)]
    public Value TaxDueAgent { get; set; }

    [DataMember(Name = "cargo:taxDueAirline", EmitDefaultValue = false)]
    public Value TaxDueAirline { get; set; }

    [DataMember(Name = "cargo:awbAcceptanceDate", EmitDefaultValue = false)]
    public DateTime AwbAcceptanceDate { get; set; }

    [DataMember(Name = "cargo:awbDeliveryDate", EmitDefaultValue = false)]
    public DateTime AwbDeliveryDate { get; set; }

    [DataMember(Name = "cargo:awbExecutionDate", EmitDefaultValue = false)]
    public DateTime AwbExecutionDate { get; set; }

    [DataMember(Name = "cargo:awbUseIndicator", EmitDefaultValue = true)]
    public bool AwbUseIndicator { get; set; }

    [DataMember(Name = "cargo:commission", EmitDefaultValue = false)]
    public double Commission { get; set; }

    [DataMember(Name = "cargo:commissionIndicator", EmitDefaultValue = true)]
    public bool CommissionIndicator { get; set; }

    [DataMember(Name = "cargo:commissionPercentage", EmitDefaultValue = false)]
    public double CommissionPercentage { get; set; }

    [DataMember(Name = "cargo:discount", EmitDefaultValue = false)]
    public double Discount { get; set; }

    [DataMember(Name = "cargo:exchangeRate", EmitDefaultValue = false)]
    public double ExchangeRate { get; set; }

    [DataMember(Name = "cargo:nbCorrections", EmitDefaultValue = false)]
    public int NbCorrections { get; set; }

    [DataMember(Name = "cargo:vatIndicator", EmitDefaultValue = true)]
    public bool VatIndicator { get; set; }
}
