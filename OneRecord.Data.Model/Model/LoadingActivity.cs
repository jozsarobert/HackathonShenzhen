using System.Runtime.Serialization;

namespace OneRecord.Data.Model.Model
{
    [DataContract(Name = "LoadingActivity")]
    public partial class LoadingActivity : LogisticsActivity
    {
        [DataMember(Name = "cargo:loadingActions", EmitDefaultValue = false)]
        public List<Loading> LoadingActions { get; set; }

        [DataMember(Name = "cargo:loadingIdentifier", EmitDefaultValue = false)]
        public string LoadingIdentifier { get; set; }
    }
}
