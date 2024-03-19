using System;
//variant 6 
struct SimpleDate
{
    private int day;
    private int month;
    private int year;
    private SimpleDate(int day, int month, int year)
    {
        this.day = day;
        this.month = month;
        this.year = year;
    }
    private bool VisYear()
    {
        return (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0));
    }
    private void DisplayDate()
    {
        Console.WriteLine($"{day:D2}.{month:D2}.{year:D4}");
    }
    public static void DisplayAllDates(SimpleDate[] dates)
    {
        Console.WriteLine(" Дата :  ");
        foreach (var date in dates)
        {
            date.DisplayDate();
        }
    }
    private static SimpleDate[] SortDates(SimpleDate[] dates)
    {
        for (int i = 0; i < dates.Length - 1; i++)
        {
            for (int j = 0; j < dates.Length - 1 - i; j++)
            {
                if (dates[j].year > dates[j + 1].year ||
                    (dates[j].year == dates[j + 1].year && dates[j].month > dates[j + 1].month) ||
                    (dates[j].year == dates[j + 1].year && dates[j].month == dates[j + 1].month && dates[j].day > dates[j + 1].day))
                {
                    SimpleDate temp = dates[j];
                    dates[j] = dates[j + 1];
                    dates[j + 1] = temp;
                }
            }
        }
        return dates;
    }
    public static void Main()
    {
        SimpleDate[] dates = new SimpleDate[]
        {
            new SimpleDate(12, 3, 2001),
            new SimpleDate(1, 9, 1985),
            new SimpleDate(25, 12, 2010),
            new SimpleDate(5, 7, 1999),
            new SimpleDate(18, 2, 1978),
            new SimpleDate(30, 11, 1995),
            new SimpleDate(8, 4, 2008),
            new SimpleDate(21, 6, 1983),
            new SimpleDate(14, 10, 1972),
            new SimpleDate(3, 5, 2019)
        };
        dates = SortDates(dates);
        DisplayAllDates(dates);
    }
}