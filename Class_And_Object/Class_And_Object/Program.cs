using System;

class Program
{
    static void Main()
    {
        // Membuat objek dari class Mobil
        Mobil mobil = new Mobil();


        // Mengakses dan mengatur atribut
        String merek = (mobil.Merek = "Suzuki");
        mobil.Tahun_Produksi = 1990;
        Console.WriteLine(merek);


        // Memanggil metode
        mobil.Start();
        mobil.Stop();
        
    }
}

public class Mobil
{
    // Atribut (variabel)
    public string Merek;
    public int Tahun_Produksi;
    

    // Metode (fungsi)
    public void Start()
    {
        Console.WriteLine("Mobil menyala");
    }

    public void Stop()
    {
        Console.WriteLine("Mobil dimatikan");
    }

}