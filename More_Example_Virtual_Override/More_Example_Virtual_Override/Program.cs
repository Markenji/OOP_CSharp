using More_Example_Virtual_Override;

class Program
{
    static void Main()
    {
        // Membuat objek karyawan tanpa bonus atau tunjangan
        Karyawan karyawanBiasa = new Karyawan { Nama = "John", GajiPokok = 5000000 };

        // Membuat objek karyawan dengan bonus
        KaryawanDenganBonus karyawanBonus = new KaryawanDenganBonus { Nama = "Alice", GajiPokok = 6000000, Bonus = 2000000 };

        // Membuat objek karyawan dengan tunjangan
        KaryawanDenganTunjangan karyawanTunjangan = new KaryawanDenganTunjangan { Nama = "Bob", GajiPokok = 7000000, Tunjangan = 1500000 };

        // Menampilkan gaji total untuk setiap karyawan
        Console.WriteLine($"Gaji total {karyawanBiasa.Nama}: {karyawanBiasa.HitungGajiTotal()}"); // Output: Gaji total John: 5000000
        Console.WriteLine($"Gaji total {karyawanBonus.Nama}: {karyawanBonus.HitungGajiTotal()}"); // Output: Gaji total Alice: 8000000
        Console.WriteLine($"Gaji total {karyawanTunjangan.Nama}: {karyawanTunjangan.HitungGajiTotal()}"); // Output: Gaji total Bob: 8500000
    }
}