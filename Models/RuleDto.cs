using System.Collections.Generic;

namespace IHF.Rules.Questions.Infrastructure.DataSeed.Models;

public class RuleDto
{
    public string? Name { get; init; }
    public string? NameNl { get; init; }
    public string? NameFr { get; init; }
    public string? NameSvn { get; init; }
    public string? NameDe { get; init; }
    public string? NameSrb { get; init; }
    public string RuleNumber { get; init; } = default!;
    internal List<QuestionDto> Questions { get; init; } = [];
}
