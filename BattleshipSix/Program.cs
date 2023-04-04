using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string currentPlayer = null;
            string boatRotation = null;
            int boatCoordinateX = 0;
            int boatCoordinateY = 0;
            int boardCounter = 0;

            CreateBoard(playerBoardOne, playerBoardTwo, boardCounter, ref currentPlayer);
        }
        
        //makes your own board where you were hit
        private static void CreateBoard(string[,] playerBoardOne, string[,] playerBoardTwo, int boardCounter, ref string currentPlayer)
        {

            for (int i = 0; i < 10; i++)
            {
                boardCounter = i + 1;
                Console.Write("   " + boardCounter + "   ");
            }

            if (currentPlayer == "one")
            {
                
                
            }
            

        }
    }
}
