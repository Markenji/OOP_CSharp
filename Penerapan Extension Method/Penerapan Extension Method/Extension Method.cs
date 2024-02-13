using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penerapan_Extension_Method
{
    public static class IniExtension
    {
        // Extensions Method untuk menambahkan dua angka
        public static int Tambah(this int a, int b)
        {
            return a + b;
        }

        // Extensions Method untuk mencetak objek ke konsol
        public static void Cetak(this object a)
        {
            Console.WriteLine(a);
        }

        // Extensions Method untuk mencetak informasi mobil ke konsol
        public static void Cetak(this Mobil mobil)
        {
            Console.WriteLine($"Mobil: {mobil.Merek}, Model: {mobil.Model}, Tahun: {mobil.Tahun}");
        }
    }
}
