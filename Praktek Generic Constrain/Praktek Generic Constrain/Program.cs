using System;

// Define a generic interface for arithmetic operations
public interface IArithmetic<T>
{
    T Add(T a, T b);
    T Subtract(T a, T b);
    T Multiply(T a, T b);
    T Divide(T a, T b);
}

// Define a concrete implementation of the interface for integer types
public class IntegerArithmetic : IArithmetic<int>
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public int Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }
        return a / b;
    }
}

// Generic calculator class constrained by IArithmetic<T>
public class Calculator<T> where T : struct
{
    private readonly IArithmetic<T> _arithmetic;

    public Calculator(IArithmetic<T> arithmetic)
    {
        _arithmetic = arithmetic;
    }

    public T Add(T a, T b)
    {
        return _arithmetic.Add(a, b);
    }

    public T Subtract(T a, T b)
    {
        return _arithmetic.Subtract(a, b);
    }

    public T Multiply(T a, T b)
    {
        return _arithmetic.Multiply(a, b);
    }

    public T Divide(T a, T b)
    {
        return _arithmetic.Divide(a, b);
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of IntegerArithmetic
        var integerArithmetic = new IntegerArithmetic();

        // Create a calculator for integers
        var intCalculator = new Calculator<int>(integerArithmetic);

        // Perform arithmetic operations
        int a = 10;
        int b = 5;

        Console.WriteLine($"Addition: {intCalculator.Add(a, b)}");
        Console.WriteLine($"Subtraction: {intCalculator.Subtract(a, b)}");
        Console.WriteLine($"Multiplication: {intCalculator.Multiply(a, b)}");
        Console.WriteLine($"Division: {intCalculator.Divide(a, b)}");
    }
}
