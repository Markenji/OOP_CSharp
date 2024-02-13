using System;

class Program
{
    static void Main()
    {
        // Mendefinisikan objek dengan nilai
        object obja = 3;
        object objb = 2;

        // Memanggil metode Add untuk melakukan penambahan
        Add(obja, objb);
    }

    static void Add(object a, object b)
    {
        // Melakukan pattern matching untuk menentukan tipe objek dan melakukan penambahan sesuai tipe
        if (a is int inta && b is int intb)
        {
            Console.WriteLine($"Hasil penambahan integer: {inta + intb}");
        }
        else if (a is float floata && b is float floatb)
        {
            Console.WriteLine($"Hasil penambahan float: {floata + floatb}");
        }
        else if (a is string stringa && b is string stringb)
        {
            Console.WriteLine($"Hasil konkatenasi string: {stringa + stringb}");
        }
        else
        {
            Console.WriteLine("Tipe objek tidak didukung untuk penambahan.");
        }
    }
}
