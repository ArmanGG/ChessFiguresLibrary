public class Rook : IFigureMoving
{
    public FiguresColor Color { get; }
    public Possition Poss { get; set; }
    public readonly char Figure = (char)FiguresSymbol.R;
    public Rook(Possition poss, FiguresColor color)
    {
        Color = color;
        Poss = poss;
    }
    public bool FigureMooving(Possition poss)
    {
        if (((Math.Abs(poss.X - Poss.X) == 0 && Math.Abs(poss.Y - Poss.Y)/2 != 0)) || (Math.Abs(poss.X - Poss.X) != 0 && Math.Abs(poss.Y - Poss.Y)/2 == 0))
        {
            return true;
        }
        else return false;
    }
}