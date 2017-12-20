using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playing_In_Traffic
{
    class GameSpace
    {
        public int gameSizeX = 300;
        public int gameSizeY = 300;
        public Object[,] gameBoard;
        

        public GameSpace()
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

        public GameSpace(int input)
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

        public GameSpace(int inputX, int inputY)
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

        public void add(int x, int y, object obj)
        {
            gameBoard[x, y] = obj;

        }
      

    }
}
