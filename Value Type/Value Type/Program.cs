using System;

class Program
{
    static void Main()
    {
        // Contoh value type: int
        int a = 3;
        int b = a;

        b = 5;

        Console.WriteLine("Value Type (int):");
        Console.WriteLine("a: " + a);
        Console.WriteLine("b: " + b);

        // Contoh value type: char
        char charA = 'A';
        char charB = charA;

        charB = 'B';

        Console.WriteLine("\nValue Type (char):");
        Console.WriteLine("charA: " + charA);
        Console.WriteLine("charB: " + charB);

        // Contoh value type: struct 
        Point pointA = new Point { X = 1, Y = 2 };
        Point pointB = pointA;

        pointB.X = 5;

        Console.WriteLine("\nValue Type (struct):");
        Console.WriteLine("pointA: (" + pointA.X + ", " + pointA.Y + ")");
        Console.WriteLine("pointB: (" + pointB.X + ", " + pointB.Y + ")");
    }

    // Contoh value type: struct
    struct Point
    {
        public int X;
        public int Y;
    }
}
