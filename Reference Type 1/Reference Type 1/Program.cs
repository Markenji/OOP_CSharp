class Program
{
    static void Main()
    {
        MyInt myInt = new MyInt();
        myInt.value = 11;
        AddThree(myInt);
        Console.WriteLine(myInt.value);


    }

    static void AddThree(MyInt b) 
    {
        b.value = b.value + 3;
    }
}


class MyInt
{
    public int value;
}