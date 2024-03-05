using System.Runtime.Serialization;

namespace OneRecord.Api.SDK.Model;

[DataContract(Name = "CO2Emissions")]
public partial class Co2Emissions : LogisticsObject
{ 
    [DataMember(Name = "cargo:calculatedEmissions", EmitDefaultValue = false)]
    public Value CalculatedEmissions { get; set; }

    [DataMember(Name = "cargo:calculationForTransportMovement", EmitDefaultValue = false)]
    public TransportMovement CalculationForTransportMovement { get; set; }

    [DataMember(Name = "cargo:methodName", EmitDefaultValue = false)]
    public string MethodName { get; set; }

    [DataMember(Name = "cargo:methodVersion", EmitDefaultValue = false)]
    public string MethodVersion { get; set; }

}
