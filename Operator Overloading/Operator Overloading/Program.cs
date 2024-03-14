class Program
{
    static void Main()
    {
        Mobil mobila = new Mobil(2);
        Mobil mobilb = new Mobil(3);
        Mobil mobilc = new Mobil(4);
        Mobil mobild = new Mobil(5);


        Mobil hasil = mobila + mobilb + mobilc + mobild;
        Console.WriteLine("Total Harga " + hasil.harga);
    }

    public class Mobil
    {
        public int harga;

        public Mobil(int p = 0)
        {
            harga = p;
        }

        public static Mobil operator +(Mobil kiri, Mobil kanan) 
        {
            return new Mobil(kiri.harga + kanan.harga);  
        }
    }


}