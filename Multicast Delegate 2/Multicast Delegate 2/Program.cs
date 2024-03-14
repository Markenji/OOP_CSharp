using Multicast_Delegate_2;
public delegate void MyDelegate();
class Program
{
    static void Main()
    {
        MyDelegate mydel;

        Info info = new Info();

        mydel = info.Display;

        mydel.Invoke();

        mydel += info.Markenji;

        mydel();
    }
}