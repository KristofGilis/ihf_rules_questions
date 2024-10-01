using IHF.Rules.Questions.Infrastructure.DataSeed.Models;

namespace IHF.Rules.Questions.Infrastructure.DataSeed;

public static partial class Rules
{
    public static RuleDto GetRule13()
    {
        return new RuleDto
        {
            Name = "The Free Throw",
            NameNl = "De Vrije Worp",
            NameFr = "Le Jet Franc",
            NameSvn = "Prosti Met",
            NameDe = "Der Freiwurf",
            NameSrb = "Слободно бацање",
            RuleNumber = "13",
            Questions =
            [
                new QuestionDto
                {
                    Phrase =
                        "There is a free throw for WHITE team. Before WHITE 5 can pick up the ball, BLACK 6 picks it up, putsit under his arm and runs towards his goal. After a few steps, he rolls the ball back to WHITE 5. Correct decision?",
                    PhraseNl =
                        "Vrije worp voor team WIT. Vooraleer WIT5 de bal kan oppakken, pakt ZWART6 deze op en loopt met de bal onder de arm in de richting van zijn eigen doel. Na enkele passen rolt hij de bal terug naar WIT5 toe. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "13.1",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for BLACK 6",
                            PhraseNl = "2-minuten uitsluiting voor ZWART6",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team after whistle signal",
                            PhraseNl = "Vrije worp voor team WIT na fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Warning for BLACK 6",
                            PhraseNl = "Waarschuwing voor ZWART6",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Game continues without interruption",
                            PhraseNl = "Verder spelen zonder onderbreking",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "Time-out",
                            PhraseNl = "Time-out",
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
                        "BLACK 7 is in possession of the ball and tries to start a counter-attack, but is held by WHITE 17. The referee is just about to whistle, but plays advantage, as BLACK 8 has just received the ball and takes a shot on goal of WHITE team. Goalkeeper WHITE 12 saves the shot and wants to start a counter-attack. Both teams have already received three warnings each earlier in the game. Correct decision?",
                    PhraseNl =
                        "ZWART7 is in balbezit en tracht een tegenaanval te starten, maar wordt door WIT17 vastgehouden. De scheidrechter wil net gaan fluiten, maar laat voordeel, wanneer ZWART8 net de bal gekregen heeft en een worp op het doel van WIT doet. Doelverdediger WIT12 vangt het shot op en wil de tegenaanval starten. Beide teams hebben eerder in de wedstrijd reeds 3 waarschuwingen gekregen. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "13.2",
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
                            Phrase = "2-minute suspension for WHITE 17",
                            PhraseNl = "2-minuten uitsluiting voor WIT17",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Goalkeeper throw for WHITE team",
                            PhraseNl = "Uitworp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Time-out",
                            PhraseNl = "Time-out",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d",
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
                            AnswerNumber = "e"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE team receives a free throw. BLACK 6 is in possession of the ball. He brings the ball with him, four metres from the place where the free-throw is to be executed. Correct decision?",
                    PhraseNl =
                        "Team WIT krijgt een vrije worp . ZWART6 in balbezit. Hij brengt de bal met zich mee, vier meter van de plaats waar WIT de vrije worp zou moeten uitvoeren. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "13.3",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Warning for BLACK 6",
                            PhraseNl = "Waarschuwing voor ZWART6",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for BLACK 6",
                            PhraseNl = "2-minuten uitsluiting van ZWART6",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification of BLACK 6 (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie voor ZWART6 (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Free throw for WHITE team from the place of the infraction that has led to the free throw",
                            PhraseNl = "Vrije worp voor team WIT op de plaats van de fout die leidde tot de vrije worp",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team from the place where the ball is",
                            PhraseNl = "Vrije worp voor team WIT op de plaats waar de bal is",
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
                        "A free throw is awarded against WHITE 4, who then takes the ball, crosses the goal area and puts the ball down. Correct decision?",
                    PhraseNl =
                        "Een vrije worp is toegekend tegen WIT4, die dan de bal neemt, het doelgebied doorkruist en de bal daar neerlegt. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "13.4",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 4",
                            PhraseNl = "2-minuten uitsluiting voor WIT4",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Warning for WHITE 4",
                            PhraseNl = "Waarschuwing voor WIT4",
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
                            Phrase = "Free throw for BLACK team",
                            PhraseNl = "Vrije worp voor team ZWART",
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
                        "WHITE 5 is in possession of the ball, when official B from WHITE team complains about the referees. The referees whistle, and the time is stopped. The referees warn official B from WHITE team. How should the game be resumed?",
                    PhraseNl =
                        "WIT5 is in balbezit wanneer official B van team WIT luidruchtig protesteert tegen de scheidsrechter. De scheidsrechters fluiten en de tijd wordt gestopt. De scheidsrechters waarschuwen official B van team WIT. Hoe zou het spel hervat moeten worden?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "13.5",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "Free throw after whistle signal for BLACK team at the substitution area of WHITE team",
                            PhraseNl = "Vrije worp voor team ZWART na fluitsignaal aan de wisselzone van team WIT",
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
                                "Free throw after whistle signal for WHITE team at the substitution area of WHITE team",
                            PhraseNl = "Vrije worp voor team WIT na fluitsignaal aan de wisselzone van team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Free throw after whistle signal for WHITE team, executed from the place where the ball was when the game was interrupted",
                            PhraseNl =
                                "Vrije worp voor team WIT na fluitsignaal uitgevoerd vanaf de plaats waar de bal zich bevond op het ogenblik van de spelonderbreking",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Throw-in for BLACK team at the substitution area of WHITE team",
                            PhraseNl = "Inworp voor team ZWART aan de wisselzone van team WIT",
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
                        "The game is interrupted by a whistle from the court referee, even though there has been no violation of the rules by any of the teams. No team time-out has been called. BLACK 13 has thrown the ball in the direction of the goal of WHITE team immediately prior to the whistle signal from the court referee. After the whistle signal, the ball goes into the goal without a chance for goalkeeper WHITE 1 to save it. How should the game be resumed?",
                    PhraseNl =
                        "Het spel wordt onderbroken door een fluitsignaal van de veldscheidsrechter zonder dat er een spelregelovertreding gebeurde door een van de teams. Er is ook geen time-out aangevraagd. ZWART13 heeft de bal in de richting van het doel van team WIT geworpen onmiddellijk voor het fluitsignaal van de veldscheidsrechter. Na het fluitsignaal gaat de bal in het doel zonder dat doelverdediger WIT1 een kans had de bal te redden. Hoe zou het spel hervat moeten worden?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "13.6",
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
                            Phrase = "Goal for BLACK team",
                            PhraseNl = "Doelpunt voor team ZWART",
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
                        "WHITE 7 is in a counterattack. With one player from BLACK team between him and the goalkeeper, he shoots on goal and hits goalkeeper BLACK 12 in the head with the ball. BLACK 12 collapses. The ball rebounds to WHITE 9, who is standing alone at the goal-area line. WHITE 9 throws the ball in the direction of the empty goal. Just before the ball crosses the goal line, the referee whistles and interrupts the game. Goalkeeper BLACK 12 needs medical care on the court. Correct decision? ",
                    PhraseNl =
                        "WIT7 is in tegenaanval. Met een speler van team ZWART tussen hem en de doelverdediger, werpt hij naar doel en treft doelverdediger ZWART12 met de bal op het hoofd. ZWART12 valt neer. De bal springt terug naar WIT9, die vrij staat aan de doelgebied. WIT9 werpt de bal in de richting van het lege doel. Net voordat de bal de doellijn overschrijdt, fluit de scheidsrechter en onderbreekt het spel. Doelverdediger ZWART12 heeft medische verzorging nodig op het speelveld. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "13.7",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Goal for WHITE team",
                            PhraseNl = "Doelpunt voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for WHITE team",
                            PhraseNl = "7m-worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team after whistle signal",
                            PhraseNl = "Vrije worp voor team WIT na fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Time-out",
                            PhraseNl = "Time-out",
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
                                "BLACK 12 must leave the court and can only re-enter following the third attack of his team.",
                            PhraseNl =
                                "ZWART12 moet het speelveld verlaten en kan enkel terugkomen na 3 aanvallen van zijn team.",
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
                        "There is a free-throw decision for BLACK 9, but WHITE 5 is still in possession of the ball. WHITE 5 moves towards one of the referees and politely gives the ball to him. Correct decision?",
                    PhraseNl =
                        "ZWART9 krijgt een vrije worp, maar WIT5 is nog in balbezit. WIT5 gaat dan naar een van de scheidsrechter en geeft hem “beleefd” de bal. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "13.8",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "2-minute suspension for WHITE 5 and free throw for BLACK team from the spot where the ball is now",
                            PhraseNl =
                                "2-minuten uitsluiting voor WIT5 en vrije worp voor team ZWART op de plaats waar de bal nu is",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Warning for WHITE 5 and free throw for BLACK team from the spot where the ball is now",
                            PhraseNl =
                                "Waarschuwing voor WIT5 en vrije worp voor team ZWART op de plaats waar de bal nu is",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "2-minute suspension for WHITE 5 and free throw for BLACK team from the spot where the foul was committed",
                            PhraseNl =
                                "2-minuten uitsluiting voor WIT5 en vrije worp voor team ZWART op de plaats waar de fout werd begaan",
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
                                "Warning for WHITE 5 and free throw for BLACK team from the spot where the foul was committed",
                            PhraseNl =
                                "Waarschuwing voor WIT5 en vrije worp voor ZWART op de plaats waar de fout werd begaan",
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
                        "WHITE 5 makes a faulty substitution after the referees have just awarded a 7-metre throw for WHITE team. Correct decision?",
                    PhraseNl =
                        "WIT5 begaat een wisselfout, nadat de scheidsrechter net een 7m-worp heeft toegekend voor team WIT. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "13.9",
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
                            Phrase = "7-metre throw for WHITE team",
                            PhraseNl = "7m-worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 5",
                            PhraseNl = "2-minuten uitsluiting voor WIT5",
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
                            PhraseNl = "Waarschuwing voor de teamverantwoordelijke van team WIT",
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
                        "Which of the following statements about the place of execution of a free throw are correct?",
                    PhraseNl =
                        "Welke van de volgende uitspraken betreffende de plaats van uitvoering van een vrije worp zijn correct?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "13.10",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "If the ball is not put down immediately after the free-throw decision, the opponents are allowed to execute the free throw from the place where the ball is.",
                            PhraseNl =
                                "Wanneer de bal niet onmiddellijk neergelegd wordt na een vrije worpbeslissing, is het de tegenstander toegestaan de vrije worp uit te voeren op de plaats waar de bal zich bevindt.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "After a faulty substitution, the free throw can be taken from where the ball is, instead of at the substitution area, if this is advantageous to the team executing the throw.",
                            PhraseNl =
                                "Na een wisselfout mag de vrije worp genomen worden op de plaats waar de bal zich bevindt in plaats van aan de wisselzone, indien dit voordeliger is voor het uitvoerende team.",
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
                                "After passive play, the free throw is always taken from the place where the ball was when the free throw was given.",
                            PhraseNl =
                                "Na passief spel wordt de vrije worp altijd genomen op de plaats waar de bal was op het ogenblik dat de vrije worp werd toegekend.",
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
                                "For a free throw from the centre line, the tolerance to the side is about the same as in case of a throw-off.",
                            PhraseNl =
                                "Voor een vrije worp op de middenlijn is de zijwaartse tolerantie ongeveer dezelfde als die bij een beginworp.",
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
                        "BLACK 11 has the ball in attack and tries to go around WHITE 2. Because of a whistle signal from the spectators’ area, WHITE 2 stops defending. BLACK 11 is now free to shoot. Correct decision?",
                    PhraseNl =
                        "ZWART11 heeft de bal in de aanval en tracht verdediger WIT2 te omspelen. Omwille van een fluitsignaal dat uit de tribune komt, stopt WIT2 zijn verdediging. ZWART11 is nu helemaal vrij om te werpen. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "13.11",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for BLACK team",
                            PhraseNl = "7m-worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Time-out; consultation with the timekeeper",
                            PhraseNl = "Time-out; overleg met de tijdopnemer",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b",
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
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team",
                            PhraseNl = "Vrije worp voor team ZWART",
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
                        "WHITE team has the ball at the free-throw line of BLACK team. Official A from BLACK team protests so strongly against a referee decision that the referees interrupt the game. Correct decision?",
                    PhraseNl =
                        "Team WIT is in balbezit aan de vrije worplijn van team ZWART. Official A van team ZWART protesteert zo fel tegen een beslissing van de scheidsrechter, dat de scheidsrechters het spel onderbreken. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "13.12",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Progressive punishment for official A from BLACK team",
                            PhraseNl = "Progressieve bestraffing van official A van team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team at the substitution area of BLACK team",
                            PhraseNl = "Vrije worp voor team WIT aan de wisselzone van team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team at the free-throw line of BLACK team",
                            PhraseNl = "Vrije worp voor team WIT aan de vrije worplijn van team ZWART",
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
                        "BLACK 6 receives a warning. When whistling for the execution of the subsequent free throw for WHITE team, the court referee does not see WHITE 11, who is between the goal-area line and the free-throw line. WHITE 11 receives the ball and has a clear chance of scoring. The goal-line referee noticed the situation. Correct decision?",
                    PhraseNl =
                        "ZWART6 krijgt een waarschuwing. Bij het fluitsignaal voor de uitvoering van de daaropvolgende vrije worp voor team WIT, verliest de veldscheidsrechter speler WIT11, die zich tussen de vrije worplijn en de doelgebied lijn bevindt, uit het oog. WIT11 krijgt de bal en heeft een open doelkans. De doelscheidsrechter had de situatie gezien. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "13.13",
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
                            Phrase = "Repeat the free throw after correction and whistle signal",
                            PhraseNl = "Herhaling van de vrije worp na correctie en fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "The goal-line referee decides on a free throw for BLACK team.",
                            PhraseNl = "De doelscheidsrechter beslist tot vrije worp voor team ZWART.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "The goal-line referee gives WHITE 11 a warning.",
                            PhraseNl = "De doelscheidsrechter geeft WIT11 een vaarschuwing.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "Time-out",
                            PhraseNl = "Time-out",
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
                        "WHITE team are in possession of the ball. BLACK team have taken their positions in defence. WHITE 8 is running close to the sideline. WHITE 4 passes the ball in the direction of WHITE 8. WHITE 8 collides with a photographer, who is walking between the stands and the court and touching the sideline. WHITE 8 fails to catch the ball and loses body control. Before the referees interrupt the game, the ball passes the sideline. What is the correct decision?",
                    PhraseNl =
                        "Team WIT is in balbezit. Team ZWART heeft zijn posities in verdediging ingenomen. WIT8 loopt vlak bij de zijlijn. WIT4 speelt de bal in de richting van WIT8. WIT8 botst met een fotograaf die wandelt tussen de tribunes en het speelveld en de zijlijn raakt. WIT8 kan de bal niet vangen en verliest zijn lichaamscontrole. Vooraleer de scheidsrechters de wedstrijd onderbreken, gaat de bal over de zijlijn. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "13.14",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "The game is restarted with a throw-in for BLACK team.",
                            PhraseNl = "Het spel wordt hernomen met een inworp voor team ZWART.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "The game is restarted with a free throw for WHITE team.",
                            PhraseNl = "Het spel wordt hernomen met een vrije worp voor team WIT.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Time-out",
                            PhraseNl = "Time-out",
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
                                "Note in the match report in conformity with the regulations of the respective federation",
                            PhraseNl =
                                "Vermelding op het wedstrijdblad in overeenstemming met de reglementering van de respectievelijke federatie",
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
                        "BLACK team are in attack. The referees give a free throw to BLACK 2. Before BLACK 2 can execute the free throw, BLACK 11 pulls WHITE 8 down. What is the correct decision?",
                    PhraseNl =
                        "Team ZWART is in aanval. De scheidsrechters geven een vrije worp aan ZWART2. Vooraleer ZWART2 de vrije worp kan uitvoeren, trekt ZWART11, WIT8 neer. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "13.15",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team after whistle signal",
                            PhraseNl = "Vrije worp voor team ZWART na fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team after whistle signal",
                            PhraseNl = "Vrije worp voor team WIT na fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Time-out",
                            PhraseNl = "Time-out",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Progressive punishment for BLACK 11",
                            PhraseNl = "Progressieve bestraffing voor ZWART11",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "Direct 2-minute suspension for BLACK 11",
                            PhraseNl = "Directe 2-minuten uitsluiting voor ZWART11",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "e",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification for BLACK 11 (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie voor ZWART11 (Rode kaart getoond door de scheidsrechter)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "f"
                        }
                    ]
                }
            ]
        };
    }
}
