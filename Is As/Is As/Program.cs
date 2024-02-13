using System;

class Program
{
    static void Main()
    {
        object a = "hello";

        string? resulta = a as string;
        Console.WriteLine(resulta);

        object b = true;

        if(b is bool)
        {
            bool resultb = (bool)b;
            Console.WriteLine(resultb);
        }

        Type type = b.GetType();
        Type type2 = typeof(Boolean);
        if(type == type2)
        {
            bool resultb = (bool)b;
            Console.WriteLine("Result b using GetType() and typeof(): "+ resultb);
        }
        
    }
}
