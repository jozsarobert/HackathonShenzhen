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
        public int ReferredBookingOptionId { get; internal set; }
        public int ShipmentId { get; internal set; }

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
    }
}
