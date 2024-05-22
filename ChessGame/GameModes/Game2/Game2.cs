using System.Drawing;

public static class Game2
{
    static object lockObj = new object();
    static bool Reached = false;
    static int minHops = 7;
    public static void PlayGame()
    {

        bool b = true;
        while (b == true)
        {
            Console.SetCursorPosition(30, 0);
            Console.WriteLine("                                                                      ");
            Console.SetCursorPosition(30, 1);
            Console.WriteLine("                                                                      ");
            Console.SetCursorPosition(30, 0);
            Console.WriteLine("Insert Possition(A8,B4,C3....)                             ");
            Console.SetCursorPosition(30, 1);
            Console.WriteLine("Insert NEXT Possition(A8,B4,C3....)");
            Console.SetCursorPosition(65, 0);
            String s1 = Console.ReadLine().ToUpper();
            Console.SetCursorPosition(65, 1);
            String s2 = Console.ReadLine().ToUpper();
            CheckInputValidation check1 = new CheckInputValidation(s1);
            CheckInputValidation check2 = new CheckInputValidation(s2);
            if (check1.Valid == true && check2.Valid == true)
            {
                int x1, y1, x2, y2;
                Possition StartPossition = new Possition(check1.x, check1.y);
                Possition EndPossition = new Possition(check2.x, check2.y);
                PossY myEnumValue1 = (PossY)Enum.Parse(typeof(PossY1), check1.y.ToString());
                y1 = (char)((int)myEnumValue1 - 63);
                y1 = y1 / 2;
                PossY myEnumValue2 = (PossY)Enum.Parse(typeof(PossY1), check2.y.ToString());
                y2 = (char)((int)myEnumValue2 - 63);
                y2 = y2 / 2;

                CanReach(check1.x - 1, y1 - 1, check2.x - 1, y2 - 1);
                b = false;
            }

            static void CanReach(int startX, int startY, int endX, int endY)
            {


                int hops = 0;
                while (!Reached)
                {
                    List<int[]> path = new List<int[]>();
                    path.Add(new int[] { startX, startY });
                    Thread[] threads = new Thread[8];

                    for (int i = 0; i < 8; i++)
                    {
                        int moveIndex = i;
                        threads[i] = new Thread(() => TryMove(startX, startY, endX, endY, hops, moveIndex, path));
                        threads[i].Start();
                    }

                    foreach (var thread in threads)
                    {
                        thread.Join();
                    }

                    hops++;
                }
            }

            static  void TryMove(int startX, int startY, int endX, int endY, int remainingHops, int moveIndex, List<int[]> path)
            {

                int[] x = { -2, -1, 1, 2, 2, 1, -1, -2 };
                int[] y = { 1, 2, 2, 1, -1, -2, -2, -1 };

                int newX = startX + x[moveIndex];
                int newY = startY + y[moveIndex];

                if (IsValid(newX, newY))
                {
                    List<int[]> newPath = new List<int[]>(path);
                    newPath.Add(new int[] { newX, newY });
                    lock (lockObj)
                    {
                        if (CanReachInNHops(newX, newY, endX, endY, remainingHops, newPath))
                        {


                            if (Reached || remainingHops < minHops)
                            {
                                Reached = true;
                                minHops = remainingHops;
                                Console.SetCursorPosition(0, 10);
                                Console.WriteLine($"Hops = {remainingHops+1} ");
                                char a = '0';
                                var writeline = new Writeline();
                                foreach (var move in newPath)
                                {
                                    writeline.WriteLinePoss(move[0], move[1], a);
                                    a++;
                                }
                                var lastMove = newPath[newPath.Count - 1];
                                writeline.WriteLinePoss(lastMove[0], lastMove[1], 'N');
                                Console.SetCursorPosition(0, 15);

                            }
                       }
                    }
                }
            }

            static bool IsValid(int x, int y)
            {
                return x >= 0 && x < 8 && y >= 0 && y < 8;
            }

            static bool CanReachInNHops(int startX, int startY, int endX, int endY, int remainingHops, List<int[]> path)
            {
                if (remainingHops == 0)
                {
                    return startX == endX && startY == endY;
                }

                int[] x = { -2, -1, 1, 2, 2, 1, -1, -2 };
                int[] y = { 1, 2, 2, 1, -1, -2, -2, -1 };

                for (int i = 0; i < 8; i++)
                {
                    int newX = startX + x[i];
                    int newY = startY + y[i];

                    if (IsValid(newX, newY))
                    {
                        path.Add(new int[] { newX, newY });

                        if (CanReachInNHops(newX, newY, endX, endY, remainingHops - 1, path))
                        {
                            return true;
                        }

                        path.RemoveAt(path.Count - 1);
                    }
                }
                return false;
            }
        }

    }
}