using System;

namespace BattleshipSix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            string[,] playerBoardOne = new string[10, 10];
            string[,] playerBoardTwo = new string[10, 10];
            bool versusAI = false;
            string currentPlayer = "one";
            string boatRotation = null;
            int boatCoordinateX = 0;
            int boatCoordinateY = 0;
            int boardCounter = 0;
            int xCoordShot = 0;
            int yCoordShot = 0;


            CreateBoard(playerBoardOne, playerBoardTwo, boardCounter, ref currentPlayer);
            PlayerTurn(playerBoardOne, playerBoardTwo, boardCounter, ref currentPlayer, ref xCoordShot, ref yCoordShot);
        }
        
        //makes your own board where you were hit
        private static void CreateBoard(string[,] playerBoardOne, string[,] playerBoardTwo, int boardCounter, ref string currentPlayer)
        {
            //draws the numbers
            Console.Write("     ");
            for (int i = 0; i < 10; i++)
            {
                boardCounter = i + 1;
                Console.Write("   " + boardCounter + "   ");
            }
            //check if play is one
            if (currentPlayer == "one")
            {
                //draws the horizontal line
                Console.WriteLine();
                Console.Write("     ");
                for (int m = 0; m < 10; m++)
                {
                    Console.Write(" ******");
                }
                //draws the player's board
                for (int i = 0; i < 10; i++)
                {
                    //sets draw counter to i + 1
                    boardCounter = i + 1;
                    //draws the top part of the square
                    Console.WriteLine();
                    Console.Write("     ");
                    for (int j = 0; j < 10; j++)
                    {
                        Console.Write("|      ");
                    }
                    Console.Write("|");

                    //draws the middle with the player's board
                    Console.WriteLine();
                    Console.Write("  " + boardCounter + "  ");
                    for (int k = 0; k < 10; k++)
                    {
                        Console.Write("|   " + playerBoardOne[i, k] + "   ");
                    }
                    Console.Write("|");

                    //draws the bottom of the square
                    Console.WriteLine();
                    Console.Write("     ");
                    for (int l = 0; l < 10; l++)
                    {
                        Console.Write("|      ");
                    }
                    Console.Write("|");

                    //draws the horizontal line
                    Console.WriteLine();
                    Console.Write("     ");
                    for (int m = 0; m < 10; m++)
                    {
                        Console.Write(" ******");
                    }
                }
            }
            //check if play is two
            if (currentPlayer == "two")
            {
                //draws the horizontal line
                Console.WriteLine();
                Console.Write("     ");
                for (int m = 0; m < 10; m++)
                {
                    Console.Write(" ******");
                }
                //draws the player's board
                for (int i = 0; i < 10; i++)
                {
                    //sets draw counter to i + 1
                    boardCounter = i + 1;
                    //draws the top part of the square
                    Console.WriteLine();
                    Console.Write("  " + boardCounter + "  ");
                    for (int j = 0; j < 10; j++)
                    {
                        Console.Write("|      ");
                    }
                    Console.Write("|");

                    //draws the middle with the player's board
                    Console.WriteLine();
                    Console.Write("     ");
                    for (int k = 0; k < 10; k++)
                    {
                        Console.Write("|   " + playerBoardTwo[i, k] + "   ");
                    }
                    Console.Write("|");

                    //draws the bottom of the square
                    Console.WriteLine();
                    Console.Write("     ");
                    for (int l = 0; l < 10; l++)
                    {
                        Console.Write("|      ");
                    }
                    Console.Write("|");

                    //draws the horizontal line
                    Console.WriteLine();
                    Console.Write("     ");
                    for (int m = 0; m < 10; m++)
                    {
                        Console.Write(" ******");
                    }
                }
            }
        }
        private static void PlayerTurn(string[,] playerBoardOne, string[,] playerBoardTwo, int boardCounter, ref string currentPlayer, ref int xCoordShot, ref int yCoordShot)
        {
            //shows which player turn
            Console.WriteLine("\nCurrent Player: " + currentPlayer);
            if (currentPlayer == "one")
            {
                Console.WriteLine("What x coordinate for shot");
                xCoordShot = Convert.ToInt32(Console.ReadLine());
                //checks if bigger than 0
                if (xCoordShot > 0)
                {
                    //checks if smaller than 11
                    if (xCoordShot < 11)
                    {
                        Console.WriteLine("What y coordinate for shot");
                        yCoordShot = Convert.ToInt32(Console.ReadLine());
                        //checks if bigger than 0
                        if (yCoordShot > 0)
                        {
                            //checks if smaller than 11
                            if (yCoordShot < 11)
                            {

                            }
                            else PlayerTurn(playerBoardOne, playerBoardTwo, boardCounter, ref currentPlayer, ref xCoordShot, ref yCoordShot);
                        }
                        else PlayerTurn(playerBoardOne, playerBoardTwo, boardCounter, ref currentPlayer, ref xCoordShot, ref yCoordShot);
                    }
                    else PlayerTurn(playerBoardOne, playerBoardTwo, boardCounter, ref currentPlayer, ref xCoordShot, ref yCoordShot);
                }
                else PlayerTurn(playerBoardOne, playerBoardTwo, boardCounter, ref currentPlayer, ref xCoordShot, ref yCoordShot);
            }
        }
        private static void BoatSetup()
        {

        }
    }
}
