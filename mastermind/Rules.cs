using System.Net;

namespace mastermind;

class Rules {

    /* Display rules*/
    public static void LoadRules()
    {
        Console.WriteLine("");
        Console.WriteLine("These are the rules.");
        Console.WriteLine("");
        Console.WriteLine("What would you like to do next?");
        Console.WriteLine("");
        Console.WriteLine("1. Main Menu");
        Console.WriteLine("2. Start Game");
        Console.WriteLine("");
        int userAnswer = GameStart.UserChoice();
        RulesMenuNavigation(userAnswer);
    }

    public static void RulesMenuNavigation(int menuOption) {
        if (menuOption == 1) {
            GameStart.HandleUserChoice();
        }
        else {
            Console.WriteLine("");
            Console.WriteLine("Please enter a valid menu optiion!");
            int menuOptions = GameStart.UserChoice();
            RulesMenuNavigation(menuOptions);
        }
    }
}