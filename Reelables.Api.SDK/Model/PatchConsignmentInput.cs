using System.Runtime.Serialization;

namespace Reelables.Api.SDK.Model;

[DataContract(Name = "PatchConsignmentInput")]
public class PatchConsignmentInput
{
    public PatchConsignmentInput(bool isActive = default(bool))
    {
        this.IsActive = isActive;
    }

    [DataMember(Name = "isActive", EmitDefaultValue = true)]
    public bool IsActive { get; set; }
}