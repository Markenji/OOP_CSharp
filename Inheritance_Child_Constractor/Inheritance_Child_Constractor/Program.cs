//Inheritance Child Constractor 
//Child Constructor Parameterless
class Program
{
    static void Main()
    {
        Cat cat = new Cat();
        cat.Makan();
        cat.Meow();
        string Warna = cat.warna = "Putih";
        cat.umur = 12;

        Console.WriteLine(Warna);
        Console.WriteLine(cat.umur);
    }
}

class Animal
{
    public string warna;
    public int umur;
    public Animal() // Constructor
    {
        Console.WriteLine("Animal di buat");
    }

    public void Makan()
    {
        Console.WriteLine("Animal itu perlu makan");
    }
}
class Cat : Animal
{
    public Cat()
    {
        Console.WriteLine("Buat kucing");
    }

    public void Meow()
    {
        Console.WriteLine("Cat Meow meow");
    }
}


