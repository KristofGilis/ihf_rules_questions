using IHF.Rules.Questions.Infrastructure.DataSeed.Models;

namespace IHF.Rules.Questions.Infrastructure.DataSeed;

public static partial class Rules
{
    public static RuleDto GetRule02()
    {
        return new RuleDto
        {
            Name = "Playing Time, Final Signal and Time-Out",
            NameNl = "Speeltijd, Eindsignaal en Time-Out",
            NameFr = "Temps de jeu, Signal de fin et Arrêt du temps de jeu",
            NameSvn = "Igralni Čas, Končni Signal In Prekinitev Igralnega Časa (Time–Out)",
            NameDe = "Spielzeit, Schlusssignal, Time-out",
            NameSrb = "Време трајања игре, завршни сигнал и тајм-аут",
            RuleNumber = "2",
            Questions =
            [
                new QuestionDto
                {
                    Phrase =
                        "Goalkeeper WHITE 1 deflects a shot, and the ball crosses the outer goal line straight before the automatic final signal from the public clock. The referees realise that the match has ended five minutes early. As the players are still on the court, the game is resumed by:",
                    PhraseNl =
                        "Doelman WIT1 weert een worp af, en de bal rolt over de buitendoellijn vlak voordat het automatisch eindsignaal weerklinkt van de publieke klok. De scheidsrechters stellen vast dat het spel 5 minuten te vroeg werd beëindigd. Gezien de spelers zich nog op het speeloppervlak bevinden, wordt het spel hernomen met:",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Голман БЕЛИ 1 брани шут и лопта се откотрља преко гол-аут линије. Одмах након тога огласи се завршни сигнал. Судије увиде да је утакмица завршена пет минута раније. Будући да су играчи још увек на игралишту, игра се наставља?",
                    QuestionNumber = "2.1",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Goalkeeper throw for WHITE team",
                            PhraseNl = "Een uitworp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Голмановим бацањем за БЕЛУ екипу",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team",
                            PhraseNl = "Een vrije worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободним бацањем за БЕЛУ екипу",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Without whistle signal",
                            PhraseNl = "Zonder fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Без знака пиштаљком",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "After whistle signal",
                            PhraseNl = "Na fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "После знака пиштаљком",
                            AnswerNumber = "d",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "After the automatic final signal from the public clock sounds for half-time, the referee immediately realises that the first half ended 1 minute too early. Correct decision?",
                    PhraseNl =
                        "Nadat het automatisch eindsignaal van de publieke klok weerklinkt voor halftime, stelt de scheidrechter onmiddellijk vast, dat de 1e helft 1’ te vroeg werd beëindigd. Juiste beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "2.2",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Prolong the second half by 1 minute",
                            PhraseNl = "De tweede helft met 1’ verlengen",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "The 1 minute is lost and not made up for.",
                            PhraseNl = "Die 1’ is verloren en wordt niet ingehaald",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "After the half-time, first play 1 minute on the same sides as in the first half, then change ends and begin second half normally",
                            PhraseNl =
                                "Na de rustpauze eerst 1’ op dezelfde speelhelften spelen zoals in de eerste helft, dan wisselen van speelhelft en dan het normale begin van de tweede helft",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Keep players on the court and have them play the remaining minute",
                            PhraseNl = "De spelers op het speelveld houden en hun de resterende 1’ laten spelen",
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
                        "WHITE 11 takes a shot on goal. Goalkeeper BLACK 1 catches the ball – just when the final signal from the public clock sounds. The referees point out to the timekeeper that 30 seconds remain in the second half of the game. All the players are still on the playing court. How should the game be restarted?",
                    PhraseNl =
                        "WIT11 werpt naar doel. Doelman ZWART1 vangt de balnet op het ogenblik dat het eindsignaal van de publieke klok weerklinkt. De scheidsrechters maken er de tijdwaarnemer opmerkzaam op dat nog 30 sec van de 2e helft te spelen zijn. Alle spelers zijn nog op het speelveld gebleven. Hoe wordt het spel hernomen?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "2.3",
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
                            Phrase = "Goalkeeper throw for BLACK team",
                            PhraseNl = "Uitworp voor team ZWART",
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
                            Phrase = "After whistle signal",
                            PhraseNl = "Na een fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Without whistle signal",
                            PhraseNl = "Zonder fluitsignaal",
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
                        "WHITE team is going to execute a free throw after the final whistle. First WHITE 3 and then WHITE 4 leave the court to be replaced by first WHITE 5 and then WHITE 6, who enter the court. Which of the following statements are correct?",
                    PhraseNl =
                        "Team WIT gaat een vrije worp uitvoeren na het eindsignaal. Eerst WIT3 en daarna WIT4 verlaten het speloppervlak om vervangen te worden door eerst WIT5 en daarna WIT6 die het speelveld betreden. Welke van de volgende uitspraken zijn juist?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "2.4",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "The timekeeper whistles and indicates a faulty substitution of WHITE team.",
                            PhraseNl = "De tijdwaarnemer fluit en geeft een wisselfout aan van team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 4 because of a faulty substitution",
                            PhraseNl = "2-minuten uitsluiting voor WIT4 wegens wisselfout",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 6 because of a faulty substitution",
                            PhraseNl = "2-minuten uitsluiting voor WIT6 wegens wisselfout",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "There is no reason for the timekeeper to whistle.",
                            PhraseNl = "Er is geen reden voor de tijdwaarnemer om te fluiten.",
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
                            Phrase = "Free throw for BLACK team",
                            PhraseNl = "Vrije worp voor team ZWART",
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
                        "A free throw for BLACK team is taken as a direct shot on goal just before the end of the match. The automatic final signal from the public clock sounds just before the ball enters the goal. Correct decision?",
                    PhraseNl =
                        "Een vrije worp voor team ZWART wordt als een directe worp naar doel uitgevoerd, vlak voor het wedstrijdeinde. Het automatisch eindsignaal van de publieke klok weerklink vlak voor de bal de doellijn overschrijdt. Juiste beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "2.5",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "End of the match",
                            PhraseNl = "Einde van de wedstrijd",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "The free throw for BLACK team must be retaken without whistle signal.",
                            PhraseNl = "De vrije worp voor team ZWART moet hernomen worden zonder fluitsignaal.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "The free throw for BLACK team must be retaken with whistle signal.",
                            PhraseNl = "De vrije worp voor team ZWART moet hernomen worden met fluitsignaal.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c",
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
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "Shortly before the end of the match BLACK 2 receives the ball at the goal-area line of WHITE team and has a clear chance of scoring. He tries to score but is prevented by a foul. Before the ball leaves the hand of BLACK 2, the automatic final signal from the public clock sounds. Correct decision?",
                    PhraseNl =
                        "Kort voor het einde van de wedstrijd wordt ZWART2 aan de cirkel van team WIT aangespeeld en heeft hij een open doelkans. Hij probeert te scoren maar wordt onreglementair gestopt. Vooraleer de bal de hand van ZWART2 verlaat, weerklinkt het automatisch eindsignaal van de publieke klok. Juiste beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "2.6",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "End of the match",
                            PhraseNl = "Einde van de speeltijd",
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
                            Phrase = "End of the match, note in the match report",
                            PhraseNl = "Einde van de speeltijd, vermelding op het wedstrijdblad",
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
                        "Shortly before the end of the first half, a 7-metre throw for WHITE team has not yet been executed. The 7-metre throw of WHITE 9 hits the crossbar, then the back of the goalkeeper, who is standing approximately 3 metres in front of his goal, and then the ball enters the goal. The automatic final signal from the public clock sounds, when the ball is flying from the crossbar to the goalkeeper’s back. Correct decision?",
                    PhraseNl =
                        "Kort voor het einde van de eerste speelhelft moet nog een 7m-worp door team WIT uitgevoerd worden. De 7m-worp van WIT9 knalt tegen de lat, van daaruit tegen de rug van de ca. 3m voor zijn doel staande doelman en dan gaat de bal in het doel van team ZWART. Het automatisch eindfluitsignaal van de publieke klok weerklinkt op het ogenblik, dat de bal van de lat in de richting van de rug van de doelman vliegt. Juiste beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "2.7",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Goal",
                            PhraseNl = "Doelpunt",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw is to be retaken",
                            PhraseNl = "7m-worp moet hernomen worden",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Half-time break; no further decision",
                            PhraseNl = "Rustsignaal, geen verdere beslissing",
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
                        "After the end of the playing time, a 7-metre throw is still to be executed. The referees wait for the immediate result of the throw. Which referee should then end the game?",
                    PhraseNl =
                        "Na het einde van de speeltijd moet nog een 7m-worp genomen worden. De scheidsrechters wachten het onmiddellijke resultaat van die worp af. Welke scheidsrechter moet de wedstrijd beëindigen?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "2.8",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "The first named referee",
                            PhraseNl = "De eerstgenoemde scheidsrechter",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "One of the two referees",
                            PhraseNl = "Een van beiden scheidsrechters",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "The court referee",
                            PhraseNl = "De veldscheidsrechter",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "The goal-line referee",
                            PhraseNl = "De doelscheidsrechter",
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
                    Phrase = "When does the match begin?",
                    PhraseNl = "Wanneer begint de wedstrijd?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "2.9",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "When the first named referee whistles",
                            PhraseNl = "Met het fluitsignaal van de eerstgenoemde scheidsrechter",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "When the ball leaves the thrower’s hand",
                            PhraseNl = "Wanneer de bal de hand van de werper verlaat",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "When the timekeeper starts the stopwatch or the public clock",
                            PhraseNl = "Wanneer de tijdwaarnemer de chrono of de muurchrono start",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "After the whistle for the throw-off is blown by the court referee",
                            PhraseNl = "Na het fluitsignaal voor de beginworp door de veldscheidsrechter",
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
                    Phrase = "For a 7-metre throwing, who decides which goal should be used?",
                    PhraseNl = "Wie bepaalt bij het 7m-werpen, op welk doel er wordt geworpen?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "2.10",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "The team that wins the coin toss",
                            PhraseNl = "Het team dat de toss wint",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "The team that loses the coin toss",
                            PhraseNl = "Het team dat de toss verliest",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "The referees",
                            PhraseNl = "De scheidsrechters",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "The first named referee",
                            PhraseNl = "De eerst aangeduide scheidsrechter",
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
                        "A free throw for BLACK team is to be executed after the final signal. Before the execution of the free throw, WHITE 8 and WHITE 9 leave the court at the same time. They are replaced first by WHITE 10 and immediately afterwards by WHITE 11. Which of the following statements are correct?",
                    PhraseNl =
                        "Na het eindsignaal moet team ZWART nog een vrije worp uitvoeren. Vóór de uitvoering van de vrije worp, verlaten WIT8 en WIT9 gelijktijdig het speelveld. Ze worden vervangen eerst door WIT10 en onmiddellijk daarna door WIT11 in. Welke van de volgende uitspraken is correct?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "2.11",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "The timekeeper whistles and indicates to the referees that there has been a faulty substitution by WHITE team",
                            PhraseNl =
                                "De tijdwaarnemer fluit en geeft de scheidsrechters aan dat er een wisselfout van team WIT is begaan",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 10 due to faulty substitution",
                            PhraseNl = "2-minuten uitsluiting voor WIT10 wegens wisselfout",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 11 due to faulty substitution",
                            PhraseNl = "2-minuten uitsluiting voor WIT11 wegens wisselfout",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "The timekeeper must not whistle, as there is no rule violation.",
                            PhraseNl = "De tijdwaarnemer moet niet fluiten omdat er geen regelovertreding is begaan.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "WHITE 11 must return to the substitution area; either WHITE 8 or WHITE 9 may re-enter the court",
                            PhraseNl =
                                "WIT11 moet terug naar de wisselzone; WIT8 of WIT9 mogen terugkeren op het speelveld",
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
                        "Just before the end of the first half, WHITE 7 assaults BLACK 5 and destroys a clear chance of scoring. The automatic final signal sounds before the referees have time to whistle. Correct decision?",
                    PhraseNl =
                        "Vlak voor het einde van de eerste speelhelft begaat WIT7 een gewelddaad tegen ZWART5, en verstoort een duidelijke scorekans. Vooraleer de scheidsrechter kan fluiten, weerklinkt het automatisch eindsignaal. Juiste beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "2.12",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "The first half is over; no progressive punishment against WHITE 7",
                            PhraseNl = "De eerste helft is afgelopen, geen progressieve bestraffing voor WIT7",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "The first half is over; no free throw or 7-metre throw is possible",
                            PhraseNl = "De eerste helft is afgelopen, geen vrije worp of 7m-worp is mogelijk",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of WHITE 7, written report (red and blue cards shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie van WIT7, schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c",
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
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification of WHITE 7 (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie van WIT7 (rode kaart getoond door de scheidsrechters)",
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
                    Phrase = "Up until when can the referees disallow a goal which has been awarded?",
                    PhraseNl = "Tot wanneer kan de scheidsrechter een reeds toegekend doelpunt annuleren?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "2.13",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Up until the whistle for the throw-off",
                            PhraseNl = "Tot aan het fluitsignaal voor de beginworp",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Up until the final whistle",
                            PhraseNl = "Tot aan het eindsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "It must be disallowed if it was scored after the timekeeper interrupted the game or if the throw-off was taken before the interruption was noticed.",
                            PhraseNl =
                                "Het moet geannuleerd worden wanneer het doelpunt gescoord werd nadat de tijdwaarnemer het spel onderbroken heeft of indien de beginworp werd genomen vooraleer de onderbreking werd vastgesteldt hij het annuleren, zelfs als de beginworp reeds genomen is.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "It can never be disallowed.",
                            PhraseNl = "Het kan nooit geannuleerd worden.",
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
                        "The referees have just awarded a throw-in for WHITE team. At the same time the responsible team official from WHITE team requests a team time-out. Which of the following statements are correct?",
                    PhraseNl =
                        "De scheidsrechters hebben net een inworp aan team WIT toegekend. Op datzelfde ogenblik vraagt de teamverantwoordelijke van WIT een team-time-out aan. Welke van de volgende uitspraken is correct?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "2.14",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Team time-out is not possible, as the ball is out of play",
                            PhraseNl = "TTO is niet mogelijk want de bal is uit het spel",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "The timekeeper whistles, stops the clock and shows hand signal number 15.",
                            PhraseNl = "De tijdwaarnemer fluit, stopt de klok en toont het teken 15.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "The referees confirm the team time-out for WHITE team.",
                            PhraseNl = "De scheidsrechters bevestigen de TTO voor team WIT.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "The scorekeeper enters the team time-out in the score sheet.",
                            PhraseNl = "De wedstrijdsecretaris vult de TTO in op het wedstrijdformulier",
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
                    Phrase = "In which of the following situations is a time-out obligatory?",
                    PhraseNl = "In welke van de volgende situaties is een time-out verplicht?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "2.15",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "7-metre throw",
                            PhraseNl = "7m-worp",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension",
                            PhraseNl = "2-minuten uitsluiting",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "External influence",
                            PhraseNl = "Bij externe invloed",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification",
                            PhraseNl = "Diskwalificatie",
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
                        "WHITE 9 shoots on goal. Goalkeeper BLACK 12 catches the ball. At the same time the timekeeper whistles to end the game. The referees point out to the timekeeper that there is 30 seconds left of the second half. All the players have remained on the court. How should the game be restarted?",
                    PhraseNl =
                        "WIT9 werpt op doel. Doelverdediger ZWART12 stopt de bal. Op datzelfde moment fluit de tijdwaarnemer voor het einde van de wedstrijd. De scheidsrechters geven aan de tijdwaarnemer aan dat er nog 30 seconden te spelen zijn van de tweede helft . Alle spelers zijn nog op het speeloppervlak. Hoe moet het spel hernomen worden?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "2.16",
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
                            Phrase = "Goalkeeper throw for BLACK team",
                            PhraseNl = "Uitworp voor team ZWART",
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
                            Phrase = "After whistle signal",
                            PhraseNl = "Na een fluitsignaal",
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
                        "After the regular playing time has ended with the result 20:20, the game must be continued until a winner has been determined. Correct decision?",
                    PhraseNl =
                        "Na de normale speeltijd is de stand 20-20; het spel moet doorgaan tot er een winnaar is. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "2.17",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "One-minute break before overtime starts",
                            PhraseNl = "1 minuut pauze voor de verlengingen beginnen",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Five-minute break before overtime starts",
                            PhraseNl = " 5 minuten pauze voor de verlengingen beginnen",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "One-minute break at the end of the first half of overtime",
                            PhraseNl = "1 minuut pauze na het einde van de eerste helft van de verlengingen",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Five-minute break at the end of the first half of overtime",
                            PhraseNl = " 5 minuten pauze na het einde van de eerste helft van de verlengingen",
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
                    Phrase = "In which of the following situations is a time-out obligatory?",
                    PhraseNl = "In welke van de volgende situaties is een time-out verplicht?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "2.18",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension",
                            PhraseNl = "2-minuten uitsluiting",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a",
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
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Passive play",
                            PhraseNl = "Passief spel",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Faulty substitution",
                            PhraseNl = "Wisselfout",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Warning",
                            PhraseNl = "Waarschuwing",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "e"
                        },
                        new AnswerDto
                        {
                            Phrase = "Throw-in",
                            PhraseNl = "Inworp",
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
                        "Who is not allowed to participate in the 7-metre throwing, when a game is still tied after overtime?",
                    PhraseNl =
                        "Wie is niet toegelaten tot het 7-m-werpen wanneer na de verlengingen een match nog steeds niet beslist is?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "2.19",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "A player who insults the referees just after overtime has finished",
                            PhraseNl =
                                "Een speler die de scheidsrechters beledigd heeft na het einde van de verlengingen",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "The goalkeepers",
                            PhraseNl = "De doelverdedigers",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "A player whose 2-minute suspension had not expired at the end of overtime",
                            PhraseNl =
                                "Een speler wiens 2-minuten uitsluiting nog niet voorbij was op het einde van de verlengingen",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "A disqualified player",
                            PhraseNl = "Een gediskwalificeerde speler",
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
                                "A player, who has received medical care on the court and has not yet served 3 attacks from his team",
                            PhraseNl =
                                "Een speler die medische verzorging ontvangen heeft op het speelveld en die nog geen 3 aanvallen van zijn team heeft uitgezeten",
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
                        "Five seconds before the end of the game, goalkeeper WHITE 12 stops a shot. The ball hits the ceiling above the goal area. The automatic final signal sounds immediately before the throw-in is executed by BLACK team. Correct decision?",
                    PhraseNl =
                        "Een doelverdediger van WIT12 stopt een worp vijf seconden van het einde van de wedstrijd. De bal raakt aansluitend het plafond boven het doelgebied. Het automatisch eindsignaal weerklinkt onmiddellijk voor de inworp is uitgevoerd door team ZWART. Juiste beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "2.20",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Throw-in for BLACK team after whistle signal",
                            PhraseNl = "Inworp voor team ZWART na fluitsignaal",
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
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "The game is over.",
                            PhraseNl = "Einde wedstrijd",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Wait for the result of the throw-in, thereafter the game is over",
                            PhraseNl =
                                "Het resultaat van de inworp moet afgewacht worden; daarna is de wedstrijd gedaan",
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
                        "BLACK 8 has already received a warning. During a team time-out he sits on the bench and comments on the referees in an unsportsmanlike manner. Correct decision?",
                    PhraseNl =
                        "ZWART8 heeft reeds een waarschuwing gekregen. Tijdens een team time-out zit hij op de \nbank en geeft op een onsportieve manier commentaar op de scheidsrechters. Juiste Beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "2.21",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Disqualification of BLACK 8 (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie voor ZWART8 (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for BLACK 8",
                            PhraseNl = "2-minuten uitsluiting voor ZWART8",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Warning for BLACK 8",
                            PhraseNl = "Waarschuwing voor ZWART8",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "No action possible",
                            PhraseNl = "Geen sanctie mogelijk",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "BLACK team will be reduced by 1 player on the court for 2minutes from the restart of the match after the team time-out.",
                            PhraseNl =
                                "Team ZWART wordt op het speelveld met 1 speler gereduceerd gedurende 2 minuten bij de herstart van de wedstrijd na de TTO",
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
                    Phrase = "Who is entitled to participate in a tie-breaker through 7-metre throws?",
                    PhraseNl = "Wie is gerechtigd om deel te nemen aan een beslissing ronde door 7m-werpen?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "2.22",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "All players who are included in the score sheet",
                            PhraseNl = "Alle spelers die op het wedstrijdformulier vermeld zijn",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Players who have not received a disqualification",
                            PhraseNl = " Spelers, die niet gediskwalificeerd zijn",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Players who were not serving a 2-minute suspension when overtime expired",
                            PhraseNl =
                                "Spelers, die op het einde van de verlengingenspeeltijd geen 2-minutenstraf uitzitten",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Players who have received permission from the referees",
                            PhraseNl = "Spelers, die de toelating van de scheidsrechters gekregen hebben",
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
                        "A free throw has still to be executed after the automatic final signal from the public clock. BLACK 9 takes up a correct position and shoots on the goal of WHITE team. When the ball leaves the hand of BLACK 9, there is a whistle signal from the timekeeper. The ball goes into the goal, as goalkeeper WHITE 1 had no chance. The timekeeper informs the referees that WHITE 7, who was on the court in defence during the free throw, had entered the court to substitute WHITE 6, just before the free throw was executed. Correct decision?",
                    PhraseNl =
                        "Na het automatisch eindsignaal van de publieke klok, moet er nog een vrije worp uitgevoerd worden. ZWART9 staat correct opgesteld en werpt naar het doel van team WIT. Wanneer de bal de hand van ZWART9 verlaat, fluit de tijdwaarnemer. De bal gaat in het doel, omdat de doelverdediger WIT1 geen verhaal heeft. De tijdwaarnemer deelt de scheidsrechters mee dat WIT7, die in verdediging op het veld stond tijdens de vrije worp, het speelveld betrad om WIT6 te vervangen net voor de worpuitvoering. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "2.23",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 7",
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
                            Phrase = "Disqualification of WHITE 7 (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie van WIT7 (rode kaart getoond door de scheidsrechter)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Goal for BLACK team",
                            PhraseNl = "Doelpunt voor team ZWART",
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
                            Phrase = "Repetition of the free throw for BLACK team after whistle signal",
                            PhraseNl = "Herneming van de vrije worp voor team ZWART na fluitsignaal",
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
                        "The game is still tied after overtime, and the regulations require a decision through 7-metre throws. WHITE 7 was given a 2-minute suspension after nine minutes in the last overtime period. He is nominated by the responsible team official to participate in the 7-metre throwing. Correct decision?",
                    PhraseNl =
                        "Na de beide verlengingen is het resultaat van de wedstrijd nog steeds gelijk en de reglementering vereist een beslissing via 7-meter worpen. WIT7 kreeg een 2-minuten uitsluiting na 9 minuten in de laatste verlenging. Voor het nemen van de 7-meter worpen wordt hij door de ploegverantwoordelijke A als vijfde werper opgegeven. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "2.24",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "WHITE 7 is allowed to participate.",
                            PhraseNl = "Speler WIT7 mag deelnemen",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "WHITE 7 is not allowed to participate.",
                            PhraseNl = "Speler WIT7 mag niet deelnemen",
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
                    Phrase = "When is a time-out mandatory?",
                    PhraseNl = "Wanneer is een time-out verplicht?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "2.25",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "When a team official has been given a 2-minute suspension",
                            PhraseNl = "Wanneer een teamofficial een 2-minuten uitsluiting krijgt",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "When a player has been given a third 2-minute suspension",
                            PhraseNl = "Wanneer een speler een derde 2-minuten uitsluiting krijgt",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "After repeated unsportsmanlike conduct",
                            PhraseNl = "Na herhaald onsportief gedrag",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "When the referees are required to consult each other to reach a joint decision",
                            PhraseNl =
                                "Wanneer de scheidsrechters verplicht zijn om elkaar te raadplegen om een gezamenlijke beslissing te nemen",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "After a seriously unsportsmanlike conduct",
                            PhraseNl = "Na grof onsportief gedrag",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "e",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "After a yellow card shown to a team official",
                            PhraseNl = "Na een gele kaart getoond aan een team official",
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
                        "Just before the end of the first half, WHITE 7 commits an assault against BLACK 5, who thus misses a clear chance of scoring. The automatic signal from the public clock sounds before the referees have time to whistle. Correct decision?",
                    PhraseNl =
                        "Vlak voor het einde van de eerste speelhelft begaat WIT7 een gewelddaad tegen ZWART5 die hierdoor een open doelkans mist. Voor dat de scheidsrechters kunnen fluiten weerklinkt het automatisch signaal van de publieke klok. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "2.26",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "The first half is over; no further action",
                            PhraseNl = "De eerste speelhelft is voorbij; geen verdere actie meer",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of WHITE 7 without written report (red card shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie van WIT7 zonder schriftelijk verslag (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for BLACK team",
                            PhraseNl = "7-meter worp voor team ZWART",
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
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of WHITE 7, written report (red and blue cards shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie van WIT7, schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters)",
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
                                "WHITE team will be reduced by 1 player on the court for 2 minutes from the beginning of the second half.",
                            PhraseNl =
                                "Team WIT wordt met 1 speler op het veld gereduceerd gedurende 2’ bij het begin van de 2e helft",
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
                        "After the whistle signal for half-time, a free throw must still be executed. Which players can still be substituted?",
                    PhraseNl =
                        "Na het fluitsignaal voor de rustpauze moet nog een vrije worp uitgevoerd worden. Welke spelers mogen nog gewisseld worden?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "2.27",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "All players of both teams",
                            PhraseNl = "Alle spelers van beide teams",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Only players of the defending team",
                            PhraseNl = "Alleen spelers van het verdedigende team",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Only players of the attacking team",
                            PhraseNl = "Alleen spelers van het aanvallende team",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "1 player from the attacking team",
                            PhraseNl = "Enkel één speler van het werpende team",
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
                                "A court player from the defending team with a goalkeeper, if the team at the time of the final whistle play without goalkeeper",
                            PhraseNl =
                                "Een veldspeler van het verdedigende team met een doelman, als het team op het ogenblik van het eindsignaal speelde zonder doelman",
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
                        "Which positions must the players assume during the execution of a free throw after the final whistle?",
                    PhraseNl =
                        "Welke posities moeten de spelers innemen tijdens de uitvoering van een vrije worp na het eindsignaal?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "2.28",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "All teammates of the thrower must be outside the free-throw line of the opponents.",
                            PhraseNl =
                                "Alle medespelers van de werper moeten zich buiten de vrije worplijn van de tegenstrevers bevinden.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "All teammates of the thrower must be in their own half of the court.",
                            PhraseNl = "Alle medespelers van de werper moeten zich op de eigen speelhelft ophouden.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "The opponents must be 3 metres away from the thrower or at their own goal-area line.",
                            PhraseNl =
                                "De tegenstrevers moeten minstens 3 meter van de werper verwijderd zijn, of aan hun doelgebied lijn staan.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "All teammates of the thrower must be at least 3 metres away from the thrower.",
                            PhraseNl = "Alle medespelers van de werper moeten minstens 3 meter van de werper staan.",
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
                                "All teammates of the thrower may stay together with the thrower at the free-throw line of the opponents.",
                            PhraseNl =
                                "Alle medespelers van de werper mogen samen bij de werper aan de vrij worplijn van de tegenstrevers staan.",
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
                        "WHITE 7 passes the ball to WHITE 8. At this moment, the timekeeper whistles for a team time-out for WHITE team. The referees and players do not hear this signal, and WHITE 8 passes the ball to WHITE 10, who has a clear chance of scoring. WHITE 10 is illegitimately stopped by BLACK 5. The referees give a 7-metre throw for WHITE team and a 2-minute suspension for BLACK 5. Now, first the referees perceive that the timekeeper has already whistled because of the team time-out request. Correct decision?",
                    PhraseNl =
                        "WIT7 past de bal naar WIT8. Op dat ogenblik geeft de tijdwaarnemer het fluitsignaal voor een TTO voor team WIT. De scheidsrechters en de spelers horen dit signaal niet en WIT8 speelt de bal naar WIT10, die een vrije doelkans heeft. WIT10 wordt door ZWART5 tegen de spelregels in gestopt. De scheidsrechters beslissen op 7m-worp voor team WIT en een 2-minuten uitsluiting voor ZWART5. Nu pas merken de scheidsrechters op, dat de tijdwaarnemer het signaal voor de TTO gegeven hadden. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "2.29",
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
                            AnswerNumber = "a"
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
                            Phrase = "Team time-out for WHITE team",
                            PhraseNl = "TTO voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c",
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
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "Whistle signal for restart",
                            PhraseNl = "Fluitsignaal om terug te starten",
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
                                "Restart with a free throw for WHITE team at the position of WHITE 7 at the time of the whistle from the timekeeper",
                            PhraseNl =
                                "Spelhervatting met vrije worp voor team WIT op de plaats waarop zich WIT7 bevond op het ogenblik van de onderbreking (door de tijdwaarnemer)",
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
                        "The whistle signal ending the first half has come 1 minute too soon. At the time of the whistle signal, neither of the teams were in possession of the ball, and there was no violation of any rule. The ball was on the floor in the playing area. Both teams are still on the court. Correct decision?",
                    PhraseNl =
                        "Het fluitsignaal om de eerste helft te beëindigen, komt 1 minuut te vroeg. Op het moment van het fluitsignaal had geen enkel team balbezit en er was ook geen spelregelovertreding. De bal lag op de grond op het speelveld. Beide teams zijn nog op het speelveld. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "2.30",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "The 1 minute is not played.",
                            PhraseNl = "De 1 minuut wordt niet gespeeld.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "The 1 minute is played before the half-time break.",
                            PhraseNl = "De 1 minuut wordt gespeeld voor de pauze.",
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
                                "The 1 minute is played after the half-time break before the start of the second half.",
                            PhraseNl = "De minuut wordt gespeeld na de pauze, voor het begin van de tweede helft.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "The 1 minute is added to the second half.",
                            PhraseNl = "De minuut wordt toegevoegd aan de tweede helft.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "It is decided through a coin toss which team gets the ball when the 1 minute is played.",
                            PhraseNl = "De toss beslist welk team de bal krijgt wanneer de minuut wordt gespeeld.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "e"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "The team that last were in possession of the ball get the ball when the game starts again.",
                            PhraseNl =
                                "Het team dat het laatst in balbezit was, krijgt balbezit bij het hernemen van het spel.",
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
                        "The first half of the game has been stopped 1 minute too soon. There has been no violation of any rule, and the ball was in the air over the goal area. The goalkeeper catches the ball after the whistle signal. Both teams are still on the court. Correct decision?",
                    PhraseNl =
                        "De eerste helft van de wedstrijd werd 1 minuut te vroeg gestopt. Er was geen spelregelovertreding en de bal was in de lucht, boven het doelgebied. De doelverdediger vangt de bal na het fluitsignaal. Beide teams bevinden zich nog op het veld. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "2.31",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "The 1 minute is not played.",
                            PhraseNl = "De resterende minuut wordt niet gespeeld.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "The 1 minute is played before the half-time break.",
                            PhraseNl = "De resterende minuut wordt gespeeld voor de pauze.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",,
                            PhraseSrb = "",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "The 1 minute is played after the half-time break before the start of the second half.",
                            PhraseNl =
                                "De resterende minuut wordt gespeeld na de pauze voor de start van de tweede helft.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "The 1 minute is added to the second half.",
                            PhraseNl = "De resterende minuut wordt toegevoegd aan de tweede helft.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "The team that last were in possession of the ball get the ball when the game starts again.",
                            PhraseNl =
                                "Het team dat als laatste in balbezit was, krijgt de bal opnieuw bij het hernemen van het spel.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "e",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "The game is restarted with a goalkeeper throw.",
                            PhraseNl = "Het spel wordt hernomen met een uitworp.",
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
                        "The first half of the match has been stopped 1 minute too soon. There has been no violation of any rule, and the ball was in the air over the goal area. After the whistle signal, the ball went over the outer goal line. Both teams are still on the court. Correct decision?",
                    PhraseNl =
                        "De eerste helft van de wedstrijd werd 1 minuut te vroeg gestopt. Er was geen spelregelovertreding en de bal was in de lucht, boven het doelgebied. Na het fluitsignaal ging de bal over de buitendoellijn. Beide teams bevinden zich nog op het veld. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "2.32",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "The 1 minute is not played.",
                            PhraseNl = "De resterende minuut wordt niet gespeeld.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "The 1 minute is played before the half-time break.",
                            PhraseNl = "De resterende minuut wordt gespeeld voor de pauze.",
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
                                "The 1 minute is played after the half-time break before the start of the second half.",
                            PhraseNl =
                                "De resterende minuut wordt gespeeld na de pauze voor de start van de tweede helft.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "The 1 minute is added to the second half.",
                            PhraseNl = "De resterende minuut wordt toegevoegd aan de tweede helft.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "The team that last were in possession of the ball get the ball when the game starts again.",
                            PhraseNl =
                                "Het team dat als laatste in balbezit was, krijgt de bal opnieuw bij het hernemen van het spel.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            AnswerNumber = "e",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "The game is restarted with a goalkeeper throw.",
                            PhraseNl = "Het spel wordt hernomen met een uitworp.",
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
                        "WHITE team have scored a goal, and BLACK team want to take the throw-off quickly. Therefore, BLACK 5 quickly dribbles the ball in the direction of the centre line. He runs past WHITE 3, who uses an open hand to play the ball away from BLACK 5, so that the ball hits the foot of BLACK 5 and rolls far away over the centre line into the half of WHITE team. Correct decision?",
                    PhraseNl =
                        "Team WIT heeft gescoord. Team ZWART wil een snelle beginworp nemen. Daarom dribbelt ZWART5 de bal snel in de richting van de middenlijn. Wanneer hij zo voorbij WIT3 komt, gebruikt deze een open hand om de bal weg te spelen van ZWART5, zodat de bal de voet van ZWART5 raakt en ver weg over de middenlijn in de speelveldhelft van team WIT terechtkomt. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "2.33",
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
                            Phrase = "Throw-off for BLACK team",
                            PhraseNl = "Beginworp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Progressive punishment against WHITE 3",
                            PhraseNl = "Progressieve bestraffing voor WIT3",
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
                            Phrase = "Direct 2-minute suspension for WHITE 3",
                            PhraseNl = "Directe 2-minuten uitsluiting voor WIT3",
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
                    Phrase = "In which situations is a time-out <b><u>NOT</u></b> obligatory?",
                    PhraseNl = "In welke situaties is een time-out <b><u>NIET</u></b> verplicht?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "2.34",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "The ball goes far away from the court",
                            PhraseNl = "De bal vliegt ver buiten het speelveld",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "The timekeeper whistles",
                            PhraseNl = "Wanneer de tijdwaarnemer fluit",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "A player seems injured",
                            PhraseNl = "Een speler lijkt gekwetst te zijn",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "When the referees indicate different directions, when making a decision",
                            PhraseNl = "Wanneer de scheidsrechters bij een beslissing elk een andere richting aangeven",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "A court player’s substitution with a goalkeeper to execute a goalkeeper throw",
                            PhraseNl = "De vervanging van een veldspeler door een doelman om de uitworp uit te voeren",
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
                    Phrase = "Who may request a team time-out?",
                    PhraseNl = "Wie mag een team-time-out aanvragen?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "2.35",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "One of the team officials",
                            PhraseNl = "Een van de team officials",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "A player",
                            PhraseNl = "Een speler",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Only the responsible team official",
                            PhraseNl = "Alleen de teamverantwoordelijke",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "The team captain",
                            PhraseNl = "De team kapitein",
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
                    Phrase = "Which of the following statements regarding team time-outs are correct?",
                    PhraseNl = "Welke van de volgende uitspraken betreffende team-time-outs zijn juist?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "2.36",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "The team time-out can only be requested by the responsible team official.",
                            PhraseNl = "De team time-out kan enkel aangevraagd worden door de teamverantwoordelijke",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "If a team time-out is requested while the opponents are in possession of the ball, the timekeeper must give the green card back to the team official.",
                            PhraseNl =
                                "Als een team-time-out is aangevraagd wanneer de tegenstander in balbezit is, moet de tijdwaarnemer de “groene kaart” teruggeven aan de teamofficial.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "The one-minute period for the team time-out starts when the timekeeper whistles.",
                            PhraseNl =
                                "De 1-minuut periode voor de team time-out begint wanneer de tijdwaarnemer fluit.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Rule violations during a team time-out have the same consequences as during the playing time.",
                            PhraseNl =
                                "Spelregelovertredingen gedurende een team time-out hebben dezelfde gevolgen als tijdens de speeltijd.",
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
                                "Following the team time-out, the game is always restarted with a throw for the team that requested the team time-out.",
                            PhraseNl =
                                "Na een team time-out, wordt het spel steeds hernomen met een “worp” voor het team dat de team time-out aanvroeg",
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
                        "WHITE team is in possession of the ball. Official C from BLACK team requests a team time-out by placing the green card on the table in front of the timekeeper. Correct decision?",
                    PhraseNl =
                        "Ploeg WIT is in balbezit. Een teamofficial C van team ZWART vraagt een team time-out aan door de groene kaart te plaatsen op de tafel voor de tijdwaarnemer. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "2.37",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "The green card is put up on the table.",
                            PhraseNl = "De groene kaart wordt op de wedstrijdtafel geplaatst.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "The timekeeper whistles as soon as BLACK team gain possession of the ball.",
                            PhraseNl = "De tijdwaarnemer fluit zodra team ZWART in balbezit komt.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "The timekeeper gives the green card back to the official.",
                            PhraseNl = "De tijdwaarnemer geeft de groene kaart terug aan de official.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Only the responsible team official can request a team time-out.",
                            PhraseNl = "Enkel de teamverantwoordelijke kan een team time-out aanvragen.",
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
                        "BLACK 3 tries to shoot on goal. However, the ball comes to rest on the floor in the goal area without having been touched by any other player. At the same time, the responsible team official of BLACK team requests a team time-out. Correct decision?",
                    PhraseNl =
                        "ZWART3 tracht naar doel te werpen. Helaas komt de bal tot stilstand in het doelgebied zonder aangeraakt te zijn door een andere speler. Op dat ogenblik vraagt de teamverantwoordelijke van team ZWART een TTO. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "2.38",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "The timekeeper whistles, stops the clock at the same time, and indicates the team time-out for BLACK team to the referees.",
                            PhraseNl =
                                "De tijdwaarnemer fluit, stopt gelijktijdig de chrono en wijst de scheidsrechters het TTO voor team ZWART aan.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "The timekeeper gives the green card back to the responsible team official from BLACK team.",
                            PhraseNl =
                                "De tijdwaarnemer geeft de groene kaart terug aan de teamverantwoordelijke van team ZWART.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "The game is restarted with a free throw for BLACK team.",
                            PhraseNl = "Het spel wordt hernomen met een vrije worp voor team ZWART.",
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
                            AnswerNumber = "d",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "Goalkeeper WHITE 1 passes the ball to WHITE 8, who is alone with goalkeeper BLACK 12 near the goal area of BLACK team. Just before the ball gets to WHITE 8, there is a whistle signal from the timekeeper: official A from WHITE team has requested a team time-out. How should the game be continued?",
                    PhraseNl =
                        "Doelverdediger WIT1 werpt de bal naar WIT8 dewelke zich alleen met doelverdediger ZWART12 aan het doelgebied van team ZWART bevindt. Net voordat de bal WIT8 bereikt fluit de tijdwaarnemer: de trainer van team WIT heeft een team time-out aangevraagd. Hoe moet het spel verdergezet worden?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "2.39",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team outside the goal area of WHITE team",
                            PhraseNl = "Vrije worp voor team WIT buiten het doelgebied van team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team at the substitution area of WHITE team",
                            PhraseNl = "Vrije worp voor team WIT aan de wisselzone van team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for WHITE team",
                            PhraseNl = "7-meter worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team at the free-throw line of BLACK team",
                            PhraseNl = "Vrije worp voor team WIT aan de vrije worplijn van team ZWART",
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
                        "WHITE 4 blocks a shot from BLACK 11. The ball touches the ceiling above the goal area. Immediately after this, official A from BLACK team puts the green card on the table in front of the timekeeper. Correct decision?",
                    PhraseNl =
                        "WIT4 blokt een worp van ZWART11 af. De bal raakt de zoldering boven het doelgebied. Onmiddellijk daarna legt de trainer van team ZWART de groene kaart op de wedstrijdtafel voor de tijdwaarnemer. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "2.40",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "BLACK team immediately receive a team time-out.",
                            PhraseNl = "Team ZWART krijgt onmiddellijk een team time-out.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "BLACK team do not receive a team time-out because the ball touched the ceiling.",
                            PhraseNl =
                                "Team ZWART krijgt geen team time-out omdat de bal de zoldering boven het doelgebied geraakt heeft.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "BLACK team do not receive a team time-out because WHITE team have possession of the ball when the game is restarted.",
                            PhraseNl =
                                "Team ZWART krijgt geen team time-out omdat team WIT de bal weer in het spel brengt.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "BLACK team receive a team time-out, but only after the game has restarted.",
                            PhraseNl = " Team ZWART bekomt een team time-out, maar enkel nadat het spel hernomen is.",
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
                        "WHITE team is in possession of the ball and request a team time-out. Because of the noise, the referees do not hear the whistle signal of the timekeeper. Only after about ten seconds, when BLACK team are in possession of the ball, the referees hear the whistle. Correct decision?",
                    PhraseNl =
                        "Team WIT is in balbezit en vraagt een team time-out aan. Door het lawaai horen de scheidsrechters het fluitsignaal van de tijdwaarnemer niet. Pas na 10 seconden, wanneer team ZWART in balbezit is, horen de scheidsrechters het fluitsignaal. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "2.41",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Team time-out is awarded",
                            PhraseNl = "Team time-out wordt toegekend",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "The game is restarted with a free throw for BLACK team.",
                            PhraseNl = "Het spel wordt hernomen met een vrije worp voor team ZWART.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Team time-out is not awarded",
                            PhraseNl = "Team time-out wordt niet toegekend",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "The game is restarted with a free throw for WHITE team.",
                            PhraseNl = "Het spel wordt hernomen met een vrije worp voor team WIT.",
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
                        "At 78:00 player WHITE 7 receives a 2-minute suspension. The match ends in a draw, and the regulations require a decision through 7-metre throws. WHITE 7 is nominated by the responsible team official to participate in the 7-metre throwing. WHITE 7 executes the 7-metre throw and scores a goal. Correct decision?",
                    PhraseNl =
                        "Op 78:00 krijgt speler WIT7 een 2-minuten uitsluiting. De wedstrijd eindigt in een gelijk spel en de reglementering vereist een beslissing via 7m-werpen. WIT7 is door zijn verantwoordelijke team official aangeduid om deel te nemen aan dit 7m-werpen. WIT7 voert een 7m-worp uit en scoort een doelpunt. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "2.42",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Goal is valid, WHITE 7 is allowed to participate",
                            PhraseNl = "Doelpunt is geldig WIT7 is toegelaten om deel te nemen",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Goal is not valid, WHITE 7 is not allowed to participate",
                            PhraseNl = "Doelpunt is niet geldig, WIT7 is niet toegelaten om deel te nemen",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "The throw is considered as failed",
                            PhraseNl = "De worp wordt beschouwd als gemist",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification for WHITE 7",
                            PhraseNl = "Diskwalificatie van WIT7",
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
                        "At 55:00 the responsible team official from WHITE team requests a team time-out, which is the second in the match. At 59:00 the same responsible team official requests the third team time-out. Correct decision?",
                    PhraseNl =
                        "Op 55:00 vraagt de verantwoordelijke team official van team WIT een team time-out, welke de tweede is in deze wedstrijd. Op 59:00 vraagt dezelfde teamverantwoordelijke zijn 3e team time-out. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "2.43",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Team time-out is possible",
                            PhraseNl = "Team-time-out is mogelijk",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Team time-out is not possible",
                            PhraseNl = "Team-time-out is niet mogelijk",
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
                        "WHITE team is in attack. Official A from WHITE team wishes to request a team time-out and goes to the table to place the green card in front of the timekeeper. The green card is placed on the table in front of the timekeeper. At the same time, WHITE 4 takes a shot on goal and manages to score. The timekeeper whistles for the team time-out just after the ball passes the goal line of BLACK team. What is the correct decision?",
                    PhraseNl =
                        "Team WIT is in aanval. Official A van team WIT wil een team time-out aanvragen en gaat naar de wedstrijdtafel om de groene kaart voor de tijdwaarnemer te plaatsen. De groene kaart is op de tafel geplaatst voor de tijdwaarnemer. Op hetzelfde ogenblik werpt WIT4 naar doel en kan scoren. De tijdwaarnemer fluit voor de team time-out net nadat de bal de doellijn van team ZWART heeft overschreden. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "2.44",
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
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "The goal is not valid, because WHITE team have requested a team time-out.",
                            PhraseNl =
                                "Het doelpunt is niet geldig, omdat team WIT een team-time-out heeft aangevraagd.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Team time-out for WHITE team",
                            PhraseNl = "Team time-out voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "No team time-out for WHITE team, because they are no longer in possession of the ball",
                            PhraseNl = "Geen team-time-out voor team WIT omdat ze niet meer in balbezit zijn",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "The green card must be returned to the team.",
                            PhraseNl = "De groene kaart moet teruggegeven worden aan het team",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "e",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Throw-off for BLACK team",
                            PhraseNl = "Beginworp voor team ZWART",
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
                        "WHITE team had their second team time-out at 55:10. At 59:25, official A from WHITE team wants to request a third team time-out for his team and places the green card on the table in front of the timekeeper. WHITE team are in possession of the ball. The timekeeper whistles and stops the clock. He shows a team time-out for WHITE team. What is the correct decision?",
                    PhraseNl =
                        "Team WIT had haar tweede team time-out op 55:10. Op 59:25 wil official A van team WIT een derde team time-out aanvragen voor zijn team en plaatst hij de groene kaart op de wedstrijdtafel voor de tijdwaarnemer. Team WIT is in balbezit. De tijdwaarnemer fluit en stopt de klok. Hij geeft een team time-out voor team WIT aan. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "2.45",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Team time-out for WHITE team",
                            PhraseNl = "TTO voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "No team time-out granted",
                            PhraseNl = "Geen TTO toegestaan",
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
                            Phrase = "The match is restarted with a free throw for WHITE team.",
                            PhraseNl = "De wedstrijd wordt hernomen met een vrije worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "The match is restarted with a free throw for BLACK team.",
                            PhraseNl = "De wedstrijd wordt hernomen met een vrije worp voor team ZWART",
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
                        "WHITE team want to request a team time-out. Official A from WHITE team places the green card on the table in front of the timekeeper. At the same time, WHITE 9 takes a shot on the goal of BLACK team. The timekeeper whistles while the ball is in the air. Shortly after the whistle, goalkeeper BLACK 12 catches the ball. What is the correct decision?",
                    PhraseNl =
                        "Team WIT wil een TTO aanvragen. Official A van team WIT plaatst de groene kaart op de wedstrijdtafel voor de tijdwaarnemer. Op hetzelfde ogenblik, werpt WIT9 naar het doel van team ZWART. De tijdwaarnemer fluit terwijl de bal in de lucht is. Kort na het fluitsignaal vangt de doelman van team ZWART de bal. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "2.46",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "No team time-out possible, because WHITE team are not in possession of the ball",
                            PhraseNl = "Geen TTO mogelijk, omdat team WIT niet in balbezit is",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Team time-out for WHITE team",
                            PhraseNl = "TTO voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "The green card is returned to WHITE team.",
                            PhraseNl = "De groene kaart wordt teruggegeven aan team WIT.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "The match is restarted with a goalkeeper throw for BLACK team.",
                            PhraseNl = "De wedstrijd wordt hernomen met een uitworp voor team ZWART.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "The match is restarted with a free throw for WHITE team.",
                            PhraseNl = "De wedstrijd wordt hernomen met een vrije worp voor team WIT.",
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
                        "WHITE team want to request a team time-out. Official A from WHITE team places the green card on the table in front of the timekeeper. Before the timekeeper whistles for the team time-out, WHITE 9 takes a shot on goal. The shot is blocked by goalkeeper BLACK 12, and the timekeeper whistles, while the ball is rolling inside the goal area. What is the correct decision?",
                    PhraseNl =
                        "Team WIT wil een TTO aanvragen. Official A van team WIT plaatst de groene kaart op de wedstrijdtafel voor de tijdwaarnemer. Vooraleer de tijdwaarnemer kan fluiten voor de TTO, werpt WIT9 naar doel. De worp wordt geblokt door doelman ZWART12 en de tijdwaarnemer fluit, op het ogenblik dat de bal rolt in het doelgebied. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "2.47",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "No team time-out possible because WHITE team are not in possession of the ball.",
                            PhraseNl = "Geen TTO mogelijk, omdat team WIT niet in balbezit is.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Team time-out for WHITE team.",
                            PhraseNl = "TTO voor team WIT.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "The green card is returned to WHITE team.",
                            PhraseNl = "De groene kaart wordt teruggegeven aan team WIT.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "The match is restarted with a goalkeeper throw for BLACK team.",
                            PhraseNl = "De wedstrijd wordt hernomen met een uitworp voor team ZWART.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "The match is restarted with a free throw for WHITE team.",
                            PhraseNl = "De wedstrijd wordt hernomen met een vrije worp voor team WIT.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "e"
                        },
                        new AnswerDto
                        {
                            Phrase = "The match is restarted with a free throw for BLACK team.",
                            PhraseNl = "De wedstrijd wordt hernomen met een vrije worp voor team ZWART.",
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
                        "WHITE team want to request a team time-out. Official A from WHITE team places the green card on the table in front of the timekeeper. Before the timekeeper whistles for the team time-out, WHITE 9 takes a shot on goal. The shot is blocked by goalkeeper BLACK 12, and the timekeeper whistles, while the ball, after the save, is in the air above the goal area. What is the correct decision?",
                    PhraseNl =
                        "Team WIT wil een TTO aanvragen. Official A van team WIT plaatst de groene kaart op de wedstrijdtafel voor de tijdwaarnemer. Vooraleer de tijdwaarnemer kan fluiten voor de TTO, werpt WIT9 naar doel. De worp wordt gestopt door doelman ZWART12 en de tijdwaarnemer fluit op het ogenblik dat de bal, na de save, in de lucht is boven het doelgebied. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "2.48",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "No team time-out possible because WHITE team are not in possession of the ball.",
                            PhraseNl = "Geen TTO mogelijk, omdat team WIT niet in balbezit is.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Team time-out for WHITE team.",
                            PhraseNl = "TTO voor team WIT.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "The green card is returned to WHITE team.",
                            PhraseNl = "De groene kaart wordt teruggegeven aan team WIT.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "The match is restarted with a goalkeeper throw for BLACK team.",
                            PhraseNl = "De wedstrijd wordt hernomen met een uitworp voor team ZWART.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "The match is restarted with a free throw for WHITE team.",
                            PhraseNl = "De wedstrijd wordt hernomen met een vrije worp voor team WIT.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "e",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "The match is restarted with a free throw for BLACK team.",
                            PhraseNl = "De wedstrijd wordt hernomen met een vrije worp voor team ZWART.",
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
                        "WHITE team want to request a team time-out. Official A from WHITE team places the green card on the table in front of the timekeeper. Before the timekeeper whistles for the team time-out, WHITE 11 commits an offensive foul. The timekeeper whistles for the team time-out just before the referee whistles for the offensive foul. What is the correct decision?",
                    PhraseNl =
                        "Team WIT wil een TTO aanvragen. Official A van team WIT plaatst de groene kaart op de wedstrijdtafel voor de tijdwaarnemer. Vooraleer de tijdwaarnemer kan fluiten voor de TTO, begaat WIT11 een aanvallende fout. De tijdwaarnemer fluit voor de TTO, net voordat de scheidsrechters fluiten voor de aanvallende fout. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "2.49",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "The referees decide that there shall be no team time-out, because the offensive foul had been committed before the timekeeper whistled for the team time-out.",
                            PhraseNl =
                                "De scheidsrechters beslissen dat er geen TTO is, omdat de aanvallende fout begaan werd vooraleer de tijdwaarnemer floot voor de TTO.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Team time-out for WHITE team",
                            PhraseNl = "TTO voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "The green card is returned to WHITE team.",
                            PhraseNl = "De groene kaart wordt teruggegeven aan team WIT.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "The match is restarted with a free throw for BLACK team.",
                            PhraseNl = "De wedstrijd wordt hernomen met een vrije worp voor team ZWART.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "The match is restarted with a free throw for WHITE team.",
                            PhraseNl = "De wedstrijd wordt hernomen met een vrije worp voor team WIT.",
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
                        "Electronic team time-out is used in the match. WHITE team had their second team time-out at 55:10. At 59:35, official A from WHITE team wants to request a third team time-out for his team and activates the team time-out buzzer. The ball is in play and WHITE team is in possession of the ball. The signal from the public clock sounds and the clock is stopped. What is the correct decision?",
                    PhraseNl =
                        "Elektronische team time-out wordt gebruikt in de wedstrijd. Team WIT heeft hun tweede TTO op 55:10. Op 59:35, wil official A van team WIT een derde TTO aanvragen voor zijn team en activeert de TTO-buzzer. De bal is in het spel en team WIT is in balbezit. Het signaal van de muurklok weerklinkt en de tijd is gestopt . Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "2.50",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Team time-out for WHITE team.",
                            PhraseNl = "TTO voor team WIT.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "No team time-out granted.",
                            PhraseNl = "TTO wordt niet toegekend.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Progressive punishment for official A from WHITE team.",
                            PhraseNl = "Progressieve bestraffing voor official A van team WIT.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "The match is restarted with a free throw for WHITE team.",
                            PhraseNl = "De wedstrijd wordt hernomen met een vrije worp voor team WIT.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "The match is restarted with a free throw for BLACK team.",
                            PhraseNl = "De wedstrijd wordt hernomen met een vrije worp voor team ZWART.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "e",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "BLACK team can choose between free throw and 7-metre throw.",
                            PhraseNl = "Team ZWART kan kiezen tussen een vrije worp en een 7m-worp.",
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
                        "Electronic team time-out is used in the match. WHITE team is in possession of the ball. At 58:40, WHITE 7 commits an offensive foul. Before the referees were able to whistle for the offensive foul, the signal from the public clock sounds because Official A from WHITE team activated the team time-out buzzer to request a team time-out. Immediately thereafter the referees whistle offensive foul against WHITE 7. What is the correct decision?",
                    PhraseNl =
                        "Elektronische team time-out wordt gebruikt in de wedstrijd. Team WIT is in balbezit. Op 58:40, begaat WIT7 een aanvallende fout. Vooraleer de scheidsrechters kunnen fluiten voor de aanvallende fout, weerklinkt het signaal van de officiële klok omdat official A van team WIT de TTO-buzzer heeft geactiveerd om een TTO aan te vragen. Onmiddellijk daarna fluiten de scheidsrechters aanvallende fout tegen WIT7. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "2.51",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "Team time-out is not possible because WHITE team is no longer in possession of the ball.",
                            PhraseNl = "TTO is niet mogelijk omdat team WIT niet langer in balbezit is.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Team time-out for WHITE team.",
                            PhraseNl = "TTO voor team WIT.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "WHITE team will lose one team time-out.",
                            PhraseNl = "Team WIT verliest één TTO.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "The match is restarted with a free throw for BLACK team.",
                            PhraseNl = "De wedstrijd wordt hernomen met een vrije worp voor team ZWART.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "The match is restarted with a free throw for WHITE team.",
                            PhraseNl = "De wedstrijd wordt hernomen met een vrije worp voor team WIT.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "e"
                        },
                        new AnswerDto
                        {
                            Phrase = "The match is restarted with a 7-metre throw for BLACK team.",
                            PhraseNl = "De wedstrijd wordt hernomen met een 7m-worp voor team ZWART.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "f"
                        },
                        new AnswerDto
                        {
                            Phrase = "BLACK team can choose between free throw and 7-metre throw.",
                            PhraseNl = "Team ZWART kan kiezen tussen een vrije worp en een 7m-worp.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "g"
                        },
                        new AnswerDto
                        {
                            Phrase = "Progressive punishment against Official A from WHITE team.",
                            PhraseNl = "Progressieve bestraffing voor official A van team WIT.",
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
                        "Electronic team time-out is used in the match. At 29:50 in the first half, WHITE 9 takes a shot on goal. The shot is blocked by goalkeeper BLACK 12, and after the save, the ball is in the air above the goal area. At that moment,the signal from the public clock sounds because Official A from BLACK team has activated the buzzer to request a team time-out. What is the correct decision?",
                    PhraseNl =
                        "Elektronische team time-out wordt gebruikt in de wedstrijd. Op 29:50 in de eerste helft, werpt WIT9 naar doel. De worp wordt door doelman ZWART12 afgeweert, en na de save, is de bal in de lucht boven het doelgebied. Op dat ogenblik weerklinkt het signaal van de officiële klok omdat official A van team ZWART de TTO-buzzer heeft geactiveerd om een TTO aan te vragen. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "2.52",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "No team time-out possible because BLACK team are not in possession of the ball.",
                            PhraseNl = "TTO is niet mogelijk omdat team ZWART niet langer in balbezit is.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Team time-out for BLACK team.",
                            PhraseNl = "TTO voor team ZWART.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "BLACK team will lose one team time-out.",
                            PhraseNl = "Team ZWART verliest één TTO.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "The match is restarted with a goalkeeper throw for BLACK team.",
                            PhraseNl = "De wedstrijd wordt hernomen met een uitworp voor team ZWART.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "The match is restarted with a free throw for WHITE team.",
                            PhraseNl = "De wedstrijd wordt hernomen met een vrije worp voor team WIT.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "e"
                        },
                        new AnswerDto
                        {
                            Phrase = "The match is restarted with a free throw for BLACK team.",
                            PhraseNl = "De wedstrijd wordt hernomen met een vrije worp voor team ZWART.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "f"
                        },
                        new AnswerDto
                        {
                            Phrase = "WHITE team can choose between a 7-metre throw and free throw.",
                            PhraseNl = "Team WIT kan kiezen tussen een vrije worp en een 7m-worp.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "g"
                        },
                        new AnswerDto
                        {
                            Phrase = "The match is restarted with a 7-metre throw for WHITE team.",
                            PhraseNl = "De wedstrijd wordt hernomen met een 7m-worp voor team WIT.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            AnswerNumber = "h",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Progressive punishment against Official A from BLACK team.",
                            PhraseNl = "Progressieve bestraffing voor official A van team ZWART.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "i",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "BLACK team is in attack. The referees show the forewarning signal. After two passes a whistle sounds from the delegate because Official A from BLACK team has requested a team time-out. Neither the referees nor the players hear the whistle, and the game continues. The fourth pass from BLACK team goes to the wing player who has a clear chance of scoring. The wing player jumps to take a shot on goal. By doing so he is pushed by WHITE 4 and he partly loses body control. The goalkeeper saves the shot. Only at that point the referees and the players become aware that the delegate interrupted the match because of the team time-out request. What is the correct decision?",
                    PhraseNl =
                        "Team ZWART is in aanval. De scheidsrechters tonen het waarschuwingsteken passief. Na twee passes weerklinkt een fluitsignaal van de waarnemer omdat official A van team ZWART een TTO heeft aangevraagd. Noch de scheidsrechters, noch de spelers horen het fluitsignaal en het spel gaat gewoon door. De vierde pass van team ZWART gaat naar de hoekspeler die een open doelkans heeft. De hoekspeler springt om een worp op doel te nemen. Terwijl hij dit doet wordt hij geduwd door WIT4 en hij verliest gedeeltelijk zijn lichaamscontrole. De doelman vangt de bal. Pas op dat punt beseffen de scheidsrechters en de spelers dat de waarnemer de wedstrijd heeft onderbroken omwille van de TTO aanvraag. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "2.53",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Team time-out for BLACK team.",
                            PhraseNl = "TTO voor team ZWART.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "The match is restarted with a free throw for BLACK team.",
                            PhraseNl = "De wedstrijd wordt hernomen met een vrije worp voor team ZWART.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "The match is restarted with a 7-metre throw for BLACK team.",
                            PhraseNl = "De wedstrijd wordt hernomen met een 7m-worp voor team ZWART.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 4.",
                            PhraseNl = "2-minuten uitsluiting voor WIT4.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "No punishment.",
                            PhraseNl = "Geen bestraffing.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "e"
                        },
                        new AnswerDto
                        {
                            Phrase = "The forewarning signal is still valid - BLACK team has completed two passes.",
                            PhraseNl =
                                "Het waarschuwingsteken passief is nog steeds geldig – team ZWART heeft 2 passes voltooid.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "f",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "The forewarning signal is still valid – BLACK team has completed four passes.",
                            PhraseNl =
                                "Het waarschuwingsteken passief is nog steeds geldig – team ZWART heeft 4 passes voltooid.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "g"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "The forewarning signal is no longer valid because WHITE 4 is punished with a 2-minute suspension.",
                            PhraseNl =
                                "Het waarschuwingsteken passief is niet langer geldig omdat WIT4 bestraft is met een 2-minuten uitsluiting.",
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
                        "WHITE team shoots at goal. Goalkeeper BLACK 1 saves the shot. The ball is bouncing inside the goal area when Team Official A from WHITE team requests a team time-out by putting the green card in front of the timekeeper. The timekeeper whistles when the ball is still bouncing inside the goal area, but the ball is very close to WHITE 13 who is completely alone just outside the goal area. What is the correct decision?",
                    PhraseNl =
                        "Team WIT werpt naar doel. Doelman ZWART1 weert de bal af. De bal botst binnen het doelgebied wanneer team official A van team WIT een TTO aanvraagt door de groene kaart op tafel te leggen voor de tijdwaarnemer. De tijdwaarnemer fluit op het ogenblik dat de bal nog aan het botsen is binnen het doelgebied, maar de bal is zeer kort bij WIT13 die volledig alleen staat net buiten het doelgebied. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "2.54",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Team time-out for WHITE team.",
                            PhraseNl = "TTO voor team WIT.",
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
                                "No team time-out possible, and the green card is handed back to Team Official A from WHITE team.",
                            PhraseNl =
                                "Geen TTO mogelijk en de groene kaart wordt teruggegeven aan team official A van team WIT.",
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
                            AnswerNumber = "c",
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
                            AnswerNumber = "e"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for WHITE team.",
                            PhraseNl = "7m-worp voor team WIT.",
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
