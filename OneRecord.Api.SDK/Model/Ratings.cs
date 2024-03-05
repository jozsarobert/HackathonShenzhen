using System.Collections.Generic;
using System.Runtime.Serialization;

namespace OneRecord.Api.SDK.Model;

[DataContract(Name = "Ratings")]
public partial class Ratings : LogisticsObject
{
    [DataMember(Name = "cargo:forPrices", EmitDefaultValue = false)]
    public List<Price> ForPrices { get; set; }

    [DataMember(Name = "cargo:preferenceOfRequests", EmitDefaultValue = false)]
    public List<BookingOptionRequest> PreferenceOfRequests { get; set; }

    [DataMember(Name = "cargo:ranges", EmitDefaultValue = false)]
    public List<Ranges> Ranges { get; set; }

    [DataMember(Name = "cargo:billingChargeIdentifier", EmitDefaultValue = false)]
    public double BillingChargeIdentifier { get; set; }

    [DataMember(Name = "cargo:chargeCode", EmitDefaultValue = false)]
    public string ChargeCode { get; set; }

    [DataMember(Name = "cargo:chargeDescription", EmitDefaultValue = false)]
    public string ChargeDescription { get; set; }

    [DataMember(Name = "cargo:chargePaymentType", EmitDefaultValue = false)]
    public string ChargePaymentType { get; set; }

    [DataMember(Name = "cargo:chargeType", EmitDefaultValue = false)]
    public string ChargeType { get; set; }

    [DataMember(Name = "cargo:entitlement", EmitDefaultValue = false)]
    public string Entitlement { get; set; }

    [DataMember(Name = "cargo:otherChargeCode", EmitDefaultValue = false)]
    public string OtherChargeCode { get; set; }

    [DataMember(Name = "cargo:priceSpecification", EmitDefaultValue = false)]
    public string PriceSpecification { get; set; }

    [DataMember(Name = "cargo:priceSpecificationRef", EmitDefaultValue = false)]
    public string PriceSpecificationRef { get; set; }

    [DataMember(Name = "cargo:rateQuantity", EmitDefaultValue = false)]
    public string RateQuantity { get; set; }

    [DataMember(Name = "cargo:ratingsType", EmitDefaultValue = false)]
    public string RatingsType { get; set; }

    [DataMember(Name = "cargo:rcp", EmitDefaultValue = false)]
    public string Rcp { get; set; }

    [DataMember(Name = "cargo:subTotal", EmitDefaultValue = false)]
    public double SubTotal { get; set; }
}
