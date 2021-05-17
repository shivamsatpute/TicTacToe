using System;

namespace TicTacToeGame
{
    class TicTacToe
    {
        public static char[] board;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TicTacToe");

            createBoard();
        }

        private static char[] createBoard()
        {
             board = new char[10];
            for (int i = 0; i < 10; i++)
            {
                board[i] = ' ';
            }
            return board;
        }
    }
    
}

