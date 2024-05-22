public static class Game1
{
    public static void PlayGame()
    {
        bool b = true;
        while (b)
        {
            Console.SetCursorPosition(0, 9);
            Console.WriteLine("Insert Possition(A8,B4,C3....)                    ");
            Console.SetCursorPosition(0, 10);
            Console.WriteLine("Insert Figure(WK,BQ,wB,bN,Wr)");
            int poss = 9;
            Console.ResetColor();
            Console.SetCursorPosition(30, poss);
            Console.WriteLine("                  ");
            Console.SetCursorPosition(30, poss + 1);
            Console.WriteLine("                  ");
            Console.SetCursorPosition(30, poss);
            string s1 = Console.ReadLine().ToUpper();
            Console.SetCursorPosition(0, 11);
            Console.WriteLine("                          ");
            Console.SetCursorPosition(30, poss + 1);
            string s3 = Console.ReadLine().ToUpper();
            CheckInputValidation check = new CheckInputValidation(s1, s3);
            if (check.Valid == true)
            {
                Writeline writeline = new Writeline();
                b = false;
                string a1;
                switch (s3[1])
                {
                    case 'K':
                        Possition KingPoss = new Possition(check.x, check.y);
                        FiguresColor KingColor = new FiguresColor();
                        KingColor = check.color;
                        King king = new King(KingPoss, KingColor);
                        writeline.WriteLinePoss(KingPoss, king.Figure, KingColor);
                        Console.SetCursorPosition(30, 0);
                        Console.Write("Insert NEXT Possition(A8,B4,C3....)");
                        a1 = Console.ReadLine().ToUpper();
                        var check1 = new CheckInputValidation(a1);
                        if (check1.Valid)
                        {
                            Possition nextPos = new Possition(check1.x, check1.y);
                            if (king.FigureMooving(nextPos))
                            {
                                writeline.WriteLinePoss(KingPoss, ' ', KingColor);
                                Thread.Sleep(1000);
                                writeline.WriteLinePoss(nextPos, king.Figure, KingColor);
                            }

                        }
                        else
                        {
                            Console.SetCursorPosition(0, 12);
                            Console.Write("Wrong Possition");
                        }
                        break;
                    case 'Q':
                        Possition QueenPoss = new Possition(check.x, check.y);
                        FiguresColor QueenColor = new FiguresColor();
                        QueenColor = check.color;
                        Queen queen = new Queen(QueenPoss, QueenColor);
                        writeline.WriteLinePoss(QueenPoss, queen.Figure, QueenColor);
                        Console.SetCursorPosition(30, 0);
                        Console.Write("Insert NEXT Possition(A8,B4,C3....)");
                        a1 = Console.ReadLine().ToUpper();
                        var check2 = new CheckInputValidation(a1);
                        if (check2.Valid)
                        {
                            Possition nextPos = new Possition(check2.x, check2.y);
                            if (queen.FigureMooving(nextPos))
                            {
                                writeline.WriteLinePoss(QueenPoss, ' ', QueenColor);
                                Thread.Sleep(1000);
                                writeline.WriteLinePoss(nextPos, queen.Figure, QueenColor);
                            }

                        }
                        else
                        {
                            Console.SetCursorPosition(0, 12);
                            Console.Write("Wrong Possition");
                        }
                        break;
                    case 'N':
                        Possition KnightPoss = new Possition(check.x, check.y);
                        FiguresColor KnightColor = new FiguresColor();
                        KnightColor = check.color;
                        Knight knight = new Knight(KnightPoss, KnightColor);
                        writeline.WriteLinePoss(KnightPoss, knight.Figure, KnightColor);
                        Console.SetCursorPosition(30, 0);
                        Console.Write("Insert NEXT Possition(A8,B4,C3....)");
                        a1 = Console.ReadLine().ToUpper();
                        var check3 = new CheckInputValidation(a1);
                        if (check3.Valid)
                        {
                            Possition nextPos = new Possition(check3.x, check3.y);
                            if (knight.FigureMooving(nextPos))
                            {
                                writeline.WriteLinePoss(KnightPoss, ' ', KnightColor);
                                Thread.Sleep(1000);
                                writeline.WriteLinePoss(nextPos, knight.Figure, KnightColor);
                            }

                        }
                        else
                        {
                            Console.SetCursorPosition(0, 12);
                            Console.Write("Wrong Possition");
                        }
                        break;
                    case 'B':
                        Possition BishopPoss = new Possition(check.x, check.y);
                        FiguresColor BishopColor = new FiguresColor();
                        BishopColor = check.color;
                        Bishop bishop = new Bishop(BishopPoss, BishopColor);
                        writeline.WriteLinePoss(BishopPoss, bishop.Figure, BishopColor);
                        Console.SetCursorPosition(30, 0);
                        Console.Write("Insert NEXT Possition(A8,B4,C3....)");
                        a1 = Console.ReadLine().ToUpper();
                        var check4 = new CheckInputValidation(a1);
                        if (check4.Valid)
                        {
                            Possition nextPos = new Possition(check4.x, check4.y);
                            if (bishop.FigureMooving(nextPos))
                            {
                                writeline.WriteLinePoss(BishopPoss, ' ', BishopColor);
                                Thread.Sleep(1000);
                                writeline.WriteLinePoss(nextPos, bishop.Figure, BishopColor);
                            }
                        }
                        else
                        {
                            Console.SetCursorPosition(0, 12);
                            Console.Write("Wrong Possition");
                        }
                        break;
                    case 'R':
                        Possition RookPoss = new Possition(check.x, check.y);
                        FiguresColor RookColor = new FiguresColor();
                        RookColor = check.color;
                        Rook rook = new Rook(RookPoss, RookColor);
                        writeline.WriteLinePoss(RookPoss, rook.Figure, RookColor);
                        Console.SetCursorPosition(30, 0);
                        Console.Write("Insert NEXT Possition(A8,B4,C3....)");
                        a1 = Console.ReadLine().ToUpper();
                        var check5 = new CheckInputValidation(a1);
                        if (check5.Valid)
                        {
                            Possition nextPos = new Possition(check5.x, check5.y);
                            if (rook.FigureMooving(nextPos))
                            {
                                writeline.WriteLinePoss(RookPoss, ' ', RookColor);
                                Thread.Sleep(1000);
                                writeline.WriteLinePoss(nextPos, rook.Figure, RookColor);
                            }
                        }
                        else
                        {
                            Console.SetCursorPosition(0, 12);
                            Console.Write("Wrong Possition");
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
