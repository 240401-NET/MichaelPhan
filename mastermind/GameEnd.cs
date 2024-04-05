using System.Collections;
using System.Net;

namespace mastermind;

class GameEnd {

    public static int response = 0;
    public static void AskNewGame() 
    {
        Console.WriteLine("Would you like you like to start a new game?");
        Console.WriteLine("1. Yes");
        Console.WriteLine("2. No");
        Console.WriteLine("");
    }

    public static int GetUserAnswer() {

        try {
            return Convert.ToInt32(Console.ReadLine());
        } catch (Exception e)
        {
            Console.WriteLine(e.Message + "Invalid response");
            return -2;
        }
    }

    public static void AnswerToNewGameQuestion () 
    {
            AskNewGame();
            response = GetUserAnswer();
            {
                switch (response)
                {
                    case 1:
                    GameMaster.PlayGame();
                    break;

                    case 2:
                    break;
            
                    default:
                    Console.WriteLine("Please enter a valid menu optiion!");
                    break;
                }
        }
    }
}