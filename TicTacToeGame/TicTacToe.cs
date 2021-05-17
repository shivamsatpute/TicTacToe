using System;

namespace TicTacToeGame
{
    class TicTacToe
    {
        public static char[] board;
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TicTacToe");
            createBoard();
            choice();
            Board();
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
        private static void Board()

        {

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);

            Console.WriteLine("     |     |      ");

        }
    }

}

