using System;

namespace ConsoleChess
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var board = new Board();
                board.PrintBoard();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //var king = new King();

            //Square kingSquare = board.GetSquareAt(1, 'e');
            //kingSquare.Piece = king;
        }
    }
}
