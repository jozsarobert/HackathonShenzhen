using System.Runtime.Serialization;

namespace Tracking.Data.Model;

[DataContract(Name = "Check")]
public partial class Check : LogisticsAction
{
    private readonly string dataType = "https://onerecord.iata.org/ns/cargo#Check";

    [DataMember(Name = "@context", EmitDefaultValue = true)]
    public Context Context = new Context
    {
        Cargo = "cargo:"
    };

    [DataMember(Name = "cargo:checkTotalResult", EmitDefaultValue = false)]
    public CheckTotalResult CheckTotalResult { get; set; }

    [DataMember(Name = "cargo:checkedObject", EmitDefaultValue = false)]
    public LogisticsObject CheckedObject { get; set; }

    [DataMember(Name = "cargo:checker", EmitDefaultValue = false)]
    public Actor Checker { get; set; }

    [DataMember(Name = "cargo:usedTemplate", EmitDefaultValue = false)]
    public CheckTemplate UsedTemplate { get; set; }
}
