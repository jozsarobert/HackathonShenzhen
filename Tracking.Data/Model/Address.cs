using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Tracking.Data.Model;

[DataContract(Name = "Address")]
public partial class Address : EntityBase
{
    [DataMember(Name = "cargo:country", EmitDefaultValue = false)]
    public Country Country { get; set; }

    [DataMember(Name = "cargo:addressCode", EmitDefaultValue = false)]
    public string AddressCode { get; set; }

    [DataMember(Name = "cargo:addressCodeType", EmitDefaultValue = false)]
    public string AddressCodeType { get; set; }

    [DataMember(Name = "cargo:cityCode", EmitDefaultValue = false)]
    public string CityCode { get; set; }

    [DataMember(Name = "cargo:cityName", EmitDefaultValue = false)]
    public string CityName { get; set; }

    [DataMember(Name = "cargo:postOfficeBox", EmitDefaultValue = false)]
    public string PostOfficeBox { get; set; }

    [DataMember(Name = "cargo:postalCode", EmitDefaultValue = false)]
    public string PostalCode { get; set; }

    [DataMember(Name = "cargo:regionCode", EmitDefaultValue = false)]
    public string RegionCode { get; set; }

    [DataMember(Name = "cargo:regionName", EmitDefaultValue = false)]
    public string RegionName { get; set; }

    [DataMember(Name = "cargo:streetAddressLines", EmitDefaultValue = false)]
    public List<string> StreetAddressLines { get; set; }
}
