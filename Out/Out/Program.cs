class Program
{
    static void Main()
    {
        int a;
        AddThree(out a);
        Console.WriteLine(a);
    }

    static void AddThree(out int x)
    {
        x = 3;
        x = x+4;
    }
}