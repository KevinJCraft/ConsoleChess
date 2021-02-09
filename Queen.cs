namespace ConsoleChess
{
    class Queen : Piece
    {
        public override string Display { get; set; }
        public Queen(int rank, char file, string team) : base(rank, file, team)
        {
            if (team == "black")
            {
                Display = "\u265B ";
            }
            else
            {
                Display = "\u2655 ";
            }
        }
    }
}