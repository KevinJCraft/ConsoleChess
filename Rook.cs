namespace ConsoleChess
{
    class Rook : Piece
    {
        public override string Display { get; set; }
        public Rook(int rank, char file, string team) : base(rank, file, team)
        {
            if (team == "black")
            {
                Display = "\u265C ";
            }
            else
            {
                Display = "\u2656 ";
            }
        }
    }
}