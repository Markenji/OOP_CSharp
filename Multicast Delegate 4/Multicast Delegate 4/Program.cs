public delegate int MyDelegate(int a , int b);

class Program
{
    static void Main()
    {
        Calculator calculator = new Calculator();

        MyDelegate mydel = calculator.Add;

        int myresult = mydel.Invoke(9,11);
        Console.WriteLine(myresult);

        mydel += calculator.Sub;

        int myresult1 = mydel.Invoke(13, 11);
        Console.WriteLine(myresult1);
    }
}

public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Sub(int a, int b) 
    {
        return a - b;
            
    }
}