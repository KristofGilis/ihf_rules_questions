using IHF.Rules.Questions.Infrastructure.DataSeed.Models;

namespace IHF.Rules.Questions.Infrastructure.DataSeed;

public static partial class Rules
{
    public static RuleDto GetRule01()
    {
        return new RuleDto
        {
            Name = "Playing Court",
            NameNl = "Speeloppervlak",
            NameFr = "L'aire de jeu",
            NameSvn = "Igrišče",
            NameDe = "Die Spielfläche",
            NameSrb = "Игралиште",
            RuleNumber = "1",
            Questions =
            [
                new QuestionDto
                {
                    Phrase = "What are the measurements of the playing court according to the rules?",
                    PhraseNl = "Wat zijn de afmetingen van het speelveld volgens de spelregels?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Које димензије игралишта прописују Правила игре?",
                    QuestionNumber = "1.1",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "40 x 20 metres",
                            PhraseNl = "40 m x 20 m",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "40 x 20 м",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "42 x 20 metres",
                            PhraseNl = "42 m x 20 m",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "42 x 20 м",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "38 x 18 metres",
                            PhraseNl = "38 m x 18 m",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "38 x 18 м",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Length between 38 and 42, width between 18 and 22 metres",
                            PhraseNl = "Lengte tussen 38 en 42 m, breedte tussen 18 en 22 m",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Дужина између 38 и 42 метра, ширина између 18 и 22 метра",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase = "What are the required interior measurements of the goal?",
                    PhraseNl = "Welke zijn de vereiste binnen afmetingen van het doel?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Које су захтеване унутрашње димензије гола?",
                    QuestionNumber = "1.2",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "1.92 x 2.92 metres",
                            PhraseNl = "1,92 m x 2,92 m",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "1,92 x 2,92 м",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "2.00 x 3.00 metres",
                            PhraseNl = "2,00 m x 3,00 m",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2,00 x 3,00 м",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "2.05 x 3.05 metres",
                            PhraseNl = "2,05 m x 3,05 m",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2,05 x 3,05 м",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "2.08 x 3.08 metres",
                            PhraseNl = "2,08 m x 3,08 m",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2,08 x 3,08 м",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase = "How wide is the goal line between the posts?",
                    PhraseNl = "Hoe breed is de doellijn tussen de doelpalen?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Колико је широка гол линија између статива?",
                    QuestionNumber = "1.3",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "5cm",
                            PhraseNl = "5 cm",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "5 цм",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "6cm",
                            PhraseNl = "6 cm",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "6 цм",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "8cm",
                            PhraseNl = "8 cm",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "8 цм",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "10cm",
                            PhraseNl = "10 cm",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "10 цм",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase = "Which statements are correct about the throw-off area?",
                    PhraseNl = "Welke uitspraken zijn juist over het beginworpgebied?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Које од следећих тврдњи везане за простор за почетно бацање су тачне?",
                    QuestionNumber = "1.4",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "It consists of a circle with a diameter of 3 metres.",
                            PhraseNl = "Het bestaat uit een cirkel met een diameter van 3 meter",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Састоји се од круга пречника 3 метра",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "It consists of a circle with a diameter of 4 metres.",
                            PhraseNl = "Het bestaat uit een cirkel met een diameter van 4 meter",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Састоји се од круга пречника 4 метра",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "The throw-off area can be an area with a different colour than the playing court.",
                            PhraseNl = "Het beginworpgebied kan een gebied zijn met een andere kleur dan het speelveld",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Простор за почетно бацање може бити простор другачије боје у односу на терен за игру",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "The throw-off area can be a circle line.",
                            PhraseNl = "Het beginworpgebied kan een cirkellijn zijn",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Простор за почетно бацање може бити кружна линија",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "The throw-off area is mandatory for all events in handball.",
                            PhraseNl = "Het beginworpgebied is verplicht voor alle evenementen in handbal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Коришћење простора за почетно бацање је обавезно за сва рукометна такмичења",
                            AnswerNumber = "e"
                        }
                    ]
                }
            ]
        };
    }
}
