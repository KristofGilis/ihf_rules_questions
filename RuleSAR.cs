using IHF.Rules.Questions.Infrastructure.DataSeed.Models;

namespace IHF.Rules.Questions.Infrastructure.DataSeed;

public static partial class Rules
{
    public static RuleDto GetRuleSar()
    {
        return new RuleDto
        {
            Name = "Substitution Area Regulation",
            NameNl = "Richtlijnen Wisselzone",
            NameFr = "Règlement des Zones de Changement",
            NameSvn = "Pravilnik O Prostoru Za Menjave",
            NameDe = "Auswechselraum-Reglement (ARR)",
            NameSrb = "Правила о простору за замену играча",
            RuleNumber = "SAR",
            Questions =
            [
                new QuestionDto
                {
                    Phrase =
                        "What should be the distance between the centre line and the start of the substitution benches?",
                    PhraseNl = "Wat zou de afstand moeten zijn tussen de middenlijn en het begin van de wisselbanken?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Колико би требало да буде и растојање између средишње линије и почетка клупе за резервне играче?",
                    QuestionNumber = "SAR1",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "1 metre",
                            PhraseNl = "1 meter",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "1 метар",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "2 metres",
                            PhraseNl = "2 meter",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 метра",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "3 metres",
                            PhraseNl = "3 meter",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "3 метра",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "3.5 metres",
                            PhraseNl = "3,5 meter",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "3,5 метра",
                            AnswerNumber = "d",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "Official A from WHITE team has already received a warning while sitting on the bench. He now leaves the substitution area and sits in the spectators’ area. From this position, he continues to protest over the referees’ decisions. Correct decision?",
                    PhraseNl =
                        "Official A van team WIT heeft reeds een waarschuwing gekregen terwijl hij op de bank zit. Nu verlaat hij de wisselzone en zit in de publiekszone. Van daaruit blijft hij protest uiten naar de beslissingen van de scheidsrechters. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Званичник А БЕЛЕ екипе је већ имао опомену док је седео на клупи. Он сада напушта простор за замену играча и седа у публику. Са ове позиције он наставља да протестује на одлуке судија. Исправна одлука?",
                    QuestionNumber = "SAR2",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "No action possible",
                            PhraseNl = "Geen actie mogelijk",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Даља акција није могућа",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for official A from WHITE team",
                            PhraseNl = "2-minuten uitsluiting voor official A van team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења за званичника А БЕЛЕ екипе",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification of official A from WHITE team (red card shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie van official A van team WIT (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Дисквалификација званичника А БЕЛЕ екипе (црвени картон показан од стране судија)",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of official A from WHITE team, written report (red and blue cards shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie van official A van team WIT, schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Дисквалификација званичника А БЕЛЕ екипе, писани извештај (црвени и плави картон показани од стране судија)",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "WHITE team will be reduced by 1 player on the court for 2 minutes.",
                            PhraseNl = "Team WIT wordt op het speelveld gereduceerd met 1 speler gedurende 2 minuten.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "БЕЛА екипа ће бити редукована за једног играча у пољу на 2 минута",
                            AnswerNumber = "e",
                            Correct = true
                        }
                    ]
                }
            ]
        };
    }
}
