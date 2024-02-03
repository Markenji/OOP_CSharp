using System;

// Contoh static class
public static class Utility
{
    // Metode statis tanpa perlu membuat objek Utility
    public static int Add(int a, int b)
    {
        return a + b;
    }

    // Properti statis
    public static string AppName { get; } = "MyStaticApp";

    // Metode lainnya
    public static void DisplayMessage(string message)
    {
        Console.WriteLine(message);
    }
}

class Program
{
    static void Main()
    {
        // Memanggil metode statis tanpa membuat objek Utility
        int result = Utility.Add(5, 10);
        Console.WriteLine("Result: " + result);

        // Mengakses properti statis
        Console.WriteLine("Application Name: " + Utility.AppName);

        // Memanggil metode lain dari static class
        Utility.DisplayMessage("Hello from static class!");
    }
}
