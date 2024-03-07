using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Reelables.Api.SDK.Model;

[DataContract(Name = "AssetGroup")]
public class AssetGroup
{
    [JsonConstructor]
    protected AssetGroup() { }
      
    [DataMember(Name = "facilityId", EmitDefaultValue = false)]
    public Guid FacilityId { get; set; }

    [DataMember(Name = "availabilityThreshold", EmitDefaultValue = false)]
    public int AvailabilityThreshold { get; set; }

    [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
    public string Name { get; set; }

    [DataMember(Name = "available", EmitDefaultValue = true)]
    public bool Available { get; set; }

    [DataMember(Name = "count", EmitDefaultValue = false)]
    public int Count { get; set; }

    [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
    public Guid Id { get; set; }

    [DataMember(Name = "workspaceId", IsRequired = true, EmitDefaultValue = true)]
    public Guid WorkspaceId { get; set; }
}