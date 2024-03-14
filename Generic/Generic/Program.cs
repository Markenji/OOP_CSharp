class Program
{
    static void Main()
    {
        GenericClass<int> intGeneric = new GenericClass<int>();
        intGeneric.Print(10);


        GenericClass<string> stringGeneric = new GenericClass<string>();
        stringGeneric.Print("Subribe DOng");


    }
}

public class GenericClass<T>
{
    public void Print(T value) 
    { 
        Console.WriteLine("Value: " + value);
    }
}