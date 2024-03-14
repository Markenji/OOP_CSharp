public delegate void MyDelegate(string a);

class Program
{
    static void Main()
    {
        MyDelegate helo;
        MyDelegate hai;


        info info = new info();

        helo = info.Displayer;
        hai = info.Markenji;

        helo.Invoke("Helo");
        hai.Invoke("hai");


        helo("Markenji ");
    }
}

class info
{
    public void Displayer(string notif)
    {
        Console.WriteLine("Displayer " + notif);
    }

    public void Markenji(string notif)
    {
        Console.WriteLine("Markenji " + notif);
    }
}