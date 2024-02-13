// Object
class Program
{
    static void Main()
    {
        // Mendefinisikan objek dengan tipe data yang berbeda
        object obja = 4.0f;
        object objb = 3.0f;

        // Memanggil metode Add dengan objek
        Tambah(obja, objb);
    }

    static void Tambah(object a, object b)
    {
        // Memeriksa tipe data menggunakan pattern matching
        if (a is int aInt && b is int bInt)
        {
            // Jika kedua objek adalah bilangan bulat, lakukan penambahan
            Console.WriteLine($"Penambahan Bilangan Bulat: {aInt + bInt}");
        }
        else if (a is float aFloat && b is float bFloat)
        {
            // Jika kedua objek adalah bilangan desimal, lakukan penambahan
            Console.WriteLine($"Penambahan Bilangan Desimal: {aFloat + bFloat}");
        }
        else if (a is string aString && b is string bString)
        {
            // Jika kedua objek adalah string, lakukan penggabungan
            Console.WriteLine($"Penggabungan String: {aString + bString}");
        }
        else
        {
            // Tangani tipe data yang tidak didukung
            Console.WriteLine("Tipe data tidak didukung untuk operasi penambahan atau penggabungan");
        }
    }
}
