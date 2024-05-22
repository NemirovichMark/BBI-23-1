using System;

abstract class Profession
{
    protected string pr;
    protected double opp;

    public abstract double sum();

    public void PrintInfo()
    {
        Console.WriteLine($"Профессия: {pr}");
        Console.WriteLine($"Надбавка за опасность: {opp}");
    }
}

class Fireman : Profession
{
    private double h;

    public Fireman(string pr, double opp, double h)
    {
        this.pr = pr;
        this.opp = opp;
        this.h = h;
    }

    public override double sum()
    {
        return opp + h;
    }
}

class Engineer : Profession
{
    private int kat;

    public Engineer(string pr, double opp, int kat)
    {
        this.pr = pr;
        this.opp = opp;
        this.kat = kat;
    }

    public override double sum()
    {
        return opp + kat * 1000;
    }
}

class Scientist : Profession
{
    private string yr;

    public Scientist(string pr, double opp, string yr)
    {
        this.pr = pr;
        this.opp = opp;
        this.yr = yr;
    }

    public override double sum()
    {
        return opp + yr 
    }
}

class Program
{
    static void Main()
    {
        Fireman[] f = new Fireman[]
        {
            new Fireman("Пожарный 1", 2000, 1000),
            new Fireman("Пожарный 2", 1800, 800),
            new Fireman("Пожарный 3", 2200, 1200),
            new Fireman("Пожарный 4", 2500, 1500),
            new Fireman("Пожарный 5", 1900, 900)
        };

        Engineer[] engineers = new Engineer[]
        {
            new Engineer("Инженер 1", 3000, 2),
            new Engineer("Инженер 2", 2800, 1),
            new Engineer("Инженер 3", 3200, 3),
            new Engineer("Инженер 4", 2700, 2),
            new Engineer("Инженер 5", 3100, 3)
        };

        Scientist[] scientists = new Scientist[]
        {
            new Scientist("Ученый 1", 4000 ),
            new Scientist("Ученый 2", 3800),
            new Scientist("Ученый 3", 4200),
            new Scientist("Ученый 4", 3700),
            new Scientist("Ученый 5", 4100)
        };

        Array.Sort(f, (x, y) => y.sum().CompareTo(x.sum()));
        Array.Sort(e, (x, y) => y.sum().CompareTo(x.sum()));
        Array.Sort(s, (x, y) => y.sum().CompareTo(x.sum()));

        Console.WriteLine("Пожарные:");
        foreach (var f in f)
        {
            f.PrintInfo();
            Console.WriteLine($"Зарплата: {f.sum()}\n");
        }

        Console.WriteLine("Инженеры:");
        foreach (var e in e)
        {
            e.PrintInfo();
            Console.WriteLine($"Зарплата: {e.sum()}\n");
        }

        Console.WriteLine("Ученые:");
        foreach (var s in s)
        {
            s.PrintInfo();
            Console.WriteLine($"Зарплата: {s.sum()}\n");
        }

        
    }
}