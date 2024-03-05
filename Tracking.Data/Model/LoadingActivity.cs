using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Tracking.Data.Model;

[DataContract(Name = "LoadingActivity")]
public partial class LoadingActivity : LogisticsActivity
{
    [DataMember(Name = "cargo:loadingActions", EmitDefaultValue = false)]
    public List<Loading> LoadingActions { get; set; }

    [DataMember(Name = "cargo:loadingIdentifier", EmitDefaultValue = false)]
    public string LoadingIdentifier { get; set; }
}
