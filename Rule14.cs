using IHF.Rules.Questions.Infrastructure.DataSeed.Models;

namespace IHF.Rules.Questions.Infrastructure.DataSeed;

public static partial class Rules
{
    public static RuleDto GetRule14()
    {
        return new RuleDto
        {
            Name = "The 7-Metre Throw",
            NameNl = "De 7m-worp",
            NameFr = "Le Jet de 7 mètres",
            NameSvn = "7-Metrovka",
            NameDe = "Der 7-m-Wurf",
            NameSrb = "Седмерац",
            RuleNumber = "14",
            Questions =
            [
                new QuestionDto
                {
                    Phrase =
                        "The score is 20:20. BLACK 7 intercepts a pass from WHITE team and starts a counter-attack. No court player from WHITE team is able to stop him. A spectator runs onto the court and pulls BLACK 7 down to the ground. This leads to tumultuous scenes with even more spectators on the court. Team official A from BLACK team knocks down the spectator who has stopped BLACK 7. Correct decision?",
                    PhraseNl =
                        "De stand is 20:20. ZWART7 onderschept een pas van team WIT, en loopt in tegenaanval. Geen enkele veldspeler van team WIT is in staat om hem te stoppen. Een toeschouwer loopt het speloppervlak op en trekt ZWART7 tegen de grond. Dit leidt tot tumultueuze scènes met nog meer toeschouwers op het speelveld. Team official A van team ZWART slaat de toeschouwer die ZWART7 neergehaald heeft, tegen de grond. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Резултат је 20:20. ЦРНИ 7 пресече додавање БЕЛЕ екипе и започиње контранапад, а ниједан играч БЕЛЕ екипе не покушава да га следи. Утрчава гледалац и обори ЦРНОГ 7, што доводи до бучних сцена са гледаоцима на игралишту. Званичник А ЦРНЕ екипе нокаутира гледаоца који је зауставио ЦРНОГ 7. Исправна одлука?",
                    QuestionNumber = "14.1",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Suspend the match permanently",
                            PhraseNl = "Wedstrijd definitief schorsen",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Трајни прекид утакмице",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Time-out; 7-metre throw for BLACK team; disqualification of team official A from BLACK team; reduce BLACK team on the court by 1 player for 2 minutes; written report (red and blue cards shown by the referees)",
                            PhraseNl =
                                "Time-out, 7m-worp voor team ZWART, diskwalificatie van team official A van team ZWART, reduceren van team ZWART op het speelveld met 1 speler voor 2 minuten, schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Тајм-аут; седмерац за ЦРНУ екипу; дисквалификација званичника А ЦРНЕ екипе; редукција ЦРНЕ екипе за једног играча у пољу за игру на 2 минута; писани извештај (црвени и плави картон показани од стране судија)",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Time-out; 7-metre throw for BLACK team; disqualification of team official A from BLACK team; reduce BLACK team on the court by 1 player for 2 minutes (red card shown by the referees)",
                            PhraseNl =
                                "Time-out, 7m-worp voor team ZWART, diskwalificatie van team official A van team ZWART, reduceren van team ZWART op het speelveld met 1 speler voor 2 minuten (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Тајм-аут; седмерац за ЦРНУ екипу; дисквалификација званичника А ЦРНЕ екипе; редукција ЦРНЕ екипе за једног играча у пољу за игру на 2 минута (црвени картон показан од стране судија)",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Time-out; 7-metre throw for BLACK team; 2-minute suspension of team official A from BLACK team; reduce BLACK team on the court by 1 player for 2 minutes",
                            PhraseNl =
                                "Time-out, 7m-worp voor team ZWART, 2-minuten uitsluiting van team official A van team ZWART, reduceren van team ZWART op het speelveld met 1 speler voor 2 minuten",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Тајм-аут; седмерац за ЦРНУ екипу; 2 минута искључења за званичника А ЦРНЕ екипе, редукција ЦРНЕ екипе за једног играча у пољу за игру на 2 минута;",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "There is a throw-in for BLACK team. BLACK 7 executes the throw-in correctly and notices that goalkeeper WHITE 12 is standing far in front of his goal. BLACK 7 throws the ball directly in the direction of the empty goal. Court player WHITE 3 enters the goal area to stop the ball. Correct decision?",
                    PhraseNl =
                        "Inworp voor team ZWART. ZWART7 voert de inworp correct uit en ziet dat doelman WIT12 ver voor zijn doel staat. ZWART7 werpt de bal rechtstreeks in de richting van het lege doel. Veldspeler WIT3 betreedt het doelgebied en stopt de bal. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Аут за ЦРНУ екипу. ЦРНИ 7 исправно изводи аут и уочи да голман БЕЛИ 12 стоји далеко испред свог гола. ЦРНИ 7 упути лопту директно у правцу празног гола, а играч у пољу БЕЛИ 3 улази у голманов простор и заустави лопту. Исправна одлука?",
                    QuestionNumber = "14.2",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Goal",
                            PhraseNl = "Doelpunt",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Гол",
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
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Progressive punishment against WHITE 3",
                            PhraseNl = "Progressieve bestraffing voor WIT3",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Прогресивна казна против БЕЛОГ 3",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "Direct 2-minute suspension for WHITE 3",
                            PhraseNl = "Directe 2-minuten uitsluiting voor WIT3",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Искључење на 2 минута за БЕЛОГ 3",
                            AnswerNumber = "e",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE 4 executes a 7-metre throw and hits the goalpost. The ball bounces back to WHITE 4 without touching any teammate or opponent. He throws the ball into the goal. Correct decision?",
                    PhraseNl =
                        "WIT4 neemt een 7m-worp en treft de paal. De bal springt naar terug naar WIT4, zonder een medespeler of tegenspeler te raken. WIT4 werpt de bal in het doel. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Изводећи седмерац, БЕЛИ 4 погоди стативу. Лопта се одбије назад до БЕЛОГ 4, а да је није додирнуо ниједан од саиграча или противничких играча. Он убаци лопту у гол. Исправна одлука?",
                    QuestionNumber = "14.3",
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
                            Phrase = "Goalkeeper throw for BLACK team",
                            PhraseNl = "Uitworp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Голманово бацање за ЦРНУ екипу",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Goal for WHITE team",
                            PhraseNl = "Doelpunt voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Гол за БЕЛУ екипу",
                            AnswerNumber = "c",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE 3 moves around BLACK 4 at the free-throw line of BLACK team. After taking three steps, he wants to take a shot on goal, but is pushed by BLACK 4. Immediately after taking a fourth step he scores a nice goal. No other player from BLACK team would have been able to intervene. Correct decision?",
                    PhraseNl =
                        "WIT3 omspeelt ZWART4 aan de vrije worplijn van team ZWART. Na de derde pas wil hij naar doel werpen, maar wordt door ZWART4 geduwd. Onmiddellijk na de 4e pas gezet te hebben, scoort hij een mooi doelpunt. Geen enkele andere speler van team ZWART zou in staat geweest zijn om tussen te komen. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "БЕЛИ 3 се креће око ЦРНОГ 4 на линији слободног бацања ЦРНЕ екипе. После трећег корака он жели да упути лопту ка голу, али га гурне ЦРНИ 4. Одмах после четвртог корака он постиже леп гол. Ниједан од играча ЦРНЕ екипе није у могућности да интервенише. Исправна одлука?",
                    QuestionNumber = "14.4",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Advantage and therefore goal for WHITE team",
                            PhraseNl = "Voordeel en dus doelpunt voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Предност и према томе и гол",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Progressive punishment against BLACK 4",
                            PhraseNl = "Progressieve bestraffing van ZWART4",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Прогресивна казна против ЦРНОГ 4",
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
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for WHITE team",
                            PhraseNl = "7m-worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за БЕЛУ екипу",
                            AnswerNumber = "d",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE 9 executes a 7-metre throw, and the ball enters the goal. However, before the ball left the thrower’s hand, WHITE 4 had crossed the free-throw line. Correct decision?",
                    PhraseNl =
                        "WIT9 voert een 7m-worp uit, en de bal gaat in het doel. Maar vooraleer de bal de hand van de werper heeft verlaten, heeft WIT4 de vrije worplijn overschreden. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "БЕЛИ 9 изводи седмерац и лопта улази у гол, али пре него што је лопта напустила руку извођача БЕЛИ 4 пређе линију слободног бацања. Исправна одлука?",
                    QuestionNumber = "14.5",
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
                            Phrase = "Repeat the 7-metre throw",
                            PhraseNl = "Hernemen van de 7m-worp",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Понављање седмерца",
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
                            Phrase = "Repeat the throw and warning for WHITE 4",
                            PhraseNl = "Hernemen van de worp en waarschuwing voor WIT4",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Понављање бацања и опомена за БЕЛОГ 4",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "BLACK 2 gets ready to execute a 7-metre throw after the referee’s whistle signal. At that moment, WHITE 5 crosses the free-throw line. Despite of WHITE 5’s action, BLACK 2 scores a goal. Correct decision?",
                    PhraseNl =
                        "ZWART2 staat na het fluitsignaal van de scheidsrechter klaar om een 7m-worp te werpen. Op dat ogenblik zet WIT5 een stap binnen de vrije worplijn. ZWART2 scoort desondanks een doelpunt. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "ЦРНИ 2 је спреман да изведе седмерац после судијског звучног сигнала. У том тренутку БЕЛИ 5 пређе линију слободног бацања. Упркос томе, ЦРНИ 2 постиже гол. Исправна одлука?",
                    QuestionNumber = "14.6",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Goal and disqualification of WHITE 5 (red card shown by the referees)",
                            PhraseNl = "Doelpunt en diskwalificatie WIT5 (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Гол и дисквалификација БЕЛОГ 5 (црвени картон показан од стране судија)",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Goal and 2-minute suspension for WHITE 5",
                            PhraseNl = "Doelpunt en 2-minuten uitsluiting voor WIT5",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Гол и 2 минута искључења за БЕЛОГ 5",
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
                            Phrase = "Repeated 7-metre throw and disqualification of WHITE 5",
                            PhraseNl = "Herneming van de 7m-worp en diskwalificatie voor WIT5",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Понављање седмерца и дисквалификација БЕЛОГ 5",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "While WHITE 6 is in possession of the ball and ready to execute a 7-metre throw, official A from BLACK team calls goalkeeper BLACK 12 to come off and be replaced. BLACK 12 is ready to follow this instruction. Correct decision?",
                    PhraseNl =
                        "Terwijl WIT6 staat klaar met de bal om een 7m-worp uit te voeren, roept official A van team ZWART de doelverdediger ZWART12 om te komen wisselen. Doelverdediger ZWART12 is klaar om deze instructie op te volgen. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "БЕЛИ 6 има лопту и спреман је да изведе седмерац, тада званичник А ЦРНЕ екипе позива голмана ЦРНОГ 12 да изађе и буде замењен. ЦРНИ 12 је спреман да га послуша. Исправна одлука?",
                    QuestionNumber = "14.7",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "No action",
                            PhraseNl = "Geen actie",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Ништа",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Warning for official A from BLACK team",
                            PhraseNl = "Waarschuwing voor official A van team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Опомена за званичника А ЦРНЕ екипе",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Warning for official A from BLACK team and BLACK 12",
                            PhraseNl = "Waarschuwing voor official A van team ZWART en ZWART12",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Опомена за званичника А ЦРНЕ екипе и ЦРНОГ 12",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Warning for BLACK 12",
                            PhraseNl = "Waarschuwing voor doelverdediger ZWART12",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Опомена за ЦРНОГ 12",
                            AnswerNumber = "d",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE 4 has taken a shot on BLACK team’s goal. The ball hits the goalpost and bounces back towards the playing area. WHITE 6 stands alone at the goal-area line and is ready to catch the ball. BLACK 4 clearly enters the goal area in order to push the ball over his team’s outer goal-line. Correct decision?",
                    PhraseNl =
                        "WIT4 heeft op het doel van team ZWART geworpen. De bal raakt de doelpaal en botst terug in de richting van het speelveld. WIT6 staat alleen aan de doelgebied lijn klaar om de bal te vangen. ZWART4 betreedt duidelijk het doelgebied om de bal achter zijn eigen buitendoellijn te duwen. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "БЕЛИ 4 је извео шут на гол ЦРНЕ екипе. Лопта је погодила стативу и враћа се у правцу поља за игру. БЕЛИ 6 стоји сам испред линије голмановог простора спреман да ухвати лопту. ЦРНИ 4 јасно улази у голманов простор и избацује лопту преко гол аут-линије. Исправна одлука?",
                    QuestionNumber = "14.8",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for WHITE team",
                            PhraseNl = "7-meter worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за БЕЛУ екипу",
                            AnswerNumber = "a",
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
                            AnswerNumber = "b"
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
                        },
                        new AnswerDto
                        {
                            Phrase = "Goalkeeper throw for BLACK team",
                            PhraseNl = "Uitworp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Голманово бацање за ЦРНУ екипу",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE 3 is executing a 7-metre throw. WHITE 5 crosses the free-throw line after the referee’s whistle, but before the ball has left WHITE 3’s hand. Correct decision?",
                    PhraseNl =
                        "WIT3 voert een 7m-worp uit, WIT5 overschrijdt de vrije worplijn nadat de scheidsrechter heeft gefloten maar voor de bal de hand van WIT3 heeft verlaten. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "БЕЛИ 3 изводи седмерац. БЕЛИ 5 пређе линију слободног бацања после судијског звиждука, али пре него што је лопта напустила руку извођача БЕЛОГ 3. Исправна одлука?",
                    QuestionNumber = "14.9",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Repeat the 7-metre throw",
                            PhraseNl = "Herhaling van de 7m-worp",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Понављање седмерца",
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
                            PhraseSrb = "Голманово бацање за ЦРНУ екипу",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Progressive punishment against WHITE 5",
                            PhraseNl = "Progressieve bestraffing voor WIT5",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Прогресивна казна против БЕЛОГ 5",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE 9 is standing completely unmarked at the goal-area line of the opponents, ready to receive the ball. This is noticed by WHITE 10, who plays a bounce pass through the goal area towards WHITE 9. This is noticed by BLACK 3, who clearly enters his own goal area to stop the ball, standing with both feet in the goal area. It is the second time in the game that he takes this action. Correct decision?",
                    PhraseNl =
                        "WIT9 staat volledig vrij aan de doelgebied lijn van de tegenstander, klaar om de bal te ontvangen. Dit wordt opgemerkt door WIT10 die de stuitbal door het doelgebied speelt naar WIT9 speelt. ZWART3 heeft dit opgemerkt en betreedt duidelijk zijn eigen doelgebied en stopt de bal terwijl hij met beide voeten in zijn doelgebied staat. Het is de tweede keer tijdens de wedstrijd dat hij dit doet. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "БЕЛИ 9 стоји потпуно сам испред линије голмановог простора противника, спреман да прими лопту. То је видео његов саиграч БЕЛИ 10, који му лопту додаје одбијањем кроз голманов простор. То је приметио ЦРНИ 3, који јасно улази у свој голманов простор и зауставља лопту, стојећи са обе ноге унутар голмановог простора. То је други пут у игри да он чини исту ствар. Исправна одлука?",
                    QuestionNumber = "14.10",
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
                            Phrase = "7-metre throw for WHITE team",
                            PhraseNl = "7m-worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за БЕЛУ екипу",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Progressive punishment for BLACK 3",
                            PhraseNl = "Progressieve bestraffing voor ZWART3",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Прогресивна казна против ЦРНОГ 3",
                            AnswerNumber = "c",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "Line player BLACK 10 legally blocks WHITE 2. When BLACK 10 gets ready to make his move, BLACK 4 plays a bounce pass into the open space where BLACK 10 could be able to break through. Before BLACK 10 can receive the ball, he is held back by WHITE 2, who grabs his shirt. Correct decision?",
                    PhraseNl =
                        "Cirkelspeler ZWART10 blokt WIT2 correct uit. Als ZWART10 zich klaarmaakt om zich te verplaatsen, gooit zijn ploegmaat ZWART4 een stuitbal in de opening waar ZWART10 zou kunnen doorbreken. Voor ZWART10 de bal kan aannemen, wordt hij tegengehouden door WIT2 die aan zijn truitje trekt. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Пивотмен ЦРНИ 10 правилно блокира БЕЛОГ 2. Када је ЦРНИ 10 спреман да крене, ЦРНИ 4 му баца лопту у празан простор, где би ЦРНИ 10 могао да се пробије. Пре него што ЦРНИ 10 ухвати лопту, БЕЛИ 2 га повлачи за дрес отпозади. Исправна одлука?",
                    QuestionNumber = "14.11",
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
                            Phrase = "7-metre throw for BLACK team, regardless of the positions of the opponents",
                            PhraseNl = "7m-worp voor team ZWART, ongeacht de posities van de tegenstanders",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за ЦРНУ екипу, без обзира на положај противника",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "7-metre throw for BLACK team, if no other player from WHITE team could legally stop BLACK 10 from shooting",
                            PhraseNl =
                                "7m-worp voor team ZWART, indien geen andere speler van team WIT in staat was om op correcte wijze ZWART10 te stoppen",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за ЦРНУ екипу, ако ниједан играч БЕЛЕ екипе не може на дозвољен начин да спречи ЦРНОГ 10 да шутира",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Progressive punishment for WHITE 2",
                            PhraseNl = "Progressieve bestraffing voor WIT2",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Прогресивна казна против БЕЛОГ 2",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Mandatory disqualification of WHITE 2 (red card shown by the referees)",
                            PhraseNl =
                                "Verplichte diskwalificatie voor WIT2 (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Обавезна дисквалификација БЕЛОГ 2 (црвени картон показан од стране судија)",
                            AnswerNumber = "e"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE 3 is in possession of the ball, running towards the goal of BLACK team in a counterattack resulting in a clear chance of scoring. While he executes a jump shot, there is a whistle signal from a spectator that distracts WHITE 3, so that he does not take a shot on goal. Instead he stops with the ball in the goal area. Correct decision?",
                    PhraseNl =
                        "WIT3 is in balbezit en loopt richting het doel van team ZWART in een tegenaanval die resulteert in een open doelkans. Terwijl hij een sprongworp uitvoert weerklinkt er een fluitsignaal vanuit de toeschouwers dat speler WIT3 verward zodat hij niet naar doel werpt. In plaats hiervan komt de speler tot stilstand in het doelgebied met de bal. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "БЕЛИ 3 има лопту и трчи у контранапад у правцу гола ЦРНЕ екипе. Када је био у скок шуту, чује се звиждук из публике, БЕЛИ 3 се збуни и не упути шут на гол. Уместо да шутне на гол, он стане са лоптом у голманов простор. Исправна одлука?",
                    QuestionNumber = "14.12",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team after whistle signal",
                            PhraseNl = "Vrije worp voor team ZWART met fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за ЦРНУ екипу, после звучног сигнала",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for WHITE team",
                            PhraseNl = "7m-worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за БЕЛУ екипу",
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
                        },
                        new AnswerDto
                        {
                            Phrase = "Goalkeeper throw for BLACK team after whistle signal",
                            PhraseNl = "Uitworp voor team ZWART na fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Голманово бацање за ЦРНУ екипу, после звучног сигнала",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Statement in the match report in conformity with the regulations of the respective federation.",
                            PhraseNl =
                                "Vermelding op het wedstrijdblad in overeenstemming met de reglementen van de respectievelijke federatie",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Изјава у записнику утакмице у складу са прописима надлежне федерације",
                            AnswerNumber = "e",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE team is running in a counter-attack, and the score is 26:26. WHITE 5 gets ready to take a shot on goal from the goal-area line of BLACK team. At the time, there is a whistle signal from the timekeeper, who indicates that the game is over. The referees determine that 20 seconds remain to be played. Correct decision?",
                    PhraseNl =
                        "Team WIT is in tegenaanval bij een stand van 26-26. WIT5 staat klaar aan de doelgebied lijn van ZWART om naar doel te werpen. Op dat ogenblik weerklinkt een fluitsignaal van de tijdwaarnemer om het einde van de wedstrijd aan te geven. De scheidsrechters stellen vast dat er nog 20 sec. te spelen zijn. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "БЕЛА екипа је у контранападу при резултату 26:26. БЕЛИ 5 је спреман да упути шут на гол и налази се сам на линији голмановог простора ЦРНЕ екипе. У исто време чује се сигнал мериоца времена, који показује да је утакмица завршена. Судије утврђују да је преостало још 20 секунди за игру. Исправна одлука?",
                    QuestionNumber = "14.13",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team at the timekeepers table.",
                            PhraseNl = "Vrije worp voor team WIT aan de wedstrijdtafel.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу код записничког стола",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for WHITE team.",
                            PhraseNl = "7m-worp voor team WIT.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за БЕЛУ екипу",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Statement in the match report in conformity with the regulations of the respective federation.",
                            PhraseNl =
                                "Vermelding op het wedstrijdblad in overeenstemming met de reglementen van de respectievelijke federatie.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Писани извештај у складу са прописима надлежне федерације",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team from where the ball was when the whistle signal came.",
                            PhraseNl = "Vrije worp voor WIT op de plaats waar de bal zich bij het fluitsignaal bevond.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу са места где се лопта налазила у тренутку звучног сигнала",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase = "Which of the following statements about the execution of a 7-metre throw are correct?",
                    PhraseNl =
                        "Welke van de volgende uitspraken met betrekking tot de uitvoering van een 7m zijn correct?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Које су од наведених константација, везаних за извођење седмерца, исправне?",
                    QuestionNumber = "14.14",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "The player executing the throw is allowed to stand up to one metre behind the 7-metre line.",
                            PhraseNl = "De uitvoerende speler mag tot één meter achter de 7m-lijn staan.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Играчу који изводи бацање дозвољено је да се одмакне до 1 метар иза линије седмерца",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "The referees must give a time-out, if the defending team is changing goalkeepers.",
                            PhraseNl =
                                "De scheidsrechters moeten een time-out geven wanneer het verdedigende team de doelverdediger wisselt.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Судије морају да дају тајм-аут ако одбрамбена екипа мења голмана",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "The goalkeeper shall be given a personal punishment, if he repeatedly crosses the goalkeeper’s restraining line.",
                            PhraseNl =
                                "Wanneer de doelverdediger herhaaldelijk de 4m-lijn overschrijdt, moet hij progressief bestraft worden.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Голману треба изрећи прогресивну казну ако више пута прелази линију 4 метра (ограничавајућу линију за голмана)",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "The players of the defending team must always be 3 metres away from the thrower.",
                            PhraseNl =
                                "De spelers van het verdedigende team moeten steeds 3 meter van de uitvoerende speler verwijderd zijn.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Играчи одбрамбене екипе морају увек бити 3 метра од извођача",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE 5 is in possession of the ball and jumps from the right corner into the goal area of BLACK team. He then collides with BLACK 11, who is standing with his arms up about 50cm inside the goal area. BLACK 11 has done this for the third time in the game. Correct decision?",
                    PhraseNl =
                        "WIT5 is in balbezit en springt vanuit de rechterhoek in het doelgebied. Hij botst daarbij op ZWART11, die ongeveer 50 cm in het doelgebied staat. Dit is de derde maal in die wedstrijd dat ZWART11 dit doet. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "БЕЛИ 5 ускаче са десног крила, са лоптом у руци, у голманов простор ЦРНЕ екипе и судара се са ЦРНИМ 11 који стоји подигнутих руку, око 50 центиметара унутар голмановог простора. Ово је трећи пут у току уткмице да ЦРНИ 11 чини исту ствар. Исправна одлука?",
                    QuestionNumber = "14.15",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for WHITE team",
                            PhraseNl = "7m-worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за БЕЛУ екипу",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Offensive foul against WHITE 5",
                            PhraseNl = "Aanvallende fout tegen WIT5",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Прекршај БЕЛОГ 5 у нападу",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for BLACK 11",
                            PhraseNl = "2-minuten uitsluiting voor ZWART11",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења против ЦРНОГ 11",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Warning for BLACK 11",
                            PhraseNl = "Waarschuwing voor ZWART11",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Опомена за ЦРНОГ 11",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE 6 is running in a counter-attack and has a clear chance of scoring, when the lights go out in the hall. Which of the following statements are correct?",
                    PhraseNl =
                        "WIT6 loopt in tegenaanval en heeft een open doelkans wanneer de verlichting in de sporthal uitvalt. Welke van de volgende uitspraken zijn van correct?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "БЕЛИ 6 трчи у контранапад и има јасну ситуацију за постизање гола, када се светла у хали угасе. Која је од следећих тврдњи тачна?",
                    QuestionNumber = "14.16",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "The referees wait for the result of the clear scoring chance.",
                            PhraseNl = "De scheidsrechters wachten eerst de vrije doelkans af.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Судије ће чекати на крајњи исход јасне ситуације за постизање гола",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "The referees interrupt the match immediately and give a time-out.",
                            PhraseNl = "De scheidsrechters onderbreken onmiddellijk het spel met een time-out.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Судије ће прекинуту утакмицу моментално и дати тајм-аут",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "After the lights are functioning again, the game is restarted with a free throw for WHITE team.",
                            PhraseNl =
                                "Zodra de verlichting weer werkt, wordt het spel hernomen met een vrije worp voor team WIT.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Након што је светло опет у функцији, утакмица се наставља слободним бацањем за БЕЛУ екипу",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "After the lights are functioning again, the game is restarted with a 7-metre throw for WHITE team.",
                            PhraseNl =
                                "Zodra de verlichting weer werkt, wordt het spel hernomen met een 7m-worp voor team WIT.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Чим је светло поново у функцији утакмица се наставља седмерцем за БЕЛУ екипу",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Statement in the match report in conformity with the regulations of the respective federation.",
                            PhraseNl =
                                "Vermelding op het wedstrijdblad in overeenstemming met de reglementen van de respectievelijke federatie.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Изјава у записник утакмице у складу са прописима надлежне федерације",
                            AnswerNumber = "e",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "While WHITE 3 is executing a 7-metre throw, WHITE 5 crosses the free-throw line after the referee’s whistle signal, but before the ball has left the thrower’s hand. Goalkeeper BLACK 1 saves the shot. Correct decision?",
                    PhraseNl =
                        "Terwijl WIT3 een 7m-worp uitvoert, overschrijdt WIT5 de vrije worplijn na het fluitsignaal van de scheidsrechter, maar vooraleer de bal de hand van de werper verlaten heeft. Doelverdediger ZWART1 stopt de worp. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Док БЕЛИ 3 изводи седмерац, БЕЛИ 5 пређе линију слободног бацања, после судијског звучног сигнала, али пре него што је лопта напустила руку извођача. Голман ЦРНИ 1 одбрани шут. Исправна одлука?",
                    QuestionNumber = "14.17",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Repeat the 7-metre throw for WHITE team",
                            PhraseNl = "Herhaling van de 7m-worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Понављање седмерца за БЕЛУ екипу",
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
                            Phrase = "Goalkeeper throw for BLACK team",
                            PhraseNl = "Uitworp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Голманово бацање за ЦРНУ екипу",
                            AnswerNumber = "c",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE 2 is ready to execute a 7-metre throw. The court referee whistles, but WHITE 2 drops the ball to the floor. BLACK 3 immediately picks up the ball and plays it to BLACK 2, who scores a goal in a counter-attack. Correct decision?",
                    PhraseNl =
                        "WIT2 staat gereed voor de uitvoering van een 7m-worp. De veldscheidsrechter fluit maar WIT2 laat de bal op de grond vallen. ZWART3 neemt hem onmiddellijk op en speelt hem naar ZWART2 die een doelpunt scoort. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "БЕЛИ 2 стоји спреман да изведе седмерац. Судија у пољу даје знак, али БЕЛИ 2 испусти лопту на под. ЦРНИ 3 одмах ухвати лопту и дода је ЦРНОМ 2, који постиже гол у контранападу. Исправна одлука?",
                    QuestionNumber = "14.18",
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
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Repetition of the 7-metre throw",
                            PhraseNl = "Herhaling van de 7m-worp",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Понављање седмерца",
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
                            Phrase = "Time-out",
                            PhraseNl = "Time-out",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Тајм-аут",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE 6 has the ball at the free-throw line of BLACK team and is brought down through a reckless foul by BLACK 5. At the same time, BLACK 8 stands at the goal-area line of BLACK team between his own goal and WHITE 6. Correct decision?",
                    PhraseNl =
                        "WIT6 in balbezit aan de vrije worplijn van team ZWART, en wordt door een grove spelregelovertreding van ZWART5 ten val gebracht. Op het zelfde ogenblik staat ZWART8 aan de doelgebied lijn van team ZWART tussen WIT6 en zijn eigen doel. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "БЕЛИ 6 има лопту на линији слободног бацања ЦРНЕ екипе и бива оборен након несмотреног прекршаја ЦРНОГ 5. У исто време ЦРНИ 8 стоји на линији голмановог простора између свог гола и БЕЛОГ 6. Коректна одлука?",
                    QuestionNumber = "14.19",
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
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of BLACK 5 without written report (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie voor ZWART5 (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Дисквалификација ЦРНОГ 5 без писаног извештаја (црвени картон показан од стране судија)",
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
                            PhraseSrb = "2 минута искључења против ЦРНОГ 5",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for WHITE team",
                            PhraseNl = "7m-worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за БЕЛУ екипу",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE team are in attack and play 7 against 6 with empty goal. BLACK 8 intercepts a pass. BLACK 8 dribbles the ball, and before he can get into position to take a shot on goal, he is attacked by WHITE 3, who manages to hold him shortly. Meanwhile, goalkeeper WHITE 12 enters the goal area again after a correct substitution with WHITE 7. What is the correct decision?",
                    PhraseNl =
                        "Team WIT is in aanval en speelt 7 tegen 6 met een leeg doel. ZWART8 onderschept een pas. ZWART8 dribbelt de bal, en vooraleer hij in een positie kan komen om een worp naar doel te doen, wordt hij aangevallen door WIT3, die er in slaagt om hem kort vast te houden. Ondertussen komt doelman WIT12 terug op het speelveld na een correcte wissel met WIT7. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "БЕЛА екипа је у нападу и игра са 7 играча и празним голом против 6. ЦРНИ 8 пресече додавање. ЦРНИ 8 води лопту и пре него што дође у могућност да шутира на гол, буде нападнут од БЕЛОГ 3, који га успева мало задржати. У међувремену, голман БЕЛИ 12 улази у голманов простор, пошто је извршио правилну замену са БЕЛИМ 7. Која је исправна одлука?",
                    QuestionNumber = "14.20",
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
                            PhraseSrb = "Седмерац за ЦРНУ екипу",
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
                            Phrase = "2-minutes suspension for WHITE 3",
                            PhraseNl = "2-minuten uitsluiting voor WIT3",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Искључење на 2 минута за БЕЛОГ 3",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE team are in attack and play 7 against 6 with empty goal. BLACK 5 intercepts a pass. BLACK 5 immediately clearly tries to take a direct shot on the empty goal. In that moment, he is pushed from behind by WHITE 6, so that he partially loses body control and his shot misses the goal. What is the correct decision?",
                    PhraseNl =
                        "Team WIT is in aanval en speelt 7 tegen 6 met een leeg doel. ZWART5 onderschept een pas. ZWART5 probeert onmiddellijk duidelijk een worp te doen naar het lege doel. Op dat ogenblik, wordt hij langs achter geduwd door WIT6, zo dat hij gedeeltelijk zijn lichaamscontrole verliest en zijn worp de goal mist. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "БЕЛА екипа је у нападу и игра са 7 играча и празним голом против 6. ЦРНИ 5 пресече додавање. ЦРНИ 5 одмах покуша да упути ударац на празан гл. У том тренутку гурнут је с леђа од стране БЕЛОГ 6 тако да делимично изгуби контролу над телом, те промаши гол. Која је исправна одлука?",
                    QuestionNumber = "14.21",
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
                            Phrase = "7-metre throw for BLACK team",
                            PhraseNl = "7m-worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за ЦРНУ екипу",
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
                            PhraseSrb = "Тајм-аут",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 6",
                            PhraseNl = "2-minuten uitsluiting voor WIT6",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Искључење на 2 минута за БЕЛОГ 6",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification for WHITE 6 (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie voor WIT6 (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Дисквалификација БЕЛОГ 6 (судије показују црвени картон)",
                            AnswerNumber = "e"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE team are in attack and play 7 against 6 with empty goal. WHITE 11 misses a pass, and the ball crosses the sideline to a throw-in for BLACK team. BLACK 9 takes the ball and executes the throw-in as an attempt to shoot the ball directly into the empty goal. The ball is blocked by WHITE 4, who is standing too close during the execution of the throw. What is the correct decision?",
                    PhraseNl =
                        "Team WIT is in aanval en speelt met 7 tegen 6 met een leeg doel. WIT11 mist een pass en de bal gaat over de zijlijn met een inworp voor team ZWART. ZWART9 neemt de bal en voert de inworp uit als een poging om de bal rechtstreeks in het lege doel te werpen. De bal wordt geblokt door WIT4, die te kortbij staat tijdens de uitvoering van de inworp. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "БЕЛА екипа је у нападу и игра са 7 играча и празним голом против 6. БЕЛИ 11 погрешно додаје и лопта прелази аут линију. ЦРНИ 9 узима лопту и изводи аут директним ударцем на празан гол. Ударац је блокиран од стране БЕЛОГ 4, који стоји преблизу извођача за време извођења аута. Која је исправна одлука?",
                    QuestionNumber = "14.22",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Correction of the position of WHITE 4",
                            PhraseNl = "Correctie van de positie van WIT4",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Корекција положаја БЕЛОГ 4",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Progressive punishment for WHITE 4",
                            PhraseNl = "Progressieve bestraffing van WIT4",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Прогресивна казна за БЕЛОГ 4",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Repeated throw-in for BLACK team after whistle signal",
                            PhraseNl = "Herhaling van de inworp voor team ZWART na fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Понављање аута за ЦРНУ екипу уз звиждук",
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
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for BLACK team",
                            PhraseNl = "7m-worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за ЦРНУ екипу",
                            AnswerNumber = "e",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Direct 2-minute suspension for WHITE 4",
                            PhraseNl = "Directe 2-minuten uitsluiting voor WIT4",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Искључење на 2 минута за БЕЛОГ 4",
                            AnswerNumber = "f",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE team are in attack and play 7 against 6 with empty goal. The referees call for an offensive foul against WHITE 7. BLACK 8 gets possession of the ball and is ready to execute the free throw as an attempt to shoot the ball into the empty goal. While doing so and before the ball has left his hand, he is held and pulled down from behind by WHITE 7 in a way that he partially loses his body control. Shortly after that, goalkeeper WHITE 16 enters his goal area after a correct substitution with WHITE 2. What is the correct decision?",
                    PhraseNl =
                        "Team WIT is in aanval en speelt met 7 tegen 6 met een leeg doel. De scheidsrechters fluiten een aanvallende fout tegen WIT7. ZWART8 komt in balbezit en is klaar om de vrije worp uit te voeren als een poging om de bal in het lege doel te werpen. Terwijl hij dit doet en vooraleer de bal zijn hand verlaten heeft, wordt hij langs achter neergetrokken door WIT7 zodat hij gedeeltelijk zijn lichaamscontrole verliest. Kort daarna betreedt doelman WIT16 in zijn doelgebied na een correcte wissel met WIT2. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "БЕЛА екипа је у нападу и игра 7 на 6 и са празним голом. Судије досуђују прекршај у нападу против БЕЛОГ 7. ЦРНИ 8 долази до лопте и спреман је да изведе слободно бацање као покушај директног ударца на празан гол. Док се припремао, а пре него што му је лопта напустила руку, оборен је са леђа од БЕЛОГ 7 тако да делимично изгуби контролу над телом. Одмах после тога голман БЕЛИ 16 улази у свој голманов простор после исправно направљене замене са БЕЛИМ 2. Која је исправна одлука?",
                    QuestionNumber = "14.23",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Progressive punishment for WHITE 7",
                            PhraseNl = "Progressieve bestraffing voor WIT7",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Прогресивна казна за БЕЛОГ 7",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 7",
                            PhraseNl = "2-minuten uitsluiting voor WIT7",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Искључење на 2 минута за БЕЛОГ 7",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification for WHITE 7 (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie voor WIT7 (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Дисквалификација БЕЛОГ 7 (судије показују црвени картон)",
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
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Repeated free throw for BLACK team after whistle signal",
                            PhraseNl = "Herhaling van de vrije worp voor team ZWART na fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Понављање слободног бацања за ЦРНУ екипу након звиждука",
                            AnswerNumber = "e"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for BLACK team",
                            PhraseNl = "7m-worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за ЦРНУ екипу",
                            AnswerNumber = "f",
                            Correct = true
                        }
                    ]
                }
            ]
        };
    }
}
