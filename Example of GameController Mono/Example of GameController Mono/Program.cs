class Program
{
    static void Main()
    {
        Tile[] tiles = new Tile[]
        {
            new Start(),
            new City(20, "Semarang", "Kota Semarang"),
            new City(24, "Jakarta", "Kota Jakarta"),
            new City(23, "Solo", "Kota Solo"),
            new Company(),
            new Jail()

        };

        GameController controller = new GameController(tiles);

        controller.CallTileAction(1);
        controller.CallTileAction(2);
        controller.CallTileAction(3);
        controller.CallTileAction(4);
        controller.CallTileAction(5);
    }
}

class GameController
{
    private Tile[] tiles;

    public GameController(Tile[] tiles)
    {
        this.tiles = tiles;
    }

    public void CallTileAction(int index)
    {
        if (index < 0 || index >= tiles.Length) 
        {
            Console.WriteLine("Index tidak valid ");
            return;
        }

        tiles[index].LakukanAksi();
    }
}

public abstract class Tile
{
    public readonly string Type;
    public readonly string Description;
    public readonly string Name;

    public Tile(string type, string name, string description)
    {
        Type = type;
        Description = description;
        Name = name;
    }

    public abstract void LakukanAksi();
}

class City : Tile
{
    private int _price;
    public City(int price, string name, string description) : base("city", name, description)
    {
        _price = price;
    }

    public override void LakukanAksi()
    {
        Console.WriteLine($"Membangun di {Name}");
    }
}

class Company : Tile
{
    public Company() : base ("company", "Company Tile", "Description for Company Tile")
    {
        
    }
    public override void LakukanAksi()
    {
        Console.WriteLine($"Membeli di {Name}");
    }
}

class Jail : Tile
{
    public Jail() : base("jail", "Jail Tile", "Description for Jail Tile")
    {

    }
    public override void LakukanAksi()
    {
        Console.WriteLine($"Melempar dadu di {Name}");
    }
}

class Start : Tile
{
    public Start() : base("start", "Start Tile", "Description for Start Tile")
    {

    }
    public override void LakukanAksi()
    {
        Console.WriteLine($"Tile Start di {Name}");
    }
}