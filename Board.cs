using System;
using System.Collections.Generic;
using System.Linq;
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

        public void PrintBoard(List<Piece> pieces)
        {
            Console.Clear();
            foreach (Square square in _board)
            {
                string occupantDisplay = getOccupant(pieces, square);
                if (square.File.Equals('a'))
                {
                    Console.Write(square.Rank);
                }
                square.PrintSquare(occupantDisplay);
                if (square.File.Equals('h'))
                {
                    Console.Write("\n");
                }
            }
            Console.WriteLine(" a b c d e f g h");
        }

        public string getOccupant(List<Piece> pieces, Square square)
        {
            string display = "  ";
            foreach (Piece p in pieces)
            {
                if (p.File == square.File && p.Rank == square.Rank)
                {
                    Console.ForegroundColor = p.Team == "black" ? ConsoleColor.Black : ConsoleColor.White;
                    display = p.Display;
                }
            }

            return display;
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