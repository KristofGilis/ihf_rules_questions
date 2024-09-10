using IHF.Rules.Questions.Infrastructure.DataSeed.Models;

namespace IHF.Rules.Questions.Infrastructure.DataSeed;

public static partial class Rules
{
    public static RuleDto GetRule06()
    {
        return new RuleDto
        {
            Name = "The Goal Area",
            NameNl = "Het Doelgebied",
            NameFr = "La Surface de but",
            NameSvn = "Vratarjev Prostor",
            NameDe = "Der Torraum",
            NameSrb = "Голманов простор",
            RuleNumber = "6",
            Questions =
            [
                new QuestionDto
                {
                    Phrase =
                        "The ball lies on the goal-area line. Attacker WHITE 7 picks it up and tries to score. WHITE 7 has a clear chance of scoring, when he is illegally attacked. Correct decision?",
                    PhraseNl =
                        "De bal ligt op de doelgebied lijn. Aanvaller WIT7 neemt hem op en probeert te scoren. WIT7 heeft een duidelijke doelkans wanneer hij foutief wordt aangevallen. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Лопта лежи на линији голмановог простора. Нападач БЕЛИ 7 је подигне и покуша постићи погодак. БЕЛИ 7 је непрописно нападнут у јасној ситуацији за постизање гола. Исправна одлука?",
                    QuestionNumber = "6.1",
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
                        },
                        new AnswerDto
                        {
                            Phrase = "Goalkeeper throw for BLACK team",
                            PhraseNl = "Uitworp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Голманово бацање за ЦРНУ екипу",
                            AnswerNumber = "d",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "The ball is rolling in the goal area of WHITE team. BLACK 8 picks the ball up and scores a goal. Correct decision?",
                    PhraseNl =
                        "De bal rolt in het doelgebied van team WIT. ZWART8 neemt hem op en scoort een doelpunt. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Лопта се котрља у голмановом простору БЕЛЕ екипе. ЦРНИ 8 подиже лопту и постиже гол. Исправна одлука?",
                    QuestionNumber = "6.2",
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
                            Phrase = "Goalkeeper throw for WHITE team",
                            PhraseNl = "Uitworp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Голманово бацање за БЕЛУ екипу",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Goal",
                            PhraseNl = "Doelpunt",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Гол",
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
                        "WHITE 3 stands with both feet in the playing area and catches the ball rebounding from his goalkeeper. When WHITE 3 is correctly obstructed by BLACK 10, he bounces the ball several times in his own goal area. Correct decision?",
                    PhraseNl =
                        "WIT3 staat met beide voeten in het speelveld en vangt een door zijn doelman afgeweerde botsende bal. Wanner hij door ZWART10 correct bedreigd wordt, tipt hij de bal meermaals in het eigen doelgebied. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "БЕЛИ 3 стоји обема ногама у пољу за игру и хвата лопту која се одбила од његовог голмана. Након што је БЕЛИ 3 правилно ометан од стране играча ЦРНОГ 10, он неколико пута удари лоптом о тло у сопственом голмановом простору. Исправна одлука?",
                    QuestionNumber = "6.3",
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
                        "WHITE 7 stands outside the goal area of BLACK team, but grabs the ball that is clearly in the air above the goal area and scores a goal. Correct decision?",
                    PhraseNl =
                        "WIT7 bevindt zich buiten het doelgebied van team ZWART, maar vangt echter de duidelijk boven het doelgebied vliegende bal en scoort een doelpunt. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "БЕЛИ 7 стоји изван голмановог простора ЦРНЕ екипе, али хвата лопту која је видно у ваздуху изнад голмановог простора и постиже гол. Исправна одлука?",
                    QuestionNumber = "6.4",
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
                            AnswerNumber = "a",
                            Correct = true
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
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE 8, who is attacked correctly by several opponents, intentionally rolls the ball into his own goal area, where the ball comes to rest. Goalkeeper WHITE 1 does not pick up the ball. Correct decision?",
                    PhraseNl =
                        "WIT8, door verschillende tegenspelers correct aangevallen, rolt de bal opzettelijk in het eigen doelgebied, waar de bal tot stilstand komt. Doelman van team WIT neemt de bal niet op. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "БЕЛИ 8, кога правилно напада неколико противничких играча, намерно откотрља лопту у свој голманов простор, где се она заустави. Голман БЕЛИ 1 не узима лопту. Исправна одлука?",
                    QuestionNumber = "6.5",
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
                            Phrase = "Goalkeeper throw for WHITE team after whistle signal",
                            PhraseNl = "Uitworp voor team WIT na fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Голманово бацање за БЕЛУ екипу после звучног сигнала",
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
                        "WHITE 5 plays the ball into his own team’s goal area. The ball hits the goal post and rolls towards the playing area. Goalkeeper WHITE 12 picks up the ball and passes it to WHITE 7, who scores a goal. Correct decision?",
                    PhraseNl =
                        "WIT5 speelt de bal in het eigen doelgebied. De bal treft de doelpaal en rolt richting speelveld. Doelman WIT12 neemt hem op en werp hem naar WIT7, die een doelpunt scoort. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "БЕЛИ 5 баци лопту у голманов простор своје екипе. Лопта удари у стативу и котрља се према пољу за игру. Голман БЕЛИ 12 је узме и дода БЕЛОМ 7 који постиже гол. Исправна одлука?",
                    QuestionNumber = "6.6",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for BLACK team",
                            PhraseNl = "7m-worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за ЦРНУ екипу",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Goal",
                            PhraseNl = "Doelpunt",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Гол",
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
                            Phrase = "Goalkeeper throw for WHITE team",
                            PhraseNl = "Uitworp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Голманово бацање за БЕЛУ екипу",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "BLACK team has scored a goal, and WHITE 10 executes the subsequent throw-off. He does not find any other teammate available, so he surprises his goalkeeper WHITE 12 by playing the ball back to him, even though the goalkeeper is standing in his goal area. WHITE 12 takes the ball and passes it to WHITE 9. Correct decision?",
                    PhraseNl =
                        "Team ZWART heeft gescoord en WIT10 neemt de daaruit voortvloeiende beginworp. Hij vindt geen vrijstaande maat, en verrast zo zijn doelman WIT12 door de bal naar hem terug te spelen, ondanks dat zijn doelman in zijn doelgebied staat. WIT12 neemt de bal en speelt hem naar WIT9. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "ЦРНА екипа је постигла гол и БЕЛИ 10 изводи почетно бацање. Он нема ниједног слободног саиграча и изненађује свог голмана БЕЛОГ 12, бацајући му лопту, иако се он налази у свом голмановом простору. БЕЛИ 12 хвата лопту и додаје је БЕЛОМ 9. Исправна одлука?",
                    QuestionNumber = "6.7",
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
                            Phrase = "Throw-off repeated after correction",
                            PhraseNl = "Hernemen van de beginworp na correctie",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Почетно бацање се понавља после корекције",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "Defender BLACK 7 sees that pivot WHITE 9 would be alone with the goalkeeper if he receives the ball. Having done the same thing earlier, he runs through the goal area to get around WHITE 9, so that he cannot receive a pass. BLACK 7 is already outside the goal-area line again, when WHITE 9 receives the ball. WHITE 9 turns around and runs straight into BLACK 7. Correct decision?",
                    PhraseNl =
                        "Verdediger ZWART7 ziet dat de cirkelspeler WIT9 volledig vrij zou staan met de doelman als hij de bal zou krijgen. Gezien hij hetzelfde reeds eerder gedaan heeft, loopt hij door het doelgebied om rond WIT9 te komen, zodat deze de pas niet kan. Krijgen. ZWART7 is al terug uit het doelgebied wanneer WIT9 de bal krijgt. WIT9 draait zich en loop recht op ZWART7 in. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Одбрамбени играч ЦРНИ 7 види да ће пивот БЕЛИ 9 примити лопту сам испред голмана. Стога, пошто је исту ствар учинио и раније, он трчи око играча БЕЛОГ 9, кроз голманов простор, тако да БЕЛИ 9 не може да прими лопту. ЦРНИ 7 је већ изван линије голмановог простора, када БЕЛИ 9 прима лопту. БЕЛИ 9 се окреће и натрчава на ЦРНОГ 7. Исправна одлука?",
                    QuestionNumber = "6.8",
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
                            Phrase = "Progressive punishment against BLACK 7",
                            PhraseNl = "Progressieve bestraffing voor ZWART7",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Прогресивна казна против ЦРНОГ 7",
                            AnswerNumber = "d",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "The ball rebounds from goalkeeper BLACK 1 to the attacking player WHITE 4, who is waiting just outside the goal-area line. To prevent a clear chance of scoring, BLACK 2 enters the goal area and prevents WHITE 4 from receiving the ball. Correct decision?",
                    PhraseNl =
                        "De bal botst terug van de doelverdediger ZWART1 naar aanvaller WIT4 die net buiten het doelgebied wacht. Om een duidelijke scorekans te voorkomen, betreedt verdediger ZWART2 het doelgebied en verhindert zo aanvaller WIT4 om de bal te krijgen. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Лопта се одбија од голмана ЦРНОГ 1 према нападачу БЕЛОМ 4 који чека уз линију голмановог простора. Да би спречио јасну прилику за гол, ЦРНИ 2 улази у голманов простор и спречава БЕЛОГ 4 да прими лопту. Исправна одлука?",
                    QuestionNumber = "6.9",
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
                            PhraseNl = "7-m-worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за БЕЛУ екипу",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Progressive punishment against BLACK 2",
                            PhraseNl = "Progressieve bestraffing voor verdediger ZWART2",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Прогресивна казна против ЦРНОГ 2",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification of BLACK 2 (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie voor ZWART2 (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Дисквалификација ЦРНОГ 2 (црвени картон показан од стране судија)",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE 10 passes the ball in the direction of his own goal area. Goalkeeper WHITE 1 jumps from the goal area and catches the ball in the air. WHITE 1 firmly holds on to the ball and lands outside the goal area. Correct decision?",
                    PhraseNl =
                        "WIT10 past de bal terug in de richting van zijn eigen doelgebied. Doelverdediger WIT1 springt op en vangt de bal in de lucht. WIT1 houdt de bal vast en landt buiten zijn doelgebied. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "БЕЛИ 10 баца лопту ка свом голмановом простору. Голман БЕЛИ 1 скаче из голмановог простора и хвата лопту у ваздуху. Чврсто држећи лопту БЕЛИ 1 доскаче изван голмановог простора. Исправна одлука?",
                    QuestionNumber = "6.10",
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
                            Phrase = "Goalkeeper throw for WHITE team",
                            PhraseNl = "Uitworp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Голманово бацање за БЕЛУ екипу",
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
                            Phrase = "7-metre throw for BLACK team",
                            PhraseNl = "7-meter-worp voor team ZWART",
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
                    Phrase =
                        "The ball is passed from WHITE 11 back into the goal area, where goalkeeper WHITE 1 jumps up and catches the ball in the air. WHITE 1 firmly holds on to the ball and lands with one foot inside the goal area and one foot outside. Correct decision?",
                    PhraseNl =
                        "De bal wordt door WIT11 terug in het doelgebied gespeeld waar doelverdediger WIT1 opspringt en de bal in de lucht vangt. De doelverdediger houdt de bal vast en landt met een voet in en een voet buiten zijn doelgebied. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Лопта додата од стране БЕЛОГ 11 враћа се у голманов простор, где голман БЕЛИ 1 скаче и хвата лопту док је у ваздуху. Чврсто држећи лопту БЕЛИ 1 доскаче једном ногом у голманов простор, а другом изван голмановог простора. Исправна одлука?",
                    QuestionNumber = "6.11",
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
                            Phrase = "Goalkeeper throw for WHITE team",
                            PhraseNl = "Uitworp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Голманово бацање за БЕЛУ екипу",
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
                            Phrase = "7-metre throw for BLACK team",
                            PhraseNl = "7-meter-worp voor team ZWART",
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
                    Phrase =
                        "WHITE 7 from the attacking team is in possession of the ball and steps with the ball into the goal area of BLACK team. Correct decision?",
                    PhraseNl =
                        "Aanvaller WIT7 is in balbezit en stapt met de bal het doelgebied van de team ZWART. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "БЕЛИ 7 из нападајуће екипе има лопту у поседу и са лоптом закорачи у голманов простор противника. Исправна одлука?",
                    QuestionNumber = "6.12",
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
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Goalkeeper throw for BLACK team after whistle signal",
                            PhraseNl = "Uitworp voor team ZWART na fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Голманово бацање за ЦРНУ екипу после звучног сигнала",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team after whistle signal",
                            PhraseNl = "Uitworp voor team ZWART na fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за ЦРНУ екипу после звучног сигнала",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "The ball is lying on the floor in the goal area of WHITE team. At this moment, the timekeeper whistles and explains that WHITE 5 has made a faulty substitution. Correct decision?",
                    PhraseNl =
                        "De bal ligt op de vloer in het doelgebied van team WIT. Op dat ogenblik fluit de tijdwaarnemer en verklaart dat WIT5 een wisselfout gemaakt heeft. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Лопта лежи на поду голмановог простора БЕЛЕ екипе. У том тренутку мерилац времена свира са стола и објашњава да је БЕЛИ 5 направио погрешну замену. Исправна одлука?",
                    QuestionNumber = "6.13",
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
                            PhraseSrb = "2 минута искључења за БЕЛОГ 5",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team at the free-throw line of WHITE team",
                            PhraseNl = "Vrije worp voor team ZWART aan de vrije worplijn van team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за ЦРНУ екипу са линије слободног бацања БЕЛЕ екипе",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team at the substitution area of WHITE team",
                            PhraseNl = "Vrije worp voor team ZWART aan de wisselzone van team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за ЦРНУ екипу код простора за замену играча БЕЛЕ екипе",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase = "In which of the following cases should a goalkeeper throw be given?",
                    PhraseNl = "In welke van de volgende gevallen moet een uitworp gegeven worden?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "У којем од наведених случајева треба досудити голманово бацање?",
                    QuestionNumber = "6.14",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "When a player of the attacking team (with the ball) touches the goal area of the opponents",
                            PhraseNl =
                                "Wanneer een speler van het aanvallende team (met de bal) het doelgebied van de tegenstrever raakt",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Када играч нападајуће екипе, са лоптом у поседу, додирне голманов простор противника",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "When a player of the attacking team (without the ball) touches the goal area of the opponents and gains an advantage by doing so",
                            PhraseNl =
                                "Wanneer een speler van het aanvallende team (zonder de bal) het doelgebied van de tegenstrever raakt en daardoor een voordeel haalt",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Када играч нападајуће екипе, без лопте у поседу, додирне голманов простор противника и тиме стекне предност",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "When a player of the attacking team deflects the ball out across the outer goal line of the opponents",
                            PhraseNl =
                                "Wanneer een speler van het aanvallende team de bal over de buitendoellijn van de tegenstrever devieert",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Када играч нападајуће екипе упути лопту преко гол-аут линије противника",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "When a player with the ball touches the goal area of his own team",
                            PhraseNl = "Wanneer een speler met bal het eigen doelgebied raakt",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Када играч са лоптом додирне сопствени голманов простор",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE team is attacking. BLACK 4 stands at the goal-area line. The ball is in the air, and BLACK 4 reaches it to direct it into the goal area. The ball is touched by goalkeeper BLACK 1 and then crosses the outer goal line. Correct decision?",
                    PhraseNl =
                        "Team WIT is in aanval. ZWART4 staat aan de doelgebied lijn. De bal vliegt in de lucht en ZWART4 raakt hem en doet hem afwijken naar zijn doelgebied. De bal wordt aangeraakt door de doelverdediger ZWART1 en gaat daarna over de buitendoellijn. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Бела екипа је у нападу. ЦРНИ 4 стоји уз линију голмановог простора. Лопта је у ваздуху, ЦРНИ 4 је ухвати и убаци је директно у голманов простор. Голман ЦРНИ 1 додирује лопту и она одлази изван гола, преко гол-аут линије. Исправна одлука?",
                    QuestionNumber = "6.15",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Throw-in for WHITE team",
                            PhraseNl = "Inworp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Аут за БЕЛУ екипу",
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
                            Phrase = "7-metre throw for WHITE team",
                            PhraseNl = "7-meter worp voor team WIT",
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
                        },
                        new AnswerDto
                        {
                            Phrase = "Progressive punishment for BLACK 4",
                            PhraseNl = "Progressieve bestraffing voor ZWART4",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Прогресивна казна против ЦРНОГ 4",
                            AnswerNumber = "e"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "Goalkeeper WHITE 12 has saved a shot and has the ball under control in his goal area. He still has the ball in his hands when the timekeeper whistles for a faulty substitution by WHITE 10. Correct decision?",
                    PhraseNl =
                        "Doelverdediger WIT12 heeft de bal gestopt en heeft hem onder controle in zijn doelgebied. Hij heeft de bal nog in zijn handen wanneer de tijdwaarnemer fluit wegens een wisselfout van WIT10. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Голман БЕЛИ 12 је одбранио шут и има лопту под контролом у свом голмановом простору. Он још увек има лопту у својим рукама, када мерилац времена свира, због погрешне замене БЕЛОГ 10. Исправна одлука?",
                    QuestionNumber = "6.16",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team at the substitution area of WHITE team",
                            PhraseNl = "Vrije worp voor team ZWART aan de wisselzone van team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за ЦРНУ екипу код простора за замену играча БЕЛЕ екипе",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Time-out",
                            PhraseNl = "Time-out",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Тајм–аут",
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
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 10",
                            PhraseNl = "2-minuten uitsluiting voor een speler WIT10",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења за БЕЛОГ 10",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team at the free-throw line of WHITE team",
                            PhraseNl = "Vrije worp voor team ZWART aan de vrije worplijn van team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за ЦРНУ екипу са линије слободног бацања БЕЛЕ екипе",
                            AnswerNumber = "e"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "Goalkeeper WHITE 12 jumps up in the playing area just outside his goal area, catches the ball – that has been thrown to him by WHITE 4 – in the air, and throws it over the outer goal line. He then lands inside the goal area. Correct decision?",
                    PhraseNl =
                        "Doelverdediger WIT12 springt op net buiten zijn doelgebied, vangt de bal – die hem toegeworpen werd door WIT4 - in de lucht op en werpt hem over de eigen buitendoellijn. Daarna landt hij in het doelgebied. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Голман БЕЛИ 12 скаче у пољу за игру, тик изван свог голмановог простора, у ваздуху хвата лопту, додату од стране БЕЛОГ 4, и баца је преко гол-аут линије. Затим доскочи у голманов простор. Исправна одлука?",
                    QuestionNumber = "6.17",
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
                            Phrase = "Throw-in for BLACK team",
                            PhraseNl = "Inworp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Аут за ЦРНУ екипу",
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
                            PhraseSrb = "Слободно бацање за ЦРНУ екипу",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Warning for WHITE 12",
                            PhraseNl = "Waarschuwing voor WIT12",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Опомена за БЕЛОГ 12",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE 9 shoots at the goal of BLACK team. Goalkeeper BLACK 1 saves the shot, and the ball rolls towards the playing area, where a player from BLACK team is ready to pick it up. As BLACK 1 was injured when saving the shot, the referees interrupt the game, while the ball is still in the goal area. Correct decision?",
                    PhraseNl =
                        "WIT9 werpt naar het doel van team ZWART. Doelverdediger ZWART1 weert de bal af en de bal rolt richting speelveld waar een speler van team ZWART gereed staat om hem aan te nemen. Doordat ZWART1 gekwetst werd bij het afweren van de bal, onderbreken de scheidsrechters het spel op het ogenblik dat de bal nog in het doelgebied is. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Играч БЕЛИ 9 шутира на гол ЦРНЕ екипе. Голман ЦРНИ 1 брани шут и лопта се котрља према пољу за игру, где је чека играч ЦРНЕ екипе спреман да је ухвати. Како се ЦРНИ 1 приликом одбране повредио, судије прекидају игру, док је лопта још увек у голмановом простору. Исправна одлука?",
                    QuestionNumber = "6.18",
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
                            Phrase = "Free throw for BLACK team",
                            PhraseNl = "Vrije worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за ЦРНУ екипу",
                            AnswerNumber = "c",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "The ball is rolling on the floor in the goal area of WHITE team. At this moment, the timekeeper whistles and explains that WHITE 5 has made a faulty substitution. Correct decision?",
                    PhraseNl =
                        "De bal rolt in het doelgebied van team WIT. Op dat ogenblik fluit de tijdwaarnemer en verklaart dat WIT5 een wisselfout begaan heeft. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Лопта се котрља по поду голмановог простора БЕЛЕ екипе. У том тренутку мерилац времена свира са стола и објашњава да је БЕЛИ 5 направио погрешну замену. Исправна одлука?",
                    QuestionNumber = "6.19",
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
                            Phrase = "2-minute suspension for WHITE 5",
                            PhraseNl = " 2-minuten uitsluiting voor WIT5",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења за БЕЛОГ 5",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team at the free-throw line of WHITE team",
                            PhraseNl = "Vrije worp voor team ZWART aan de vrije worplijn van team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за ЦРНУ екипу са линије слободног бацања БЕЛЕ екипе",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team at the substitution area of WHITE team",
                            PhraseNl = "Vrije worp voor team ZWART aan de wisselzone van team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за ЦРНУ екипу код простора за замену играча БЕЛЕ екипе",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE 5 takes a shot on goal. The shot is blocked by goalkeeper BLACK 12 and goes in the air over the goal area in the direction of pivot WHITE 11, who is standing at the goal-area line alone and ready to catch the ball. Defender BLACK 2 jumps in the direction of the ball, and while in mid-air over the goal area, he plays the ball in the direction of the sideline. Because of glue on the ball, the ball comes to rest in the goal area without the goalkeeper touching it. Correct decision?",
                    PhraseNl =
                        "WIT5 werpt naar doel. Het schot wordt door de doelman ZWART12 geblokt en gaat in de lucht boven het doelgebied in de richting van cirkelspeler WIT11, die aan de doelgebied lijn staat, alleen en klaar om de bal te vangen. Verdediger ZWART2 springt in de richting van de bal en terwijl hij boven het doelgebied hangt, speelt hij de bal in de richting van de zijlijn. Omdat er hars op de bal hangt, komt de bal stil te liggen in het doelgebied zonder dat de doelman hem aanraakt. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "БЕЛИ 5 шутира на гол, шут блокира голман ЦРНИ 12 и лопта лети изнад голмановог простора у правцу пивота БЕЛОГ 11, који стоји уз линију голмановог простора у јасној ситуацији за постизање гола, спреман да ухвати лопту. Одбрамбени играч ЦРНИ 2 скочи ка лопти и док је у ваздуху, изнад голмановог простора, пошаље лопту у правцу аут линије. Због лепка на њој, лопта остане у голмановом простору, а да је голман није додирнуо. Исправна одлука?",
                    QuestionNumber = "6.20",
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
                            Phrase = "7-metre throw for WHITE team",
                            PhraseNl = "7m-worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Progressive punishment for BLACK 2",
                            PhraseNl = "Progressieve bestraffing voor ZWART2",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Прогресивна казна против ЦРНОГ 2",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "Goalkeeper BLACK 1 has saved a shot and wants to pass the ball to BLACK 6, who is ready for a fast break. When BLACK 1 makes the pass, he touches the goal-area line. BLACK 6 gets the ball and scores a goal. Correct decision?",
                    PhraseNl =
                        "Doelman ZWART1 heeft een worp gestopt en wil de bal naar ZWART6 spelen die klaar is voor de tegenaanval. Wanneer ZWART1 de bal past, raakt hij de doelgebied lijn. ZWART6 krijgt de bal en scoort een doelpunt. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Голман ЦРНИ 1 је одбранио шут и жели да дода лопту ЦРНОМ 6 који је спреман за контранапад. Приликом додавања ЦРНИ 1 додирује линију голмановог простора. ЦРНИ 6 ухвати лопту и постигне гол. Исправна одлука?",
                    QuestionNumber = "6.21",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Goal is valid",
                            PhraseNl = "Doelpunt is geldig",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Гол је исправан",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for team WHITE",
                            PhraseNl = "Vrije worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Correction and repeated goalkeeper throw after whistle",
                            PhraseNl = "Correctie en herneming van de uitworp na fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Корекција и понављање голмановог бацања после звучног сигнала",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Goal is not valid",
                            PhraseNl = "Doelpunt is niet geldig",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Гол није исправан",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE 6 is counter-attacking. He jumps, takes a shot on goal, and lands in the goal area of BLACK team. Goalkeeper BLACK 12 blocks the shot, and the ball goes to WHITE 11, who scores a goal, while WHITE 6 is lying in the goal area between him and goalkeeper BLACK 12. Correct decision?",
                    PhraseNl =
                        "WIT6 is in tegenaanval. Hij springt, werpt op doel en landt in het doelgebied van team ZWART. Doelman ZWART12 blokt de worp, en de bal gaat naar WIT1, die een doelpunt scoort, terwijl WIT6 in het doelgebied ligt tussen hem en de doelman ZWART12. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "БЕЛИ 6 је у контранападу. Скочи, шутира на гол и падне у голманов простор ЦРНЕ екипе. Голман ЦРНИ 12 брани шут и лопта долази до БЕЛОГ 11, који постиже гол, док БЕЛИ 6 лежи у голмановом простору између њих двојице. Исправна одлука?",
                    QuestionNumber = "6.22",
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
                            Phrase = "Goalkeeper throw for BLACK team",
                            PhraseNl = "Uitworp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Голманово бацање за ЦРНУ екипу",
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
                            PhraseSrb = "Слободно бацање за ЦРНУ екипу",
                            AnswerNumber = "c"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE team are in attack and play with an empty goal. WHITE 11 takes a shot on goal. Goalkeeper BLACK 1 saves the shot. He executes the goalkeeper throw as a shot on the empty goal. WHITE 10 tries to save the shot. He jumps from outside his own goal area and – while in the air over the goal area – touches the ball. The ball crosses the outer goal line. After touching the ball, WHITE 10 lands inside the goal area. What is the correct decision?",
                    PhraseNl =
                        "Team WIT is in aanval en speelt met een leeg doel. WIT11 werpt naar doel. Doelman ZWART1 stopt het schot. Hij voert een uitworp uit als een worp naar het lege doel. WIT10 probeert het shot te stoppen. Hij springt van buiten zijn eigen doelgebied op en – terwijl hij in de lucht is boven zijn doelgebied – raakt hij de bal. De bal gaat over de buitendoellijn. Na de bal geraakt te hebben, landt WIT10 in het doelgebied. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "БЕЛА екипа је у нападу и игра без голмана (празан гол). БЕЛИ 11 упућује ударац према голу. Голман ЦРНИ 1 брани ударац те изводи голманово бацање као ударац према празном голу. БЕЛИ 10 покушава спречити ударац тако што се одрази ван сопственог голмановог простора и док је у ваздуху додирне лопту која је изнад голмановог простора. Лопта прелази линију ван гола. Пошто је додирнуо лопту, БЕЛИ 11 доскаче у голманов простор. Која је исправна одлука?",
                    QuestionNumber = "6.23",
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
                            Phrase = "Throw-in for BLACK team",
                            PhraseNl = "Inworp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Аут за ЦРНУ екипу",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Progressive punishment for WHITE 10",
                            PhraseNl = "Progressieve bestraffing voor WIT10",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Прогресивна казна за БЕЛОГ 10",
                            AnswerNumber = "e"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE team are in attack and play with an empty goal. WHITE 11 takes a shot on goal. Goalkeeper BLACK 1 saves the shot. He executes the goalkeeper throw as a shot on the empty goal. WHITE 10 tries to save the shot. He jumps from outside his own goal area and – while in the air over the goal area – catches the ball and lands inside the goal area with the ball in his hands. What is the correct decision?",
                    PhraseNl =
                        "Team WIT is in aanval en speelt met een leeg doel. WIT11 werpt naar doel. Doelman ZWART1 stopt het schot. Hij voert een uitworp uit als een worp naar het lege doel. WIT10 probeert het shot te stoppen. Hij springt op van buiten zijn eigen doelgebied – en in de lucht boven zijn doelgebied – vangt hij de bal en landt binnen het doelgebied met de bal in zijn handen. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "БЕЛА екипа је у нападу и игра без голмана (празан гол). БЕЛИ 11 упућује ударац према голу. Голман ЦРНИ 1 брани ударац те изводи голманово бацање као ударац према празном голу. БЕЛИ 10 покушава спречити ударац тако што се одрази ван сопственог голмановог простора и док је у ваздуху ухвати лопту и доскаче у голманов простор с лоптом у руци. Која је исправна одлука?",
                    QuestionNumber = "6.24",
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
                            Phrase = "Direct 2-minute suspension for WHITE 10",
                            PhraseNl = "Directe 2-minuten uitsluiting voor WIT10",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Искључење на 2 минута за БЕЛОГ 10",
                            AnswerNumber = "c",
                            Correct = true
                        }
                    ]
                }
            ]
        };
    }
}
