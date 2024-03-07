using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Reelables.Api.SDK.Model;


[DataContract(Name = "Piece")]
public class Piece
{
    [JsonConstructor]
    protected Piece() { }
    
    [DataMember(Name = "trackingRef", IsRequired = true, EmitDefaultValue = true)]
    public string TrackingRef { get; set; }


    [DataMember(Name = "inFacilities", EmitDefaultValue = false)]
    public List<InFacility> InFacilities { get; set; }

    [DataMember(Name = "consignmentId", IsRequired = true, EmitDefaultValue = true)]
    public Guid ConsignmentId { get; set; }

    [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
    public string Id { get; set; }

    [DataMember(Name = "label", EmitDefaultValue = false)]
    public AssetLabel Label { get; set; }

    [DataMember(Name = "createdOn", EmitDefaultValue = false)]
    public DateTime CreatedOn { get; set; }

    [DataMember(Name = "workspaceId", IsRequired = true, EmitDefaultValue = true)]
    public Guid WorkspaceId { get; set; }
}