using System.Collections.Generic;
using System.Runtime.Serialization;

namespace OneRecord.Api.SDK.Model;

[DataContract(Name = "CarrierProduct")]
public partial class CarrierProduct : EntityBase
{
    [DataMember(Name = "cargo:checks", EmitDefaultValue = false)]
    public List<Check> HttpsCargochecks { get; set; }

    [DataMember(Name = "cargo:events", EmitDefaultValue = false)]
    public List<LogisticsEvent> HttpsCargoevents { get; set; }

    [DataMember(Name = "cargo:externalReferences", EmitDefaultValue = false)]
    public List<ExternalReference> HttpsCargoexternalReferences { get; set; }

    [DataMember(Name = "cargo:companyIdentifier", EmitDefaultValue = false)]
    public string HttpsCargocompanyIdentifier { get; set; }

    [DataMember(Name = "cargo:skeletonIndicator", EmitDefaultValue = true)]
    public bool HttpsCargoskeletonIndicator { get; set; }

    [DataMember(Name = "cargo:forBookingOptions", EmitDefaultValue = false)]
    public BookingOption HttpsCargoforBookingOptions { get; set; }

    [DataMember(Name = "cargo:productCode", EmitDefaultValue = false)]
    public string HttpsCargoproductCode { get; set; }

    [DataMember(Name = "cargo:productDescription", EmitDefaultValue = false)]
    public string HttpsCargoproductDescription { get; set; }
}
