using System;

class Program
{
    static void Main()
    {
        try
        {
            RecursiveMethod(1);
        }
        catch (StackOverflowException ex)
        {
            Console.WriteLine($"Terjadi {ex.GetType().Name}: {ex.Message}");
        }
    }

    static void RecursiveMethod(int counter)
    {
        Console.WriteLine($"Counter: {counter}");
        RecursiveMethod(counter + 1);
    }
}
