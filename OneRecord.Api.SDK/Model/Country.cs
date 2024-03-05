using System.Runtime.Serialization;

namespace OneRecord.Api.SDK.Model;

[DataContract(Name = "Country")]
public partial class Country : EntityBase
{
    [DataMember(Name = "cargo:countryCode", EmitDefaultValue = false)]
    public string HttpsCargocountryCode { get; set; }

    [DataMember(Name = "cargo:countryName", EmitDefaultValue = false)]
    public string HttpsCargocountryName { get; set; }
}
