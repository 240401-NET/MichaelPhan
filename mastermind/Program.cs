namespace mastermind;

class Program
{
    static void Main(string[] args)
    {
        GameStart.AtGameBoot();
        GameStart.PrintStartMenu();

        // List<Player> playersList = new();
        // FilePersistence.LoadPreviousPlayers(playersList);;
        int userMenuOption = 0;
        GameStart.HandleUserChoice(userMenuOption);

        List<Player> playersList = new();
    }
}
