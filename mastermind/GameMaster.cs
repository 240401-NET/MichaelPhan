using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;

namespace mastermind;

class GameMaster {

    // public static string[] secretCode {get; set;}
    // public static int currentTurn {get; set;}
    public static Dictionary<string, int> previousSolutions = new();


    public static void OnGameStartUp ()
    {
        GameStart.AtGameBoot();
        GameStart.HandleUserChoice();
    }

    public static Player GeneratePlayer(Dictionary<string, int> dict)
    {
        Player player = new();
        Console.WriteLine("What is the name?");
        player.previousSolutions = dict;
        player.name = Console.ReadLine();
        return player;
    }
    public static void PlayGame() 
    {
        string[] secretCode = 
        //["B", "O", "R", "R"];

        GameMaintenance.GenerateColorCode(GameMaintenance.colors);
        int currentTurn = 0;
        Console.WriteLine("");
        GameBoard.PrintBoard();
        while (currentTurn < 8)
        {
            string playerGuess = GameMaintenance.GetGuess();
            string[] playerGuessArray = GameMaintenance.ConvertGuessToArray(playerGuess);
            GameMaintenance.CheckIfGuessOnlyHasValidColors(playerGuessArray, GameMaintenance.colors);
            GameMaintenance.ValidGuess(playerGuessArray, GameMaintenance.colors);
            string[] compareCodeAndGuess = GameMaintenance.CompareGuessToSecretCode(playerGuessArray, secretCode);
            GameBoard.PrintBoard();
            GameBoard.UpdateBoard(playerGuessArray, compareCodeAndGuess, currentTurn);
            bool win = GameMaintenance.CheckForWin(compareCodeAndGuess);
            currentTurn += 1;
            if (win == true)
            {
                string codeString = "";
                Console.WriteLine("");
                Console.WriteLine("Congratulations! You won!");
                Console.WriteLine("");
                foreach (string code in secretCode)
                {
                    codeString += $"{code}, ";
                }
                Console.WriteLine("The secrete code was: " + codeString);
                Console.WriteLine("");
                string stringFormForSecretCode = string.Join(" ", secretCode);
                Player.GenerateSolvesList(stringFormForSecretCode, currentTurn, previousSolutions);
                break;
            } 
            else if (win == false && currentTurn == 8)
            {
                string codeString = "";
                Console.WriteLine("");
                foreach (string code in secretCode)
                {
                    codeString += $"{code}, ";
                }
                Console.WriteLine("Unfortunately you have lost! The secret code was: " + codeString);
                Console.WriteLine("");
            }
        }
        // Player newPlayer = new("michael", "zekkan", previousSolutions);
        // newPlayer.Printout();
        // newPlayer.PrintDictionary(previousSolutions);
        GameEnd.AnswerToNewGameQuestion();
    }
}