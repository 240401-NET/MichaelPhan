using System.ComponentModel.DataAnnotations;
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

        // Checks for funcions in GameMaintenance class:
        GameMaster.PlayGame();
    }
}
