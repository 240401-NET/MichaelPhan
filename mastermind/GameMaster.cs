namespace mastermind;

class GameMaster {

    public int maxTurns = 12;

    public static void PlayGame() 
    {
        string[] secretCode = GameMaintenance.GenerateColorCode(GameMaintenance.colors);
        int currentTurn = 0;
        while (currentTurn < 12)
        {
            string playerGuess = GameMaintenance.GetGuess();
            string[] playerGuessArray = GameMaintenance.ConvertGuessToArray(playerGuess);
            GameMaintenance.CheckIfGuessOnlyHasValidColors(playerGuessArray, GameMaintenance.colors);
            GameMaintenance.ValidGuess(playerGuessArray, GameMaintenance.colors);
            string[] compareCodeAndGuess = GameMaintenance.CompareGuessToSecretCode(playerGuessArray, secretCode);
            GameBoard.PrintBoard();
            GameBoard.UpdateBoard(playerGuessArray, compareCodeAndGuess, currentTurn);
            currentTurn +=1;
        }
    }
}