using System;

class Program
{
    static void Main()
    {
        int a = 4;
        AddTwo(ref a);
        Console.WriteLine(a);
    }

    static void AddTwo(ref int a)
    {
        a = a + 2;
    }
}

class MyInt
{
    public int value;
}
