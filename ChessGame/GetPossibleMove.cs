using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;

public class GetPossibleMove
{

   public List<Possition> whiteKingMoves = new List<Possition>();
   public  List<Possition> blackKingMoves = new List<Possition>();
    List<Possition> whiteQueenMoves = new List<Possition>();
    List<Possition> blackQueenMoves = new List<Possition>();
    List<Possition> whiteRookMoves = new List<Possition>();
    List<Possition> blackRookMoves = new List<Possition>();
    List<Possition> whiteBishopMoves = new List<Possition>();
    List<Possition> blackBishopMoves = new List<Possition>();
    List<Possition> whiteKnightMoves = new List<Possition>();
    List<Possition> blackKnightMoves = new List<Possition>();

    public List<Possition> whiteFiguresMoves = new List<Possition>();
    public List<Possition> blackFiguresMoves = new List<Possition>();

    public Possition whiteKing = new Possition();
    public Possition blackKing = new Possition();

    bool WhiteKingShax = false;
    bool BlackKingShax = false;


    public void GetPossMoves(ChessBoard chessBoard)
    {
        for (int i = 0; i < 8; i++)
        {
            for (int j = 2; j < 17; j += 2)
            {
                var Position = new Possition(i, j);
                string s = chessBoard.CheckNewBoard(Position);

                if (s == "WK")
                {
                    whiteKing = Position;
                    whiteKingMoves = GetKingMoves(chessBoard, Position);
                    continue;
                }

                if (s == "BK")
                {
                    blackKing = Position;
                    blackKingMoves = GetKingMoves(chessBoard, Position);
                    continue;

                }
                if (s == "WQ")
                {
                    whiteQueenMoves = GetQueenMoves(chessBoard, Position);
                    whiteFiguresMoves.AddRange(whiteQueenMoves);
                    continue;

                }

                if (s == "BQ")
                {
                    blackQueenMoves = GetQueenMoves(chessBoard, Position);
                    blackFiguresMoves.AddRange(blackQueenMoves);
                    continue;

                }
                if (s == "WR")
                {

                    whiteRookMoves = GetRookMoves(chessBoard, Position);
                    whiteFiguresMoves.AddRange(whiteRookMoves);
                    continue;

                }

                if (s == "BR")
                {
                    blackRookMoves = GetRookMoves(chessBoard, Position);
                    blackFiguresMoves.AddRange(blackRookMoves);
                    continue;


                }
                if (s == "WB")
                {
                    whiteBishopMoves = GetBishopMoves(chessBoard, Position);
                    whiteFiguresMoves.AddRange(whiteBishopMoves);
                    continue;

                }

                if (s == "BB")
                {
                    blackBishopMoves = GetBishopMoves(chessBoard, Position);
                     blackFiguresMoves.AddRange(blackBishopMoves);
                    continue;

                }
                if (s == "WN")
                {
                    whiteKnightMoves = GetKnightMoves(chessBoard, Position);
                    whiteFiguresMoves.AddRange(whiteKnightMoves);
                    continue;

                }

                if (s == "BN")
                {
                    blackKnightMoves = GetKnightMoves(chessBoard, Position);
                    blackFiguresMoves.AddRange(blackKnightMoves);
                    continue;

                }
            }
        }
    }

    private List<Possition> GetQueenMoves(ChessBoard chessBoard, Possition pos)
    {
        var moves = GetRookMoves(chessBoard, pos);
        moves.AddRange(GetBishopMoves(chessBoard, pos));
        return moves;
    }

    private List<Possition> GetKingMoves(ChessBoard chessBoard, Possition pos)
    {
       var moves = new List<Possition>();
        for (int x = -1; x <= 1; x++)
        {
            for (int y = -2; y <= 2; y += 2)
            {
                if (x == 0 && y == 0)
                    continue;

                var newPos = new Possition(pos.X + x, pos.Y + y);
                if (newPos.IsValidPosition(newPos))
                {
                    moves.Add(newPos);
                }
            }
        }
        return moves;
    }

    private List<Possition> GetBishopMoves(ChessBoard chessBoard, Possition pos)
    {
        var moves = new List<Possition>();
        for (int x = -1; x <= 1; x += 2)
        {
            for (int y = -2; y <= 2; y += 4)
            {
                var newPos = pos;
                while (true)
                {
                    newPos = new Possition(newPos.X + x, newPos.Y + y);
                    if (!newPos.IsValidPosition(newPos))
                        break;
                    var result = CheckMove(chessBoard, newPos);
                    if (result)
                    {
                        moves.Add(newPos);
                    }
                    else if (!result)
                    {
                        moves.Add(newPos);
                        break;
                    }
                }
            }
        }
        return moves;
    }

    private List<Possition> GetKnightMoves(ChessBoard chessBoard, Possition pos)
    {
        var moves = new List<Possition>();
        int[] x = { -2, -1, 1, 2, 2, 1, -1, -2 };
        int[] y = { 2, 4, 4, 2, -2, -4, -4, -2 };

        for (int k = 0; k < 8; k++)
        {
            var newPos = new Possition(pos.X + x[k], pos.Y + y[k]);
            if (newPos.IsValidPosition(newPos))
            {
                moves.Add(newPos);
            }
        }
        return moves;
    }

    private List<Possition> GetRookMoves(ChessBoard chessBoard, Possition pos)
    {
        var moves = new List<Possition>();

        for (int x = -1; x <= 1; x += 2)
        {
            var newPos = pos;
            while (true)
            {
                newPos = new Possition(newPos.X + x, newPos.Y);
                if (!newPos.IsValidPosition(newPos))
                    break;
                var result = CheckMove(chessBoard, newPos);
                if (result)
                {
                    moves.Add(newPos);
                }
                else if (!result)
                {
                    moves.Add(newPos);
                    break;
                }
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
                var result = CheckMove(chessBoard, newPos);
                if (result)
                {
                    moves.Add(newPos);
                }
                else if (!result)
                {
                    moves.Add(newPos);
                    break;
                }
            }
        }

        return moves;
    }


    public bool CheckShax(List<Possition> poss, Possition possition)
    {
        foreach (var pos in poss)
        {
            if (pos.X == possition.X && pos.Y == possition.Y)
            {
                return true;

            }
        }
        return false;
    }
    private bool CheckMove(ChessBoard chessBoard, Possition pos)
    {
        string piece = chessBoard.CheckNewBoard(pos);
        if (piece == null)
        {
            return true;
        }
        else
        {

            return false;
        }

    }
}



 





