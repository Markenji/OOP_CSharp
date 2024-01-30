using CARCAR;

class Program
{
    static void Main()
    {
        ElectricEngine ee = new ElectricEngine();
        HydroEngine hy = new HydroEngine();
        ee.Start();

        //    Car car = new Car(ee);
        //    car.EngineRun();

        //    Car car1 = new Car(hy);
        //    car1.EngineRun();
    }
}