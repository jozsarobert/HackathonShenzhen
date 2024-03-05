using System.Collections.Generic;
using System.Runtime.Serialization;

namespace OneRecord.Api.SDK.Model;

[DataContract(Name = "Storing")]
public partial class Storing : LogisticsAction
{
    [DataMember(Name = "cargo:storedObjects", EmitDefaultValue = false)]
    public List<PhysicalLogisticsObject> StoredObjects { get; set; }

    [DataMember(Name = "cargo:storagePlaceIdentifier", EmitDefaultValue = false)]
    public string StoragePlaceIdentifier { get; set; }

    [DataMember(Name = "cargo:storingType", EmitDefaultValue = false)]
    public string StoringType { get; set; }
}
