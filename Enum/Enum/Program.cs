// Enum
// List of Const

// Program entry point
class Program
{
    static void Main()
    {
        string month = MonthOfYear.January.ToString();

        int count = (int)MonthOfYear.March;

        Console.WriteLine("Month: "+ month);

        Console.WriteLine("Month Count: " + count);

        int x = 4;

        MonthOfYear result = (MonthOfYear)x;

        Console.WriteLine("Enum dari Nilai: " + result);


    }
}

// Enumerasi untuk bulan-bulan dalam setahun
public enum MonthOfYear
{
    January = 1,
    February,
    March,
    April,
    May,
    June,
    July,
    August,
    September,
    October,
    November,
    December
}
