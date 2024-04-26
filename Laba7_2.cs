#region 2_1
/*
using System;
class Human
{
    public string? FIO;
}

class Student : Human
{
    private static int currentID = 1;
    public int IDnumber { get; private set; }
    public double Averagescore { get; private set; }

    public Student(string fio, double mark1, double mark2, double mark3, double mark4)
    {
        FIO = fio;
        IDnumber = currentID++;
        Averagescore = (mark1 + mark2 + mark3 + mark4) / 4;
    }

    public void Print()
    {
        Console.WriteLine($"ФИО: {FIO}\t№студ. билета: {IDnumber}\tСредний балл: {Averagescore}");
    }
}

class Program
{
    static void Main()
    {
        Student[] students = new Student[5];
        students[0] = new Student("Аня", 5, 5, 2, 5);
        students[1] = new Student("Яна", 5, 4, 5, 5);
        students[2] = new Student("Полина", 3, 2, 3, 4);
        students[3] = new Student("Артем", 4, 2, 5, 5);
        students[4] = new Student("Сорбон", 3, 5, 4, 3);

        Array.Sort(students, (x, y) => y.Averagescore.CompareTo(x.Averagescore));

        Console.WriteLine("Студенты:");
        foreach (var student in students)
        {
            if (student.Averagescore >= 4)
            {
                student.Print();
            }
        }
    }
}
*/
#endregion
#region 3_5

using System;
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
        Console.WriteLine(" Place   Team   Gender   Points");
        for (int i = 0; i < teams.Length; i++)
        {
            Console.WriteLine("{0,2} {1,10} {2,12} {3,3}", i + 1, teams[i].Name,  teams[i] is MaleFootballTeam ? "Male Team" : "Female Team",  teams[i].Points);
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

        PlayMatches(teams);
        Sort(teams);
        FootballTeam.Print(teams);
    }

    static void PlayMatches(FootballTeam[] teams)
    {
        for (int i = 0; i < teams.Length; i++)
        {
            for (int j = i + 1; j < teams.Length; j++)
            {
                Match(ref teams[i], ref teams[j]);
            }
        }
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
                if (teams[j].Points < teams[j + 1].Points ||  (teams[j].Points == teams[j + 1].Points && teams[j].Difference < teams[j + 1].Difference))
                {
                    FootballTeam temp = teams[j];
                    teams[j] = teams[j + 1];
                    teams[j + 1] = temp;
                }
            }
        }
    }
}

#endregion
