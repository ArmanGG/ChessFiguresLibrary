public class King : IFigureMoving
{
    public FiguresColor Color { get; }
    public Possition Poss { get; set; }
    public readonly char Figure = (char)FiguresSymbol.K;
    public King(Possition poss, FiguresColor color)
    {
        Color = color;
        Poss = poss;
    }
    public bool FigureMooving(Possition poss) {
     
        if (((Math.Abs(poss.X - Poss.X) == 1 && Math.Abs(poss.Y - Poss.Y)/2 == 1) || (Math.Abs(poss.X - Poss.X) == 0 && Math.Abs(poss.Y - Poss.Y)/2 ==1) || (Math.Abs(poss.X - Poss.X) == 1 && Math.Abs(poss.Y - Poss.Y) / 2 == 0)))
        {       
                return true;
        }
        return false;   
    }
}