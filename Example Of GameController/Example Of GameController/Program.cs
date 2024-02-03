
using Example_Of_GameController;

class Program
{
    static void Main()
    {
        IPlayer onlinePlayer = new OnlinePlayer(2, "Markenji");
        GameController controller = new GameController(onlinePlayer);
        controller.PlayerChecker();

        IPlayer offlinePlayer = new OfflinePlayer(3, "FullBaster");
        GameController controller1 = new GameController(offlinePlayer);
        controller1.PlayerChecker();
    }
}

