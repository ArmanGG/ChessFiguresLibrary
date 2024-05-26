using System.Text;
using System;
using System.Net.NetworkInformation;
using System.Reflection.PortableExecutable;

public static class Game4
{
    public static void PlayGame()
    {
        ChessBoard board = new ChessBoard();
        Writeline writeline = new Writeline();
        int count = 0;
        int whiteKingCount = 0;
        int blackKingCount = 0;
        int whiteQueenCount = 0;
        int blackQueenCount = 0;
        int whiteRookCount = 0;
        int blackRookCount = 0;
        int whiteBishopCount = 0;
        int blackBishopCount = 0;
        int whiteKnightCount = 0;
        int blackKnightCount = 0;
        while (count < 4)
        {
            Console.SetCursorPosition(0, 9);
            Console.WriteLine("Insert Possition(A8,B4,C3....)                           ");
            Console.SetCursorPosition(0, 10);
            Console.WriteLine("Insert Figure(BK,WQ,BB,WN,WR...)");
            int poss = 9;
            Console.ResetColor();
            Console.SetCursorPosition(30, poss);
            Console.WriteLine("                  ");
            Console.SetCursorPosition(30, poss + 1);
            Console.WriteLine("                  ");
            Console.SetCursorPosition(30, poss);
            string s1 = Console.ReadLine().ToUpper();
            Console.SetCursorPosition(0, 11);
            Console.WriteLine("                                    ");
            Console.SetCursorPosition(30, poss + 1);
            string s3 = Console.ReadLine().ToUpper();
            var Check = new CheckInputValidation(s1, s3);
            bool IsValid = Check.Valid;
            if (IsValid == true)
            {
                Possition possition = new Possition(Check.x, Check.y);
                FiguresColor color = Check.color;
                if (board.CheckNewBoard(possition) == null)
                {
                    if (s3 == "WK" && whiteKingCount >= 1)
                    {
                        Console.SetCursorPosition(0, 11);
                        Console.WriteLine("Only one White King is allowed.");
                        continue;
                    }

                    if (s3 == "BK" && blackKingCount >= 1)
                    {
                        Console.SetCursorPosition(0, 11);
                        Console.WriteLine("Only one Black King is allowed.");
                        continue;
                    }
                    if (s3 == "WQ" && whiteQueenCount >= 1)
                    {
                        Console.SetCursorPosition(0, 11);
                        Console.WriteLine("Only one White Queen is allowed.");
                        continue;
                    }

                    if (s3 == "BQ" && blackQueenCount >= 1)
                    {
                        Console.SetCursorPosition(0, 11);
                        Console.WriteLine("Only one Black Queen is allowed.");
                        continue;
                    }
                    if (s3 == "WR" && whiteRookCount >= 2)
                    {
                        Console.SetCursorPosition(0, 11);
                        Console.WriteLine("Only two White Rook is allowed.");
                        continue;
                    }

                    if (s3 == "BR" && blackRookCount >= 2)
                    {
                        Console.SetCursorPosition(0, 11);
                        Console.WriteLine("Only two Black Rook is allowed.");
                        continue;
                    }
                    if (s3 == "WB" && whiteBishopCount >= 2)
                    {
                        Console.SetCursorPosition(0, 11);
                        Console.WriteLine("Only two White Bishop is allowed.");
                        continue;
                    }

                    if (s3 == "BB" && blackBishopCount >= 2)
                    {
                        Console.SetCursorPosition(0, 11);
                        Console.WriteLine("Only two Black Bishop is allowed.");
                        continue;
                    }
                    if (s3 == "WN" && whiteKnightCount >= 2)
                    {
                        Console.SetCursorPosition(0, 11);
                        Console.WriteLine("Only two White Knight is allowed.");
                        continue;
                    }

                    if (s3 == "BN" && blackKnightCount >= 2)
                    {
                        Console.SetCursorPosition(0, 11);
                        Console.WriteLine("Only two Black Knight is allowed.");
                        continue;
                    }
                }
                else
                {
                    Console.SetCursorPosition(0, 11);
                    Console.WriteLine("The position is already occupied. ");
                    continue;
                }
                count++;
                switch (s3[1])
                {
                    case 'K':

                        King king = new King(possition, color);
                        if (color == FiguresColor.W) whiteKingCount++;
                        if (color == FiguresColor.B) blackKingCount++;
                        board.WriteInNewBoard(possition, s3);
                        writeline.WriteLinePoss(possition, king.Figure, color);

                        break;
                    case 'Q':

                        Queen queen = new Queen(possition, color);
                        if (color == FiguresColor.W) whiteQueenCount++;
                        if (color == FiguresColor.B) blackQueenCount++;
                        board.WriteInNewBoard(possition, s3);
                        writeline.WriteLinePoss(possition, queen.Figure, color);


                        break;
                    case 'N':

                        Knight knight = new Knight(possition, color);
                        if (color == FiguresColor.W) whiteKnightCount++;
                        if (color == FiguresColor.B) blackKnightCount++;
                        board.WriteInNewBoard(possition, s3);
                        writeline.WriteLinePoss(possition, knight.Figure, color);

                        break;
                    case 'R':

                        Rook rook = new Rook(possition, color);
                        if (color == FiguresColor.W) whiteRookCount++;
                        if (color == FiguresColor.B) blackRookCount++;
                        board.WriteInNewBoard(possition, s3);
                        writeline.WriteLinePoss(possition, rook.Figure, color);


                        break;
                    case 'B':

                        Bishop bishop = new Bishop(possition, color);
                        if (color == FiguresColor.W) whiteBishopCount++;
                        if (color == FiguresColor.B) blackBishopCount++;
                        board.WriteInNewBoard(possition, s3);
                        writeline.WriteLinePoss(possition, bishop.Figure, color);

                        break;
                    default:
                        Console.SetCursorPosition(0, 13);
                        Console.WriteLine("Invalid figure type.");
                        count--;
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Try again.");
            }

        }
        GetPossibleMove getPossibleMove = new GetPossibleMove();
        getPossibleMove.GetPossMoves(board);
        Console.SetCursorPosition(0, 15);
        if (getPossibleMove.CheckShax(getPossibleMove.whiteFiguresMoves, getPossibleMove.blackKing))
        {
            if (getPossibleMove.blackFiguresMoves.Count == 0)
            {
                if (getPossibleMove.blackKingMoves.All(getPossibleMove.whiteFiguresMoves.Contains))
                {
                    Console.WriteLine("Mat Black King");

                }
                else
                    Console.WriteLine("SHAX Black King ");
            }
            else
                Console.WriteLine("SHAX Black King ");
        }else
        {
            if(getPossibleMove.blackFiguresMoves.Count == 0&& getPossibleMove.blackKingMoves.All(getPossibleMove.whiteFiguresMoves.Contains))
            {
                Console.WriteLine("Pat");
            }
        }
        if (getPossibleMove.CheckShax(getPossibleMove.blackFiguresMoves, getPossibleMove.whiteKing))
        {
            if (getPossibleMove.whiteFiguresMoves.Count == 0)
            {
                if (getPossibleMove.whiteKingMoves.All(getPossibleMove.blackFiguresMoves.Contains))
                {
                    Console.WriteLine("Mat White King");

                }
                else
                    Console.WriteLine("SHAX White King ");
            }
            else
                Console.WriteLine("SHAX White King ");
        }
        else
        {
            if (getPossibleMove.whiteFiguresMoves.Count == 0 && getPossibleMove.whiteKingMoves.All(getPossibleMove.blackFiguresMoves.Contains))
            {
                Console.WriteLine("Pat");
            }
        }


    }
}