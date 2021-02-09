namespace ConsoleChess
{
    class Knight : Piece
    {
        public override string Display { get; set; }
        public Knight(int rank, char file, string team) : base(rank, file, team)
        {
            if (team == "black")
            {
                Display = "\u265E ";
            }
            else
            {
                Display = "\u2658 ";
            }
        }

    }
}