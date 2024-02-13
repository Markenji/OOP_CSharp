using System;
using Microsoft.CSharp.RuntimeBinder;

class Program
{
    static void Main()
    {
        
        dynamic a = 3;

     

        a = "hello";
        a = true;

        
        a.Running();

        try
        {
            
            a.Runninx();
        }
        catch (RuntimeBinderException ex)
        {
            
            Console.WriteLine($"Exception: {ex.Message}");
        }

        try
        {
            
            a.Meledak();
        }
        catch (RuntimeBinderException ex)
        {
            
            Console.WriteLine($"Exception: {ex.Message}");
        }
    }
}


public class Car
{
    public void Running()
    {
        Console.WriteLine("Car is running");
    }
}
