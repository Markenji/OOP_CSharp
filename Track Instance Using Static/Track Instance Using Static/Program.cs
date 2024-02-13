class Program
{
    static void Main()
    {
        Car b = new Car();  
        Car c = new Car();
        Car d = new Car();

        Console.WriteLine(Car.Count);
    }
}

class Car
{
    public static int Count = 0;


    public Car()
    {
        Count++;
    }
}