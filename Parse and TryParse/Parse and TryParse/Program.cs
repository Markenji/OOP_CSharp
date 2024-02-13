class Program
{
    static void Main()
    {
        string a = "20";
        int result = int.Parse(a);
        Console.WriteLine(result);

        string b = "20";
        int value;
        bool status =  int.TryParse(b, out value);  
        Console.WriteLine(status);
        Console.WriteLine(value);
    }
}