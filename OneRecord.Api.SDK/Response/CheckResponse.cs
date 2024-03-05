using OneRecord.Api.SDK.Model;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace OneRecord.Api.SDK.Response;

public class CheckResponse : LogisticsObjectReponse
{
    /// <summary>
    /// Gets or Sets Context
    /// </summary>
    [DataMember(Name = "@context", EmitDefaultValue = true)]
    public Context Context = new Context
    {
        Cargo = "cargo:"
    };

    /// <summary>
    /// Gets or Sets CargocontactDetails
    /// </summary>
    [DataMember(Name = $"cargo:contactDetails", EmitDefaultValue = false)]
    public List<ContactDetail> ContactDetails { get; set; }

    /// <summary>
    /// Gets or Sets CargocontactPersons
    /// </summary>
    [DataMember(Name = "cargo:contactPersons", EmitDefaultValue = false)]
    public List<Person> ContactPersons { get; set; }

    /// <summary>
    /// Gets or Sets CargolocationOfPerformance
    /// </summary>
    [DataMember(Name = "cargo:locationOfPerformance", EmitDefaultValue = false)]
    public Location LocationOfPerformance { get; set; }

    /// <summary>
    /// Gets or Sets CargoservedActivity
    /// </summary>
    [DataMember(Name = "cargo:servedActivity", EmitDefaultValue = false)]
    public LogisticsActivity ServedActivity { get; set; }

    /// <summary>
    /// Gets or Sets CargoactionEndTime
    /// </summary>
    [DataMember(Name = "cargo:actionEndTime", EmitDefaultValue = false)]
    public DateTime ActionEndTime { get; set; }

    /// <summary>
    /// Gets or Sets CargoactionStartTime
    /// </summary>
    [DataMember(Name = "cargo:actionStartTime", EmitDefaultValue = false)]
    public DateTime ActionStartTime { get; set; }

    /// <summary>
    /// Gets or Sets CargoactionTimeType
    /// </summary>
    [DataMember(Name = "cargo:actionTimeType", EmitDefaultValue = false)]
    public string ActionTimeType { get; set; }

    /// <summary>
    /// Gets or Sets CargocheckTotalResult
    /// </summary>
    [DataMember(Name = "cargo:checkTotalResult", EmitDefaultValue = false)]
    public CheckTotalResult CheckTotalResult { get; set; }

    /// <summary>
    /// Gets or Sets CargocheckedObject
    /// </summary>
    [DataMember(Name = "cargo:checkedObject", EmitDefaultValue = false)]
    public LogisticsObject CheckedObject { get; set; }

    /// <summary>
    /// Gets or Sets Cargochecker
    /// </summary>
    [DataMember(Name = "cargo:checker", EmitDefaultValue = false)]
    public Actor Checker { get; set; }

    /// <summary>
    /// Gets or Sets CargousedTemplate
    /// </summary>
    [DataMember(Name = "cargo:usedTemplate", EmitDefaultValue = false)]
    [JsonProperty("usedTemplate")]
    public CheckTemplateResponse UsedTemplate { get; set; }
}
