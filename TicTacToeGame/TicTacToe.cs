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
            choice();
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

        public static void choice()
        {

            Console.WriteLine("Enter the choice \nX \n0");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "X":
                    Console.WriteLine("your choice is  X");
                    break;
                case "0":
                    Console.WriteLine("your choice is 0");
                    break;
                default:
                    Console.WriteLine("select valid option");
                    break;

            }
        }

    }
}

