class Program
{
    static void Main()
    {
        int x = 4;
        object obj = x;

        int result = (int)obj;
        Console.WriteLine(result);

        object obj1 = 5;
        double myDouble = (int)obj1;
        Console.WriteLine(myDouble);

        object obj2 = 6.0;
        int myInt = (int)(double)obj2;
        Console.WriteLine(myInt);
    }
}