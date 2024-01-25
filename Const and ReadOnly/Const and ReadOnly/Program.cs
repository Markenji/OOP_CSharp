//Const vs ReadOnly
class Program
{
    static void Main()
    {
        Calculator calc = new Calculator(10);
        
        Console.WriteLine(calc.g);
        Console.WriteLine(calc.Times(10)); 
    }
}
class Calculator
{
    public const float phi = 3.14f;
    public readonly int g;
    public Calculator(int x)
    {
        g = x;
    }

    public float Times(int x)
    {
        return phi * x;
    }
}