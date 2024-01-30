using System;
using Method_Hiding;

class Program
{
    static void Main()
    {
        Animal animal = new Animal();
        animal.MakeSound();

        Cat cat = new Cat();
        cat.MakeSound();

        Dog dog = new Dog();    
        dog.MakeSound();

        Animal dogAnimal = new Dog();
        dogAnimal.MakeSound();
    }
}



