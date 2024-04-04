namespace mastermind;

class Program
{
    static void Main(string[] args)
    {
        // string[] secretCode = GameMaintenance.GenerateColorCode(GameMaintenance.colors);
        // GameMaintenance.printSecretCode(secretCode);
        GameStart.AtGameBoot();

        // List<Player> playersList = new();
        // FilePersistence.LoadPreviousPlayers(playersList);;
        int userMenuOption = 0;
        GameStart.HandleUserChoice(userMenuOption);

        // List<Player> playersList = new();
    }
}
