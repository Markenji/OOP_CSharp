using System;

class Program
{
    static void Main()
    {
        // Upcasting (Implicit)
        int a = 5;
        double b = a;
        Console.WriteLine($"Upcasting (Implicit): int ke double: {b}");

        // Downcasting (Explicit)
        double c = 3;
        int d = (int)c;
        Console.WriteLine($"DonwCating (Explicit): double ke int: {d}");

    }
}