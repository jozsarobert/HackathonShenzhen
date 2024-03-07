using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Reelables.Api.SDK.Model;

[DataContract(Name = "ConsignmentInput_pieces_inner")]
public class ConsignmentInputPiecesInner
{

    [JsonConstructor]
    protected ConsignmentInputPiecesInner() { }

    [DataMember(Name = "trackingRef", EmitDefaultValue = false)]
    public string TrackingRef { get; set; }

    [DataMember(Name = "label", IsRequired = true, EmitDefaultValue = true)]
    public ConsignmentInputPiecesInnerLabel Label { get; set; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class ConsignmentInputPiecesInner {\n");
        sb.Append("  TrackingRef: ").Append(TrackingRef).Append("\n");
        sb.Append("  Label: ").Append(Label).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}