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
        // OPTION FOR PROGRAM UI
        public static int option = 0;

        // MONSTER OPTIONS
        public static int monsterOption = 0;
        public static bool monsterOne = false;
        public static bool monsterTwo = false;
        public static int monsterChosen = 0;
        public static int monsterChosen2 = 0;

        // INTEGER TO CHOOSE WHICH MONSTER
        public static int consoleInputMonsterOne = 0;
        public static int consoleInputMonsterTwo = 0;

        // VARIABLES TO USE FOR VALIDATIOn
        public static bool validConsoleInputHealth = false;
        public static bool validConsoleInputAP = false;
        public static bool validConsoleInputDP = false;
        public static bool validConsoleInputS = false;
        public static bool successHealth = false;
        public static bool successAP = false;
        public static bool successDP = false;
        public static bool successS = false;

        // CHANGABLE VARIABLES OF MONSTERSTATS
        // HP
        public static int minHP = 600;
        public static int maxHP = 7000;
        // AP
        public static int minAP = 70;
        public static int maxAP = 450;
        // DP
        public static int minDP = 15;
        public static int maxDP = 60;
        // S
        public static int minS = 1;
        public static int maxS = 10;

        // VARIABLE FOR CUSTOMIZING MONSTERS IN PROGRAM
        public static float monsterOneHealth = 0.0f;
        public static float monsterTwoHealth = 0.0f;
        public static float monsterOneAP = 0.0f;
        public static float monsterTwoAP = 0.0f;
        public static float monsterOneDP = 0.0f;
        public static float monsterTwoDP = 0.0f;
        public static float monsterOneS = 0.0f;
        public static float monsterTwoS = 0.0f;

        // Main logic
        public void GameLoop()
        {
            Console.Clear();
            PrintTitle();
            Console.WriteLine("Press any key to continue..\n");
            Console.ReadLine();
            Console.Clear();
            do
            {
                Console.Clear();
                PrintTitle();
                PrintOptions();
                int.TryParse(Console.ReadLine(), out option);

                if (option == 1)
                {
                    // SELECT MONSTER 1
                    // Make new monster class
                    Monster player;
                    do
                    {
                        Console.Clear();
                        PrintMonsters();

                        int.TryParse(Console.ReadLine(), out consoleInputMonsterOne);

                        // Int to choose which monster
                        switch (consoleInputMonsterOne)
                        {
                            case 1:
                                monsterChosen = 1;
                                ValidateUserInput(0);
                                player = new Shapeshifter(monsterOneHealth, monsterOneAP, monsterOneDP, monsterOneS, monsterOneHealth);
                                monsterOne = true;
                                break;
                            case 2:
                                monsterChosen = 2;
                                ValidateUserInput(0);
                                player = new Vampire(monsterOneHealth, monsterOneAP, monsterOneDP, monsterOneS, monsterOneHealth);
                                monsterOne = true;
                                break;
                            case 3:
                                monsterChosen = 3;
                                ValidateUserInput(0);
                                player = new Werewolve(monsterOneHealth, monsterOneAP, monsterOneDP, monsterOneS, monsterOneHealth);
                                monsterOne = true;
                                break;

                            case 4:
                                monsterChosen = 4;
                                ValidateUserInput(0);
                                player = new Wraith(monsterOneHealth, monsterOneAP, monsterOneDP, monsterOneS, monsterOneHealth);
                                monsterOne = true;
                                break;
                            case 5:
                                monsterChosen = 5;
                                ValidateUserInput(0);
                                player = new Ghoul(monsterOneHealth, monsterOneAP, monsterOneDP, monsterOneS, monsterOneHealth);
                                monsterOne = true;
                                break;

                            default:
                                monsterOne = false;
                                player = new Shapeshifter(0, 0, 0, 0, 0);
                                break;
                        }
                        // Do loop as long as no monster has been choosen
                    } while (!monsterOne);


                    // SELECT MONSTER 2
                    // Make new monster class
                    Monster monster;

                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Same monster-types cannot fight eachother!\n\n");
                        PrintMonsters();

                        int.TryParse(Console.ReadLine(), out consoleInputMonsterOne);

                        // Int to choose which monster
                        switch (consoleInputMonsterOne)
                        {
                            case 1:
                                monsterChosen2 = 1;
                                if (monsterChosen2 != monsterChosen)
                                {
                                    ValidateUserInput(1);
                                    monster = new Shapeshifter(monsterTwoHealth, monsterTwoAP, monsterTwoDP, monsterTwoS, monsterTwoHealth);
                                    monsterTwo = true;
                                }
                                else
                                {
                                    monsterTwo = false;
                                    monster = new Shapeshifter(0, 0, 0, 0, 0);
                                }
                                break;
                            case 2:
                                monsterChosen2 = 2;
                                if (monsterChosen2 != monsterChosen)
                                {
                                    ValidateUserInput(1);
                                    monster = new Vampire(monsterTwoHealth, monsterTwoAP, monsterTwoDP, monsterTwoS, monsterTwoHealth);
                                    monsterTwo = true;
                                }
                                else
                                {
                                    monsterTwo = false;
                                    monster = new Shapeshifter(0, 0, 0, 0, 0);
                                }
                                break;
                            case 3:
                                monsterChosen2 = 3;
                                if (monsterChosen2 != monsterChosen)
                                {
                                    ValidateUserInput(1);
                                    monster = new Werewolve(monsterTwoHealth, monsterTwoAP, monsterTwoDP, monsterTwoS, monsterTwoHealth);
                                    monsterTwo = true;
                                }
                                else
                                {
                                    monsterTwo = false;
                                    monster = new Shapeshifter(0, 0, 0, 0, 0);
                                }
                                break;
                            case 4:
                                monsterChosen2 = 4;
                                if (monsterChosen2 != monsterChosen)
                                {
                                    ValidateUserInput(1);
                                    monster = new Wraith(monsterTwoHealth, monsterTwoAP, monsterTwoDP, monsterTwoS, monsterTwoHealth);
                                    monsterTwo = true;
                                }
                                else
                                {
                                    monsterTwo = false;
                                    monster = new Shapeshifter(0, 0, 0, 0, 0);
                                }
                                break;
                            case 5:
                                monsterChosen2 = 5;
                                if (monsterChosen2 != monsterChosen)
                                {
                                    ValidateUserInput(1);
                                    monster = new Ghoul(monsterTwoHealth, monsterTwoAP, monsterTwoDP, monsterTwoS, monsterTwoHealth);
                                    monsterTwo = true;
                                }
                                else
                                {
                                    monsterTwo = false;
                                    monster = new Shapeshifter(0, 0, 0, 0, 0);
                                }
                                break;
                            default:
                                monsterTwo = false;
                                monster = new Shapeshifter(0, 0, 0, 0, 0);
                                break;
                        }
                        // Do loop as long as no monsters has been choosen or monster1 = monster2
                    } while (!monsterTwo || (monsterChosen == monsterChosen2));

                    // Make new fight class
                    Fight fight = new Fight();
                    // Execute fight logic
                    fight.DoFight(player: player, monster: monster);
                    Console.WriteLine("\n\nPress any key to continue..");
                    Console.ReadLine();
                }
                else if (option == 2) // Tutorial option
                {
                    Console.Clear();
                    PrintTutorial();
                }
                else if (option == 3) // Program exit option
                {
                    Console.Clear();
                    Environment.Exit(0);
                }
                else { option = 0; }
                // Do loop as long as option is not to quit
            } while (option != 3);
        }

        // Prints the title
        public void PrintTitle()
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

        // Prints the options
        public void PrintOptions()
        {
            Console.WriteLine("Please choose one of the following options...\n");
            Console.WriteLine("1. Play and FIGHT");
            Console.WriteLine("2. Tutorial");
            Console.WriteLine("3. Exit\n");
        }

        // Prints the tutorial
        public void PrintTutorial()
        {
            PrintTitle();

            Console.WriteLine("Tutorial for the game:\n\n");
            Console.WriteLine("Choose in option 1 which monsters should fight.\n");
            Console.WriteLine("Let the fighting begin.\n");
            Console.WriteLine("Just sit back, relax and enjoy those creatures fighting for their lives.\n");
            Console.WriteLine("To quit the game press ESCAPE or the ENTER key.\n\n\n");
            Console.WriteLine("Press any key to return to the menu..\n");
            Console.ReadKey();
        }

        // Prints available monsters
        public void PrintMonsters()
        {
            Console.WriteLine("Choose which monster should fight:\n\n");
            Console.WriteLine("1. Shapeshifter, species of monster that can take the form of any human being.");
            Console.WriteLine("2. Vampire, species of blood-drinking supernatural creatures that were once human.");
            Console.WriteLine("3. Werewolve, species of monster that can morph into a combination of human and wolf.");
            Console.WriteLine("4. Wraith, species of monster that feed on human brain fluids and can infect them with high doses of dopamine.");
            Console.WriteLine("5. Ghoul, of monsters that feed mainly on the flesh of the dead and assume the form of their victims.");
        }

        // Function for validating userinput (check if numbers are in the limits etc.)
        public void ValidateUserInput(int whichMonster)
        {
            // whichMonster determines if user is giving input to monster 1 or 2
            if (whichMonster == 0)
            {
                #region run checks for monster1
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
                #endregion
            }
            else
            {
                #region run checks for monster2
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
                #endregion
            }
        }
    }
}
