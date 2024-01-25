//Inheritance
//Parent Constructor overloading
class Program
{
    static void Main()
    {
        Cat cat = new Cat("red", 3);

        Console.WriteLine(cat.colour);
        
        Console.WriteLine(cat.age);
    }
}

class Animal
{
    public string colour;
    public int age;
    public Animal(string colour, int age) //Constructor
    {
        this.colour = colour;
        this.age = age;
        Console.WriteLine("Animal Created");
        
    }

    public Animal()
    {
        
    }
  
    public void Eat()
    {
        Console.WriteLine("Animal Eat");
    }
}
class Cat : Animal
{
    public Cat(string colour, int age) 
    {
        this.colour = colour;
        this.age = age;
        Console.WriteLine("Cat Created");
    }
    public void Meow()
    {
        Console.WriteLine("Meow...");
    }
}