using IHF.Rules.Questions.Infrastructure.DataSeed.Models;

namespace IHF.Rules.Questions.Infrastructure.DataSeed;

public static partial class Rules
{
    public static RuleDto GetRule09()
    {
        return new RuleDto
        {
            Name = "Scoring",
            NameNl = "Het maken van een doelpunt",
            NameFr = "Validité du but",
            NameSvn = "Zadetek",
            NameDe = "Der Torgewinn",
            NameSrb = "Постизање гола",
            RuleNumber = "9",
            Questions =
            [
                new QuestionDto
                {
                    Phrase =
                        "WHITE 7 is standing in the centre of defence, when BLACK 3 tries to play a bounce pass to the line player. WHITE 7 tries to stop the ball by clearly lifting his foot. While doing so he kicks the ball into the goal of WHITE team. Correct decision?",
                    PhraseNl =
                        "WIT7 staat in het midden van de verdediging wanneer ZWART3 probeert een bots de bal naar de cirkelspeler te geven. WIT7 probeert de bal te stoppen door de voet duidelijk op te heffen. Door zo te doen stampt hij de bal in het doel van team WIT. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "БЕЛИ 7 стоји у средини одбране своје екипе. Када ЦРНИ 3 покуша да дода лопту одбијањем о тло. БЕЛИ 7 покуша да заустави лопту тако што видно подиже своју ногу. Након тога ногом шутне лопту која одлази у гол БЕЛЕ екипе. Исправна одлука?",
                    QuestionNumber = "9.1",
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
                            PhraseSrb = "Гол за ЦРНУ",
                            AnswerNumber = "b",
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
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension against WHITE 7",
                            PhraseNl = "2-minuten uitsluiting tegen WIT7",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Искључење на 2 минута за БЕЛОГ 7",
                            AnswerNumber = "d",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "A shot by WHITE 5 bounces back from the goalpost of BLACK team. It deflects off the foot of BLACK 3, who is standing in the playing area, into the goal of BLACK team. Correct decision?",
                    PhraseNl =
                        "De worp van WIT5 springt terug van de doelpaal van team ZWART. De bal devieert via de voet van ZWART3 die in het veld staat in het doel van ZWART. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Лопта се после шута БЕЛОГ 5 одбија од стативе гола ЦРНЕ екипе, погађа у ногу ЦРНОГ 3, који стоји пољу за игру и улази у гол ЦРНЕ екипе. Исправна одлука?",
                    QuestionNumber = "9.2",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team",
                            PhraseNl = "Vrije worp voor WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Goal for WHITE team",
                            PhraseNl = "Doelpunt voor WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Гол за БЕЛУ екипу",
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
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "The ball has been stopped by goalkeeper WHITE 1 and bounces back from defender WHITE 3’s back, who is standing two metres inside the goal area, into the goal of WHITE team. Correct decision?",
                    PhraseNl =
                        "De bal werd gestopt door de doelman WIT1 en springt terug van de rug van verdediger WIT3, die 2 meter in het doelgebied staat, en gaat in het doel van WIT. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Голман БЕЛИ 1 је одбранио шут, а лопта се одбија од одбрамбеног играча БЕЛОГ 3, који стоји два метра у голмановом простору, и уђе у гол БЕЛЕ екипе. Исправна одлука?",
                    QuestionNumber = "9.3",
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
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Progressive punishment against WHITE 3",
                            PhraseNl = "Progressieve bestraffing voor WIT3",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Прогресивна казна против БЕЛОГ 3",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Goal for BLACK team",
                            PhraseNl = "Doelpunt voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Гол за ЦРНУ екипу",
                            AnswerNumber = "d",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "Goalkeeper WHITE 1 holds the ball for four seconds in a position where three quarters of the ball have already passed the goal line. Correct decision?",
                    PhraseNl =
                        "Doelman WIT1 houdt de bal gedurende 4 seconden vast in een positie waarbij drie kwart van de bal de doellijn overschreden heeft. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Голман БЕЛИ 1 држи лопту четири секунде у положају у којем је она са три четвртине свога обима прешла гол линију. Исправна одлука?",
                    QuestionNumber = "9.4",
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
                            Phrase = "Goalkeeper throw for WHITE team",
                            PhraseNl = "Uitworp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Голманово бацање за БЕЛУ екипу",
                            AnswerNumber = "c",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE 3 enters his team’s goal area and tries to stop a shot with his foot, but the ball deflects off his foot into the goal of WHITE team. Correct decision?",
                    PhraseNl =
                        "WIT3 betreedt zijn eigen doelgebied en probeert, een worp met de voet af te weren, maar de bal springt daarbij van zijn voet in het doel van team WIT. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "БЕЛИ 3 уђе у голманов простор своје екипе и покуша да заустави лопту ногом, али се лопта одбија од његове ноге и уђе у гол БЕЛЕ екипе. Исправна одлука?",
                    QuestionNumber = "9.5",
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
                        "WHITE 11 takes a lob shot over goalkeeper BLACK 1, who is standing far in front of the goal. Just before the ball crosses the goal line, the manager of BLACK team, who has been sitting in the first spectators’ row behind the goal and is not listed on the score sheet, pushes the ball away. Correct decision?",
                    PhraseNl =
                        "WIT11 werpt een boogballetje over de doelman van ZWART, die ver voor zijn doel staat. Net vooraleer de bal de doellijn overschrijdt, duwt de manager van team ZWART, die in de eerste rij toeschouwers achter het doel zat en niet op het wedstrijdblad staat, de bal weg. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "БЕЛИ 11 лобује голмана ЦРНОГ 1 који стоји далеко испред гола. Пре него што лопта пређе гол линију, директор ЦРНЕ екипе, који седи у првом реду гледалишта иза гола и није уписан у записник, избаци лопту. Исправна одлука?",
                    QuestionNumber = "9.6",
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
                            Phrase =
                                "Disqualification of BLACK team’s manager with written report (red and blue cards shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie van de teammanager van ZWART met schriftelijk verslag (rode en blauwe kaart gegeven door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Дисвалификација директора ЦРНЕ екипе са писаним извештајем (црвени и плави картон показани од стране судија)",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Written report",
                            PhraseNl = "Schriftelijk verslag",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Писани извештај",
                            AnswerNumber = "d",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "The score is 25:25 with two seconds to play in the match. An official of WHITE team (home team), who is not listed on the score sheet, intercepts the ball, which is flying high in the direction of the empty goal. This action spoils a goal for BLACK team. Immediately after this action, the final signal sounds. Correct decision?",
                    PhraseNl =
                        "Bij een stand van 25:25, met nog 2 seconden te spelen in de wedstrijd. Een official van team WIT (thuisploeg) die niet op het wedstrijdformulier ingeschreven staat, onderschept de bal die hoog in de richting van het lege doel vliegt. Deze actie verhindert zo een doelpunt van team ZWART. Onmiddellijk na deze actie weerklinkt het eindsignaal. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "При резултату 25:25 и две секунде пре краја утакмице, званичник БЕЛЕ екипе (домаћа екипа) , који није уписан у записник утакмица, ухвати лопту која лети директно у празан гол и тиме спречи гол за ЦРНУ екипу. Одмах потом огласи се сигнал за крај утакмице. Исправна одлука?",
                    QuestionNumber = "9.7",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "The final score is 25:25.",
                            PhraseNl = "Eindstand 25:25.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Коначан резултат 25:25",
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
                            Phrase = "The final score is 25:26.",
                            PhraseNl = "Eindstand 25:26.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Коначан резултат 25:26",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of the official with written report (red and blue cards shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie van de official met een schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Дисквалификација званичника са писаним извештајем (црвени и плави картон показани од стране судија)",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "Written report",
                            PhraseNl = "Schriftelijk verslag",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Писани извештај",
                            AnswerNumber = "e",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "BLACK 9 takes a 7-metre throw and scores. WHITE team immediately takes a fast throw-off after the referee’s whistle. After two passes, WHITE 4 scores a goal. At this moment, the timekeeper whistles and informs that BLACK 9, who has returned to the bench in the meantime, had 20 seconds left of a 2-minute suspension at the time of the 7-metre throw. Correct decision?",
                    PhraseNl =
                        "ZWART9 neemt een 7m-worp en scoort. Team WIT neemt een snelle beginworp na het fluitsignaal van de scheidsrechter. Na twee passen, scoort WIT4 een doelpunt. Op dit ogenblik fluit de tijdopnemer en deelt mee dat ZWART9, die intussen naar de wisselbank is teruggekeerd, nog 20 seconden van zijn tijdelijke uitsluiting had moeten uitzitten op het ogenblik van de 7m-worp. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "ЦРНИ 9 постиже гол из седмерац. БЕЛА екипа одмах изводи почетно бацање, после судијског звиждука. После два додавања БЕЛИ 4 постиже гол. У том тренутку мерилац времена свира и информише да је ЦРНОМ 9, који се вратио на клупу, остало још 20 секунди од искључења на 2 минута, у време извођења седмерца. Исправна одлука?",
                    QuestionNumber = "9.8",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for BLACK team must be repeated",
                            PhraseNl = "De 7m-worp voor team ZWART moet herhaald worden",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за ЦРНУ екипу се мора поновити",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "BLACK 9 receives additional suspension",
                            PhraseNl = "ZWART9 krijgt een bijkomende uitsluiting",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "ЦРНИ 9 добија додатну казну",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Both goals are valid.",
                            PhraseNl = "Beide doelpunten zijn geldig.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Оба гола су исправна",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Both goals are invalid.",
                            PhraseNl = "Beide doelpunten zijn ongeldig",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Оба гола нису исправна",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "Just before the end of the match, when the result is 22:21 for his team, WHITE 5 has correctly executed a throw-off. The ball goes back in the direction of the goal of WHITE team. Goalkeeper WHITE 1 does not touch the ball, as he is in his goal area. The ball goes into the goal. The teammates of WHITE 5 had crossed the centre line after the referee’s whistle, but before the ball was played, running in the direction of the goal of BLACK team. Correct decision?",
                    PhraseNl =
                        "Net voor het einde van de wedstrijd bij een 22-21 stand in het voordeel van zijn team, heeft WIT5 op correcte wijze een correcte beginworp uitgevoerd. De bal gaat terug in de richting van het doel van team WIT. De doelverdediger WIT1 raakt de bal niet aan omdat hij nog in zijn doelgebied staat. De bal gaat in het doel. De medespelers van WIT5 hebben de middenlijn overschreden in de richting van het doel van team ZWART na het fluitsignaal van de scheidsrechter maar voor de bal gespeeld werd. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Мало пре краја утакмице при резултату 22:21 за његову екипу, БЕЛИ 5 је исправно извео почетно бацање. Лопта је иде назад у правцу гола БЕЛЕ екипе. Голман БЕЛИ 1 не додирује лопту, мада је се налази у сопственом голмановом простору. Лопта улази у гол. Саиграчи БЕЛОГ 5 су прешли средишњу линију после судијског звиждука, али пре него што је лопта напустила руку извођача, трћечи у правцу гола ЦРНЕ екипе. Исправна одлука?",
                    QuestionNumber = "9.9",
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
                            Phrase = "Repetition of the throw-off after whistle signal",
                            PhraseNl = "Herhaling van de beginworp na fluitsignaal",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Понављање почетног бацања после звучног сигнала",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Personal punishment for WHITE 5",
                            PhraseNl = "Persoonlijke bestraffing tegen WIT5",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Прогресивна казна против БЕЛОГ 5",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "Time-out",
                            PhraseNl = "Time-out",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Тајм - аут",
                            AnswerNumber = "e"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE 9 tries to stop a low shot with his lower leg by clearly lifting his foot. In doing so he kicks the ball, which goes into his own goal. This is the second time that he tries to stop a shot with his leg. Correct decision?",
                    PhraseNl =
                        "WIT9 weert een lage worp af met zijn onderbeen door duidelijk zijn voet op te heffen. Op deze wijze schopt hij de bal die in zijn eigen doel gaat. Het is de tweede maal dat hij probeert om een worp met de voet af te weren. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "БЕЛИ 9 покуша да заустави низак шут потколеницом тако што видно подиже ногу, али то чини тако да скреће лопту у властити гол. Ово је други пут да он покушава да заустави шут ногом. Исправна одлука?",
                    QuestionNumber = "9.10",
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
                            Phrase = "2-minute suspension against WHITE 9",
                            PhraseNl = "2-minuten uitsluiting tegen WIT9",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Искључење на 2 минута за БЕЛОГ 9",
                            AnswerNumber = "c",
                            Correct = true
                        }
                    ]
                }
            ]
        };
    }
}
