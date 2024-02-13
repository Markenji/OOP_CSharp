class Program
{
    static void Main()
    {
        GameController gameController = new GameController();
        Console.WriteLine(gameController.TotalPlayer2);
        gameController.SetTotalPlayer(100);
        Console.WriteLine(gameController.GetTotalPlayer());
    }
}

class GameController
{
    public readonly int TotalPlayer;


    private int _totalPlayer;

    public int GetTotalPlayer()
    {
        return _totalPlayer;
    }

    public bool SetTotalPlayer(int total)
    {
        if(total > 0) 
        {
        
        _totalPlayer = total;
        
        return true;}

        return false;
    }


    public int MyProperty { get; private set; }


    private int _totalPlayer2;

    public int TotalPlayerr
    {
        get
        {
            return _totalPlayer2 * 20;
        }

        set
        {
            if (value > 0)
            {
                _totalPlayer = value;
            }
        }
    }


    public int TotalPlayer2 { get; } = 10;
}