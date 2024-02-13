using System;

class Program
{
    static void Main()
    {
        Car car = new Car("Sasaski");
        Console.WriteLine(car);
        string hasil = car.ToString();
        Console.WriteLine(hasil);
    }
}

class Car
{
    private string brand;

    public Car(string brand)
    {
        this.brand = brand;
    }

    public override string ToString()
    {
        return brand;
    }
}