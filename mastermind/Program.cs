using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace mastermind;

class Program
{
    static void Main(string[] args)
    {
        Player playerX = FilePersistence.LoadPlayer();
        GameMaster.previousSolutions = playerX.previousSolutions;
        GameMaster.OnGameStartUp();

        FilePersistence.PersistCharacter(GameMaster.GeneratePlayer(GameMaster.previousSolutions));
    }
}
