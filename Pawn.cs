namespace ConsoleChess
{
    class Pawn : Piece
    {
        public override string Display { get; set; }
        public Pawn(int rank, char file, string team) : base(rank, file, team)
        {
            if (team == "black")
            {
                Display = "\u265F ";
            }
            else
            {
                Display = "\u2659 ";
            }
        }

    }
}