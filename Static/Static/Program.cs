﻿class Program
{
    static void Main()
    {
        
        
        Console.WriteLine(Calculator.Add(3,17));
    }
}

static class Calculator
{
    public static int Add(int x, int y)
    { 
        return x + y; 
    }

    public static int Sub(int x, int y)
    {
        return x - y;
    }

    public static int Div(int x, int y)
    {
        return x / y;
    }

    public static int Mul(int x, int y)
    {
        return x * y;
    }
}