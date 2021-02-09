namespace ConsoleChess
{
    class Piece
    {
        public int Rank { get; set; }
        public char File { get; set; }
        public string Team { get; }

        public virtual string Display { get; set; }

        public Piece(int rank, char file, string team)
        {
            Rank = rank;
            File = file;
            team = Team;
        }



    }
}
