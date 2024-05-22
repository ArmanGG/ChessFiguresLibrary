public class Knight : IFigureMoving
{
    public FiguresColor Color { get; }
    public Possition Poss { get; set; }
    public readonly char Figure = (char)FiguresSymbol.N;
    public Knight(Possition poss, FiguresColor color)
    {
        Color = color;
        Poss = poss;
    }

    public bool FigureMooving(Possition poss)
    {
        if (((Math.Abs(Poss.X - poss.X) == 1 && Math.Abs(Poss.Y - poss.Y)/2 == 2) || (Math.Abs(Poss.X - poss.X) == 2 && Math.Abs(Poss.Y - poss.Y) / 2 == 1)))
        {
            return true;
        }
        else return false;
    }
}