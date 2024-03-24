﻿#region 1.1 lab 7
/*

using System;

public class JumpResult
{
    public string LastName { get; }
    public string Society { get; }
    public double Result1 { get; private set; }
    public double Result2 { get; private set; }
    public double TotalResult { get; private set; }
    public bool IsDisqualified { get; private set; }

    public JumpResult(string lastName, string society, double result1, double result2)
    {
        LastName = lastName;
        Society = society;
        Result1 = result1;
        Result2 = result2;
        TotalResult = result1 + result2;
        IsDisqualified = false;
    }

    public void Disqualify()
    {
        IsDisqualified = true;
    }

    public override string ToString()
    {
        return string.Format("{0,-15} {1,-15} {2,10} {3,10} {4,10}", LastName, Society, Result1, Result2, TotalResult);
    }
}

class JumpCompetition
{
    static void Main()
    {
        JumpResult[] results = new JumpResult[]
        {
            new JumpResult("Чайкина", "МИСиС", 5.6, 6.2),
            new JumpResult("Чичинкова", "ВШЭ", 5.5, 6.0),
            new JumpResult("Лунин", "МГИМО", 5.8, 6.1),
            new JumpResult("Бычкова", "МГТУ", 5.7, 6.3),
            new JumpResult("Агапова", "МГУ", 5.9, 6.2)
        };

        results[2].Disqualify();

        Array.Sort(results, (x, y) =>
        {
            if (!x.IsDisqualified && !y.IsDisqualified)
            {
                return y.TotalResult.CompareTo(x.TotalResult); 
            }
            else if (x.IsDisqualified && !y.IsDisqualified)
            {
                return 1; 
            }
            else if (!x.IsDisqualified && y.IsDisqualified)
            {
                return -1; 
            }
            else
            {
                return 0; 
            }
        });

        Console.WriteLine("{0,-15} {1,-15} {2,10} {3,10} {4,10}", "Фамилия", "Общество", "1-ая попытка", "2-ая попытка", "Итого");
        Console.WriteLine(new string('-', 60));

        foreach (var result in results)
        {
            if (!result.IsDisqualified)
            {
                Console.WriteLine(result);
            }
        }
    }
}
*/


#region 2.7 lab 7
/*
 
using System;

class Program
{
    static void Main()
    {
        Sportsman[] players = new Sportsman[5];

        players[0] = new Sportsman("Чичинкова", 1, "12345");
        players[1] = new Sportsman("Бычкова", 0.5, "54321");
        players[2] = new Sportsman("Куулар", 0, "98765");
        players[3] = new Sportsman("Агапова", 1, "45678");
        players[4] = new Sportsman("Чайкина", 0.5, "67890");

        Array.Sort(players, (x, y) => y.Score.CompareTo(x.Score));

        Console.WriteLine("Турнирная таблица:");
        foreach (var player in players)
        {
            Console.WriteLine($"{player.FullName} ({player.Id}) - {player.Score} очка");
        }
    }
}

public class Human
{
    protected string _fullName;

    public Human(string fullName)
    {
        _fullName = fullName;
    }

    public string FullName { get { return _fullName; } }
}

public class Sportsman : Human
{
    private double _score;
    private string _id;

    public Sportsman(string fullName, double score, string id) : base(fullName)
    {
        _score = score;
        _id = id;
    }

    public double Score { get { return _score; } }
    public string Id { get { return _id; } }
}
*/


#region 3.4 lab 7
/*

using System;

public class Sportsman
{
    public string LastName { get; protected set; }
    public int FinishTime { get; protected set; }

    public Sportsman(string lastName, int finishTime)
    {
        LastName = lastName;
        FinishTime = finishTime;
    }
}

public class Skier : Sportsman
{
    public Skier(string lastName, int finishTime) : base(lastName, finishTime) { }
}

public class Skieress : Sportsman
{
    public Skieress(string lastName, int finishTime) : base(lastName, finishTime) { }
}

public class SkiRace
{
    private Sportsman[] skieressGroup1Results;
    private Sportsman[] skieressGroup2Results;
    private Sportsman[] skierGroup1Results;
    private Sportsman[] skierGroup2Results;

    public SkiRace()
    {
        skieressGroup1Results = new Sportsman[]
        {
            new Skieress("Чиченкова", 60),
            new Skieress("Агапова", 55),
            new Skieress("Чайкина", 58),
            new Skieress("Абраменкова", 57),
            new Skieress("Бычкова", 62)
        };

        skieressGroup2Results = new Sportsman[]
        {
            new Skieress("Куулар", 63),
            new Skieress("Лунина", 56),
            new Skieress("Щербакова", 59),
            new Skieress("Родина", 61),
            new Skieress("Лищенко", 58)
        };

        skierGroup1Results = new Sportsman[]
        {
            new Skier("Стоценко", 57),
            new Skier("Виноградов", 59),
            new Skier("Смирнов", 58),
            new Skier("Волков", 56),
            new Skier("Иванов", 61)
        };

        skierGroup2Results = new Sportsman[]
        {
            new Skier("Зайцев", 62),
            new Skier("Павлов", 63),
            new Skier("Козлов", 55),
            new Skier("Голубев", 58),
            new Skier("Горбунов", 60)
        };

        MergeAndPrintResults();
    }

    private void SortResults(ref Sportsman[] results)
    {
        Array.Sort(results, (r1, r2) => r1.FinishTime.CompareTo(r2.FinishTime));
    }

    private void PrintResults(Sportsman[] results, string groupName)
    {
        Console.WriteLine($"\nРезультаты для группы {groupName}:");
        Console.WriteLine("{0,-15} {1,-15} {2,-15}", "Фамилия", "Время", "Группа");

        int place = 1;
        foreach (var result in results)
        {
            Console.WriteLine("{0,-15} {1,-15} {2,-15}", result.LastName, result.FinishTime, result.GetType().Name + $" (место {place++})");
        }
    }

    private void MergeAndPrintResults()
    {
        SortResults(ref skieressGroup1Results);
        SortResults(ref skieressGroup2Results);
        SortResults(ref skierGroup1Results);
        SortResults(ref skierGroup2Results);

        PrintResults(skieressGroup1Results, "Лыжницы-1");
        PrintResults(skieressGroup2Results, "Лыжницы-2");
        PrintResults(skierGroup1Results, "Лыжники-1");
        PrintResults(skierGroup2Results, "Лыжники-2");

        Sportsman[] allResults = new Sportsman[skieressGroup1Results.Length + skieressGroup2Results.Length + skierGroup1Results.Length + skierGroup2Results.Length];
        Array.Copy(skieressGroup1Results, allResults, skieressGroup1Results.Length);
        Array.Copy(skieressGroup2Results, 0, allResults, skieressGroup1Results.Length, skieressGroup2Results.Length);
        Array.Copy(skierGroup1Results, 0, allResults, skieressGroup1Results.Length + skieressGroup2Results.Length, skierGroup1Results.Length);
        Array.Copy(skierGroup2Results, 0, allResults, skieressGroup1Results.Length + skieressGroup2Results.Length + skierGroup1Results.Length, skierGroup2Results.Length);
        SortResults(ref allResults);

        PrintResults(allResults, "Все участники");
    }
}

class Program
{
    static void Main()
    {
        SkiRace skiRace = new SkiRace();
    }
}
*/