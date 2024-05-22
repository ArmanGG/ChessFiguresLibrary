using System.Linq.Expressions;

public struct Possition
{
    public int X { get; }
    public int Y { get; }

    public Possition(int x, char y)
    {
        if (x < 1 || x > 8 || !Enum.IsDefined(typeof(PossY), (PossY)y))
        {
            throw new ArgumentException("Invalid arguments for Possition");
            
        }

        X = 8 - x; 
        Y = ((int)Enum.Parse(typeof(PossY), y.ToString()) - 65) * 2 + 2; 
    }

    public Possition(int x, int y)
    {
        if (x < 0 || x >= 8 || y < 2 || y > 16 || y % 2 != 0)
        {
            //throw new ArgumentException("Invalid arguments for Possition");
        }
        else
        {

            X = x;
            Y = y;
        }
    }

    public bool IsValidPosition(Possition pos)
    {
        return pos.X >= 0 && pos.X < 8 && pos.Y >= 2 && pos.Y <= 16;
    }
}
