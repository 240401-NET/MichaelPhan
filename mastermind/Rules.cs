namespace mastermind;

class Rules {

    /* Display rules*/
    public static void LoadRules()
    {
        Console.WriteLine("hello");
        Console.WriteLine("");
        Console.WriteLine("Would you like to start your game now? (y/n)");
        string userAnswer = Console.ReadLine()!;

        if (userAnswer == "y")
        {
            GameBoard.PrintBoard();
        } else {
            Console.WriteLine("");
            Console.WriteLine("Please choose one of the following options?");
            GameStart.PrintStartMenu();
            GameStart.HandleUserChoice(0);
        }
    }
}