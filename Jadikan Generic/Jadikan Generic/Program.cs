using System;

class Program
{
    public static void Main()
    {
        // Membuat objek CustomCollection dan menambahkan nilai
        CustomCollection<int> custom = new CustomCollection<int>(20);
        custom.Add(0, 1);
        custom.Add(1, 2);

        int result = custom.GetValue(1);
        Console.WriteLine(result);

        CustomCollection<string> custom1 = new CustomCollection<string>(20);
        custom1.Add(2,"Markenji");

        string result1 = custom1.GetValue(2);
        Console.WriteLine(result1);


    }
}

// Kelas CustomCollection untuk menyimpan berbagai jenis data tanpa menggunakan generic
class CustomCollection<T>
{
    T[] myArray;

    public CustomCollection(int arraSize)
    {
        myArray = new T[arraSize];
    }

    public bool Add(int index, T x) 
    {
        if(index >= 0 && index < myArray.Length) 
        {
            myArray[index] = x;
            return true;
        }


        return false;
    }

    public T GetValue(int index) 
    {
        if (index >= 0 && index < myArray.Length)
        {
            return myArray[index];
        }

        throw new IndexOutOfRangeException("Index out of range");
    }
}
