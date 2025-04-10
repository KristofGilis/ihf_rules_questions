using IHF.Rules.Questions.Infrastructure.DataSeed.Models;

namespace IHF.Rules.Questions.Infrastructure.DataSeed;

public static partial class Rules
{
    public static RuleDto GetRule04()
    {
        return new RuleDto
        {
            Name = "The Team, Substitutions, Equipment, Player Injuries",
            NameNl = "De Ploeg, Wisselen van spelers, Kleding, Blessures",
            NameFr = "L’équipe, Les changements, L’équipement, Blessures",
            NameSvn = "Moštvo, Menjave, Oprema, Poškodbe Igralcev",
            NameDe = "Mannschaften, Spielerwechsel, Ausrüstung, Spielerverletzung",
            NameSrb = "Екипа, замена играча, опрема",
            RuleNumber = "4",
            Questions =
            [
                new QuestionDto
                {
                    Phrase =
                        "Shortly before the beginning of the game, WHITE 11 is severely injured in a way that he is unable to play. Correct decision?",
                    PhraseNl =
                        "Kort voor het begin van de wedstrijd wordt speler WIT11 zo zwaargekwetst dat hij niet meer kan spelen. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Мало пре почетка утакмице БЕЛИ 11 се тешко повреди, тако да није у стању да игра. Исправна одлука?",
                    QuestionNumber = "4.1",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "WHITE 11 cannot be replaced.",
                            PhraseNl = "WIT11 mag niet meer vervangen worden.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "БЕЛИ 11 не може бити замењен",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "WHITE 11 can be replaced if the opponents accept this.",
                            PhraseNl = "WIT11 mag vervangen worden indien de tegenstrever hiermee akkoord gaat.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "БЕЛИ 11 се може заменити, ако противник то прихвати",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Normally, WHITE 11 can be replaced in the match report and his substitute can wear number 11. However, the referees may have to observe special deviating regulations for the respective competition.",
                            PhraseNl =
                                "Normaal, mag WIT11 vervangen worden op het wedstrijdblad en zijn vervanger mag het nummer 11 dragen. Maar de scheidsrechters moeten kijken naar speciale afwijkende reglementeringen voor de betreffende competitie.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "БЕЛИ 11 може бити замењен, његова замена сме носити број 11 и мора бити уписан у записник утакмице. Судије, ипак, треба да сагледају специјалне разлике пропозиција за одређена такмичења",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "WHITE 11 can be replaced, but his substitute cannot wear number 11.",
                            PhraseNl = "WIT11 mag vervangen worden, maar zijn vervanger mag niet met het nr 11 spelen.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "БЕЛИ 11 може бити замењен, али његова замена не сме носити број 11",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "BLACK team appear with five court players. The goalkeeper is not present at the beginning of the game. BLACK team appoint court player BLACK 5 as goalkeeper. What are the consequences for BLACK 5?",
                    PhraseNl =
                        "Team ZWART verschijnt met 5 veldspelers. De doelverdediger is niet aanwezig bij het begin van de wedstrijd. Team ZWART duidt veldspeler ZWART5 aan als doelman. Wat zijn de gevolgen voor ZWART5?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "ЦРНА екипа излази на терен са пет играча у пољу. На почетку утакмице голман није присутан. ЦРНА екипа одреди играча ЦРНОГ 5 као голмана. Које су последице за ЦРНОГ 5?",
                    QuestionNumber = "4.2",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "BLACK 5 can be used as a court player at any time, when he makes a correct substitution.",
                            PhraseNl =
                                "ZWART5 kan op ieder ogenblik als veldspeler gebruikt worden, voor zover hij correct gewisseld wordt.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "ЦРНИ 5 се може користити као играч у пољу, у било које време, ако се направи правилна замена",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "BLACK 5 can no longer be used as a court player.",
                            PhraseNl = "ZWART5 kan niet meer als veldspeler ingezet worden.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "ЦРНИ 5 се не може више користити као играч у пољу",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "BLACK 5 can be used as a court player if the officials of WHITE team accept this.",
                            PhraseNl =
                                "ZWART5 kan als veldspeler ingezet worden, indien de teamverantwoordelijke van team WIT akkoord gaat.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "ЦРНИ 5 се може користити као играч у пољу, ако то прихвате званичници БЕЛЕ екипе",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "BLACK 5 can be used as a court player, as soon as the intended goalkeeper is present.",
                            PhraseNl =
                                "ZWART5 kan als veldspeler ingezet worden zodra de voorziene doelman aanwezig is.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "ЦРНИ 5 се може користити као играч у пољу, чим предвиђени голман буде био присутан",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "Just after the match has started, the club president of WHITE team sits down on the bench in the substitution area with two team officials, the masseur and the coach. What are the consequences?",
                    PhraseNl =
                        "Net nadat de wedstrijd gestart is, zet de voorzitter van team WIT zich naast de 2 team officials, de kinesist en de trainer, op de wisselbank. Wat zijn de consequenties?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Одмах након почетка утакмице, председник БЕЛЕ екипе је сео на клупу са два званичника, физиотарапеутом и тренером. Које су последице?",
                    QuestionNumber = "4.3",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "The substitute goalkeeper must stand behind the bench.",
                            PhraseNl = "De reservedoelman moet achter de bank plaatsnemen.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Резервни голман мора стајати иза клупе",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "The club president must leave the substitution area.",
                            PhraseNl = "De clubvoorzitter moet de wisselbank verlaten.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Председник мора напустити простор за замену играча",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "One of the officials must leave the substitution area.",
                            PhraseNl = "Een van de officials moet de wisselbank verlaten.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Један од званичника мора напустити простор за замену играча",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Whoever is not included in the score sheet must leave the substitution area.",
                            PhraseNl =
                                "Wie niet op het wedstrijdblad ingeschrevene staat, moet de wisselzone verlaten.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Ко није уписан у записник утакмице мора напустити простор за замену играча",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "The responsible team official gets a progressive punishment.",
                            PhraseNl = "De teamverantwoordelijke krijgt een progressieve bestraffing.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "“одговорног представника” екипе добија прогресивну казну",
                            AnswerNumber = "e",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "What is the minimum number of players that must be present on the court at the beginning of the game and included in the match score sheet?",
                    PhraseNl =
                        "Hoeveel spelers moeten er per team bij het begin van de wedstrijd op het speelveld aanwezig zijn, en ingeschreven zijn op het wedstrijdblad?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Који је најмањи број играча који морају бити присутни на игралишту на почетку утакмице и бити уписани у записник утакмице?",
                    QuestionNumber = "4.4",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Five players",
                            PhraseNl = "5 spelers",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "5 играча",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Four court players and one goalkeeper",
                            PhraseNl = "4 veldspelers en 1 doelman",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "4 играча у пољу и 1 голман",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Five court players and one goalkeeper",
                            PhraseNl = "5 veldspelers en 1 doelman",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "5 играча у пољу и 1 голман",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Six court players",
                            PhraseNl = "6 veldspelers",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "6 играча у пољу",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase = "Four scenarios: Who is entitled to participate?",
                    PhraseNl = "Vier scenario’s: wie is spelgerechtigd?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Четири сценарија: Ко има право наступа?",
                    QuestionNumber = "4.5",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "A player who is present at the beginning of the game and entered in the score sheet",
                            PhraseNl =
                                "Een speler die aanwezig is bij het begin van de wedstrijd en op het wedstrijdblad ingeschreven.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Играч који је присутан на почетку утакмице и уписан у записник са утакмице",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "A player who is not present at the beginning of the game but is entered in the score sheet",
                            PhraseNl =
                                "Een speler die niet aanwezig is bij het begin van de wedstrijd, maar wel op het wedstrijdblad ingeschreven.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Играч који није присутан на почетку утакмице, али је уписан у записник са утакмице",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "A player who is present at the beginning of the game but not entered in the score sheet",
                            PhraseNl =
                                "Een speler die aanwezig is bij het begin van de wedstrijd, maar niet op het wedstrijdblad ingeschreven",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Играч који је присутан на почетку утакмице, али није уписан у записник са утакмице",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "A player who has received permission to play from the timekeeper but is not entered in the score sheet",
                            PhraseNl =
                                "Een speler die toelating gekregen heeft van de tijdwaarnemer, maar niet op het wedstrijdblad is ingeschreven",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Играч који је добио дозволу за играње од мериоца времена, али није уписан у записник",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "At the beginning of the game, there are only six players of WHITE team present. Immediately after the start of the game, the missing players arrive. WHITE 7 runs directly out on the playing court through the substitution area. He is not included in the score sheet. Correct decision?",
                    PhraseNl =
                        "Bij het begin van de wedstrijd zijn slechts 6 spelers van team WIT aanwezig. Onmiddellijk na het begin van de wedstrijd komen de ontbrekende spelers toe. WIT7 loopt direct via de wisselzone van zijn ploeg op het speelveld. Hij is niet op het wedstrijdblad ingeschreven. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "На почетку утакмице присутно је само 6 играча БЕЛЕ екипе. Непосредно после почетка утакмице пољављују се и остали играчи. БЕЛИ 7 утрчава у поље за игру кроз простор за замену играча. Он није уписан у записник утакмице. Која је правилна одлука?",
                    QuestionNumber = "4.6",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Disqualification of WHITE 7 (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie van WIT7 (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Дисквалификација БЕЛОГ 7 (црвени картон показан од стране судија)",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 7, who must be included in the score sheet",
                            PhraseNl =
                                "2-minuten uitsluiting voor WIT7, die op het wedstrijdblad moet ingeschreven worden",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Искључење на 2 минута БЕЛОГ 7, који мора да се упише у записник са утакмице",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "WHITE 7 must be entered in the score sheet, if this is in accordance with the regulations of the responsible federation",
                            PhraseNl =
                                "WIT7 moet op het wedstrijdblad ingeschreven worden, indien dit in overeenstemming is met de reglementen van de verantwoordelijke federatie",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "БЕЛИ 7 мора бити уписан у записник, уколико је ово у складу са прописима одговорне федерације",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Progressive punishment against the responsible team official of WHITE team",
                            PhraseNl = "Progressieve bestraffing van de teamverantwoordelijke van team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Прогресивно кажњавање “одговорног представника” БЕЛЕ екипе",
                            AnswerNumber = "d",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "The referees have awarded a free throw for WHITE team at the free-throw line of BLACK team. Now, there is a whistle signal from the timekeeper, who stops the clock. The referees enquire about the reason for the intervention. The timekeeper informs the referees that WHITE 9 made a faulty substitution. Correct decision?",
                    PhraseNl =
                        "De scheidsrechters hebben een vrije worp toegekend aan team WIT, aan de vrije worplijn van team ZWART. Nu weerklinkt er een fluitsignaal van de tijdwaarnemer, die de klok stopt. De scheidsrechters vragen naar de reden van de interventie. De tijdwaarnemer informeert de scheidsrechters dat WIT9 een wisselfout beging. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Судије су досудиле слободно бацање за БЕЛУ екипу, са линије слободног бацања ЦРНЕ екипе. Мало затим, чује се звиждук мериоца времена који зауставља сат. Судије су обавештене о разлогу интервенције мериоца времена. Мерилац времена обавештава судије да је играч А9 направио погрешну измену. Исправна одлука?",
                    QuestionNumber = "4.7",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team at the free-throw line of BLACK team",
                            PhraseNl = "Vrije worp voor team WIT aan de vrije worplijn van team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу са линије слободног бацања ЦРНЕ екипе",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team at the team’s own free-throw line",
                            PhraseNl = "Vrije worp voor team ZWART aan de eigen vrije worplijn",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за ЦРНУ екипу са своје линије слободног бацања",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team at the substitution area of WHITE team",
                            PhraseNl = "Vrije worp voor team ZWART aan de wisselzone van team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за ЦРНу екипу код простора за замену играча БЕЛЕ екипе",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 9",
                            PhraseNl = "2-minuten uitsluiting voor WIT9",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута казне за БЕЛОГ 9",
                            AnswerNumber = "d",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "BLACK 14 makes a correct substitution, while the game is interrupted. However, a whistle comes from the timekeeper’s table. BLACK 14 is not entered correctly in the score sheet. It is found that this player has number 18 in the score sheet. Correct decision?",
                    PhraseNl =
                        "ZWART14 wisselt bij een spelonderbreking correct. Desondanks komt er een fluitsignaal van de wedstrijdtafel. ZWART14 is niet correct op het wedstrijdblad ingeschreven. Blijkt dat deze speler nr 18 heeft op het wedstrijdblad. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "ЦРНИ 14 прави исправну замену док је утакмица у прекиду. Међутим, са записничког стола се огласи мерилац времена. ЦРНИ 14 није уписан у записник утакмице. Установи се да тај играч носи број 18 у записнику утакмице. Исправна одлука?",
                    QuestionNumber = "4.8",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Progressive punishment against the responsible team official from BLACK team",
                            PhraseNl = "Progressieve bestraffing van de teamverantwoordelijke van team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Прогресивна казна за “одговорног представника” ЦРНЕ екипе Б",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team at the timekeeper’s table",
                            PhraseNl = "Vrije worp voor team WIT bij de wedstrijdtafel",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу код записничког стола",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "The number is to be corrected in the score sheet.",
                            PhraseNl = "Correctie van het nummer op het wedstrijdblad.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Број треба исправити у записнику утакмице",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "The game is continued with the throw corresponding to the situation, and there must be a written report.",
                            PhraseNl =
                                "Het spel wordt hernomen met een aan de spelsituatie aangepaste worp, en er moet een schriftelijk verslag gemaakt te worden.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Игра се наставља бацањем које одговара ситуацији. Писани извештај.",
                            AnswerNumber = "d",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "When is it permitted for up to two people from one team (team officials and/or players) to enter the court?",
                    PhraseNl =
                        "Wanneer is het toegestaan aan twee personen van een team (team officials en/of spelers) om het speelveld te betreden?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Када је дозвољено да “две особе“ (званичници екипе и/или играчи) уђу поље за игру?",
                    QuestionNumber = "4.9",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "During a match interruption",
                            PhraseNl = "Tijdens een wedstrijd onderbreking",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "За време прекида игре",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "During a match interruption and with permission from a referee",
                            PhraseNl = "Tijdens een wedstrijd onderbreking en met toestemming van een scheidsrechter",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "За време тајм-аута, након дозволе судија",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "When a player is injured",
                            PhraseNl = "Wanneer een speler gekwetst is",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Када је играч повређен",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "With permission from the timekeeper",
                            PhraseNl = "Met toestemming van de tijdwaarnemer",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "После дозволе од стране мериоца времена",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "The referee whistles to indicate a time-out because WHITE 2 is being given his third 2-minute suspension. As the referee turns to the timekeeper and scorekeeper to report the disqualification, the responsible team official from WHITE team runs onto the court to protest about the suspension. Team official B from WHITE team has previously already been given a warning. Correct decision?",
                    PhraseNl =
                        "De SR fluit en geeft een Time-out aan omdat WIT2 zijn derde 2-minuten uitsluiting heeft gekregen. Wanneer de SR naar tijdwaarnemer en de secretaris gaat om de diskwalificatie mee te delen, loopt de verantwoordelijke team official van team WIT het speelveld op, om tegen deze uitsluiting te protesteren. Team official B van Team WIT had voordien reeds waarschuwing gekregen. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Судија свира и показује тајм-аут, јер је играчу БЕЛОМ 2 досуђено треће искључење на 2 минута. Судија се окрене према мериоцу времена и записничару да пријави дисквалификацију, а одговорни представник БЕЛЕ екипе утрчи у поље за игру протестујући против искључења. Званичник Б БЕЛЕ екипе већ је раније добио опомену. Исправна одлука?",
                    QuestionNumber = "4.10",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of responsible team official from WHITE team (red card shown by the referees) and a reduction of WHITE team by an additional player for 2 minutes",
                            PhraseNl =
                                "Diskwalificatie van de verantwoordelijke team official van team WIT (rode kaart getoond door de scheidsrechters) en reductie van team WIT met een bijkomende speler voor 2 minuten",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Дисквалификација одговорног представника БЕЛЕ екипе (црвени картон показан од стране судија) и редукција БЕЛЕ екипе за једног играча у пољу на 2 минута",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Personal warning for responsible team official from WHITE team",
                            PhraseNl = "Persoonlijke waarschuwing voor de verantwoordelijke team official van team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Лична опомена одговорном представнику БЕЛЕ екипе",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of responsible team official from WHITE team with a written report (red and blue cards shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie van de verantwoordelijke team official van team WIT met een schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Дисквалификација одговорног представника БЕЛЕ екипе са писаним извештајем (црвени и плави картон показани од стране судија)",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for responsible team official from WHITE team",
                            PhraseNl = "2-minuten uitsluiting voor de verantwoordelijke team official van team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења за одговорног представника БЕЛЕ екипе",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Reduction of WHITE team by an additional player for 2 minutes on the court",
                            PhraseNl = "Reductie van team WIT met een bijkomende speler voor 2’ op het speelveld",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Редукција БЕЛЕ екипе за додатног играча 2 минута на терену",
                            AnswerNumber = "e",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "During a time-out due to a player’s injury, WHITE 2 runs onto the court as an additional player although neither one of the referees has given him permission to enter the court. Correct decision?",
                    PhraseNl =
                        "Gedurende een time-out wegens een kwetsuur van een speler, loopt WIT2 als een bijkomende speler op het speelveld, zonder dat een van de scheidsrechter toelating gegeven heeft om het speelveld te betreden. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "За време тајм-аута због повреде играча, БЕЛИ 2 утрчи као додатни играч у поље за игру, иако ниједан од судија није дао одобрење за улазак на терен. Исправна одлука?",
                    QuestionNumber = "4.11",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Warning for WHITE 2",
                            PhraseNl = "Waarschuwing voor WIT2",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Опомена за БЕЛОГ 2",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Progressive punishment against the responsible team official from WHITE team",
                            PhraseNl = "Progressieve bestraffing tegen de verantwoordelijke team official van team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Прогресивна казна за одговорног представника БЕЛЕ екипе",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification of WHITE 2 (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie van WIT2 (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Дисквалификација БЕЛОГ 2 (црвени картон показан од стране судија)",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "2-minute suspension for WHITE 2 and a reduction of his team by 1 player on the court for 2 minutes",
                            PhraseNl =
                                "2-minuten uitsluiting voor WIT2 en reductie van team WIT op het veld met een 1 speler gedurende 2’",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "2 минута искључења за БЕЛОГ 2 и редукција његове екипе за једног играча на терену на 2 минута",
                            AnswerNumber = "d",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE 5 is injured on the court, and the court referee indicates a time-out and gives permission for two people from WHITE team to enter the court to assist WHITE 5. Team official B from BLACK team also enters the court to give advice to his goalkeeper. Correct decision?",
                    PhraseNl =
                        "WIT5 is gekwetst op het speelveld en de veldscheidsrechter geeft een time-out aan en geeft toelating aan 2 personen van team WIT om op het speelveld te komen om WIT5 bij te staan. De teamofficial B van team ZWART betreedt eveneens het speelveld om zijn doelman aanwijzingen te geven. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "БЕЛИ 5 је повређен на терену и судија у пољу показује тајм-аут дајући дозволу да две особе из БЕЛЕ екипе уђу на терен и помогну БЕЛОМ 5. Званичник Б ЦРНЕ екипе такође уђе на терен и даје савете свом голману. Исправна одлука?",
                    QuestionNumber = "4.12",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "No decision, the signal allows all players and officials to enter the court.",
                            PhraseNl =
                                "Geen beslissing, het signaal laat alle spelers en officials toe om het speelveld te betreden.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Нема казне, сигнал дозвољава свим играчима и званичницима да уђу на терен",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "All four officials of BLACK team receive a warning and if the episode is repeated they must be disqualified.",
                            PhraseNl =
                                "Alle vier officials van team ZWART krijgen een waarschuwing, en bij herhaling moeten ze gediskwalificeerd worden.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Сва четири званичника ЦРНЕ екипе добијају опомене и ако се то буде поновило морају бити дисквалификовани",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "The responsible team official of BLACK team receives a warning.",
                            PhraseNl = "De verantwoordelijke team official van team ZWART krijgt een waarschuwing.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Одговорни представник ЦРНЕ екипе добија опомену",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Progressive punishment against team official B from BLACK team",
                            PhraseNl = " Progressieve bestraffing van de teamofficial B van team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Прогресивна казна званичнику Б ЦРНЕ екипе",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "After receiving medical care on the playing court, WHITE 5 has to leave the court immediately, and he can only re-enter the court following the third attack of his team.",
                            PhraseNl =
                                "Na medische verzorging op het speelveld ontvangen te hebben, moet WIT5 onmiddellijk het speelveld verlaten en mag hij pas terug opkomen na de derde aanval van zijn team.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Након указане медицинске помоћи на терену БЕЛИ 5 мора одмах да напусти терен и може се поново вратити након три напада његове екипе",
                            AnswerNumber = "e",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "Goalkeeper WHITE 16 has been injured and must be replaced by WHITE 5. WHITE 5 changes his shirt. After 20 minutes, WHITE 16 is ready to play again, and the team official A from WHITE team makes a substitution. WHITE 5 changes his shirt again and is sent in as a court player again without notification to the scorekeeper. Correct decision?",
                    PhraseNl =
                        "Doelman WIT16 is gekwetst en moet vervangen worden door WIT5. WIT5 wisselt zijn kleding. Na 20 minuten is WIT16 weer inzetbaar en de team official A van team WIT wisselt hem terug. WIT5 wisselt zijn shirt opnieuw en wordt opnieuw als veldspeler ingezet zonder de wedstrijdsecretaris te verwittigen. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Голман БЕЛИ 16 је повређен и мора бити замењен БЕЛИМ 5. БЕЛИ 5 мења дрес. После 20 минута БЕЛИ 16 је поново спреман да игра и званичник А БЕЛЕ екипе врши замену. БЕЛИ 5 поново мења дрес и улази као играч у пољу, без јављања записничару. Исправна одлука?",
                    QuestionNumber = "4.13",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "No punishment, as this is allowed",
                            PhraseNl = "Geen bestraffing, gezien dit toegelaten is",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Нема казне, то је дозвољено",
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
                            Phrase = "2-minute suspension for WHITE 5",
                            PhraseNl = "2-minuten uitsluiting voor WIT5",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута казне за БЕЛОГ 5",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification of WHITE 5 (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie voor WIT5 (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Дисквалификација БЕЛОГ 5 (црвени картон показан од стране судија)",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE 4 leaves the playing court beyond the substitution line. When WHITE 4 has crossed the sideline but not yet arrived in his substitution area, WHITE 11 crosses the line correctly to enter the playing court. What is the correct decision after the whistle from the timekeeper?",
                    PhraseNl =
                        "WIT4 verlaat het speeloppervlak buiten de wisselzone. Nadat WIT4 de zijlijn overschreden heeft, maar nog voor hij in zijn wisselzone is aangekomen, overschrijdt WIT11 de wissellijn op de juiste plaats om het speelveld te betreden. Wat is de correcte beslissing na het fluitsignaal van de tijdwaarnemer?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "БЕЛИ 4 напушта терен изван линија за замену играча. Када је БЕЛИ 4 прешао уздужну линију, али пре него што је стигао у свој простор за замену играча, БЕЛИ 11 исправно прелази линију и улази на терен. Исправна одлука после звиждука мериоца времена?",
                    QuestionNumber = "4.14",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team where WHITE 4 left the court",
                            PhraseNl =
                                "Vrije worp voor team ZWART op de plaats, waar WIT4 het speeloppervlak verlaten heeft",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за ЦРНУ екипу са места где је БЕЛИ 4 напустио терен",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team at height of the substitution area of WHITE team",
                            PhraseNl = "Vrije worp voor team ZWART aan de wisselzone van team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за ЦРНУ екипу у висини простора за замену играча БЕЛЕ екипе",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 4",
                            PhraseNl = "2-minuten uitsluiting voor WIT4",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења за БЕЛОГ 4",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 11",
                            PhraseNl = "2-minuten uitsluiting voor WIT11",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута иксључења за БЕЛОГ 11",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 4 and WHITE 11",
                            PhraseNl = "2-minuten uitsluiting voor WIT4 en WIT11",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења за БЕЛОГ 4 и БЕЛОГ 11",
                            AnswerNumber = "e"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "BLACK 3 makes the first faulty substitution for his team during an interruption of the match. The interruption was caused by a free-throw decision in favour of BLACK team. BLACK 3 has neither been warned nor suspended earlier in the match. Correct decision?",
                    PhraseNl =
                        "ZWART3 begaat de eerste wisselfout van zijn ploeg tijdens een spelonderbreking. De onderbreking was gefloten voor een vrije worp beslissing in het voordeel van team ZWART. ZWART3 had tot op dat ogenblik noch een waarschuwing, noch een tijdstraf gehad. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "ЦРНИ 3 прави прву погрешну замену за своју екипу, за време прекида игре. Игра је прекинута досуђивањем слободног бацања за ЦРНУ екипу. ЦРНИ 3 до тада није био кажњаван. Исправна одлука?",
                    QuestionNumber = "4.15",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Warning for BLACK 3",
                            PhraseNl = "Waarschuwing voor ZWART3",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Опомена ЦРНОМ 3",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for BLACK 3",
                            PhraseNl = "2-minuten uitsluiting voor ZWART3",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења за ЦРНОГ 3",
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
                        "After the referees have awarded a 7-metre throw to WHITE team, WHITE 27, who has been designated to carry out the 7-metre throw, makes a faulty substitution. Correct decision?",
                    PhraseNl =
                        "Nadat de scheidsrechters een 7m worp hebben toegekend aan team WIT, maakt WIT27, die als werper aangeduid was om de 7m uit te voeren, een wisselfout. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Након што су судије досудиле седмерац за БЕЛУ екипу, БЕЛИ 27, који је одређен да изведе седмерац, прави погрешну замену. Исправна одлука?",
                    QuestionNumber = "4.16",
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
                            Phrase = "2-minute suspension for WHITE 27",
                            PhraseNl = "2-minuten uitsluiting voor WIT27",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења за БЕЛОГ 27",
                            AnswerNumber = "d",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE team have scored a goal. The referees have not yet whistled for the throw-off to be taken, when BLACK 10 enters the court before BLACK 6 has left it. Correct decision?",
                    PhraseNl =
                        "Team WIT heeft een doelpunt gescoord. De scheidsrechters hebben nog niet gefloten voor de beginworp, wanneer ZWART10 het speloppervlak betreedt, vooraleer ZWART6 dit verlaten heeft. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "БЕЛА екипа је постигла гол. Судије још увек нису дале знак да се изведе почетно бацање, када ЦРНИ 10 улази на терен, пре него што је ЦРНИ 6 напустио терен. Исправна одлука?",
                    QuestionNumber = "4.17",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Throw-off",
                            PhraseNl = "Beginworp",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Почетно бацање",
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
                            Phrase = "2-minute suspension for BLACK 10",
                            PhraseNl = "2-minuten uitsluiting voor ZWART10",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења за ЦРНОГ 10",
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
                            PhraseSrb = "2 минута искључења за ЦРНОГ 6",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE team only have twelve players present at the beginning of the match, as the two goalkeepers are still missing. WHITE team therefore start with one of the twelve court players as a goalkeeper. Which of the following alternatives are correct?",
                    PhraseNl =
                        "Team WIT heeft slechts 12 spelers aanwezig bij het begin van de wedstrijd, omdat de 2 voorziene doelwachters nog niet aanwezig zijn. Team WIT begint daarom met een van de twaalf veldspelers als doelman. Welke van de volgende alternatieven zijn correct?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "БЕЛА екипа има само 12 играча присутних на почетку утакмице, будући да два голмана још увек нису стигла. БЕЛА екипа стога почиње са једним од 12 играча у пољу као голманом. Која је од понуђених алтернатива исправна?",
                    QuestionNumber = "4.18",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "The court player who starts the match as a goalkeeper must be registered as number 1, 12 or 16 in the score sheet.",
                            PhraseNl =
                                "De veldspeler die als doelman de wedstrijd begon moet met het nummer 1, 12 of 16 op het wedstrijdblad vermeld worden",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Играч у пољу, који почиње утакмицу као голман, мора имати број 1, 12 или 16 у записнику утакмице",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "The court player who starts the match as a goalkeeper can also be used as a court player later in the game.",
                            PhraseNl =
                                "De veldspeler die als doelman de wedstrijd begon kan later ook als veldspeler ingezet worden.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Играч у пољу, који почиње утакмицу као голман, може касније играти утакмицу као играч у пољу",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "The late-arriving goalkeepers of WHITE team must be registered as number 1, 12 or 16 in the score sheet.",
                            PhraseNl =
                                "De later toekomende doelwachters van team WIT moeten op het wedstrijdblad onder de nummers 1,12 of 16 ingevuld worden",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Касније пристигли голмани БЕЛЕ екипе морају имати бројеве 1, 12 или 16 у записнику утакмице",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "One of the two late-arriving goalkeepers can only be used as a court player.",
                            PhraseNl =
                                "Een van de later toekomende doelwachters van team WIT kan enkel nog als veldspeler ingezet worden.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Један од два заказнела голмана може се користити само као играч у пољу",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "During a time-out, WHITE 5 makes the first faulty substitution of his team. WHITE team were in possession of the ball when the time-out was called. Correct decision?",
                    PhraseNl =
                        "Tijdens een time-out begaat speler WIT5 de eerste wisselfout van zijn ploeg. Team WIT was in balbezit toen de time-out gefloten werd. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "За време тајм-аута, БЕЛИ 5 направи прву неправилну замену за своју екипу. БЕЛА екипа је имала лопту у поседу када је дат тајм-аут. Исправна одлука?",
                    QuestionNumber = "4.19",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "No punishment",
                            PhraseNl = "Geen bestraffing",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Нема казне",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Warning for WHITE 5",
                            PhraseNl = "Waarschuwing voor WIT5",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Опомена за БЕЛОГ 5",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 5",
                            PhraseNl = "2-minuten uitsluiting voor WIT5",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Искључење на 2 минута за БЕЛОГ 5",
                            AnswerNumber = "c",
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
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "WHITE team remain in possession of the ball",
                            PhraseNl = "Team WIT blijft in balbezit",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Лопта остаје у поседу БЕЛЕ екипе",
                            AnswerNumber = "e",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "Goalkeeper WHITE 3 wants to carry out a 7-metre throw. To protect the empty goal WHITE 15 enters the court in a goalkeeper uniform replacing a court player. Correct decision?",
                    PhraseNl =
                        "Doelman WIT3 wil een 7m-worp uitvoeren. Om het lege doel te beschermen, betreedt WIT15 in doelwachterstrui het speelveld, nadat hij tegen een veldspeler is gewisseld. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Голман БЕЛИ 3 треба да изведе седмерац. Ради заштите празног гола, БЕЛИ 15 улази у поље за игру у дресу голмана мењајући играча у пољу. Исправна одлука?",
                    QuestionNumber = "4.20",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 3",
                            PhraseNl = "2-minuten uitsluiting voor WIT3",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења за БЕЛОГ 3",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 15",
                            PhraseNl = "2-minuten uitsluiting voor WIT15",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења за БЕЛОГ 15",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "No punishment",
                            PhraseNl = "Geen bestraffing",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Нема кажњавања",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for WHITE team",
                            PhraseNl = "7-m worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за БЕЛУ екипу",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team at the height of the substitution area of WHITE team",
                            PhraseNl = "Vrije worp voor team ZWART aan de wisselzone van team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за ЦРНУ екипу у висини простора за замену играча БЕЛЕ екипе",
                            AnswerNumber = "e"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "During a counter-attack by WHITE team, who have a clear chance of scoring, BLACK 3 makes a faulty substitution. The timekeeper and scorekeeper do not react, but the court referee spotted what had happened. Correct decision?",
                    PhraseNl =
                        "Bij een tegenaanval van team WIT, die een duidelijke score kans heeft, begaat ZWART3 een wisselfout. De tijdwaarnemer en wedstrijdsecretaris reageren niet, maar de veldscheidsrechter heeft de wisselfout bemerkt. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "За време контранапада БЕЛЕ екипе, која има јасну ситуацију за постизање гола, ЦРНИ 3 направи погрешну замену. Мерилац времена/записничар не реагују, али је судија у пољу уочио шта се догодило. Исправна одлука?",
                    QuestionNumber = "4.21",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Immediate suspension for BLACK 3 and free throw for WHITE team",
                            PhraseNl = "Onmiddellijke tijdelijke uitsluiting voor ZWART3 en vrije worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Тренутно искључење ЦРНОГ 3 и слободно бацање за БЕЛУ екипу",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Immediate suspension for BLACK 3 and 7-metre throw for WHITE team",
                            PhraseNl = "Onmiddellijke tijdelijke uitsluiting voor ZWART3 en 7m-worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Тренутно искључење ЦРНОГ 3 и седмерац за БЕЛУ екипу",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Wait until the chance of scoring has passed, then suspension for BLACK 3 and free throw for WHITE team",
                            PhraseNl =
                                "Doelpoging afwachten, dan tijdelijke uitsluiting voor ZWART3 en vrije worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Сачекати исход гол шансе, затим 2 минута искључења за ЦРНОГ 3 и слободно бацање за БЕЛУ екипу",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Wait until the chance of scoring has passed, then suspension for BLACK 3 and an appropriate throw according to the situation",
                            PhraseNl =
                                "Doelpoging afwachten, dan tijdelijke uitsluiting voor ZWART3 en worp aangepast aan de spelsituatie",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Сачекати исход гол шансе, затим 2 минута искључења за ЦРНОГ 3 и одредити бацање према ситуацији",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "A shot on goal is saved by goalkeeper WHITE 1, and the ball is rolling along the sideline near WHITE team’s substitution bench. WHITE 5, who sits on the substitution bench, now enters the court with one foot to stop the ball, so that WHITE 4 can pick it up before it crosses the sideline. Correct decision?",
                    PhraseNl =
                        "Een doelworp wordt door de doelman van team WIT afgeweerd en de bal rolt langs de zijlijn aan de wisselzone van team WIT voorbij. WIT5, die op de wisselbank zit, komt nu mrt een voet in het speelveld om de bal te stoppen, zodat WIT4 de bal kan oppikken nog voor deze de uitlijn overschrijdt. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Голман БЕЛИ 1 зауставља лопту упућену на гол и лопта се откотрља дуж аута у близини клупе за резервне играче БЕЛЕ А. БЕЛИ 5, који седи на клупи, испружи ногу у поље за игру и заустави лопту тако да је БЕЛИ 4 може подићи пре него што пређе аут линију. Исправна одлука?",
                    QuestionNumber = "4.22",
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
                            Phrase = "2-minute suspension for WHITE 5",
                            PhraseNl = "2-minuten uitsluiting voor WIT5",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења за БЕЛОГ 5",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification of WHITE 5 (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie van WIT5 (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Дисквалификација БЕЛОГ 5 (црвени картон показан од стране судија)",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "WHITE team reduced by 1 player on the court for 2 minutes",
                            PhraseNl = "Team WIT wordt gereduceerd met een speler op het speelveld voor 2 minuten",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "БЕЛА екипа ће бити редукована за једног играча на терену на 2 минута",
                            AnswerNumber = "e",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "30 seconds before his suspension time is over, WHITE 3 enters the court without interfering with the game. WHITE team are in possession of the ball. Correct decision?",
                    PhraseNl =
                        "Dertig seconden voor dat zijn tijdelijke uitsluiting afgelopen is, betreedt speler WIT3 het speloppervlak, zonder echter in het spelgebeuren in te grijpen. Team WIT is in balbezit. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "30 секунди пре истека временске казне, БЕЛИ 3 улази у поље за игру без утицаја на ток игре. БЕЛА екипа има лопту у поседу. Исправна одлука?",
                    QuestionNumber = "4.23",
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
                            Phrase =
                                "2-minute suspension for WHITE 3 and WHITE team are to be further reduced by 1 player on the court for 30 seconds",
                            PhraseNl =
                                "2-minuten uitsluiting voor WIT3, team WIT wordt bijkomend op het veld gereduceerd met 1 speler gedurende 30 sec",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "2 минута искључења за БЕЛОГ 3 и БЕЛА екипа се даље редукује за једног играча у пољу за 30 секунди",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "30 seconds for WHITE 3 and WHITE team are to be reduced by 1 player on the court for 2 minutes",
                            PhraseNl =
                                "30 seconden voor WIT3 en team WIT wordt bijkomend op het veld gereduceerd met 1 speler gedurende 2 minuten",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "30 секунди за играча БЕЛОГ 3 и БЕЛА екипа се даље редукује за једног играча у пољу за игру за 2 минута",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of WHITE 3 (red card shown by the referees) and WHITE team are to be further reduced by 1 player on the court for 30 seconds",
                            PhraseNl =
                                "Diskwalificatie van WIT3 (rode kaart wordt getoond door de scheidsrechters) en team WIT wordt bijkomend gereduceerd op het veld met 1 speler gedurende 30 sec",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Дисквалификација за БЕЛОГ 3 (црвени картон показан од стране судија) и БЕЛА екипа се даље редукује за једног играча у пољу за игру за 30 секунди",
                            AnswerNumber = "e"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE 5 has been suspended. After 1 minute and 45 seconds of the 2-minute suspension, team official A from WHITE team sends him onto the court. Correct decision?",
                    PhraseNl =
                        "WIT5 werd uitgesloten. Na 1’45” van de 2-minuten uitsluiting, wordt hij door zijn team official A het veld opgestuurd. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "БЕЛИ 5 је искључен. Након 1 минута и 45 секунди казне од 2 минута званичник А БЕЛЕ екипе пошаље БЕЛОГ 5 на терен. Исправна одлука?",
                    QuestionNumber = "4.24",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "Another 2-minute suspension for WHITE 5, and WHITE team are to be reduced by 1 player on the court for 2 minutes and 15 seconds",
                            PhraseNl =
                                "Nieuwe 2-minuten uitsluiting voor WIT5, en team WIT wordt op het speelveld gereduceerd met 1 speler voor 2’15”",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Друго искључење на 2 минута за БЕЛОГ 5 и БЕЛА екипа се редукује за једног играча на терену за 2 минута и 15 секунди",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification for WHITE 5 (red card shown by the referees), and WHITE team are to be reduced by 2 players on the court for 15 seconds and by 1 player on the court for 1 minute and 45 seconds",
                            PhraseNl =
                                "Diskwalificatie van WIT5 (rode kaart getoond door de scheidsrechters) en reductie van team WIT met twee spelers op het speelveld gedurende 15 seconden en met 1 speler voor 1’45”",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Дисквалификација играча БЕЛОГ 5 (црвени картон показан од стране судија) и БЕЛА екипе се редукује за два играча на терену за 15 секунди и за једног играча на терену за 1 минут и 45 секунди",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Another 2-minute suspension for WHITE 5, and WHITE team are to be reduced by 2 players on the court for 15 seconds and by 1 player on the court for 1 minute and 45 seconds",
                            PhraseNl =
                                "Nieuwe 2-minuten uitsluiting voor WIT5, en team WIT wordt op het speelveld gereduceerd met twee spelers gedurende 15 seconden en met 1 speler voor 1’45”",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Друго искључење за БЕЛОГ 5 и БЕЛА екипа се редукује за два играча на терену за 15 секунди и за једног играча на терену за 1 минут и 45 секунди",
                            AnswerNumber = "c",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "After his 2-minute suspension has ended, goalkeeper BLACK 1 wants to re-join his team, who are defending at that moment. He enters the court wearing his goalkeeper jersey to assume the wing position, as BLACK team’s sixth court player. Correct decision?",
                    PhraseNl =
                        "Na afloop van zijn 2-minuten uitsluiting wil doelman ZWART1 zijn ploeg die op dat ogenblik in verdediging staat, vervolledigen. Hij betreedt daarom het speelveld in doelman uitrusting en neemt als 6e veldspeler van team ZWART de hoekpositie in. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "По истеку казне од 2 минута искључења, голман ЦРНИ 1 жели да се поново придружи екипи, која је у том моменту у одбрани. Он улази на терен носећи свој голмански дрес и заузима крилну позицију, као шести играч у пољу ЦРНЕ екипе. Исправна одлука?",
                    QuestionNumber = "4.25",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Game continues without interruption",
                            PhraseNl = "Het spel gaat verder zonder onderbreking",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Игра се наставља без прекидања",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "7-metre throw for WHITE team",
                            PhraseNl = "7m- worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Седмерац за БЕЛУ екипу",
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
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for goalkeeper BLACK 1",
                            PhraseNl = "2-minuten uitsluiting voor doelman ZWART1",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења за ЦРНОГ 1",
                            AnswerNumber = "d",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "Which of the following statements are correct regarding a player who is bleeding on the court?",
                    PhraseNl =
                        " Welke van de volgende uitspraken is correct met betrekking tot een speler die op het speelveld bloedt?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Шта је исправно, с обзиром на то да играч крвари на терену?",
                    QuestionNumber = "4.26",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "The player must leave the court immediately and voluntarily.",
                            PhraseNl = "De speler moet het speelveld onmiddellijk en uit eigen beweging verlaten.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Играч мора одмах, добровољно напустити поље за игру",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "The player can remain on the court until the next interruption of the game.",
                            PhraseNl = "De speler kan op het speelveld blijven tot de volgende spelonderbreking.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Играч може остати у пољу за игру, до следећег прекида игре",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "The player who replaces the bleeding player can enter the court beyond the substitution line.",
                            PhraseNl =
                                "De speler die de bloedende speler vervangt mag het speelveld betreden buiten de wisselzone.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Играч који замењује играча који крвари, може ући у поље за игру изван простора за замену играча",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "The player must not re-enter the court until the next interruption of the game.",
                            PhraseNl = "De speler mag het speelveld pas betreden bij de volgende spelonderbreking.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Играч не може поново ући у поље за игу, до следећег прекида игре",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "If the player refuses to follow the instructions of the referees to leave the court, he must be punished for unsportsmanlike conduct.",
                            PhraseNl =
                                "Indien de speler weigert om de instructies van de scheidsrechter op te volgen om het speelveld te verlaten, moet hij bestraft worden voor onsportief gedrag",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Ако играч одбије да следи упуства судије о напуштању поља за игру, мора бити кажњен за неспортско понашање",
                            AnswerNumber = "e",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE 5 is alone with goalkeeper BLACK 1 and has a clear chance of scoring. BLACK 11 makes a faulty substitution, as he enters the court before BLACK 9 has left it. The timekeeper whistles because of this infraction, precisely when WHITE 5 is ready to shoot. Correct decision?",
                    PhraseNl =
                        "WIT5 is alleen met de doelman ZWART1 en heeft een open doelkans. ZWART11 begaat een wisselfout, doordat hij het speelveld betreedt vooraleer ZWART9 dit verlaten heeft De tijdwaarnemer fluit daarom, net op het moment dat WIT5 klaar is om te werpen. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "БЕЛИ 5 је сам са голманом ЦРНИМ 1 и има јасну ситуацију за постизање гола. ЦРНИ 11 прави погрешну замену, тако што улази на терен пре него што је ЦРНИ 9 изашао. Мерилац времена свира због овог прекршаја, тачно када је БЕЛИ 5 спреман да шутира. Исправна одлука?",
                    QuestionNumber = "4.27",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for BLACK 11",
                            PhraseNl = "2-minuten uitsluiting voor ZWART11",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења ЦРНОГ 11",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification for BLACK 11, written report (red and blue cards shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie voor ZWART11, schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Дисквалификација ЦРНОГ 11, писана пријава (црвени и плави картон показани од стране судија)",
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
                        "Goalkeeper BLACK 1 saves a shot and throws the ball to his teammate BLACK 4. Now, BLACK 1 goes to the sideline near his substitution area. He clearly crosses the line, takes a towel and drinks from a water bottle. He is not replaced on the court by another goalkeeper or court player. Correct decision?",
                    PhraseNl =
                        "Doelverdediger ZWART1 stopt een bal, speelt hem naar zijn medespeler ZWART4. Nu gaat ZWART1 naar de zijlijn in de buurt van zijn wisselzone. Hij overschrijdt duidelijk de zijlijn haalt zich een handdoek en drinkt van een fleswater. Hij wordt niet vervangen door een andere doelverdediger of veldspeler. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Голман ЦРНИ 1 је одбранио шут и бацио лопту саиграчу ЦРНОМ 4. Сада голман ЦРНИ 1 иде ка аут линији, према простору за замену играча. Он јасно прелази аут линију, ван простора за замену, да би узео пешкир и попио воде. Он на терену није замењен другим голманом или играчем у пољу. Исправна одлука?",
                    QuestionNumber = "4.28",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "The game continues without interruption, as this is allowed.",
                            PhraseNl = "Verder laten spelen zonder onderbreking, gezien dit toegelaten is",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Игра се наставља, то је дозвољено",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for BLACK 1 for faulty substitution",
                            PhraseNl = "2-minuten uitsluiting voor ZWART1 wegens wisselfout",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења за ЦРНОГ 1 због погрешне замене",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team at the substitution area of BLACK team",
                            PhraseNl = "Vrije worp voor team WIT ter hoogte van de wisselzone van team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу код простора за замену играча ЦРНЕ екипе",
                            AnswerNumber = "c"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "Team official A from BLACK team received a warning earlier in the game. After a decision by the referees, team official D from BLACK team runs several metres onto the court without permission from the referees. Correct decision?",
                    PhraseNl =
                        "De official A van team ZWART heeft eerder in de wedstrijd een waarschuwing gekregen. Na een beslissing van de scheidsrechter rent team official D van team ZWART meerdere meters het speelveld op zonder toestemming van de scheidsrechters. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Званичник А ЦРНЕ екипе је већ добио опомену. На једну судијску одлуку званичник Д исте екипе утрчи неколико метара у поље за игру, без одобрења судија. Исправна одлука?",
                    QuestionNumber = "4.29",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "No punishment",
                            PhraseNl = "Geen bestraffing",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Нема кажњавања",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Warning for team official D from BLACK team",
                            PhraseNl = "Waarschuwing voor team official D van team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Опомена за званичника Д ЦРНЕ екипе",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minutes suspension for team official D from BLACK team",
                            PhraseNl = "2-minuten uitsluiting voor team official D van team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења за званичника Д ЦРНЕ екипе",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification for team official D from BLACK team (red card shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie voor team official D van team ZWART (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Дисквалификација за званичника Д ЦРНЕ екипе (црвени картон показан од стране судија)",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "There is a time-out due to an injury of WHITE 6 caused by an incident that did not lead to a progressive punishment against a player from BLACK team. The referees have given permission for two people to enter the court and assist WHITE 6. Official C from WHITE team assists WHITE 6. Official A from WHITE team pursues BLACK 5, who in his opinion has caused the injury. He follows BLACK 5 into the substitution area of BLACK team and hits him in the face. Correct decision?",
                    PhraseNl =
                        "Er is een time-out door een blessure van WIT6, als gevolg van een incident dat niet geleid heeft tot een progressieve bestraffing tegen de speler van team ZWART. De scheidsrechters geven toestemming aan twee personen om het veld te betreden om WIT6 bij te staan.Official C van team WIT staat WIT6 bij. Official A van team WIT vervolgt ZWART5, die in zijn opvatting de kwetsuur veroorzaakt heeft. Hij volgt ZWART5 tot in de wisselzone van team ZWART en slaat hem in het gezicht. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Дат је тајм-аут због повреде БЕЛОГ 6, која је настала као последица прекршаја играча ЦРНЕ екипе, који није прогресивно кажњен. Судије дају дозволу да две особе уђу на терен и помогну БЕЛОМ 6. Званичник Ц БЕЛЕ екипе помаже БЕЛОМ 6, а званичник А БЕЛЕ екипе јури ЦРНОГ 5, који је према његовом мишљењу проузроковао повреду. Он прати ЦРНОГ 5 у простор за замену ЦРНЕ екипе и удари га у лице. Исправна одлука?",
                    QuestionNumber = "4.30",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of official A from WHITE team, written report (red and blue cards shown by the referees), WHITE team is reduced by 1 player on the court for 2 minutes",
                            PhraseNl =
                                "Diskwalificatie voor official A van team WIT, schriftelijk verslag (rode en blauwe kaart getoond door de scheidsrechters), team WIT wordt op het speelveld met 1 speler gereduceerd gedurende 2 minuten",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Дисквалификација званичника А БЕЛЕ екипе, писани извештај (црвени и плави картон показани од стране судија), БЕЛА екипа је редукована за једног играча у пољу за два минута",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "The game is restarted after a whistle signal with the throw that corresponds to the reason of the interruption.",
                            PhraseNl =
                                "Het spel wordt hernomen na fluitsignaal met een worp overeenkomstig de reden van de onderbreking",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Игра се наставља после звучног сигнала у складу са разлогом за прекид игре",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "2-minute suspension for official A from WHITE team, WHITE team is reduced by 1 player on the court for 2 minutes",
                            PhraseNl =
                                "2-minuten uitsluiting voor official A van team WIT, team WIT wordt met 1 speler op het speelveld gereduceerd voor 2 minuten",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "2 минута искључења за званичника А БЕЛЕ екипе, БЕЛА екипа ће бити редукована за једног играча у пољу за два минутa",
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
                            Phrase =
                                "Disqualification without written report of official A from WHITE team (red card shown by the referees), WHITE team is reduced by 1 player on the court for 2 minutes",
                            PhraseNl =
                                "Diskwalificatie zonder schriftelijk verslag voor official A van team WIT (rode kaart getoond door de scheidsrechters), team WIT wordt op het speelveld gereduceerd gedurende 2 minuten",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Дисквалификација званичника А БЕЛЕ екипе, без писаног извештаја (црвени картон показан од стране судија), БЕЛА екипа је редукована за једног играча у пољу за два минута",
                            AnswerNumber = "e"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "After receiving medical care on the court, WHITE 6 must leave the court and may only re-enter the court following the third attack of his team.",
                            PhraseNl =
                                "Na medische verzorging op het speelveld, moet WIT6 het speelveld verlaten en kan hij pas terug opkomen na de derde aanval van zijn team.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "После указане медицинске помоћи на терену, БЕЛИ 6 мора напустити терен и може се вратити после трећег напада своје екипе",
                            AnswerNumber = "f",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "Just after the execution of a throw-off for BLACK team, the referees realise that a person, who is not on the score sheet, is present in the substitution area of BLACK team. It turns out that this person is one of the board members of the club, but BLACK team has already had four other people registered as team officials in the score sheet. Correct decision?",
                    PhraseNl =
                        "Direct na de uitvoering van een beginworp door team ZWART, stellen de scheidsrechters vast, dat zich in de wisselzone van ZWART een persoon bevindt die niet op het wedstrijdformulier staat. Controle wijst uit dat het om een van de bestuursleden van de club gaat. Team ZWART heeft echter al 4 officials op het wedstrijdformulier ingevuld. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Непосредно након изведеног почетног бацања ЦРНЕ екипе, судије су утврдиле да се у простору за замену играча ЦРНЕ екипе налази особа која није унесена у записник. Испоставило се да је он један од чланова клуба, али се установи да ЦРНА екипа већ има на клупи 4 званичника унешена у записник. Исправна одлука?",
                    QuestionNumber = "4.31",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "The person must leave the substitution area.",
                            PhraseNl = "De persoon moet de wisselzone verlaten.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Особа мора напустити простор за замену играча",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Personal punishment for the responsible team official from BLACK team.",
                            PhraseNl =
                                "Persoonlijke bestraffing voor de verantwoordelijke team official van team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Одговорни представник ЦРНЕ екипе добија личну казну",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "An additional team official must leave the substitution area.",
                            PhraseNl = "Een bijkomende team official moet de wisselzone verlaten",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Додатно још један званичник мора напустити простор за замену",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "The game is restarted with a free throw for WHITE team.",
                            PhraseNl = "Het spel wordt hernomen met een vrije worp voor team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Утакмица се наставља слободним бацањем за БЕЛУ екипу",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "The game is restarted with a free throw for BLACK team.",
                            PhraseNl = "Het spel wordt hernomen met een vrije worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Утакмица се наставља слободним бацањем за ЦРНУ екипу",
                            AnswerNumber = "e"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase = "Which of the following statements about the uniform are correct?",
                    PhraseNl =
                        "Welke van de volgende uitspraken met betrekking tot de uitrusting van de spelers is correct?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb = "Шта се примењује везано за изглед дреса?",
                    QuestionNumber = "4.32",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "All players of a team identified as goalkeepers must wear shirts of identical colour.",
                            PhraseNl =
                                "Alle spelers van eenzelfde team die als doelverdediger opgesteld worden, moeten shirts van identieke kleuren dragen",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Сви играчи који играју на месту голмана морају носити дрес у идентичној боји",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "The players must have at least 20cm high numbers on both the front and the back.",
                            PhraseNl =
                                "De spelers moeten minstens 20 cm hoge nummers hebben zowel op de voor als de achterzijde.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Играчи морају носити бројеве висине најмање 20цм на грудима и леђима",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "The goalkeepers are allowed to wear head protection if it is made of soft material.",
                            PhraseNl =
                                "De doelverdedigers mogen hoofdbescherming dragen, indien deze van zacht materiaal gemaakt is.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Голмани смеју носити заштиту за главу ако је она израђена од меканог материјала",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "The players including the goalkeepers may use numbers from 1 to 100.",
                            PhraseNl = "De spelers, inclusief doelverdedigers, mogen nummers van 1 tot 100 gebruiken.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Играчи, укључујући голмане, могу користити бројеве од 1 до 100",
                            AnswerNumber = "d"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE 10 is serving his first 2-minute suspension starting from 21:00. After the match has been restarted, he complains so strongly that the referees interrupt the match at 21:30 to give WHITE 10 an additional 2-minute suspension. What are the consequences for WHITE team?",
                    PhraseNl =
                        "Speler WIT10 krijgt zijn eerste 2-minuten uitsluiting beginnend op 21:00. Nadat het spel hernomen is, protesteert hij zo erg dat de scheidsrechters het spel onderbreken op 21:30 om WIT10 een bijkomende 2-minuten uitsluiting te geven. Wat zijn de gevolgen voor team WIT?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "БЕЛИ 10 издржава прву казну искључења на 2 минута, које је почело у 21:00. Након што је утакмица настављена, он протествује толико енергично, да судије прекидају игру у 21:30 и дају БЕЛОМ 10 додатна 2 минута искључења. Које су последице за БЕЛУ екипу?",
                    QuestionNumber = "4.33",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 10",
                            PhraseNl = "2-minuten uitsluiting voor WIT10",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Искључење БЕЛОГ 10 на 2 минута",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification of WHITE 10",
                            PhraseNl = "Diskwalificatie voor WIT10",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Дисквалификација БЕЛОГ 10",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "WHITE team will be reduced by 1 player on the court until 25:00",
                            PhraseNl = "Team WIT wordt met 1 speler op het speelveld gereduceerd tot 25:00",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "БЕЛА екипа се редукује за једног играча на терену до 25:00",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "WHITE team will be reduced by 2 players on the court until 23:00 and then by 1 player on the court until 23:30",
                            PhraseNl =
                                "Team WIT wordt met 2 spelers op het speelveld gereduceerd tot 23:00 en daarna met 1 speler op het speelveld gereduceerd tot 23:30",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "БЕЛА екипа се редукује за два играча на терену до 23:00, а затим за једног играча на терену до 23:30",
                            AnswerNumber = "d",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "In which of the following cases is the responsible team official to be given a personal punishment?",
                    PhraseNl =
                        "In welke van de volgende gevallen moet de verantwoordelijke team official persoonlijk bestraft worden?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "У којој од наведених ситуација ће одговорни представник екипе добити прогресивну казну?",
                    QuestionNumber = "4.34",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "When a player of his team leaves the substitution area without informing the timekeeper/scorekeeper.",
                            PhraseNl =
                                "Wanneer een speler van zijn team de wisselzone verlaat zonder zich af te melden bij de tijdwaarnemer/wedstrijdsecretaris",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Када играч његове екипе напусти простор за замену играча а да се не јави мериоцу/записничару",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "If there are people, who are not included in the score sheet, present in the substitution area when the game starts.",
                            PhraseNl =
                                "Wanneer zich personen die niet op het wedstrijdformulier staan, aanwezig zijn in de wisselzone wanneer de wedstrijd begint",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Када је утакмица већ почела, а у простору за замену играча се налази особа која није уписана у записнику",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "When an additional player enters the court.",
                            PhraseNl = "Wanneer een bijkomende speler het speelveld betreedt.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Када додатни играч уђе у терен",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "When a player who is not entitled to participate enters the court.",
                            PhraseNl = "Wanneer een niet spelgerechtigde speler het speelveld betreedt.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Када играч који не може да учествује уђе у терен",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "If it is detected that players on the court wear incorrect equipment after the start of the game.",
                            PhraseNl =
                                "Wanneer vastgesteld wordt, dat spelers op het speelveld, niet correcte uitrusting dragen na de start van de wedstrijd",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Ако се неправилна опрема установи после почетка утакмице",
                            AnswerNumber = "e",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "If there are violations in the substitution area, which cannot clearly be attributed to individuals.",
                            PhraseNl =
                                "Wanneer er een overtreding in de wisselzone wordt zijn, die niet duidelijk aan een bepaald individu kan gelinkt worden.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "У случају прекршаја у простору за замену играча, који се не могу лично определити",
                            AnswerNumber = "f",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "If it is detected that players in the substitution area wear incorrect equipment after the start of the game.",
                            PhraseNl =
                                "Wanneer vastgesteld wordt dat spelers in de wisselzone niet correcte uitrusting dragen na de start van de wedstrijd",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Ако се установи да играчи у простору за замену носе неисправну опрему након почетка утакмице.",
                            AnswerNumber = "g"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "The referees give the hand signal to indicate permission to enter the court, because a player of WHITE team is injured. Who is allowed to enter the court?",
                    PhraseNl =
                        "De scheidsrechters geven het teken om het speelveld te betreden omdat een speler van team WIT gekwetst is. Wie mag dan het speelveld betreden?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Судије дају ручни сигнал да је дозвољен улазак у терен зато што је играч БЕЛЕ екипе повређен. Коме је дозвољено да уђе на терен?",
                    QuestionNumber = "4.35",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Two officials from WHITE team, nobody else",
                            PhraseNl = "Twee officials van team WIT en niemand anders",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Два званичника БЕЛЕ екипе (нико други)",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Two officials from both WHITE and BLACK team",
                            PhraseNl = "Twee officials van zowel team WIT en team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "По два званичника из БЕЛЕ и ЦРНЕ екипе",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Two people (officials or players) from WHITE team",
                            PhraseNl = "Twee personen (officials of spelers) van team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Две особе (званичник или играч) БЕЛЕ екипе",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Two people (officials or players) from both WHITE and BLACK team",
                            PhraseNl = "Twee personen (officials of spelers) van zowel team WIT als team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Две особе (званичник или играч) из БЕЛЕ и ЦРНЕ екипе",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "The doctor of WHITE team, if he is not one of the four team officials",
                            PhraseNl = "De dokter van team WIT indien hij geen van de vier officials is",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Доктор БЕЛЕ екипе, ако он није један од четири званичника екипе",
                            AnswerNumber = "e"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "Official C from WHITE team has already received a warning for protests. Later on, official B from WHITE team enters the court without permission, but he does not behave in an unsportsmanlike manner. Correct decision?",
                    PhraseNl =
                        "Official C van team WIT heeft reeds geel gekregen voor protest. Later betreedt official B van team WIT het speelveld zonder toelating, maar hij gedraagt zich niet onsportief. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Званичник Ц БЕЛЕ екипе, већ је добио опомену због протеста. Касније, званичник Б БЕЛЕ екипе уђе у поље за игру без дозволе, али се коректно понаша. Исправна одлука?",
                    QuestionNumber = "4.36",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Warning for official B from WHITE team",
                            PhraseNl = "Waarschuwing voor official B van team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Опомена за званичника Б БЕЛЕ екипе",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "2-minute suspension for official B from WHITE team (must leave the bench for 2 minutes)",
                            PhraseNl =
                                "2-minuten uitsluiting voor official B van team WIT (hij moet de bank voor 2 minuten verlaten)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "2 минута искључења за званичника Б БЕЛЕ екипе; Он мора отићи са клупе 2 минута",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification of official B from WHITE team (red card shown by the referees, WHITE team will be reduced by 1 player on the court for 2 minutes",
                            PhraseNl =
                                "Diskwalificatie van official B van team WIT (rode kaart getoond door de scheidsrechters). Team WIT wordt op het speelveld gereduceerd met 1 speler gedurende 2 minuten",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Дисквалификација званичника Б БЕЛЕ екипе (црвени картон показан од стране судија), БЕЛА екипа ће бити редукована за једног играча у пољу за 2 минута",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "2-minute suspension for official B from WHITE team, WHITE team will be reduced by 1 player on the court for 2 minutes, official B can stay in the substitution area",
                            PhraseNl =
                                "2-minuten uitsluiting voor official B van team WIT, team WIT wordt op het speelveld gereduceerd met 1 speler gedurende 2 minuten, official B mag in de wisselzone blijven",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "2 минута искључења за званичника Б БЕЛЕ екипе, БЕЛА екипа ће бити редукована за једног играча у пољу за 2 минута; Званичник Б БЕЛЕ екипе може остати у простору за замену играча",
                            AnswerNumber = "d",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "Which of the following actions are <b><u>not</u></b> allowed when there is a time-out because of an injury and the referees have given permission for up to two people from WHITE team to enter the court?",
                    PhraseNl =
                        "Welke van de volgende handelingen is/zijn <b><u>niet</u></b> toegelaten bij een time-out, gegeven voor een kwetsuur en waarbij de scheidsrechters aan team WIT de toelating gegeven hebben om het speelveld te betreden met 2 personen?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Дат је тајм-аут због повреде и судије су ручним сигналом дале дозволу да особе БЕЛЕ екипе уђу у терен. Које од следећих радњи нису дозвољене?",
                    QuestionNumber = "4.37",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "The players of BLACK team stand near the sideline in order to get instructions from the coach.",
                            PhraseNl =
                                "De spelers van team ZWART staan in de nabijheid van de zijlijn om instructies van hun coach te krijgen",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Играчи ЦРНЕ екипе стоје близу уздужне линије, са циљем да добију савете од тренера",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Players of WHITE team make substitutions outside the substitutions line.",
                            PhraseNl = "Spelers van team WIT wisselen buiten de wisselzone.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Играчи БЕЛЕ екипе праве замену ван линије за замену играча",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "One of the team officials of WHITE team, who is on the court, moves far away from the injured player and gives instructions to the other players of his team.",
                            PhraseNl =
                                "Een der officials van team WIT, die op het speelveld is, verwijdert zich ver van de gekwetste speler om aanwijzingen te geven aan de andere spelers van zijn team.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Један званичник БЕЛЕ екипе, који је на терену, креће се далеко од повређеног играча и даје савете другим играчима свог тима",
                            AnswerNumber = "c",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "Before the start of the match the delegate realises that WHITE 7 is wearing ankle protectors with hard material that is not covered. What is/are the correct decision(s)?",
                    PhraseNl =
                        "Voor het begin van de wedstrijd realiseert de waarnemer zich dat WIT7 enkelbeschermers draagt met hard materiaal dat niet bedekt is. Wat is/zijn de correcte beslissing(en)?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Пре почетка утакмице, делегат примећује да БЕЛИ 7 носи штитнике за скочни зглоб од тврдог материјала који нису покривени. Која је исправна одлука?",
                    QuestionNumber = "4.38",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "WHITE 7 can play with the ankle protectors, but the delegate needs to send a report to the competition management.",
                            PhraseNl =
                                "WIT7 mag spelen met de enkelbeschermers, maar de waarnemer moet een verslag sturen naar het competitie management",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "БЕЛИ 7 може да игра са штитницима за скочни зглоб али делегат мора да наведе то у свом извештају",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "WHITE 7 cannot play with ankle protectors that have uncovered hard parts. The delegate must alert the responsible team official that the player should remove the ankle protectors or cover the hard parts with soft material.",
                            PhraseNl =
                                "WIT7 mag niet spelen met de enkelbeschermers die niet bedekte harde delen heeft. De waarnemer moet de verantwoordelijke team official alert maken dat de speler de enkelbeschermers moet verwijderen of de harde delen moet bedekken met zacht materiaal.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "БЕЛИ 7 не сме да игра са штитницима за скочни зглоб који имају откривене тврде делове. Делегат мора да обавести одговорног представника екипе да играч мора да уклони штитнике или да прекрије тврде делове меканим материјалом",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "WHITE 7 will receive a warning.",
                            PhraseNl = "WIT7 zal een waarschuwing krijgen.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Опомена за БЕЛОГ 7",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "The responsible team official will receive a warning.",
                            PhraseNl = "De verantwoordelijke team official zal een waarschuwing krijgen.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Опомена за одговорног представника БЕЛЕ екипе",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "None of the previous answers are valid.",
                            PhraseNl = "Geen enkele van de voorgaande antwoorden zijn geldig",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Ниједна од претходних тврдњи није тачна",
                            AnswerNumber = "e"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "At 29:00 in the first half, WHITE 5 receives a 2-minute suspension. After the half-time break, the court referee whistles to start the second half. Three seconds after this, the timekeeper blows his whistle. WHITE team has seven players on the court. Correct decision?",
                    PhraseNl =
                        "Bij 29:00 in de 1e helft krijgt WIT5 een 2-minuten uitsluiting. Na de pauze fluit de veldscheidsrechter voor de start van de tweede helft. Na 3 seconden, fluit de tijdwaarnemer. Team WIT heeft 7 spelers op het speelveld. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "У 29:00 првог полувремена БЕЛИ 5 је искључен на 2 минута. После одмора између два полувремена судија у пољу даје знак за почетак другог полувремена. Три секунде после тога оглашава се мерилац времена. БЕЛА екипа има 7 играча на терену! Исправна одлука?",
                    QuestionNumber = "4.39",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "1 player of WHITE team must leave the court, no additional punishment",
                            PhraseNl =
                                "Een speler van team WIT moet het speloppervlak verlaten, geen bijkomende bestraffing",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Један играч БЕЛЕ екипе мора да напусти терен; нема додатне казне",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for the additional player from WHITE team",
                            PhraseNl = "2-minuten uitsluiting voor de bijkomende speler van team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења за додатног играча БЕЛЕ екипе",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "WHITE team will be reduced by 2 players on the court for 57 seconds and by 1 player for 1 minute and 3 seconds.",
                            PhraseNl =
                                "Team WIT wordt op het speelveld gereduceerd met 2 spelers voor 57 seconden en met 1 speler voor 1 minuut en 3 seconden.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "БЕЛА екипа ће бити редукована за два играча у пољу за 57 секунди и за једног играча за 1 минут и 3 секунде",
                            AnswerNumber = "c",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "The playing time is 43:27. There is an interruption by the timekeeper after a goal from WHITE 15 and throw-off. The timekeeper informs the referees that WHITE 15 is not registered in the score sheet. 14 players are already listed for WHITE team. The referees realise that WHITE 11 is not even present. Correct decision?",
                    PhraseNl =
                        "Speeltijd 43:27 – Er is een spelonderbreking door de tijdwaarnemer na doelpunt van WIT15 en beginworp. De tijdwaarnemer informeert de scheidsrechters dat speler WIT15 niet op het wedstrijdformulier staat. Op het wedstrijdformulier staan reeds 14 spelers voor team WIT ingeschreven. De scheidsrechters stellen vast dat de speler A11 zelfs helemaal niet aanwezig is. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Време игре: 43:27 – прекид од стране мериоца времена, после гола БЕЛОГ 15 и почетног бацања. Мерилац времена обавештава судије да БЕЛИ 15 није уписан у записник утакмице. 14 играча БЕЛЕ екипе је већ уписано. Судије установе да играч БЕЛИ 11 није присутан. Исправна одлука?",
                    QuestionNumber = "4.40",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "The goal is cancelled.",
                            PhraseNl = "Het doelpunt wordt geannuleerd.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Гол се поништава",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "The goal is valid.",
                            PhraseNl = "Het doelpunt is geldig.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Гол је исправан",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "WHITE 11 is removed, and WHITE 15 is registered in the score sheet in conformity with the regulations of the responsible federation.",
                            PhraseNl =
                                "Speler WIT11 wordt geschrapt en WIT15 wordt ingeschreven op het wedstrijdblad, in overeenstemming met de reglementen van de verantwoordelijke federatie.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "БЕЛИ 11 се брише, а БЕЛИ 15 се уписује у записник, уколико је ово у складу са прописима одговорне федерације",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "WHITE 15 is not allowed to play and must leave the court.",
                            PhraseNl = "Speler WIT15 mag niet meespelen en moet het speelveld verlaten.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "БЕЛОМ 15 није дозвољено да игра и мора напустити терен",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "Progressive punishment for the responsible team official from WHITE team",
                            PhraseNl = "Progressieve bestraffing voor de verantwoordelijke team official van team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Прогресивна казна за одговорног представника БЕЛЕ екипе",
                            AnswerNumber = "e",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Written report in conformity with the regulations of the responsible federation.",
                            PhraseNl =
                                "Schriftelijk verslag in overeenstemming met de reglementen van de verantwoordelijke federatie.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Писани извештај у складу са прописима надлежне федерације",
                            AnswerNumber = "f",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "Goalkeeper WHITE 12 lies on the floor with a knee injury after saving a shot from BLACK team. Correct decision?",
                    PhraseNl =
                        "Doelman WIT12 ligt op de vloer met een knie kwetsuur na een worp gered te hebben van team ZWART. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Голман БЕЛИ 12 лежи на поду због повреде колена, након што је одбранио шут ЦРНЕ екипе. Исправна одлука?",
                    QuestionNumber = "4.41",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "WHITE 12 may continue to play after receiving medical treatment on the court.",
                            PhraseNl =
                                "WIT12 mag verder spelen na medische verzorging ontvangen te hebben op het speelveld.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "БЕЛИ 12 може наставити да игра, после указане помоћи на терену",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Two people from WHITE team, who are entitled to participate, can enter the court to give WHITE 12 medical treatment on the court after the hand signals 15 and 16 have been shown by one of the referees.",
                            PhraseNl =
                                "Twee personen van team WIT, die spelgerechtigd zijn, mogen het speelveld betreden om WIT12 medische verzorging te geven op het speelveld, nadat handsignaal 15 en 16 door een van de scheidsrechters getoond werden.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Две особе БЕЛЕ екипе, које имају право учешћа, могу ући у поље за игру после ручних сигнала 15 и 16, показаних од стране судија, да пруже медицинску помоћ БЕЛОМ 12",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Only one person from WHITE team, who is entitled to participate, can enter the court to give WHITE 12 medical treatment on the court after the hand signals 15 and 16 have been shown by one of the referees.",
                            PhraseNl =
                                "Slechts 1 persoon van team WIT, die spelgerechtigd is, mag op het speelveld komen om WIT12 medische verzorging te geven op het speelveld, nadat handsignaal 15 en 16 door de scheidsrechters getoond werden.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Само једна особа БЕЛЕ екипе која има право учешћа, може ући у поље за игру после ручних сигнала 15 и 16, показаних од стране судија, да пружи медицинску помоћ БЕЛОМ 12",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "After receiving medical treatment on the court, WHITE 12 can only re-enter the court following the third attack of his team.",
                            PhraseNl =
                                "Na medische verzorging op het speelveld ontvangen te hebben, kan WIT12 enkel opnieuw op het speelveld komen na de derde aanval van zijn team",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "После указане медицинске помоћи на терену, БЕЛИ 12 се може вратити на терен после трећег напада његове екипе",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Regardless of the number of attacks, WHITE 12 can re-enter the court when the game is continued after the end of a half.",
                            PhraseNl =
                                "Ongeacht het aantal aanvallen van zijn team, kan WIT12 terug op het speelveld komen, wanneer het spel verdergezet wordt na het einde van een speelhelft.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Независно од броја напада БЕЛИ 12 се може вратити на терен, када се игра наставља после паузе између два полувремена",
                            AnswerNumber = "e",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "If the team officials refuse to provide the necessary treatment of WHITE 12, the responsible team official is to be punished progressively.",
                            PhraseNl =
                                "Als de team officials weigeren om de noodzakelijke verzorging van WIT12 te geven, moet de verantwoordelijke team official progressief bestraft worden.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Ако званичници екипе одбијају да пруже неопходну помоћ БЕЛОМ 12, одговорни представник БЕЛЕ екипе ће бити прогресивно кажњен",
                            AnswerNumber = "f",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "Goalkeeper WHITE 1 saves a shot from BLACK team. In doing so, he hits his head against the goal post and needs medical treatment on the court. Correct decision?",
                    PhraseNl =
                        "Doelman WIT1 stopt een worp van het team ZWART. Dit doende stoot hij zijn hoofd tegen de doelpaal. Hij heeft medische verzorging nodig op het speelveld. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Голман БЕЛИ 1 брани шут ЦРНЕ екипе. Том приликом удари главом у стативу. Потребна му је медицинска помоћ на терену. Исправна одлука?",
                    QuestionNumber = "4.42",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "WHITE 1 may continue to play after receiving medical treatment on the court, because the treatment was caused by a head injury.",
                            PhraseNl =
                                "WIT1 mag verder spelen na de medische behandeling op het speelveld, omdat de behandeling nodig was door een hoofdkwetsuur.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "БЕЛИ 1 може наставити да игра, након указане медицинске помоћи на терену, због тога што је узрок помоћи била повреда главе",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "After receiving medical treatment on the court, WHITE 1 can only re-enter the court following the third attack of his team.",
                            PhraseNl =
                                "Na de medische behandeling op het speelveld, kan WIT1 pas terug op het speelveld komen na de derde aanval van zijn team.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "После указане медицинске помоћи на терену БЕЛИ 1 се може вратити после трећег напада своје екипе",
                            AnswerNumber = "b",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "After receiving medical treatment on the court WHITE 7 sits on the bench in the substitution area. During the first attack of WHITE team, BLACK 2 intercepts the ball and runs in a counter-attack alone with only goalkeeper WHITE 12 between him and the goal of WHITE team. Before BLACK 2 can take a shot on goal, WHITE 7 enters the court through a substitution with WHITE 9. Correct decision?",
                    PhraseNl =
                        "Na medische verzorging op het speelveld ontvangen te hebben, zit WIT7 op de bank in de wisselzone. Tijdens de eerste aanval van team WIT, onderschept ZWART2 de bal en loopt alleen in tegenaanval met alleen doelman WIT12 tussen hem en het doel van team WIT. Vooraleer ZWART2 een worp op doel kan geven, loopt WIT7 het speelveld op na een wissel met WIT9. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Након указане медицинске помоћи на терену БЕЛИ 7 седи на клупи у простору за замену играча. За време првог напада БЕЛЕ екипе, ЦРНИ 2 ухвати лопту и трчи у контранапад сам, једино се голман БЕЛИ 12 налази између њега и гола БЕЛЕ екипе. Пре него што је ЦРНИ 2 могао да шутира на гол, БЕЛИ 7 улази на терен, правећи замену са БЕЛИМ 9. Исправна одлука?",
                    QuestionNumber = "4.43",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "The timekeeper waits until BLACK 2 has taken a shot on goal before interrupting the game due to a faulty substitution of WHITE team.",
                            PhraseNl =
                                "De tijdwaarnemer wacht tot ZWART2 een worp op doel genomen heeft, vooraleer het spel te onderbreken omwille van een foutieve wissel van team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Мерилац времена чека док ЦРНИ 2 не изведе шут на гол, пре него што прекине игру због погрешне замене БЕЛЕ екипе",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "The timekeeper immediately interrupts the game due to a faulty substitution of WHITE team.",
                            PhraseNl =
                                "De tijdwaarnemer onderbreekt het spel onmiddellijk omwille van de foutieve wissel van team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Мерилац времена тренутно прекида игру због погрешне замене БЕЛЕ екипе",
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
                            Phrase = "2-minute suspension of WHITE 7",
                            PhraseNl = "2-minuten uitsluiting voor WIT7",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења за БЕЛОГ 7",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Disqualification without written report of WHITE 7 (red card shown by the referees)",
                            PhraseNl =
                                "Diskwalificatie zonder schriftelijk verslag voor WIT7 (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Дисквалификација без писаног извештаја за БЕЛОГ 7 (црвени картон показан од стране судија)",
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
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team",
                            PhraseNl = "Vrije worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за ЦРНУ екипу",
                            AnswerNumber = "g"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Regardless of the number of attacks of his team, WHITE 7 can re-enter the court after serving a 2-minute suspension.",
                            PhraseNl =
                                "Ongeacht het aantal aanvallen van zijn team kan WIT7 terug op het speelveld komen na het einde van zijn 2-minuten uitsluiting",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Без обзира на број напада своје екипе, БЕЛИ 7 се може вратити на терен после издржане казне од 2 минута",
                            AnswerNumber = "h",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "After receiving medical treatment on the court, BLACK 11 sits on the bench and complains about a decision of the referees. Therefore, he receives his first 2-minute suspension of the match. Following the second attack of BLACK team, BLACK 11 re-enters the court after serving his 2-minute suspension. Correct decision?",
                    PhraseNl =
                        "Na medische verzorging gekregen te hebben op het speelveld, zit ZWART11 op de bank en klaagt over een beslissing van de scheidsrechters. Hiervoor krijgt hij zijn eerste 2-minuten uitsluiting van de wedstrijd. Na de tweede aanval van team ZWART gaat ZWART11 terug op het veld na het einde van zijn 2-minuten uitsluiting te hebben uitgezeten. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "После указане медицинске помоћи на терену ЦРНИ 11 седи на клупи жалећи се на судијску одлуку. Због тога ЦРНИ 11 добија своје прво искључење на утакмици. За време другог напада ЦРНЕ екипе, ЦРНИ 11 се враћа у поље за игру, након издржане казне од 2 минута. Исправна одлука?",
                    QuestionNumber = "4.44",
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
                            Phrase = "2-minute suspension of BLACK 11",
                            PhraseNl = "2-minuten uitsluiting voor ZWART11",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења за ЦРНОГ 11",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Play on",
                            PhraseNl = "Verder spelen",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Игра се наставља",
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
                        "BLACK 10 receives the ball at the free-throw line. Just after catching the ball he is pulled down by WHITE 3. He falls, hurts his elbow, and needs medical treatment on the court. Correct decision?",
                    PhraseNl =
                        "ZWART10 krijgt de bal aan de vrije worp lijn. Vlak nadat hij de bal gevangen heeft wordt hij neergetrokken door WIT3. Hij valt, kwetst zijn elleboog en heeft medische verzorging nodig op het speelveld. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "ЦРНИ 10 добија лопту на линији слободног бацања. Одмах након што је ухватио лопту бива оборен од стране БЕЛОГ 3. Пао је тако незгодно да је повредио лакат и потребна му је медицинска помоћ на терену. Исправна одлука?",
                    QuestionNumber = "4.45",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Warning for WHITE 3",
                            PhraseNl = "Waarschuwing voor WIT3",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Опомена за БЕЛОГ 3",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 3",
                            PhraseNl = "2-minuten uitsluiting voor WIT3",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења за БЕЛОГ 3",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Two people from BLACK team, who are entitled to participate, can enter the court to give BLACK 10 medical treatment on the court after the hand signals 15 and 16 have been shown by one of the referees.",
                            PhraseNl =
                                "Twee personen van team ZWART, die deelname gerechtigd zijn, mogen het speelveld betreden om ZWART10 medische verzorging te geven op het speelveld, nadat de handsignalen 15 en 16 door een van de scheidsrechters werden getoond.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Две особе ЦРНЕ екипе, које имају право учешћа, могу ући у поље за игру после ручних сигнала 15 и 16, показаних од стране судија, да пруже медицинску помоћ ЦРНОМ 10",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "BLACK 10 may continue to play after receiving medical treatment on the court.",
                            PhraseNl =
                                "ZWART10 mag verder spelen nadat hij de medische verzorging op het speelveld ontvangen heeft",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "ЦРНИ 10 може наставити да игра после указане медицинске помоћи у пољу за игру",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "After receiving medical treatment on the court, BLACK 10 can only re-enter the court following the third attack of his team.",
                            PhraseNl =
                                "Na de medische verzorging ontvangen te hebben op het speelveld, mag ZWART10 het speelveld pas terug betreden, na de derde aanval van zijn team.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "После указане медицинске помоћи у пољу за игру, ЦРНИ 10 се може вратити у поље за игру после трећег напада своје екипе",
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
                },
                new QuestionDto
                {
                    Phrase =
                        "BLACK 10 receives the ball in a counter-attack from BLACK 9. Just after passing the ball, BLACK 9 is pulled down by WHITE 11. Right after receiving the ball, BLACK 10 falls and lies injured on the floor. Correct decision?",
                    PhraseNl =
                        "Zwart10 krijgt de bal in een tegenaanval van ZWART9. Vlak na de bal gepast te hebben wordt ZWART9 neergetrokken door WIT11. Vlak na de bal ontvangen te hebben, valt ZWART10 en ligt gekwetst op de vloer. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "ЦРНИ 10 је добио лопту од ЦРНОГ 9. Чим је додао лопту, ЦРНИ 9 је оборен од стране БЕЛОГ 11. Када је примио лопту, ЦРНИ 10 пао и лежи повређен на терену. Исправна одлука?",
                    QuestionNumber = "4.46",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Warning for WHITE 11",
                            PhraseNl = "Waarschuwing voor WIT11",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Опомена за БЕЛОГ 11",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 11",
                            PhraseNl = "2-minuten uitsluiting voor WIT11",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења за БЕЛОГ 11",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Two people from BLACK team, who are entitled to participate, can enter the court to give BLACK 10 medical treatment on the court after the hand signals 15 and 16 have been shown by one of the referees.",
                            PhraseNl =
                                "Twee personen van team ZWART, die deelname gerechtigd zijn, mogen het speelveld betreden om medische verzorging te geven aan ZWART10 op het speelveld, nadat de handsignalen 15 en 16 door een van de scheidsrechters werden getoond.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Две особе ЦРНЕ екипе, које имају право учешћа, могу ући у поље за игру после ручних сигнала 15 и 16, показаних од стране судија, да пруже медицинску помоћ ЦРНОМ 10",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "BLACK 10 may continue to play after receiving medical treatment on the court.",
                            PhraseNl =
                                "ZWART10 mag verder spelen na de medische verzorging op het speelveld ontvangen te hebben",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "ЦРНИ 10 може наставити да игра после указане медицинске помоћи у пољу за игру",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "After receiving medical treatment on the court, BLACK 10 can only re-enter the court following the third attack of his team.",
                            PhraseNl =
                                "Na de medische verzorging ontvangen te hebben op het speelveld, mag ZWART11 het veld pas terug betreden, na de derde aanval van zijn team.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "После указане медицинске помоћи на терену, ЦРНИ 10 се може вратити после трећег напада своје екипе",
                            AnswerNumber = "e",
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
                            AnswerNumber = "f",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "With three minutes left, the game is tied at 21-21. BLACK 2, the top scorer of his team, twists his ankle and ends up lying on the floor. One of the referees asks BLACK 2 if he needs medical treatment on the court. As BLACK 2 does not answer the question, but remains on the floor, the referees interrupt the game and show the hand signals 15 and 16 to allow two people from BLACK team to enter the court and give medical treatment to BLACK 2. BLACK team refuse to send anyone onto the court, and before the referees take any other action, BLACK 2 is ready to continue. Correct decision?",
                    PhraseNl =
                        "Met nog 3 minuten te gaan is de score 21-21. ZWART2, de topscorer van zijn team, slaat zijn enkel om en ligt op de vloer. Een van de scheidsrechters vraagt ZWART2 of hij medische verzorging op het speelveld nodig heeft. Wanneer ZWART2 geen antwoord geeft op die vraag, maar nog steeds op de grond ligt, onderbreken de scheidsrechters de wedstrijd en tonen de handsignalen 15 en 16 om twee personen van team ZWART toe te laten op het speelveld om medische verzorging te geven aan ZWART2. Team ZWART weigert om verzorgers op het speelveld te sturen, en vooraleer de scheidsrechters een andere actie kunnen ondernemen, is ZWART2 klaar om verder te spelen. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Остало је још 3 минута игре до краја, резултат је 21:21. ЦРНИ 2, голгетер своје екипе, је несрећно угануо чланак и лежи на терену. Један од судија пита ЦРНОГ 2 да ли му је потребна медицинска помоћ на терену. ЦРНИ 2 не одговара, али и даље лежи на терену. Судије прекидају игру и показују сигнале 15 и 16, одобравајући да две особе из ЦРНЕ екипе уђу на терен и пруже медицинску помоћ ЦРНОМ 2. ЦРНА екипа одбија да пошаље особе на терен и пре него што су судије предузеле даље акције, ЦРНИ 2 је спреман да настави игру. Исправна одлука?",
                    QuestionNumber = "4.47",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "BLACK 2 may continue to play.",
                            PhraseNl = "ZWART2 mag verder spelen.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "ЦРНИ 2 може да настави да игра",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "BLACK 2 must leave the court and can only re-enter the court following the third attack of his team.",
                            PhraseNl =
                                "ZWART2 moet het speelveld verlaten en mag pas opnieuw op het speelveld komen ne de derde aanval van zijn team.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "ЦРНИ 2 мора да напусти терен и може се вратити после трећег напада своје екипе",
                            AnswerNumber = "b",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Progressive punishment to responsible team official of BLACK team",
                            PhraseNl =
                                "Progressieve bestraffing voor de verantwoordelijke team official van team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Прогресивна казна за одговорног представника ЦРНЕ екипе",
                            AnswerNumber = "c",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "With 30 seconds left in the first half, WHITE 5 receives medical treatment on the court. After receiving medical treatment, he leaves the court and can only re-enter following the third attack of his team. After one minute of the second half, during the second attack of WHITE team, WHITE 5 enters the court through a correct substitution with WHITE 4. Correct decision?",
                    PhraseNl =
                        "Met nog 30 seconden te gaan in de eerste helft, krijgt WIT5 medische verzorging op het speelveld. Na de medische verzorging gekregen te hebben, verlaat hij het speelveld en mag hij enkel terug op het speelveld komen na drie aanvallen van zijn team. Na een minuut van de tweede helft tijdens de tweede aanval van team WIT, komt WIT5 op het speelveld na een correcte wissel met WIT4. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Остало је још 30 секунди до краја првог полувремена, БЕЛОМ 5 је указана медицинска помоћ на терену. После указане помоћи он је напустио терен и може да се врати после трећег напада своје екипе. После једног минута другог полувремена, за време другог напада његове екипе, БЕЛИ 5 улази на терен, исправно мењајући БЕЛОГ 4. Исправна одлука?",
                    QuestionNumber = "4.48",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Play on",
                            PhraseNl = "Verder spelen",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Игра се наставља",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "2-minute suspension for WHITE 5 due to a faulty substitution (entering the court too early after receiving medical treatment on the court)",
                            PhraseNl =
                                "2-minuten uitsluiting voor WIT5 omwille van een foutieve wissel (te vroeg op het speelveld gekomen na medische verzorging ontvangen te hebben op het speelveld)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "2 минута искључења за БЕЛОГ 5, због погрешне замене (ранији улазак на терен после указане медицинске помоћи на терену)",
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
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "After a collision, WHITE 4 and BLACK 5 lie on the floor and seem to be injured. The referees immediately interrupt the game and show the hand signals 15 and 16 to give both teams permission to let two people enter the court and give medical treatment on the court. Before any person can enter the court, BLACK 5 is ready to play. WHITE 4 receives medical treatment on the court. After 20 seconds, play can continue. Correct decision?",
                    PhraseNl =
                        " Na een botsing liggen WIT4 en ZWART5 blijkbaar gekwetst op de grond. De scheidsrechters onderbreken direct de wedstrijd en tonen de handsignalen 15 en 16 om aan beide teams toelating te geven om met 2 personen op het speelveld te komen om medische verzorging te geven op het speelveld. Vooraleer iemand op het veld kan komen, is ZWART5 klaar om te spelen. WIT4 krijgt medische verzorging op het speelveld. Na 20 seconden kan het spel verder gaan. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "После судара, БЕЛИ 4 и ЦРНИ 5 леже на терену делујући повређено. Судије одмах прекидају игру и сигналима 15 и 16 дају дозволу да на терен уђу по две особе из обе екипе и пруже медицинску помоћ. Пре него што су позване особе ушле на терен, ЦРНИ 5 је спреман да игра. БЕЛОМ 4 је указана помоћ на терену. После 20 секунди игра је настављена. Исправна одлука?",
                    QuestionNumber = "4.49",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "After receiving medical treatment on the court, WHITE 4 has to leave the court and can only re-enter following the third attack of his team.",
                            PhraseNl =
                                "Na medische verzorging gekregen te hebben op het speelveld, moet WIT4 het speelveld verlaten en mag hij enkel terug op het speelveld komen na drie aanvallen van zijn team.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "После указане медицинске помоћи на терену БЕЛИ 4 је напустио терен и може да се врати после трећег напада своје екипе",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "As BLACK 5 did not receive medical treatment on the court, he is allowed to continue.",
                            PhraseNl =
                                "Gezien ZWART5 geen medische verzorging op het veld heeft gekregen, mag hij verder spelen.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Како ЦРНИ 5 није добио медицинску помоћ на терену, њему је дозвољено да настави игру",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "BLACK 5 has to leave the court and can only re-enter following the third attack of his team.",
                            PhraseNl =
                                "Zwart5 moet het speelveld verlaten en mag hij enkel terug op het speelveld komen na drie aanvallen van zijn team.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "ЦРНИ 5 напушта терен и може да се врати после трећег напада своје екипе",
                            AnswerNumber = "c",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE 2 is injured and needs medical treatment on the court. The first half finishes after the first attack of his team. When the referee whistles to start the second half, WHITE 2 is on the court during the attack of his team. Correct decision?",
                    PhraseNl =
                        "WIT2 is gekwetst en heeft medische verzorging op het speelveld nodig. De eerste helft eindigt na de eerste aanval van zijn team. Wanneer de scheidsrechters fluiten voor het begin van de tweede helft, is WIT2 op het speelveld tijdens de aanval van zijn team. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "БЕЛИ 2 је повређен и потребна му је медицинска помоћ на терену. Прво полувреме је завршено после првог напада његове екипе. Када су судије дале знак за почетак другог полувремена, БЕЛИ 2 је био на терену, у нападу своје екипе. Исправна одлука?",
                    QuestionNumber = "4.50",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "The timekeeper immediately interrupts the game and informs the referees.",
                            PhraseNl =
                                "De tijdwaarnemer onderbreekt onmiddellijk de wedstrijd en informeert de scheidsrechters.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Мерилац времена тренутно прекида игру и обавештава судије",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 2",
                            PhraseNl = "2-minuten uitsluiting voor WIT2",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења за БЕЛОГ 2",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "Play on",
                            PhraseNl = "Verder spelen",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Игра се наставља",
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team in the substitution area",
                            PhraseNl = "Vrije worp voor team ZWART in de wisselzone",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за ЦРНУ екипу код простора за замену играча",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "No suspension for WHITE 2 who must leave the court. WHITE team continues in possession of the ball because it is a mistake by the timekeeper/delegate.",
                            PhraseNl =
                                "Geen uitsluiting voor WIT2 die het speelveld moet verlaten. Team WIT gaat verder in balbezit omdat het een vergissing is van de tijdwaarnemer/waarnemer.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Нема искључења за БЕЛОГ 2, који мора да напусти терен, БЕЛА екипа и даље има лопту у поседу, због тога што је мерилац времена/делегат погрешио",
                            AnswerNumber = "e"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE 4 is receiving medical treatment on the court. After receiving treatment, WHITE 4 has to leave the court and can only re-enter following the third attack of his team. After the second attack of WHITE team, team official A from WHITE team asks WHITE 4 to enter the court to play in defence. WHITE 4 enters the court through a substitution with WHITE 6 to play in defence only. Correct decision?",
                    PhraseNl =
                        "WIT4 krijgt medische verzorging op het speelveld. Na verzorging gekregen te hebben, moet WIT4 het speelveld verlaten en mag enkel terug op het speelveld komen na drie aanvallen van zijn team. Na de tweede aanval van team WIT, vraagt team official A van team WIT aan WIT4 om terug op het speelveld te gaan om in de verdediging te spelen. WIT4 komt via een wissel met WIT6 op het speelveld om enkel in de verdediging te spelen. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "БЕЛОМ 4 је указана медицинска помоћ на терену. После указане помоћи, БЕЛИ 4 напушта терен и може се вратити након три напада своје екипе. После другог напада БЕЛЕ екипе, званичник А БЕЛЕ екипе тражи од БЕЛОГ 4 да уђе на терен и обави задатак у одбрани. БЕЛИ 4 улази на терен, мењајући БЕЛОГ 6, да игра само у одбрани. Исправна одлука?",
                    QuestionNumber = "4.51",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "Play on (WHITE 4 is allowed to play in defence)",
                            PhraseNl = "Verder spelen (WIT4 mag in verdediging spelen)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Игра се наставља - БЕЛОМ 4 је дозвољено да игра у одбрани",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase = "Warning for WHITE 4, because he entered the court too early",
                            PhraseNl = "Waarschuwing voor WIT4, omdat hij te vroeg op het speelveld is gekomen",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Опомена БЕЛОМ 4 због прераног уласка на терен",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 4 due to a faulty substitution",
                            PhraseNl = "2-minuten uitsluiting voor WIT4 voor een foutieve wissel",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења за БЕЛОГ 4 због погрешне замене",
                            AnswerNumber = "c",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE 11 slides on the floor and ends just outside the court on the other side of the substitution area. He hits his head against the advertising board. The referees immediately interrupt the game to call for medical treatment for WHITE 11. After 20 seconds, WHITE 11 is ready to play again. Correct decision?",
                    PhraseNl =
                        "WIT11 glijdt over de vloer en eindigt net buiten het speelveld aan de andere kant van de wisselzone. Hij botst met zijn hoofd tegen de reclamepanelen. De scheidsrechters onderbreken onmiddellijk het spel en vragen medische verzorging voor WIT11. Na 20 seconden is WIT11 klaar om weer te spelen. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "БЕЛИ 11 се оклизнуо на подлози и завршио ван терена, на другој страни од простора за замену играча. Он је ударио главом о рекламни пано. Судије тренутно прекидају игру и зову медицинску помоћ за БЕЛОГ 11. После 20 секунди, БЕЛИ 11 је спреман да игра. Исправна одлука?",
                    QuestionNumber = "4.52",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "WHITE 11 is allowed to continue the game, because he was lying outside the court, when he received medical treatment.",
                            PhraseNl =
                                "WIT11 mag verder spelen, omdat hij buiten het speelveld lag, toe hij de medische verzorging kreeg.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "БЕЛОМ 11 је дозвољено да настави да игра, зато што је лежао ван терена када му је указивана медицинска помоћ",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "WHITE 11 has to leave the court and can only re-enter following the third attack of his team.",
                            PhraseNl =
                                "WIT11 moet het speelveld verlaten en mag enkel terug op het speelveld komen na drie aanvallen van zijn team.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "БЕЛИ 11 мора да напусти терен и може се вратити после трећег напада своје екипе",
                            AnswerNumber = "b",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "After one minute of the game, there is a fight between BLACK 3 and WHITE 6. BLACK 3 ends up lying on the floor and seems to be injured. The referees choose to give WHITE 6 a verbal caution.BLACK 3 asks for medical treatment on the court. After receiving medical treatment on the court, BLACK 3 is ready to continue the game. Correct decision?",
                    PhraseNl =
                        "Na 1 minuut in de wedstrijd, is er een gevecht tussen ZWART3 en WIT6. ZWART3 eindigt op de grond en schijnt gekwetst te zijn. De scheidsrechters kiezen ervoor om WIT6 een waarschuwing te geven. ZWART3 vraagt medische verzorging op het speelveld. Na de verzorging gekregen te hebben, is ZWART3 klaar om verder te spelen. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "После једног минута игре дешава се блиска борба између пивота ЦРНОГ 3 и БЕЛОГ 6. ЦРНИ 3 заврши лежећи на поду делујући повређено. Судије одлучују да усмено упозоре БЕЛОГ. ЦРНИ 3 тражи медицинску помоћ на терену. После указане медицинске помоћи на терену, ЦРНИ 3 је спреман да настави игру. Исправна одлука?",
                    QuestionNumber = "4.53",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "BLACK 3 is allowed to continue the game.",
                            PhraseNl = "ZWART3 mag verder spelen",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "ЦРНОМ 3 је дозвољено да настави игру",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "BLACK 3 has to leave the court and can only re-enter following the third attack of his team.",
                            PhraseNl =
                                "ZWART3 moet het speelveld verlaten en mag enkel terug op het speelveld komen na drie aanvallen van zijn team",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "ЦРНИ 3 мора да напусти терен и може се вратити после трећег напада своје екипе",
                            AnswerNumber = "b",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "BLACK team is in a counter-attack. BLACK 2 dribbles the ball and is pushed by WHITE 10. He partially loses body control, but manages to play the ball to BLACK 4, who scores a goal. After scoring a goal, BLACK 4 twists his ankle while running back in defence. The referees interrupt the game, give a 2-minute suspension for WHITE 10 and give permission for two people to enter the court to give medical treatment to BLACK 4. After 30 seconds, BLACK 4 is ready to play again. Correct decision?",
                    PhraseNl =
                        "Team ZWART is in tegenaanval. ZWART2 dribbelt met de bal en wordt door WIT10 geduwd. Hij verliest gedeeltelijk zijn lichaamscontrole maar slaagt erin om de bal naar ZWART4 te spelen, die een doelpunt scoort. Na het doelpunt gescoord te hebben, slaat ZWART4 zijn enkel om terwijl hij terugloopt in verdediging. De scheidsrechters onderbreken het spel, geven een 2-minuten uitsluiting aan WIT10 en geven toelating voor 2 personen om op het speelveld te komen om medische verzorging te geven aan ZWART4. Na 30 seconden is ZWART4 klaar om te spelen. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "ЦРНА екипа је у контранападу. ЦРНИ 2 води лопту и бива гурнут од стране БЕЛОГ 10. Он делимично губи контролу над телом, али се сналази и додаје лопту ЦРНОМ 4, који постиже гол. После постигнутог гола, ЦРНИ 4 угане чланак враћајући се у одбрану. Судије прекидају игру, искључују БЕЛОГ 10 на 2 минута и дају дозволу да на терен могу ући две особе и указати медицинску помоћ ЦРНОМ 4. После 30 секунди ЦРНИ 4 је спреман да игра. Исправна одлука?",
                    QuestionNumber = "4.54",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase = "BLACK 4 is allowed to continue the game.",
                            PhraseNl = "ZWART4 mag verder spelen.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "ЦРНОМ 4 је дозвољено да настави игру",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "BLACK 4 has to leave the court and can only re-enter following the third attack of his team.",
                            PhraseNl =
                                "ZWART4 moet het speelveld verlaten en mag enkel terug op het speelveld komen na drie aanvallen van zijn team.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "ЦРНИ 4 мора да напусти терен и може се вратити после трећег напада своје екипе",
                            AnswerNumber = "b",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE 11 takes a shot on goal. Defender BLACK 2 is unfortunately hit in the face by the ball and needs medical treatment on the court. After 20 seconds of treatment, BLACK 2 is ready to play again. Correct decision?",
                    PhraseNl =
                        "WIT11 werpt naar doel. Verdediger ZWART2 krijgt ongelukkig de bal in het gezicht en heeft medische verzorging op het speelveld nodig. Na 20 seconden van verzorging, is ZWART2 klaar om verder te spelen. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "БЕЛИ 11 шутира на гол. Одбрамбени играч ЦРНИ 2 је несрећно погођен лоптом у главу и потребна му је медицинска помоћ на терену. После 20 секунди од указане помоћи, ЦРНИ 2 је спреман да настави игру. Исправна одлука?",
                    QuestionNumber = "4.55",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "BLACK 2 is allowed to continue the game, because the injury was caused by a ball in the face.",
                            PhraseNl =
                                "ZWART2 mag verder spelen, omdat de kwetsuur veroorzaakt werd door een bal in het gezicht.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "ЦРНОМ 2 је дозвољено да настави игру, зато што је повреда последица ударца лоптом у главу",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "BLACK 2 has to leave the court and can only re-enter following the third attack of his team.",
                            PhraseNl =
                                "ZWART2 moet het speelveld verlaten en mag enkel terug op het speelveld komen na drie aanvallen van zijn team.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "ЦРНИ 2 мора да напусти терен и може се вратити после трећег напада своје екипе",
                            AnswerNumber = "b",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "BLACK 2 is lying on the floor in the goal area of WHITE team after a shot on goal asking for medical treatment, apparently because of a leg injury. WHITE team has just started a counter-attack. Correct decision?",
                    PhraseNl =
                        "ZWART2 ligt op de vloer in het doelgebied van team WIT na een worp op doel en vraagt medische verzorging blijkbaar omwille van een been kwetsuur. Team WIT is net een tegenaanval gestart. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "После шута на гол, пивот ЦРНИ 2 лежи у голмановом простору БЕЛЕ екипе и тражи медицинску помоћ, јер делује да је повредио ногу. БЕЛА екипа је баш кренула у контранапад. Исправна одлука?",
                    QuestionNumber = "4.56",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "The referees immediately interrupt the game and show hand signals 15 and 16 to call for medical treatment on the court for BLACK 2",
                            PhraseNl =
                                "De scheidsrechters onderbreken onmiddellijk het spel en tonen de handgebaren 15 en 16 om medische verzorging op het speelveld te vragen voor ZWART2",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Судије тренутно прекидају игру и показују сигнале 15 и 16 и зову медицинску помоћ за ЦРНОГ 2",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Play on until there is a result of the counter-attack from WHITE team – then interrupt the game to call for medical treatment for BLACK 2",
                            PhraseNl =
                                "Verder spelen tot er een resultaat is van de tegenaanval van team WIT – dan het spel onderbreken om medische verzorging te vragen voor ZWART2",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Сачекати исход контранапада БЕЛЕ екипе - онда прекинути игру и звати медицинску помоћ за ЦРНОГ 2",
                            AnswerNumber = "b",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE 2 is warming up without elbow protection. After 5 minutes of the game, WHITE team is in possession of the ball. WHITE 2 enters the court under a correct substitution. The referees notice that WHITE 2 now wears an elbow protection with uncovered hard components. Correct decision?",
                    PhraseNl =
                        "WIT2 warmt op zonder elleboogbescherming. Na 5 minuten in de wedstrijd, is team WIT in balbezit. WIT2 komt via een correcte wissel op het speelveld. De scheidsrechters stellen vast dat WIT2 nu een elleboogprotectie draagt met niet bedekte harde componenten. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "БЕЛИ 2 се загрева без заштите за лакат. После пет минута игре, када БЕЛА екипа има лопту у поседу, БЕЛИ 2 улази у игру исправном заменом. Судије су приметиле да БЕЛИ 2 носи заштиту за лакат са чврстим непокривеним деловима. Исправна одлука?",
                    QuestionNumber = "4.57",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "Play on, it is allowed to wear an elbow protection with uncovered hard components.",
                            PhraseNl =
                                "Verder spelen, het is toegelaten om een elleboogprotectie te dragen met niet bedekte harde componenten.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Игра се наставља, дозвољено је носити заштиту за лакат са непокривеним тврдим деловима",
                            AnswerNumber = "a"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "The referees interrupt the game, WHITE 2 has to leave the court and can only re-enter after removing the elbow protection or covering up the uncovered hard components.",
                            PhraseNl =
                                "De scheidsrechters onderbreken de wedstrijd, WIT2 moet het speelveld verlaten en mag enkel terug op het speelveld komen na verwijdering van de elleboogprotectie of afdekking van de niet bedekte harde componenten.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Судије заустављају игру, БЕЛИ 2 мора да напусти терен и може се вратити после уклањања заштите за лакат или покривања непокривених чврстих делова",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "The referees interrupt the game, WHITE 2 has to leave the court and can only re-enter after removing the elbow protection.",
                            PhraseNl =
                                "De scheidsrechters onderbreken de wedstrijd, WIT2 moet het speelveld verlaten en mag enkel terug op het speelveld komen na verwijdering van de elleboogprotectie.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Судије заустављају игру, БЕЛИ 2 мора да напусти терен и може се вратити после уклањања заштите за лакат",
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
                            PhraseSrb = "Прогресивна казна за БЕЛОГ 2",
                            AnswerNumber = "d"
                        },
                        new AnswerDto
                        {
                            Phrase = "Progressive punishment for responsible team official from WHITE team",
                            PhraseNl = "Progressieve bestraffing voor de verantwoordelijke team official van team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Прогресивна казна за представника БЕЛЕ екипе",
                            AnswerNumber = "e",
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
                            AnswerNumber = "f"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team",
                            PhraseNl = "Vrije worp voor team ZWART",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бавање за ЦРНУ екипу",
                            AnswerNumber = "g",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE team is attacking close to the 9-metre line. WHITE 7 enters the court after a normal substitution wearing his yellow pullover/jersey over the normal white t-shirt. Correct decision?",
                    PhraseNl =
                        "Team WIT aanvalt dicht bij de 9m lijn. WIT7 komt in het speelveld na een normale wissel, maar met zijn gele pullover/trui over het normale witte T-shirt. Correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Бела екипа напада близу линије деветерца. Играч БЕЛИ 7 улази на терен, путем нормалне замене, и има жуту мајицу дугих рукава испод белог дреса. Исправна одлука?",
                    QuestionNumber = "4.58",
                    Answers =
                    [
                        new AnswerDto
                        {
                            Phrase =
                                "The referees interrupt the game, WHITE 7 must take off the yellow jersey before continuing on the court.",
                            PhraseNl =
                                "De scheidsrechters onderbreken het spel, WIT7 moet zijn gele pullover/trui uit doen alvorens verder te gaan op het speelveld.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Тајм-аут, играч мора да скине жуту мајицу дугих рукава пре него што настави игру",
                            AnswerNumber = "a",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for BLACK team.",
                            PhraseNl = "Vrije worp voor team ZWART.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за ЦРНУ екипу",
                            AnswerNumber = "b"
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for WHITE 7.",
                            PhraseNl = "2-minuten uitsluiting voor WIT7.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "2 минута искључења за БЕЛОГ 7",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "Free throw for WHITE team.",
                            PhraseNl = "Vrije worp voor team WIT.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Слободно бацање за БЕЛУ екипу",
                            AnswerNumber = "d",
                            Correct = true
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "WHITE team is in possession of the ball, when the timekeeper interrupts the match. The timekeeper tells the referees that WHITE 11 has entered the court, and there is no WHITE 11 included in the score sheet. It turns out that official A had wrongly included the player in the score sheet as number 13. What is the correct decision?",
                    PhraseNl =
                        "Team WIT is in balbezit wanneer de tijdwaarnemer de wedstrijd onderbreekt. De tijdwaarnemer vertelt de scheidsrechters dat WIT11 het speelveld heeft betreden, maar dat er geen WIT11 op het wedstrijdblad staat. Het blijkt nu dat teamofficial A de speler verkeerdelijk op het wedstrijdblad vermeld heeft met nummer 13. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "БЕЛА екипа има лопту у поседу, мерилац времена прекида игру. Мерилац времена обавештава судије да је БЕЛИ 11 ушао у поље за игру те да БЕЛИ 11 није уписан у записник. Испоставило се да је званичник А погрешно пријавио број БЕЛОГ 11, јер је исти пријављен под бројем 13. Која је исправна одлука?",
                    QuestionNumber = "4.59",
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
                            Phrase = "WHITE 11 is not allowed to participate in the match.",
                            PhraseNl = "WIT11 wordt niet toegelaten om deel te nemen aan de wedstrijd.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "БЕЛОМ 11 није дозвољен наступ",
                            AnswerNumber = "c"
                        },
                        new AnswerDto
                        {
                            Phrase = "The mistake is corrected, and WHITE 11 is entitled to participate.",
                            PhraseNl = "De vergissing wordt gecorrigeerd, en WIT11 mag deelnemen.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Грешка је исправљена, БЕЛИ 11 може наступати за екипу",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase =
                                "Note in the match report/written report in conformity with the regulations of the responsible federation.",
                            PhraseNl =
                                "Vermelding op het wedstrijdblad/schriftelijk verslag overeenkomstig de reglementen van de verantwoordelijke federatie.",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb =
                                "Забелешка у записнику или писани извештај у складу са прописима надлежне федерације",
                            AnswerNumber = "e",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Progressive punishment for official A from WHITE team",
                            PhraseNl = "Progressieve bestraffing voor official A van team WIT",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Прогресивна казна за званичника А БЕЛЕ екипе",
                            AnswerNumber = "f"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "The score is 29:29 with 10 seconds left in the match. Goalkeeper WHITE 12 executes a goalkeeper throw and passes the ball to WHITE 11. WHITE 11 sees that WHITE 9 is in a free position at the goal-area line of BLACK team. Before he can play the pass to WHITE 9, the timekeeper interrupts the game because of a faulty substitution. BLACK 2 has entered the court before BLACK 4 has left it. What is the correct decision?",
                    PhraseNl =
                        "De stand is 29:29 met nog 10 sec te spelen in de wedstrijd. Doelman WIT12 voert een uitworp uit en speelt de bal naar WIT11. WIT11 ziet dat WIT9 in een vrije positie staat aan de doelgebied lijn van team ZWART. Vooraleer hij de bal naar WIT9 kan spelen, onderbreekt de tijdwaarnemer het spel voor een foutieve wissel. ZWART2 is op het speelveld gekomen vooraleer ZWART4 dit heeft verlaten. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Резултат је 29:29, преостало је 10 секунди до краја утакмице. Голман БЕЛИ 12 изводи голманово бацање и додаје БЕЛОМ 11. БЕЛИ 11 види да је БЕЛИ 9 слободан пред голмановим простором ЦРНЕ екипе. Пре него што је лопта упућена до БЕЛОГ 9, мерилац времена прекида игру због погрешне замене. ЦРНИ 2 је ушао у поље за игру пре него што је ЦРНИ 4 напустио поље за игру. Која је исправна одлука?",
                    QuestionNumber = "4.60",
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
                            Phrase = "2-minute suspension for BLACK 2",
                            PhraseNl = "2-minuten uitsluiting voor ZWART2",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Искључење на 2 минута за ЦРНОГ 2",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification for BLACK 2 (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie voor ZWART2 (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Дисквалификација за ЦРНОГ 2 (црвени картон показан од стране судија)",
                            AnswerNumber = "e"
                        }
                    ]
                },
                new QuestionDto
                {
                    Phrase =
                        "The score is 29:29 with 10 seconds left in the match. Goalkeeper WHITE 12 executes a goalkeeper throw and passes the ball to WHITE 11. WHITE 11 sees that WHITE 9 is in a free position at the goal-area line of BLACK team. He passes the ball to WHITE 9. Before WHITE 9 takes a shot on goal, the timekeeper interrupts the game because of a faulty substitution. BLACK 2 has entered the court before BLACK 4 has left it. What is the correct decision?",
                    PhraseNl =
                        "De stand is 29:29 met nog 10 sec te spelen in de wedstrijd. Doelman WIT12 voert een uitworp uit en speelt de bal naar WIT11. WIT11 ziet dat WIT9 in een vrije positie staat aan de doelgebied lijn van team ZWART. Hij speelt de bal naar WIT9. Vooraleer WIT9 naar doel kan werpen, onderbreekt de tijdwaarnemer het spel voor een foutieve wissel. ZWART2 is op het speelveld gekomen vooraleer ZWART4 dit heeft verlaten. Wat is de correcte beslissing?",
                    PhraseFr = "",
                    PhraseSvn = "",
                    PhraseDe = "",
                    PhraseSrb =
                        "Резултат је 29:29, преостало је 10 секунди до краја утакмице. Голман БЕЛИ 12 изводи голманово бацање и додаје БЕЛОМ 11. БЕЛИ 11 види да је БЕЛИ 9 слободан пред голмановим простором ЦРНЕ екипе и додаје му лопту. Пре него што БЕЛИ 9 упути ударац ка голу, мерилац времена прекида игру због погрешне замене. ЦРНИ 2 је ушао у поље за игру пре него што је ЦРНИ 4 напустио поље за игру. Која је исправна одлука?",
                    QuestionNumber = "4.61",
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
                            AnswerNumber = "c",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "2-minute suspension for BLACK 2",
                            PhraseNl = "2-minuten uitsluiting voor ZWART2",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Искључење на 2 минута за ЦРНОГ 2",
                            AnswerNumber = "d",
                            Correct = true
                        },
                        new AnswerDto
                        {
                            Phrase = "Disqualification for BLACK 2 (red card shown by the referees)",
                            PhraseNl = "Diskwalificatie voor ZWART2 (rode kaart getoond door de scheidsrechters)",
                            PhraseFr = "",
                            PhraseSvn = "",
                            PhraseDe = "",
                            PhraseSrb = "Дисквалификација за ЦРНОГ 2 (црвени картон показан од стране судија)",
                            AnswerNumber = "e"
                        }
                    ]
                }
            ]
        };
    }
}
