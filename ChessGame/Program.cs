
CreateСhessBoard();
GameMode();
static void GameMode()
{
    Console.WriteLine("Choose Game Mode` Game1 or Game2 or Game3 or Game4");
    string mode = Console.ReadLine();
    switch (mode.ToLower())
    {
        case "game1":
            Game1.PlayGame();
            break;
        case "game2":
            Game2.PlayGame();
            break;
        case "game3":
            Game3.PlayGame();
            break;
        case "game4":
            Game4.PlayGame();
            break;
        default:
            Console.WriteLine("Wrong Game Mode");
            break;
    }
}
static void CreateСhessBoard()
{
    Console.SetCursorPosition(0, 0);

    for (int i = 8; i > 0; i--)
    {
        Console.WriteLine(i);
    }
    Console.Write(" ");

    for (char symbol = 'A'; symbol <= 'H'; symbol++)
    {
        Console.Write(symbol + " ");


    }
    Console.SetCursorPosition(1, 0);
    int y = 1;
    for (int i = 8; i > 0; i--)
    {

        for (int j = 1; j < 9; j++)
        {

            if ((i + j) % 2 == 0)
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write(" ");
                Console.Write(" ");
            }
            else
            {

                Console.BackgroundColor = ConsoleColor.White;
                Console.Write(" ");
                Console.Write(" ");

            }
        }
        Console.SetCursorPosition(1, y);
        y++;

    }
    Console.BackgroundColor = ConsoleColor.Black;
    Console.WriteLine("");

}
