using System.Runtime.Serialization;

namespace Tracking.Data.Model;

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
    public string ShipmentId { get; internal set; }
}
