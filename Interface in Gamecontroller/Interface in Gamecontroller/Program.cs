using System;

// Interface IPlayer
public interface IPlayer
{
    string GetName();
    int GetId();
}

// Kelas GameController yang menggunakan interface IPlayer
class GameController
{
    public IPlayer player;

    // Konstruktor menerima objek yang mengimplementasikan IPlayer
    public GameController(IPlayer p)
    {
        player = p;
    }
}

// Kelas Player yang mengimplementasikan IPlayer
class Player : IPlayer
{
    private int _id;
    private string _name;

    // Konstruktor dengan nama dan ID acak
    public Player()
    {
        _id = GenerateRandomId();
        _name = GenerateRandomName();
    }

    public int GetId()
    {
        return _id;
    }

    public string GetName()
    {
        return _name;
    }

    // Metode untuk menghasilkan nama acak
    private string GenerateRandomName()
    {
        // Implementasi logika untuk menghasilkan nama acak
        return "Player_" + Guid.NewGuid().ToString().Substring(0, 5);
    }

    // Metode untuk menghasilkan ID acak
    private int GenerateRandomId()
    {
        // Implementasi logika untuk menghasilkan ID acak
        return new Random().Next(1000, 9999);
    }
}

// Kelas MLPlayer yang mengimplementasikan IPlayer
class MLPlayer : IPlayer
{
    private int _id;
    private string _name;
    private string _username;
    private int _level;

    public MLPlayer()
    {
        _id = GenerateRandomId();
        _name = GenerateRandomName();
    }

    public bool ConnectToServer()
    {
        return true;
    }

    public int GetId()
    {
        return _id;
    }

    public string GetName()
    {
        return _name;
    }

    private string GenerateRandomName()
    {
        return "MLPlayer_" + Guid.NewGuid().ToString().Substring(0, 5);
    }

    private int GenerateRandomId()
    {
        return new Random().Next(1000, 9999);
    }
}

// Kelas CODPlayer yang mengimplementasikan IPlayer (ditambahkan untuk kelengkapan)
class CODPlayer : IPlayer
{
    private int _id;
    private string _name;
    private string _username;
    private int _level;

    public CODPlayer()
    {
        _id = GenerateRandomId();
        _name = GenerateRandomName();
    }

    public bool ConnectToServer()
    {
        return true;
    }

    public int GetId()
    {
        return _id;
    }

    public string GetName()
    {
        return _name;
    }

    private string GenerateRandomName()
    {
        return "CODPlayer_" + Guid.NewGuid().ToString().Substring(0, 5);
    }

    private int GenerateRandomId()
    {
        return new Random().Next(1000, 9999);
    }
}

// Kelas PBPlayer yang mengimplementasikan IPlayer
class PBPlayer : IPlayer
{
    private int _id;
    private string _name;
    private string _username;
    private int _level;

    public PBPlayer()
    {
        _id = GenerateRandomId();
        _name = GenerateRandomName();
    }

    public bool ConnectToServer()
    {
        return true;
    }

    public int GetId()
    {
        return _id;
    }

    public string GetName()
    {
        return _name;
    }

    private string GenerateRandomName()
    {
        return "PBPlayer_" + Guid.NewGuid().ToString().Substring(0, 5);
    }

    private int GenerateRandomId()
    {
        return new Random().Next(1000, 9999);
    }
}

// Kelas Program sebagai entry point
class Program
{
    static void Main()
    {
        // Membuat objek player
        Player player = new Player();

        // Membuat objek MLPlayer
        MLPlayer mlplayer = new MLPlayer();

        // Membuat objek PBPlayer
        PBPlayer pbplayer = new PBPlayer();

        // Membuat objek GameController dengan player dari PBPlayer
        GameController game = new GameController(pbplayer);

        // Menggunakan metode dari IPlayer pada objek GameController
        Console.WriteLine("Player Name: " + game.player.GetName());
        Console.WriteLine("Player ID: " + game.player.GetId());

        // Menggunakan metode dari IPlayer pada objek Player
        Console.WriteLine("Player Name: " + player.GetName());
        Console.WriteLine("Player ID: " + player.GetId());

        // Menggunakan metode dari IPlayer pada objek MLPlayer
        Console.WriteLine("MLPlayer Name: " + mlplayer.GetName());
        Console.WriteLine("MLPlayer ID: " + mlplayer.GetId());
    }
}
