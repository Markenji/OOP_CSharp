using System;

class Program
{
    static void Main()
    {
        // Membuat objek dari kelas RumahMewah
        RumahMewah rm = new RumahMewah();

        // Membuat objek dari kelas RumahBiasa
        RumahBiasa rb = new RumahBiasa();

        // Membuat objek dari kelas RumahSederhana
        RumahSederhana rs = new RumahSederhana();

        // Menggunakan objek dari kelas RumahBiasa sebagai referensi kelas abstrak Rumah
        Rumah rumah = rs;

        // Memanggil metode BukaPintu pada objek rumah (RumahBiasa)
        rumah.BukaPintu();
    }
}

// Kelas abstrak yang merepresentasikan konsep rumah
abstract class Rumah
{
    // Variabel readonly
    public readonly int i;

    // Metode konkret untuk membuka jendela
    public void BukaJendela()
    {
        Console.WriteLine("Buka jendela");
    }

    // Metode virtual untuk membuka garasi
    public virtual void BukaGarasi()
    {
        Console.WriteLine("Keatas");
    }

    // Metode abstrak yang harus diimplementasikan oleh kelas turunan
    public abstract void BukaPintu();
}

// Kelas turunan yang mewarisi dari kelas Rumah
class RumahMewah : Rumah
{
    // Implementasi metode abstrak BukaPintu untuk rumah mewah
    public override void BukaPintu()
    {
        Console.WriteLine("Keastass");
    }
}

// Kelas turunan yang mewarisi dari kelas Rumah
class RumahBiasa : Rumah
{
    // Implementasi metode abstrak BukaPintu untuk rumah biasa
    public override void BukaPintu()
    {
        Console.WriteLine("Kedepan");
    }
}

// Kelas turunan yang mewarisi dari kelas Rumah
class RumahSederhana : Rumah
{
    // Implementasi metode abstrak BukaPintu untuk rumah sederhana
    public override void BukaPintu()
    {
        Console.WriteLine("Gorden");
    }
}
