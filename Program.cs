using System;

namespace ConsoleChess
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();
            game.DisplayBoard();

            //var king = new King();

            //Square kingSquare = board.GetSquareAt(1, 'e');
            //kingSquare.Piece = king;
        }
    }
}
