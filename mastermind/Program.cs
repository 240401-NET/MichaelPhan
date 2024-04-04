using System.Security.Cryptography.X509Certificates;

namespace mastermind;

class Program
{
    static void Main(string[] args)
    {
        // string[] secretCode = GameMaintenance.GenerateColorCode(GameMaintenance.colors);
        // GameMaintenance.printSecretCode(secretCode);
        // GameStart.AtGameBoot();

        // List<Player> playersList = new();
        // FilePersistence.LoadPreviousPlayers(playersList);;
        // GameStart.HandleUserChoice();

        // List<Player> playersList = new();
        string playerGuess = GameMaintenance.GetGuess();
        string[] playerGuessArray = GameMaintenance.ConvertGuessToArray(playerGuess);
        GameMaintenance.CheckIfGuessOnlyHasValidColors(playerGuessArray, GameMaintenance.colors);
        GameMaintenance.ValidGuess(playerGuessArray, GameMaintenance.colors);
    }
}
