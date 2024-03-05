using System.Runtime.Serialization;

namespace OneRecord.Api.SDK.Model;

[DataContract(Name = "Insurance")]
public partial class Insurance : LogisticsObject
{
    [DataMember(Name = "cargo:coveringOrganization", EmitDefaultValue = false)]
    public Organization CoveringOrganization { get; set; }

    [DataMember(Name = "cargo:insuredAmount", EmitDefaultValue = false)]
    public Value InsuredAmount { get; set; }

    [DataMember(Name = "cargo:insuredShipment", EmitDefaultValue = false)]
    public Shipment InsuredShipment { get; set; }

    [DataMember(Name = "cargo:nvdIndicator", EmitDefaultValue = true)]
    public bool NvdIndicator { get; set; }
}
