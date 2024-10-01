using IHF.Rules.Questions.Infrastructure.DataSeed.Models;

namespace IHF.Rules.Questions.Infrastructure.DataSeed;

public static partial class Rules
{
    public static RuleDto GetRule18()
    {
        return new RuleDto
        {
            Name = "The Timekeeper and the Scorekeeper",
            NameNl = "De Tijdopnemer en de Secretaris",
            NameFr = "Le Chronométreur et le Secrétaire",
            NameSvn = "Časomerilec In Zaposnikar",
            NameDe = "Zeitnehmer und Sekretär",
            NameSrb = "Мерилац времена и записничар",
            RuleNumber = "18",
            Questions =
            [
                new QuestionDto
                {
                    Phrase =
                        "What do the Rules of the Game prescribe regarding the work distribution between timekeeper and scorekeeper?",
                    PhraseNl =
                        "Wat schrijven de spelregels voor met betrekking tot de taakverdeling tussen tijdwaarnemer en wedstrijdsecretaris?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "18.1",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "The control of the entry and exit of the substitutes is handled only by the timekeeper.",
                            PhraseNl =
                                "De controle op het betreden en het verlaten van het speelveld door de wisselspelers is voorbehouden aan de tijdwaarnemer.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Generally, only the timekeeper should interrupt the game, when this becomes necessary.",
                            PhraseNl =
                                "In het algemeen, zou enkel de tijdwaarnemer het spel moeten onderbreken, wanneer dit noodzakelijk is.",
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
                                "The scorekeeper must whistle, if he observes that a substitute enters the court too soon.",
                            PhraseNl =
                                "De wedstrijdsecretaris moet fluiten, wanneer hij vaststelt dat een uitgesloten speler te vroeg het speelveld betreedt.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "If there is no public clock, the timekeeper keeps the teams informed about how much time has been played or how much time remains.",
                            PhraseNl =
                                "Wanneer er geen muurklok beschikbaar is, houdt de tijdwaarnemer beide teams op de hoogte omtrent de gespeelde of nog te spelen tijd.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Counting the number of attacks when a player is serving 3 attacks after receiving medical care on the court is a shared task for the timekeeper and scorekeeper.",
                            PhraseNl =
                                "Het tellen van het aantal aanvallen, wanneer een speler na verzorging op het speelveld, 3 aanvallen moet afblijven, is een gezamenlijke taak van de wedstrijdsecretaris en de tijdwaarnemer.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "e",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE 5 has a clear chance of scoring. Team official A from WHITE team insults the timekeeper. The timekeeper whistles just when WHITE 5 is about to shoot. The action has been noticed only by the timekeeper. Correct decision?",
                    PhraseNl =
                        "WIT5 heeft een duidelijke scorekans. Team official A van team WIT beledigt de tijdwaarnemer. De tijdwaarnemer fluit net op het ogenblik dat WIT5 gaat werpen. De actie is enkel opgemerkt door de tijdwaarnemer. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "18.2",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team",
                            PhraseNl = "Vrije worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Punishment against team official A from WHITE team",
                            PhraseNl = "Bestraffing van team official A van team WIT",
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
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for WHITE team",
                            PhraseNl = "7m-worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "Written report",
                            PhraseNl = "Schriftelijk verslag",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "e",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "The responsible team official from WHITE team insults the scorekeeper, without this being noticed by the referees or a delegate. During the next interruption of the game, the scorekeeper informs the referees about what has happened. Correct decision?",
                    PhraseNl =
                        "De verantwoordelijke team official van team WIT beledigt de wedstrijdsecretaris, zonder dat de scheidsrechters of de waarnemer dit bemerken. Bij de volgende spelonderbreking van het spel, informeert de wedstrijdsecretaris de scheidsrechters over wat er gebeurd is. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "18.3",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of the responsible team official from WHITE team, written report (red and blue cards shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie voor de verantwoordelijke team official van team WIT, schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for the responsible team official of WHITE team",
                            PhraseNl = "2-minuten uitsluiting voor de verantwoordelijke team official van team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Written report",
                            PhraseNl = "Schriftelijk verslag",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Warning for the responsible team official from WHITE team",
                            PhraseNl = "Waarschuwing voor de verantwoordelijke team official van team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "No personal punishment possible",
                            PhraseNl = "Geen persoonlijke bestraffing mogelijk",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "e",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE team is in possession of the ball at the free-throw line of BLACK team. The technical delegate interrupts the game and explains to the referees that official A from BLACK team has insulted him. Correct decision?",
                    PhraseNl =
                        "Team WIT is in balbezit aan de vrije worplijn van team ZWART. De waarnemer onderbreekt het spel en legt de scheidsrechters uit dat official A van team ZWART hem beledigd heeft. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "18.4",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Caution for official A from BLACK team, written report",
                            PhraseNl = "Vermaning voor official A van team ZWART, schriftelijk verslag",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of official A from BLACK team, written report (red and blue cards shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie van official A van team ZWART, schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters)",
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
                                "The game is restarted with a free throw for WHITE team at the substitution area of BLACK team.",
                            PhraseNl =
                                "Het spel wordt hernomen met een vrije worp voor team WIT aan de wisselzone van team ZWART.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "The game is restarted with a free throw for WHITE team at the free-throw line of BLACK team.",
                            PhraseNl =
                                "Het spel wordt hernomen met een vrije worp voor team WIT aan de vrije worplijn van team ZWART.",
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
                        "WHITE team is in possession of the ball at the free-throw line of BLACK team. The timekeeper interrupts the game and explains to the referees that official A from WHITE team has insulted him. The action has been noticed only by the timekeeper. Correct decision?",
                    PhraseNl =
                        "Team WIT is in balbezit aan de vrije worplijn van team ZWART. De tijdwaarnemer onderbreekt het spel en legt aan de scheidsrechters uit dat official A van team WIT hem beledigd heeft. Deze actie werd enkel door de tijdwaarnemer vastgesteld. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "18.5",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Written report",
                            PhraseNl = "Schriftelijk verslag",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for official A from WHITE team, written report",
                            PhraseNl = "2-minuten uitsluiting voor official A van team ZWART, schriftelijk verslag",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "The game is restarted with a free throw for BLACK team at the substitution area of WHITE team.",
                            PhraseNl =
                                "Het spel wordt hernomen met een vrije worp voor team ZWART aan de wisselzone van team WIT.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "The game is restarted with a free throw for WHITE team at the free-throw line of BLACK team.",
                            PhraseNl =
                                "Het spel wordt hernomen met een vrije worp voor team WIT aan de vrije worp lijn van team ZWART.",
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
                        "During the match, official A from WHITE team repeatedly moves to the timekeeper’s desk to coach right next to it. While doing so he protests over referee decisions. Due to the noise in the playing hall, the referees do not notice this. Correct decision?",
                    PhraseNl =
                        "De official A van team WIT begeeft zich tijdens het spel herhaaldelijk naar de wedstrijdtafel om van vlak ernaast te coachen. Daarbij protesteert hij tegen de beslissingen van de scheidsrechters. Door het lawaai in de hal merken de scheidsrechters dit niet op. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "18.6",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "The timekeeper immediately interrupts the game and informs the referees about official A’s misbehaviour.",
                            PhraseNl =
                                "De tijdwaarnemer onderbreekt onmiddellijk het spel en licht de scheidsrechters in over het foute gedrag van official A van team WIT.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "The timekeeper waits until the next interruption of the game and informs the referees about official A’s misbehaviour.",
                            PhraseNl =
                                "De tijdwaarnemer wacht tot de volgende onderbreking van het spel en licht de scheidsrechters in over het foute gedrag van official A van team WIT.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Progressive punishment for official A from WHITE team",
                            PhraseNl = "Progressieve bestraffing voor official A van team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "No punishment possible",
                            PhraseNl = "Geen bestraffing mogelijk",
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
                        "When should the timekeeper/scorekeeper inform the referees about a violation of the Substitution Area Regulations that has not been noticed by the referees?",
                    PhraseNl =
                        "Wanneer zouden de tijdwaarnemer/wedstrijdsecretaris de scheidsrechters moeten informeren over een inbreuk op het wisselzone reglement die niet door de scheidsrechters werd opgemerkt?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "18.7",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Immediately",
                            PhraseNl = "Onmiddellijk",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "At the time of the next interruption of the game",
                            PhraseNl = "Bij de eerstvolgende spelonderbreking",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "If the technical delegate interrupts the game because of a violation by WHITE team when the ball is in play, the game is restarted with ball possession by BLACK team. Correct?",
                    PhraseNl =
                        "Indien de waarnemer het spel onderbreekt omwille van een overtreding van team WIT wanneer de bal in het spel is, wordt het spel hernomen met balbezit voor team ZWART. Correct?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "18.8",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Yes",
                            PhraseNl = "Ja",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "No",
                            PhraseNl = "Neen",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        }
                    ]
                }
            ]
        };
    }
}
