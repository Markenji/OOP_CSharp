class Program
{
    static void Main()
    {
        Mobil mobil = new Mobil("a", 4);
        mobil.EngineRun();
        //mobil.EngineUp();
    }
}

class Mobil 
{   // internal
    private string brand; // private

    private int tempX;

    public Mobil(string b, int x)
    {
        brand = b;
        tempX = x;
    }

    public void EngineRun()
    {
        int x = 4;
        EngineTest();
        EngineUp();

    }

    private void EngineTest()

    { // private
        Console.WriteLine($"Engine Testing {brand}");
      
    }

    private void EngineUp()
    {
        Console.WriteLine($"Engine Up {tempX}");
    }
}
