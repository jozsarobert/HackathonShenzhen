using System.Runtime.Serialization;

namespace Tracking.Data.Model;

[DataContract(Name = "Country")]
public partial class Country : EntityBase
{
    [DataMember(Name = "cargo:countryCode", EmitDefaultValue = false)]
    public string CountryCode { get; set; }

    [DataMember(Name = "cargo:countryName", EmitDefaultValue = false)]
    public string CountryName { get; set; }
}
