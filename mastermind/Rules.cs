using System.Net;

namespace mastermind;

class Rules {

    /* Display rules*/
    public static void LoadRules()
    {
        Console.WriteLine("");
        Console.WriteLine("These are the rules:");
        Console.WriteLine("");
        Console.WriteLine("You'll have 12 turns to guess the code. The code will be made up of four colors from the following list:" 
        + " Please enter your guess in the format of: 'C1 C2 C3 C4'--case insensitive."
        + " After each guess, the computer will provide feedback on how close your guess was to the code."
        + " A '+' sign means the color is in the code and in the correctposition. A '*' sign indicates the color is in the code but in the wrong position." 
        + " A '-' sign indicates the color is not in the code.");
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