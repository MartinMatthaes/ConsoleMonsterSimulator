using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using ConsoleMonsters.Monsters;

namespace ConsoleMonsters
{
    public class Game
    {
        public static int option;

        public int monsterOption;
        public bool monsterOne = false;
        public bool monsterTwo = false;
        public int monsterChosen = 0;
        public int monsterChosen2 = 0;

        public int consoleInputMonsterOne = 0;
        public int consoleInputMonsterTwo = 0;

        public bool validConsoleInputHealth = false;
        public bool validConsoleInputAP = false;
        public bool validConsoleInputDP = false;
        public bool validConsoleInputS = false;

        public int minHP = 600;
        public int maxHP = 7000;

        public int minAP = 70;
        public int maxAP = 450;

        public int minDP = 15;
        public int maxDP = 60;

        public int minS = 1;
        public int maxS = 10;

        public bool successHealth = false;
        public bool successAP = false;
        public bool successDP = false;
        public bool successS = false;

        public float monsterOneHealth = 0;
        public float monsterTwoHealth = 0;

        public float monsterOneAP = 0;
        public float monsterTwoAP = 0;

        public float monsterOneDP = 0;
        public float monsterTwoDP = 0;

        public float monsterOneS = 0;
        public float monsterTwoS = 0;

        public void GameLoop()
        {
            //Clear console and display Title
            Console.Clear();
            PrintTitle();
            Console.WriteLine("Press any key to continue..\n");
            Console.ReadKey();
            Console.Clear();

            //Game-Loop
            do
            {
                //Clear console and display Title + Options
                Console.Clear();
                PrintTitle();
                PrintOptions();
                int.TryParse(Console.ReadLine(), out option);

                //Option 1 (Playing the game)
                if (option == 1)
                {
                    // SELECT MONSTER 1
                    Monster player;
                    do
                    {
                        Console.Clear();
                        PrintMonsters();

                        int.TryParse(Console.ReadLine(), out consoleInputMonsterOne);

                        //MonsterOptions
                        switch (consoleInputMonsterOne)
                        {
                            case 1:
                                monsterChosen = 1;
                                ValidateUserInput(0);
                                player = new Shapeshifter(monsterOneHealth, monsterOneAP, monsterOneDP, monsterOneS);
                                monsterOne = true;
                                break;
                            case 2:
                                monsterChosen = 2;
                                ValidateUserInput(0);
                                player = new Vampire(monsterOneHealth, monsterOneAP, monsterOneDP, monsterOneS);
                                monsterOne = true;
                                break;
                            case 3:
                                monsterChosen = 3;
                                ValidateUserInput(0);
                                player = new Werewolve(monsterOneHealth, monsterOneAP, monsterOneDP, monsterOneS);
                                monsterOne = true;
                                break;

                            case 4:
                                monsterChosen = 4;
                                ValidateUserInput(0);
                                player = new Wraith(monsterOneHealth, monsterOneAP, monsterOneDP, monsterOneS);
                                monsterOne = true;
                                break;
                            case 5:
                                monsterChosen = 5;
                                ValidateUserInput(0);
                                player = new Ghoul(monsterOneHealth, monsterOneAP, monsterOneDP, monsterOneS);
                                monsterOne = true;
                                break;

                            default:
                                monsterOne = false;
                                player = new Shapeshifter(0, 0, 0, 0);
                                break;
                        }
                    } 
                    while (!monsterOne);


                    // SELECT MONSTER 2
                    Monster monster;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Same monster-types cannot fight eachother!\n\n");
                        PrintMonsters();

                        int.TryParse(Console.ReadLine(), out consoleInputMonsterOne);

                        //MonsterOptions
                        switch (consoleInputMonsterOne)
                        {
                            case 1:
                                monsterChosen2 = 1;
                                if (monsterChosen2 != monsterChosen)
                                {
                                    ValidateUserInput(1);
                                    monster = new Shapeshifter(monsterTwoHealth, monsterTwoAP, monsterTwoDP, monsterTwoS);
                                    monsterTwo = true;
                                }
                                else
                                {
                                    monsterTwo = false;
                                    monster = new Shapeshifter(0, 0, 0, 0);
                                }
                                break;
                            case 2:
                                monsterChosen2 = 2;
                                if (monsterChosen2 != monsterChosen)
                                {
                                    ValidateUserInput(1);
                                    monster = new Vampire(monsterTwoHealth, monsterTwoAP, monsterTwoDP, monsterTwoS);
                                    monsterTwo = true;
                                }
                                else
                                {
                                    monsterTwo = false;
                                    monster = new Shapeshifter(0, 0, 0, 0);
                                }
                                break;
                            case 3:
                                monsterChosen2 = 3;
                                if (monsterChosen2 != monsterChosen)
                                {
                                    ValidateUserInput(1);
                                    monster = new Werewolve(monsterTwoHealth, monsterTwoAP, monsterTwoDP, monsterTwoS);
                                    monsterTwo = true;
                                }
                                else
                                {
                                    monsterTwo = false;
                                    monster = new Shapeshifter(0, 0, 0, 0);
                                }
                                break;
                            case 4:
                                monsterChosen2 = 4;
                                if (monsterChosen2 != monsterChosen)
                                {
                                    ValidateUserInput(1);
                                    monster = new Wraith(monsterTwoHealth, monsterTwoAP, monsterTwoDP, monsterTwoS);
                                    monsterTwo = true;
                                }
                                else
                                {
                                    monsterTwo = false;
                                    monster = new Shapeshifter(0, 0, 0, 0);
                                }
                                break;
                            case 5:
                                monsterChosen2 = 5;
                                if (monsterChosen2 != monsterChosen)
                                {
                                    ValidateUserInput(1);
                                    monster = new Ghoul(monsterTwoHealth, monsterTwoAP, monsterTwoDP, monsterTwoS);
                                    monsterTwo = true;
                                }
                                else
                                {
                                    monsterTwo = false;
                                    monster = new Shapeshifter(0, 0, 0, 0);
                                }
                                break;
                            default:
                                monsterTwo = false;
                                monster = new Shapeshifter(0, 0, 0, 0);
                                break;
                        }
                    } 
                    while (!monsterTwo || (monsterChosen == monsterChosen2));

                    //Create new Fight instance to simulate fight
                    Fight fight = new();
                    fight.DoFight(player: player, monster: monster);
                    Console.WriteLine("\n\nPress any key to continue..");
                    Console.ReadLine();
                }
                //Print the tutorial in Option2
                else if (option == 2)
                {
                    Console.Clear();
                    PrintTutorial();
                }
                //Exit the game in Option3
                else if (option == 3)
                {
                    Console.Clear();
                    Environment.Exit(0);
                }
                else option = 0;
            } 
            //Keep game alive while option is not to quit it
            while (option != 3);
        }

        //Below are functions make code more readable
        public static void PrintTitle()
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("███╗   ███╗ ██████╗ ███╗   ██╗███████╗████████╗███████╗██████╗      █████╗ ████████╗████████╗ █████╗  ██████╗██╗  ██╗");
            Console.WriteLine("████╗ ████║██╔═══██╗████╗  ██║██╔════╝╚══██╔══╝██╔════╝██╔══██╗    ██╔══██╗╚══██╔══╝╚══██╔══╝██╔══██╗██╔════╝██║ ██╔╝");
            Console.WriteLine("██╔████╔██║██║   ██║██╔██╗ ██║███████╗   ██║   █████╗  ██████╔╝    ███████║   ██║      ██║   ███████║██║     █████╔╝ ");
            Console.WriteLine("██║╚██╔╝██║██║   ██║██║╚██╗██║╚════██║   ██║   ██╔══╝  ██╔══██╗    ██╔══██║   ██║      ██║   ██╔══██║██║     ██╔═██╗ ");
            Console.WriteLine("██║ ╚═╝ ██║╚██████╔╝██║ ╚████║███████║   ██║   ███████╗██║  ██║    ██║  ██║   ██║      ██║   ██║  ██║╚██████╗██║  ██╗");
            Console.WriteLine("╚═╝     ╚═╝ ╚═════╝ ╚═╝  ╚═══╝╚══════╝   ╚═╝   ╚══════╝╚═╝  ╚═╝    ╚═╝  ╚═╝   ╚═╝      ╚═╝   ╚═╝  ╚═╝ ╚═════╝╚═╝  ╚═╝");
            Console.WriteLine("\n\n");
        }

        public static void PrintOptions()
        {
            Console.WriteLine("Please choose one of the following options...\n");
            Console.WriteLine("1. Play and FIGHT");
            Console.WriteLine("2. Tutorial");
            Console.WriteLine("3. Exit\n");
        }

        public static void PrintTutorial()
        {
            PrintTitle();

            Console.WriteLine("Tutorial for the game:\n\n");
            Console.WriteLine("Choose in option 1 which monsters should fight.\n");
            Console.WriteLine("Let the fighting begin.\n");
            Console.WriteLine("Just sit back, relax and enjoy those creatures fighting for their lives.\n\n\n");
            Console.WriteLine("Press any key to return to the menu..\n");
            Console.ReadKey();
        }

        public static void PrintMonsters()
        {
            Console.WriteLine("Choose which monster should fight:\n\n");
            Console.WriteLine("1. Shapeshifter, species of monster that can take the form of any human being.");
            Console.WriteLine("2. Vampire, species of blood-drinking supernatural creatures that were once human.");
            Console.WriteLine("3. Werewolve, species of monster that can morph into a combination of human and wolf.");
            Console.WriteLine("4. Wraith, species of monster that feed on human brain fluids and can infect them with high doses of dopamine.");
            Console.WriteLine("5. Ghoul, of monsters that feed mainly on the flesh of the dead and assume the form of their victims.");
        }

        public void ValidateUserInput(int whichMonster)
        {
            if (whichMonster == 0)
            {
                do
                {
                    Console.Write($"Choose the Health of the Monster between {minHP} and {maxHP}.\n");
                    successHealth = float.TryParse(Console.ReadLine(), out monsterOneHealth);
                    if (monsterOneHealth < minHP || monsterOneHealth > maxHP) { validConsoleInputHealth = false; }
                    else { validConsoleInputHealth = true; }
                } while (!validConsoleInputHealth);

                do
                {
                    Console.WriteLine($"Choose the AttackPoints of the monster between {minAP} and {maxAP}.\n");
                    successAP = float.TryParse(Console.ReadLine(), out monsterOneAP);
                    if (monsterOneAP < minAP || monsterOneAP > maxAP) { validConsoleInputAP = false; }
                    else { validConsoleInputAP = true; }
                } while (!validConsoleInputAP);

                do
                {
                    Console.Write($"Choose the DefensePoints of the monster between {minDP} and {maxDP}.\n");
                    successDP = float.TryParse(Console.ReadLine(), out monsterOneDP);
                    if (monsterOneDP < minDP || monsterOneDP > maxDP) { validConsoleInputDP = false; }
                    else { validConsoleInputDP = true; }
                } while (!validConsoleInputDP);

                do
                {
                    Console.WriteLine($"Choose the AttackSpeed of the monster between {minS} and {maxS}.\n");
                    successS = float.TryParse(Console.ReadLine(), out monsterOneS);
                    if (monsterOneS < minS || monsterOneS > maxS) { validConsoleInputS = false; }
                    else { validConsoleInputS = true; }
                } while (!validConsoleInputS);
            }
            else
            {
                do
                {
                    Console.Write($"Choose the Health of the Monster between {minHP} and {maxHP}.\n");
                    successHealth = float.TryParse(Console.ReadLine(), out monsterTwoHealth);
                    if (monsterTwoHealth < minHP || monsterTwoHealth > maxHP) { validConsoleInputHealth = false; }
                    else { validConsoleInputHealth = true; }
                } while (!validConsoleInputHealth);

                do
                {
                    Console.WriteLine($"Choose the AttackPoints of the monster between {minAP} and {maxAP}.\n");
                    successAP = float.TryParse(Console.ReadLine(), out monsterTwoAP);
                    if (monsterTwoAP < minAP || monsterTwoAP > maxAP) { validConsoleInputAP = false; }
                    else { validConsoleInputAP = true; }
                } while (!validConsoleInputAP);

                do
                {
                    Console.Write($"Choose the DefensePoints of the monster between {minDP} and {maxDP}.\n");
                    successDP = float.TryParse(Console.ReadLine(), out monsterTwoDP);
                    if (monsterTwoDP < minDP || monsterTwoDP > maxDP) { validConsoleInputDP = false; }
                    else { validConsoleInputDP = true; }
                } while (!validConsoleInputDP);

                do
                {
                    Console.WriteLine($"Choose the AttackSpeed of the monster between {minS} and {maxS}.\n");
                    successS = float.TryParse(Console.ReadLine(), out monsterTwoS);
                    if (monsterTwoS < minS || monsterTwoS > maxS) { validConsoleInputS = false; }
                    else { validConsoleInputS = true; }
                } while (!validConsoleInputS);
            }
        }
    }
}
