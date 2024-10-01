using IHF.Rules.Questions.Infrastructure.DataSeed.Models;

namespace IHF.Rules.Questions.Infrastructure.DataSeed;

public static partial class Rules
{
    public static RuleDto GetRule10()
    {
        return new RuleDto
        {
            Name = "The Throw-Off",
            NameNl = "De Beginworp",
            NameFr = "L’Engagement",
            NameSvn = "Začetni Met",
            NameDe = "Der Anwurf",
            NameSrb = "Почетно бацање",
            RuleNumber = "10",
            Questions =
            [
                new QuestionDto
                {
                    Phrase =
                        "WHITE team wins the coin toss and decides to start with the ball. The representative of BLACK team wants to change ends. Correct decision?",
                    PhraseNl =
                        "Team WIT wint de toss en beslist met de bal te starten. Teamaanvoerder team ZWART wil van speelveldhelft wisselen. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "10.1",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Change ends",
                            PhraseNl = "Wisselen van speelveldhelft",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Change ends if WHITE team agrees",
                            PhraseNl = "Wisselen van speelveldhelft indien team WIT akkoord gaat",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Repeat coin toss",
                            PhraseNl = "Opnieuw tossen",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Do not change ends",
                            PhraseNl = "Niet van speelveldhelft wisselen",
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
                        "WHITE team win the coin toss and want to change ends. BLACK team want WHITE team to take the throw-off. Correct decision?",
                    PhraseNl =
                        "Team WIT wint de toss en wil van speelveldhelft te wisselen. Team ZWART wil dat team WIT de beginworp neemt. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "10.2",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Throw-off by WHITE team",
                            PhraseNl = "Beginworp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Change ends and throw-off by BLACK team",
                            PhraseNl = "Wisselen van speelveldhelft, beginworp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Repeat coin toss",
                            PhraseNl = "Opnieuw tossen",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "The team representatives must come to an agreement.",
                            PhraseNl = "De teamverantwoordelijken moeten tot een overeenkomst komen.",
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
                    Phrase = "(Without throw-off area) From where can the throw-off be executed?",
                    PhraseNl = "(Zonder beginworp zone) Vanaf waar kan de beginworp uitgevoerd worden?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "10.3",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Up to 3 metres behind the centre line in the team’s own half",
                            PhraseNl = "Tot 3 meter achter de middellijn in zijn eigen speelveldhelft",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Up to 3 metres across the centre line on the opponent’s half of the court",
                            PhraseNl = "Tot 3 meter voorbij de middellijn in de speelveldhelft van de tegenstrever",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "At the centre of the court with one foot on the centre line and the other foot on or behind the line, with a sideways tolerance of about 1.5 metres",
                            PhraseNl =
                                "In het midden van het terrein, met één voet op de middellijn, en de andere voet op of achter de middenlijn, met een zijwaartse tolerantie van ongeveer 1.5 meter",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "(Without throw-off area) The score is 15:15, and just before the end of the game, BLACK team score to make it 15:16. WHITE team want to quickly take the throw-off. The player with the ball stands at the centre of the court with one foot in front of the centre line and one foot behind the line. Correct decision?",
                    PhraseNl =
                        "(Zonder beginworp zone) Speelstand 15:15 net voor het einde van de wedstrijd. Team ZWART scoort 15:16. Team WIT wil een snelle beginworp uitvoeren. De speler met de bal staat in het midden van het speelveld met een voet vóór, met de andere voet achter de middenlijn. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "10.4",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Correction; then whistle signal for executing the throw-off",
                            PhraseNl = "Correctie opstelling, dan fluitsignaal voor de uitvoering van de beginworp",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Position is correct; whistle signal for executing the throw-off",
                            PhraseNl = "De opstelling is correct, fluitsignaal voor de uitvoering van de beginworp",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Time-out; correction; whistle signal for executing the throw-off",
                            PhraseNl = "Time-out, correctie, fluitsignaal voor de uitvoering van de beginworp",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE team is about to execute a throw-off. Goalkeeper BLACK 1 is not yet in his goal area. The court referee still whistles for the match to begin, and WHITE 9 immediately scores a goal. Correct decision?",
                    PhraseNl =
                        "Team WIT staat klaar om de beginworp uittevoeren. Doelverdediger ZWART1 bevindt zich nog niet in zijn doelgebied. Desondanks fluit de veldscheidsrechter om de wedstrijd te beginnen, en WIT9 werpt direct in doel. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "10.5",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team from the centre line",
                            PhraseNl = "Vrije worp voor team WIT aan de middellijn",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Repeat the throw-off",
                            PhraseNl = "Herhaling van de beginworp",
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
                            AnswerNumber = "c",
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
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "(Without throw-off area) Which of the following statements about the throw-off are correct?",
                    PhraseNl = "(Zonder beginworp zone) Welke beweringen omtrent de beginworp zijn correct?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "10.6",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "The throw-off must be taken from the centre of the court within three seconds after the whistle signal and must be thrown into the opponents’ half of the court.",
                            PhraseNl =
                                "De beginworp moet binnen de 3 seconden na het fluitsignaal worden uitgevoerd vanuit het middelpunt van het speelveld in de richting van de speelhelft van de tegenstander.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "A goal against the opponents can be scored directly from a throw-off.",
                            PhraseNl = "De beginworp kan onmiddellijk tot een doelpunt bij de tegenstander leiden.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Illegal positions of the defending team must be corrected.",
                            PhraseNl =
                                "Bij de uitvoering van een beginworp dient een verkeerde opstelling van de tegenstander verbeterd te worden",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "If the thrower dribbles the ball after the whistle signal for executing the throw-off, then a free throw must be given to the opponents.",
                            PhraseNl =
                                "Indien de werper de bal dribbelt na het fluitsignaal voor de uitvoering van de beginworp, dan moet er een vrije worp worden toegekend aan de tegenpartij.",
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
                                "The teammates of the thrower are allowed to cross the centre line, before the throw has been taken.",
                            PhraseNl =
                                "De medespelers van de werper mogen de middellijn overschrijden vooraleer de worp uitgevoerd is.",
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
                        "(Without throw-off area) BLACK 6 stands for a throw-off in the centre of the court with one foot on the centre line and one foot in his team’s half of the court. The referee whistles. Before the ball has left his hand, the thrower runs over the centre line. At the time of the whistle, there were still players from WHITE team in BLACK team’s half of the court. Correct decision?",
                    PhraseNl =
                        "(Zonder beginworp zone) ZWART6 staat in het midden van het speelveld voor de uitvoering van een beginworp met één voet op de middenlijn, en een andere voet in zijn eigen speelveldhelft. De scheidsrechter fluit. Voor de bal zijn hand heeft verlaten, loopt ZWART6 over de middenlijn Op het moment van het fluitsignaal waren er nog enkele spelers van team WIT op de speelveldhelft van team ZWART. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "10.7",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Game continues without interruption",
                            PhraseNl = "Verder spelen zonder onderbreking",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team",
                            PhraseNl = "Vrije worp voor team WIT",
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
                                "Correction of the positions of WHITE team and repeated throw-off after whistle signal",
                            PhraseNl =
                                "Correctie van de posities van team WIT en herhaling van de beginworp na fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Correction of the position of BLACK 6 and repeated throw-off after whistle signal",
                            PhraseNl =
                                "Correctie van de positie van ZWART6 en herhaling van de beginworp na fluitsignaal",
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
                        "(With throw-off area) WHITE team scored a goal. BLACK team want to execute a fast throw-off. BLACK 9 is in a correct position inside the throw-off area. After the referees whistled for the execution, BLACK 9 takes 6 steps with the ball inside the throw-off area. Within 3 seconds after the whistle signal for the execution of the throw-off, BLACK 9 throws the ball into the empty goal of WHITE team. What is the correct decision?",
                    PhraseNl =
                        "(Met beginworp zone) Team WIT scoort een doelpunt. Team ZWART wil een snelle beginworp uitvoeren. ZWART9 is in een correcte opstelling binnen de beginworp zone. Nadat de scheidsrechters fluiten voor de uitvoering, doet ZWART9 6 stappen met de bal binnen de beginworp zone. Binnen de 3 seconden na het fluitsignaal voor de uitvoering van de beginworp, werpt ZWART9 de bal in het lege doel van team WIT. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "10.8",
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
                            Phrase = "Free throw for WHITE team",
                            PhraseNl = "Vrije worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Correction, and new throw-off after whistle signal from the referees.",
                            PhraseNl = "Correctie en nieuwe beginworp na fluitsignaal van de scheidsrechters.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "(With throw-off area) WHITE team scored a goal. BLACK team want to execute a fast throw-off. BLACK 9 receives the ball. He has the ball and one foot completely inside the throw-off area. The other foot is outside the throw-off area. The referees whistle for the execution of the throw. Before BLACK 9 moves the other foot inside the throw-off area, he throws the ball into the empty goal of WHITE team. What is the correct decision?",
                    PhraseNl =
                        "(Met beginworp zone) Team WIT scoort een doelpunt. Team ZWART wil een snelle beginworp uitvoeren. ZWART9 krijgt de bal. Hij heeft de bal en 1 voet volledig binnen de beginworp zone. De andere voet is buiten de beginworp zone. De scheidsrechters fluiten voor de uitvoering van de worp. Vooraleer ZWART9 de andere voet binnen de beginworp zone beweegt, werpt hij de bal in het lege doel van team WIT. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "10.9",
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
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team",
                            PhraseNl = "Vrije worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Correction, new throw-off for BLACK team after whistle signal from the referees",
                            PhraseNl =
                                "Correctie, nieuwe beginworp voor team ZWART na fluitsignaal van de scheidsrechters",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "The throw is executed correctly as the referees have approved the position of the thrower by giving the whistle signal for the execution.",
                            PhraseNl =
                                "De worp is correct uitgevoerd gezien de scheidsrechters de opstelling van de werper hebben goedgekeurd door het fluitsignaal te geven voor de uitvoering.",
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
                        "(With throw-off area) BLACK team want to execute a fast throw-off from the throw-off area. At the same time as BLACK 8 is running with one foot and the ball completely inside the throw-off area, WHITE 7 is also inside the throw-off area, running in the direction of his own goal. With no teammates in the direction of WHITE 7, BLACK 8 throws the ball into the back of WHITE 7. WHITE 7 is inside the throw-off area, when the ball hits him. What is the correct decision?",
                    PhraseNl =
                        "(Met beginworp zone) Team ZWART wil een snelle beginworp uitvoeren van uit de beginworp zone. Op hetzelfde ogenblik als ZWART8 met 1 voet en de bal volledig binnen de beginworp zone loopt, is WIT 7 ook in de beginworp zone, lopend in de richting van zijn eigen doel. Zonder ploeggenoot in de richting van WIT7, werpt ZWART8 de bal in de rug van WIT7. WIT7 is binnen de beginworp zone als de bal hem treft. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "10.10",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team",
                            PhraseNl = "Vrije worp voor team WIT",
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
                            Phrase = "7-metre throw for BLACK team",
                            PhraseNl = "7m-worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Progressive punishment for WHITE 7",
                            PhraseNl = "Progressieve bestraffing voor WIT7",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "Progressive punishment for BLACK 8",
                            PhraseNl = "Progressieve bestraffing voor ZWART8",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "e"
                        },
                        new AnswerDto
                        {
                            Phrase = "Direct 2-minute suspension for BLACK 8",
                            PhraseNl = "Directe 2-minuten uitsluiting voorZWART8",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "f",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "(With throw-off area) Which of the following statements regarding the throw-off area are incorrect?",
                    PhraseNl =
                        " (Met beginworp zone) Welke van de volgende uitspraken met betrekking tot de beginworp zone zijn niet correct?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "10.11",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "The whistle signal for the execution of the throw-off can be given when the thrower has a part of the body inside the throw-off area.",
                            PhraseNl =
                                "Het fluitsignaal voor de uitvoering van de beginworp kan gegeven worden als de werper een deel van zijn lichaam binnen de beginworp zone heeft.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "There is no restriction regarding the positions of the teammates of the thrower during the execution of a throw-off.",
                            PhraseNl =
                                "Er is geen beperking betreffende de positie van de ploegmaats van de werper gedurende de uitvoering van de beginworp.",
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
                                "The thrower is allowed to step outside the throw-off area during the execution of the throw-off.",
                            PhraseNl =
                                "Het is de werper toegestaan om buiten de beginworp zone te stappen gedurende de uitvoering van de beginworp.",
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
                                "A player from defending team is allowed to intercept the ball after the execution, even if the ball still is inside the throw-off area.",
                            PhraseNl =
                                "Het is een speler van het verdedigende team toegestaan om de bal na uitvoering te onderscheppen, zelfs als de bal nog binnen de beginworp zone is.",
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
                                "The thrower is not allowed to bounce the ball after the whistle signal for the execution.",
                            PhraseNl =
                                "Het is de werper niet toegestaan de bal te tippen na het fluitsignaal voor de uitvoering.",
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
                        "(With throw-off area) WHITE team plays with 7 court players and scores a goal. BLACK team wants to execute a fast throw-off. BLACK 6 has one foot and the ball inside the throw-off area. The referees whistle for the execution. WHITE 8 clearly enters the throw-off area with active arms trying to block the ball and interferes with the execution. Even so, BLACK 6 who has his entire body and the ball inside the throw-off area executes the throw-off as a shot at the empty goal. The ball crosses the outer goal line. What is the correct decision?",
                    PhraseNl =
                        "(Met beginworp zone) Team WIT speelt met 7 veldspelers en scoort een doelpunt. Team ZWART wil een snelle beginworp uitvoeren. ZWART6 heeft 1 voet binnen de beginworp zone. De scheidsrechters fluiten voor de uitvoering. WIT8 betreedt duidelijk de beginworp zone met actieve armen ineen poging om de bal te blokken en interfereert met de uitvoering. Zelfs zo, voert ZWART6, die zijn hele lichaam en de bal binnen de beginworp zone heeft, de beginworp uit als een worp naar het lege doel. De bal gaat over de buitendoellijn. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "10.12",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Goalkeeper throw for WHITE team.",
                            PhraseNl = "Uitworp voor team WIT.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "New throw-off after whistle signal.",
                            PhraseNl = "Nieuwe beginworp na fluitsignaal.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team.",
                            PhraseNl = "Vrije worp voor team ZWART.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for BLACK team.",
                            PhraseNl = "7m-worp voor team ZWART.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Time-out.",
                            PhraseNl = "Time-out.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "e",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Progressive punishment for WHITE 8.",
                            PhraseNl = "Progressieve bestraffing voor WIT8.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "f"
                        },
                        new AnswerDto
                        {
                            Phrase = "Direct 2-minute suspension for WHITE 8.",
                            PhraseNl = "Directe 2-minuten uitsluiting voor WIT8.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "g",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification for WHITE 8 (red card shown by the referees).",
                            PhraseNl = "Diskwalificatie voor WIT8 (rode kaart getoond door de scheidsrechters).",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "h"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "(With throw-off area) Which of the following statements about the throw-off area are correct?",
                    PhraseNl =
                        "(Met beginworp zone) Welke van de volgende uitspraken met betrekking tot de beginworp zone zijn correct?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "10.13",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "The throw-off is to be executed within 3 seconds of the whistle signal for the execution.",
                            PhraseNl =
                                "De beginworp moet uitgevoerd worden binnen de 3 seconden na het fluitsignaal voor de uitvoering.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "A throw-off can lead to a goal for the executing team.",
                            PhraseNl = "Een beginworp kan leiden tot een doelpunt voor het uitvoerende team.",
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
                                "In connection with a throw-off, wrong positions of defending players must be corrected.",
                            PhraseNl =
                                "In verband met een beginworp, moet een foutieve opstelling van het verdedigende team worden gecorrigeerd.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "If the thrower jumps after the whistle signal for the execution of the throw, the correct decision is free throw for the opponents.",
                            PhraseNl =
                                "Indien de werper na het fluitsignaal voor de uitvoering springt is de correcte beslissing een vrije worp voor de tegenpartij.",
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
                                "The teammates of the thrower are not allowed to cross the centre line at any time before the whistle signal for the execution of the throw.",
                            PhraseNl =
                                "De medespelers van de werper mogen de middenlijn overschrijden op ieder ogenblik voor het fluitsignaal voor de uitvoering van de worp.",
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
                    Phrase = "(With throw-off area) When can a referee whistle for the execution of a throw-off?",
                    PhraseNl =
                        "(Met beginworp zone) Wanneer kan een scheidsrechter fluiten voor de uitvoering van de beginworp?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "10.14",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "When the thrower has at least one foot and the ball inside the throw-off area, and the other foot is not outside the throw-off area on the opponent’s half of the court.",
                            PhraseNl =
                                "Wanneer de werper tenminste een voet en de bal binnen de beginworp zone heeft, en de andere voet niet buiten de beginworp zone is in de speelhelft van de tegenstrever.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "When the thrower has at least one foot inside the throw-off area, and the other foot is not outside the throw-off area on the opponent’s half of the court, but the ball is still outside the throw-off area.",
                            PhraseNl =
                                "Wanneer de werper tenminste een voet binnen de beginworp zone heeft, en de andere voet niet buiten de beginworp zone is in de speelhelft van de tegenstrever, maar de bal nog buiten de beginworp zone is.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "When the thrower has at least one foot and the ball inside the throw-off area, and the other foot is outside the throw-off area on the opponent’s half.",
                            PhraseNl =
                                "Wanneer de werper tenminste een voet en de bal binnen de beginworp zone heeft, en de andere voet is buiten de beginworp zone is op de speelhelft van de tegenstrever.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "When the thrower has at least one foot and the ball inside the throw-off area, the other foot is not outside the throw-off area on the opponent’s half of the court, but teammates of the thrower are inside the throw-off area on the opponent’s half of the court.",
                            PhraseNl =
                                "Wanneer de werper tenminste een voet en de bal binnen de beginworp zone heeft, de andere voet is niet buiten de beginworp zone op de speelhelft van de tegenstrever, maar ploegmaats van de werper zich binnen de beginworp zone van de tegenstrever bevinden.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d",
                            Correct = true
                        }
                    ]
                }
            ]
        };
    }
}
