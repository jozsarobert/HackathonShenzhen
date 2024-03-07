using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Reelables.Api.SDK.Model;

[DataContract(Name = "Consignment_deactivated")]
public class ConsignmentDeactivated
{
    [JsonConstructor]
    protected ConsignmentDeactivated() { }
      
    [DataMember(Name = "where", EmitDefaultValue = false)]
    public ConsignmentDeactivatedWhere Where { get; set; }

    [DataMember(Name = "when", IsRequired = true, EmitDefaultValue = true)]
    public DateTime When { get; set; }

       
}