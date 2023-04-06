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

            playerBoardOne[9, 3] = "x";
            CreateBoard(playerBoardOne, playerBoardTwo, boardCounter, ref currentPlayer);
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
                //draws the top part of the square
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine();
                    Console.Write("     ");
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
        }
    }
}
