using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        // Contoh reference type: string
        string string1 = "Hello";
        string string2 = string1;

        Console.WriteLine("Reference Type (string):");
        Console.WriteLine($"string1: {string1}, Address: {GetAddress(string1)}");
        Console.WriteLine($"string2: {string2}, Address: {GetAddress(string2)}");

        // Mengubah nilai melalui salah satu referensi tidak mempengaruhi objek yang sama di heap
        string2 = "World";

        Console.WriteLine("\nSetelah Mengubah Nilai:");
        Console.WriteLine($"string1: {string1}, Address: {GetAddress(string1)}");
        Console.WriteLine($"string2: {string2}, Address: {GetAddress(string2)}");

        // Membuat dua string yang sama (berisi "Hello") dengan alamat yang sama
        string string3 = "Hello";
        string string4 = "Hello";

        Console.WriteLine("\nDua String yang Sama:");
        Console.WriteLine($"string3: {string3}, Address: {GetAddress(string3)}");
        Console.WriteLine($"string4: {string4}, Address: {GetAddress(string4)}");

        // Membuat dua string yang berbeda dengan alamat yang berbeda
        string string5 = "Hello";
        string string6 = "World";

        Console.WriteLine("\nDua String yang Berbeda:");
        Console.WriteLine($"string5: {string5}, Address: {GetAddress(string5)}");
        Console.WriteLine($"string6: {string6}, Address: {GetAddress(string6)}");
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
