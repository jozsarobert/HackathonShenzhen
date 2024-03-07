using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Reelables.Api.SDK.Model;

[DataContract(Name = "Space")]
public class Space
{
    [JsonConstructor]
    protected Space() { }
    
    [DataMember(Name = "numberAssetsInSpace", EmitDefaultValue = false)]
    public int NumberAssetsInSpace { get; set; }

    [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
    public string Name { get; set; }

    [DataMember(Name = "locations", EmitDefaultValue = false)]
    public AssetLocations Locations { get; set; }

    [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
    public string Id { get; set; }

    [DataMember(Name = "createdOn", EmitDefaultValue = false)]
    public DateTime CreatedOn { get; set; }

    [DataMember(Name = "gateway", EmitDefaultValue = false)]
    public SpaceGateway Gateway { get; set; }

    [DataMember(Name = "workspaceId", IsRequired = true, EmitDefaultValue = true)]
    public Guid WorkspaceId { get; set; }

   
}