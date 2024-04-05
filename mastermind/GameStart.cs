using System.Reflection.Metadata;

namespace mastermind;

class GameStart {

    public static int userMenuOption = 0;

    public static void AtGameBoot() 
    {
        Console.WriteLine("");
        Console.WriteLine("Welcome to MasterMind!");
    }

    public static void  PrintStartMenu() 
    {
        Console.WriteLine("");
        Console.WriteLine("Please chose one of the following options:");
        Console.WriteLine("");
        Console.WriteLine("1. Game");
        Console.WriteLine("2. Rules");
        Console.WriteLine("3. Leaderboards");
        Console.WriteLine("9. Exit");
        Console.WriteLine("");

    }

    public static int UserChoice() 
    {
        try {
            return Convert.ToInt32(Console.ReadLine());
        } catch (Exception e) {
            Console.WriteLine(e.Message);
            return -1;
        }
    }
    
    public static void HandleUserChoice() 
    {
        while (userMenuOption !=9)
        {

        PrintStartMenu();
        userMenuOption = UserChoice(); 
        
            switch(userMenuOption)
            {
                case 1:
                GameMaster.PlayGame();
                GameEnd.AskNewGame();
                break;

                case 2:
                Rules.LoadRules();
                break;

                case 3:
                Console.WriteLine("Leaderboard");
                break;

                case 9:
                Console.WriteLine("");
                Console.WriteLine("Goodbye! Thanks for playing!");
                break;

                default:
                Console.WriteLine("");
                Console.WriteLine("Please enter a valid menu optiion!");
                break;
            }
        }

    }
}