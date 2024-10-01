using IHF.Rules.Questions.Infrastructure.DataSeed.Models;

namespace IHF.Rules.Questions.Infrastructure.DataSeed;

public static partial class Rules
{
    public static RuleDto GetRule15()
    {
        return new RuleDto
        {
            Name =
                "General Instructions on the Execution of the Throws (Throw-Off, Throw-In, Goalkeeper Throw, Free Throw and 7-Metre Throw)",
            NameNl =
                "Algemene Richtlijnen voor de Uitvoering van de Worpen (Beginworp, Inworp, Uitworp, Vrije Worp, 7m-worp)",
            NameFr =
                "Instructions Générales pour l’Exécution des Jets (Engagement, Remise en jeu, Renvoi, Jet Franc, Jet de 7 mètres)",
            NameSvn = "Navodila Za Izvajanje Metov",
            NameDe = "Allgemeine Anweisungen zur Ausführung der Würfe (Anwurf, Einwurf, Abwurf, Freiwurf, 7-m-Wurf)",
            NameSrb = "Општи прописи за извођење бацања (почетно, голманово и слободно бацање, аут и седмерац)",
            RuleNumber = "15",
            Questions =
            [
                new QuestionDto
                {
                    Phrase =
                        "When carrying out a goalkeeper throw, goalkeeper WHITE 13 swings back the ball in a way that it goes beyond the goal line between the goalposts. Correct decision?",
                    PhraseNl =
                        "Bij het uitvoeren van een uitworp, zwiert doelverdediger WIT13 de bal naar achter op een wijze dat de bal de doellijn overschrijdt tussen de doelpalen. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Изводећи голманово бацање, голман БЕЛИ 13 замахне, држећи лопту, тако да она пређе иза гол линије, између статива. Исправна одлука?",
                    QuestionNumber = "15.1",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Game continues without interruption",
                            PhraseNl = "Verder spelen zonder onderbreking",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Игра се наставља без прекида",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Goalkeeper throw for WHITE team with whistle signal",
                            PhraseNl = "Uitworp voor team WIT na fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Голманово бацање за БЕЛУ екипу после звучног сигнала",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Goal for BLACK team",
                            PhraseNl = "Doelpunt voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Гол за ЦРНУ екипу",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team",
                            PhraseNl = "Vrije worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за ЦРНУ екипу",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "20 seconds before the end of the match, WHITE team is leading 20:19. Goalkeeper WHITE 12 takes his time executing a goalkeeper throw, bouncing the ball back and forth in the goal area. Correct decision?",
                    PhraseNl =
                        "20 seconden voor het einde van de speeltijd, leidt team WIT met 20:19. Doelverdediger WIT12 neemt zijn tijd om een uitworp uit te voeren, de bal vooruit en achteruit stuitend in het doelgebied. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "20 секунди пре краја утакмице резултат је 20:19 за БЕЛУ екипу. Голман БЕЛИ 12 одуговлачи са извођењем голмановог бацања, водећи лопту по голмановом простору. Исправна одлука?",
                    QuestionNumber = "15.2",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Time-out",
                            PhraseNl = "Time-out",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Тајм-аут",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw against WHITE team",
                            PhraseNl = "Vrije worp tegen team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање против БЕЛЕ екипе",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Whistle signal for goalkeeper throw",
                            PhraseNl = "Fluitsignaal voor uitworp",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Звучни сигнал за голманово бацање",
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
                            PhraseSrb = "2 минута искључења против БЕЛОГ 12",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "Show the forewarning signal for passive play",
                            PhraseNl = "Waarschuwingsteken voor passief spel tonen",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Показивање упозоравајућег сигнала за пасивну игру",
                            AnswerNumber = "e"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "The referees have given a free throw for BLACK team at the free-throw line of WHITE team. When all the players have assumed their correct positions, the referee whistles. Before the ball has left the thrower’s hand, two of his teammates cross the free-throw line of WHITE team. Correct decision?",
                    PhraseNl =
                        "De scheidsrechters hebben een vrije worp gegeven voor team ZWART aan de vrije worplijn van team WIT. Wanneer alle spelers correct opgesteld staan, fluiten de scheidsrechters. Vooraleer de bal de hand van de werper verlaten heeft, overschrijden twee van zijn medespelers de vrije worplijn van team WIT. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Судије су досудиле слободно бацање за ЦРНУ екипу на линији слободног бацања БЕЛЕ екипе. Када су сви играчи заузели исправну (дозвољену) позицију, судија је свирао. Пре него што је лопта напустила руку извођача, двојица његових саиграча су прешла линију слободног бацања БЕЛЕ екипе. Исправна одлука?",
                    QuestionNumber = "15.3",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Repetition of the free throw for BLACK team",
                            PhraseNl = "Herhaling van de vrije worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Понављање слободног бацања за ЦРНУ екипу",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team",
                            PhraseNl = "Vrije worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "With restart signal",
                            PhraseNl = "Met fluitsignaal voor de herneming",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Са звучним сигналом",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Without restart signal",
                            PhraseNl = "Zonder fluitsignaal voor de herneming",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Без звучног сигнала",
                            AnswerNumber = "d",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "Goalkeeper WHITE 12 is standing in the goal area with the ball in his hand and ready to execute a goalkeeper throw. BLACK 6 plays the ball away from WHITE 12 with an open hand. Correct decision?",
                    PhraseNl =
                        "Doelman team WIT12 staat met de bal in de hand in het doelgebied, klaar om een uitworp uit te voeren. Aanvaller ZWART6 speelt met open hand de bal weg. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Голман БЕЛИ 12 стоји у голмановом простору са лоптом у руци, спреман да изведе голманово бацање. ЦРНИ 6 му избија лопту отвореним дланом. Исправна одлука?",
                    QuestionNumber = "15.4",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Goalkeeper throw for WHITE team",
                            PhraseNl = "Uitworp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Голманово бацање за БЕЛУ екипу",
                            AnswerNumber = "a"
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
                            Phrase = "Goalkeeper throw after whistle signal",
                            PhraseNl = "Herhaling van de uitworp met fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Голманово бацање после звучног сигнала",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for BLACK 6",
                            PhraseNl = "2-minuten uitsluiting voor ZWART6",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Искључење на 2 минута за ЦРНОГ 6",
                            AnswerNumber = "d",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "A throw-in is awarded to WHITE team. WHITE 8 executes the throw-in as a direct shot on goal. The ball hits the goalpost and bounces back to WHITE 8, who catches the ball and scores a goal. Correct decision?",
                    PhraseNl =
                        "Aan team WIT werd een inworp toegekend. WIT8 voert de inworp uit als een directe worp op doel. De bal treft de doelpaal en springt terug naar WIT8, die hem vangt en in het doel werpt. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Аут је досуђен за БЕЛУ екипу. БЕЛИ 8 изводи аут као директан шут на гол. Лопта погађа стативу и враћа се до БЕЛОГ 8 који хвата лопту и постиже гол. Исправна одлука?",
                    QuestionNumber = "15.5",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Goalkeeper throw for BLACK team",
                            PhraseNl = "Uitworp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Голманово бацање за ЦРНУ екипу",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Goal for WHITE team",
                            PhraseNl = "Doelpunt voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Гол за БЕЛУ екипу",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Throw-in is retaken after whistle signal",
                            PhraseNl = "Herhaling van de inworp met fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Понављање аута након звучног сигнала",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team",
                            PhraseNl = "Vrije worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за ЦРНУ екипу",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "Goalkeeper BLACK 12 has saved a shot on goal. He wants to immediately start a counter-attack, but drops the ball in a way that it crosses the goal line into the goal of BLACK team. Correct decision?",
                    PhraseNl =
                        "Doelman ZWART12 stopt een worp op doel. Hij wil onmiddellijk een tegenaanval inzetten, maar laat de bal vallen zo dat deze de doellijn overschrijdt in het doel van team ZWART.Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Голман ЦРНИ 12 је одбранио шут на гол и жели брзо да започне контранапад. При томе испушта лопту и она прелази гол линију и улази у гол ЦРНЕ екипе. Исправна одлука?",
                    QuestionNumber = "15.6",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Goal for WHITE team",
                            PhraseNl = "Doelpunt voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Гол за БЕЛУ екипу",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Repeat the goalkeeper throw after whistle signal",
                            PhraseNl = "Uitworp hernemen na fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Понављање голмановог бацања просле звучног сигнала",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Throw-in for WHITE team",
                            PhraseNl = "Inworp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Аут за БЕЛУ екипу",
                            AnswerNumber = "c"
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
                        "WHITE 6 executes a throw-in in the direction of his goalkeeper. Goalkeeper WHITE 1 notices the ball too late, and the ball crosses the goal line. Correct decision?",
                    PhraseNl =
                        "WIT6 voert een inworp uit in de richting van zijn eigen doelverdediger. Doelverdediger WIT1 bemerkt dit te laat, waardoor de bal in het doel belandt. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "БЕЛИ 6 изводи аут у правцу свог голмана. Голман БЕЛИ 1 прекасно уочава лопту и она улази у гол. Исправна одлука?",
                    QuestionNumber = "15.7",
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
                            Phrase = "Repeat the throw-in for WHITE team after whistle signal",
                            PhraseNl = "Herhaling van de inworp voor team WIT met fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Понављање аута за БЕЛУ екипу, после звучног сигнала",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE 7 executes a throw-in, and the ball hits the referee. WHITE 7 picks up the ball again and throws it into the goal of BLACK team. Correct decision?",
                    PhraseNl =
                        "WIT7 voert de inworp uit en de bal treft de scheidsrechter. WIT7 neemt de bal weer op en werpt de bal in het doel van team ZWART. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Аут за БЕЛУ екипу. БЕЛИ 7 изводи аут и погоди судију. БЕЛИ 7 поново ухвати лопту и убаци је у гол ЦРНЕ екипе. Исправна одлука?",
                    QuestionNumber = "15.8",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Goalkeeper throw for BLACK team",
                            PhraseNl = "Uitworp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Голманово бацање за ЦРНУ екипу",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Goal for WHITE team",
                            PhraseNl = "Doelpunt voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Гол за БЕЛУ екипу",
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
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Repeat the throw-in after whistle signal",
                            PhraseNl = "Herhaling van de inworp na fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Понављање извођења аута после звучног сигнала",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team",
                            PhraseNl = "Vrije worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу",
                            AnswerNumber = "e"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "There is a free throw for WHITE team. When everyone stands correctly, WHITE 10 puts the ball down to give some instructions. BLACK 7 quickly takes the ball and starts a counter-attack. Correct decision?",
                    PhraseNl =
                        "Vrije worp voor team WIT. Na een correcte opstelling van alle spelers legt WIT10 de bal neer, om enkele aanwijzingen te geven. ZWART7 neemt de bal snel op en gaat in tegenaanval. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Слободно бацање за БЕЛУ екипу. Кад сви играчи исправно стоје, БЕЛИ 10 спусти лопту ради давања упутства. ЦРНИ 7 одмах уочава ситуацију, узима лопту и започиње контранапад. Исправна одлука?",
                    QuestionNumber = "15.9",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Game continues without interruption",
                            PhraseNl = "Verder spelen zonder onderbreking",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Игра се наставља без прекида",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Repeat free throw for WHITE team after whistle signal",
                            PhraseNl = "Hernemen vrije worp voor team WIT na fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Понављање слободног бацања после звучног сигнала",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team, warning for BLACK 7",
                            PhraseNl = "Vrije worp voor team WIT, waarschuwing voor ZWART7",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу и опомена за ЦРНОГ 7",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team, 2-minute suspension for BLACK 7",
                            PhraseNl = "Vrije worp voor team WIT, 2-minuten uitsluiting voor ZWART7",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу и 2 минута искључења против ЦРНОГ 7",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "BLACK 9 wants to execute a free throw, but WHITE 11 is only two metres away from the ball and tries to delay the throw. Correct decision?",
                    PhraseNl =
                        "ZWART9 wil een vrije worp uitvoeren maar WIT11 staat slechts op 2 meter afstand van de bal en probeert de uitvoering te belemmeren. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "ЦРНИ 9 жели да изведе слободно бацање, али БЕЛИ 11 стоји само 2 метра даље од лопте и покушава да омете извођење бацања. Исправна одлука?",
                    QuestionNumber = "15.10",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "Personal punishment against WHITE 11, free throw for BLACK team after whistle signal",
                            PhraseNl =
                                "Persoonlijke bestraffing voor WIT11, vrije worp voor team ZWART na fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Лична казна против БЕЛОГ 11, слободно бацање за ЦРНУ екипу после звучног сигнала",
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
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу после звучног сигнала",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 11",
                            PhraseNl = "2-minuten uitsluiting voor WIT11",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења против БЕЛОГ 11",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Correct the position of WHITE 11 and free throw after whistle signal",
                            PhraseNl = "Positie van WIT11 corrigeren en vrije worp na fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Корекција положаја БЕЛОГ 11 и слободно бацање после звучног сигнала",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "There is a free throw for BLACK team at the free-throw line of WHITE team. The referee overlooks that BLACK 8 is in a position between the free-throw line and the goal-area line. BLACK 8 receives the ball and scores. Correct decision?",
                    PhraseNl =
                        "Vrije worp voor team ZWART aan de vrije worplijn van team WIT. De scheidsrechters zien over het hoofd dat speler ZWART8 zich tussen de doelgebied lijn en de vrije worplijn bevindt. ZWART8 krijgt de bal toegespeeld en scoort. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Слободно бацање за ЦРНУ екипу са линије слободног бацања БЕЛЕ екипе. Судије превиде да се ЦРНИ 8 налази између линије слободног бацања и линије голмановог простора. ЦРНИ 8 добије лопту и постигне гол. Исправна одлука?",
                    QuestionNumber = "15.11",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Repeat the free throw for BLACK team after whistle signal",
                            PhraseNl = "Hernemen van de vrije worp voor team ZWART na fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Понављање слободног бацања за ЦРНУ екипу после звучног сигнала",
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
                            Phrase = "Goal for BLACK team",
                            PhraseNl = "Doelpunt voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Гол за ЦРНУ екипу",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Warning for BLACK 8",
                            PhraseNl = "Waarschuwing voor ZWART8",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Опомена за ЦРНОГ 8",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "Goalkeeper BLACK 12 executes a goalkeeper throw towards the goal of WHITE team. No player from either team touches the ball, and it enters the goal of WHITE team. Correct decision?",
                    PhraseNl =
                        "Doelman ZWART12 voert een uitworp uit in de richting van het doel van de team WIT. Geen enkele speler van een van de teams raakt de bal en hij gaat in het doel van team WIT. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Голман ЦРНИ 12 изводи голманово бацање у правцу гола БЕЛЕ екипе. Ниједан играч обе екипе не додирне лопту и она уђе у гол БЕЛЕ екипе. Исправна одлука?",
                    QuestionNumber = "15.12",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Goalkeeper throw for WHITE team",
                            PhraseNl = "Uitworp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Голманово бацање за БЕЛУ екипу",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Throw-in for WHITE team",
                            PhraseNl = "Inworp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Аут за БЕЛУ екипу",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Goal for BLACK team",
                            PhraseNl = "Doelpunt voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Гол за ЦРНУ екипу",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Warning for BLACK 12 for unsportsmanlike conduct",
                            PhraseNl = "Waarschuwing voor doelman ZWART12 wegens onsportief gedrag",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Опомена за ЦРНОГ 12 због неспортског понашања",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE 5 has already received a warning and two 2-minute suspensions. When BLACK team is carrying out a free throw, he interferes with the execution of the throw by not keeping his distance. This is the first time he does that. Correct decision?",
                    PhraseNl =
                        "Speler WIT5 heeft reeds een waarschuwing en twee 2-minuten uitsluitingen gekregen. Wanneer team ZWART een vrije worp uitvoert interfereert hij met de uitvoering van de worp door zijn afstand niet te houden. Dit is de eerste keer dat hij dit doet. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "БЕЛИ 5 је већ добио опомену и два искључења на 2 минута. Када ЦРНА екипа изводи слободно бацање, БЕЛИ 5 се први пут не придржава прописане удаљености. Исправна одлука?",
                    QuestionNumber = "15.13",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Warning for WHITE 5",
                            PhraseNl = "Waarschuwing voor WIT5",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Опомена за БЕЛОГ 5",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "No punishment",
                            PhraseNl = "Geen bestraffing",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Нема казне",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Third 2-minute suspension for WHITE 5 and disqualification (red card shown by the referees)",
                            PhraseNl =
                                "Derde 2-minuten uitsluiting voor WIT5 en diskwalificatie (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Треће искључење на 2 минута против БЕЛОГ 5 и дисквалификација (црвени картон показан од стране судија)",
                            AnswerNumber = "c",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "Shortly before the end of the game, WHITE team is leading 24:23. A free throw is awarded for WHITE team about one metre outside the free-throw line of BLACK team. All players are in a correct position, and the referee whistles for the execution of the free throw. WHITE 10, who is executing the free throw, takes one step before the ball has left his hand. Correct decision?",
                    PhraseNl =
                        "Kort voor het einde van de wedstrijd, leidt team WIT met 24-23. Een vrije worp wordt toegekend aan team WIT op ongeveer 1 meter buiten de vrije worplijn van team ZWART. Alle spelers hebben de juiste plaats ingenomen en de scheidsrechter fluit voor de uitvoering van de vrije worp. WIT10, die de worp uitvoert, neemt een stap vooraleer de bal zijn hand verlaten heeft. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Мало пре краја утакмице резултат је 24:23 у корист БЕЛЕ екипе. Слободно бацање за БЕЛУ екипу око једног метра изван линије слободног бацања ЦРНЕ екипе. Сви играчи одмах заузимају исправан положај и судија даје знак за извођење слободног бацања. БЕЛИ 10 који изводи слободно бацање направи један корак пре него што лопта напусти његову руку. Исправна одлука?",
                    QuestionNumber = "15.14",
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
                            Phrase = "Time-out",
                            PhraseNl = "Time-out",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Тајм-аут",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 10",
                            PhraseNl = "2-minuten uitsluiting voor WIT10",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења против БЕЛОГ 10",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team",
                            PhraseNl = "Vrije worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за ЦРНУ екипу",
                            AnswerNumber = "d",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE 14 wants to execute a free throw without whistle signal at the free-throw line of BLACK team. He and his teammates are standing in correct positions. Before the ball has left the hand of WHITE 14, both WHITE 13 and WHITE 15 run across the free-throw line towards the goal-area line. Correct decision?",
                    PhraseNl =
                        "WIT14 wil een vrije worp (zonder fluitsignaal) uitvoeren aan de vrije worp lijn van team ZWART. Hij bevindt zich (net als zijn medespelers) in de juiste positie. Voor de bal de hand van WIT14 heeft verlaten, lopen WIT13 en WIT15 over de vrije worplijn naar de doelgebied lijn. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "БЕЛИ 14 жели да изведе слободно бацање без знака пиштаљком, са линије слободног бацања ЦРНЕ екипе. Он и његови саиграчи стоје у исправним положајима. Пре него што је лопта напустила руку БЕЛОГ 14, БЕЛИ 13 и БЕЛИ 15 пређу преко линије слободног бацања према линији голмановог простора. Исправна одлука?",
                    QuestionNumber = "15.15",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Correction",
                            PhraseNl = "Correctie",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Корекција",
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
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу А, после звучног сигнала",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Game continues without interruption",
                            PhraseNl = "Verder spelen zonder onderbreking",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Игра се наставља без прекида",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team",
                            PhraseNl = "Vrije worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за ЦРНУ екипу",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "Goalkeeper BLACK 1 is executing a goalkeeper throw. The ball touches the referee and goes back to BLACK 1, who in the meantime has left the goal area. Correct decision?",
                    PhraseNl =
                        "Doelverdediger ZWART1 voert een uitworp uit. De bal raakt de scheidsrechter en gaat terug naar doelverdediger ZWART1 die ondertussen zijn doelgebied heeft verlaten. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Голман ЦРНИ 1 изводи голманово бацање. Лопта погоди судију и врати се ЦРНОМ 1, који је у међувремену изашао из голмановог простора. Исправна одлука?",
                    QuestionNumber = "15.16",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Game continues without interruption",
                            PhraseNl = "Verder spelen zonder onderbreking",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Игра се наставља без прекида",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Repeat the goalkeeper throw after whistle signal",
                            PhraseNl = "Herhaling van de uitworp na fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Понављање голмановог бацања после звучног сигнала",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team",
                            PhraseNl = "Vrije worp voorteam WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу",
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
                            PhraseSrb = "Слободно бацање за ЦРНУ екипу, после звучног сигнала",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "While executing a free throw, BLACK 11 swings back his arm while moving the ball completely over the sideline. Correct decision?",
                    PhraseNl =
                        "Bij de uitvoering van een vrije worp, beweegt ZWART11 zijn arm met de bal volledig over de zijlijn. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "За време извођења слободног бацања, ЦРНИ 11 замахује руком уназад док се лопта налази комплетно изван аут линије. Исправна одлука?",
                    QuestionNumber = "15.17",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Game continues without interruption",
                            PhraseNl = "Verder spelen zonder onderbreking",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Игра се наставља без прекида",
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
                            Phrase = "Throw-in for WHITE team",
                            PhraseNl = "Inworp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Аут за БЕЛУ екипу",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team, verbal caution for BLACK 11",
                            PhraseNl = "Vrije worp voor team WIT en verbale vermaning voor ZWART11",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу и упозорење ЦРНОМ 11",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "Goalkeeper WHITE 1 stops the ball just in front of the goal line. When he tries to pass the ball to WHITE 4, the ball falls out of his hand and into his own goal. Correct decision?",
                    PhraseNl =
                        "Doelverdediger WIT1 stopt de bal net voor de doellijn. Wanneer hij de bal naar WIT4 wil werpen, valt de bal uit zijn hand en overschrijdt de eigen doellijn. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Голман БЕЛИ 1 зауставља лопту баш испред гол линије. Када покуша да дода лопту БЕЛОМ 4, лопта испадне из његове руке и уђе у гол. Исправна одлука?",
                    QuestionNumber = "15.18",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Goal for BLACK team",
                            PhraseNl = "Doelpunt voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Гол за ЦРНУ екипу",
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
                            Phrase = "7-metre throw for BLACK team",
                            PhraseNl = "7m-worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за ЦРНУ екипу",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Repeated goalkeeper throw for WHITE team after whistle signal",
                            PhraseNl = "Herneming van de uitworp voor team WIT na fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Поновљено голманово бацање за БЕЛУ екипу после звучног сигнала",
                            AnswerNumber = "d",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE team has a throw-off. The court referee gives the whistle signal for the execution. WHITE 13 takes the ball out of the hand of WHITE 9, who was standing ready to execute the throw. WHITE 13 does this because he saw that WHITE 7 and WHITE 3 are running into the half of the opponents and are in favourable positions. WHITE 13 throws the ball to WHITE 7, who scores a goal. Correct decision?",
                    PhraseNl =
                        "Team WIT neemt een beginworp. De veldscheidsrechter geeft het fluitsignaal voor de uitvoering van de worp. WIT13 neemt de bal uit de hand van WIT9 die klaar stond voor de uitvoering van de beginworp. WIT13 doet dit omdat hij ziet dat WIT7 en WIT3 in gunstige positie lopen op de speelveldhelft van de tegenstander. WIT13 gooit de bal naar WIT7 die een doelpunt scoort. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "БЕЛА екипа треба да изведе почетно бацање. Судија у пољу даје знак пиштаљком. БЕЛИ 13 узима лопту из руке БЕЛОГ 9, који стоји спреман да изведе бацање, зато што БЕЛИ 13 види да БЕЛИ 7 и БЕЛИ 3 трче на противничку половину и имају повољну позицију. БЕЛИ 13 баца лопту БЕЛОМ 7, који постиже гол. Исправна одлука?",
                    QuestionNumber = "15.19",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Goal for WHITE team",
                            PhraseNl = "Doelpunt voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Гол за БЕЛУ екипу",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Correction, repetition of the throw-off for WHITE team",
                            PhraseNl = "Correctie, herhaling van de beginworp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Корекција, понављање почетног бацања за БЕЛУ екипу",
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
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Verbal caution for WHITE 13",
                            PhraseNl = "Verbale waarschuwing voor WIT13",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Усмена опомена за БЕЛОГ 13",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "Verbal caution for WHITE 7 and WHITE 13",
                            PhraseNl = "Verbale waarschuwing voor WIT13 en WIT7",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Усмена опомена за БЕЛОГ 7 и БЕЛОГ 13",
                            AnswerNumber = "e"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "(Without throw-off area) The score is 30:30 with just four seconds left in the game. WHITE team scores to make it 31:30. BLACK team tries to take a quick throw-off. BLACK 10 stands with one foot behind the centre line and the other one just in front of it. Without a whistle signal, he throws the ball into the goal of WHITE team. The automatic signal from the public clock for the end of the game sounds. Correct decision?",
                    PhraseNl =
                        "(Zonder beginworp zone) De score is 30-30 op 4 seconden voor het wedstrijdeinde. Team WIT scoort op 30-31. Team ZWART wil een snelle beginworp uitvoeren. ZWART10 staat met één voet achter en met de andere net voor de middellijn. Zonder fluitsignaal werpt ZWART10 de bal in het doel van team WIT. Het automatisch signaal van de klok weerklinkt voor het einde van de wedstrijd. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "(Без простора за почетно бацање) Резултат је 30:30, четири секунде пре краја утакмице. БЕЛА екипа постиже гол за вођство 31:30. ЦРНА екипа жели брзо да изведе почетно бацање. ЦРНИ 10 стоји једном ногом иза средишње линије, а другом испред ње. Без звучног сигнала, он баца лопту, која иде у гол БЕЛЕ екипе. Аутоматски сигнал за крај утакмице се оглашава. Исправна одлука?",
                    QuestionNumber = "15.20",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Goal for BLACK team",
                            PhraseNl = "Doelpunt voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Гол за ЦРНУ екипу",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Repetition of the throw-off for BLACK team",
                            PhraseNl = "Hernemen van de beginworp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Понављање почетног бацања за ЦРНУ екипу",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Wait for the result of the throw",
                            PhraseNl = "Resultaat van de worp afwachten",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Сачекати резултат бацања",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Time-out",
                            PhraseNl = "Time-out",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Тајм-аут",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "The game is over; no goal",
                            PhraseNl = "Einde van het spel, geen doelpunt",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Утакмица је завршена; гол се не признаје",
                            AnswerNumber = "e",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "There is a free throw for WHITE team at the free-throw line of BLACK team. WHITE 7 executes the free throw and, like his teammates, he is standing correctly outside the free-throw line. The free throw is executed quickly without a whistle signal, but before the ball has left the hand of WHITE 7, both WHITE 9 and WHITE 18 cross the free-throw line. Correct decision?",
                    PhraseNl =
                        "Vrije worp voor team WIT aan de vrije worplijn van team ZWART. WIT7 voert de vrije worp uit terwijl hij, zoals zijn medespelers, correct buiten de vrije worplijn staat. De vrije worp wordt snel uitgevoerd zonder fluitsignaal, maar vooraleer de bal de hand van WIT7 verlaten heeft overschrijden zowel WIT9 als WIT18 de vrije worplijn. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Слободно бацање за БЕЛУ екипу са линије слободног бацања ЦРНЕ екипе. БЕЛИ 7 изводи слободно бацање и жели да дода лопту саиграчу, који стоји исправно, изван линије слободног бацања. Слободно бацање је изведено брзо, без знака пиштаљком, али пре него што је лопта напустила руку БЕЛОГ 7, два играча, БЕЛИ 9 и БЕЛИ 18, пређу преко линије слободног бацања. Исправна одлука?",
                    QuestionNumber = "15.21",
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
                            Phrase = "Correction",
                            PhraseNl = "Correctie",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Корекција",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team after whistle signal",
                            PhraseNl = "Vrije worp voor team WIT na fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу после звучног сигнала",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team; warning for WHITE 9 and WHITE 18",
                            PhraseNl = "Vrije worp voor team ZWART; waarschuwing voor WIT9 of WIT18",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Опомена за ЦРНУ екипу; Опомене за БЕЛОГ 9 и БЕЛОГ 18",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase = "From which of the following throws is it not possible to score an own goal?",
                    PhraseNl = "Met welke van de volgende worpen kan men niet scoren in het eigen doel?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Из којег од наведених бацања није могуће постићи ауто-гол?",
                    QuestionNumber = "15.22",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Goalkeeper throw",
                            PhraseNl = "Uitworp",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Голманово бацање",
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
                            PhraseSrb = "Слободно бацање",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Throw-in",
                            PhraseNl = "Inworp",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Аут",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Throw-off",
                            PhraseNl = "Beginworp",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Почетно бацање",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "BLACK 4 assumes a correct position to execute a throw-in that has been awarded to his team. As he cannot find a teammate to whom he could pass the ball he bounces the ball one time inside the sideline. Correct decision?",
                    PhraseNl =
                        "Speler ZWART4 staat correct opgesteld voor de uitvoering van een inworp die aan zijn team is toegekend. Omdat hij niet direct een aanspeelbare medespeler ziet, tipt hij de bal éénmaal binnen het speelveld. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "ЦРНИ 4 има исправну позицију за извођење аута, који је досуђен за његову екипу. Пошто није видео слободног саиграча коме би додао лопту, он удари лоптом о под унутар терена и поново је ухвати. Исправна одлука?",
                    QuestionNumber = "15.23",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team without whistle signal",
                            PhraseNl = "Vrije worp voor team WIT zonder fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу, без звучног сигнала",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Throw-in for WHITE team after restart signal",
                            PhraseNl = "Inworp voor team WIT na herstart fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Аут за БЕЛУ екипу, после звучног сигнала",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Repetition of the throw-in for BLACK team after whistle signal",
                            PhraseNl = "Hernemen van de inworp voor team ZWART na fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Понављање аута за ЦРНУ екипу, после звучног сигнала",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team after whistle signal",
                            PhraseNl = "Vrije worp voor team ZWART na fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за ЦРНУ екипу, после звучног сигнала",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE team receives a free throw. Without a whistle signal from the referees, WHITE 9 executes the free throw very quickly while jumping. The ball goes to WHITE 4, who finds himself completely unmarked in front of the goal of BLACK team. Correct decision?",
                    PhraseNl =
                        "Team WIT krijgt een vrije worp. Zonder fluitsignaal van de scheidsrechters voert WIT9 de worp in sprong uit. De bal gaat naar WIT4 die zich volledig vrij voor het doel van team ZWART bevindt. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "За БЕЛУ екипу је досуђено слободно бацање које изводи БЕЛИ 9, веома брзо из скока и без звучног сигнала. Лопта долази до БЕЛОГ 4, који је потпуно сам испред гола ЦРНЕ екипе. Исправна одлука?",
                    QuestionNumber = "15.24",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Game continues without interruption",
                            PhraseNl = "Verder laten spelen zonder onderbreking",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Игра се наставља без прекида",
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
                            Phrase = "Repetition of the free throw for WHITE team after whistle signal",
                            PhraseNl = "Correctie van de vrije worp voor team WIT na fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Понављање слободног бацања за БЕЛУ екипу после звучног сигнала",
                            AnswerNumber = "c",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE team receives a free throw. Without a whistle signal from the referees, WHITE 5 very quickly executes the free throw while running fast. WHITE 5 intends to play the ball to WHITE 4, but BLACK 3 intercepts the ball and finds himself unmarked in front of the goal of WHITE team. Correct decision?",
                    PhraseNl =
                        "Team WIT krijgt een vrije worp. Zonder fluitsignaal van de scheidsrechters voert WIT5 zeer snel de worp al lopend uit. De intentie van WIT5 was om de bal naar WIT4 te spelen, maar ZWART3 onderschept de bal en bevindt zich nu volledig vrij voor het doel van team WIT. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "За БЕЛУ екипу је досуђено слободно бацање које БЕЛИ 5 изводи врло брзо, у трку и без звучног сигнала. БЕЛИ 5 жели да дода лопту БЕЛОМ 4, али ЦРНИ 3 пресеца додавање и налази се сам испред гола БЕЛЕ екипе. Исправна одлука?",
                    QuestionNumber = "15.25",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Game continues without interruption",
                            PhraseNl = "Verder laten spelen zonder onderbreking",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Игра се наставља без прекида",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Repetition of the free throw after whistle signal",
                            PhraseNl = "Hernemen van de vrije worp na fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Понављање слободног бацања после звучног сигнала",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Repetition of the free throw and progressive punishment for BLACK 3",
                            PhraseNl = "Hernemen van de vrije worp en progressieve bestraffing voor ZWART3",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Понављање слободног бацања и прогресивна казна против ЦРНОГ 3",
                            AnswerNumber = "c"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "BLACK team is ready to execute a free throw without whistle signal. BLACK 8 executes the throw with both feet and his left hand in contact with the floor. BLACK 6 receives the ball and scores a goal. What is the correct decision?",
                    PhraseNl =
                        "Team ZWART staat klaar om een vrije worp zonder fluitsignaal uit te voeren. ZWART8 voert de worp uit met beide voeten en zijn linker hand in contact met de vloer. ZWART6 krijgt de bal en scoort een doelpunt. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "ЦРНА екипа је спремна да изведе слободно бацање без звиждука. ЦРНИ 8 изводи бацање тако да су му оба стопала и лева шака у контакту са подлогом. ЦРНИ 6 прихвата лопту и постиже гол. Која је исправна одлука?",
                    QuestionNumber = "15.26",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Goal for BLACK team",
                            PhraseNl = "Doelpunt voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Гол за ЦРНУ екипу",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Correction, repetition of the free throw after whistle signal from the referees",
                            PhraseNl = "Correctie, herneming van de vrije worp na fluitsignaal van de scheidsrechters",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Корекција, понављање извођења слободног бацања након звиждука",
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
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу",
                            AnswerNumber = "c"
                        }
                    ]
                }
            ]
        };
    }
}
