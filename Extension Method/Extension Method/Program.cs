class Program
{
    static void Main()
    {
        Car car = new Car();
        car.EngineRun();
        car.PrintNow();
    }
}

class Car
{
    public void EngineRun()
    {

        Console.WriteLine("Engine Sedang Berjalanan");
    }
}

public static class MyExtension
{
    public static void PrintNow(this object obj)
    {
        Console.WriteLine(DateTime.Now);
    }
}