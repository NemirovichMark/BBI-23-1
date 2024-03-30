using System;

struct Athlete
{
    private string _lastName;
    private string _club;
    private double _firstAttempt;
    private double _secondAttempt;
    private bool _disqualified;

    public string LastName => _lastName;
    public string Club => _club;
    public double FirstAttempt => _firstAttempt;
    public double SecondAttempt => _secondAttempt;
    public double TotalDistance => _firstAttempt + _secondAttempt;
    public bool Disqualified => _disqualified;

    public void Disqualify()
    {
        _disqualified = true;
    }

    public Athlete(string lastName, string club, double firstAttempt, double secondAttempt)
    {
        _lastName = lastName;
        _club = club;
        _firstAttempt = firstAttempt;
        _secondAttempt = secondAttempt;
        _disqualified = false;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Athlete[] sportik = new Athlete[5];

        sportik[0] = new Athlete("Иванов", "Снежок", 6.5, 7.2);
        sportik[1] = new Athlete("Губеев", "Баскет", 7.1, 7.5);
        sportik[2] = new Athlete("Енукидзе", "ПВА", 6.3, 6.7);
        sportik[3] = new Athlete("Жуков", "РСКА", 6.6, 6.9);
        sportik[4] = new Athlete("Капелин", "Барса", 8.5, 7.0);

        sportik[2].Disqualify();

        Array.Sort(sportik, (x, y) => y.TotalDistance.CompareTo(x.TotalDistance));
        Console.WriteLine("| Место |   Фамилия   |  Клуб      |  Попытка 1  |  Попытка 2  |  Итоговый результат |");
        Console.WriteLine("|-------|-------------|------------|-------------|-------------|---------------------|");

        for (int i = 0; i < 5; i++)
        {
            if (!sportik[i].Disqualified)
            {
                Console.WriteLine($"|  {i + 1} |  {sportik[i].LastName,-11} |  {sportik[i].Club,-10} |  {sportik[i].FirstAttempt,-11} |  {sportik[i].SecondAttempt,-10} |  {sportik[i].TotalDistance,-18} |");
            }
        }
        Console.WriteLine();
    }

}