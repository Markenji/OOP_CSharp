using Interface;

class Program
{
    static void Main()
    {
        // Membuat objek smartphone
        Smartphone myPhone = new Smartphone();

        // Menggunakan metode dari kedua interface
        myPhone.Connect();
        myPhone.Play();
        myPhone.Pause();
        myPhone.Stop();
        myPhone.Disconnect();
    }
}