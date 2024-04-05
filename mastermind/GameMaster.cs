using System.Security.Principal;

namespace mastermind;

class GameMaster {

    public int maxTurns = 12;

    public static void PlayGame() 
    {
        string[] secretCode = ["O", "G", "Y", "G"];/*GameMaintenance.GenerateColorCode(GameMaintenance.colors);*/
        int currentTurn = 0;
        while (currentTurn < 2)
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
                foreach (string code in secretCode)
                {
                    codeString += $"{code}, ";
                }
                Console.WriteLine("The secrete code was: " + codeString);
                break;
            } 
            else if (win == false && currentTurn == 2)
            {
                string codeString = "";
                foreach (string code in secretCode)
                {
                    codeString += $"{code}, ";
                }
                Console.WriteLine("Unfortunately you have lost! The secret code was: " + codeString);
            }
        }
    }
}