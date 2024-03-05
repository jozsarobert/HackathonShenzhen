using System.Collections.Generic;
using System.Runtime.Serialization;

namespace OneRecord.Api.SDK.Model;

[DataContract(Name = "Storage")]
public partial class Storage : LogisticsActivity
{
    [DataMember(Name = "cargo:storingActions", EmitDefaultValue = false)]
    public List<Storing> StoringActions { get; set; }

    [DataMember(Name = "cargo:storingIdentifier", EmitDefaultValue = false)]
    public string StoringIdentifier { get; set; }
}
