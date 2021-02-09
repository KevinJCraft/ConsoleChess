using System.Collections.Generic;
namespace ConsoleChess
{
    class Game
    {
        public List<Piece> Pieces { get; set; }
        public Board Board { get; set; }

        public Game()
        {
            Pieces = getFreshPieces();
            Board = new Board();
        }

        public void DisplayBoard()
        {
            Board.PrintBoard(Pieces);
        }

        public List<Piece> getFreshPieces()
        {
            List<Piece> Pieces = new List<Piece>();
            Pieces.Add(new Bishop(8, 'c', "black"));
            Pieces.Add(new Bishop(8, 'f', "black"));
            Pieces.Add(new Knight(8, 'b', "black"));
            Pieces.Add(new Knight(8, 'g', "black"));
            Pieces.Add(new Rook(8, 'a', "black"));
            Pieces.Add(new Rook(8, 'h', "black"));
            Pieces.Add(new King(8, 'e', "black"));
            Pieces.Add(new Queen(8, 'd', "black"));
            Pieces.Add(new Pawn(7, 'a', "black"));
            Pieces.Add(new Pawn(7, 'b', "black"));
            Pieces.Add(new Pawn(7, 'c', "black"));
            Pieces.Add(new Pawn(7, 'd', "black"));
            Pieces.Add(new Pawn(7, 'e', "black"));
            Pieces.Add(new Pawn(7, 'f', "black"));
            Pieces.Add(new Pawn(7, 'g', "black"));
            Pieces.Add(new Pawn(7, 'h', "black"));
            Pieces.Add(new Bishop(1, 'c', "white"));
            Pieces.Add(new Bishop(1, 'f', "white"));
            Pieces.Add(new Knight(1, 'b', "white"));
            Pieces.Add(new Knight(1, 'g', "white"));
            Pieces.Add(new Rook(1, 'a', "white"));
            Pieces.Add(new Rook(1, 'h', "white"));
            Pieces.Add(new King(1, 'e', "white"));
            Pieces.Add(new Queen(1, 'd', "white"));
            Pieces.Add(new Pawn(2, 'a', "white"));
            Pieces.Add(new Pawn(2, 'b', "white"));
            Pieces.Add(new Pawn(2, 'c', "white"));
            Pieces.Add(new Pawn(2, 'd', "white"));
            Pieces.Add(new Pawn(2, 'e', "white"));
            Pieces.Add(new Pawn(2, 'f', "white"));
            Pieces.Add(new Pawn(2, 'g', "white"));
            Pieces.Add(new Pawn(2, 'h', "white"));
            return Pieces;
        }
        public void Reset()
        {
            this.Pieces.Clear();
            this.Pieces = getFreshPieces();
        }
    }
}