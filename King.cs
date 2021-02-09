namespace ConsoleChess
{
    class King : Piece
    {
        public override string Display { get; set; }
        public King(int rank, char file, string team) : base(rank, file, team)
        {

            if (team == "black")
            {
                Display = "\u265A ";
            }
            else
            {
                Display = "\u2654 ";
            }
        }

    }
}