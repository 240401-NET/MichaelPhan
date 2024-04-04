using System.Collections;

namespace mastermind;

class GameEnd {

    public static void AskNewGame() 
    {
        Console.WriteLine("Would you like you like to start a new game? (y/n)");
        Console.ReadLine();
    }

    public static string GetUserAnswer() {

        try {
            return Console.ReadLine()!;
        } catch (Exception e)
        {
            Console.WriteLine(e.Message + "Invalid response");
            return "-2";
        }
    }

    public static void AnswerToNewGameQuestion (string response) 
    {
        while (response != "n")

        // AskNewGame();
        // response = GetUserAnswer();

        {
            switch (response)
            {
                case "y":
                GameMaster.PlayGame();
                break;

                case "n":
                Console.WriteLine("Goodbye! Thanks for playing");
                break;
            
                default:
                Console.WriteLine("Please enter a valid menu optiion!");
                break;
            }
            
        }
    }
}