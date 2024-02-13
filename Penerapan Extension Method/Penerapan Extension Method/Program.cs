using System;
using Penerapan_Extension_Method;
public class Program
{
    public static void Main()
    {
        int angka1 = 5;
        int angka2 = 3;

        // Menggunakan Extensions Method untuk menambahkan fungsionalitas tambahan pada tipe data int
        int hasilPenambahan = angka1.Tambah(angka2);
        hasilPenambahan.Cetak(); // Menampilkan hasil penambahan

        string teks = "Hello, Extensions Method!";
        teks.Cetak(); // Menampilkan teks dengan menggunakan Extensions Method

        // Membuat objek Mobil
        Mobil mobil = new Mobil("Toyota", "Avanza", 2022);
        mobil.Cetak(); // Menampilkan informasi mobil dengan menggunakan Extensions Method
    }
}