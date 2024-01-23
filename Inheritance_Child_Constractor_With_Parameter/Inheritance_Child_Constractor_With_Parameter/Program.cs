//Inheritance Child Constractor 
//Child Constructor not Parameterless
class Program
{
    static void Main()
    {
        Cat cat = new Cat("Kuning",8);
      

        Console.WriteLine(cat.warna);
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
    public Cat(string warna, int umur)
    {
        Console.WriteLine("Buat kucing");
        this.warna = warna;
        this.umur = umur;
    }

    public void Meow()
    {
        Console.WriteLine("Cat Meow meow");
    }
}


