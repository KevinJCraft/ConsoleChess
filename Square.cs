using System;
namespace ConsoleChess
{
    class Square
    {
        public int Rank { get; private set; }
        public char File { get; private set; }
        public System.ConsoleColor Color { get; private set; }
        public Square(int rank, char file, System.ConsoleColor color)
        {
            Rank = rank;
            File = file;
            Color = color;
        }
        public void PrintSquare(string pieceChar)
        {
            Console.BackgroundColor = Color;
            Console.Write(pieceChar, Console.ForegroundColor);
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}