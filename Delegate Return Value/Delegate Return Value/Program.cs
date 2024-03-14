public delegate int MyDelegate(int a, int b);

class Program
{
    static void Main()
    {
        Calculator calculator = new Calculator();

        MyDelegate mydel = calculator.Add;

        mydel += calculator.Sub;

        Delegate[] delegatelist = mydel.GetInvocationList();


        int[] result = new int[delegatelist.Length];
        int count = 0;

        foreach (MyDelegate d in delegatelist)
        {
            result[count] = d.Invoke(11, 9);
            count++;
        }

        foreach (int i in result)
        {
            Console.WriteLine(i);
        }
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