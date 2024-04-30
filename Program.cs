using System;

abstract class Runner
{
    protected string _surname;
    protected internal double _result;
    protected string _coach;
    protected int _group;

    public Runner(string surname, double result, string coach, int group)
    {
        _surname = surname;
        _result = result;
        _coach = coach;
        _group = group;
    }

    public abstract void DisplayInfo();

    
    public static void Qsort(FootballTeam[] a, int low, int high)
    {
        if (low < high)
        {
            int pi = Prtition(a, low, high);

            Qsort(a, low, pi - 1);
            Qsort(a, pi + 1, high);
        }
    }

    private static int Prtition(FootballTeam[] a, int low, int high)
    {
        int pivot = a[high].Ball;
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (a[j].Ball > pivot)
            {
                i++;
                FootballTeam temp = a[i];
                a[i] = a[j];
                a[j] = temp;
            }
        }

        FootballTeam temp2 = a[i + 1];
        a[i + 1] = a[high];
        a[high] = temp2;

        return i + 1;
    }
}

class FootballTeam
{
    public string ClubName { get; protected set; }
    public int Ball { get; protected set; }

    public FootballTeam(string clubName, int points)
    {
        ClubName = clubName;
        Ball = points;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"{ClubName} {this.GetType().Name}: {Ball} points");
    }
}

class WomenFootballTeam : FootballTeam
{
    public WomenFootballTeam(string clubName, int points) : base(clubName, points)
    {
    }
}

class MenFootballTeam : FootballTeam
{
    public MenFootballTeam(string clubName, int points) : base(clubName, points)
    {
    }
}

class Program
{
    static void Main()
    {
        FootballTeam[] womenClubs = new FootballTeam[]
        {
            new WomenFootballTeam("Spartak", 15),
            new WomenFootballTeam("Zenit", 12),
            new WomenFootballTeam("Loko", 18),
            new WomenFootballTeam("CSKA", 20),
            new WomenFootballTeam("Dynamo", 16),
            new WomenFootballTeam("Torpedo", 14)
        };

        FootballTeam[] menClubs = new FootballTeam[]
        {
            new MenFootballTeam("Anzhi", 22),
            new MenFootballTeam("Ural", 19),
            new MenFootballTeam("Rubin", 17),
            new MenFootballTeam("Arsenal", 21),
            new MenFootballTeam("Fakel", 16),
            new MenFootballTeam("Krasnodar", 18)
        };

        FootballTeam[] combClubs = new FootballTeam[12];
        int i = 0;

        foreach (FootballTeam club in womenClubs)
        {
            combClubs[i] = club;
            i++;
        }

        foreach (FootballTeam club in menClubs)
        {
            combClubs[i] = club;
            i++;
        }

        Console.WriteLine("Top teams:");
        Runner.Qsort(combClubs, 0, combClubs.Length - 1);

        for (int j = 0; j < combClubs.Length; j++)
        {
            Console.WriteLine($"{j + 1}. ");
            combClubs[j].DisplayInfo();
        }
    }
}
