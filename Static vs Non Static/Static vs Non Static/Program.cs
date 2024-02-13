class Program
{
    static void Main()
    {
        Car car = new Car("Honda");
        car.EngineRun();


        Car.EngineCheck();
    }
}

class Car
{
    public string enginebrand;

    public Car(string brand)
    {
        enginebrand = brand;    
    }

    public void EngineRun()
    {
        Console.WriteLine("Nyalakan Mesin" + enginebrand);

        EngineCheck();
    }

    public static void EngineCheck()
    {
        Console.WriteLine("Cek Mesin Dong");
    }
}