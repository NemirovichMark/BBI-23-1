#region 2.7 lab 7

using System;

class Program
{
    static void Main()
    {
        Sportsman[] players = new Sportsman[5];

        players[0] = new Sportsman("Чичинкова", 1);
        players[1] = new Sportsman("Бычкова", 0.5);
        players[2] = new Sportsman("Куулар", 0);
        players[3] = new Sportsman("Агапова", 1);
        players[4] = new Sportsman("Чайкина", 0.5);

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
    private static int nextId = 1;
    private string _id;

    public Sportsman(string fullName, double score) : base(fullName)
    {
        _score = score;
        _id = "ID" + nextId;
        nextId++;
    }

    public double Score { get { return _score; } }
    public string Id { get { return _id; } }
}

