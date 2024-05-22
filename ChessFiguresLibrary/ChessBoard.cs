public class ChessBoard
{
    private char[,] board = new char[8, 17];
    private string[,] newboard = new string[8, 17];

    public char CheckBoard(Possition pos)
    {
        return board[pos.X, pos.Y];
    }

    public void WriteInBoard(Possition pos, char value)
    {
        board[pos.X, pos.Y] = value;

    }
    public string CheckNewBoard(Possition pos)
    {
        return newboard[pos.X, pos.Y];
    }

    public void WriteInNewBoard(Possition pos, string value)
    {
        newboard[pos.X, pos.Y] = value;
    }
}

