using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Reelables.Api.SDK.Model;


[DataContract(Name = "ConsignmentInput_pieces_inner_label")]
public class ConsignmentInputPiecesInnerLabel 
{

    [JsonConstructor]
    protected ConsignmentInputPiecesInnerLabel() { }

    [DataMember(Name = "nfcId", IsRequired = true, EmitDefaultValue = true)]
    public string NfcId { get; set; }

    
}