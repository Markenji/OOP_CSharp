class Program
{
    static void Main()
    {
        Mobil mobil = new Mobil("Honda");
        ChangeBrand(in mobil);
        Console.WriteLine(mobil.brand);
        
        foreach(int num in mobil.myArray) 
        {
            Console.WriteLine(num);
        }
    }

    static void ChangeBrand(in Mobil mobil)
    {
        //mobil.brand = "zuzuki";
        mobil.myArray[0] = 4;
    }
}

class Mobil
{
    public readonly string brand;
    public readonly int[] myArray = [1, 3, 5];

    public Mobil(string b)
    {
        brand = b;
    }
}