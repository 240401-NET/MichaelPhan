using System.Reflection.Metadata;

namespace mastermind;

class GameStart {


    public static void AtGameBoot() 
    {
        Console.WriteLine("");
        Console.WriteLine("Welcome to MasterMind!");
        Console.WriteLine("Please chose one of the following options:");
        Console.WriteLine("");
    }

    public static void  PrintStartMenu() 
    {
        Console.WriteLine("1. Game");
        Console.WriteLine("2. Rules");
        Console.WriteLine("3. Leaderboards");
        Console.WriteLine("4. Credits");
        Console.WriteLine("9. Exit");

    }

    public static int UserChoice() 
    {
        try {
            return Convert.ToInt32(Console.ReadLine());
        } catch (Exception e) {
            Console.WriteLine(e.Message + "Please enter a valid menu option!");
            return -1;
        }
    }

    public static void HandleUserChoice(int userMenuOption) 
    {
        while (userMenuOption != 9) 
        {
            userMenuOption = UserChoice(); 
            switch(userMenuOption)
            {
                case 1:
                Console.WriteLine("Welcome to the game: Please enter a name");
                break;

                case 2:
                Rules.LoadRules();
                break;

                case 3:
                LeaderBoard.LoadLeaderboard();
                break;
                
                case 4:
                Console.WriteLine("Colaborators:");
                Console.WriteLine("Michael Phan");
                break;

                case 9:
                Console.WriteLine("Goodbye! Thanks for playing!");
                break;

                default:
                Console.WriteLine("Please enter a valid menu optiion!");
                PrintStartMenu();
                break;
            }
            
        }
    }
}