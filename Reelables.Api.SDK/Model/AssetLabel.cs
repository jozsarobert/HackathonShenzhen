using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Reelables.Api.SDK.Model;

[DataContract(Name = "AssetLabel")]
public class AssetLabel
{

    [JsonConstructor]
    protected AssetLabel() { }
     
    [DataMember(Name = "bleId", IsRequired = true, EmitDefaultValue = true)]
    public int BleId { get; set; }

    [DataMember(Name = "nfcId", IsRequired = true, EmitDefaultValue = true)]
    public string NfcId { get; set; }

    [DataMember(Name = "addedOn", IsRequired = true, EmitDefaultValue = true)]
    public DateTime AddedOn { get; set; }
}