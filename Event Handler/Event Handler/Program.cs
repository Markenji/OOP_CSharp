public delegate void EventHandler();

class MyClass
{
    static void Main()
    {
        Button button = new Button();

        EventHandlerClass eventHandler = new EventHandlerClass();

        button.Click += eventHandler.Button_Click;

        button.Onlick();
    }

    private static void Button_Click()
    {
        throw new NotImplementedException();
    }
}


public class Button
{
    public event EventHandler Click;

    public void Onlick()
    {
        if (Click != null)
        {  
            Click(); 
        
        }   
           
    }
}


public class EventHandlerClass
{
    public void Button_Click()
    {
        Console.WriteLine("Tombol Sudah Ditekan");
    } 
}