public delegate void MySubcriber(string message);

class Program
{
    static void Main()
    {
        Youtuber youtuber = new Youtuber();

        Subcriber1 subcriber1 = new Subcriber1();   
        Subcriber2 subcriber2 = new Subcriber2();   
        Tv tv = new Tv();

        youtuber.AddSubcriber(subcriber1.GetNotified);
        youtuber.AddSubcriber(subcriber2.GetNotified);
        youtuber.AddSubcriber(tv.GetInform);

        youtuber.RemoveSubcriber(subcriber1.GetNotified);

        Console.WriteLine(youtuber.ChechHistorySubcriber(subcriber1.GetNotified));

        youtuber.UploadVideo();
    }
}

class Youtuber
{
    private MySubcriber _mySubcriber;

    private HashSet<MySubcriber> _history = new HashSet<MySubcriber>(); 

    public void UploadVideo()
    {
        Console.WriteLine("Uploading Video ...");
        Console.WriteLine("Upload Selesai");
        SendNotification("Video Uploaded");
    }

    private void SendNotification(string message) 
    {
        _mySubcriber?.Invoke(message);  
    }

    public bool AddSubcriber(MySubcriber subcriber)
    {
        if(_mySubcriber == null) 
        {
        
        _mySubcriber = subcriber;
        
        _history.Add(subcriber);


        return true;
        
        }

        Delegate[] myDelegate = _mySubcriber.GetInvocationList();

        if(myDelegate.Contains(subcriber)) 
        {
            return false;
        }

        _history.Add(subcriber);
        _mySubcriber += subcriber;
        return true;
    }

    public bool ChechHistorySubcriber(MySubcriber subcriber)
    {  
        return _history.Contains(subcriber);
    }

    public bool RemoveSubcriber(MySubcriber subcriber) 
    {
        _mySubcriber -= subcriber;
        return true;
    }
}

class Subcriber1
{
    public void GetNotified(string message)
    {
        Console.WriteLine("Subcriber 1 : " + message);
    }
}

class Subcriber2
{
    public void GetNotified(string message)
    {
        Console.WriteLine("Subcriber 2 : " + message);
    }
}

class Tv
{
    public void GetInform(string message)
    {
        Console.WriteLine("Tv 1 : " + message);
    }
}