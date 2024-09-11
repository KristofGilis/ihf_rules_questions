using IHF.Rules.Questions.Infrastructure.DataSeed.Models;

namespace IHF.Rules.Questions.Infrastructure.DataSeed;

public static partial class Rules
{
    public static RuleDto GetRule07()
    {
        return new RuleDto
        {
            Name = "Playing the Ball, Passive Play",
            NameNl = "Het spelen van de bal, Passief Spel",
            NameFr = "Le Maniement du ballon, Le jeu passif",
            NameSvn = "Igra Z Žogo, Pasivna Igra",
            NameDe = "Spielen des Balls, passives Spiel",
            NameSrb = "Игра лоптом, пасивна игра",
            RuleNumber = "7",
            Questions =
            [
                new QuestionDto
                {
                    Phrase =
                        "The ball is in the air going towards the sideline. WHITE 3 manages to play the ball with his hand to WHITE 7 before the ball crosses the line. In order to do this, WHITE 3 crosses the sideline with one foot. WHITE 7 catches the ball and scores a goal. Correct decision?",
                    PhraseNl =
                        "De bal is in de lucht en gaat richting de zijlijn. Speler WIT3 slaagt erin om de bal met zijn hand naar WIT7 te spelen vooraleer de bal de lijn overschrijdt. Bij deze actie komt WIT3 echter met één voet buiten het speeloppervlak. WIT7 vangt de bal en scoort een doelpunt. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Лопта је у ваздуху и иде према аут линији. БЕЛИ 3 успева да дода лопту руком БЕЛОМ 7, пре него што лопта пређе линију. Да би то учинио БЕЛИ 3 прелази једном ногом ван игралишта. БЕЛИ 7 хвата лопту и постиже гол. Исправна одлука?",
                    QuestionNumber = "7.1",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Throw-in for BLACK team",
                            PhraseNl = "Inworp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Аут за ЦРНУ екипу",
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
                            Phrase = "2-minute suspension for WHITE 3",
                            PhraseNl = "2-minuten uitsluiting voor WIT3",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења против играча БЕЛОГ 3",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "A risky pass is played from BLACK 3 to BLACK 11. When the ball is in the air, BLACK 11 realises that he will not be able to catch it, so he hits the ball with his fist to feed BLACK 9, who is standing in the middle of the court. Correct decision?",
                    PhraseNl =
                        "Een risicovolle pas wordt gespeeld van ZWART3 naar ZWART11. Wanneer de bal in de lucht is, realiseert ZWART11 zich dat hij de bal niet zal kunnen vangen. Daarom slaat hij hem met de vuist naar ZWART9, die midden op het speelveld staat. Correcte be beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Ризично додавање ЦРНОГ 3 ка ЦРНОМ 11. Док је лопта у ваздуху, ЦРНИ 11 схвати да је не може ухватити, па је удари песницом према играчу ЦРНОМ 9 који стоји на средини игралишта. Исправна одлука?",
                    QuestionNumber = "7.2",
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
                            Phrase = "Free throw for WHITE team from BLACK 9’s position",
                            PhraseNl = "Vrije worp voor team WIT van op de positie van ZWART9",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу са позиције ЦРНОГ 9",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team from BLACK 11’s position",
                            PhraseNl = "Vrije worp voor team WIT van op de positie van ZWART11",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу са позиције ЦРНО 11",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for BLACK 11",
                            PhraseNl = "2-minuten uitsluiting voor ZWART11",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења против ЦРНОГ 11",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE 4 catches the ball while standing. He then jumps and lands on the right foot and jumps to his left foot to throw. How many steps did WHITE 4 take?",
                    PhraseNl =
                        "WIT4 vangt de bal in stand, springt op en landt op de rechtervoet, springt op de linkervoet en werpt. Hoeveel passen heeft WIT4 gedaan?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "БЕЛИ 4 стоји и ухвати лопту. Он затим скочи и доскочи на десну ногу, затим скочи и доскочи на леву ногу и шутира. Колико је корака направио играч БЕЛИ 4?",
                    QuestionNumber = "7.3",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "1",
                            PhraseNl = "1",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "1 корак",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "2",
                            PhraseNl = "2",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 корака",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "3",
                            PhraseNl = "3",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "3 корака",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "4",
                            PhraseNl = "4",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "4 корака",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "A player jumps to catch the ball passed to him by a teammate. He lands on both feet simultaneously. Then he lifts his right foot to take a step to the side and drags his left foot up to the right foot. How many steps did he take?",
                    PhraseNl =
                        "Een speler springt om de bal te vangen. Hij landt op beide voeten tegelijk. Daarna heft hij de rechtervoet op, maakt een zijwaartse pas en zet de linkervoet bij. Hoeveel passen maakte hij?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Играч скочи и ухвати лопту додату од стране саиграча. Доскочи са обе ноге истовремено. Потом дигне десну ногу, направи корак у страну и привуче леву ногу десној. Колико је корака направио?",
                    QuestionNumber = "7.4",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "1",
                            PhraseNl = "1",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "1 корак",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "3",
                            PhraseNl = "3",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "3 корака",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "0",
                            PhraseNl = "0",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "0 корака",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "2",
                            PhraseNl = "2",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 корака",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "A player catches the ball in mid-air, passed to him by a teammate. He then lands on the right foot and moves off with that foot. Then he puts the left foot down first and then the right one to throw. How many steps did he take?",
                    PhraseNl =
                        "Een speler vangt de bal die hem door een ploegmaat wordt toegespeeld, in de lucht, landt op de rechtervoet en springt met deze af. Hij zet eerst de linker voet neer en dan de rechtervoet en werpt. Hoeveel passen maakte hij?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Играч ухвати лопту у ваздуху, додату од стране саиграча, доскочи на десну ногу и са те ноге закорачи, најпре спусти леву ногу на тло, а затим и десну и онда шутира. Колико је корака направио?",
                    QuestionNumber = "7.5",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "3",
                            PhraseNl = "3",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "3 корака",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "2",
                            PhraseNl = "2",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 корака",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "1",
                            PhraseNl = "1",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "1 корак",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "0",
                            PhraseNl = "0",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",,
                            PhraseSrb = "0 корака",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE 5 is fumbling the ball, but finally manages to get it under control. Then he takes three steps, bounces the ball once, and takes another three steps before scoring a goal. Correct decision?",
                    PhraseNl =
                        "WIT5 moet bij een poging om de bal te vangen, meermaals napakken, maar krijgt hem finaal onder controle. Dan doet hij 3 passen, tipt de bal eenmaal en na nog eens drie passen, werpt hij de bal in het doel. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "БЕЛИ 5 се спетља са лоптом, али успе да је задржи под контролом. Потом направи три корака, једном одбије лопту о тло, па направи још три корака пре него што постигне гол. Исправна одлука?",
                    QuestionNumber = "7.6",
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
                            Phrase = "Goal",
                            PhraseNl = "Doelpunt",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Гол",
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
                            Phrase = "Throw-in for BLACK team",
                            PhraseNl = "Inworp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Аут за ЦРНУ екипу",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE 5 wants to start an attack. He bounces the ball repeatedly while taking five steps. He then takes the ball up again to pass it. Correct decision?",
                    PhraseNl =
                        "WIT5 wil een aanval opzetten. Hij tipt de bal herhaaldelijk terwijl hij 5 stappen doet. Dan neemt hij de bal terug vast om een pas te geven. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "БЕЛИ 5 жели да започне напад. Играч почне да води лопту, одбија лопту о под, направи пет корака, затим хвата лопту и дода је. Исправна одлука?",
                    QuestionNumber = "7.7",
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
                            Phrase = "Game continues without interruption",
                            PhraseNl = "Verder spelen zonder onderbreking",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Игра се наставља без прекида",
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
                            PhraseSrb = "Седмерац за ЦРНУ екипу",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "BLACK 6 catches the ball, slips and falls. Lying on his back, he passes the ball to BLACK 9. Correct decision?",
                    PhraseNl =
                        "ZWART6 vangt de bal, glijdt uit en valt. Liggend op zijn rug, speelt hij de bal naar ZWART9. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "ЦРНИ 6 ухвати лопту, оклизне се и падне. Лежећи на леђима додаје лопту ЦРНОМ 9. Исправна одлука?",
                    QuestionNumber = "7.8",
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
                            Phrase = "Game continues without interruption",
                            PhraseNl = "Het spel gaat verder zonder onderbreking",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Игра се наставља без прекида",
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
                        "WHITE 3 runs between two opponents to push the ball in the direction of his path. He grabs the ball again, before it has touched the ground. Now, there is an open space towards the goal of BLACK team. WHITE 3 bounces the ball once and score. Correct decision?",
                    PhraseNl =
                        "WIT3 loopt tussen 2 tegenspelers en stoot de bal voorwaarts in de eigen looprichting. Vooraleer de bal de grond raakt, vangt hij hem. Nu is er een vrije baan naar het doel van team ZWART. WIT3 tipt de bal een keer en scoort. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "БЕЛИ 3 трчи између два противничка играча и гурне лопту у смеру у којем трчи. Поново хвата лопту пре него што је дотакла земљу и има отворен пут према голу ЦРНЕ екипе. БЕЛИ 3 удари лопту о тло још једном и убацује је у гол. Исправна одлука?",
                    QuestionNumber = "7.9",
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
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "After bouncing the ball once, WHITE 7 wants to pass the ball to WHITE 5, but WHITE 5 is marked by an opponent. WHITE 7 becomes so confused that he drops the ball, but manages to catch it again before it has touched the floor. Correct decision?",
                    PhraseNl =
                        "Na de bal eenmaal getipt te hebben, wil WIT7, WIT5 aanspelen, die echter afgedekt wordt. WIT7 is zo verward, dat hem de bal ontglipt. Hij vangt hem echter weer op vooraleer de bal de grond raakt. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "БЕЛИ 7 жели да дода лопту БЕЛОМ 5 након што ју је једном ударио о под, али БЕЛОГ 5 покрива противнички играч. БЕЛИ 7 се збуни, испусти лопту и поново је ухвати пре него што лопта дотакне тло. Исправна одлука?",
                    QuestionNumber = "7.10",
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
                            Phrase = "Free throw for WHITE team",
                            PhraseNl = "Vrije worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу",
                            AnswerNumber = "c"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase = "How is repeated passive play to be penalised?",
                    PhraseNl = "Hoe moet herhaald passief spel bestraft te worden?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Како се кажњава поновљена пасивна игра?",
                    QuestionNumber = "7.11",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Free throw and warning",
                            PhraseNl = "Vrije worp en waarschuwing",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање и опомена",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw and 2-minute suspension",
                            PhraseNl = "Vrije worp en 2-minuten uitsluiting",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање и 2 минута искључења",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw",
                            PhraseNl = "Vrije worp",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw and disqualification (red card shown by the referees)",
                            PhraseNl = "Vrije worp en diskwalificatie (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање и дисквалификација (црвени картон показан од стране судија)",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "Following a shot on goal by WHITE 4, the ball rebounds from the goal post of BLACK team, and hits the referee who stands inside the goal area next to the goal. Consequently, the ball crosses the sideline and not the outer goal line. Correct decision?",
                    PhraseNl =
                        "Na een worp naar doel door WIT4 springt de bal van de doelpaal van team ZWART terug, treft de scheidsrechter die in het doelgebied staat naast het doel. Dien ten gevolge gaat de bal over de zijlijn en niet over de buitendoellijn. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Лопту је на гол упутио БЕЛИ 4, лопта се одбила од стативе гола ЦРНЕ екипе, погодила је судију у голмановом простору близу гола и услед тога прешла аут линију игралишта, а не гол-аут линију. Исправна одлука?",
                    QuestionNumber = "7.12",
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
                            Phrase = "Goalkeeper throw for BLACK team",
                            PhraseNl = "Uitworp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Голманово бацање за ЦРНУ екипу",
                            AnswerNumber = "c"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE team executes a throw-in. WHITE 5 throws the ball onto the court, where it hits the referee and crosses the goal line of BLACK team. Correct decision?",
                    PhraseNl =
                        "Ploeg WIT voert een inworp uit. WIT5 werpt de bal in het speelveld, waar de bal de scheidsrechter raakt en de doellijn overschrijdt van team ZWART. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "БЕЛА екипа изводи аут. БЕЛИ 5 баца лопту у поље за игру која погађа судију и улази у гол ЦРНЕ екипе. Исправна одлука?",
                    QuestionNumber = "7.13",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Repetition of throw-in after whistle signal",
                            PhraseNl = "Hernemen van de worp met fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Понављање аута, после звучног сигнала",
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
                            Phrase = "Free throw for WHITE team",
                            PhraseNl = "Vrije worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слододно бацање за БЕЛУ екипу",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Goal for WHITE team",
                            PhraseNl = "Doelpunt voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Гол БЕЛУ екипу",
                            AnswerNumber = "d",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "BLACK 3 makes a jump shot, and WHITE 9 blocks the ball. The ball falls to the floor, and WHITE 9 picks it up with both hands and starts dribbling in a counter-attack. He throws the ball into the goal of BLACK team. Correct decision?",
                    PhraseNl =
                        "ZWART3 doet een sprongworp en WIT9 blokt de bal. De bal valt op de vloer en WIT9 neemt hem op met beide handen en begint in tegenaanval te dribbelen. Hij werpt de bal in het doel van team ZWART. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "ЦРНИ 3 изводи скок-шут, а БЕЛИ 9 блокира лопту. Лопта падне на под, БЕЛИ 9 је узме и крене да је води у контранапад, а затим је убаци у гол ЦРНЕ екипе. Исправна одлука?",
                    QuestionNumber = "7.14",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Goal for WHITE team",
                            PhraseNl = "Doelpunt voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Гол З БЕЛУ екипу",
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
                            Phrase = "2-minute suspension for WHITE 9",
                            PhraseNl = "2-minuten uitsluiting voor WIT9",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења против БЕЛОГ 9",
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
                        "WHITE 5 dribbles the ball along the sideline. BLACK obstructs him correctly. To get past BLACK 2, WHITE 5 steps over the sideline with one foot during his dribbling. Correct decision?",
                    PhraseNl =
                        "WIT5 dribbelt de bal langs de zijlijn. ZWART2 spert hem correct. Om voorbij ZWART2 te geraken, loopt WIT5 met 1 voet over de zijlijn terwijl hij dribbelt. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "БЕЛИ 5 води лопту дуж аут линије. ЦРНИ 2 га правилно омета. Да би прошао ЦРНОГ 2, БЕЛИ 5 прекорачи аут линију једном ногом, за време вођења. Исправна одлука?",
                    QuestionNumber = "7.15",
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
                            AnswerNumber = "c",
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
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "After an imprecise pass from WHITE 3 to WHITE 9, the ball rolls towards the sideline near the substitution area of WHITE team. BLACK 10 is one metre away and ready to grab the ball, when WHITE 9 dives for the ball and hits it with his fist towards the centre of the playing court back to WHITE 3. His movement then causes WHITE 9 to slide over the sideline and land outside the court. Correct decision?",
                    PhraseNl =
                        "Na een onnauwkeurige pas van WIT3 naar WIT9, rolt de bal naar de zijlijn richting wisselbank van team WIT. ZWART10 is daar 1 meter van verwijderd en klaar om de bal te pakken, als WIT9 naar de bal duikt en de bal met de vuist in de richting van het midden van het speelveld slaat, terug naar WIT3. Door deze actie glijdt WIT9 nadien over de zijlijn. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "После нетачног додавања БЕЛОГ 3 ка БЕЛОМ 9, лопта се котрља према аут линији близу клупе за резервне играче БЕЛЕ екипе. ЦРНИ 10 је један метар удаљен и спреман да узме лопту, када се БЕЛИ 9 баца за лоптом и избоксује је у правцу средине терена, према играчу БЕЛОМ 3. БЕЛИ 9 затим, услед инерције, проклиже преко аут линије. Исправна одлука?",
                    QuestionNumber = "7.16",
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
                            Phrase = "Progressive punishment for WHITE 9",
                            PhraseNl = "Progressieve bestraffing voor WIT9",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Прогресивна казна против БЕЛОГ 9",
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
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "BLACK 7 of the attacking team assumes a position outside the court without having the ball. The referees indicate to the player that he must return to the court, but he does not react. Correct decision?",
                    PhraseNl =
                        "ZWART7 van het aanvallende team, neemt zonder bal een positie in buiten het speloppervlak. De scheidsrechters geven aan de speler aan dat hij terug in het speelveld moet komen, maar hij reageert niet. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "ЦРНИ 7 из нападајуће екипе заузима позицију ван терена без лопте. Судије су показале играчу да мора да се врати на терен, али он не реагује. Исправна одлука?",
                    QuestionNumber = "7.17",
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
                            Phrase = "Free throw for WHITE team",
                            PhraseNl = "Vrije worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање БЕЛУ екипу",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Progressive punishment for BLACK 7",
                            PhraseNl = "Progressieve bestraffing voor ZWART7",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Прогресивна казна против ЦРНОГ 7",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Throw-in for WHITE team",
                            PhraseNl = "Inworp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Аут за БЕЛУ екипу",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "A player jumps in over the goal area of the opposing team. He has full ball and body control, and he is in a good position to shoot. However, instead of shooting he turns around in mid-air and passes the ball back to a teammate, who passes the ball further. Correct decision?",
                    PhraseNl =
                        "Een speler springt in over het doelgebied van de tegenstander. Hij heeft de bal en zijn lichaam onder controle en bevindt zich in een goede positie om te werpen. In plaats van te werpen, draait hij in de lucht rond en werpt de bal terug naar een medespeler. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Играч ускаче у голманов простор, има пуну контролу над лоптом и телом и у доброј је позицији за шут. Међутим, уместо да шутне у гол, он се окреће у ваздуху и додаје назад лопту саиграчу, који је додаје даље. Исправна одлука?",
                    QuestionNumber = "7.18",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Forewarning signal for passive play",
                            PhraseNl = "Waarschuwingsteken voor passief spel",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Упозоравајући сигнал за пасивну игру",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Immediate free throw because of passive play",
                            PhraseNl = "Onmiddellijke vrije worp wegens passief spel",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Тренутно слободно бацање, због пасивне игре",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Immediate free throw because of unsportsmanlike conduct",
                            PhraseNl = "Onmiddellijke vrije worp wegens onsportieve houding",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Тренутно слободно бацање, због неспортског понашања",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Progressive punishment",
                            PhraseNl = "Progressieve bestraffing",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Прогресивна казна",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE 3 takes a shot on the goal of BLACK team and hits the goalpost. The ball rolls back out of the goal area. At the free-throw line, WHITE 3 and BLACK 4 dive for the ball without endangering each other. BLACK 4 manages to push the ball to BLACK 6, who starts a counter-attack and scores a goal. Correct decision?",
                    PhraseNl =
                        "WIT3 werpt naar het doel van team ZWART en treft de doelpaal. De bal rolt uit het doelgebied. Aan de vrije worplijn duiken WIT3 en ZWART4 naar de bal zonder elkaar in gevaar te brengen. ZWART4 kan de bal naar ZWART6 duwen die een tegenaanval opzet en een doelpunt scoort. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "БЕЛИ 3 шутира на гол ЦРНЕ екипе и погађа стативу. Лопта се откотрља изван голмановог простора. Поред линије слободног бацања, БЕЛИ 3 и ЦРНИ 4 се бацају за лоптом, неугрожавајући један другог. ЦРНИ 4 успе да гурне лопту до ЦРНОГ 6, који креће у контранапад и постиже гол. Исправна одлука?",
                    QuestionNumber = "7.19",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Warning for BLACK 4",
                            PhraseNl = "Waarschuwing voor ZWART 4",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Опомена за ЦРНОГ 4",
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
                            Phrase = "Free throw for WHITE team or BLACK team depending on the circumstances",
                            PhraseNl = "Vrije worp voor team WIT of team ZWART naargelang de situatie",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу или ЦРНУ екипу, у зависности од околности",
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
                        "WHITE 10 tries to pass the ball to WHITE 8, who is at the goal-area line of BLACK team. BLACK 10 stands completely still in front of WHITE 8, when the ball hits his foot. Correct decision?",
                    PhraseNl =
                        "WIT10 probeert de bal naar WIT8 te spelen, die aan de rand van het doelgebied staat. Verdediger ZWART10 staat volledig stil voor WIT8, wanneer de bal zijn voet raakt. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "БЕЛИ 10 покуша да дода лопту БЕЛОМ 8, који је испред голмановог простора ЦРНЕ екипе. ЦРНИ 10 мирно стоји испред БЕЛОГ 8 и лопта га погађа у ногу. Исправна одлука?",
                    QuestionNumber = "7.20",
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
                            Phrase = "Game continues without interruption",
                            PhraseNl = "Verder spelen zonder onderbreking",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Игра се наставља без прекида",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Decision depending on who gets the ball",
                            PhraseNl = "Beslissing afhankelijk van wie in balbezit komt",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Зависи ко ухвати лопту",
                            AnswerNumber = "c"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE 15 blocks a pass from BLACK 9, and the ball rolls on the floor. WHITE 15 and BLACK 9 dive for the ball. WHITE 15 catches the ball and dives on the floor. He stands up, takes three steps with the ball and plays the ball to a teammate, who scores a goal. Correct decision?",
                    PhraseNl =
                        "Speler WIT15 blokt een pass van ZWART12, daarna rolt de bal over de vloer. WIT15 en ZWART9 werpen zich naar de bal. WIT15 pakt de bal en schuift over de vloer. Hij staat op, maakt 3 passen met de bal en speelt de bal naar een medespeler, die een doelpunt scoort. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "БЕЛИ 15 блокира додавање ЦРНОГ 9 и лопта се котрља по поду. БЕЛИ 15 и ЦРНИ 9 се бацају за лоптом, БЕЛИ 15 ухвати лопту и падне на под, затим устане, направи 3 корака са лоптом и дода лопту саиграчу који постиже гол. Исправна одлука?",
                    QuestionNumber = "7.21",
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
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE team is leading 24:23 in the 57th minute, but has one less player on the court. The court referee has given a free throw in favour of WHITE 3. WHITE 6 tries to execute the free throw several metres away from the correct spot, even though the referee has shown the correct spot very clearly. Correct decision?",
                    PhraseNl =
                        "Team WIT leidt in de 57e minuut met 24:23 maar heeft een speler minder op het speelveld. De veldscheidsrechter heeft een vrije worp aan WIT3 toegekend. WIT6 wil de vrije worp uitvoeren, meerdere meters van de correcte plaats, ondanks dat de scheidsrechter duidelijk de plaats van uitvoering aangeduid heeft. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "БЕЛА екипа води резултатом 24:23 у 57. минуту и има једног играча мање на терену него ЦРНА екипа. Судија у пољу досуђује слободно бацање у корист БЕЛОГ 3. БЕЛИ 6 покушава да изведе слободно бацање очигледно неколико метара даље од исправног места и поред тога што су судије јасно показале тачно место извођења бацања. Исправна одлука?",
                    QuestionNumber = "7.22",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Correction of the position, restart signal, no other action",
                            PhraseNl =
                                "Correctie van de plaats van uitvoering, fluitsignaal voor uitvoering worp, geen verdere maatregelen",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Корекција позиције, сигнал за наставак игре, без даљих одлука",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Correction of the position, restart signal, and referees show the forewarning signal for passive play",
                            PhraseNl =
                                "Correctie van de plaats van uitvoering, fluitsignaal voor uitvoering worp, scheidsrechters tonen waarschuwingsteken voor passief spel",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Корекција позиције, сигнал за наставак игре, судије показују упозоравајући сигнал за пасивну игру",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Correction of the position, progressive punishment against WHITE 6, restart signal, and referees show the forewarning signal for passive play",
                            PhraseNl =
                                "Correctie van de plaats van uitvoering, progressieve bestraffing tegen WIT6, fluitsignaal voor uitvoering van de worp en scheidsrechters tonen waarschuwingsteken voor passief spel",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Корекција позиције, прогресивна казна против БЕЛОГ 6, сигнал за наставак игре, упозоравајући сигнал за пасивну игру",
                            AnswerNumber = "c"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "BLACK team is playing with one player less. The players of BLACK team have already assumed their positions in attack and started the build-up phase. Now, BLACK 6 and BLACK 8 decide to leave the court for a substitution. Correct decision?",
                    PhraseNl =
                        "Team ZWART speelt met één speler minder op het speelveld. De spelers van team ZWART hebben reeds hun aanvallende posities ingenomen en hebben reeds de opbouwfase ingezet. Nu beslissen ZWART6 en ZWART8 om het speelveld te verlaten voor een wissel. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "ЦРНА екипа игра са једним играчем мање. Играчи ЦРНЕ екипе су већ заузели своје позиције у нападу и започињу припремну фазу напада. Тада ЦРНИ 6 и ЦРНИ 8 одлуче да напусте поље за игру и изврше замену. Исправна одлука?",
                    QuestionNumber = "7.23",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Forewarning signal",
                            PhraseNl = "Waarschuwingsteken voor passief spel",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Упозоравајући сигнал",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Forewarning signal if there is no increase in tempo within 5 seconds",
                            PhraseNl =
                                "Waarschuwingsteken voor passief spel indien er binnen de 5 seconden geen tempoverhoging is",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Упозоравајући сигнал, ако они не повећају темпо игре у наредних 5 секунди",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Immediate free throw for WHITE team because of passive play",
                            PhraseNl = "Onmiddellijke vrije worp voor team WIT wegens passief spel",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Одмах слободно бацање за БЕЛу А, због пасивне игре",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Warning for BLACK 6 or BLACK 8 if repeated",
                            PhraseNl = "Waarschuwing voor ZWART6 of ZWART8 in geval van herhaling",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Опомена за ЦРНОМ 6 и ЦРНОМ 8 у случају понављања",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for BLACK 6 or BLACK 8 if repeated",
                            PhraseNl = "2-minuten uitsluiting voor ZWART6 of ZWART8 in geval van herhaling",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења против ЦРНОГ 6 и ЦРНОГ 8 у случају понаваљања",
                            AnswerNumber = "e"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase = "Which of the following actions nullify the forewarning signal?",
                    PhraseNl =
                        " Door welke van de volgende handelingen wordt het waarschuwingssignaal voor passief spel opgeheven?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "После чега упозоравајући сигнал за пасивну игру престаје да важи?",
                    QuestionNumber = "7.24",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "Renewed ball possession for attacking team after goalkeeper saves a 7-metre throw",
                            PhraseNl =
                                "Bij nieuw balbezit voor het aanvallende team nadat de doelverdediger een 7m-worp afweerde",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Враћање лопте у посед нападајуће екипе, после одбране седмерца од стране голмана",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Renewed ball possession for attacking team after the ball rebounds from the crossbar or the goalpost",
                            PhraseNl =
                                "Bij nieuw balbezit voor het aanvallende team nadat de bal terugspringt van de doelpaal/dwarsbalk",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Враћање лопте у посед нападајуће екипе, после њеног одбијања од пречке или стативе",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Team time-out",
                            PhraseNl = "Team time-out",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Екипни тајм-аут",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Forceful action before the team’s next passive actions",
                            PhraseNl = "Pressiespel voordat het team zijn volgende passieve acties",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Екипа убрзава игру, пре него што поново почиње да игра још спорије",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "None of the actions under points a-d",
                            PhraseNl = "Door geen enkele van de voorgaande acties in a-d",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Сваки од поступака од а) до д)",
                            AnswerNumber = "e"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "Which of the following instructions regarding the forewarning signal for passive play (IHF hand signal 17) are correct?",
                    PhraseNl =
                        "Welke van de volgende instructies met betrekking tot het waarschuwingsteken voor passief spel (IHF-handgebaar 17) zijn correct:",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Која од следећих инструкција је исправна у погледу упозоравајућег сигнала за пасивну игру (ИХФ сигнал број 17)?",
                    QuestionNumber = "7.25",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "If a tendency to passive play is noticed, this is first shown by the goal-line referee using hand signal 17. The court referee then raises his arm in the same way.",
                            PhraseNl =
                                "Wanneer een tendens tot passief spel onderkend wordt geeft eerst de doelscheidsrechter dit aan met het IHF-handgebaar 17. De veldscheidsrechter heft dan, op dezelfde wijze, de arm op.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Судија код гола је уочио пасивну игру и показао сигнал број 17, а након што је то видео судија у пољу је показао исти сигнал руком",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "If the team in possession of the ball requests a team time-out after the forewarning signal has been shown, then the forewarning signal must be shown again, when the game is restarted.",
                            PhraseNl =
                                "Indien, na het tonen van het waarschuwingsteken, het aanvallende team een team-time-out aanvraagt dan moet het waarschuwingsteken na het hernemen van het spel opnieuw getoond worden.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Ако екипа која има лопту у поседу затражи екипни тајм-аут, када је упозоравајући сигнал већ био показан, тада упозоравајући сигнал мора бити поново показан када се игра буде наставила.",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "If the team in possession of the ball makes no clear effort to get in a position to shoot on goal, after the forewarning signal has been shown, then either the court referee or the goal-line referee gives a free throw because of passive play.",
                            PhraseNl =
                                "Indien het team in balbezit na het tonen van het waarschuwingsteken geen duidelijke poging onderneemt om tot een doelworp te komen, dan geeft ofwel de veldscheidsrechter of de doelscheidsrechter een vrije worp omwille van.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Ако екипа која има лопту у поседу не чини јасан напор да дође у позицију за шут, након што је показан знак упозорења за пасивну игру, онда ће судија у пољу или судија код гола досудити слободно бацање због пасивне игре",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "After the forewarning signal is shown, the referees decide on passive play at the latest when no shot on goal is taken after four passes.",
                            PhraseNl =
                                "Nadat het waarschuwingsteken is getoond, beslissen scheidsrechters op passief spel uiterlijk wanneer geen worp op doel ondernomen is na 4 passes.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "После показивања упозоравајућег сигнала судије одлучују о пасивној игри најкасније онда када шут није изведен после 4. додавања",
                            AnswerNumber = "d",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE team delay the execution of a throw-off. The team has already been cautioned for this type of tactical delay earlier. Correct decision?",
                    PhraseNl =
                        "Team WIT vertraagd de uitvoering van de beginworp. Het team werd reeds eerder voor dezelfde tactische vertraging gewaarschuwd. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "БЕЛА А одуговлачи са извођењем почетног бацања. Екипа је већ раније била упозорена за ово тактичко понашање. Исправна одлука?",
                    QuestionNumber = "7.26",
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
                            Phrase = "Time-out; throw-off after whistle signal",
                            PhraseNl = "Time-out, beginworp na fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Тајм-аут; почетно бацање после звучног сигнала за наставак",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Time-out; throw-off after whistle signal, immediate hand signal for passive play",
                            PhraseNl = "Time-out, beginworp na fluitsignaal, onmiddellijk handgebaar voor passief spel",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Тајм-аут; почетно бацање после звучног сигнала за наставак; моментални сигнал за пасивну игру",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Whistle signal for throw-off, immediate hand signal for passive play",
                            PhraseNl = "Fluitsignaal voor de beginworp, onmiddellijk handgebaar voor passief spel",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Почетно бацање после звучног сигнала за наставак; моментални сигнал за пасивну игру",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Progressive punishment for the responsible team official from WHITE team",
                            PhraseNl = "Progressieve bestraffing van de verantwoordelijke team official van team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Прогресивна казна за одговорног представника БЕЛЕ екипе",
                            AnswerNumber = "e"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "Which of the following statements regarding the correct use of the forewarning signal for passive play are correct?",
                    PhraseNl =
                        "Welke van de volgende uitspraken met betrekking tot het correct gebruik van het waarschuwingsteken voor passief spel zijn correct?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Које од следећих тврдњи су тачне, а тичу се употребе упозоравајућег сигнала за пасивну игру?",
                    QuestionNumber = "7.27",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "The forewarning signal is always to be stopped when a team official from the defending team is given a progressive punishment during the course of an attack.",
                            PhraseNl =
                                "Het waarschuwingsteken moet altijd gestopt worden, wanneer een team official van het verdedigende team een progressieve bestraffing krijgt tijdens de loop van een aanval",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Упозоравајући сигнал увек престаје да важи када званичник одбрамбене екипе добије прогресивну казну",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "When the forewarning signal is shown for the first time during an attack, the arms must be taken down after about ten seconds.",
                            PhraseNl =
                                "Wanneer het waarschuwingsteken tijdens een aanval voor de eerste maal getoond werd moet de arm na ongeveer 10 seconden omlaag gebracht worden",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Када је упозоравајући сигнал показан први пут за време напада, руке морају бити спуштене после десетак секунди",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "The forewarning signal must be repeated as a reminder after the first interruption, if it has been shown before the interruption.",
                            PhraseNl =
                                "Het waarschuwingsteken moet als herinnering na de eerste onderbreking herhaald worden indien het voor de onderbreking reeds getoond werd.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Упозоравајући сигнал мора бити поновљен, као подсетник, после првог прекида, ако је био показан пре прекида",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "The forewarning signal is always to be stopped when a player from the defending team is given a progressive punishment during the course of an attack.",
                            PhraseNl =
                                "Het handgebaar moet altijd gestopt worden wanneer een speler van het verdedigende team progressieve bestraft wordt in de loop van een aanval.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Упозоравајући сигнал увек престаје да важи када одбрамбени играч буде прогресивно кажњен",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "The referees must show the forewarning signal when a player has the ball clearly under control.",
                            PhraseNl =
                                "De scheidsrechters moeten het waarschuwingsteken voor passief spel tonen wanneer een speler de bal duidelijk onder controle heeft.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Судије морају показати упозоравајући сигнал кад играч има лопту јасно под контролом",
                            AnswerNumber = "e",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase = "Which of the following statements regarding passive play are correct?",
                    PhraseNl = "Welke van de volgende uitspraken met betrekking tot passief spel zijn correct?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Које су од следећих тврдњи везаних за пасивну игру тачне?",
                    QuestionNumber = "7.28",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "A team must not be allowed more than five seconds to move from the build-up phase to the finishing phase.",
                            PhraseNl =
                                "Een team mag niet meer dan 5 seconden toegestaan worden om van de opbouwfase naar de afwerkingsfase te gaan.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Еикпи није дозвољено више од 5 секунди да пређе из фазе припреме напада у фазу завршетка напада",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "The referees must be aware of slow and late substitutions after the throw-off has already been executed.",
                            PhraseNl =
                                "De scheidsrechters moeten attent zijn voor het langzame en late wisselen van spelers na de beginworp reeds werd uitgevoerd.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Судије морају да обрате пажњу на успорену и закаснелу замену, након што је почетно бацање изведено",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "The referees must observe if the team is trying to increase the tempo or gain a spatial advantage during the build-up phase.",
                            PhraseNl =
                                "De scheidsrechters moeten waarnemen wanneer team probeert om het tempo op te drijven of een ruimtelijk voordeel probeert te winnen gedurende de opbouwfase.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Судије морају да обрате пажњу на то да ли екипа у фази изградње напада покушава да убрза темпо или само да стекне просторну предност",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "The referees must look out for passive play as soon as a team has gained ball possession in its own half of the court.",
                            PhraseNl =
                                "De scheidsrechters moeten opmerkzaam zijn voor passief spel van zodra het team in balbezit komt in zijn eigen speelhelft.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Судије морају да обрате пажњу на пасивну игру чим екипа има лопту на својој половини",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "A team that has tried to make a counter-attack must be allowed a normal substitution when switching from counter-attacking to a normal build-up phase.",
                            PhraseNl =
                                "Een team dat een poging tot tegenaanval heeft ondernomen moet de mogelijkheid krijgen om normaal te wisselen wanneer het overgaat van deze tegenaanval naar een normale opbouwfase.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Екипи која покуша да изведе контранапад мора бити дозвољена нормална замена, ако је контранапад прекинут и започета је нормална изградња напада",
                            AnswerNumber = "e",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE team is in possession of the ball. The referees show the forewarning signal for passive play. After one pass, WHITE 5 takes a shot on goal. The shot is blocked by BLACK 2, and the ball bounces back to WHITE 5, who passes the ball to WHITE 9. How many passes have been completed?",
                    PhraseNl =
                        "Team WIT is in balbezit. De scheidsrechters tonen het waarschuwingsteken voor passief spel. Na 1 pass werpt WIT5 naar doel. De worp wordt geblokkeerd door ZWART2 en de bal springt terug naar WIT5, die de bal doorspeelt naar WIT9. Hoeveel passen werden er gegeven?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "БЕЛА екипа има лопту у поседу, судије показују упозоравајући сигнал за пасивну игру. После једног додавања, БЕЛИ 5 шутира на гол. ЦРНИ 2 је блокирао шут и лопта се враћа БЕЛОМ 5 који је додаје БЕЛОМ 9. Колико је додавања учињено?",
                    QuestionNumber = "7.29",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "3",
                            PhraseNl = "3",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "3",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "4",
                            PhraseNl = "4",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "4",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "5",
                            PhraseNl = "5",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "5",
                            AnswerNumber = "c"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE team is in possession of the ball. The referees show the forewarning signal for passive play. WHITE 9 tries to pass the ball to WHITE 2, but the pass is blocked by BLACK 8, and the ball bounces back to WHITE 9. WHITE 9 tries to break through the defence, but is rewarded a free throw. WHITE 8 executes the free throw by passing the ball to WHITE 2. How many passes have been completed?",
                    PhraseNl =
                        "Team WIT is in balbezit. De scheidsrechters tonen het waarschuwingsteken voor passief spel. WIT9 probeert de bal door te spelen naar WIT2, maar de worp wordt geblokkeerd door ZWART8 en de bal springt terug naar WIT9. WIT9 probeert door de verdediging van team ZWART te dringen, maar krijgt een vrije worp. WIT8 voert de vrije worp uit door de bal naar WIT2 te spelen. Hoeveel passen werden er gegeven?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "БЕЛА екипа има лопту у поседу, судије показују упозоравајући сигнал за пасивну игру. БЕЛИ 9 покуша да дода лопту БЕЛОМ 2, али лопту блокира ЦРНИ 8 и лопта се одбије назад БЕЛОМ 9. БЕЛИ 9 покушава да се пробије кроз одбрану и добије слободно бацање. БЕЛИ 8 изводи слободно бацање додајући лопту БЕЛОМ 2. Колико је додавања учињено?",
                    QuestionNumber = "7.30",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "1",
                            PhraseNl = "1",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "1",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "2",
                            PhraseNl = "2",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "3",
                            PhraseNl = "3",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "3",
                            AnswerNumber = "c"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE team is in possession of the ball. The referees notice a passive tendency in the play of WHITE team. The referees show the forewarning signal for passive play. BLACK team sees that the forewarning signal is shown, and they become more aggressive in defence, trying to cause a free throw. After three passes by WHITE team, BLACK team causes a free throw. Correct decision?",
                    PhraseNl =
                        "Team WIT is in balbezit. De scheidsrechters onderkennen een passieve trend in het spel van team WIT. De scheidsrechters tonen het waarschuwingsteken voor passief spel. Team ZWART ziet dat het waarschuwingsteken getoond is en zij worden agressiever in de verdediging, en proberen een vrije worp te veroorzaken. Na 3 passen van team WIT, veroorzaakt team ZWART een vrije worp. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "БЕЛА екипа има лопту у поседу, судије уочавају тенденцију ка пасивној игри БЕЛЕ екипе и показују знак упозорења за пасивну игру. ЦРНА екипа уочава показан сигнал и почиње да игра много агресивније у одбрани, правећи прекршаје за слободно бацање. После 3 додавања БЕЛЕ екипе, ЦРНА екипа направи прекршај за слободно бацање. Исправна одлука?",
                    QuestionNumber = "7.31",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "WHITE team has 4 passes left to take a shot on goal.",
                            PhraseNl = "Team WIT heeft nog 4 passen om een doelworp te ondernemen.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "БЕЛОЈ екипи је преостало 4 додавања до шута на гол",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "WHITE team has 2 passes left to take a shot on goal.",
                            PhraseNl = "Team WIT heeft nog 2 passen om een doelworp te ondernemen.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "БЕЛОЈ екипи су преостала 2 додавања до шута на гол",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "WHITE team has 1 pass left to take a shot on goal.",
                            PhraseNl = "Team WIT heeft nog 1 pas om een doelworp te ondernemen.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "БЕЛОЈ екипи је преостало још 1 додавање до шута на гол",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "WHITE team has to execute the free throw as a direct shot on goal.",
                            PhraseNl = "Team WIT moet de vrije worp als een directe worp op doel uitvoeren.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "БЕЛА екипа мора да изведе слободно бацање као директан шут на гол",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE team is in attack. The referees notice a passive tendency in the play of WHITE team and show the forewarning signal. WHITE team passes the ball four times, before WHITE 9 takes a shot on goal. The shot is blocked by BLACK 3, and the ball goes over the sideline for a throw-in for WHITE team. Correct decision?",
                    PhraseNl =
                        "Team WIT is in aanval. De scheidsrechters onderkennen een passieve trend in het spel van team WIT en tonen het waarschuwingsteken voor passief spel. Team WIT past de bal 4 maal, vooraleer WIT9 een worp naar doel uitvoert. De worp wordt geblokt door ZWART3 en gaat over de zijlijn buiten met een inworp voor team WIT. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "БЕЛА екипа је у нападу, судије уочавају тенденцију ка пасивној игри БЕЛЕ екипе и показују упозоравајући сигнал. БЕЛА екипа је направила четири додавања пре него што је БЕЛИ 9 шутирао на гол. Шут је блокирао ЦРНИ 3 и лопта одлази преко аут линије. Аут је за БЕЛУ екипу. Исправна одлука?",
                    QuestionNumber = "7.32",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "The forewarning signal is no longer valid.",
                            PhraseNl = "Het waarschuwingsteken is niet meer geldig.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Упозоравајући сигнал за пасивну игру више не важи",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "WHITE team has 4 passes left to take a shot on goal.",
                            PhraseNl = "Team WIT heeft nog 4 passen om een doelworp te ondernemen.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "БЕЛОЈ екипи је преостало 4 додавања до шута на гол",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "WHITE team has 2 passes left to take a shot on goal.",
                            PhraseNl = "Team WIT heeft nog 2 passen om een doelworp te ondernemen.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "БЕЛОЈ екипи су преостала 2 додавања до шута на гол",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "WHITE team has 1 pass left to take a shot on goal.",
                            PhraseNl = "Team WIT heeft nog 1 pas om een doelworp te ondernemen.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "БЕЛОЈ екипи је преостало још 1 додавање до шута на гол",
                            AnswerNumber = "d",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE team is in possession of the ball, and because of a passive tendency in the play of WHITE team the referees show the forewarning signal. After 4 passes WHITE 5 takes a shot on goal. BLACK 3 blocks the shot, and the ball returns to WHITE 5. Correct decision?",
                    PhraseNl =
                        "Team WIT is in balbezit, en omwille van de passieve trend in het spel van team WIT, tonen de scheidsrechters het waarschuwingsteken. Na 4 passen werpt WIT5 naar doel. ZWART3 blokt de worp, en de bal gaat terug naar WIT5. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Лопта је у поседу БЕЛЕ екипе и због тенденције ка пасивној игри БЕЛЕ екипе судије показују упозоравајући сигнал. После 4 додавања БЕЛИ 5 шутира на гол. ЦРНИ 3 блокира шут и лопта се враћа БЕЛОМ 5. Исправна одлука?",
                    QuestionNumber = "7.33",
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
                            Phrase = "WHITE team has 1 pass left to take a shot on goal.",
                            PhraseNl = "Team WIT heeft nog 1 pas om naar doel te werpen.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "БЕЛОЈ екипи је преостало још једно додавање до шута на гол",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Forewarning signal continues",
                            PhraseNl = "Waarschuwingsteken blijft geldig",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Упозоравајући сигнал за пасивну игру и даље важи",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Forewarning signal is no longer valid",
                            PhraseNl = "Waarschuwingsteken is niet meer geldig",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Упозоравајући сигнал за пасивну игру више не важи",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "WHITE team has no more passes before taking a shot on goal.",
                            PhraseNl = "Team WIT heeft geen passen meer over vooraleer op doel te werpen",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "БЕЛА екипа нема више додавања до шута на гол",
                            AnswerNumber = "e"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "BLACK team are in attack. The referees show the forewarning signal. BLACK 7 passes the ball to BLACK 11. BLACK 11 tries to break through, but is stopped by WHITE 3. The referees give a free throw for BLACK team. BLACK 11 executes the free throw and passes the ball to BLACK 2, who tries to take a shot on goal, but the shot is blocked by defender WHITE 4, and the ball goes to BLACK 11. BLACK 11 takes a shot on goal, but he is pushed lightly by WHITE 5, and goalkeeper WHITE 1 manages to save the shot. What is the correct decision?",
                    PhraseNl =
                        "Team ZWART is in aanval. De scheidsrechters tonen het waarschuwingsteken voor passief spel. ZWART7 speelt de bal naar ZWART11. ZWART11 probeert door te breken, maar wordt gestopt door WIT3. De scheidsrechters geven een vrije worp voor team ZWART. ZWART11 voert de vrije worp uit en speelt de bal naar ZWART2, die een worp op doel probeert, maar het schot wordt geblokt door verdediger WIT4 en de bal gaat naar ZWART11. ZWART11 werpt naar doel, maar hij wordt lichtjes geduwd door WIT5 en de doelman WIT1 slaagt erin om het schot te stoppen. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "ЦРНА екипа је у нападу. Судије показују знак за пасивну игру. ЦРНИ 7 додаје лопту ЦРНОМ 11. ЦРНИ 11 покушава проћи али је заустављен од стране БЕЛОГ 3. Судије досуђују слободно бацање за ЦРНУ екипу. ЦРНИ 11 изводи слободно бацање и додаје ЦРНОМ 2 који шутира према голу, али је ударац блокиран од одбрамбеног БЕЛОГ 4, те се лопта одбија назад до ЦРНОГ 11. ЦРНИ 11 упућује ударац на гол, али је лагано одгурнут од БЕЛОГ 5, те голман БЕЛИ 1 успева одбранити ударац. Која је исправна одлука ?",
                    QuestionNumber = "7.34",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "Free throw for BLACK team; new attack, because BLACK team manage to get possession of the ball after a shot on goal.",
                            PhraseNl =
                                "Vrije worp voor team ZWART; nieuwe aanval, omdat team ZWART in balbezit komt na de worp op doel.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за ЦРНЕ; нови напад, зато што је ЦРНА екипа стекла поново посед лопте",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team; forewarning signal, BLACK team have used two passes.",
                            PhraseNl =
                                "Vrije worp voor team ZWART; waarschuwingsteken passief spel, team ZWART heeft 2 passes gebruikt.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за ЦРНЕ; знак за пасивни напад, ЦРНА екипа је већ искористила два додавања",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Free throw for BLACK team; forewarning signal, BLACK team have used three passes.",
                            PhraseNl =
                                "Vrije worp voor team ZWART; waarschuwingsteken passief spel, team ZWART heeft 3 passes gebruikt.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за ЦРНЕ; знак за пасивни напад, ЦРНА екипа је већ искористила три додавања",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team; forewarning signal, BLACK team have used four passes",
                            PhraseNl =
                                "Vrije worp voor team ZWART; waarschuwingsteken passief spel, team ZWART heeft 4 passes gebruikt",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за ЦРНЕ; знак за пасивни напад, ЦРНА екипа је већ искористила четири додавања",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "The score is 27-27 with 20 seconds left of the match. WHITE team play without goalkeeper. The forewarning signal is shown by the referees. After three passes, WHITE 8 passes the ball to WHITE 7, who takes a shot on goal. The ball is blocked by defender BLACK 2, and the ball passes the side line. Shortly after the throw-in is executed, the whistle sounds from the table, because WHITE team have requested a team time-out. How should the match be restarted?",
                    PhraseNl =
                        "De score is 27-27 met nog 20 seconden te gaan in de wedstrijd. Team WIT speelt zonder doelverdediger. Het waarschuwingsteken wordt getoond door de scheidsrechters. Na drie passes, speelt WIT8 de bal naar WIT7, die naar doel werpt. De bal wordt geblokt door verdediger ZWART2 en de bal gaat over de zijlijn. Kort nadat de inworp is uitgevoerd, weerklinkt het signaal van de wedstrijdtafel, omdat team WIT een team-time-out heeft aangevraagd. Hoe moet het spel hernomen worden?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Резултат је 27:27 и остало је још 20 секунди до краја утакмице. БЕЛА екипа игра без голмана. Показан је знак упозорења за пасивну игру. Након три додавања, БЕЛИ 8 додаје лопту саиграчу БЕЛОМ 7 који након тога шутира на гол. Шут је блокиран од стране одбрамбеног играча ЦРНОГ 2 и лопта прелази аут линију. Непосредно након извођења аута, чује се звучни сигнал са записничког стола зато што је БЕЛА екипа затражила екипни тајм-аут. Како се наставља игра?",
                    QuestionNumber = "7.35",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team.",
                            PhraseNl = "Vrije worp voor team WIT.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Throw-in for WHITE team.",
                            PhraseNl = "Inworp voor team WIT.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Аут за БЕЛУ екипу",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "The throw must be executed as a direct shot on goal.",
                            PhraseNl = "De worp moet uitgevoerd worden als een directe worp naar doel.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Бацање мора бити изведено као директан шут на гол",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Besides the possibility to execute the throw as a direct shot on goal, the thrower may pass the ball to a teammate.",
                            PhraseNl =
                                "Naast de mogelijkheid om de worp uit te voeren als een directe worp naar doel, mag de werper de bal naar een ploegmaat spelen.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Осим могућности да бацање буде изведено као директан шут на гол, извођач има право да дода лопту саиграчу",
                            AnswerNumber = "d",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE team plays in attack. Two passes after the forewarning signal has been shown by the referees, WHITE 7 shoots on goal. The ball is blocked by BLACK 8. WHITE 8 receives the rebound and tries to shoot on goal. Again, the ball is blocked by BLACK 8. WHITE 8 receives the ball after the block and plays the ball to WHITE 6, who has a clear chance of scoring. WHITE 6 is pulled down from behind by BLACK 7 in a way that he totally loses body control. What is the correct decision?",
                    PhraseNl =
                        "Team WIT is in aanval. Twee passes nadat het waarschuwingsteken voor passief spel door de scheidsrechters werd getoond, werpt WIT7 naar doel. De bal wordt geblokt door ZWART8. WIT8 krijgt de terugkaatsende bal en probeert op doel te werpen. Opnieuw wordt de bal geblokt door ZWART8. WIT8 krijgt de bal na het blok en speelt de bal naar WIT6, die een duidelijke doelkans heeft. WIT6 wordt langs achter neergetrokken door ZWART7 zodanig dat hij zijn lichaamscontrole verliest. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "БЕЛА екипа је у нападу. Одиграно је 2 додавања након упозоравајућег сигнала за пасивну игру и потом БЕЛИ 7 шутира на гол. Шут је блокиран од стране ЦРНОГ 8. БЕЛИ 8 хвата одбијену лопту и покушава да шутне на гол. Шут је опет блокиран од стране ЦРНОГ 8. БЕЛИ 8 прихвата одбијену лопту и додаје саиграчу БЕЛОМ 6 који је у јасној ситуацији за постизање гола. БЕЛИ 6 је оборен са леђа од стране ЦРНОГ 7 тако да потпуно изгуби контролу над телом. Која је исправна одлука?",
                    QuestionNumber = "7.36",
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
                            Phrase = "Direct 2-minute suspension for BLACK 7",
                            PhraseNl = "Directe 2-minuten uitsluiting voor ZWART7",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Искључење на 2 минута за ЦРНОГ 7",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification for BLACK 7 (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie voor ZWART7 (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Дисквалификација за ЦРНОГ 7 (црвени картон)",
                            AnswerNumber = "d",
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
                            AnswerNumber = "e"
                        },
                        new AnswerDto
                        {
                            Phrase = "Time-out",
                            PhraseNl = "Time-out",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Тајм-аут",
                            AnswerNumber = "f",
                            Correct = true
                        }
                    ]
                }
            ]
        };
    }
}
