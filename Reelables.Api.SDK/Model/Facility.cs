using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Reelables.Api.SDK.Model;

[DataContract(Name = "Facility")]
public class Facility
{

    [JsonConstructor]
    protected Facility() { }

    [DataMember(Name = "createdAt", EmitDefaultValue = false)]
    public DateTime CreatedAt { get; set; }

    [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
    public string Name { get; set; }

    [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
    public Guid Id { get; set; }

    [DataMember(Name = "workspaceId", IsRequired = true, EmitDefaultValue = true)]
    public Guid WorkspaceId { get; set; }

    [DataMember(Name = "userFacilityId", EmitDefaultValue = false)]
    public string UserFacilityId { get; set; }
}