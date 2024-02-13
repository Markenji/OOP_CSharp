using Properties_Interface;

class Program
{
    static void Main()
    {
        GameController controller = new GameController();

        controller.X();

        Console.WriteLine(controller.MyProp);
    }
}