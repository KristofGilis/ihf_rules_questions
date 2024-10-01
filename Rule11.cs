using IHF.Rules.Questions.Infrastructure.DataSeed.Models;

namespace IHF.Rules.Questions.Infrastructure.DataSeed;

public static partial class Rules
{
    public static RuleDto GetRule11()
    {
        return new RuleDto
        {
            Name = "The Throw-In",
            NameNl = "De Inworp",
            NameFr = "La Remise en jeu",
            NameSvn = "Stranski Met",
            NameDe = "Der Einwurf",
            NameSrb = "Аут",
            RuleNumber = "11",
            Questions =
            [
                new QuestionDto
                {
                    Phrase =
                        "WHITE 3 is executing a throw-in from a position two metres outside the sideline. Correct decision?",
                    PhraseNl = "WIT3 voert een inworp uit op twee meter buiten de zijlijn. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "11.1",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "No decision required, as this is allowed",
                            PhraseNl = "Geen beslissing vereist, gezien dit toegelaten is",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team",
                            PhraseNl = "Vrije worp voor ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Repeat the throw-in without whistle signal",
                            PhraseNl = "Herhaling van de inworp zonder fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Repeat the throw-in after whistle signal",
                            PhraseNl = "Herhaling van de inworp na fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "BLACK 4 stands with one foot on the sideline and the other foot in the playing area. He executes a throw-in and scores a goal directly. Correct decision?",
                    PhraseNl =
                        "ZWART4 staat met één voet op de zijlijn, met de andere in het speelveld. Hij voert de inworp uit en scoort direct in het doel. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "11.2",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Goal for BLACK team",
                            PhraseNl = "Doelpunt voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Repeat the throw-in for BLACK team after whistle signal",
                            PhraseNl = "Herhaling van de inworp voor ZWART na fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team",
                            PhraseNl = "Vrije worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Goalkeeper throw for WHITE team",
                            PhraseNl = "Uitworp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE 6 executes a throw-in standing with one foot inside the court and the other foot one metre outside the sideline. He throws the ball into the goal of BLACK team. Correct decision?",
                    PhraseNl =
                        "WIT6 voert, met één voet in het speelveld en de andere voet 1m buiten de zijlijn, een inworp uit. Hij werpt de bal in het doel van ZWART. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "11.3",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Repeated throw-in for WHITE team after whistle signal",
                            PhraseNl = "Herhalen van de inworp voor team WIT na fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team",
                            PhraseNl = "Vrije worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Goal for WHITE team",
                            PhraseNl = "Doelpunt voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Goalkeeper throw for BLACK team",
                            PhraseNl = "Uitworp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE 11 takes a shot on goal. The ball rebounds from the crossbar and hits equipment, which hangs from the ceiling over the goal area of BLACK team. From there the ball falls down into the arms of goalkeeper BLACK 1. Correct decision?",
                    PhraseNl =
                        "WIT11 werpt naar doel. De bal botst via de dwarslat tegen een sportconstructie die aan het plafond boven het doelgebied van ZWART hangt. Van daar valt de bal naar beneden in de armen van doelverdediger ZWART1. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "11.4",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Goalkeeper throw for BLACK team",
                            PhraseNl = "Uitworp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Throw-in for BLACK team",
                            PhraseNl = "Inworp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team after whistle signal",
                            PhraseNl = "Vrije worp voor team ZWART na fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Throw-in for BLACK team after whistle signal",
                            PhraseNl = "Inworp voor team ZWART na fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "Mandatory time-out",
                            PhraseNl = "Verplichte time-out",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "e"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "During the execution of throws following an interruption of the game, when is the defending team allowed to be closer than 3 metres from the ball?",
                    PhraseNl =
                        "Wanneer is het een verdedigend team toegestaan om dichter te komen dan 3 meter bij de uitvoering van een worp na een onderbreking van het spel?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "11.5",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "As soon as the referee has given the signal for the execution of the throw",
                            PhraseNl = "Van zodra de scheidsrechter het signaal geeft voor de uitvoering van de worp",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "When the ball has left the hand of the player executing a free throw",
                            PhraseNl = "Wanneer de bal de hand van de speler die vrije worp uitvoert, heeft verlaten",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "In case of a free throw or throw-in, when the players are positioned at their own goal-area line",
                            PhraseNl =
                                "In het geval een vrije worp of een inworp, wanneer de spelers plaats hebben genomen aan hun eigen doelgebied lijn",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "During the execution of a goalkeeper throw or a throw-off, when the defending player is standing outside the goal area or the throw-off area.",
                            PhraseNl =
                                "Tijdens de uitvoering van een uitworp of een beginworp, wanneer de verdedigende speler, buiten de doelgebied lijn of de beginworp zone, staat.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE 5 fails to catch a pass. He runs after the ball and stops it before it crosses the sideline, but he himself cannot avoid crossing the sideline afterwards. Correct decision?",
                    PhraseNl =
                        "WIT5 kan een pass niet vangen. Hij loopt achter de bal aan en stopt de bal net voor deze over de zijlijn gaat, maar hij kan hierbij niet verhinderen dat hij zelf nadien de zijlijn overschrijdt. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "11.6",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Game continues without interruption",
                            PhraseNl = "Spel gaat verder zonder onderbreking",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team",
                            PhraseNl = "Vrije worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Throw-in for BLACK team",
                            PhraseNl = "Inworp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        }
                    ]
                }
            ]
        };
    }
}
