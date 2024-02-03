using System;

class Program
{
    static void Main()
    {
        MieAyam mieAyam1 = new MieAyam("Enak");
        MieAyam mieAyam2 = new MieAyam("Biasa");
        MieAyam mieAyam3 = new MieAyam("Mantap");
        MieAyam mieAyam4 = new MieAyam("RA ENAK");
        MieAyam mieAyam5 = new MieAyam("MEDENI");
        MieAyam mieAyam6 = new MieAyam("MEDENI66");

        Console.WriteLine(mieAyam1.Nama);
        Console.WriteLine(mieAyam2.Nama);
        Console.WriteLine(mieAyam3.Nama);
        Console.WriteLine(mieAyam4.Nama);

        Console.WriteLine("Counter: " + MieAyam.Counter);
    }

    class MieAyam
    {
        public static int Counter;
        public string Nama;

        public MieAyam(string input)
        {
            Nama = input;
            Counter++;
        }
    }
}
