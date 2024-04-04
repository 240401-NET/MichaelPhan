namespace mastermind;

class GameEnd {

    public static void AskNewGame() 
    {
        Console.WriteLine("Would you like you like to start a new game? (y/n)");
        string newGame = Console.ReadLine();
        if (newGame == "y")
        {
            GameBoard.PrintBoard();
        }
        else 
        {
            Console.WriteLine("Goodbye! Thanks for playing");
        }


    }
}