using System.Runtime.Serialization;

namespace Tracking.Data.Model;


[DataContract(Name = "EpermitConsignment")]
public partial class EpermitConsignment : LogisticsObject
{
    [DataMember(Name = "cargo:consignmentItems", EmitDefaultValue = false)]
    public PieceLiveAnimals ConsignmentItems { get; set; }

    [DataMember(Name = "cargo:epermit", EmitDefaultValue = false)]
    public LiveAnimalsEpermit Permit { get; set; }

    [DataMember(Name = "cargo:examiningQuantity", EmitDefaultValue = false)]
    public Value ExaminingQuantity { get; set; }

    [DataMember(Name = "cargo:usedToDateQuotaQuantity", EmitDefaultValue = false)]
    public int UsedToDateQuotaQuantity { get; set; }
}
