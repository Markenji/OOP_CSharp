using Overloading;

class Program
{
    static void Main()
    {
        Calculator calculator = new Calculator();

        Console.WriteLine(calculator.Add(9,8));
        Console.WriteLine(calculator.Add(9.4f, 8.8f));
    }
}