using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playing_In_Traffic
{
    class GameSpace
    {
        private static int gameSizeX = 300;
        private static int gameSizeY = 300;
        private static Object[,] gameBoard;

       static void __init__()
       {
            gameBoard =  new Object[gameSizeX, gameSizeY];
            for (int x = 0; x < gameBoard.GetLength(0); x++)
            {
                for (int y = 0; y < gameBoard.GetLength(1); y++)
                {
                    gameBoard[x, y] = null;
                }
            }
       }

       static void __init__(int input)
       {
           gameSizeX = input;
           gameSizeY = input;

           gameBoard = new Object[gameSizeX, gameSizeY];
           for (int x = 0; x < gameBoard.GetLength(0); x++)
            {
                for (int y = 0; y < gameBoard.GetLength(1); y++)
                {
                    gameBoard[x, y] = null;
                }
            }
       }

        internal void add(int v1, int v2, object house)
        {
            throw new NotImplementedException();
        }

        static void __init__(int inputX, int inputY)
        {
            gameSizeX = inputX;
            gameSizeY = inputY;

            gameBoard = new Object[gameSizeX, gameSizeY];
            for (int x = 0; x < gameBoard.GetLength(0); x++)
            {
                for (int y = 0; y < gameBoard.GetLength(1); y++)
                {
                    gameBoard[x, y] = null;
                }
            }
        }
    }
}
