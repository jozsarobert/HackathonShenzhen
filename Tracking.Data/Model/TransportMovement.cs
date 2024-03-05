using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Tracking.Data.Model;

[DataContract(Name = "TransportMovement")]
public partial class TransportMovement : LogisticsActivity
{
    [DataMember(Name = "cargo:actions", EmitDefaultValue = false)]
    public List<LogisticsAction> Actions { get; set; }

    [DataMember(Name = "cargo:arrivalLocation", EmitDefaultValue = false)]
    public Location ArrivalLocation { get; set; }

    [DataMember(Name = "cargo:co2Emissions", EmitDefaultValue = false)]
    public List<Co2Emissions> Co2Emissions { get; set; }

    [DataMember(Name = "cargo:departureLocation", EmitDefaultValue = false)]
    public Location DepartureLocation { get; set; }

    [DataMember(Name = "cargo:distanceCalculated", EmitDefaultValue = false)]
    public Value DistanceCalculated { get; set; }

    [DataMember(Name = "cargo:distanceMeasured", EmitDefaultValue = false)]
    public Value DistanceMeasured { get; set; }

    [DataMember(Name = "cargo:fuelAmountCalculated", EmitDefaultValue = false)]
    public Value FuelAmountCalculated { get; set; }

    [DataMember(Name = "cargo:fuelAmountMeasured", EmitDefaultValue = false)]
    public Value FuelAmountMeasured { get; set; }

    [DataMember(Name = "cargo:movementTimes", EmitDefaultValue = false)]
    public List<MovementTimes> MovementTimes { get; set; }

    [DataMember(Name = "cargo:operatingTransportMeans", EmitDefaultValue = false)]
    public TransportMeans OperatingTransportMeans { get; set; }

    [DataMember(Name = "cargo:fuelType", EmitDefaultValue = false)]
    public string FuelType { get; set; }

    [DataMember(Name = "cargo:modeCode", EmitDefaultValue = false)]
    public string ModeCode { get; set; }

    [DataMember(Name = "cargo:modeQualifier", EmitDefaultValue = false)]
    public string ModeQualifier { get; set; }

    [DataMember(Name = "cargo:seal", EmitDefaultValue = false)]
    public string Seal { get; set; }

    [DataMember(Name = "cargo:transportIdentifier", EmitDefaultValue = false)]
    public string TransportIdentifier { get; set; }
}
