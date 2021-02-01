using System;
namespace ConsoleChess
{
    class Square
    {
        public int Rank { get; private set; }
        public char File { get; private set; }
        public Piece Piece { get; set; }
        // { This is messing up my shit
        //     get { return Piece; }
        //     set { Piece = value; }
        // }
        public System.ConsoleColor Color { get; private set; }
        public Square(int rank, char file, System.ConsoleColor color)
        {
            Rank = rank;
            File = file;
            Color = color;
        }
        public void PrintSquare()
        {
            Console.BackgroundColor = Color;
            string print = "\u2654 ";
            if (Piece != null)
            {
                print = Piece.Display();
            }
            Console.Write(print);
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}