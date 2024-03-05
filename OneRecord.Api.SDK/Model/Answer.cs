using System.Collections.Generic;
using System.Runtime.Serialization;

namespace OneRecord.Api.SDK.Model;

[DataContract(Name = "Answer")]
public partial class Answer : LogisticsObject
{
    [DataMember(Name = "cargo:answerActor", EmitDefaultValue = false)]
    public Actor AnswerActor { get; set; }

    [DataMember(Name = "cargo:answerValue", EmitDefaultValue = false)]
    public Value AnswerValue { get; set; }

    [DataMember(Name = "cargo:givenAtLocation", EmitDefaultValue = false)]
    public Location GivenAtLocation { get; set; }

    [DataMember(Name = "cargo:involvedParties", EmitDefaultValue = false)]
    public List<Party> InvolvedParties { get; set; }

    [DataMember(Name = "cargo:question", EmitDefaultValue = false)]
    public Question Question { get; set; }

    [DataMember(Name = "cargo:text", EmitDefaultValue = false)]
    public string Text { get; set; }
}
