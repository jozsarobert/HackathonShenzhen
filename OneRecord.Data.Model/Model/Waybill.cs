using System.Runtime.Serialization;

namespace OneRecord.Data.Model.Model
{
    [DataContract(Name = "Waybill")]
    public partial class Waybill : LogisticsObject
    {
        public Waybill()
        {
            Type = new List<string>
            {
                "cargo:WayBill"
            };
        }

        public string BillingDetailsId { get; set; }
        public string ReferredBookingOptionId { get; internal set; }
        public string ShipmentId { get; internal set; }

        [DataMember(Name = "@context", EmitDefaultValue = true)]
        public Context Context = new Context
        {
            Cargo = "cargo:"
        };

        [DataMember(Name = "cargo:arrivalLocation", EmitDefaultValue = false)]
        public Location ArrivalLocation { get; set; }

        [DataMember(Name = "cargo:referredBookingOption", EmitDefaultValue = false)]
        public Booking ReferredBookingOption { get; set; }

        [DataMember(Name = "cargo:departureLocation", EmitDefaultValue = false)]
        public Location DepartureLocation { get; set; }

        //[DataMember(Name = "cargo:billingDetails", EmitDefaultValue = false)]
        //public BillingDetails BillingDetails { get; set; }

        [DataMember(Name = "cargo:carrierDeclarationPlace", EmitDefaultValue = false)]
        public Location CarrierDeclarationPlace { get; set; }

        //[DataMember(Name = "cargo:declaredValueForCustoms", EmitDefaultValue = false)]
        //public CurrencyValue DeclaredValueForCustoms { get; set; }

        //[DataMember(Name = "cargo:declaredValueForCarriage", EmitDefaultValue = false)]
        //public CurrencyValue DeclaredValueForCarriage { get; set; }

        //[DataMember(Name = "cargo:masterWaybill", EmitDefaultValue = false)]
        //public Waybill MasterWaybill { get; set; }

        //[DataMember(Name = "cargo:houseWaybills", EmitDefaultValue = false)]
        //public List<Waybill> HouseWaybills { get; set; }

        //[DataMember(Name = "cargo:involvedParties", EmitDefaultValue = false)]
        //public List<Party> InvolvedParties { get; set; }

        //[DataMember(Name = "cargo:waybillLineItems", EmitDefaultValue = false)]
        //public List<WaybillLineItem> WaybillLineItems { get; set; }

        //[DataMember(Name = "cargo:otherCharges", EmitDefaultValue = false)]
        //public List<OtherCharge> OtherCharges { get; set; }

        [DataMember(Name = "cargo:shipment", EmitDefaultValue = false)]
        public Shipment Shipment { get; set; }

        [DataMember(Name = "cargo:waybillType", EmitDefaultValue = false)]
        public string WaybillType { get; set; }

        [DataMember(Name = "cargo:carrierChargeCode", EmitDefaultValue = false)]
        public string CarrierChargeCode { get; set; }

        [DataMember(Name = "cargo:otherChargesIndicator", EmitDefaultValue = false)]
        public string OtherChargesIndicator { get; set; }

        [DataMember(Name = "cargo:serviceCode", EmitDefaultValue = false)]
        public string ServiceCode { get; set; }

        [DataMember(Name = "cargo:weightValueIndicator", EmitDefaultValue = false)]
        public string WeightValueIndicator { get; set; }

        [DataMember(Name = "cargo:customsOriginCode", EmitDefaultValue = false)]
        public string CustomsOriginCode { get; set; }

        [DataMember(Name = "cargo:accountingInformation", EmitDefaultValue = false)]
        public string AccountingInformation { get; set; }

        [DataMember(Name = "cargo:carrierDeclarationDate", EmitDefaultValue = false)]
        public DateTime CarrierDeclarationDate { get; set; }

        [DataMember(Name = "cargo:carrierDeclarationSignature", EmitDefaultValue = false)]
        public string CarrierDeclarationSignature { get; set; }

        [DataMember(Name = "cargo:consignorDeclarationSignature", EmitDefaultValue = false)]
        public string ConsignorDeclarationSignature { get; set; }

        //[DataMember(Name = "cargo:destinationCharges", EmitDefaultValue = false)]
        //public List<CurrencyValue> DestinationCharges { get; set; }

        [DataMember(Name = "cargo:destinationCurrencyRate", EmitDefaultValue = false)]
        public double DestinationCurrencyRate { get; set; }

        [DataMember(Name = "cargo:shippingInfo", EmitDefaultValue = false)]
        public string ShippingInfo { get; set; }

        [DataMember(Name = "cargo:shippingRefNo", EmitDefaultValue = false)]
        public string ShippingRefNo { get; set; }

        [DataMember(Name = "cargo:waybillNumber", EmitDefaultValue = false)]
        public string WaybillNumber { get; set; }

        [DataMember(Name = "cargo:waybillPrefix", EmitDefaultValue = false)]
        public string WaybillPrefix { get; set; }

        [DataMember(Name = "cargo:modularCheckNumber", EmitDefaultValue = false)]
        public bool ModularCheckNumber { get; set; }

        //[DataMember(Name = "cargo:destinationCurrencyCode", EmitDefaultValue = false)]
        //public string DestinationCurrencyCode { get; set; }

        //[DataMember(Name = "cargo:originCurrency", EmitDefaultValue = false)]
        //public string OriginCurrency { get; set; }

    }
}
