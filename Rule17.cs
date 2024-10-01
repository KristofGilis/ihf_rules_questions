using IHF.Rules.Questions.Infrastructure.DataSeed.Models;

namespace IHF.Rules.Questions.Infrastructure.DataSeed;

public static partial class Rules
{
    public static RuleDto GetRule17()
    {
        return new RuleDto
        {
            Name = "The Referees",
            NameNl = "De Scheidsrechters",
            NameFr = "Les Arbitres",
            NameSvn = "Sodnika",
            NameDe = "Die Schiedsrichter",
            NameSrb = "Судије",
            RuleNumber = "17",
            Questions =
            [
                new QuestionDto
                {
                    Phrase = "The referees disagree on which team should have a throw-in. How should this be handled?",
                    PhraseNl =
                        "De scheidsrechters verschillen van mening over welk team een inworp moet krijgen. Hoe zou dit afgehandeld moeten worden?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "17.1",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "The court referee decides.",
                            PhraseNl = "De veldscheidsrechter beslist.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "The goal-line referee decides.",
                            PhraseNl = "De doelscheidsrechter beslist.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "The two referees make a joint decision after consultation.",
                            PhraseNl = "De twee scheidsrechters nemen een gemeenschappelijke beslissing na overleg.",
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
                            Phrase = "No time-out, but throw-in executed after whistle signal",
                            PhraseNl = "Geen time-out, de inworp wordt uitgevoerd na fluitsignaal",
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
                        "The automatic final signal from the public clock is not working. The timekeeper has not noticed the problem and therefore does not react, even though the playing time has already ended. Who shall give the final signal in this case?",
                    PhraseNl =
                        "Het automatisch eindsignaal van de elektronische muurtijdklok werkt niet. De tijdwaarnemer heeft het probleem niet opgemerkt en reageert niet, ook al is de speeltijd reeds verlopen. Wie moet in dit geval het eindsignaal geven?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "17.2",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Only the scorekeeper",
                            PhraseNl = "Alleen de wedstrijdsecretaris",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Only the court referee",
                            PhraseNl = "Alleen de veldscheidsrechter",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Only the delegate",
                            PhraseNl = "Alleen de waarnemer",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Only one of the referees",
                            PhraseNl = "Alleen een van de scheidsrechters",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "Only the timekeeper",
                            PhraseNl = "Alleen de tijdwaarnemer",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "e"
                        },
                        new AnswerDto
                        {
                            Phrase = "Either the timekeeper, the delegate or one of the referees",
                            PhraseNl = "Ofwel de tijdwaarnemer, de waarnemer of een van de scheidsrechters",
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
                        "BLACK 2 has committed an infraction. The court referee decides on a disqualification of BLACK 2 (red card shown by the referees) and a free throw. The goal referee decides on a 2-minute suspension for BLACK 2 and a 7-metre throw. How is BLACK 2 to be penalised, and how is the game to be continued?",
                    PhraseNl =
                        "ZWART2 heeft een overtreding begaan. De veldscheidsrechter beslist tot een diskwalificatie van ZWART2 (rode kaart getoond door de scheidsrechter) en vrije worp. De doelscheidsrechter beslist op een 2-minuten bestraffing voor ZWART2 en een 7m-worp. Hoe moet WART2 bestraft worden en hoe moet het spel hernomen worden?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "17.3",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for BLACK 2",
                            PhraseNl = "2-minuten uitsluiting voor ZWART2",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification of BLACK 2 (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie van ZWART2 (rode kaart getoond door de scheidsrechter)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b",
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
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw",
                            PhraseNl = "7m-worp",
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
                    Phrase = "In case of doubt, who decides about the accuracy of the timekeeping?",
                    PhraseNl = "Wie beslist in geval van twijfel over de juistheid van de tijd?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "17.4",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "The timekeeper and the scorekeeper",
                            PhraseNl = "De tijdwaarnemer en de wedstrijdsecretaris",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "The two referees reach a joint decision.",
                            PhraseNl = "De twee scheidsrechters in overleg.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "The timekeeper",
                            PhraseNl = "De tijdwaarnemer",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "The two referees and the timekeeper reach a joint decision.",
                            PhraseNl = "De twee scheidsrechters en de tijdwaarnnemer in gezamenlijk overleg.",
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
                    Phrase = "Which punishments need to be explained in the match report?",
                    PhraseNl = "Welke bestraffingen moeten verklaard worden op het wedstrijdblad?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "17.5",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "All disqualifications, except for those given because of three 2-minute suspensions",
                            PhraseNl = "Alle diskwalificaties, behalve deze ten gevolge van 3 2-minuten uitsluitingen",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "All punishments, except cautions",
                            PhraseNl = "Alle bestraffingen, behalve de waarschuwingen",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "All suspensions and all disqualifications",
                            PhraseNl = "Alle uitsluitingen en alle diskwalificaties",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualifications for dangerous fouls or seriously unsportsmanlike conduct in the last 30 seconds of the match, if the action is intended to prevent the opponents from creating a scoring chance",
                            PhraseNl =
                                "Diskwalificaties wegens gevaarlijke fouten en grof onsportief gedrag in de laatste 30 seconden van de wedstrijd, indien de actie bedoeld is om de tegenstrever te verhinderen om een scorekans te creëren",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification due to extremely unsportsmanlike conduct",
                            PhraseNl = "Diskwalificatie wegens extreem onsportief gedrag",
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
                                "Any progressive punishment during the last 30 seconds of the game, if the action is intended to prevent the opponents from creating a scoring chance",
                            PhraseNl =
                                "Elke progressieve bestraffing in de laatste 30 seconden van de wedstrijd, indien de actie bedoeld is om de tegenstrever te verhinderen om een scorekans te creëren",
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
                    Phrase = "Who is entitled to address the referees during a game?",
                    PhraseNl = "Wie mag zich tijdens de wedstrijd tot de scheidsrechters wenden?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "17.6",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Every player",
                            PhraseNl = "Iedere speler",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Every official",
                            PhraseNl = "Iedere official",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "The responsible team official",
                            PhraseNl = "De verantwoordelijke team official",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "The team captain",
                            PhraseNl = "De team aanvoerder",
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
                        "The referees have different opinions about how much playing time remains. The goal-line referee (first mentioned referee) believes that 50 seconds remain, while the court referee believes that 42 seconds remain. Correct decision?",
                    PhraseNl =
                        "De scheidsrechters hebben een verschillende mening over de resterende speeltijd. De doelscheidsrechter ( “eerstgenoemde” scheidsrechter) denkt dat er nog 50 seconden te spelen zijn, terwijl de veldscheidsrechter gelooft dat er 42 seconden overblijven. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "17.7",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "The longer playing time applies (50 seconds).",
                            PhraseNl = "De langste tijd is van toepassing (50 seconden).",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "The first mentioned referee decides (50 seconds).",
                            PhraseNl = "De eerstgenoemde scheidsrechter beslist (50 seconden).",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "The court referee decides (42 seconds).",
                            PhraseNl = "De veldscheidsrechter beslist (42 seconden).",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "The two referees must reach a joint decision.",
                            PhraseNl = "De twee scheidsrechters moeten tot een gezamenlijke beslissing komen.",
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
                        "At the start of a match, which referee becomes the court referee, and which referee becomes the goal-line referee?",
                    PhraseNl =
                        "Welke scheidsrechter wordt veldscheidsrechter en welke doelscheidsrechter bij het begin van de wedstrijd?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "17.8",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "The first mentioned referee becomes the court referee.",
                            PhraseNl = "De eerstgenoemde scheidsrechter wordt veldscheidsrechter.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "The first mentioned referee becomes the goal-line referee.",
                            PhraseNl = "De eerstgenoemde scheidsrechter wordt doelscheidsrechter.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "The referees use a coin toss to decide, who starts where.",
                            PhraseNl =
                                "De scheidsrechters gebruiken een toss om te beslissen wie in welke positie begint.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "The referees are free to make their own choice.",
                            PhraseNl = "De scheidsrechters mogen dit zelf vrij bepalen.",
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
                        "The two referees whistle after a collision between two players. The court referee shows offensive foul, but the goal-line referee indicates a violation by the defender. How should this be decided?",
                    PhraseNl =
                        "Bij een botsing tussen twee spelers fluiten beide scheidsrechters. De veldscheidsrechter geeft een aanvallende fout aan doch de doelscheidsrechter geeft een fout van de verdediger aan. Wat moet dit beslist worden?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "",
                    QuestionNumber = "17.9",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "The decision of the goal-line referee is valid.",
                            PhraseNl = "De beslissing van de doelscheidsrechter is geldig.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "The decision of the court referee is valid.",
                            PhraseNl = "De beslissing van de veldscheidsrechter is geldig.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "The referees contact each other to reach a joint decision.",
                            PhraseNl =
                                "De scheidsrechters contacteren elkaar om een gezamenlijke beslissing te bereiken.",
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
                            PhraseNl = "Time-out is verplicht",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Time-out only necessary if the joint decision goes against the attacking team",
                            PhraseNl =
                                "Time-out is enkel noodzakelijk, wanneer de gezamenlijke beslissing tegen het aanvallende team is",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "",
                            AnswerNumber = "e"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Time-out not obligatory, if the referees are using electronic equipment for their internal communication",
                            PhraseNl =
                                "Time-out is niet verplicht, wanneer de scheidsrechters elektronische apparaten voor interne communicatie gebruiken",
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
