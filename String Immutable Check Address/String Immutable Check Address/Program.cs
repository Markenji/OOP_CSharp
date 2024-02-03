using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        int a1 = 4;
        int b1 = a1;

        Console.WriteLine("Nilai a: " + a1 + ", Alamat a: " + GetAddress(a1));
        Console.WriteLine("Nilai b: " + b1 + ", Alamat b: " + GetAddress(b1));
        Console.WriteLine("\n");

        string a = "3";
        string b = a;

        Console.WriteLine("Nilai a: " + a + ", Alamat a: " + GetAddress(a));
        Console.WriteLine("Nilai b: " + b + ", Alamat b: " + GetAddress(b));

        b = "5";  // Memperbarui variabel b dengan nilai "5"

        Console.WriteLine("\nSetelah perubahan b:");
        Console.WriteLine("Nilai a: " + a + ", Alamat a: " + GetAddress(a));
        Console.WriteLine("Nilai b: " + b + ", Alamat b: " + GetAddress(b));
    }

    static IntPtr GetAddress(object obj)
    {
        GCHandle handle = GCHandle.Alloc(obj, GCHandleType.Pinned);
        try
        {
            return handle.AddrOfPinnedObject();
        }
        finally
        {
            handle.Free();
        }
    }
}
