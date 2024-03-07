using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Reelables.Api.SDK.Model;

[DataContract(Name = "Asset")]
public class Asset
{

    [JsonConstructor]
    protected Asset() { }
       
    [DataMember(Name = "inSpaces", EmitDefaultValue = false)]
    public List<AssetInSpace> InSpaces { get; set; }

    [DataMember(Name = "temperatures", EmitDefaultValue = false)]
    public AssetTemperatures Temperatures { get; set; }

    [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
    public string Name { get; set; }

    [DataMember(Name = "locations", EmitDefaultValue = false)]
    public AssetLocations Locations { get; set; }

    [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
    public string Id { get; set; }

    [DataMember(Name = "label", EmitDefaultValue = false)]
    public AssetLabel Label { get; set; }

    [DataMember(Name = "createdOn", EmitDefaultValue = false)]
    public DateTime CreatedOn { get; set; }

    [DataMember(Name = "workspaceId", IsRequired = true, EmitDefaultValue = true)]
    public Guid WorkspaceId { get; set; }
}