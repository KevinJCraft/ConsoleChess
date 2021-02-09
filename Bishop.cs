namespace ConsoleChess
{
    class Bishop : Piece
    {
        public override string Display { get; set; }
        public Bishop(int rank, char file, string team) : base(rank, file, team)
        {
            if (team == "black")
            {
                Display = "\u265D ";
            }
            else
            {
                Display = "\u2657 ";
            }
        }
    }
}