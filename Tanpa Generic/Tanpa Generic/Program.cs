class Program
{
    static void Main()
    {
        CustomCollecton custom = new CustomCollecton(20);
        custom.Add(0, "Markenji");
        custom.Add(1, 20);
        custom.Add(2, false);

        object result = custom.GetValue(0);
        string resultFromString = (string)result;
        Console.WriteLine(resultFromString);

        object result1 = custom.GetValue(1);
        int resultFromInt = (int)result1;
        Console.WriteLine(resultFromInt);
    }
}

class CustomCollecton
{
    object[] MyArray;

    public CustomCollecton(int arraySize)
    {
        MyArray = new object[arraySize];
    }

    public bool Add(int index, object x) 
    {
        MyArray[index] = x; 
        return true;
    }

    public object GetValue(int index) 
    {
        return MyArray[index];
    }
}

