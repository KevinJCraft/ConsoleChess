namespace ConsoleChess
{
    class Piece
    {
        public Square Location { get; set; }

        public virtual string Display()
        {
            return "  ";
        }
    }
}
