#region 1_1
/*
using System;
class JumpResult
{
    private string lastName;
    private string society;
    private double Result1;
    private double Result2;
    private double totalResult;
    private bool disqualified;

    public JumpResult(string lastName, string society, double Result1, double Result2)
    {
        this.lastName = lastName;
        this.society = society;
        this.Result1 = Result1;
        this.Result2 = Result2;
        this.totalResult = Result1 + Result2;
        this.disqualified = false;
    }

    public string LastName { get { return lastName; } }
    public string Society { get { return society; } }
    public double TotalResult { get { return totalResult; } }
    public bool Disqualified { get { return disqualified; } }

    public void Disqualify()
    {
        disqualified = true;
    }

    public override string ToString()
    {
        return string.Format("{0,-10} {1,11} {2,17} {3,14} {4,15}", lastName, society, Result1, Result2, totalResult);
    }
}

class JumpCompetition
{
    static void Main()
    {
        JumpResult[] results = new JumpResult[]
        {
            new JumpResult("Хрищанович", "МИСиС", 2, 1.9),
            new JumpResult("Щерба", "БГЭУ", 2, 1.8),
            new JumpResult("Джурабоев", "МЭИ", 2.1, 1.7),
            new JumpResult("Мисюк", "БГУ", 2.1, 1.9),
            new JumpResult("Васечкин", "МИРЭА", 2.0, 1.85)
        };

        results[2].Disqualify();

        Array.Sort(results, (x, y) => y.TotalResult.CompareTo(x.TotalResult));

        Console.WriteLine("{0,-15} {1,-15} {2,5} {3,15} {4,11}", "Фамилия", "Общество", "1-ая попытка", "2-ая попытка", "Итого");
        Console.WriteLine(new string('-', 60));

        foreach (var result in results)
        {
            if (!result.Disqualified)
            {
                Console.WriteLine(result);
            }
        }
    }
}
*/
#endregion
#region 2_1
/*
using System;

class Человек
{
    public string ФИО;
}

class Студент : Человек
{
    public int НомерСтудБилета { get; private set; }
    public double СреднийБалл { get; private set; }

    public Студент(string фио, int номерСтудБилета, double оценка1, double оценка2, double оценка3, double оценка4)
    {
        ФИО = фио;
        НомерСтудБилета = номерСтудБилета;
        СреднийБалл = (оценка1 + оценка2 + оценка3 + оценка4) / 4;
    }

    public void  Print()
    {
        Console.WriteLine($"ФИО: {ФИО}\t№ студ. билета: {НомерСтудБилета}\tСредний балл: {СреднийБалл}");
    }
}

class Program
{
    static void Main()
    {
        Студент[] студенты = new Студент[5];
        студенты[0] = new Студент("Аня", 1, 5, 5, 2, 5);
        студенты[1] = new Студент("Яна", 2, 5, 4, 5, 5);
        студенты[2] = new Студент("Полина", 3, 3, 2, 3, 4);
        студенты[3] = new Студент("Артем", 4, 4, 2, 5, 5);
        студенты[4] = new Студент("Сорбон", 5, 3, 5, 4, 3);

        for (int i = 0; i < студенты.Length; i++)
        {
            for (int j = 0; j < студенты.Length - 1; j++)
            {
                if (студенты[j].СреднийБалл < студенты[j + 1].СреднийБалл)
                {
                    (студенты[j], студенты[j + 1]) = (студенты[j + 1], студенты[j]);
                }
            }
        }

        Console.WriteLine();
        Console.WriteLine("Студенты:");
        for (int i = 0; i < студенты.Length; i++)
        {
            if (студенты[i].СреднийБалл >= 4)
            {
                студенты[i].Print();
            }
        }
    }
}
*/

#endregion
#region 3_5

class FootballTeam
{
    private string name;
    private int Scored;
    private int Failed;
    private int points;
    public FootballTeam(string name)
    {
        this.name = name;
        Scored = 0;
        Failed = 0;
        points = 0;
    }
    public string Name { get { return name; } set { name = value; } }
    public void Result(int scored, int conceded)
    {
        Scored += scored;
        Failed += conceded;
        if (scored > conceded) points += 3;
        else if (scored == conceded) points += 1;
    }
    public int Points { get { return points; } }
    public int Difference { get { return Scored - Failed; } }
    public static void Print(FootballTeam[] teams)
    {
        Console.WriteLine("  Place      Team         Gender      Points");
        for (int i = 0; i < teams.Length; i++)
        {
            Console.WriteLine("{0,5}     {1,-8}    {2, -3}       {3}", i + 1, teams[i].Name, teams[i] is MaleFootballTeam ?"Male Team":"Female Team", teams[i].Points);
        }
    }
}
class MaleFootballTeam : FootballTeam
{
    public MaleFootballTeam(string name) : base(name)
    {
    }
}

class FemaleFootballTeam : FootballTeam
{
    public FemaleFootballTeam(string name) : base(name)
    {
    }
}

class Program
{
    static void Main(string[] args)
    {
        FootballTeam[] teams = new FootballTeam[]
        {
            new MaleFootballTeam("Барселона"),
            new MaleFootballTeam("Реал Мадрид"),
            new MaleFootballTeam("Дерби Каунти"),
            new FemaleFootballTeam("ЦСКА"),
            new FemaleFootballTeam("Динамо"),
            new FemaleFootballTeam("Спартак")

        };
        Match(ref teams[0], ref teams[1]);
        Match(ref teams[0], ref teams[2]);
        Match(ref teams[1], ref teams[0]);
        Match(ref teams[1], ref teams[2]);

        Match(ref teams[3], ref teams[4]);
        Match(ref teams[3], ref teams[5]);
        Match(ref teams[4], ref teams[3]);
        Match(ref teams[4], ref teams[5]);

        Sort(teams); FootballTeam.Print(teams);
    }
    static void Match(ref FootballTeam team1, ref FootballTeam team2)
    {
        Random random = new Random();
        int scored = random.Next(0, 5);
        int conceded = random.Next(0, 5);
        team1.Result(scored, conceded);
        team2.Result(conceded, scored);
    }
    static void Sort(FootballTeam[] teams)
    {
        int n = teams.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (teams[j].Points < teams[j + 1].Points || (teams[j].Points == teams[j + 1].Points && teams[j].Difference < teams[j + 1].Difference))
                {
                    FootballTeam temp = teams[j];
                    teams[j] = teams[j + 1]; teams[j + 1] = temp;
                }
            }
        }
    }
}

#endregion
