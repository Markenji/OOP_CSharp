using System;

class Program
{
    static void Main()
    {
        // Contoh reference type: class
        Person person1 = new Person("John", 25);
        Person person2 = person1; // Membuat salinan referensi, bukan salinan objek
        person2.Age = 30;
        Console.WriteLine("Reference Type (class):");
        Console.WriteLine($"person1: {person1.Name}, Age: {person1.Age}");
        Console.WriteLine($"person2: {person2.Name}, Age: {person2.Age}");

        // Mengubah nilai melalui salah satu referensi akan mempengaruhi objek yang sama di heap
        //person2.Age = 30;

        //Console.WriteLine("\nSetelah Mengubah Nilai:");
        //Console.WriteLine($"person1: {person1.Name}, Age: {person1.Age}");
        //Console.WriteLine($"person2: {person2.Name}, Age: {person2.Age}");
    }
}

// Contoh reference type: class
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}
