using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Tracking.Data.Model;

[DataContract(Name = "LoadingMaterial")]
public partial class LoadingMaterial : PhysicalLogisticsObject
{
    [DataMember(Name = "cargo:manufacturer", EmitDefaultValue = false)]
    public Organization Manufacturer { get; set; }

    [DataMember(Name = "cargo:otherIdentifiers", EmitDefaultValue = false)]
    public List<OtherIdentifier> OtherIdentifiers { get; set; }

    [DataMember(Name = "cargo:description", EmitDefaultValue = false)]
    public string Description { get; set; }

    [DataMember(Name = "cargo:materialModel", EmitDefaultValue = false)]
    public string MaterialModel { get; set; }

    [DataMember(Name = "cargo:materialType", EmitDefaultValue = false)]
    public string MaterialType { get; set; }

    [DataMember(Name = "cargo:serialNumber", EmitDefaultValue = false)]
    public string SerialNumber { get; set; }
}
