using System.Runtime.Serialization;

namespace OneRecord.Api.SDK.Model;

[DataContract(Name = "Question")]
public partial class Question : LogisticsObject
{
    [DataMember(Name = "cargo:answer", EmitDefaultValue = false)]
    public Answer Answer { get; set; }

    [DataMember(Name = "cargo:checkTemplate", EmitDefaultValue = false)]
    public CheckTemplate CheckTemplate { get; set; }

    [DataMember(Name = "cargo:answerOptionsText", EmitDefaultValue = false)]
    public string AnswerOptionsText { get; set; }

    [DataMember(Name = "cargo:answerOptionsValue", EmitDefaultValue = false)]
    public string AnswerOptionsValue { get; set; }

    [DataMember(Name = "cargo:longText", EmitDefaultValue = false)]
    public string LongText { get; set; }

    [DataMember(Name = "cargo:questionsNumber", EmitDefaultValue = false)]
    public string QuestionsNumber { get; set; }

    [DataMember(Name = "cargo:questionsSection", EmitDefaultValue = false)]
    public string QuestionsSection { get; set; }

    [DataMember(Name = "cargo:shortText", EmitDefaultValue = false)]
    public string ShortText { get; set; }
}
