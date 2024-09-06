using System.Collections.Generic;

namespace IHF.Rules.Questions.Infrastructure.DataSeed.Models;

public class QuestionDto
{
    public string? Phrase { get; init; }
    public string? PhraseNl { get; init; }
    public string? PhraseFr { get; init; }
    public string? PhraseSvn { get; init; }
    public string? PhraseDe { get; init; }
    public string? PhraseSrb { get; init; }
    public string QuestionNumber { get; init; } = default!;
    public List<AnswerDto> Answers { get; init; } = [];
}
