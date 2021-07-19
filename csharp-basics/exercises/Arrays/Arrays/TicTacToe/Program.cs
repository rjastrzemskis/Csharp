using System;

namespace TicTacToe
{
    class Program
    {
        private static char[,] board = new char[3, 3];

        private static void Main(string[] args)
        {
            InitBoard();
        }

        private static void InitBoard()
        {
            char player = 'X';
            Console.WriteLine("Welcome to tic tac toe");
            Console.WriteLine("Starting player is " + player);

            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                    board[r, c] = ' ';
            }
            DisplayBoard(player);
        }

        private static void DisplayBoard(char player)
        {
            Console.WriteLine("      0" + " 1 " + "2 ");
            Console.WriteLine("  0  |" + board[0, 0] + "|" + board[0, 1] + "|" + board[0, 2] + "|");
            Console.WriteLine("     --+-+--");
            Console.WriteLine("  1  |" + board[1, 0] + "|" + board[1, 1] + "|" + board[1, 2] + "|");
            Console.WriteLine("     --+-+--");
            Console.WriteLine("  2  |" + board[2, 0] + "|" + board[2, 1] + "|" + board[2, 2] + "|");
            Play(player);
        }

        private static void Play(char player)
        {
            Console.Write("Player " + player + " , choose your location on row from 0-2: ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Player " + player + " , choose your location on column from 0-2: ");
            int column = Convert.ToInt32(Console.ReadLine());

            for (int r = row; r <= row; r++)
            {
                for (int c = column; c <= column; c++)
                    if (board[r, c] == ' ')
                    {
                        board[r, c] = player;
                        player = player == 'X' ? 'O' : 'X';
                    }
            }

            char winner = Win();
            if (winner != ' ')
            {
                Console.WriteLine("      0" + " 1 " + "2 ");
                Console.WriteLine("  0  |" + board[0, 0] + "|" + board[0, 1] + "|" + board[0, 2] + "|");
                Console.WriteLine("     --+-+--");
                Console.WriteLine("  1  |" + board[1, 0] + "|" + board[1, 1] + "|" + board[1, 2] + "|");
                Console.WriteLine("     --+-+--");
                Console.WriteLine("  2  |" + board[2, 0] + "|" + board[2, 1] + "|" + board[2, 2] + "|");
                Console.WriteLine("Winner is " + winner);
                Reset();
            }
            Draw();
            DisplayBoard(player);
        }

        private static char Win()
        {
            if (board[0, 0] == board[0, 1] && board[0, 0] == board[0, 2])
                return board[0, 0];
            else if (board[1, 0] == board[1, 1] && board[1, 0] == board[1, 2])
                return board[1, 0];
            else if (board[2, 0] == board[2, 1] && board[2, 0] == board[2, 2])
                return board[2, 0];
            else if (board[2, 2] == board[1, 1] && board[2, 2] == board[0, 0])
                return board[2, 2];
            else if (board[0, 2] == board[1, 1] && board[0, 2] == board[2, 0])
                return board[0, 2];
            else if (board[0, 0] == board[1, 0] && board[0, 0] == board[2, 0])
                return board[0, 0];
            else if (board[0, 1] == board[1, 1] && board[0, 1] == board[2, 1])
                return board[0, 1];
            else if (board[0, 2] == board[1, 2] && board[0, 2] == board[2, 2])
                return board[0, 2];
            return ' ';
        }

        private static void Draw()
        {
            int steps = 0;
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    if (board[r, c] == 'X' || board[r, c] == 'O')
                        steps++;
                    if (steps == 9)
                    {
                        Console.WriteLine("      0" + " 1 " + "2 ");
                        Console.WriteLine("  0  |" + board[0, 0] + "|" + board[0, 1] + "|" + board[0, 2] + "|");
                        Console.WriteLine("     --+-+--");
                        Console.WriteLine("  1  |" + board[1, 0] + "|" + board[1, 1] + "|" + board[1, 2] + "|");
                        Console.WriteLine("     --+-+--");
                        Console.WriteLine("  2  |" + board[2, 0] + "|" + board[2, 1] + "|" + board[2, 2] + "|");
                        Console.WriteLine("The game is a tie");
                        Reset();
                    }
                }
            }
        }

        private static void Reset()
        {
            Console.Write("Wanna play again? y/n : ");
            string answer = Console.ReadLine();
            switch (answer.ToLower())
            {
                case "y":
                    Console.Clear();
                    InitBoard();
                    break;
                case "n":
                    System.Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("Invalid answer!");
                    Reset();
                    break;
            }
        }
    }
}

