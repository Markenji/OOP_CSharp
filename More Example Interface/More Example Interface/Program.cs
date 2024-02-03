using More_Example_Interface;

class Program
{
    static void Main()
    {
        Printer printer = new Printer();

        printer.Print();
        printer.Scan();
        printer.Fax();
    }
}