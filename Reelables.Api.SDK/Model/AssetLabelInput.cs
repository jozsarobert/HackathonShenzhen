using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Reelables.Api.SDK.Model;

[DataContract(Name = "AssetLabelInput")]
public class AssetLabelInput
{

    [JsonConstructor]
    protected AssetLabelInput() { }
       
    [DataMember(Name = "replaceExistingLabel", EmitDefaultValue = true)]
    public bool ReplaceExistingLabel { get; set; }

    [DataMember(Name = "nfcId", IsRequired = true, EmitDefaultValue = true)]
    public string NfcId { get; set; }  
}