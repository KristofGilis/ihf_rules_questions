﻿using IHF.Rules.Questions.Infrastructure.DataSeed.Models;

namespace IHF.Rules.Questions.Infrastructure.DataSeed;

public static partial class Rules
{
    public static RuleDto GetRule03()
    {
        return new RuleDto
        {
            Name = "The Ball",
            NameNl = "De Bal",
            NameFr = "Le Ballon",
            NameSvn = "Žoga",
            NameDe = "Der Ball",
            NameSrb = "Лопта",
            RuleNumber = "3",
            Questions =
            [
                new QuestionDto
                {
                    Phrase = "How many colours is the ball allowed to have?",
                    PhraseNl = "Hoeveel kleuren mag de wedstrijdbal hebben?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "3.1",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "1",
                            PhraseNl = "1",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PharseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "2",
                            PhraseNl = "2",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PharseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "3",
                            PhraseNl = "3",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PharseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Unlimited",
                            PhraseNl = "zoveel men wil",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PharseSrb = "",
                            AnswerNumber = "d",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase = "Which of the following balls must the referees select for a men’s game?",
                    PhraseNl =
                        "Welke van de volgende ballen, moet de scheidrechter kiezen voor een wedstrijd heren senioren?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PharseSrb = "",
                    QuestionNumber = "3.2",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Circumference 57cm, weight 450g",
                            PhraseNl = "Omtrek 57 cm, gewicht 450 g",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PharseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Circumference 58cm, weight 400g",
                            PhraseNl = "Omtrek 58 cm, gewicht 400 g",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PharseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Circumference 59cm, weight 425g",
                            PhraseNl = "Omtrek 59 cm, gewicht 425 g",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PharseSrb = "",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Circumference 60cm, weight 500g",
                            PhraseNl = "Omtrek 60 cm, gewicht 500 g",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PharseSrb = "",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase = "Which of the following balls must the referees select for at women’s game?",
                    PhraseNl =
                        "Welke van de volgende ballen, moet de scheidrechter kiezen voor een wedstrijd dames senioren?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PharseSrb = "",
                    QuestionNumber = "3.3",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Circumference 53cm, weight 350g",
                            PhraseNl = "Omtrek 53 cm, gewicht 350 g",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PharseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Circumference 54cm, weight 300g",
                            PhraseNl = "Omtrek 54 cm, gewicht 300 g",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PharseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Circumference 55cm, weight 425g",
                            PhraseNl = "Omtrek 55 cm, gewicht 425 g",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PharseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Circumference 56cm, weight 375g",
                            PhraseNl = "Omtrek 56 cm, gewicht 375 g",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PharseSrb = "",
                            AnswerNumber = "d",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "The referees have decided to bring the reserve ball into play. When should the original ball be used again?",
                    PhraseNl =
                        "De scheidsrechters hebben besloten om de reservebal in het spel te brengen. Wanneer moet de wedstrijdbal weer gebruikt worden?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PharseSrb = "",
                    QuestionNumber = "3.4",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "At the time of the next interruption",
                            PhraseNl = "Bij de volgende spelonderbreking",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PharseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "It cannot be used again, unless it becomes impossible to continue to use the reserve ball.",
                            PhraseNl =
                                "Hij kan niet opnieuw gebruikt worden, tenzij het onmogelijk wordt om met de reservebal verder te spelen.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PharseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "When the referees find it necessary to use it again",
                            PhraseNl = "Wanneer de scheidsrechters het aangewezen vinden dat hij weer gebruikt wordt",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PharseSrb = "",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "If one of the teams request it",
                            PhraseNl = "Wanneer een der teams dit vraagt",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PharseSrb = "",
                            AnswerNumber = "d"
                        }
                    ]
                }
            ]
        };
    }
}
