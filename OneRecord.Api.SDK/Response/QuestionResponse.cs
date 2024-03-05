using System.Runtime.Serialization;
using Newtonsoft.Json;
using OneRecord.Api.SDK.Model;

namespace OneRecord.Api.SDK.Response;

public class QuestionResponse : LogisticsObjectReponse
{
    [JsonProperty("@type")]
    public string TypeString { get; set; }

    /// <summary>
    /// Gets or Sets Cargoanswer
    /// </summary>
    [DataMember(Name = "cargo:answer", EmitDefaultValue = false)]
    [JsonProperty("answer")]
    public Answer Answer { get; set; }

    /// <summary>
    /// Gets or Sets CargocheckTemplate
    /// </summary>
    [DataMember(Name = "cargo:checkTemplate", EmitDefaultValue = false)]
    public CheckTemplate CheckTemplate { get; set; }

    /// <summary>
    /// Gets or Sets CargoanswerOptionsText
    /// </summary>
    [DataMember(Name = "cargo:answerOptionsText", EmitDefaultValue = false)]
    [JsonProperty("answerOptionsText")]
    public string AnswerOptionsText { get; set; }

    /// <summary>
    /// Gets or Sets CargoanswerOptionsValue
    /// </summary>
    [DataMember(Name = "cargo:answerOptionsValue", EmitDefaultValue = false)]
    [JsonProperty("answerOptionsValue")]
    public string AnswerOptionsValue { get; set; }

    /// <summary>
    /// Gets or Sets CargolongText
    /// </summary>
    [DataMember(Name = "cargo:longText", EmitDefaultValue = false)]
    [JsonProperty("longText")]
    public string LongText { get; set; }

    /// <summary>
    /// Gets or Sets CargoquestionsNumber
    /// </summary>
    [DataMember(Name = "cargo:questionsNumber", EmitDefaultValue = false)]
    [JsonProperty("questionsNumber")]
    public string QuestionsNumber { get; set; }

    /// <summary>
    /// Gets or Sets CargoquestionsSection
    /// </summary>
    [DataMember(Name = "cargo:questionsSection", EmitDefaultValue = false)]
    [JsonProperty("questionsSection")]
    public string QuestionsSection { get; set; }

    /// <summary>
    /// Gets or Sets CargoshortText
    /// </summary>
    [DataMember(Name = "cargo:shortText", EmitDefaultValue = false)]
    [JsonProperty("shortText")]
    public string ShortText { get; set; }

}
