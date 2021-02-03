using System;
using System.Collections.Generic;
using System.IO;

namespace BattleBoats
{
    class Program
    {
        static bool comparison(List<string> RepeatTestList, string compare) 
        {
            foreach (var item in RepeatTestList)
            {
                if (item == compare) 
                {
                    return true;
                }
            }
            return false;
        }

        static int menu() 
        {
            Console.WriteLine("1) Create new game");
            Console.WriteLine("2) Continue game");
            Console.WriteLine("3) Quit");

            int menu = Convert.ToInt32(Console.ReadLine());
            return menu;
        }
        static void printGrid(string[,] shipCoords) 
        {
            int rowLength = shipCoords.GetLength(0);
            int colLength = shipCoords.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(string.Format("{0} ", shipCoords[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
        }
        static void Main(string[] args)
        {
            int menuChoice = 0;
            while (menuChoice != 3)
            {
                menuChoice = menu();
                switch (menuChoice)
                {
                    case 1:
                        string[,] playerSeesComputerCoords = new string[11, 37]
                        {
                        {" "," "," "," ","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_"},
                        {"_","_","_","_","|"," ","1"," ","|"," ","2"," ","|"," ","3"," ","|"," ","4"," ","|"," ","5"," ","|"," ","6"," ","|"," ","7"," ","|"," ","8"," ","|"},
                        {"|"," ","1"," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"},
                        {"|"," ","2"," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"},
                        {"|"," ","3"," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"},
                        {"|"," ","4"," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"},
                        {"|"," ","5"," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"},
                        {"|"," ","6"," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"},
                        {"|"," ","7"," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"},
                        {"|"," ","8"," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"},
                        {"-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-"},
                        };
                        string[,] playerCoords = new string[11, 37]
                        {
                        {" "," "," "," ","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_"},
                        {"_","_","_","_","|"," ","1"," ","|"," ","2"," ","|"," ","3"," ","|"," ","4"," ","|"," ","5"," ","|"," ","6"," ","|"," ","7"," ","|"," ","8"," ","|"},
                        {"|"," ","1"," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"},
                        {"|"," ","2"," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"},
                        {"|"," ","3"," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"},
                        {"|"," ","4"," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"},
                        {"|"," ","5"," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"},
                        {"|"," ","6"," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"},
                        {"|"," ","7"," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"},
                        {"|"," ","8"," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"},
                        {"-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-"},
                        };
                        string[,] computerCoords = new string[11, 37]
                        {
                        {" "," "," "," ","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_"},
                        {"_","_","_","_","|"," ","1"," ","|"," ","2"," ","|"," ","3"," ","|"," ","4"," ","|"," ","5"," ","|"," ","6"," ","|"," ","7"," ","|"," ","8"," ","|"},
                        {"|"," ","1"," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"},
                        {"|"," ","2"," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"},
                        {"|"," ","3"," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"},
                        {"|"," ","4"," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"},
                        {"|"," ","5"," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"},
                        {"|"," ","6"," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"},
                        {"|"," ","7"," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"},
                        {"|"," ","8"," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"," "," "," ","|"},
                        {"-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-"},
                        };
                        printGrid(playerCoords);
                        Console.WriteLine("Please enter the coordinates of your boats.");
                        for (int i = 0; i < 5; i++)
                        {
                            Console.Write("X axis, " + (i + 1) + ": ");
                            int ShipCoordXoriginal = (Convert.ToInt32(Console.ReadLine()));
                            int shipCoordX = (4 * (ShipCoordXoriginal)) + 2;
                            Console.Write("Y axis, " + (i + 1) + ": ");
                            int ShipCoordYoriginal = (Convert.ToInt32(Console.ReadLine()));
                            int shipCoordY = (ShipCoordYoriginal) + 1;
                            playerCoords[shipCoordY, shipCoordX] = "X";
                            Console.WriteLine();
                            Console.WriteLine("");
                        }
                        Console.WriteLine("-------------------------------------------------------------------------------------");
                        Console.WriteLine("Your grid: ");
                        Console.WriteLine("");
                        printGrid(playerCoords);
                        //Computer's Random Ship
                        Random rnd = new Random();
                        List<string> RepeatLimitList = new List<string>();
                        int RepeatLimit = 5;
                        while (RepeatLimit != 0)
                        {
                            int computerCoordsX = (4 * (rnd.Next(1, 8)) + 2);
                            int computerCoordsY = (rnd.Next(1, 8)) + 1;
                            string RepeatTest = computerCoordsX.ToString() + computerCoordsY.ToString();
                            if (comparison(RepeatLimitList, RepeatTest) == true)
                            {
                                continue;
                            }
                            else
                            {
                                computerCoords[computerCoordsY, computerCoordsX] = "X";
                                RepeatLimitList.Add(RepeatTest);
                                RepeatLimit--;
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Computer's grid: ");
                        Console.WriteLine("");
                        printGrid(playerSeesComputerCoords);
                        Console.WriteLine();
                        Console.WriteLine();
                        //Taking turn to fire at each other
                        int numberOfPlayerShips = 5;
                        int numberOfComputerShips = 5;
                        int TurnNumber = 1;
                        while (numberOfPlayerShips != 0 || numberOfComputerShips != 0)
                        {
                            File.WriteAllText(("ContinueCondtitons.txt"), numberOfPlayerShips.ToString());
                            
                            using (StreamWriter sw = File.AppendText("ContinueCondtitons.txt"))
                            {
                                sw.WriteLine(numberOfPlayerShips);
                                sw.WriteLine(TurnNumber);
                            }
                            File.WriteAllText("playerCoords.txt", "");
                            using (var sw = new StreamWriter("playerCoords.txt"))
                            {
                                for (int i = 0; i < playerCoords.GetLength(0); i++)
                                {
                                    for (int x = 0; x < playerCoords.GetLength(1); x++)
                                    {
                                        sw.Write(playerCoords[i, x]);
                                    }
                                }
                                sw.Close();
                            }
                            File.WriteAllText("computerCoords.txt", "");
                            using (var sw = new StreamWriter("computerCoords.txt"))
                            {
                                for (int i = 0; i < computerCoords.GetLength(0); i++)
                                {
                                    for (int x = 0; x < computerCoords.GetLength(1); x++)
                                    {
                                        sw.Write(computerCoords[i, x]);
                                    }
                                }
                                sw.Close();
                            }
                            File.WriteAllText("playerSeesComputerCoords.txt", "");
                            using (var sw = new StreamWriter("playerSeesComputerCoords.txt"))
                            {
                                for (int i = 0; i < playerSeesComputerCoords.GetLength(0); i++)
                                {
                                    for (int x = 0; x < playerSeesComputerCoords.GetLength(1); x++)
                                    {
                                        sw.Write(playerSeesComputerCoords[i, x]);
                                    }
                                }
                                sw.Close();
                            }
                            //Player's turn
                            Console.WriteLine("Turn "+ TurnNumber);
                            Console.WriteLine("PLayer's turn");
                            Console.WriteLine();
                            Console.WriteLine("Choose a coordinate to attack!");
                            Console.WriteLine();
                            Console.Write("X axis : ");
                            int AttackCoordXoriginal = (Convert.ToInt32(Console.ReadLine()));
                            int AttackCoordX = (4 * (AttackCoordXoriginal)) + 2;
                            Console.Write("Y axis : ");
                            int AttackCoordYoriginal = (Convert.ToInt32(Console.ReadLine()));
                            int AttackCoordY = (AttackCoordYoriginal) + 1;
                            if (computerCoords[AttackCoordY,AttackCoordX] == "X")
                            {
                                playerSeesComputerCoords[AttackCoordY, AttackCoordX] = "X";
                                numberOfComputerShips--;

                                Console.WriteLine("");
                                Console.WriteLine("You hit an enemy's ship, well done!");
                            }
                            else
                            {
                                playerSeesComputerCoords[AttackCoordY, AttackCoordX] = "O";
                                Console.WriteLine("There wasn't a ship in that location, try again!");
                            }
                            Console.WriteLine("Player's grid");
                            Console.WriteLine();
                            printGrid(playerSeesComputerCoords);
                            //Computer's turn
                            Console.WriteLine("");
                            Console.WriteLine("The enemy is firing at us!");
                            int AttackComputerCoordsX = (4 * (rnd.Next(1, 8)) + 2);
                            int AttackComputerCoordsY = (rnd.Next(1, 8)) + 1;
                            if (playerCoords[AttackComputerCoordsY, AttackComputerCoordsX] == "X")
                            {
                                playerCoords[AttackComputerCoordsY, AttackComputerCoordsX] = " ";
                                numberOfPlayerShips--;

                                Console.WriteLine("");
                                if (numberOfPlayerShips == 1)
                                {
                                    Console.WriteLine("You only have 1 ship left!");
                                }
                                else
                                {
                                    Console.WriteLine("You've lost a ship!");
                                }
                            }
                            else
                            {
                                playerCoords[AttackComputerCoordsY, AttackComputerCoordsX] = "O";
                                Console.WriteLine("Luckily they missed, make sure you hit them this time!");
                            }
                            Console.WriteLine("Computer's Grid");
                            Console.WriteLine("");
                            printGrid(playerCoords);
                        }
                        if (numberOfComputerShips == 0)
                        {
                            Console.WriteLine("Congratulations! You've taken down all enemy ships!");
                        }
                        else
                        {
                            Console.WriteLine("Oh no! Your fleet of ships has been destroyed!");                          
                        }
                        Console.WriteLine();
                        Console.WriteLine("-------------------------------------------------------------------------------------");

                        break;

                        //Continuing a game
                    case 2:
                        TextReader tr = new StreamReader("ContinueConditions.txt");
                        int NumberOfLines = 3;
                        int[] ListLines = new int[NumberOfLines];
                        for (int i = 1; i < NumberOfLines; i++)
                        {
                            ListLines[i] = Convert.ToInt32(tr.ReadLine());
                        }
                        int ContinueNumberOfPlayerShips = ListLines[1];
                        int ContinueNumberOfComputerShips = ListLines[2];
                        int ContinueTurnNumber = ListLines[3];
                        while (ContinueNumberOfPlayerShips != 0 || ContinueNumberOfComputerShips != 0) 
                        {
                            int TurnNumberFile = Convert.ToInt32(File.ReadAllText("NumberOfTurn.txt"));
                            //Player's turn
                            Console.WriteLine("Turn "+ ContinueTurnNumber);
                            Console.WriteLine("PLayer's turn");
                            Console.WriteLine();
                            Console.WriteLine("Choose a coordinate to attack!");
                            Console.WriteLine();
                            Console.Write("X axis : ");
                            int AttackCoordXoriginal = (Convert.ToInt32(Console.ReadLine()));
                            int AttackCoordX = (4 * (AttackCoordXoriginal)) + 2;
                            Console.Write("Y axis : ");
                            int AttackCoordYoriginal = (Convert.ToInt32(Console.ReadLine()));
                            int AttackCoordY = (AttackCoordYoriginal) + 1;
                            if (computerCoords[AttackCoordY,AttackCoordX] == "X")
                            {
                                playerSeesComputerCoords[AttackCoordY, AttackCoordX] = "X";
                                numberOfComputerShips--;

                                Console.WriteLine("");
                                Console.WriteLine("You hit an enemy's ship, well done!");
                            }
                            else
                            {
                                playerSeesComputerCoords[AttackCoordY, AttackCoordX] = "O";
                                Console.WriteLine("There wasn't a ship in that location, try again!");
                            }
                            Console.WriteLine("Player's grid");
                            Console.WriteLine();
                            printGrid(playerSeesComputerCoords);
                            //Computer's turn
                            Console.WriteLine("");
                            Console.WriteLine("The enemy is firing at us!");
                            int AttackComputerCoordsX = (4 * (rnd.Next(1, 8)) + 2);
                            int AttackComputerCoordsY = (rnd.Next(1, 8)) + 1;
                            if (playerCoords[AttackComputerCoordsY, AttackComputerCoordsX] == "X")
                            {
                                playerCoords[AttackComputerCoordsY, AttackComputerCoordsX] = " ";
                                numberOfPlayerShips--;

                                Console.WriteLine("");
                                if (numberOfPlayerShips == 1)
                                {
                                    Console.WriteLine("You only have 1 ship left!");
                                }
                                else
                                {
                                    Console.WriteLine("You've lost a ship!");
                                }
                            }
                            else
                            {
                                playerCoords[AttackComputerCoordsY, AttackComputerCoordsX] = "O";
                                Console.WriteLine("Luckily they missed, make sure you hit them this time!");
                            }
                            Console.WriteLine("Computer's Grid");
                            Console.WriteLine("");
                            printGrid(playerCoords);
                        }
                        if (numberOfComputerShips == 0)
                        {
                            Console.WriteLine("Congratulations! You've taken down all enemy ships!");
                        }
                        else
                        {
                            Console.WriteLine("Oh no! Your fleet of ships has been destroyed!");                          
                        }
                        Console.WriteLine();
                        Console.WriteLine("-------------------------------------------------------------------------------------");


                        break;
                    case 3:
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("You have entered an invalid number.");
                        Console.WriteLine("Please try again.");
                        Console.WriteLine();
                        break;
                }
            }                           
        }
    }
}
