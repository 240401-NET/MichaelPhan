using System.Reflection;

namespace mastermind;

class LeaderBoard {
    public static void LoadLeaderboard() {
        Console.WriteLine(GameMaster.previousSolutions.Count + " solves");
        Console.WriteLine("Each solve:");
        Player.PrintDictionary(GameMaster.previousSolutions);
        Console.WriteLine("");
        Console.WriteLine("What would you like to do next?");
        Console.WriteLine("");
        Console.WriteLine("1. Main Menu");
        Console.WriteLine("2. New Game");
        Console.WriteLine("");
        int userAnswer = GameStart.UserChoice();
        LeaderBoardMenuNavigation(userAnswer);
    }

    public static void LeaderBoardMenuNavigation(int menuOption) 
    {
            switch (menuOption) {
                case 1:
                GameStart.HandleUserChoice();
                break;
        
                case 2:
                GameMaster.PlayGame();
                break;
                
                default:
                Console.WriteLine("");
                Console.WriteLine("Please enter a valid menu optiion!");
                int menuOptions = GameStart.UserChoice();
                LeaderBoardMenuNavigation(menuOptions);
                break;
            }
    }
}
