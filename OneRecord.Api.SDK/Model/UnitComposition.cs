using System.Collections.Generic;
using System.Runtime.Serialization;

namespace OneRecord.Api.SDK.Model;

[DataContract(Name = "UnitComposition")]
public partial class UnitComposition : LogisticsActivity
{
    [DataMember(Name = "cargo:compositionActions", EmitDefaultValue = false)]
    public List<Composing> CompositionActions { get; set; }

    [DataMember(Name = "cargo:compositionIdentifier", EmitDefaultValue = false)]
    public string CompositionIdentifier { get; set; }
}
