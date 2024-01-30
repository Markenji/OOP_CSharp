using Overloading;

class Program
{
    static void Main()
    {
        Calculator calculator = new Calculator("Markenji Hello W");
        //Calculator calculator1 = new Calculator();



        Console.WriteLine(calculator.Hello());
        Console.WriteLine(calculator.Add(9, 8));
        Console.WriteLine(calculator.Add(9.4f, 8.8f));
        Console.WriteLine(calculator.Sub(9, 8));
        Console.WriteLine(calculator.Sub(9.4f, 8.8f));
    }
}