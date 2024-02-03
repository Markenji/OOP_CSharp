using System;


class Program
{
    static void Main()
    {
        // Membuat objek dari kelas C
        C objC = new C();

        // Memanggil metode dari kelas C
        objC.MethodA();
        objC.MethodB();
    }
}


// Kelas abstrak A KAKEK
abstract class A
{
    // Metode abstrak yang harus diimplementasikan oleh kelas turunannya
    public abstract void MethodA();
}

// Kelas abstrak B yang mewarisi dari kelas A ORAN TUA
abstract class B : A 
{
    // Metode abstrak lain yang harus diimplementasikan oleh kelas turunannya
    public abstract void MethodB();
}

// Kelas C yang mewarisi dari kelas B ANAK ATAU CUCU
class C : B 
{
    // Implementasi metode abstrak dari kelas A
    public override void MethodA()
    {
        Console.WriteLine("Implementation of MethodA in class C");
    }

    // Implementasi metode abstrak dari kelas B
    public override void MethodB()
    {
        Console.WriteLine("Implementation of MethodB in class C");
    }
}

