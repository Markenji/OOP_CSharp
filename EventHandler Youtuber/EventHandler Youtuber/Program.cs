using Microsoft.VisualBasic;

public delegate void MySubcriber(string message);

class Program
{
    static void Main()
    {
        Youtuber youtuber = new Youtuber(); 
        

        Subcriber subcriber = new Subcriber();  
        Subcriber2 subcriber2 = new Subcriber2();   
        Tv tv = new Tv();

        youtuber.AddSubcriber(subcriber.GetNotified);
        youtuber.AddSubcriber(subcriber2.GetNotified);
        youtuber.AddSubcriber(tv.GetInform);

        youtuber.UploadVideo();
    }
}

class Youtuber
{
    private event MySubcriber mySubcriber;

    public void UploadVideo()
    {
        Console.WriteLine("Uploading Video.....");
        Console.WriteLine("Upload Selesai");
        SendNotification("Video Uploaded");
    }

    private void SendNotification(string message)
    {
        mySubcriber?.Invoke( message);
    }

    public void AddSubcriber(MySubcriber subcriber)
    {
        mySubcriber += subcriber;
    }

    public void RemoveSubcriber(MySubcriber subcriber)
    {
        mySubcriber -= subcriber;
    }
}

class Subcriber
{
    public void GetNotified(string message)
    {
        Console.WriteLine("Subcriber1 : " + message);
    }
}

class Subcriber2
{
    public void GetNotified(string message)
    {
        Console.WriteLine("Subcriber2 : " + message);
    }
}

class Tv
{
    public void GetInform(string message)
    {
        Console.WriteLine("Tv : " + message);
    }
}