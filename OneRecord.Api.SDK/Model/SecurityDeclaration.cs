using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace OneRecord.Api.SDK.Model;

[DataContract(Name = "SecurityDeclaration")]
public partial class SecurityDeclaration : LogisticsObject 
{ 
    [DataMember(Name = "cargo:issuedBy", EmitDefaultValue = false)]
    public Person IssuedBy { get; set; }

    [DataMember(Name = "cargo:issuedForPiece", EmitDefaultValue = false)]
    public Piece IssuedForPiece { get; set; }

    [DataMember(Name = "cargo:otherRegulatedEntities", EmitDefaultValue = false)]
    public List<RegulatedEntity> OtherRegulatedEntities { get; set; }

    [DataMember(Name = "cargo:receivedFrom", EmitDefaultValue = false)]
    public RegulatedEntity ReceivedFrom { get; set; }

    [DataMember(Name = "cargo:regulatedEntityIssuer", EmitDefaultValue = false)]
    public RegulatedEntity RegulatedEntityIssuer { get; set; }

    [DataMember(Name = "cargo:additionalSecurityInformation", EmitDefaultValue = false)]
    public string AdditionalSecurityInformation { get; set; }

    [DataMember(Name = "cargo:groundsForExemption", EmitDefaultValue = false)]
    public List<string> GroundsForExemption { get; set; }

    [DataMember(Name = "cargo:issuedOn", EmitDefaultValue = false)]
    public DateTime IssuedOn { get; set; }

    [DataMember(Name = "cargo:otherScreeningMethods", EmitDefaultValue = false)]
    public List<string> OtherScreeningMethods { get; set; }

    [DataMember(Name = "cargo:screeningMethods", EmitDefaultValue = false)]
    public List<string> ScreeningMethods { get; set; }

    [DataMember(Name = "cargo:securityStatus", EmitDefaultValue = false)]
    public string SecurityStatus { get; set; }
}
