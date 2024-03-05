using System.Runtime.Serialization;

namespace OneRecord.Api.SDK.Model;

[DataContract(Name = "CustomsInformation")]
public partial class CustomsInformation : LogisticsObject
{
    [DataMember(Name = "cargo:issuedForPiece", EmitDefaultValue = false)]
    public Piece IssuedForPiece { get; set; }

    [DataMember(Name = "cargo:contentCode", EmitDefaultValue = false)]
    public string ContentCode { get; set; }

    [DataMember(Name = "cargo:countryCode", EmitDefaultValue = false)]
    public string CountryCode { get; set; }

    [DataMember(Name = "cargo:note", EmitDefaultValue = false)]
    public string Note { get; set; }

    [DataMember(Name = "cargo:otherCustomsInformation", EmitDefaultValue = false)]
    public string OtherCustomsInformation { get; set; }

    [DataMember(Name = "cargo:subjectCode", EmitDefaultValue = false)]
    public string SubjectCode { get; set; }
}
