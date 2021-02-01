using System;
namespace ConsoleChess
{
    class Board
    {
        private Square[,] _board = new Square[8, 8];
        private int[] Ranks = { 1, 2, 3, 4, 5, 6, 7, 8 };
        private char[] Files = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
        public Board()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            System.ConsoleColor color;
            for (int i = 0; i < 8; i++)
            {
                for (int x = 0; x < 8; x++)
                {
                    if ((x + i) % 2 == 0)
                    {
                        color = System.ConsoleColor.Blue;
                    }
                    else
                    {
                        color = System.ConsoleColor.Yellow;
                    }
                    _board[i, x] = new Square(Ranks[i], Files[x], color);
                }
            }
        }

        public void PrintBoard()
        {
            Console.Clear();
            foreach (Square square in _board)
            {
                if (square.File.Equals('a'))
                {
                    Console.Write(square.Rank);
                }
                square.PrintSquare();
                if (square.File.Equals('h'))
                {
                    Console.Write("\n");
                }
            }
            Console.WriteLine(" a b c d e f g h");
        }

        // public Square GetSquareAt(int rank, char file)
        // {
        //     foreach (Square square in _board)
        //     {
        //         if (square.Rank == rank && square.File.Equals(file))
        //         {
        //             return square;
        //         }
        //     }
        //     return null;
        // }
    }
}