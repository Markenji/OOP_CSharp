public delegate void MyDelegate();

class Program
{
    static void Main()

    {
        MyDelegate mydel = Display;

        mydel += Markenji;

        mydel.Invoke();

        mydel -= Markenji;

        mydel();
    }

    static void Display()
    {
        Console.WriteLine("Helowww");
    }

    static void Markenji()
    {
        Console.WriteLine("Markenji");
    }
}