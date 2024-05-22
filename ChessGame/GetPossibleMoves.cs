public class GetPossibleMoves
{
    Writeline writeline = new Writeline();
    public void GetPossMoves(ChessBoard chessBoard)
    {
        ConsoleColor color1 = ConsoleColor.Red;
        ConsoleColor color2 = ConsoleColor.DarkBlue;

        for (int i = 0; i < 8; i++)
        {
            for (int j = 2; j < 17; j += 2)
            {
                var Position = new Possition(i, j);
                char s = chessBoard.CheckBoard(Position);

                if (s == 'Q')
                {
                    GetQueenMoves(chessBoard, Position, color1, color2);
                }
                else if (s == 'K')
                {
                    GetKingMoves(chessBoard, Position, color1, color2);
                }
                else if (s == 'B')
                {
                    GetBishopMoves(chessBoard, Position, color1, color2);
                }
                else if (s == 'N')
                {
                    GetKnightMoves(chessBoard, Position, color1, color2);
                }
                else if (s == 'R')
                {
                    GetRookMoves(chessBoard, Position, color1, color2);
                }
            }
        }
    }

    private void GetQueenMoves(ChessBoard chessBoard, Possition pos, ConsoleColor color1, ConsoleColor color2)
    {
        GetRookMoves(chessBoard, pos, color1, color2);
        GetBishopMoves(chessBoard, pos, color1, color2);
    }

    private void GetKingMoves(ChessBoard chessBoard, Possition pos, ConsoleColor color1, ConsoleColor color2)
    {
        for (int x = -1; x <= 1; x++)
        {
            for (int y = -2; y <= 2; y += 2)
            {
                if (x == 0 && y == 0)
                    continue;

                var newPos = new Possition(pos.X + x, pos.Y + y);
                if (newPos.IsValidPosition(newPos))
                {
                    CheckAndWriteMove(chessBoard, newPos, color1, color2);
                }
            }
        }
    }

    private void GetBishopMoves(ChessBoard chessBoard, Possition pos, ConsoleColor color1, ConsoleColor color2)
    {
        for (int x = -1; x <= 1; x += 2)
        {
            for (int y = -2; y <=2; y += 4)
            {
                var newPos = pos;
                while (true)
                {
                    newPos = new Possition(newPos.X + x, newPos.Y + y);
                    if (!newPos.IsValidPosition(newPos))
                        break;
                    if (!CheckAndWriteMove(chessBoard, newPos, color1, color2))
                        break;
                }
            }
        }
    }

    private void GetKnightMoves(ChessBoard chessBoard, Possition pos, ConsoleColor color1, ConsoleColor color2)
    {
        int[] x = { -2, -1, 1, 2, 2, 1, -1, -2 };
        int[] y = { 2, 4, 4, 2, -2, -4, -4, -2 };

        for (int k = 0; k < 8; k++)
        {
            var newPos = new Possition(pos.X + x[k], pos.Y + y[k]);
            if (newPos.IsValidPosition(newPos))
            {
                CheckAndWriteMove(chessBoard, newPos, color1, color2);
            }
        }
    }

    private void GetRookMoves(ChessBoard chessBoard, Possition pos, ConsoleColor color1, ConsoleColor color2)
    {
        for (int x = -1; x <= 1; x += 2)
        {
            var newPos = pos;
            while (true)
            {
                newPos = new Possition(newPos.X + x, newPos.Y);
                if (!newPos.IsValidPosition(newPos))
                    break;
                if (!CheckAndWriteMove(chessBoard, newPos, color1, color2))
                    break;
            }
        }

        for (int y = -2; y <= 2; y += 2)
        {
            var newPos = pos;
            while (true)
            {
                newPos = new Possition(newPos.X, newPos.Y + y);
                if (!newPos.IsValidPosition(newPos))
                    break;
                if (!CheckAndWriteMove(chessBoard, newPos, color1, color2))
                    break;
            }
        }
    }

  

    private bool CheckAndWriteMove(ChessBoard chessBoard, Possition pos, ConsoleColor color1, ConsoleColor color2)
    {
        char piece = chessBoard.CheckBoard(pos);
        if (piece == 0)
        {
            writeline.WriteLinePoss1(pos.X, pos.Y, '*', color1);
            chessBoard.WriteInBoard(pos, '*');
            return true;
        }
        else if (piece == '*')
        {
            writeline.WriteLinePoss1(pos.X, pos.Y, '#', color2);
            return true;
        }
        return false;
    }
    
}






