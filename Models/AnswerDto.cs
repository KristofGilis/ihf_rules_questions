namespace IHF.Rules.Questions.Infrastructure.DataSeed.Models;

public class AnswerDto
{
    public string? Phrase { get; init; }
    public string? PhraseNl { get; init; }
    public string? PhraseFr { get; init; }
    public string? PhraseSvn { get; init; }
    public string? PhraseDe { get; init; }
    public string? PhraseSrb { get; init; }
    public string AnswerNumber { get; init; } = default!;
    public bool Correct { get; init; }
}
