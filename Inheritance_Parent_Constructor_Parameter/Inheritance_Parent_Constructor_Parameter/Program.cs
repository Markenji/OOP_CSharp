//Inheritance
//Parent Constructor Parameter
class Program
{
    static void Main()
    {
        Cat cat = new Cat();

        Console.WriteLine(cat.warna);
        Console.WriteLine(cat.umur+ " " + "bulan");

        cat.Eat();

    }
}

class Animal
{
    public string warna;
    public int umur;
    public Animal(string warna, int umur)
    {
        Console.WriteLine("Animal dibuat");
        this.warna = warna;
        this.umur = umur;

    }

    public void Eat()
    {
        Console.WriteLine("Animal Eat");
            
    }
}
class Cat : Animal 
{
    public Cat() : base("Putih", 2)
    {
        Console.WriteLine("Cat Dibuat");
    }

    public void Meow()
    {
        Console.WriteLine("MEOW MEOW MEOW");
    }
}
