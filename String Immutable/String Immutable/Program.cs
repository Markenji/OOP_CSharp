using System;

class Program
{
    static void Main()
    {
        string a = "3";
        string b = a;

        // String bersifat immutable, yang berarti setelah string dibuat, nilainya tidak dapat diubah.
        // Oleh karena itu, perubahan nilai b tidak mempengaruhi nilai a.

        b = "5";  // Memperbarui variabel b dengan nilai "5"

        Console.WriteLine("Nilai a setelah perubahan b: " + a);
        Console.WriteLine("Nilai b setelah perubahan b: " + b);
    }
}
