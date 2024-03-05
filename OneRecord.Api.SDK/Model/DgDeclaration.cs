using System.Runtime.Serialization;

namespace OneRecord.Api.SDK.Model;

[DataContract(Name = "DgDeclaration")]
public partial class DgDeclaration : LogisticsObject
{ 
    [DataMember(Name = "cargo:issuedForPiece", EmitDefaultValue = false)]
    public Piece IssuedForPiece { get; set; }

    [DataMember(Name = "cargo:aircraftLimitationInformation", EmitDefaultValue = false)]
    public string AircraftLimitationInformation { get; set; }

    [DataMember(Name = "cargo:complianceDeclarationText", EmitDefaultValue = false)]
    public string ComplianceDeclarationText { get; set; }

    [DataMember(Name = "cargo:exclusiveUseIndicator", EmitDefaultValue = true)]
    public bool ExclusiveUseIndicator { get; set; }

    [DataMember(Name = "cargo:handlingInformation", EmitDefaultValue = false)]
    public string HandlingInformation { get; set; }

    [DataMember(Name = "cargo:shipperDeclarationText", EmitDefaultValue = false)]
    public string ShipperDeclarationText { get; set; }
}
