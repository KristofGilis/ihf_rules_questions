﻿using IHF.Rules.Questions.Infrastructure.DataSeed.Models;

namespace IHF.Rules.Questions.Infrastructure.DataSeed;

public static partial class Rules
{
    public static RuleDto GetRule16()
    {
        return new RuleDto
        {
            Name = "The Punishments",
            NameNl = "De Straffen",
            NameFr = "Les Sanctions",
            NameSvn = "Kazni",
            NameDe = "Die Strafen",
            NameSrb = "Казне",
            RuleNumber = "16",
            Questions =
            [
                new QuestionDto
                {
                    Phrase =
                        "Team official B from WHITE team is complaining and receives a 2-minute suspension. Before the game is restarted, he complains again and is therefore disqualified. Correct decision?",
                    PhraseNl =
                        "Team official B van team WIT protesteert en krijgt een 2-minuten uitsluiting. Vooraleer het spel hernomen wordt protesteert hij opnieuw en wordt gediskwalificeerd. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "16.1",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "WHITE team is reduced by 2 players on the court for 2 minutes",
                            PhraseNl = "Team WIT wordt op het speelveld gereduceerd met 2 spelers voor 2 minuten",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "WHITE team is reduced by 1 player on the court for 4 minutes",
                            PhraseNl = "Team WIT wordt op het speelveld gereduceerd met 1 speler voor 4 minuten",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "WHITE team is reduced by 1 player on the court for 2 minutes",
                            PhraseNl = "Team WIT wordt op het speelveld gereduceerd met 1 speler voor 2 minuten",
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
                        "WHITE 8 receives a 2-minute suspension, as he has pushed an opponent. He approaches the referee to insult him with the following words: “You are stupid, you are an idiot, you will never learn!” Before leaving the court he spits in the referees face. Correct decision?",
                    PhraseNl =
                        "WIT8 krijgt wegens duwen van een tegenstrever een 2-minuten uitsluiting. Daarop gaat hij naar de scheidsrechter en verwijt hem: “Jij bent dom, jij bent een idioot, je leert het nooit”. Vooraleer hij het speelveld verlaat, spuwt hij nog de scheidsrechter in het gezicht. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "16.2",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of WHITE 8, WHITE team is reduced by 1 player on the court for 4 minutes (red card shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie van WIT8, team WIT wordt op het speelveld gereduceerd met 1 speler voor 4 minuten rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of WHITE 8, WHITE team is reduced by 2 players on the court for 2 minutes (red card shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie van WIT8, team WIT wordt op het speelveld gereduceerd met 2 spelers voor 2 minuten (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of WHITE 8, WHITE team is reduced by 1 player on the court for 4 minutes, written report (red and blue cards shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie van WIT8, team WIT wordt op het speelveld gereduceerd met 1 speler voor 4 minuten; schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters)",
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
                                "Disqualification of WHITE 8, WHITE team is reduced by 2 players on the court for 2 minutes, written report (red and blue cards shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie van WIT8, team WIT wordt op het speelveld gereduceerd met 2 spelers voor 2 minuten; schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters)",
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
                        "What is the maximum number of warnings that should be given to the officials of a team during a match?",
                    PhraseNl =
                        "Wat is het maximaal aantal waarschuwingen dat zou gegeven mogen worden aan de officials van een team tijdens een wedstrijd?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "16.3",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "None",
                            PhraseNl = "Geen",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "1",
                            PhraseNl = "1",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "2",
                            PhraseNl = "2",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "3",
                            PhraseNl = "3",
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
                    Phrase = "When does the suspension time of a player start?",
                    PhraseNl = "Wanneer start de tijd van een uitsluiting van een speler?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "16.4",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "When the referee gives the hand signal for the suspension",
                            PhraseNl = "Wanneer de scheidsrechter het teken van de uitsluiting heeft gegeven",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "When the suspended player crosses the sideline",
                            PhraseNl = "Wanneer de uitgesloten speler de zijlijn overschrijdt",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "When the referee whistles for the game to be restarted",
                            PhraseNl = "Wanneer de scheidsrechter fluit voor het hernemen van het spel",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "When the timekeeper starts the stopwatch",
                            PhraseNl = "Wanneer de tijdwaarnemer de chrono start",
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
                    Phrase = "To whom are suspensions to be indicated?",
                    PhraseNl = "Aan wie moeten uitsluitingen worden meegedeeld?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "16.5",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "The suspended player and the scorekeeper/timekeeper",
                            PhraseNl = "De uitgesloten speler en de secretaris/ tijdwaarnemer",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "The responsible team official and the timekeeper",
                            PhraseNl = "De verantwoordelijke team official en de tijdwaarnemer",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Timekeeper/scorekeeper",
                            PhraseNl = "Tijdwaarnemer/ wedstrijdsecretaris",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "The suspended player, the responsible team official, and the scorekeeper",
                            PhraseNl =
                                "De uitgesloten speler, de verantwoordelijke team official en de wedstrijdsecretaris",
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
                        "BLACK 5 has received two 2-minute suspensions earlier in the game. One suspension for a foul that was punished progressively, and one for throwing the ball away, when the referees gave a free throw for the opponents. Now he commits his team’s second faulty substitution, and before the game is restarted, he commits an extremely unsportsmanlike conduct. Correct decision?",
                    PhraseNl =
                        "ZWART5 kreeg reeds in de wedstrijd tweemaal een 2-minuten uitsluiting. Een uitsluiting voor een progressief te bestraffen spelregelovertreding en een voor het wegwerpen van de bal nadat de scheidsrechter vrije worp voor de tegenstanders gaf. Nu begaat hij de tweede wisselfout van zijn team en vooraleer het spel hernomen wordt begaat hij nog een extreem grove onsportiviteit. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "16.6",
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
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification for BLACK 5, written report (red and blue cards shown by the referees; BLACK team is reduced by 1 player on the court for 4 minutes",
                            PhraseNl =
                                "Diskwalificatie voor ZWART5, schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters), zijn team wordt op het speelveld gereduceerd met 1 speler gedurende 4 minuten",
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
                                "Disqualification for BLACK 5, written report (red and blue cards shown by the referees); BLACK team is reduced by 2 players on the court for 2 minutes",
                            PhraseNl =
                                "Diskwalificatie voor ZWART5, schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters), zijn team wordt op het speelveld gereduceerd met 2 spelers gedurende 2 minuten",
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
                        "WHITE 5 receives a 2-minute suspension for a foul. While leaving the court he insults the referees and is disqualified. WHITE 5 then gets so upset that he hits one of the referees. Correct decision?",
                    PhraseNl =
                        "WIT5 krijgt een 2-minuten uitsluiting voor een fout. Bij het verlaten van het speelveld beledigt hij de scheidsrechters en wordt gediskwalificeerd. WIT5 windt zich hierover zo hard op dat hij de scheidsrechter slaat. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "16.7",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Written report (blue card shown by the referees)",
                            PhraseNl = "Schriftelijk verslag (blauwe kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "WHITE team is reduced by 1 player on the court for 2 minutes",
                            PhraseNl = "Team WIT wordt op het speelveld gereduceerd met 1 speler voor 2 minuten",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "WHITE team is reduced by 2 players on the court for 2 minutes",
                            PhraseNl = "Team WIT wordt op het speelveld gereduceerd met 2 spelers voor 2 minuten",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "WHITE team is reduced by 1 player on the court for 4 minutes",
                            PhraseNl = "Team WIT wordt op het speelveld gereduceerd met 1 speler voor 4 minuten",
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
                        "WHITE 7 has just been suspended for two minutes for unfair play. Before the game is restarted, he says to the referee: “You must be blind, you idiot!” Correct decision?",
                    PhraseNl =
                        "WIT7 wordt net wegens onsportief gedrag voor 2 minuten uitgesloten. Vooraleer het spel hernomen wordt, zegt hij tegen de scheidsrechter: ”Jij moet wel blind zijn, jij idioot”. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "16.8",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Another 2-minutes suspension for WHITE 7",
                            PhraseNl = "Bijkomende 2-minuten uitsluiting voor WIT7",
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
                                "Diskwalificatie voor WIT7 zonder schriftelijk verslag (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "WHITE team is reduced by 2 players on the court for 2 minutes",
                            PhraseNl = "Team WIT wordt op het speelveld gereduceerd met 2 spelers voor 2 minuten",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "WHITE team is reduced by 1 player on the court for 4 minutes",
                            PhraseNl = "Team WIT wordt op het speelveld gereduceerd met 1 speler voor 4 minuten",
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
                                "Disqualification of WHITE 7, written report (red and blue cards shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie van WIT7, schriftelijk verslag (rode en blauwe kaart worden getoond door de scheidsrechters)",
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
                        "WHITE 3 has been suspended for two minutes. After leaving the court, but before the restart of the match, WHITE 3 is guilty of a seriously unsportsmanlike conduct in the substitution area against official B from BLACK team. Just before that, official B from BLACK team ran out onto the playing court, even though no permission had been given. No sanctions have been called against the officials of BLACK team. Correct decision?",
                    PhraseNl =
                        "Speler WIT3 is voor twee minuten uitgesloten. Na het verlaten van het speelveld, maar voor het hernemen van het spel, maakt WIT3 zich schuldig aan een ernstig onsportief gedrag in de wisselzone tegen official B van team ZWART. Net voordien, liep official B van team ZWART het speelveld op zonder dat hiervoor toelating werd gegeven. Tegen de officials van team ZWART was tot dan nog geen straf uitgesproken. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "16.9",
                    Answers =
                    [
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
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Warning for official B from BLACK team",
                            PhraseNl = "Waarschuwing voor official B van team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "WHITE team is reduced by 2 players on the court for 2 minutes",
                            PhraseNl = "Team WIT wordt gereduceerd op het veld met 2 spelers gedurende 2 minuten",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "WHITE team is reduced by 1 player on the court for 4 minutes",
                            PhraseNl = "Team WIT wordt gereduceerd op het veld met 1 speler gedurende 4 minuten",
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
                        "When a player is disqualified, the team is reduced by 1 player on the court for 2 minutes, unless the disqualification is given:",
                    PhraseNl =
                        "Wanneer een speler gediskwalificeerd wordt, wordt het team op het speelveld gereduceerd met 1 speler voor 2 minuten, tenzij de diskwalificatie werd gegeven:",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "16.10",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "For seriously unsportsmanlike conduct during the half-time break",
                            PhraseNl = "Voor grof onsportief gedrag tijdens de pauze",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "For an infringement outside the court",
                            PhraseNl = "Voor een vergrijp buiten het speelveld",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Before the match begins",
                            PhraseNl = "Voor de wedstrijd begint",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "For insulting the referees",
                            PhraseNl = "Voor beledigen van de scheidsrechters",
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
                        "During the half-time, break WHITE 7 assaults goalkeeper BLACK 12, while they are still on the court. Correct decision?",
                    PhraseNl =
                        "Tijdens de rust begaat WIT7 een gewelddaad tegen doelverdediger ZWART12 terwijl beide zich nog op het speelveld bevinden. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "16.11",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of WHITE 7, written report (red and blue cards shown by the referees); WHITE team is reduced by 1 player on the court for 2 minutes at the beginning of the second half.",
                            PhraseNl =
                                "Diskwalificatie voor WIT7, schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters). Team WIT wordt met 1 speler op het veld gereduceerd gedurende 2’ bij het begin van de tweede helft.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Warning for WHITE 7",
                            PhraseNl = "Waarschuwing voor WIT7",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Caution for WHITE 7, because the match was interrupted",
                            PhraseNl = "Vermaning voor WIT7 omdat het wedstrijd onderbroken was",
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
                        "During the half-time break, a referee is insulted by BLACK 7 on the way to the changing rooms. Correct decision?",
                    PhraseNl =
                        "Tijdens de rust wordt een scheidsrechter beledigd door ZWART7 op weg naar de kleedkamer. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "16.12",
                    Answers =
                    [
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
                            AnswerNumber = "a"
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
                            Phrase =
                                "BLACK team is reduced by 1 player on the court for 2 minutes at the beginning of the second half.",
                            PhraseNl =
                                "Team ZWART wordt op het speelveld gereduceerd met 1 speler voor 2 minuten bij het begin van de 2e helft",
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
                                "Disqualification of BLACK 7, written report (red and blue cards shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie van ZWART7, schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechter)",
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
                        "After the whistle for half-time, BLACK 5 collides with WHITE 9 on the court, and they both start shouting at each other. WHITE 9 then pushes BLACK 5 in the chest with both hands, so that BLACK 5 almost loses body control. Correct decision?",
                    PhraseNl =
                        "Na het fluitsignaal voor de pauze botsen WIT9 en ZWART5 op het speelveld tegen elkaar en beginnen naar elkaar te schreeuwen. Dan duwt WIT9 met beide handen tegen de borst van ZWART5 zodat ZWART5 bijna zijn lichaamscontrole verliest. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "16.13",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 9 at the beginning of the second half",
                            PhraseNl = "2-minuten uitsluiting voor WIT9 bij het begin van de tweede helft",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of WHITE 9 without written report (red card shown by the referees); WHITE team will be reduced by 1 player on the court for 2 minutes from the beginning of the second half.",
                            PhraseNl =
                                "Diskwalificatie voor WIT9 zonder schriftelijk verslag (rode kaart getoond door de scheidsrechters), team WIT wordt op het speelveld gereduceerd met 1 speler gedurende 2 minuten bij het begin van de tweede helft",
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
                                "Disqualification of WHITE 9; WHITE team starts the second half without reduction.",
                            PhraseNl = "Diskwalificatie van WIT9, team WIT begint de 2e helft zonder reductie",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of WHITE 9, written report (red and blue cards shown by the referees); WHITE team will be reduced by 1 player on the court for 2 minutes from the beginning of the second half.",
                            PhraseNl =
                                "Diskwalificatie van WIT9 met schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters) Team WIT wordt bij het begin van de 2e helft op het speelveld gereduceerd met 1 speler gedurende 2 minuten",
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
                        "After the game, WHITE 10 shouts at the referees: “You stole the game from us, you idiots!” Correct decision?",
                    PhraseNl =
                        "Na de wedstrijd schreeuwt WIT10 naar de scheidsrechter: “Jij hebt ons bestolen, idioot die je bent!”. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "16.14",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Warning for WHITE 10",
                            PhraseNl = "Waarschuwing voor WIT10",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of WHITE 10, written report (red and blue cards shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie voor WIT10, schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters)",
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
                            Phrase = "Warning for WHITE 10, written report",
                            PhraseNl = "Waarschuwing voor WIT10, schriftelijk verslag",
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
                        "During the half-time break, WHITE 9, on the playing court, commits an assault against official B from BLACK team, who subsequently insults WHITE 9. Correct decision?",
                    PhraseNl =
                        "Gedurende de pauze, begaat WIT9 een gewelddaad, op het speelveld, tegen de official B van team ZWART, die vervolgens speler WIT9 beledigt. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "16.15",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of WHITE 9, written report (red and blue cards shown by the referees); WHITE team will be reduced by 1 player on the court for 2 minutes from the beginning of the second half.",
                            PhraseNl =
                                "Diskwalificatie voor WIT9, schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters). Team WIT wordt op het speelveld bij het begin van de 2e helft met 1 speler gereduceerd gedurende 2 minuten.",
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
                                "Disqualification of official B from BLACK team, written report (red and blue cards shown by the referees); BLACK team will be reduced by 1 player on the court for 2 minutes from the beginning of the second half.",
                            PhraseNl =
                                "Diskwalificatie van official B van team ZWART, schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters). Team ZWART wordt op het speelveld bij het begin van de 2e helft met 1 speler gereduceerd gedurende 2 minuten.",
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
                                "Disqualification of WHITE 9 (red card shown by the referees); WHITE team will not be reduced from the beginning of the second half.",
                            PhraseNl =
                                "Diskwalificatie van WIT9 (rode kaart getoond door de scheidsrechters). Team WIT wordt op het speelveld niet gereduceerd bij het begint de tweede helft.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of official B from BLACK team (red card shown by the referees); BLACK team will not be reduced from the beginning of the second half.",
                            PhraseNl =
                                "Diskwalificatie van official B van team ZWART (rode kaart getoond door de scheidsrechters). Team ZWART wordt op het speelveld niet gereduceerd bij het begint de tweede helft.",
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
                        "WHITE 7 is disqualified because he has just received his third 2-minute suspension. He tries to argue with the referees and does not leave the court. Correct decision?",
                    PhraseNl =
                        "WIT7 is gediskwalificeerd omdat hij net een derde 2-minuten uitsluiting heeft gekregen. Hij probeert te discussiëren met de scheidsrechter en gaat niet van het speelveld. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "16.16",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "No further action",
                            PhraseNl = "Geen verdere beslissing",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "WHITE team is reduced by 1 player on the court for 4 minutes.",
                            PhraseNl = "Team WIT wordt op het speelveld met 1 speler gereduceerd gedurende 4 minuten.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "WHITE team is reduced by 2 players on the court for 2 minutes.",
                            PhraseNl = "Team WIT wordt op het speelveld met 1 speler gereduceerd gedurende 2 minuten.",
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
                        "WHITE 11 was warned in the first half and is again guilty of unsportsmanlike conduct during the half-time break. WHITE team was playing at full strength on the court, when the first half ended. Correct decision?",
                    PhraseNl =
                        "WIT11 werd de eerste helft gewaarschuwd en is opnieuw schuldig aan onsportief gedrag gedurende de rust. Team WIT speelde in volle sterkte op het speelveld bij het einde van de eerste helft. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "16.17",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Warning for WHITE 11",
                            PhraseNl = "Waarschuwing voor WIT11",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 11",
                            PhraseNl = "2-minuten uitsluiting voor WIT11",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification of WHITE 11",
                            PhraseNl = "Diskwalificatie voor WIT11",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "WHITE team will be reduced by 1 player on the court for 2 minutes from the beginning of the second half.",
                            PhraseNl =
                                "Team WIT wordt op het speelveld gereduceerd met 1 speler gedurende 2 minuten bij het beging van de tweede helft.",
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
                                "WHITE team will not be reduced by players on the court from the beginning of the second half.",
                            PhraseNl =
                                "Team WIT wordt niet gereduceerd in spelers op het speelveld bij het begint van de tweede helft.",
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
                        "WHITE 4 is injured. The referees whistle for a time-out and give the hand signal to permit WHITE team to enter the court and take care of the player. Officials A and B from WHITE team, but also official A from BLACK team, enter the court. Official A from BLACK team already received a warning. Correct decision?",
                    PhraseNl =
                        "Speler WIT4 is gekwetst. De scheidsrechters geven time-out en het teken om het speeloppervlak te betreden om voor de speler te zorgen. Officials A en B van team WIT, maar ook official A van team ZWART, betreden het speelveld. Official A van team ZWART heeft reeds eerder een waarschuwing gekregen, Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "16.18",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "No intervention",
                            PhraseNl = "Geen tussenkomst",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "When the game is restarted, BLACK team continues with the same number of players on the court as before the interruption.",
                            PhraseNl =
                                "Wanneer het spel hernomen wordt, gaat team ZWART verder met hetzelfde aantal spelers op het speelveld als voor de onderbreking.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for official A from BLACK team",
                            PhraseNl = "2-minuten uitsluiting voor official A van team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification of official A from BLACK team (red card shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie van official A van team ZWART (rode kaart getoond door de scheidrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "When the game is restarted, BLACK team will be reduced by 1 player on the court for 2 minutes.",
                            PhraseNl =
                                "Wanneer het spel hernomen wordt, zal team ZWART op het speelveld gereduceerd worden met 1 speler gedurende 2 minuten.",
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
                                "After receiving medical care on the court, WHITE 4 must leave the court and can only re-enter following the third attack of his team.",
                            PhraseNl =
                                "Na medische verzorging op het speelveld ontvangen te hebben, moet WIT4 het speelveld verlaten en kan pas na drie aanvallen van zijn team terug op het speelveld komen.",
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
                        "BLACK 9 is given a disqualification because of a serious foul against WHITE 9. Before the game is restarted, BLACK 9 hits official A from WHITE team in the face. Correct decision?",
                    PhraseNl =
                        "ZWART9 wordt wegens een grove spelregelovertreding tegen WIT9 gediskwalificeerd. Vooraleer het spel hernomen wordt slaat ZWART9 official A van team WIT in het gezicht. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "16.19",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of BLACK 9 without written report (red card shown by the referees); BLACK team will be reduced by 2 players on the court for 2 minutes.",
                            PhraseNl =
                                "Diskwalificatie voor ZWART9 zonder schriftelijk verslag (rode kaart getoond door de scheidsrechters); team ZWART wordt op het speelveld gereduceerd met twee spelers gedurende 2 minuten.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of BLACK 9 without written report (red card shown by the referees); BLACK team will be reduced by 1 player on the court for 4 minutes.",
                            PhraseNl =
                                "Diskwalificatie voor ZWART9 zonder schriftelijk verslag voor ZWART9 (rode kaart getoond door de scheidsrechters); team ZWART wordt op het speelveld gereduceerd met 1 speler gedurende 4 minuten.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "No additional punishment is possible",
                            PhraseNl = "Geen bijkomende bestraffing mogelijk",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of BLACK 9, written report (red and blue cards shown by the referees); BLACK team will be reduced by 2 players on the court for 2 minutes.",
                            PhraseNl =
                                "Diskwalificatie voor ZWART9 met schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters); team ZWART wordt op het speelveld gereduceerd met twee spelers gedurende 2 minuten.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of BLACK 9, written report (red and blue cards shown by the referees); BLACK team will be reduced by 1 player on the court for 4 minutes.",
                            PhraseNl =
                                "Diskwalificatie voor ZWART9 met schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters); team ZWART wordt op het speelveld gereduceerd met 1 speler gedurende 4 minuten.",
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
                        "BLACK 8 is given his first 2-minute suspension following a time-out signal. When he leaves the court, before the game is restarted, he addresses the referees in an unsportsmanlike manner. Correct decision?",
                    PhraseNl =
                        "ZWART8 krijgt zijn eerste 2 minuten na een time-out signaal. Bij het verlaten van het speelveld en voor het spel hernomen wordt, richt hij zich onsportief tot de scheidsrechter. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "16.20",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "An additional 2-minute suspension for BLACK 8, BLACK team will be reduced by 2 players on the court for 2 minutes",
                            PhraseNl =
                                "Een bijkomende 2-minuten uitsluiting voor ZWART8, team ZWART zal op het speelveld gereduceerd worden met 2 spelers gedurende 2 minuten",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "An additional 2-minute suspension for BLACK 8, BLACK team will be reduced by 1 player on the court for 4 minutes",
                            PhraseNl =
                                "Een bijkomende 2-minuten uitsluiting voor ZWART8, team ZWART zal op het speelveld gereduceerd worden met 1 speler gedurende 4 minuten",
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
                                "Disqualification of BLACK 8 (red card shown by the referees), BLACK team will be reduced by 2 players on the court for 2 minutes",
                            PhraseNl =
                                "Diskwalificatie voor ZWART8 (rode kaart getoond door de scheidsrechters); team ZWART zal op het speelveld gereduceerd worden met 2 spelers gedurende 2 minuten",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of BLACK 8 (red card shown by the referees), BLACK team will be reduced by 1 player on the court for 4 minutes",
                            PhraseNl =
                                "Diskwalificatie voor ZWART8 (rode kaart getoond door de scheidsrechters); team ZWART zal op het speelveld gereduceerd worden met 1 speler gedurende 4 minuten",
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
                        "In which of the following situations must a team be reduced by 1 player on the court for 4 minutes?",
                    PhraseNl =
                        "In welk van de volgende situaties moet een team op het speelveld gereduceerd worden met 1 speler gedurende 4 minuten?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "16.21",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "A player has just been disqualified. When leaving the court, he protests in a way that justifies a 2-minute suspension.",
                            PhraseNl =
                                "Een speler werd net gediskwalificeerd. Bij het verlaten van het speelveld protesteert hij op een wijze die een 2-minuten uitsluiting rechtvaardigt.",
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
                                "A player has just received a 2-minute suspension. When leaving the court, he insults the referees and is disqualified.",
                            PhraseNl =
                                "Een speler heeft net een 2-minuten uitsluiting gekregen. Bij het verlaten van het speelveld beledigt hij de scheidsrechter en wordt gediskwalificeerd.",
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
                                "A player has just received a 2-minute suspension for unsportsmanlike conduct towards an opponent. While he is still on the court, he hits an opponent in the face and is disqualified.",
                            PhraseNl =
                                "Een speler heeft net een 2-minuten uitsluiting gekregen wegens onsportief gedrag tegenover een tegenspeler. Terwijl hij nog op het speelveld is, slaat hij een tegenspeler in het gezicht en wordt gediskwalificeerd.",
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
                                "A player has just received a 2-minute suspension for unsportsmanlike conduct. After crossing the sideline, he comes back onto the court and protests, and he is given an additional 2-minute suspension.",
                            PhraseNl =
                                "Een speler heeft net een 2-minuten uitsluiting gekregen wegens onsportief gedrag. Nadat hij de zijlijn heeft overschreden heeft, komt hij terug op het speelveld en protesteert en krijgt een bijkomende 2-minuten uitsluiting.",
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
                                "A player has just been disqualified for spitting on an opponent. When leaving the court, he pushes a referee.",
                            PhraseNl =
                                "Een speler werd net gediskwalificeerd omdat hij een tegenstander gespuwd heeft. Bij het verlaten van het speelveld geeft hij de scheidsrechter een duw.",
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
                                "A player has just been disqualified for a serious foul. After leaving the court, and after the match has been restarted, he insults the referees while sitting in the spectators’ area.",
                            PhraseNl =
                                "Een speler werd net gediskwalificeerd wegens een grove spelregelovertreding. Na het verlaten van het speelveld en na het hernemen van het spel, beledigt hij de scheidsrechters terwijl hij in de toeschouwerszone zit.",
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
                        "WHITE 5 receives a 2-minute suspension in minute 7. He complains before the game is restarted and receives an additional 2-minute suspension. Exactly one minute later, he runs onto the court, and the timekeeper whistles. Because of the additional suspension for entering the court, he is disqualified. Because of this he now insults the referees. Correct decision?",
                    PhraseNl =
                        "WIT5 krijgt een 2-minuten uitsluiting in minuut 7. Voor de herneming van het spel protesteert hij en krijgt daarvoor een bijkomende 2-minuten uitsluiting. Precies één minuut later, loopt hij het speelveld op en de tijdwaarnemer fluit. Door de bijkomende uitsluiting voor het betreden van het speelveld, wordt hij gediskwalificeerd. Omwille hiervan, beledigt hij de scheidsrechters. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "16.22",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "WHITE team will be reduced by 1 player on the court from 07:00 to 08:00, by 2 players from 08:00 to 10:00 and by 1 player from 10:00 to 11:00.",
                            PhraseNl =
                                "Team WIT wordt op het speelveld gereduceerd met 1 speler van 07:00 tot 08:00, met 2 spelers van 08:00 tot 10:00 en met 1 speler 10:00 tot 11:00.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "WHITE team will be reduced by 1 player on the court from 07:00 to 08:00, by 2 players from 08:00 to 11:00 and by 1 player from 11:00 to 12:00.",
                            PhraseNl =
                                "Team WIT wordt op het speelveld gereduceerd met 1 speler van 07:00 tot 08:00, met 2 spelers van 08:00 tot 11:00 en met 1 speler 11:00 tot 12:00.",
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
                                "WHITE team will be reduced by 2 players on the court from 07:00 to 08:00, by 3 players from 08:00 to 10:00 and by two players from 10:00 to 11:00.",
                            PhraseNl =
                                "Team WIT wordt op het speelveld gereduceerd met 2 spelers van 07:00 tot 08:00, met 3 spelers van 08:00 tot 10:00 en met 2 speler 10:00 tot 11:00.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "WHITE team will be reduced by 2 players on the court from 07:00 to 08:00, by 4 players from 08:00 to 10:00 and by 2 players from 10:00 to 11:00.",
                            PhraseNl =
                                "Team WIT wordt op het speelveld gereduceerd met 2 speler van 07:00 tot 08:00, met 4 spelers van 08:00 tot 10:00 en met 2 speler 10:00 tot 11:00.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of WHITE 5, written report (red and blue cards shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie van WIT5, schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters)",
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
                        "Official C from WHITE team receives a warning in the first half because of unsportsmanlike conduct. The playing time is 35:50, and official B from WHITE team, with forceful gestures, shows that he disagrees with a decision of the referees. For this, he receives a 2-minute suspension. Three minutes before the end of the match, official A from WHITE team enters the court without permission from the referees. What is the correct decision?",
                    PhraseNl =
                        "Official C van team WIT krijgt tijdens de eerste helft een waarschuwing wegens onsportief gedrag. De speeltijd is 35:50, en official B van team WIT, toont, krachtig gesticulerend, dat hij niet akkoord is met een beslissing van de scheidsrechters. Hiervoor krijgt hij een 2-minuten uitsluiting. Drie minuten voor het einde van de wedstrijd, loopt official A van team WIT het veld in, zonder toestemming van de scheidsrechters. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "16.23",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Warning for official A from WHITE team",
                            PhraseNl = "Waarschuwing voor official A van team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "2-minute suspension for official A from WHITE team; WHITE team are reduced on the court by 1 player for 2 minutes; official A can stay in the substitution area",
                            PhraseNl =
                                "2-minuten uitsluiting voor official A van team WIT; team WIT wordt op het speelveld gereduceerd met 1 speler gedurende 2 minuten; official A van team WIT mag in de wisselzone blijven",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "2-minute suspension for official A from WHITE team; WHITE team are reduced on the court by 1 player for 2 minutes; official A must leave the substitution area",
                            PhraseNl =
                                "2-minuten uitsluiting voor official A van team WIT; team WIT wordt op het speelveld gereduceerd met 1 speler gedurende 2 minuten; official A van team WIT moet de wisselzone verlaten",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification for official A from WHITE team (red card shown by the referees); WHITE team are reduced on the court by 1 player for 2 minutes",
                            PhraseNl =
                                "Diskwalificatie voor official A van team WIT (rode kaart getoond door de scheidsrechters); Team WIT wordt op het speelveld gereduceerd met 1 speler gedurende 2 minuten",
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
                                "Disqualification for official A from WHITE team with written report (red and blue cards shown by the referees); WHITE team are reduced on the court by 1 player for 2 minutes",
                            PhraseNl =
                                "Diskwalificatie voor official A van team WIT met schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters); Team WIT wordt op het speelveld gereduceerd met 1 speler gedurende 2 minuten",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "e"
                        }
                    ]
                }
            ]
        };
    }
}
