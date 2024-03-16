using System.Runtime.Serialization;

namespace OneRecord.Data.Model.Model;

[DataContract(Name = "Dimensions")]
public partial class Dimensions : EntityBase
{
    [DataMember(Name = "cargo:height", EmitDefaultValue = false)]
    public Value Height { get; set; }

    [DataMember(Name = "cargo:length", EmitDefaultValue = false)]
    public Value Length { get; set; }

    [DataMember(Name = "cargo:volume", EmitDefaultValue = false)]
    public Value Volume { get; set; }

    [DataMember(Name = "cargo:width", EmitDefaultValue = false)]
    public Value Width { get; set; }
}
