using IHF.Rules.Questions.Infrastructure.DataSeed.Models;

namespace IHF.Rules.Questions.Infrastructure.DataSeed;

public static partial class Rules
{
    public static RuleDto GetRule08()
    {
        return new RuleDto
        {
            Name = "Fouls and Unsportsmanlike Conduct",
            NameNl = "Overtredingen en Onsportief Gedrag",
            NameFr = "Irrégularités et Comportements Antisportifs",
            NameSvn = "Prekrški In Nešportno Obnašanje",
            NameDe = "Regelwidrigkeiten und unsportliches Verhalten",
            NameSrb = "Прекршаји и неспортско понашање",
            RuleNumber = "8",
            Questions =
            [
                new QuestionDto
                {
                    Phrase =
                        "During a counter-attack by WHITE team, BLACK 7 enters the court as an additional player and holds WHITE 5 in such a way that the clear chance of scoring is spoiled. Correct decision?",
                    PhraseNl =
                        "Tijdens een tegenaanval van team WIT loopt ZWART7 als bijkomende speler het veld op en klemt WIT5 zodanig dat de duidelijke doelkans verdwijnt. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.1",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for BLACK 7",
                            PhraseNl = "2-minuten uitsluiting voor ZWART7",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of BLACK 7 without written report (red card shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie voor ZWART7 zonder schriftelijk verslag (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of BLACK 7 with written report (red and blue cards shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie voor ZWART7 met schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw",
                            PhraseNl = "Vrije worp",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw",
                            PhraseNl = "7-meter worp",
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
                        "BLACK 8, who is not included in the score sheet, arrives late and runs straight from the locker room onto the court. He spoils a clear chance of scoring when pushing the jump-shooting player WHITE 6, so that he loses body control. Correct decision?",
                    PhraseNl =
                        "ZWART8 die niet op het wedstrijdformulier staat, komt te laat en loopt uit de kleedkamer direct het speelveld op. Hij verhindert een duidelijke doelkans, doordat hij de in sprong zijnde speler WIT6 zo duwt, dat deze de controle over zijn lichaam verliest. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.2",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for WHITE team",
                            PhraseNl = "7m-worp voor team WIT",
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
                            Phrase =
                                "Disqualification of BLACK 8 without written report (red card shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie van ZWART8 zonder schriftelijk verslag (rode kaart getoond door de \nscheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of BLACK 8 with written report (red and blue cards shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie van ZWART8 met schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Progressive punishment against the responsible team official of BLACK team",
                            PhraseNl =
                                "Progressieve bestraffing voor de verantwoordelijke team official van team ZWART",
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
                        "On the way to the changing rooms (during the half-time break) team official B from WHITE team complains to the referees in an unsportsmanlike way. Team official A from WHITE team has already received a warning during the first half of the game. Correct decision?",
                    PhraseNl =
                        "Op weg naar de kleedkamers (tijdens de pauze) protesteert team official B van team WIT bij de scheidsrechters op een onsportieve wijze. Tijdens de eerste helft van de wedstrijd kreeg team official A van team WIT reeds een waarschuwing. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.3",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for team official B from WHITE team",
                            PhraseNl = "2-minuten uitsluiting voor team official B van team WIT",
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
                                "Disqualification of team official B from WHITE team (red card shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie van team official B van team WIT (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "WHITE team begins the second half reduced by 1 player for 2 minutes.",
                            PhraseNl = "Team WIT begint de 2e speelhelft met een speler minder gedurende 2 minuten.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "No punishment possible, but written report",
                            PhraseNl = "Geen bestraffing mogelijk, maar een schriftelijk verslag",
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
                        "WHITE 6 has already been penalised twice with a 2-minute suspension. Now, WHITE 6 commits a faulty substitution. What is the decision, if he is also guilty of extremely unsportsmanlike conduct after the referees have informed him about the faulty substitution?",
                    PhraseNl =
                        "WIT6 werd reeds tweemaal voor 2 minuten uitgesloten. Nu begaat WIT6 een wisselfout. Hoe moet beslist worden, wanneer hij zich daarbij nog schuldig maakt aan extreem grof onsportief gedrag nadat de scheidsrechters hem geïnformeerd hebben over zijn wisselfout?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.4",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 6",
                            PhraseNl = "2-minuten uitsluiting voor WIT6",
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
                                "Disqualification of WHITE 6 without written report (red card shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie van WIT6 zonder schriftelijk verslag (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of WHITE 6 with written report (red and blue cards shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie van WIT6 met schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "WHITE team reduced by 1 player on the court for 2 minutes",
                            PhraseNl = "Team WIT speelt gedurende 2 minuten met één speler minder",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "WHITE team reduced by 2 players on the court for 2 minutes",
                            PhraseNl = "Team WIT speelt gedurende 2 minuten met twee spelers minder",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "e"
                        },
                        new AnswerDto
                        {
                            Phrase = "WHITE team reduced by 1 player on the court for 4 minutes",
                            PhraseNl = "Team WIT speelt gedurende 4 minuten met één speler minder",
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
                        "WHITE 2 is suspended for 2 minutes, but official A sends him back onto the court after 1 minute. Before the timekeeper’s whistle WHITE 2 has already destroyed a clear chance of scoring for BLACK team. Correct decision?",
                    PhraseNl =
                        "WIT2 is uitgesloten voor 2 minuten, maar wordt al na 1 minuut door official A van team WIT terug het veld opgestuurd. Vooraleer de tijdwaarnemer fluit, heeft WIT2 een duidelijke doelkans voor team ZWART vernietigd. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.5",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team and additional suspension for WHITE 2",
                            PhraseNl = "Vrije worp voor team ZWART en bijkomende uitsluiting voor WIT2",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "7-metre throw for BLACK team, additional suspension for WHITE 2, and further reduction of WHITE team for the remainder of WHITE 2’s suspension time",
                            PhraseNl =
                                "7m-worp voor team ZWART, bijkomende uitsluiting voor WIT2 en verder reduceren van team WIT voor de resterende uitsluitingstijd van WIT2",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "7-metre throw, disqualification of WHITE 2 without written report, and further reduction of WHITE team for the remainder of WHITE 2’s suspension time (red card shown by the referees)",
                            PhraseNl =
                                "7m-worp, diskwalificatie van WIT2 zonder schriftelijk verslag en verder reduceren van team WIT voor de resterende uitsluitingstijd van WIT2 (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "7-metre throw, disqualification of WHITE 2, and further reduction of WHITE team for the remainder of WHITE 2’s suspension time; written report (red and blue cards shown by the referees)",
                            PhraseNl =
                                "7m-worp, diskwalificatie van WIT2 en verder reduceren van team WIT voor de resterende uitsluitingstijd van WIT2; schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters)",
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
                        "During the attack of WHITE team, pivot WHITE 7, who is not in possession of the ball, blocks BLACK 4 with his trunk. Correct decision?",
                    PhraseNl =
                        "Tijdens een aanval van team WIT, blokt WIT7, die niet in balbezit is, ZWART4 met de romp. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.6",
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
                            Phrase = "Progressive punishment against WHITE 7",
                            PhraseNl = "Progressieve bestraffing tegen WIT7",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Game continues without interruption",
                            PhraseNl = "Het spel gaat verder zonder onderbreking",
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
                        "Wing player WHITE 4 has a clear chance of scoring. BLACK 7 tries to play the ball out of his hand, but he only hits his forearm. The ball misses the goal. Correct decision?",
                    PhraseNl =
                        "Buitenspeler WIT4 komt tot een duidelijke scorekans. ZWART7 probeert de bal uit zijn hand te spelen, maar raakt alleen zijn onderarm, De bal gaat aan het doel voorbij. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.7",
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
                            Phrase = "2-minute suspension for BLACK 7",
                            PhraseNl = "2-minuten uitsluiting voor ZWART7",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Warning for BLACK 7",
                            PhraseNl = "Waarschuwing voor ZWART7",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "No progressive punishment for BLACK 7",
                            PhraseNl = "Geen progressieve bestraffing voor ZWART7",
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
                        "WHITE 6 is in a counter-attack, goalkeeper BLACK 12 leaves his goal area to gain possession of the ball, but collides with WHITE 6. However, a defender might have stopped WHITE 6 by using legal means. Correct decision?",
                    PhraseNl =
                        "WIT6 loopt in tegenaanval. Doelman ZWART12 verlaat zijn doelgebied, om in balbezit te komen, maar komt in botsing met WIT6. Maar mogelijk had echter een verdedigende speler WIT6 nog op correcte wijze kunnen afstoppen. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.8",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for BLACK 12",
                            PhraseNl = "2-minuten uitsluiting voor ZWART12",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification for BLACK 12 (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie ZWART12 (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b",
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
                            AnswerNumber = "c",
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
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification for BLACK 12, written report (red and blue cards shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie voor ZWART12, schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters)",
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
                        "WHITE 2 wants to pass the ball to a teammate into the other half of the court, but his teammate is held by BLACK 5. BLACK 5 has already received a warning for running into an opponent, who did not have the ball. Correct decision?",
                    PhraseNl =
                        "WIT2 wil een medespeler op de andere speelhelft aanspelen, maar deze wordt door ZWART5 vastgehouden. ZWART5 had voordien reeds een waarschuwing gekregen voor het aanlopen van een tegenspeler die niet in balbezit was. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.9",
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
                            Phrase = "2-minute suspension for BLACK 5",
                            PhraseNl = "2-minuten uitsluiting voor ZWART5",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification for BLACK 5 (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie van ZWART5 (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Written report (blue card shown by the referees)",
                            PhraseNl = "Schriftelijk verslag (blauwe kaart getoond door de scheidsrechters)",
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
                        "The ball is played to pivot WHITE 9, who is standing alone at the goal-area line of BLACK team. His throwing arm is then pulled back by BLACK 2. Correct decision?",
                    PhraseNl =
                        "De bal wordt naar de cirkelspeler WIT9 gespeeld, die alleen staat aan de doelgebiedlijn van team ZWART. Zijn werparm wordt dan naar achter getrokken door ZWART2. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.10",
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
                            Phrase = "2-minute suspension for BLACK 2",
                            PhraseNl = "2-minuten uitsluiting voor ZWART2",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification for BLACK 2 (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie voor ZWART2 (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Written report (blue card shown by the referees)",
                            PhraseNl =
                                "Schriftelijk rapport voor ZWART2 (blauwe kaart getoond door de scheidsrechters)",
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
                        "Shortly after BLACK 9 has received a warning for pushing in the first minute of the game, BLACK 7 holds the pivot of WHITE team. There is no clear chance of scoring. Correct decision?",
                    PhraseNl =
                        "Kort nadat ZWART7 wegens duwen mondeling vermaand werd in de eerste minuut van de wedstrijd, omklemt ZWART7 de cirkelspeler van team WIT (er is geen duidelijke scorekans). Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.11",
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
                            Phrase = "Warning for BLACK 7",
                            PhraseNl = "Waarschuwing voor ZWART7",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for BLACK 7",
                            PhraseNl = "2-minuten uitsluiting voor ZWART7",
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
                        "WHITE 4 receives the ball standing at the opponents’ goal-area line with only the goalkeeper in front of him. Before WHITE 4 tries to score, BLACK 3 pulls him down in a way that WHITE 4 loses the ball. Correct decision?",
                    PhraseNl =
                        "WIT4, krijgt de bal aan het doelgebied van de tegenstrever met enkel de doelman nog voor zich. Vooraleer WIT4 probeert te scoren, trekt ZWART3 hem neer zodat WIT4 de bal verliest. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.12",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Warning for BLACK 3",
                            PhraseNl = "Waarschuwing voor ZWART3",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for BLACK 3",
                            PhraseNl = "2-minuten uitsluiting voor ZWART3",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification for BLACK 3 (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie voor ZWART3 (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team",
                            PhraseNl = "Vrije worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for WHITE team",
                            PhraseNl = " 7m-worp voor team WIT",
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
                    Phrase = "When must a player be disqualified (red or red and blue cards shown by the referees)?",
                    PhraseNl =
                        "Wanneer moet een speler gediskwalificeerd worden (rode of rode en blauwe kaart getoond door de scheidsrechters)?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.13",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "For a foul that endangers the health of an opponent",
                            PhraseNl = "Bij een fout die de gezondheid van de tegenstrever in gevaar brengt",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "For extremely unsportsmanlike conduct on or off the court",
                            PhraseNl = "Bij uitzonderlijk onsportief gedrag op of buiten het speeloppervlak",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "For repeated unsportsmanlike conduct on the court",
                            PhraseNl = "Bij herhaald onsportief gedrag op het speeloppervlak",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "For faulty substitution during a suspension (no clear chance of scoring)",
                            PhraseNl = "Bij foutief wisselen tijdens een uitsluitingstijd (geen duidelijke doelkans)",
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
                        "During a counter-attack by WHITE 5, team official C from BLACK team runs from the bench onto the court in the direction of his own goal area. WHITE 5 becomes so confused that he stops running. In the referee’s opinion, WHITE 5 had a clear chance of scoring. The guilty official did not touch the opponent, who had the ball; his shortest distance to WHITE 5 was approximately ten metres. Correct decision?",
                    PhraseNl =
                        "Bij een tegenaanval van WIT5 loopt official C van team ZWART, van de bank uit, in de richting van het eigen doelgebied. WIT5 is zo verrast, dat hij stopt met lopen. Volgens de scheidsrechters had WIT5 een duidelijke scorekans. De schuldige official heeft noch bal, noch tegenstander aangeraakt, de kortste afstand tot WIT5 bedroeg ca. 10 meter. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.14",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Time-out",
                            PhraseNl = "Time-out",
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
                            Phrase = "7-metre throw for WHITE team",
                            PhraseNl = "7m-worp voor team WIT",
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
                                "Disqualification of team official C from BLACK team without written report (red card shown by the referees)",
                            PhraseNl =
                                " Diskwalificatie van team official C van team ZWART zonder schriftelijk verslag (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of team official C from BLACK team, written report (red and blue cards shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie van team official C van team ZWART met schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "e",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "BLACK team reduced by 1 player on the court for 2 minutes",
                            PhraseNl = "Team ZWART wordt op het speelveld met 1 speler gereduceerd gedurende 2 minuten",
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
                        "WHITE team is counter-attacking. WHITE 5 wants to play the ball to WHITE 7, who is all alone at the goal-area line of BLACK team. When WHITE 5 passes the ball, team official D from BLACK team runs onto the court and catches the ball. Correct decision?",
                    PhraseNl =
                        "Team WIT is in tegenaanval. WIT5 wil WIT7 aanspelen, die zich helemaal alleen aan de doelgebied lijn van team ZWART bevindt. Wanneer WIT5 de bal werpt, loopt team official D van team ZWART het speelveld op en vangt de bal. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.15",
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
                            Phrase = "2-minute suspension for team official D from BLACK team",
                            PhraseNl = "2-minuten uitsluiting voor team official D van team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of team official D from BLACK team without written report (red card shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie voor team official D van team ZWART zonder schriftelijk verslag (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of team official D from BLACK team, written report (red and blue cards shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie voor team official D van team ZWART, met schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "e",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "BLACK team reduced by 1 player on the court for 2 minutes",
                            PhraseNl = "Team ZWART wordt op het speelveld gereduceerd met 1 speler gedurende 2 minuten",
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
                        "Which of the following actions should be defined as extremely unsportsmanlike conduct and therefore be punished with a disqualification with a written report (red and blue cards shown by the referees)?",
                    PhraseNl =
                        "Welke van de volgende acties zou als extreem grof onsportief gedrag gedefinieerd moeten worden, en daarom met een diskwalificatie en schriftelijk verslag bestraft moeten worden?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.16",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Repeated defending with the foot or lower leg by a court player",
                            PhraseNl = "Herhaald verdedigen met de voet of onderbeen door een veldspeler",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "A team official destroying a clear chance of scoring",
                            PhraseNl = "Verhinderen van een open doelkans door een team official",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Spitting on another person",
                            PhraseNl = "Bespuwen van een ander persoon",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Repeated delays of the game, with the purpose of wasting time",
                            PhraseNl = "Herhaalde spelvertragen om tijd te winnen",
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
                        "When entering the playing hall, the referees meet BLACK 4, who wears the player’s uniform, but is not included in the score sheet for the match. BLACK 4 shouts: “Not these idiots again!” After 12 minutes of the match have been played, BLACK 4 is added to the score sheet as his team’s 14th player. This is discovered by the referees. Correct decision?",
                    PhraseNl =
                        "Bij het betreden van de sporthal, komen de scheidsrechters de reeds omgeklede, maar nog niet op het wedstrijdformulier ingeschreven ZWART4 tegen. ZWART4 roep: “Toch niet weer deze idioten”. Nadat er 12 minuten gespeeld zijn in de wedstrijd, wordt ZWART4 als 14e speler van zijn team inschrijven op het wedstrijdformulier. Dit wordt vastgesteld door de scheidsrechter. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.17",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of BLACK 4 without written report (red card shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie van ZWART4 zonder schriftelijk verslag (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "BLACK team is reduced by 1 player on the court for 2 minutes",
                            PhraseNl = "Team ZWART wordt op het speelveld gereduceerd met 1 speler gedurende 2 minuten",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "BLACK team continues without a reduction of players on the court",
                            PhraseNl = "Team ZWART speelt verder zonder reducering van een speler op het speelveld",
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
                                "Disqualification of BLACK 4, written report (red and blue cards shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie van ZWART4, schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters)",
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
                                "BLACK team can add another player to complete the team’s allowed number of 14 players.",
                            PhraseNl =
                                "Team ZWART mag een andere speler toevoegen om zijn team tot 14 spelers te vervolledigen",
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
                        "After a free throw for WHITE team, team official C from BLACK team enters the court and shouts: “But that should be a free throw for us!” No team officials from BLACK team have been punished earlier in the match. Correct decision?",
                    PhraseNl =
                        "Na een vrije worp voor team WIT, betreedt team official C van team ZWART het speelveld en roept: “Maar dat is toch vrije worp voor ons!”. Geen enkele team official van team ZWART werd eerder bestraft in de wedstrijd. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.18",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "The responsible team official from BLACK team must take team official C out of the hall.",
                            PhraseNl =
                                "De verantwoordelijke team official van team ZWART moet team official C uit de hal zetten",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "2-minute suspension for team official C from BLACK team, BLACK team is reduced by 1 player on the court for 2 minutes",
                            PhraseNl =
                                "2-minuten uitsluiting voor team official C van team ZWART, team ZWART wordt op het speelveld met 1 speler gereduceerd gedurende 2 minuten",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Warning for team official C from BLACK team",
                            PhraseNl = "Waarschuwing voor team official C van team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c",
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
                            AnswerNumber = "d",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE 3 receives a warning due to a foul on the court that requires progressive punishment. After restart of the game and after being substituted, WHITE 3 insults the referees from the substitutions bench. Correct decision?",
                    PhraseNl =
                        "WIT3 krijgt een waarschuwing omwille van een fout op het speelveld die een progressieve bestraffing vereist. Na herneming van het spel en na gewisseld te zijn, beschuldigd WIT3 de scheidsrechters vanaf de wisselbank. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.19",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of WHITE 3 without written report (red card shown by the referees, and WHITE team reduced by 1 player on the court for 2 minutes",
                            PhraseNl =
                                "Diskwalificatie van WIT3 zonder schriftelijk verslag (rode kaart getoond door de scheidsrechters) en team WIT wordt op het speelveld gereduceerd met 1 speler voor 2 minuten",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of WHITE 3, written report (red and blue cards shown by the referees), WHITE team reduced by 1 player on the court for 2 minutes",
                            PhraseNl =
                                "Diskwalificatie van WIT3 met schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters) en team WIT wordt op het speelveld gereduceerd met 1 speler voor 2 minuten",
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
                                "2-minute suspension for WHITE 3, and WHITE team reduced by 1 player on the court for 2 minutes",
                            PhraseNl =
                                "2-minuten uitsluiting van WIT3 en team WIT wordt op het speelveld gereduceerd met 1 speler voor 2 minuten",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Time-out",
                            PhraseNl = "Time out",
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
                        "During a counter-attack BLACK 9 has his shirt pulled by WHITE 4, who has already received a warning. Despite this, BLACK 9 manages to play the ball to BLACK 8, who scores a goal. The referees want to penalise WHITE 4 afterwards, but by then he is already sitting on the substitution bench. Correct decision?",
                    PhraseNl =
                        "Bij een tegenaanval wordt ZWART9 door WIT4, die voordien reeds gewaarschuwd werd, aan zijn truitje vastgehouden. Desondanks kan ZWART9 de bal toch nog naar ZWART8 spelen, die een doelpunt scoort. De scheidsrechter wil nu WIT4 na bestraffen, doch die zit ondertussen op de wisselbank. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.20",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "2-minute suspension for WHITE 4, WHITE team is reduced by 1 player on the court for 2 minutes",
                            PhraseNl =
                                "2-minuten uitsluiting voor WIT4, team WIT wordt op het speelveld gereduceerd gedurende 2 minuten",
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
                                "WHITE 4 is not allowed to play for the next 2 minutes, but the team remains complete on the court",
                            PhraseNl =
                                "WIT4 mag de volgende 2 minuten niet meer meespelen maar zijn team blijft volledig op het speelveld",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Punishment no longer possible",
                            PhraseNl = "Geen bestraffing meer mogelijk",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification for WHITE 4 (red card shown by the referees), and WHITE team is reduced by 1 player on the court for 2 minutes",
                            PhraseNl =
                                "Diskwalificatie voor WIT4 (rode kaart getoond door de scheidsrechters) en team WIT wordt met 1 speler op het speelveld gereduceerd gedurende twee minuten",
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
                        "When must a player be disqualified (red card or red and blue cards shown by the referees)?",
                    PhraseNl =
                        "Wanneer moet een speler gediskwalificeerd worden (rode kaart of rode en blauwe kaart getoond door de scheidsrechters)?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.21",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "For seriously unsportsmanlike conduct",
                            PhraseNl = "Bij grof onsportief gedrag",
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
                                "For destroying a clear chance of scoring through actively blocking a shot or pass by using his foot",
                            PhraseNl =
                                "Bij het verhinderen van een open doelkans door het actief blokken van een worp of pas met de voet",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "For faulty substitution during suspension time (no clear chance of scoring)",
                            PhraseNl = "Bij foutief wisselen tijdens een tijdelijke uitsluiting (geen open doelkans)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "For not putting down the ball for a free throw against his own team (not in the last 30 seconds)",
                            PhraseNl =
                                "Voor het niet neerleggen van de bal voor een vrije worp tegen zijn eigen team (niet in de laatste 30 seconden)",
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
                        "BLACK team is attacking. WHITE 11 takes the ball away from BLACK 6 by committing a foul that endangers the health of BLACK 6. WHITE 7 and WHITE 8 were positioned between BLACK 6 and the goal of WHITE team at the time of the foul. Correct decision?",
                    PhraseNl =
                        "Team ZWART is in de aanval. WIT11 ontneemt ZWART6 de bal, door een fout te begaan die de gezondheid van ZWART6 in gevaar brengt. WIT7 en WIT8 staan tussen ZWART6 en het doel van team WIT op het ogenblik van de fout. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.22",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 11",
                            PhraseNl = "2-minuten uitsluiting voor WIT11",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification for WHITE 11 (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie voor WIT11 (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b",
                            Correct = true
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
                        "Which of the following infractions must be punished with a disqualification with written report according to the rules (red and blue cards shown by the referees)?",
                    PhraseNl =
                        "Welke van de volgende inbreuken moeten volgens de spelregels met een diskwalificatie en een schriftelijk verslag bestraft worden (rode en blauwe kaard getoond door de scheidsrechters)?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.23",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "An official enters the court for the second time without permission.",
                            PhraseNl =
                                "Een official betreedt het speloppervlak voor de tweede maal zonder toestemming.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "An official, who tries to force his team to abandon the game.",
                            PhraseNl = "Een official die zijn team aanzet tot het stoppen van de wedstrijd.",
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
                                "When a 7-metre thrower hits the goalkeeper’s head, and the goalkeeper is not moving his head in the direction of the ball.",
                            PhraseNl =
                                "Wanneer een 7m werper het hoofd van de doelverdediger raakt, en de doelverdediger zijn hoofd niet in de richting van de bal beweegt.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "After a decision by the referees, a player demonstratively throws the ball into the stands.",
                            PhraseNl =
                                "Na een beslissing van de scheidsrechters werpt een speler de bal demonstratief in de tribune.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "A player outside the playing court spits on a spectator.",
                            PhraseNl = "Een speler buiten het speeloppervlak spuwt naar een toeschouwer.",
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
                        "WHITE 3 has received a 2-minute suspension for a foul and is sitting on the substitution bench. During a throw-in near the bench, WHITE 3 shouts at the referees to insult them. Correct decision?",
                    PhraseNl =
                        "WIT3 heeft een 2-minuten uitsluiting gekregen voor een fout en zit op de wisselbank. Bij een inworp in de buurt van de bank, roept WIT3 naar de scheidsrechter om hun te beledigen. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.24",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "2-minutes suspension for WHITE 3",
                            PhraseNl = "2-minuten uitsluiting voor WIT3",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of WHITE 3 without written report (red card shown by the referees), which causes an immediate 2-minute reduction of WHITE team on the court",
                            PhraseNl =
                                "Diskwalificatie van WIT3, zonder schriftelijk verslag (rode kaart getoond door de scheidsrechters), wat een onmiddellijke reductie gedurende 2 minuten van team WIT op het speelveld tot gevolg heeft",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "WHITE team reduced by 1 player on the court for 4 minutes",
                            PhraseNl = "Team WIT wordt met één speler gereduceerd gedurende 4 minuten",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification for WHITE 3, written report (red and blue cards shown by the referees), which causes an immediate 2-minute reduction of WHITE team on the court",
                            PhraseNl =
                                "Diskwalificatie voor WIT3, schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters), wat een onmiddellijke reductie gedurende 2 minuten van team WIT op het speelveld tot gevolg heeft",
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
                        "Due to disappointment over a mistake, WHITE 3 hits one of his teammates in the face. Correct decision?",
                    PhraseNl =
                        "Uit ontgoocheling over een fout slaat WIT3 een van zijn eigen medespeler in het gelaat. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.25",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "No action, because it involves a teammate",
                            PhraseNl = "Geen actie, aangezien het om een eigen medespeler gaat",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 3",
                            PhraseNl = "2-minuten uitsluiting voor WIT3",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of WHITE 3 without written report (red card shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie voor WIT3 zonder schriftelijk verslag (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification for WHITE 3, written report (red and blue cards shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie voor WIT3 met schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters)",
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
                        "When entering the hall the referees meet BLACK 4, who already wears a player’s uniform and immediately shouts out: “Surely not these idiots again!” The referees verify that BLACK 4 is included in the score sheet for the match. Correct decision?",
                    PhraseNl =
                        "Bij het betreden van de hal, komen de scheidsrechters de reeds aangeklede speler ZWART4 tegen, die meteen roept: “Toch niet wéér deze idioten!”. De scheidsrechters stellen vóór aanvang van de wedstrijd vast dat ZWART4 op het wedstrijdformulier staat ingeschreven. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.26",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for BLACK 4 at the beginning of the match",
                            PhraseNl = "2-minuten uitsluiting voor ZWART4 bij het begin van het spel",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of BLACK 4 without written report (red card shown by the referees), BLACK team is reduced by 1 player on the court for 2 minutes at the beginning of the match",
                            PhraseNl =
                                "Diskwalificatie van ZWART4 zonder schriftelijk verslag (rode kaart getoond door de scheidsrechters), team ZWART wordt bij het begin van de wedstrijd op het speelveld gereduceerd met 1 speler gedurende 2 minuten",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of BLACK 4, written report (red and blue cards shown by the referees), BLACK team may use 14 players in the match",
                            PhraseNl =
                                "Diskwalificatie van ZWART4, schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters). Team ZWART mag 14 spelers in de wedstrijd opstellen",
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
                                "Disqualification of BLACK 4, written report (red and blue cards shown by the referees), BLACK team may use 14 players in the match but is reduced by 1 player on the court for 2 minutes at the beginning of the match",
                            PhraseNl =
                                "Diskwalificatie van ZWART4, schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters). Team ZWART mag 14 spelers in de wedstrijd opstellen maar wordt bij het begin van de wedstrijd op het veld met 1 speler gereduceerd gedurende 2 minuten",
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
                        "While warming up before the match, WHITE 3 and goalkeeper BLACK 1 collide by accident. The two players get upset with each other, and BLACK 1 hits WHITE 3. WHITE 3 hits him straight back. Both players are included in the score sheet for the match. Correct decision?",
                    PhraseNl =
                        "Bij het opwarmen voor de wedstrijd botsen WIT3 en de doelverdediger ZWART1 per ongeluk tegen elkaar. Beide spelers schelden elkaar uit en doelman ZWART1 slaat WIT3. WIT3 slaat meteen terug. Beide spelers staan op het wedstrijdformulier ingeschreven. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.27",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of BLACK 1, written report (red and blue cards shown by the referees) and a 2-minute suspension for WHITE 3. The teams may use 14 players each in the match.",
                            PhraseNl =
                                "Diskwalificatie van ZWART1, schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters) en een 2-minuten uitsluiting van WIT3. De ploegen mogen elk tot 14 spelers aangevuld worden",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of BLACK 1 and WHITE 3, written reports (red and blue cards shown by the referees). The teams may use 14 players each in the match, but both teams are reduced by 1 player on the court for 2 minutes at the beginning of the match.",
                            PhraseNl =
                                "Diskwalificatie van ZWART1 en WIT3, schriftelijke verslagen (rode en blauwe kaart getoond door de scheidsrechters). De ploegen mogen elk tot 14 spelers aangevuld worden, maar beide teams worden bij het begin van de wedstrijd op het speelveld met 1 speler gereduceerd gedurende 2 minuten",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Both players receive a 2-minute suspension, which must be served at the beginning of the match. Written report.",
                            PhraseNl =
                                "Beide spelers krijgen een 2-minuten uitsluiting die in het begin van de wedstrijd moet worden uitgezeten. Schriftelijk verslag.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of BLACK 1 and WHITE 3, written reports (red and blue cards shown by the referees). The teams may use 14 players each in the match.",
                            PhraseNl =
                                "Diskwalificatie van ZWART1 en WIT3,, schriftelijke verslagen (rode en blauwe kaart getoond door de scheidsrechters) De ploegen mogen elk tot 14 spelers aangevuld worden.",
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
                        "WHITE 9 is taking a jump shot. BLACK 5 grabs WHITE 9’s shooting arm from behind and pulls him down. BLACK 10 and BLACK 11 are in position between WHITE 9 and the goal of BLACK team. Correct decision?",
                    PhraseNl =
                        "WIT9 is in sprongworp. ZWART5 grijpt de werparm van WIT9 langs achter en trekt hem neer. ZWART10 en ZWART11 staan nog tussen WIT9 en het doel van team ZWART. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.28",
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
                            Phrase =
                                "Disqualification of BLACK 5 without written report (red card shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie voor ZWART5 zonder schriftelijk verslag (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for BLACK 5",
                            PhraseNl = "2-minuten uitsluiting voor ZWART5",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of BLACK 5, written report (red and blue cards shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie voor ZWART5, schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters)",
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
                        "Which of the following infractions must be punished with a disqualification (red card shown by the referees)?",
                    PhraseNl =
                        "Welke van de volgende overtredingen moet bestraft worden met een diskwalificatie (rode kaart getoond door de scheidsrechters)?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.29",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "An official enters the court for the second time without permission.",
                            PhraseNl =
                                "Een official betreedt voor de tweede keer het speeloppervlak zonder toestemming.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "A player in possession of the ball is pulled down when running during a counter-attack. The situation is not particularly dangerous.",
                            PhraseNl =
                                "Een speler in balbezit wordt neergetrokken terwijl hij in tegenaanval loopt, de situatie is niet zeer gevaarlijk.",
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
                                "A 7-metre throw hits the face of the goalkeeper, who is not moving in the direction of the ball.",
                            PhraseNl =
                                "Een 7-m-worp raakt het gezicht van de doelverdediger, die niet beweegt in de richting van de bal.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "After a referee decision a player throws the ball into the stands as a protest.",
                            PhraseNl =
                                "Na een beslissing van de scheidsrechter werpt een speler uit protest de bal in de tribune.",
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
                                "The goalkeeper leaves the goal area and gains possession of the ball, but causes a collision with an opponent, who is running in a counter-attack.",
                            PhraseNl =
                                "De doelverdediger verlaat het doelgebied en komt in balbezit, maar veroorzaakt een botsing met de tegenspeler die in tegenaanval loopt.",
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
                        "WHITE 9 receives his third 2-minute suspension and is therefore disqualified. Wearing his tracksuit he takes a seat in the first spectators’ row behind the sideline opposite the substitution area. Directly in front of him, BLACK 3 commits a particularly dangerous foul against WHITE 10. The player remains injured on the floor. Before the referees can punish BLACK 3, WHITE 9 runs onto the court and knocks BLACK 3 down. Correct decision?",
                    PhraseNl =
                        "WIT9 krijgt zijn derde 2-minuten uitsluiting en is daardoor gediskwalificeerd. In trainingspak neemt hij plaats, op de eerste rij toeschouwers aan de zijlijn, tegenover de wisselzone. Vlak voor hem begaat ZWART3 een grove fout tegen WIT10. De speler blijft gekwetst op de grond blijft liggen. Voor de scheidsrechters ZWART3 kunnen bestraffen, loopt WIT9 het plein op en slaat ZWART3 neer. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.30",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Time-out",
                            PhraseNl = "Time-out",
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
                                "Disqualification of BLACK 3, written report (red and blue cards shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie van ZWART3, schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "WHITE 9 is not involved in the match any more, no remarks possible",
                            PhraseNl = "WIT9 is niet meer betrokken bij het spel, vandaar geen vermeldingen mogelijk",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Written report about the behaviour of WHITE 9",
                            PhraseNl = "Schriftelijk verslag over het gedrag van WIT9",
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
                                "Disqualification of BLACK 3 without written report (red card shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie van ZWART3 zonder schriftelijk verslag (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "e"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "WHITE 10 must leave the court after receiving medical care and can only re-enter following the third attack of his team.",
                            PhraseNl =
                                "WIT10 moet na verzorging het speelveld verlaten en mag pas terug opkomen na drie aanvallen van zijn team.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "f"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase = "A warning shall be given for:",
                    PhraseNl = "Een waarschuwing moet gegeven worden bij:",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.31",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "Infractions where the action is mainly or exclusively aimed at the body of the opponent",
                            PhraseNl =
                                "Overtredingen waarbij de actie voornamelijk of uitsluitend gericht is op het lichaam van de tegenstrever",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Infractions while the opponents are executing a formal throw",
                            PhraseNl = "Overtredingen wanneer de tegenstander een gewone worp uitvoert",
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
                                "Failure to put the ball down on the floor when a decision is made against one’s own team",
                            PhraseNl = "Het niet neerleggen van de bal bij beslissingen tegen het eigen team",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "A goalkeeper’s attempt to make a substitution when an opponent is ready to take a 7-metre throw",
                            PhraseNl =
                                "Een doelverdediger die aanstalten maakt om te wisselen wanneer de tegenstander klaarstaat voor de uitvoering van een 7-meterworp",
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
                    Phrase = "What must be considered as unsportsmanlike conduct?",
                    PhraseNl = "Wat moet worden beschouwd als onsportief gedrag?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.32",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "Throwing the ball in the face of a defender, who is not moving in the direction of the ball",
                            PhraseNl =
                                "De bal in het gezicht van de tegenstrever werpen, die zich niet in de richting van de bal baweegt",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Passive behaviour by the goalkeeper during the execution of a 7-metre throw, if it is apparent that he is not willing to save the shot",
                            PhraseNl =
                                "Passief gedrag van een doelverdediger bij een 7m-worp zodat duidelijk is dat hij de 7m-worp niet wil trachten te stoppen",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Trying to mislead the referees through fake actions",
                            PhraseNl = "Poging om de scheidsrechters met komedie te misleiden",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Actively blocking a shot by using a foot or lower leg",
                            PhraseNl = "Actief blokken van een worp door gebruik van voeten en onderbeen",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Repeated entering the goal area for tactical reasons",
                            PhraseNl = "Herhaaldelijk betreden van het doelgebied om tactische redenen",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "e",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "An act of revenge after having been fouled",
                            PhraseNl = "Revanche actie na een ondergane overtreding",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "f"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "In which of the following situations must a disqualification lead to a written report (red and blue cards shown by the referees)?",
                    PhraseNl =
                        "In welke van de volgende gevallen moet een diskwalificatie een schriftelijk verslag tot gevolg hebben (rode en blauwe kaart getoond door de scheidsrechters)?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.33",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Assault on the playing court during the half-time break",
                            PhraseNl = "Een gewelddaad op het speeloppervlak tijdens de pauze",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "A particularly reckless or dangerous action",
                            PhraseNl = "Een uitzonderlijk roekeloze en gevaarlijke overtreding",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "An act of revenge after having been fouled",
                            PhraseNl = "Revanche actie na een ondergane overtreding",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "A malicious action, which is not in any way related to the game situation",
                            PhraseNl =
                                "Een gemene en intentionele actie, die op geen enkele wijze verband houdt met de spelsituatie",
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
                        "There is a throw-off for WHITE team. The referee has given the whistle signal, and WHITE 9 is ready to execute the throw-off. After the whistle signal, WHITE 3 crosses the centre line and is pulled down from behind by BLACK 5 in a way he totally loses body control. Correct decision?",
                    PhraseNl =
                        "Beginworp voor team WIT. De scheidsrechters hebben aangefloten en WIT9 is klaar om de beginworp uit te voeren. Na het fluitsignaal, overschrijdt WIT3 loopt de middellijn en wordt langs achter neergetrokken door ZWART5 zodat hij de lichaamscontrole verliest. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.34",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for BLACK 5",
                            PhraseNl = "2-minuten uitsluiting voor ZWART5",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of BLACK 5 without written report (red card shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie van ZWART5, zonder schriftelijk verslag (rode kaart getoond door de scheidsrechters)",
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
                            Phrase = "Throw-off for WHITE team",
                            PhraseNl = "Beginworp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "e"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of BLACK 5, written report (red and blue cards shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie van ZWART5, schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "f"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "BLACK 8 has received a 2-minute suspension because of a faulty substitution. Two seconds after the game has been restarted, he makes a comment to the referees in an unsportsmanlike manner from his position on the bench. Correct decision?",
                    PhraseNl =
                        "ZWART8 heeft 2-minuten uitsluiting gekregen voor een foutieve wissel. Twee seconden nadat het spel hernomen werd, geeft hij commentaar op de scheidsrechters op een onsportieve wijze vanaf zijn positie op de bank. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.35",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Additional 2-minute suspension for BLACK 8",
                            PhraseNl = "Een bijkomende 2-minuten uitsluiting voor ZWART8",
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
                                "Disqualification of BLACK 8 without written report (red card shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie voor ZWART8 zonder schriftelijk verslag (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "BLACK team will be reduced by 2 players on the court for the next 1 minute and 58 seconds and then by 1 player on the court for 2 seconds.",
                            PhraseNl =
                                "Team ZWART zal gereduceerd worden met 2 spelers op het speelveld voor de volgende 1’58” en daarna met 1 speler op het speelveld voor 2 seconden.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "BLACK team will be reduced by 2 players on the court for the next 2 minutes.",
                            PhraseNl =
                                "Team ZWART zal gereduceerd worden met twee spelers op het speelveld voor de volgende 2 minuten",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team",
                            PhraseNl = "Vrije worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "e",
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
                            AnswerNumber = "f",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "Goalkeeper WHITE 1 throws a long pass to WHITE 15, who is running alone towards the opponents’ goal. Goalkeeper BLACK 12 leaves his goal area, jumps up, catches the ball and collides with WHITE 15 while in the air. Both players fall to the ground and lie there injured. Correct decision?",
                    PhraseNl =
                        "Doelverdediger WIT1 werpt een lange pass naar WIT15, die alleen op het doel van de tegenstrever af loopt. Doelverdediger ZWART12 verlaat zijn doelgebied, springt op, vangt de bal en botst terwijl hij in de lucht is met WIT15. Beide spelers vallen op de grond en blijven gekwetst liggen. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.36",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Time-out, 2-minute suspension for WHITE 15",
                            PhraseNl = "Time-out, 2-minuten uitsluiting voor WIT15",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Time-out, 2-minute suspension for BLACK 12",
                            PhraseNl = "Time-out, 2-minuten uitsluiting voor ZWART12",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Time-out, disqualification for BLACK 12",
                            PhraseNl = "Time-out, diskwalificatie voor ZWART12",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c",
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
                            AnswerNumber = "d"
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
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for WHITE team",
                            PhraseNl = "7m-worp voor team WIT",
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
                        "BLACK team is in possession of the ball. The delegate interrupts the game because official A from BLACK team has thrown a chair onto the court in protest at a referee decision. There were no previous punishments given to the team officials from BLACK team. BLACK 7 had a clear chance of scoring, when the game was interrupted. Correct decision?",
                    PhraseNl =
                        "Team ZWART heeft balbezit. De waarnemer onderbreekt het spel omdat official A van team ZWART een stoel op het speelveld heeft gegooid als protest tegen een beslissing van de scheidsrechter. Voordien was er nog geen bestraffing geweest tegen de teamofficials van team ZWART. ZWART 7 had een duidelijke scorekans toen het spel werd onderbroken. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.37",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Warning for official A from BLACK team",
                            PhraseNl = "Waarschuwing voor official A van team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for official A from BLACK team",
                            PhraseNl = "2-minuten uitsluiting official A van team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of official A from BLACK team without written report (red card shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie voor official A van team ZWART zonder schriftelijk verslag (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team",
                            PhraseNl = "Vrije worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for BLACK team",
                            PhraseNl = "7-meter-worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "e"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of official A from BLACK team, written report (red and blue cards shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie voor official A van team ZWART, schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters)",
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
                        "Official A from WHITE team protests loudly at a referee decision against his team and states: “You are idiots!” Ten minutes earlier, official C from WHITE team has already received a warning. Correct decision?",
                    PhraseNl =
                        "Official A van team WIT protesteert met luid stem op een beslissing van de scheidsrechters tegen zijn team en schreeuwt “jullie zijn idioten”. 10 minuten eerder heeft official C van team WIT al een verwittiging gekregen. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.38",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Warning for official A from WHITE team due to unsportsmanlike conduct",
                            PhraseNl = "Verwittiging van official A van team WIT wegens onsportief gedrag",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "2-minute suspension for official A from WHITE team; WHITE team is reduced by 1 player on the court for 2 minutes",
                            PhraseNl =
                                "2-minuten uitsluiting voor official A van team WIT; team WIT wordt met 1 speler op het speelveld gereduceerd gedurende 2 minuten",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of official A from WHITE team, written report (red and blue cards shown by the referees); WHITE team is reduced by 1 player on the court for 2 minutes",
                            PhraseNl =
                                "Diskwalificatie van official A van team WIT, schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters). Team WIT wordt met 1 speler op het speelveld gereduceerd gedurende 2 minuten",
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
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "Goalkeeper WHITE 1 wants to carry out a goalkeeper throw. For the second time, BLACK 3 now enters the goal area and tries to prevent WHITE 1 from executing the throw without body contact with him. Correct decision?",
                    PhraseNl =
                        "Doelverdediger WIT1 wil een uitworp uitvoeren. Voor de tweede maal betreedt ZWART3 nu het doelgebied en probeert, zonder lichaamscontact, deze uitworp te hinderen. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.39",
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
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Goalkeeper throw for WHITE team after whistle signal",
                            PhraseNl = "Uitworp voor team WIT na fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Warning for BLACK 3",
                            PhraseNl = "Waarschuwing voor ZWART3",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for BLACK 3",
                            PhraseNl = "2-minuten uitsluiting voor ZWART3",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d",
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
                            AnswerNumber = "e",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE 4 touches the ball that is rolling on the floor in the goal area of BLACK team. At this moment, he is pushed to the floor by BLACK 6. Correct decision?",
                    PhraseNl =
                        "WIT4 raakt de in het doelgebied van de team ZWART rollende bal. Op dat ogenblik wordt hij op de grond geduwd door ZWART6. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.40",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Progressive punishment for BLACK 6",
                            PhraseNl = "Progressieve bestraffing van ZWART6",
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
                            Phrase = "Goalkeeper throw for BLACK team",
                            PhraseNl = "Uitworp voor team ZWART",
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
                        "WHITE 7 has just received a 2-minute suspension for unsportsmanlike conduct. This is his first suspension. Ten seconds after the game has been restarted, he makes strong gestures on the bench to show that he does not agree with the referees. Correct decision?",
                    PhraseNl =
                        "WIT7 heeft net een 2-minuten uitsluiting gekregen voor onsportief gedrag. Het is zijn eerste uitsluiting. 10 seconden nadat het spel hernomen werd maakt hij van op de bank met hevige gebaren duidelijk dat hij het niet eens is met de beslissing van de scheidsrechter. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.41",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of WHITE 7 without written report (red card shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie voor WIT7 zonder schriftelijk verslag (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "2-minute suspension for WHITE 7; WHITE 7 must remain on the bench for four minutes",
                            PhraseNl =
                                "2-minuten uitsluiting voor WIT7; WIT7 moet gedurende 4 minuten op de bank blijven",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Additional 2-minute suspension for WHITE 7; WHITE team will be reduced by 2 players on the court for 1 minute and 50 seconds and then by 1 player on the court for 10 seconds.",
                            PhraseNl =
                                "Een bijkomende 2-minuten uitsluiting voor WIT7, team WIT moet met 2 spelers gereduceerd worden op het speelveld gedurende 1’50”, en daarna met 1 speler op het speelveld gedurende 10 seconden.",
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
                                "Warning because the progressive punishment on the bench is separate from the punishments on the court",
                            PhraseNl =
                                "Waarschuwing, aangezien de progressieve bestraffing op de bank gescheiden is van de progressieve bestraffingen op het speelveld",
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
                        "WHITE 6 is pushed by BLACK 3 and spits demonstratively on the floor in front of BLACK 3. How shall WHITE 6 be punished?",
                    PhraseNl =
                        "WIT6 wordt door ZWART3 geduwd; daarna spuwt WIT6 demonstratief op de grond voor ZWART3. Hoe moet WIT6 bestraft worden?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.42",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Progressive punishment",
                            PhraseNl = "Progressieve bestraffing",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Always with a 2-minute suspension",
                            PhraseNl = "Altijd met 2-minuten uitsluiting",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification without written report (red card shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie zonder schriftelijk verslag (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification, written report (red and blue cards shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie met schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters)",
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
                        "Goalkeeper WHITE 12 runs from the goal area towards BLACK 10, who is counter-attacking. WHITE 12 approaches BLACK 10 from the side and holds on to him, but BLACK 10 is able to catch the ball to throw it into the empty goal. Correct decision?",
                    PhraseNl =
                        "Doelverdediger WIT12 loopt uit zijn doelgebied naar de in tegenaanval zijnde speler ZWART10. WIT12 nadert ZWART10 zijdelings en houdt hem vast, maar ZWART10 kan de bal vangen en deze in het lege doel werpt. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.43",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Throw-off",
                            PhraseNl = "Beginworp",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a",
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
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification of WHITE 12",
                            PhraseNl = "Diskwalificatie voor WIT12",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 12",
                            PhraseNl = "2-minuten uitsluiting voor WIT12",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for BLACK team",
                            PhraseNl = "7m-worp voor team ZWART",
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
                        "Goalkeeper WHITE 12 executes a goalkeeper throw, playing a long pass in the direction of his teammate WHITE 4, who is running in a counter-attack. WHITE 4 jumps to receive the ball and immediately after this, he collides with goalkeeper BLACK 1, who has decided to leave his goal area in an attempt to stop the counter-attack. At the time of the collision, BLACK 1 stands completely still in front of the 9-metre line. After the collision, WHITE 4 loses his body control and falls to the floor. Correct decision?",
                    PhraseNl =
                        "Doelverdediger WIT12 voert de uitworp uit met een lange bal naar de in tegenaanval lopende medespeler WIT4. WIT4 springt omhoog om de bal te pakken en onmiddellijk daarna botst hij met de doelverdediger ZWART1, die besliste om zijn doelgebied te verlaten in een poging om de tegenaanval te verhinderen. Op het ogenblik van de botsing, staat ZWART1 volledig stil aan de 9m lijn. Na de botsing verliest WIT4 de lichaamscontrole en valt op de grond. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.44",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Offensive foul, free throw for BLACK team",
                            PhraseNl = "Aanvallende fout, vrije worp voor team ZWART",
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
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for WHITE team",
                            PhraseNl = "7m-worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Progressive punishment for BLACK 1",
                            PhraseNl = "Progressieve bestraffing voor ZWART1",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of BLACK 1 without written report (red card shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie van ZWART1 zonder schriftelijk verslag (rode kaart getoond door de scheidsrechters)",
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
                        "Which of the following infractions must be punished with a disqualification with written report according to the rules (red and blue cards shown by the referees)?",
                    PhraseNl =
                        "Welke van de volgende overtredingen moeten overeenkomstig de spelregels bestraft worden met een diskwalificatie en schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters)?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.45",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "A player spitting on an opponent",
                            PhraseNl = "Een speler bespuwt een tegenstrever",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "An official trying to force his team to abandon the game",
                            PhraseNl = "Een official probeert zijn team te dwingen om de wedstrijd af te breken",
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
                                "A 7-metre shooter hitting the goalkeeper’s head, with the goalkeeper not moving his head in the direction of the ball",
                            PhraseNl =
                                "Wanneer een 7m werper het hoofd van de doelverdediger raakt, waarbij de doelverdediger zijn hoofd niet richting bal beweegt",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "After a referee decision, a player throws the ball demonstratively into the stands.",
                            PhraseNl =
                                "Na een beslissing van de scheidsrechters werpt een speler de bal demonstratief in de tribune.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "A player outside the playing court spitting on a spectator",
                            PhraseNl = "Een speler bespuwt buiten het speeloppervlak een toeschouwer",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "e",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "A player intentionally hitting an opponent in the stomach",
                            PhraseNl = "Een speler slaat opzettelijk een tegenspeler in de maag",
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
                        "The playing time is 59:26. Player BLACK 10 is running alone in a counter-attack. When he receives the ball from a teammate, BLACK 10 collides with goalkeeper WHITE 1, who has left the goal area, but before falling down he is able to pass the ball to BLACK 7, who shoots at the empty goal, but the ball goes wide. When the referees order a time-out, the playing time is 59:31. Correct decision?",
                    PhraseNl =
                        "Wedstrijdtijd is 59:26. Speler ZWART10 loopt alleen in tegenaanval. Wanneer hij de bal krijgt van een ploegmaat, botst ZWART10 met doelman WIT1 die zijn doelgebied verlaten heeft, maar alvorens neer te vallen slaagt hij erin om de bal naar ZWART7 te spelen die naar een leeg doel kan werpen, maar de bal gaat naast het doel. Wanneer de scheidsrechters een time-out geven staat de klok op 59:31. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.46",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Free throw",
                            PhraseNl = "Vrije worp",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw",
                            PhraseNl = "7m-worp",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Red card for WHITE 1",
                            PhraseNl = "Rode kaart voor WIT1",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Blue card for WHITE 1",
                            PhraseNl = "Blauwe kaart voor WIT1",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "Goalkeeper throw",
                            PhraseNl = "Uitworp",
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
                        "WHITE team is in attack and plays with seven court players. BLACK 5 intercepts a pass and gets possession of the ball. He immediately tries to take a shot on goal. WHITE 2 tries to prevent BLACK 5 from taking a shot on goal by trying to play the ball out of his hand. By doing so, he hits BLACK 5’s forearm, and the ball misses the goal. Earlier in the match, WHITE team has received three warnings. Correct decision?",
                    PhraseNl =
                        "Team WIT is in aanval en speelt met 7 veldspelers. ZWART5 onderschept een pas en komt in balbezit. Hij probeert onmiddellijk een worp naar doel te doen. WIT2 tracht te verhinderen dat ZWART5 naar doel kan werpen door de bal uit zijn hand te spelen? Hierbij raakt hij de onderarm van ZWART5 en de bal mist het doel. Team WIT heeft eerder in de wedstrijd 3 waarschuwingen gekregen. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.47",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Goalkeeper throw for WHITE team",
                            PhraseNl = "Uitworp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
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
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 2",
                            PhraseNl = "2-minuten uitsluiting voor WIT2",
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
                        "WHITE team is in attack and plays with seven court players. BLACK 5 intercepts a pass and gets possession of the ball. He immediately tries to take a shot on goal. WHITE 2 tries to prevent BLACK 5 from taking a shot on goal by pulling him down. The ball misses the goal. Correct decision?",
                    PhraseNl =
                        "Team WIT is in aanval en speelt met 7 veldspelers. ZWART5 onderschept een pas en komt in balbezit. Hij probeert onmiddellijk een worp naar doel te doen. WIT2 probeert te verhinderen dat ZWART5 naar doel kan werpen door hem neer te trekken. De bal mist het doel. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.48",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Goalkeeper throw for WHITE team",
                            PhraseNl = "Uitworp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
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
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 2",
                            PhraseNl = "2-minuten uitsluiting voor WIT2",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d",
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
                            AnswerNumber = "e",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE team is in attack and plays with seven court players. WHITE 4 takes a shot on goal, but the ball is saved by goalkeeper BLACK 1. BLACK 1 passes the ball to BLACK 9. Just as goalkeeper WHITE 12 enters his goal area, BLACK 9 tries to take a shot on goal, but he is prevented by a foul from WHITE 2. The ball passes the outer goal line. Correct decision?",
                    PhraseNl =
                        "Team WIT is in aanval en speelt met 7 veldspelers. WIT4 werpt naar doel, maar de bal wordt gered door doelman ZWART1. ZWART1 speelt de bal naar ZWART9. Net als doelman WIT12 in zijn doelgebied komt, tracht ZWART9 een worp naar doel te doen, maar dit wordt verhinderd door een fout van WIT2. De bal gaat over de buitendoellijn. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.49",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Goalkeeper throw for WHITE team",
                            PhraseNl = "Uitworp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team",
                            PhraseNl = "Vrije worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b",
                            Correct = true
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
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE team is in attack and plays with seven court players. WHITE 4 takes a shot on goal, but the ball is saved by goalkeeper BLACK 1, who is standing with the ball in his goal area ready to execute the goalkeeper throw. At that moment, the delegate interrupts the game because of a faulty substitution, as goalkeeper WHITE 1 entered the court before WHITE 7 has left it. Correct decision?",
                    PhraseNl =
                        "Team WIT is in aanval en speelt met 7 veldspelers. WIT4 werpt naar doel, maar de bal wordt gered door doelman ZWART1, die met de bal in zijn doelgebied staat, klaar om de uitworp uit te voeren. Op dat ogenblik onderbreekt de waarnemer het spel omwille van een foutieve wissel, omdat doelman WIT1 het speelveld betrad, vooraleer WIT7 het verlaten had. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.50",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Goalkeeper throw for BLACK team after whistle signal",
                            PhraseNl = "Uitworp voor team ZWART na fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a",
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
                            AnswerNumber = "b",
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
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for BLACK team",
                            PhraseNl = "7m-worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 1",
                            PhraseNl = "2-minuten uitsluiting voor WIT1",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "e",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 7",
                            PhraseNl = "2-minuten uitsluiting voor WIT7",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "f"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE team is in attack and plays with seven court players. WHITE 4 takes a shot on goal, but the ball is saved by goalkeeper BLACK 12. BLACK 12 passes the ball to BLACK 9. BLACK 9 takes a shot on goal. Court player WHITE 10 enters his own goal area and manages to save the ball. The ball passes the outer goal line. Correct decision?",
                    PhraseNl =
                        "Team WIT is in aanval en speelt met 7 veldspelers. WIT4 werpt naar doel, maar de bal wordt gered door doelman ZWART12. ZWART12 speelt de bal naar ZWART9. ZWART9 werpt naar doel. Veldspeler WIT10 betreedt zijn eigen doelgebied en slaagt erin om de bal te redden. De bal gaat over de buitendoellijn. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.51",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Throw-in for BLACK team",
                            PhraseNl = "Inworp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
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
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Progressive punishment for WHITE 10",
                            PhraseNl = "Progressieve bestraffing voor WIT10",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "Direct 2-minute suspension for WHITE 10",
                            PhraseNl = "Directe 2-minuten uitsluiting voor WIT10",
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
                        "WHITE team is in attack and plays with seven court players. WHITE 6 takes a shot on goal, but the ball is saved by goalkeeper BLACK 1. BLACK 1 immediately tries to score in the empty goal, but he misses the goal, and the ball passes the outer goal line. Correct decision?",
                    PhraseNl =
                        "Team WIT is in aanval en speelt met 7 veldspelers. WIT6 werpt naar doel, maar de bal wordt gered door de doelman ZWART1. ZWART1 probeert onmiddellijk in het lege doel te scoren, maar hij mist het doel, en de bal gaat over de buitendoellijn. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.52",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Goalkeeper throw for WHITE team",
                            PhraseNl = "Uitworp voor team WIT",
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
                                "The goalkeeper throw may be executed by any player on the court from WHITE team to keep the flow in the game.",
                            PhraseNl =
                                "De uitworp mag uitgevoerd worden door om het even welke speler van team WIT op het speelveld om het spel vlot te houden.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "WHITE team has to make a substitution to get a goalkeeper on the court to execute the goalkeeper throw.",
                            PhraseNl =
                                " Team WIT moet een wissel doen om een doelman in het speelveld te krijgen om de uitworp uit te voeren.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Time-out is obligatory",
                            PhraseNl = "Verplichte Time-out",
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
                        "BLACK team is playing with seven court players. BLACK 5 takes a shot on goal, but the shot is saved by goalkeeper WHITE 1. WHITE 1 tries to score in the empty goal. At the same time, goalkeeper BLACK 12 makes a faulty substitution, as he runs onto the court before BLACK 7 has left it. The delegate immediately interrupts the game with a whistle signal. Just after the whistle signal from the delegate, the ball crosses the outer goal line of BLACK team. Correct decision?",
                    PhraseNl =
                        "Team ZWART speelt met 7 veldspelers. ZWART5 werpt naar doel, maar het schot wordt door doelman WIT1 gered. WIT1 probeert te scoren in het lege doel. Op hetzelfde ogenblik maakt doelman ZWART12 een foutieve wissel, omdat hij op het veld loopt nog vooraleer ZWART7 het verlaten heeft. De waarnemer onderbreekt onmiddellijk het spel met een fluitsignaal. Vlak na het fluitsignaal van de waarnemer, gaat de bal over de buitendoellijn van team ZWART. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.53",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for BLACK 12",
                            PhraseNl = "2-minuten uitsluiting voor ZWART12",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for BLACK 7",
                            PhraseNl = "2-minuten uitsluiting voor ZWART7",
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
                            Phrase = "Goalkeeper throw for BLACK team",
                            PhraseNl = "Uitworp voor team ZWART",
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
                        "BLACK team is playing with seven court players. BLACK 6 takes a shot on goal, but the shot is saved by goalkeeper WHITE 1. WHITE 1 tries to score in the empty goal. At the same time, goalkeeper BLACK 12 makes a faulty substitution, as he runs onto the court before BLACK 7 has left it. The delegate immediately interrupts the game with a whistle signal. Just after the whistle signal from the delegate, the ball crosses the goal line into the goal of BLACK team. Correct decision?",
                    PhraseNl =
                        "Team ZWART speelt met 7 veldspelers. ZWART6 werpt naar doel, maar het schot wordt door doelman WIT1 gered. WIT1 probeert te scoren in het lege doel. Op hetzelfde ogenblik maakt doelman ZWART12 een foutieve wissel, omdat hij het speelveld op loopt vooraleer ZWART7 dit heeft verlaten. De waarnemer onderbreekt onmiddellijk het spel met een fluitsignaal. Net na het fluitsignaal van de waarnemer, overschrijdt de bal de doellijn in het doel van team ZWART. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.54",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for BLACK 12",
                            PhraseNl = "2-minuten uitsluiting voor ZWART12",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for BLACK 7",
                            PhraseNl = "2-minuten uitsluiting voor ZWART7",
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
                            Phrase = "7-metre throw for WHITE team",
                            PhraseNl = "7m-worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Goal for WHITE team",
                            PhraseNl = "Doelpunt voor team WIT",
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
                        "BLACK team is playing with seven court players. WHITE 9 intercepts the ball and manages to score in the empty goal. The ball gets to rest in the goal area. Correct decision?",
                    PhraseNl =
                        "Team zwart speelt met 7 veldspelers. WIT9 onderschept de bal en slaagt erin om te scoren in het lege doel. De bal blijft in het doelgebied liggen. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.55",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Goal and throw-off for BLACK team",
                            PhraseNl = "Doelpunt en beginworp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a",
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
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "A goalkeeper must enter the court under a correct substitution to get the ball in the goal area.",
                            PhraseNl =
                                "Een doelman moet op het speelveld komen via een correcte wissel om de bal in het doelgebied te halen",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "The ball may be picked up by any court player from BLACK team.",
                            PhraseNl =
                                "De bal mag vrij opgehaald worden door gelijk welke speler op het speelveld van team ZWART",
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
                        "The score is 27:27 with six seconds left in the match. WHITE team is in attack. WHITE 7 tries to pass the ball to pivot WHITE 3. BLACK 7 intercepts the ball. At that moment he is pulled down by WHITE 3. One second later the final signal from the public clock sounds to end the game. Correct decision?",
                    PhraseNl =
                        "De score is 27-27 met nog 6 seconden te spelen. Team WIT is in aanval. WIT7 probeert de bal naar pivot WIT3 te spelen. ZWART7 onderschept de bal. Op dat ogenblik wordt hij door WIT3 neergetrokken. Een seconde later weerklinkt het eindsignaal vanaf de muurklok om de wedstrijd te beëindigen. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.56",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "The game is over.",
                            PhraseNl = "De wedstrijd is afgelopen",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team",
                            PhraseNl = "Vrije worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b",
                            Correct = true
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
                            Phrase = "2-minute suspension for WHITE 3",
                            PhraseNl = "2-minuten uitsluiting voor WIT3",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification for WHITE 3 (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie voor WIT3 (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "e"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of WHITE 3 with written report (red and blue cards shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie met schriftelijk verslag voor WIT3 (rode en blauwe kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "f"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "The score is 27:27 with ten seconds left in the match. WHITE team is in attack. BLACK 5 intercepts a pass and starts a counter-attack. A moment later he is attacked from behind by WHITE 11, who pushes him in a dangerous way, so that he loses body control. Before the referee whistles for the infraction, the final signal from the public clock sounds. Correct decision?",
                    PhraseNl =
                        "De score is 27-27 met nog 10 seconden te spelen. Team WIT is in aanval. ZWART5 onderschept een pas en start een tegenaanval. Een ogenblik later wordt hij langs achter aangevallen door WIT11, die hem op een gevaarlijke wijze duwt zodat hij zijn lichaamscontrole verliest. Vooraleer de scheidsrechters fluiten voor de overtreding, weerklinkt het eindsignaal van de wedstrijdklok. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.57",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "The game is over.",
                            PhraseNl = "De wedstrijd is afgelopen",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
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
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 11",
                            PhraseNl = "2-minuten uitsluiting voor WIT11",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification for WHITE 11 (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie voor WIT11 (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "e",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of WHITE 11 with written report (red and blue cards shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie met schriftelijk verslag voor WIT11 (rode en blauwe kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "f"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "BLACK 10 is in possession of the ball. The time is 59:27 when he executes a jump shot. WHITE 2 pushes him so hard in the chest that he completely loses body control. He falls with the ball to the floor. The referee whistles, and the clock is stopped at 59:31. Correct decision?",
                    PhraseNl =
                        "ZWART10 is in balbezit. Het is 59:27 wanneer hij een sprongworp uitvoert. WIT2 duwt hem zo hard op de borst dat hij volledig de lichaamscontrole verliest. Hij valt met de bal op de vloer. De scheidsrechters fluiten en de klok wordt gestopt op 59:31. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.58",
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
                            Phrase = "7-metre throw for BLACK team",
                            PhraseNl = "7m-worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 2",
                            PhraseNl = "2-minuten uitsluiting voor WIT2",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification for WHITE 2 (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie voor WIT2 (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d",
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
                            AnswerNumber = "e",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "With 15 second left in the game, BLACK team is in possession of the ball. The referees give a free throw for BLACK team at the centre line. Before BLACK 7 is able to execute the free throw, he is blocked by WHITE 2. Correct decision?",
                    PhraseNl =
                        "Met nog 15 seconden te spelen, is team zwart in bezit van de bal. De scheidsrechters geven een vrije worp voor team ZWART aan de middenlijn. Vooraleer ZWART7 de vrije worp kan uitvoeren, wordt hij geblokt door WIT2. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.59",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Time-out",
                            PhraseNl = "Time-out",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Correction and a new free throw for BLACK team after whistle signal",
                            PhraseNl = "Correctie en een nieuwe vrije worp voor team ZWART na een fluitsignaal",
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
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 2",
                            PhraseNl = "2-minuten uitsluiting voor WIT2",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification for WHITE 2 (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie voor WIT2 (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "e",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of WHITE 2 with written report (red and blue cards shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie voor WIT2, schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "f"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "BLACK team is in attack. The referees give a free throw for BLACK team at the free-throw line with three seconds left in the match. BLACK 10 is in a correct position and ready to execute the free throw directly on the goal, but player WHITE 5, who is standing one metre from BLACK 10, blocks the shot on goal. Then the final signal sounds. Correct decision?",
                    PhraseNl =
                        "Team ZWART is in aanval. De scheidsrechters geven een vrije worp voor team ZWART aan de vrije worplijn met nog 3 seconden te spelen. ZWART10 is op de juiste plaats en klaar om de vrije worp uit te voeren direct naar doel, maar speler WIT5, die op 1 meter van ZWART10 staat, blokt de worp op doel. Dan weerklinkt het eindsignaal. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.60",
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
                            AnswerNumber = "a",
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
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification for WHITE 5 (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie voor WIT5 (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c",
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
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "BLACK team is in attack. The referees give a free throw for BLACK team at the free-throw line with three seconds left in the match. Player BLACK 10 is in a correct position to execute the free throw directly on the goal, but before he can take the shot, he is prevented by WHITE 5, who moves into a distance of one metre moving his arms and jumping in front of BLACK 10. Then the final signal sounds. Correct decision?",
                    PhraseNl =
                        "Team ZWART is in aanval. De scheidsrechters geven een vrije worp voor team ZWART aan de vrije worplijn met nog 3 seconden te spelen. ZWART10 is op de juiste plaats en klaar om de vrije worp uit te voeren direct naar doel, maar vooraleer hij de worp kan uitvoeren, wordt hij gehinderd door WIT5, die beweegt naar een afstand van 1m met zijn armen staat te wuiven en staat te springen voor ZWART10. Dan weerklinkt het eindsignaal. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.61",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 5",
                            PhraseNl = "2-minuten uitsluiting voor WIT5",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification for WHITE 5 (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie voor WIT5 (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b",
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
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for BLACK team",
                            PhraseNl = "7m-worp voor team ZWART",
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
                        "With 19 seconds left in the match WHITE 2 is trying to break through, but the referees whistle steps against WHITE 2. After the whistle from the referees, WHITE 2 takes a shot on goal. The ball is grabbed by goalkeeper BLACK 12, and he is ready to start a counter-attack. Correct decision?",
                    PhraseNl =
                        "Met nog 19 seconden op de klok, probeert WIT2 een doorbraak te maken, maar de scheidsrechters fluiten loopfout tegen WIT2. Na het fluitsignaal van de scheidsrechters, werpt WIT2 naar het doel. De bal wordt snel opgenomen door doelman ZWART12, en hij is klaar om de tegenaanval te starten. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.62",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Play on",
                            PhraseNl = "Verder spelen",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Time-out",
                            PhraseNl = "Time-out",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 2",
                            PhraseNl = "2-minuten uitsluiting voor WIT2",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification for WHITE 2 (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie van WIT2 (rode kaart getoond door de scheidsrechters)",
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
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for BLACK team",
                            PhraseNl = "7m-worp voor team ZWART",
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
                        "The score is 28:26 for WHITE team. With 25 seconds left in the match, BLACK team score a goal. Goalkeeper WHITE 12 kicks the ball away on purpose, so that it ends up in the spectators’ seats. It is clear that he kicks the ball with the intention of delaying the game, so that the throw-off cannot be executed immediately. What is the correct decision?",
                    PhraseNl =
                        "De score is 28:26 voor team WIT. Met nog 25 sec te gaan in de wedstrijd, scoort team ZWART. Doelman WIT12 schopt de bal opzettelijk weg, zo dat deze in de toeschouwer tribune terecht komt. Het is duidelijk dat hij de bal weg schopt met de intentie om het spel te vertragen, zodat de beginworp niet onmiddellijk kan genomen worden. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.63",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Time-out",
                            PhraseNl = "Time-out",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Throw-off for WHITE team",
                            PhraseNl = "Beginworp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b",
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
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for BLACK team",
                            PhraseNl = "7m-worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 12",
                            PhraseNl = "2-minuten uitsluiting voor WIT12",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "e"
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification for WHITE 12 (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie voor WIT12 (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "f",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification for WHITE 12 with written report (red and blue cards shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie voor WIT12 met schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "g"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "The score is 25:25 with 3 seconds left in the match. WHITE team are in attack. BLACK 5 causes a free throw for WHITE 2 at the free-throw line. Shortly after, the final signal sounds. The referees whistle for the execution of the free throw after the final signal. Before the ball has left the hand of the thrower, BLACK 6 steps forward and blocks the ball standing too close. What is the correct decision?",
                    PhraseNl =
                        "De score is 25-25 met nog 3 sec te gaan in de wedstrijd. Team WIT is in aanval. ZWART5 veroorzaakt een vrije worp voor WIT2 aan de vrije worplijn. Kort daarna weerklinkt het eindsignaal. De scheidsrechters fluiten voor de uitvoering van de vrije worp na het eindsignaal. Vooraleer de bal de hand van de werper verlaten heeft, stapt ZWART6 vooruit en blokt de bal terwijl hij te kortbij staat. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.64",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "The game is over.",
                            PhraseNl = "De wedstrijd is afgelopen.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "The free throw must be retaken.",
                            PhraseNl = "De vrije worp moet opnieuw genomen worden.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for WHITE team",
                            PhraseNl = "7m worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for BLACK 6",
                            PhraseNl = "2-minuten uitsluiting voor ZWART6",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification for BLACK 6 (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie voor ZWART6 (rode kaart getoond door de scheidsrechters)",
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
                        "WHITE team are playing without a goalkeeper and with 7 field players. BLACK 5 intercepts a pass and runs with the ball in the direction of the empty goal of WHITE team. Goalkeeper WHITE 12 enters the court under a correct substitution and runs in the same direction as BLACK 5. Just as BLACK 5 takes a shot on goal, goalkeeper WHITE 12 pushes BLACK 5 from the side, so that he partly loses body control and his shot misses the goal. What is the correct decision?",
                    PhraseNl =
                        "Team WIT speelt zonder doelman en met 7 veldspelers. ZWART5 onderschept een pass en loopt met de bal in de richting van het lege doel van team WIT. Doelman WIT12 komt op het speelveld na een correcte wissel en loopt in dezelfde richting als ZWART5. Net op het ogenblik dat ZWART5 een worp naar doel doet, duwt WIT12, ZWART5 van op zij, zo dat hij gedeeltelijk zijn lichaamscontrole verliest en zijn worp het doel mist. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.65",
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
                            Phrase = "7-metre throw for BLACK team",
                            PhraseNl = "7m-worp voor team ZWART",
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
                            PhraseNl = "Time-Out",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 12",
                            PhraseNl = "2-minuten uitsluiting voor WIT12",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification for WHITE 12 (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie voor WIT12 (rode kaart getoond door de scheidsrechters)",
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
                        "The score is 26:26 with 4 seconds left in the match. WHITE team are in attack. A free throw is caused for WHITE 4. WHITE 4 immediately executes the free throw. The ball is actively blocked by BLACK 5, who is standing too close. At the same time, the final signal sounds. What is the correct decision?",
                    PhraseNl =
                        "De score is 26:26 met nog 4 sec te spelen in de wedstrijd. Team WIT is in aanval. Een vrije worp wordt veroorzaakt tegen WIT4. WIT4 voert de vrije worp onmiddellijk uit. De bal wordt actief geblokt door ZWART5 die te kort bij staat. Op hetzelfde ogenblik weerklinkt het eindsignaal. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.66",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "The free throw must be retaken.",
                            PhraseNl = "De vrije worp moet opnieuw genomen worden",
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
                            Phrase = "2-minute suspension for BLACK 5",
                            PhraseNl = "2-minuten uitsluiting voor ZWART5",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification for BLACK 5 (red card shown by the referees)",
                            PhraseNl = " Diskwalificatie van ZWART5 (rode kaart getoond door de scheidsrechters)",
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
                        "The score is 26:26 with 4 seconds left in the match. WHITE team are in attack. BLACK 5 causes a free throw for WHITE 6. BLACK 5 immediately moves back to the correct distance. WHITE 6 executes the free throw, and the ball hits BLACK 5, who does not take an active action. The ball rebounds back to WHITE 6. At the same time, the final signal sounds. What is the correct decision?",
                    PhraseNl =
                        "De score is 26:26 met nog 4 sec te spelen in de wedstrijd. Team WIT is in aanval. ZWART5 veroorzaakt een vrije worp voor WIT6. ZWART5 gaat onmiddellijk achteruit tot de correcte afstand. WIT6 voert de vrije worp uit, en de bal raakt ZWART5, die geen actieve actie onderneemt. De bal botst terug naar WIT6. Op hetzelfde ogenblik weerklinkt het eindsignaal. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.67",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "No further action. The match is over",
                            PhraseNl = "Geen verdere actie. De wedstrijd is ten einde",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "The free throw must be retaken.",
                            PhraseNl = "De vrije worp moet hernomen worden.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for WHITE team",
                            PhraseNl = "7m-worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for BLACK 5",
                            PhraseNl = "2-minuten uitsluiting voor ZWART5",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification for BLACK 5",
                            PhraseNl = "Diskwalificatie van ZWART5",
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
                        "The score is 29:29 with 20 seconds left in the match. Goalkeeper WHITE 12 saves a shot on goal, and the ball crosses the outer goal line. The referees decide on goalkeeper throw for WHITE team. WHITE 12 wants to quickly execute the goalkeeper throw. BLACK 2 runs into the goal area and delays the execution of the throw. What is the correct decision?",
                    PhraseNl =
                        "De score is 29-29 met nog 20 sec te gaan in de wedstrijd. Doelman WIT12 stopt een worp op zijn doel en de bal overschrijdt de buiten doellijn. De scheidsrechters beslissen op uitworp voor team WIT. WIT12 wil snel de uitworp uitvoeren. ZWART2 loopt het doelgebied in en vertraagd de uitvoering van de uitworp. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.68",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Time-out",
                            PhraseNl = "Time-out",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Goalkeeper throw for WHITE team after whistle signal",
                            PhraseNl = "Uitworp voor team WIT na fluitsignaal",
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
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for WHITE team",
                            PhraseNl = "7m-worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for BLACK 2",
                            PhraseNl = "2-minuten uitsluiting voor ZWART2",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "e"
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification for BLACK 2 (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie van ZWART2 (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "f",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification for BLACK 2 with written report (red and blue cards shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie van ZWART2 met schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "g"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "The score is 29:29 with 20 seconds left in the match. Goalkeeper WHITE 12 saves a shot on goal, and the ball crosses the outer goal line. The referees decide on goalkeeper throw for WHITE team. WHITE 12 gets ready to execute the goalkeeper throw. Before the ball has left his hand, a whistle signal sounds from the timekeeper because of a faulty substitution made by BLACK team. BLACK 3 has entered the court before BLACK 11 has left it. What is the correct decision?",
                    PhraseNl =
                        "De score is 29-29 met nog 20 sec te gaan in de wedstrijd. Doelman WIT12 stopt een worp op zijn doel en de bal overschrijdt de buiten doellijn. De scheidsrechters beslissen op uitworp voor team WIT. WIT12 is klaar om de uitworp uit te voeren. Vooraleer de bal zijn hand verlaten heeft, weerklinkt een fluitsignaal van de tijdwaarnemer omdat er een foutieve wissel gebeurde door team ZWART. ZWART3 heeft het speelveld betreden vooraleer ZWART11 het verlaten heeft. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.69",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Time-out",
                            PhraseNl = "Time-out",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Goalkeeper throw for WHITE team after whistle signal",
                            PhraseNl = "Uitworp voor team WIT na fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team at the substitution area of BLACK team",
                            PhraseNl = "Vrije worp voor team WIT aan de wisselzone van team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for WHITE team",
                            PhraseNl = "7m-worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for BLACK 3",
                            PhraseNl = "2-minuten uitsluiting voor ZWART3",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "e"
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification for BLACK 3 (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie van ZWART3 (rode kaart getoond door de scheidsrechters)",
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
                        "The score is 29:29 with 20 seconds left in the match. Goalkeeper WHITE 12 saves a shot on goal, and the ball crosses the outer goal line. The referees decide on goalkeeper throw for WHITE team. WHITE 12 executes the throw as a pass to WHITE 9, who is standing just outside the goal area. Before the ball has crossed the goal-area line, a whistle signal sounds from the timekeeper because of a faulty substitution made by BLACK team. BLACK 3 has entered the court before BLACK 11 has left it. What is the correct decision?",
                    PhraseNl =
                        "De score is 29-29 met nog 20 sec te gaan in de wedstrijd. Doelman WIT12 stopt een worp op zijn doel en de bal overschrijdt de buiten doellijn. De scheidsrechters beslissen op uitworp voor team WIT. WIT12 voert de uitworp uit met een pass naar WIT9 die net buiten het doelgebied staat. Vooraleer de bal de doelgebied lijn overschrijdt, weerklinkt een fluitsignaal van de tijdwaarnemer omdat er een foutieve wissel gebeurde door team ZWART. ZWART3 heeft het speelveld betreden vooraleer ZWART11 het verlaten heeft. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.70",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Time-out",
                            PhraseNl = "Time-out",
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
                            Phrase = "7-metre throw for WHITE team",
                            PhraseNl = "7m-worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for BLACK 3",
                            PhraseNl = "2-minuten uitsluiting voor ZWART3",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification for BLACK 3 (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie van ZWART3 (rode kaart getoond door de scheidsrechters)",
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
                        "The score is 29:29 with 10 seconds left in the match. WHITE team are in a counter-attack. BLACK 10 attacks WHITE 9 in a way that is dangerous to his health. Before falling, WHITE 9 plays the ball to WHITE 11. WHITE 11 takes a shot on goal, but the ball is saved by goalkeeper BLACK 12. What is the correct decision?",
                    PhraseNl =
                        "De score is 29-29 met nog 10 sec te gaan in de wedstrijd. Team WIT is in tegenaanval. ZWART10 valt WIT9 aan op een wijze die gevaarlijk is voor zijn gezondheid. Alvorens te vallen speelt WIT9 de bal naar WIT11. WIT11 werpt naar doel, maar de bal wordt gered door doelman ZWART12. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.71",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for BLACK 10",
                            PhraseNl = "2-minuten uitsluiting voor ZWART10",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification for BLACK 10 (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie van ZWART10 (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Goalkeeper throw for BLACK team",
                            PhraseNl = "Uitworp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team",
                            PhraseNl = "Vrije worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for WHITE team",
                            PhraseNl = "7m-worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "e",
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
                            AnswerNumber = "f",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "The score is 29:29 with 10 seconds left in the match. WHITE team are in a counter-attack. BLACK 10 attacks WHITE 9 in a way that is dangerous to his health. Before falling, WHITE 9 plays the ball to WHITE 11. WHITE 11 scores a goal. What is the correct decision?",
                    PhraseNl =
                        "De score is 29-29 met nog 10 sec te gaan in de wedstrijd. Team WIT is in tegenaanval. ZWART10 valt WIT9 aan op een wijze die gevaarlijk is voor zijn gezondheid. Alvorens te vallen speelt WIT9 de bal naar WIT11. WIT11 scoort een doelpunt. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.72",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for BLACK 10",
                            PhraseNl = "2-minuten uitsluiting voor ZWART10",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification for BLACK 10 (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie van ZWART10 (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b",
                            Correct = true
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
                            Phrase = "Free throw for WHITE team",
                            PhraseNl = "Vrije worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for WHITE team",
                            PhraseNl = "7m-worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "e"
                        },
                        new AnswerDto
                        {
                            Phrase = "Time-out",
                            PhraseNl = "Time-out",
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
                        "The score is 29:29 with 10 seconds left in the match. WHITE team are in a counter-attack. BLACK 10 attacks WHITE 9 in a way that is dangerous to his health. Before falling, WHITE 9 plays the ball to WHITE 11. WHITE 11 plays the ball to WHITE 4. What is the correct decision?",
                    PhraseNl =
                        "De score is 29-29 met nog 10 sec te gaan in de wedstrijd. Team WIT is in tegenaanval. ZWART10 valt WIT9 aan op een wijze die gevaarlijk is voor zijn gezondheid. Alvorens te vallen speelt WIT9 de bal naar WIT11. WIT11 speelt de bal door naar WIT4. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.73",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for BLACK 10",
                            PhraseNl = "2-minuten uitsluiting voor ZWART10",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification for BLACK 10 (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie van ZWART10 (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Referee whistles after the pass from WHITE 11 to WHITE 4",
                            PhraseNl = "De scheidsrechters fluiten na de pass van WIT11 naar WIT4",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c",
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
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for WHITE team",
                            PhraseNl = "7m-worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "e",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Time out",
                            PhraseNl = "Time-out",
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
                        "WHITE 7 is in a counterattack. He has a clear chance of scoring and takes an unhindered shot on goal. The ball hits goalkeeper BLACK 12 in the head, and he falls to the floor. The rebounding ball is recovered by WHITE 9 who has a clear chance of scoring at the goal-area line of BLACK team. At that moment, the referees whistle to call for medical treatment for goalkeeper BLACK 12. What is the correct decision?",
                    PhraseNl =
                        "WIT7 is in tegenaanval. Hij heeft een duidelijke scoringskans en werpt ongehinderd naar doel. De bal raakt de doelverdediger ZWART12 op het hoofd, en hij valt op de grond. De terugkaatsende bal wordt bemachtigd door WIT9 die een duidelijke scorekans heeft aan de doelgebied lijn van team ZWART. Op dat ogenblik fluiten de scheidsrechters voor de medische behandeling van doelverdediger ZWART 12. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.74",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 7.",
                            PhraseNl = "2-minuten uitsluiting voor WIT7",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Goalkeeper throw for BLACK team.",
                            PhraseNl = "Uitworp voor team ZWART.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team.",
                            PhraseNl = "Vrije worp voor team WIT.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for WHITE team.",
                            PhraseNl = "7m-worp voor team WIT.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team.",
                            PhraseNl = "Vrije worp voor team ZWART.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "e",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "No punishment for WHITE 7.",
                            PhraseNl = "Geen bestraffing voor WIT7.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "f"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Goalkeeper BLACK 12 must leave the court and can only re-enter after his team have completed 3 attacks.",
                            PhraseNl =
                                "Doelverdediger ZWART12 moet het speelveld verlaten en mag pas opnieuw het speelveld betreden nadat zijn team haar derde aanval beëindigd heeft.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "g"
                        },
                        new AnswerDto
                        {
                            Phrase = "Time-out.",
                            PhraseNl = "Time-out",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "h",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE team leads by one goal with 7 seconds left until the end of the match. WHITE team are ready to execute a throw-off from the throw-off area, and the referees give the whistle signal for the execution. Instead of passing the ball to a teammate, WHITE 7 puts the ball down on the floor inside the throw-off area and walks away. No teammates are interested in entering the throw-off area to pick up the ball. What is the correct decision?",
                    PhraseNl =
                        "Team WIT leidt met 1 doelpunt met nog 7 seconden te spelen tot het einde van de wedstrijd. Team WIT staat klaar om een beginworp te nemen, en de scheidsrechters geven het fluitsignaal voor de uitvoering. In plaats van de bal naar een medespeler te spelen, legt WIT7 de bal op de grond binnen de beginworp-zone en wandelt weg. Geen enkele medespeler is geïnteresseerd om de beginworp-zone te betreden en de bal op te rapen. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.75",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Correction of the throw-off.",
                            PhraseNl = "Correctie van de beginworp.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Time-out.",
                            PhraseNl = "Time-out.",
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
                                "The referees must wait 3 seconds after the whistle signal for the execution before they can give a free throw for BLACK team.",
                            PhraseNl =
                                "De scheidsrechters moeten 3 seconden wachten na het fluitsignaal voor de uitvoering vooraleer zij een vrije worp voor team ZWART kunnen geven.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Direct 2-minute suspension for WHITE 7.",
                            PhraseNl = "Directe 2-minuten uitsluiting voor WIT7.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Free-throw for BLACK team.",
                            PhraseNl = "Vrije worp voor team ZWART.",
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
                        "BLACK 8 breaks through the defence of WHITE team and has no players between himself and the goalkeeper WHITE 1. When he is about to shoot on goal, he is pushed from the side by WHITE 7. Even if he partly loses body control, he is able to shoot hard on goal. The ball hits the head of goalkeeper WHITE 1, changes direction and goes into the goal. What is the correct decision?",
                    PhraseNl =
                        "ZWART8 breekt door de verdediging van team WIT en heeft geen speler meer tussen hem en doelverdediger WIT1. Wanneer hij een doelworp wil nemen, wordt hij van op zij geduwd door WIT7. Zelfs wanneer hij gedeeltelijk zij lichaamscontrole versliest, is hij in staat om hard naar doel te werpen. De bal treft het hoofd van doelverdediger WIT1, verandert van richting en gaat in doel. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.76",
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
                            Phrase = "Direct 2-minute suspension for BLACK 8",
                            PhraseNl = "Directe 2-minuten uitsluiting voor ZWART8",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Direct 2-minute suspension for WHITE 7",
                            PhraseNl = "Directe 2-minuten uitsluiting voor WIT7",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for BLACK team",
                            PhraseNl = "7m-worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "e"
                        },
                        new AnswerDto
                        {
                            Phrase = "Time-out",
                            PhraseNl = "Time-out",
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
                        "Line player BLACK 8 receives the ball. When he is trying to turn towards the goal, he is strongly held and pulled down by WHITE 7. However, he still regains full body control. Without any players between himself and the goalkeeper, he jumps above the goal area. He shoots hard with full body control. The ball hits goalkeeper WHITE 1 in the head. The head is the first point of contact with the ball. The ball changes direction and goes into the goal. What is the correct decision?",
                    PhraseNl =
                        "Cirkelspeler ZWART8 krijgt de bal. Wanneer hij zich richting doel wil draaien, wordt hij stevig vastgehouden en neergetrokken door WIT7. Niettemin behoudt hij volledige lichaamscontrole. Zonder enige speler tussen hem en de doelverdediger, springt hij boven het doelgebied. Hij werpt hard met volledige lichaamscontrole. De bal raakt doelverdediger WIT1 op het hoofd. Het hoofd is het eerste contact punt met de bal. De bal verandert van richting en gaat in het doel. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.77",
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
                            Phrase = "Free throw for BLACK team",
                            PhraseNl = "Vrije worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for BLACK team",
                            PhraseNl = "7m-worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "Direct 2-minute suspension for BLACK 8",
                            PhraseNl = "Directe 2-minuten uitsluiting voor ZWART8",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "e",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Direct 2-minute suspension for WHITE 7",
                            PhraseNl = "Directe 2-minuten uitsluiting voor WIT7",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "f",
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
                            AnswerNumber = "g",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "Wing player BLACK 3 has a clear chance of scoring and takes a shot on goal. The ball touches the side of the head of goalkeeper WHITE 1 without changing direction. The ball goes into the goal. What is the correct decision?",
                    PhraseNl =
                        "Hoekspeler ZWART3 heeft een duidelijke scorekans en werpt naar doel. De bal raakt de zijkant van het hoofd van doelverdediger WIT1 zonder van richting te veranderen. De bal gaat in het doel. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.78",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Direct 2-minute suspension for BLACK 3.",
                            PhraseNl = "Directe 2-minuten uitsluiting voor ZWART3",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Progressive punishment for WHITE 1.",
                            PhraseNl = "Progressieve bestraffing voor WIT1.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Goal.",
                            PhraseNl = "Doelpunt.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team.",
                            PhraseNl = "Vrije worp voor team WIT.",
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
                        "Wing player BLACK 3 has a clear chance of scoring and takes a shot on goal. The ball hits the side of the head of goalkeeper WHITE 1 and changes direction. The head is the first point of contact with the ball. The ball goes into the goal. WHITE 1 falls to the floor, puts his hand on his head, and clearly needs medical assistance. What is the correct decision?",
                    PhraseNl =
                        "Hoekspeler ZWART3 heeft een duidelijke scorekans en werpt naar doel. De bal raakt de zijkant van het hoofd van doelverdediger WIT1 en verandert van richting. Het hoofd is het eerste contactpunt met de bal. De bal gaat in het doel. WIT1 valt op de grond, houdt zijn hand op het hoofd en heeft duidelijk medische verzorging nodig. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "8.79",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Time-out.",
                            PhraseNl = "Time-out.",
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
                                "The referees call for medical assistance for WHITE 1 by showing hand signals 15 and 16.",
                            PhraseNl =
                                "De scheidsrechters vragen medische assistentie voor WIT1 door de tekens 15 en 16 te tonen.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Direct 2-minute suspension for BLACK 3.",
                            PhraseNl = "Directe 2-minuten uitsluiting voor ZWART3.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Progressive punishment for WHITE 1.",
                            PhraseNl = "Progressieve bestraffing voor WIT1.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "Goal.",
                            PhraseNl = "Doelpunt.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "e"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team.",
                            PhraseNl = "Vrije worp voor team WIT.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "f",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "After receiving medical assistance WHITE 1 must leave the court and can only re-enter after his team completed 3 attacks.",
                            PhraseNl =
                                "Na medische assistentie ontvangen te hebben, moet WIT1 het speelveld verlaten en mag dit pas terug betreden nadat zijn team 3 aanvallen vervolledigd heeft.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "g"
                        }
                    ]
                }
            ]
        };
    }
}
