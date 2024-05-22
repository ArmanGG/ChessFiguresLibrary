public class Queen : IFigureMoving
{
    public FiguresColor Color { get; }
    public Possition Poss { get; set; }
    public readonly char Figure = (char)FiguresSymbol.Q; 

    public Queen(Possition poss, FiguresColor color)
    {
        Color = color;
        Poss = poss;
    }

    public bool FigureMooving(Possition poss)
    {
        if ((Math.Abs(poss.X - Poss.X) == 0 && Math.Abs(Poss.Y - poss.Y)/2 != 0) || (Math.Abs(poss.X - Poss.X) != 0 && Math.Abs(Poss.Y - poss.Y)/2 == 0))
        {

            return true;
        }
        else if ((Math.Abs(poss.X - Poss.X) == Math.Abs(Poss.Y - poss.Y) / 2))
        {

            return true;
        }
        else return false;

    } 
}