public class Bishop : IFigureMoving
{
    public FiguresColor Color { get; }
    public Possition Poss { get; set; }
    public readonly char Figure = (char)FiguresSymbol.B;

    public Bishop(Possition poss, FiguresColor color)
    {
        Color = color;
        Poss = poss;
    }
    public bool FigureMooving(Possition poss)
    {
        if (Math.Abs(poss.X - Poss.X) == Math.Abs(poss.Y - Poss.Y))
        {
            return true;
        }
        else return false;
    }
}