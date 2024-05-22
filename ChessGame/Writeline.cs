public class Writeline
{
    public void WriteLinePoss(Possition possition, char Figure)
    {
        int X = possition.X;//8 - possition.X;
        int y = possition.Y;  // int X = 8 - Possition.X;
        //int y = Possition.Y * 2 - 128;
        char Letter = Figure;
        Console.SetCursorPosition(y, X);
        if (((y == 1 || y == 2 || y == 5 || y == 6 || y == 9 || y == 10 || y == 13 || y == 14)) && (X % 2 == 0))
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Letter);
        }
        else if (((y == 3 || y == 4 || y == 7 || y == 8 || y == 11 || y == 12 || y == 15 || y == 16)) && (X % 2 == 1))
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Letter);
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Letter);
        }
        Console.ResetColor();
        Console.SetCursorPosition(0, 12);

    }
    public void WriteLinePoss(Possition possition, char Figure, FiguresColor color)
    {
        int X = possition.X;//8 - possition.X;
        int y = possition.Y;   ///int X = 8 - possition.X;
        //int y = possition.Y * 2 - 128;
        char Letter = Figure;
        ConsoleColor color1;
        if (color == FiguresColor.W)
        {
            color1 = ConsoleColor.Red;
        }
        else color1 = ConsoleColor.Black;
        Console.SetCursorPosition(y, X);
        if (((y == 1 || y == 2 || y == 5 || y == 6 || y == 9 || y == 10 || y == 13 || y == 14)) && (X % 2 == 0))
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = color1;
            Console.WriteLine(Letter);
        }
        else if (((y == 3 || y == 4 || y == 7 || y == 8 || y == 11 || y == 12 || y == 15 || y == 16)) && (X % 2 == 1))
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = color1;
            Console.WriteLine(Letter);
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = color1;
            Console.WriteLine(Letter);
        }
        Console.ResetColor();
        Console.SetCursorPosition(0, 12);
    }
    public void WriteLinePoss1(int X, int Y, char Letter,ConsoleColor color)
    {
        
        int y = Y;
        Console.SetCursorPosition(y, X);
        if (((y == 1 || y == 2 || y == 5 || y == 6 || y == 9 || y == 10 || y == 13 || y == 14)) && (X % 2 == 0))
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = color;
            Console.WriteLine(Letter);
        }
        else if (((y == 3 || y == 4 || y == 7 || y == 8 || y == 11 || y == 12 || y == 15 || y == 16)) && (X % 2 == 1))
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = color;
            Console.WriteLine(Letter);
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor =color;
            Console.WriteLine(Letter);
        }
        Console.ResetColor();
    }
    public void WriteLinePoss(int X, int Y, char Letter)
    {
        X = 7 - X;
        int y = Y + Y + 2;
        Console.SetCursorPosition(y, X);
        if (((y == 1 || y == 2 || y == 5 || y == 6 || y == 9 || y == 10 || y == 13 || y == 14)) && (X % 2 == 0))
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Letter);
        }
        else if (((y == 3 || y == 4 || y == 7 || y == 8 || y == 11 || y == 12 || y == 15 || y == 16)) && (X % 2 == 1))
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Letter);
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Letter);
        }
        Console.ResetColor();
    }
    public  void WriteLinePoss(Possition possition, ConsoleColor color)
    {
       char Letter = '*';
       int  X = 8 - possition.X;
       int y = possition.Y;
       
        Console.SetCursorPosition(y, X);
        if (((y == 1 || y == 2 || y == 5 || y == 6 || y == 9 || y == 10 || y == 13 || y == 14)) && (X % 2 == 0))
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = color ;
            Console.WriteLine(Letter);
        }
        else if (((y == 3 || y == 4 || y == 7 || y == 8 || y == 11 || y == 12 || y == 15 || y == 16)) && (X % 2 == 1))
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = color;
            Console.WriteLine(Letter);
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = color;
            Console.WriteLine(Letter);
        }
       Console.ResetColor();
    }
}


