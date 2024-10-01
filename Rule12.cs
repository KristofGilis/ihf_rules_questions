using IHF.Rules.Questions.Infrastructure.DataSeed.Models;

namespace IHF.Rules.Questions.Infrastructure.DataSeed;

public static partial class Rules
{
    public static RuleDto GetRule12()
    {
        return new RuleDto
        {
            Name = "The Goalkeeper Throw",
            NameNl = "De uitworp",
            NameFr = "Le Renvoi",
            NameSvn = "Vratarjev Met",
            NameDe = "Der Abwurf",
            NameSrb = "Голманово бацање",
            RuleNumber = "12",
            Questions =
            [
                new QuestionDto
                {
                    Phrase =
                        "While executing a goalkeeper throw, goalkeeper WHITE 1 touches his goal-area line with one foot. Correct decision?",
                    PhraseNl =
                        "Tijdens het uitvoeren van een uitworp raakt doelman WIT1 zijn doelgebied lijn met een voet. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Изводећи голманово бацање, голман БЕЛИ 1 додирује линију свог голмановог простора. Исправна одлука?",
                    QuestionNumber = "12.1",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Goalkeeper throw is to be retaken after whistle signal",
                            PhraseNl = "De uitworp moet hernomen worden na fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Голманово бацање се понавља после звучног сигнала",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team",
                            PhraseNl = "Vrije worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за ЦРНУ екипу",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Let the game continue without interruption",
                            PhraseNl = "Verder spelen zonder onderbreking",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Игра се наставља без прекида",
                            AnswerNumber = "c",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "After the whistle for the execution of a 7-metre throw, goalkeeper WHITE 12 steps on the goalkeeper’s restraining line with one foot. The 7-metre throw goes over the crossbar. Correct decision?",
                    PhraseNl =
                        "Na het fluitsignaal voor de uitvoering van een 7m-worp, stapt doelman WIT12 met 1 voet op de doelverdedigersgrenslijn. De 7m-worp gaat over de deklat. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "После звиждука за извођење седмерца, голман БЕЛИ 12 стане једном ногом на линију четверца (ограничавајућа линија за голмана) . Лопта одлази преко пречке. Исправна одлука?",
                    QuestionNumber = "12.2",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "7-metre throw is to be retaken after whistle signal",
                            PhraseNl = "Herhaling van de 7m-worp na fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац ће бити поновљен после звучног сигнала",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Since there is no goal, the game continues with a goalkeeper throw.",
                            PhraseNl = "Gezien het geen doelpunt is, gaat het spel verder met een uitworp.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Није гол, игра се наставља голмановим бацањем",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "The position of the goalkeeper is correct.",
                            PhraseNl = "De opstelling van de doelverdediger is correct.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Позиција голмана је исправна",
                            AnswerNumber = "c",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "Goalkeeper WHITE 1 stops a shot and dives for the ball, which rolls in the goal area towards the playing area. BLACK 7 is unmarked and ready to pick up the ball. At the very last moment, WHITE 1 uses his hand to hit the ball over the outer goal line. Correct decision?",
                    PhraseNl =
                        "Doelman WIT1 weert af en werpt zich naar de bal die richting speelveld rolt. ZWART7 staat ongedekt, klaar om de bal aan te nemen. Op het allerlaatste moment slaat doelverdediger WIT1 de bal met de hand over de eigen buitendoellijn. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Голман БЕЛИ 1 зауставља шут и баца се за лоптом која се котрља према пољу за игру. ЦРНИ 7 стоји неометан и спреман да узме лопту. У последњем тренутку БЕЛИ 1 успева руком да избије лопту преко гол-аут линије изван гола. Исправна одлука?",
                    QuestionNumber = "12.3",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team",
                            PhraseNl = "Vrije worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за ЦРНУ екипу",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Throw-in for BLACK team",
                            PhraseNl = "Inworp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Аут за ЦРНУ екипу",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Goalkeeper throw for WHITE team",
                            PhraseNl = "Uitworp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Голманово бацање за БЕЛУ екипу",
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
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "While executing a goalkeeper throw, goalkeeper WHITE 12 drops the ball. The ball hits his foot. From there the ball crosses the goal-area line into the playing area. WHITE 12 runs after the ball, picks it up and returns to his goal area to repeat the goalkeeper throw. Correct decision?",
                    PhraseNl =
                        "Wanneer doelman WIT12 een uitworp uitvoert, laat hij de bal vallen. De bal valt op zijn voet. Van hieruit overschrijdt de bal de doelgebied lijn in het speelveld. Doelman WIT12 loopt de bal na, neemt hem op en keert in zijn doelgebied terug om de uitworp te hernemen. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Изводећи голманово бацање, голман БЕЛИ 12 испусти лопту и она га погоди у ногу. Лопта пређе преко линије голмановог простора и оде у поље за игру. БЕЛИ 12 трчи за лоптом, ухвати је и врати се у свој голманов простор да понови голманово бацање. Исправна одлука?",
                    QuestionNumber = "12.4",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for BLACK team",
                            PhraseNl = "7m-worp tegen team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за ЦРНУ екипу",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team",
                            PhraseNl = "Vrije worp tegen team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за ЦРНУ екипу",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Time-out",
                            PhraseNl = "Time-out",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Тајм-аут",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Correction, goalkeeper throw after whistle signal",
                            PhraseNl = "Correctie, uitworp na fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Корекција, голманово бацање после звучног сигнала",
                            AnswerNumber = "d",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "When is a goalkeeper throw considered as executed, so that the ball may be played by a court player?",
                    PhraseNl =
                        "Wanneer wordt een uitworp als uitgevoerd beschouwd, zo dat de bal door een veldspeler mag gespeeld worden?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Када се сматра да је голманово бацање изведено тако да лоптом може да игра играч у пољу за игру?",
                    QuestionNumber = "12.5",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "When the ball is still in the air above the goal area",
                            PhraseNl = "Wanneer de bal zich nog in de lucht boven het doelgebied bevindt",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Кад је лопта још у ваздуху изнад голмановог простора",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "When the ball has left the hand of the goalkeeper, passed the goal-area line and entered the playing area",
                            PhraseNl =
                                "Wanneer de bal de hand van de doelverdediger heeft verlaten, de doelgebied lijn in de richting van het speelveld heeft overschreden en in het speelveld is binnen gegaan",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Кад је лопта напустила руку голмана, прешла линију голмановог простора и налази се изнад поља за игру",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "When the ball has left the hand of the goalkeeper",
                            PhraseNl = "Wanneer de bal de hand van de doelverdediger heeft verlaten",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Кад је лопта напустила руку голмана",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "When a teammate of the goalkeeper has touched the ball",
                            PhraseNl = "Wanneer een medespeler van de doelverdediger de bal aangeraakt heeft",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Кад је саиграч голмана додирнуо лопту",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "Goalkeeper WHITE 12 is executing a goalkeeper throw. BLACK 10, who is standing outside the goal-area line, legally tries to gain possession of the ball. He succeeds and scores a goal. Correct decision?",
                    PhraseNl =
                        "Doelverdediger WIT12 voert een uitworp uit. Speler ZWART10, die buiten de doelgebied lijn staat, probeert overeenkomstig de spelregels in balbezit te geraken. Dat lukt hem en hij scoort een doelpunt. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Голман БЕЛИ 12 изводи голманово бацање. ЦРНИ 10 стоји уз линију голмановог простора и покушава на исправан начин да освоји лопту. У томе успева и постиже гол. Исправна одлука?",
                    QuestionNumber = "12.6",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team",
                            PhraseNl = "Vrije worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Goal for BLACK team",
                            PhraseNl = "Doelpunt voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Гол за ЦРНУ екипу",
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
                            PhraseSrb = "Голманово бацање за БЕЛУ екипу",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Progressive punishment against BLACK 10",
                            PhraseNl = "Progressieve bestraffing voor ZWART10",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Прогресивна казна против ЦРНОГ 10",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "Goalkeeper WHITE 12 stops a shot, deflecting the ball across the outer goal line next to the goal. Which hand signals should the goal-line referee show, if necessary?",
                    PhraseNl =
                        "Doelverdediger WIT12 weert een worp af, devieert de bal over zijn buitendoellijn naast het doel. Welk(e) handsignalen zou de doelscheidsrechter moeten tonen, indien nodig?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Голман БЕЛИ 12 одбрани шут, одбије лопту преко гол-аут линије поред гола; Који ручни сигнал/сигнале треба судија код гола да покаже?",
                    QuestionNumber = "12.7",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Number 8 (goalkeeper throw)",
                            PhraseNl = "Nummer 8 (uitworp)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Сигнал број 8: голманово бацање",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Number 9 (free-throw direction)",
                            PhraseNl = "Nummer 9 (richting vrije worp)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Сигнал број 9: смер слободног бацања",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "First number 9 (free-throw direction), then number 8 (goalkeeper throw)",
                            PhraseNl = "Eerst nummer 9 (richting vrije worp), dan nummer 8 (uitworp)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Прво сигнал број 9: смер слободног бацања, а затим сигнал број 8: голманово бацање",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "First number 8 (goalkeeper throw), then number 9 (free-throw direction)",
                            PhraseNl = "Eerst nummer 8 (uitworp), dan nummer 9 (richting vrije worp)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Прво сигнал број 8: голманово бацање, а затим сигнал броој 9: смер слободног бацања",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "Goalkeeper WHITE 1 loses the ball while executing a goalkeeper throw. The ball bounces in the direction of the playing area, where BLACK 6 is waiting for the ball. WHITE 2 dives over the goal area and pushes the ball, which is in the air, over the sideline. Correct decision?",
                    PhraseNl =
                        "Doelverdediger WIT1 verliest de bal bij het uitvoeren van een uitworp. De bal botst in de richting van het speelveld, waar ZWART6 de bal opwacht. WIT2 duikt boven het doelgebied en duwt de bal, die in de lucht is, over de zijlijn. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Голману БЕЛОМ 1 испадне лопта док је изводио голманово бацање. Лопта одскаче у правцу поља за игру, где је чека ЦРНИ 6. БЕЛИ 2 се баца преко линије голмановог простора и избацује лопту која је у ваздуху преко аут линије. Исправна одлука?",
                    QuestionNumber = "12.8",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Goalkeeper throw for WHITE team after whistle signal",
                            PhraseNl = "Uitworp voor team WIT na fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Голманово бацање за БЕЛУ екипу после звучног сигнала",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Throw-in for BLACK team",
                            PhraseNl = "Inworp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Аут за ЦРНУ екипу",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team",
                            PhraseNl = "Vrije worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за ЦРНУ екипу",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for BLACK team",
                            PhraseNl = "7m-worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за ЦРНУ екипу",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase = "Which of the following statements about the goalkeeper throw are correct?",
                    PhraseNl = "Welke uitspraken betreffende de uitworp zijn correct?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Које су тврдње у вези са голмановим бацањам тачне?",
                    QuestionNumber = "12.9",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "The goalkeeper throw is considered as taken when the ball has left the goalkeeper’s hand.",
                            PhraseNl =
                                "De uitworp wordt als uitgevoerd beschouwd van zodra de bal de hand van de doelverdediger heeft verlaten.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Голманово бацање се сматра изведеним кад лопта напусти голманову руку",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "The opponents must keep a distance of 3 metres.",
                            PhraseNl = "De tegenstanders moeten zich op minstens 3 meter afstand bevinden.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Противници морају бити на одстојању од 3 метра",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "The goalkeeper throw is considered as taken when the ball has left the hand of the goalkeeper and has passed the goal-area line.",
                            PhraseNl =
                                "De uitworp wordt als uitgevoerd beschouwd van zodra de bal de hand van de doelverdediger heeft verlaten en de doelgebied lijn heeft overschreden.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Голманово бацање се сматра изведеним кад лопта напусти руку голмана и пређе линију голмановог простора",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "The opponents are allowed to stand directly outside the goal-area line.",
                            PhraseNl = "De tegenspelers mogen zich ophouden net buiten de doelgebied lijn.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Противницима је дозвољено да стоје непосредно испред линије голмановог простора",
                            AnswerNumber = "d",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "There is a goalkeeper throw for BLACK team. Goalkeeper BLACK 1 is in a hurry, because his team is behind in the game. While executing the goalkeeper throw, the ball slides out of his hand and goes to BLACK 6, who is still in the goal area. BLACK 6 rolls the ball back to BLACK 1 using his foot. Correct decision?",
                    PhraseNl =
                        "Uitworp voor team ZWART. Doelverdediger ZWART1 is gehaast omdat zijn team achterstaat. Bij het uitvoeren van de uitworp glijdt de bal uit zijn hand en gaat naar ZWART6 die nog in het doelgebied staat. ZWART6 rolt de bal met de voet terug naar ZWART1. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Голманово бацање за ЦРНУ екипу. Голман ЦРНИ 1 жури, зато што његов тим резултатски заостаје. Док извод слободно бацање лопта клизне из његове руке и долази до ЦРНОГ 6, који стоји у голмановом простору. ЦРНИ 6 ногом врати лопту ЦРНОМ 1. Исправна одлука?",
                    QuestionNumber = "12.10",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Goalkeeper throw for BLACK team after whistle signal",
                            PhraseNl = "Uitworp voor team ZWART na fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Поновљено голманово бацање после звучног сигнала",
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
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for WHITE team",
                            PhraseNl = "7m-worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за БЕЛУ екипу",
                            AnswerNumber = "c"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase = "Which of the following statements about the goalkeeper throw are correct?",
                    PhraseNl = "Welke van de volgende beweringen betreffende de uitworp zijn juist?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Која од ових тврдњи у вези са голмановим бацањем је исправна?",
                    QuestionNumber = "12.11",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "The players from the opponents’ team must remain outside the free-throw line until the ball is in play.",
                            PhraseNl =
                                "De spelers van het andere team moeten zich buiten de vrije worplijn bevinden tot de bal in het spel is.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Играчи противничке екипе морају остати изван линије слободног бацања, док лопта не буде у игри",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "The players from the opponents’ team must remain outside the goal-area line and 3 metres away from the position where the goalkeeper executes the goalkeeper throw.",
                            PhraseNl =
                                "De spelers van het andere teammoeten zich buiten de doelgebied lijn blijven op 3 meter van de plaats waar de doelverdediger de uitworp uitvoert.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Играчи противничке екипе морају бити изван линије голмановог простора, три метра удаљени од места са кога голман изводи голманово бацање",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "The players from the opponents’ team are allowed to touch the ball before it has crossed the goal-area line.",
                            PhraseNl =
                                "Het is de spelers van het andere team toegestaan de bal aan te raken voordat deze de doelgebied lijn overschreden heeft.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Играчима противничке екипе је дозвољено да додирну лопту пре него што она пређе линију голмановог простора",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "The goalkeeper cannot score an own goal when he is executing a goalkeeper throw.",
                            PhraseNl =
                                "De doelverdediger kan bij de uitvoering van een uitworp geen doelpunt in eigen doel scoren.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Голман не може да постигне у “властити гол “, када изводи голманово бацање",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "The goalkeeper cannot score a direct goal against the opponents with a goalkeeper throw.",
                            PhraseNl =
                                "De doelverdediger kan bij een uitworp geen direct doelpunt in het doel van de tegenstrever scoren.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Голман не може дати директно гол противнику из голмановог бацања",
                            AnswerNumber = "e"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "While executing a goalkeeper throw, the goalkeeper is not allowed to touch the goal-area line.",
                            PhraseNl =
                                "De doelverdediger mag bij de uitvoering van de uitworp de doelgebied lijn niet raken.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Голману није дозвољено да додирује линију голмановог простора за време извођења голмановог бацања",
                            AnswerNumber = "f"
                        }
                    ]
                }
            ]
        };
    }
}
