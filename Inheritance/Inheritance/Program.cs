// Inheritance

using System;
using System.Threading.Channels;

class Program
{
    static void Main()
    {
        //Cat myCat = new Cat("Coki", "Kucing Persia");

        //myCat.Eat();

        //myCat.Moew();

        Animal animal = new Animal("Cokii");
        
    }
}

// Base Class
class Animal
{
    // Konstructor base class
    public Animal(string name)
    {
        Console.WriteLine($"Nama hewan ku adalah {name}");
    }

    public void Eat()
    {
        Console.WriteLine("hewan makan");
    }
    
}

// Derived Class
class Cat : Animal
{
    public Cat(string name, string peranakan) : base(name) 
    {
        Console.WriteLine($"Nama peliharaan {name} peranakan dari {peranakan}");
    }

    public void Moew()
    { 
        Console.WriteLine("Kucing itu meong meong");
    }
}