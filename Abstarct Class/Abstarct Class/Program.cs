using Abstarct_Class;
class Program
{
    static void Main()
    {
        Lingkaran lingkarang = new Lingkaran();
        lingkarang.Tampilkan();
        Console.WriteLine("Luas Linkaran:  " + lingkarang.HitungLuas());

        PersegiPanjang persegiPanjang = new PersegiPanjang();   
        persegiPanjang.Tampilkan();
        Console.WriteLine("Luas Lingkaran: " + persegiPanjang.HitungLuas());


    }
}