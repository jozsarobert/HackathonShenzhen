using Newtonsoft.Json;
using OneRecord.Api.SDK.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace OneRecord.Api.SDK.Response;

[DataContract]
public class LoadingUnitResponse : LogisticsObjectReponse
{
    /// <summary>
    /// Gets or Sets CargoattachedIotDevices
    /// </summary>
    [DataMember(Name = "attachedIotDevices", EmitDefaultValue = false)]
    [JsonProperty("attachedIotDevices")]
    public List<IotDevice> AttachedIotDevices { get; set; }

    /// <summary>
    /// Gets or Sets CargoinvolvedInActions
    /// </summary>
    [DataMember(Name = "involvedInActions", EmitDefaultValue = false)]
    [JsonProperty("involvedInActions")]
    public List<LogisticsAction> InvolvedInActions { get; set; }

    /// <summary>
    /// Gets or Sets CargoloadedPiecesOnLoadingUnit
    /// </summary>
    [DataMember(Name = "loadedPiecesOnLoadingUnit", EmitDefaultValue = false)]
    [JsonProperty("loadedPiecesOnLoadingUnit")]
    public List<Piece> LoadedPiecesOnLoadingUnit { get; set; }

    /// <summary>
    /// Gets or Sets CargotareWeight
    /// </summary>
    [DataMember(Name = "tareWeight", EmitDefaultValue = false)]
    [JsonProperty("tareWeight")]
    public Value TareWeight { get; set; }

    /// <summary>
    /// Gets or Sets Cargoremarks
    /// </summary>
    [DataMember(Name = "remarks", EmitDefaultValue = false)]
    [JsonProperty("remarks")]
    public string Remarks { get; set; }

}
