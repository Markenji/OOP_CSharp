using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        // Contoh value type: int
        int a = 3;
        int b = a;

        //b = 5;

        Console.WriteLine("Value Type (int):");
        Console.WriteLine($"a: {a}, Address: {GetAddress(a)}");
        Console.WriteLine($"b: {b}, Address: {GetAddress(b)}");

        // Contoh value type: char
        char charA = 'A';
        char charB = charA;

        charB = 'B';

        Console.WriteLine("\nValue Type (char):");
        Console.WriteLine($"charA: {charA}, Address: {GetAddress(charA)}");
        Console.WriteLine($"charB: {charB}, Address: {GetAddress(charB)}");

        // Contoh value type: struct 
        Point pointA = new Point { X = 1, Y = 2 };
        Point pointB = pointA;

        pointB.X = 5;

        Console.WriteLine("\nValue Type (struct):");
        Console.WriteLine($"pointA: ({pointA.X}, {pointA.Y}), Address: {GetAddress(pointA)}");
        Console.WriteLine($"pointB: ({pointB.X}, {pointB.Y}), Address: {GetAddress(pointB)}");
    }

    // Contoh value type: struct
    struct Point
    {
        public int X;
        public int Y;
    }

    static IntPtr GetAddress<T>(T value) where T : struct
    {
        GCHandle handle = GCHandle.Alloc(value, GCHandleType.Pinned);
        try
        {
            return handle.AddrOfPinnedObject();
        }
        finally
        {
            handle.Free();
        }
    }
}
