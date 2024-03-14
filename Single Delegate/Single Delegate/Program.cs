public delegate void MyDelegate();

class Program
{
    static void Main()
    {
        MyDelegate mydel = Display;

        mydel();

        mydel.Invoke();

        mydel = Markenji;

        mydel();
    }

    static void Display()
    {
        Console.WriteLine("Helow");
    }

    static void Markenji()
    {
        Console.WriteLine("HOHO");
    }
}