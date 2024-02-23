# region_1.1
/*
using System;

public class CompetitionResult
{
    public struct Participant
    {
        public string lastName;
        public string society;
        public double result1;
        public double result2;

        public Participant(string lastName, string society, double result1, double result2)
        {
            this.lastName = lastName;
            this.society = society;
            this.result1 = result1;
            this.result2 = result2;
        }
    }

    public void DisplayResults(Participant[] participants)
    {
        Array.Sort(participants, (x, y) => (x.result1 + x.result2).CompareTo(y.result1 + y.result2));

        Console.WriteLine("Results:");
        Console.WriteLine("-----------------------------------------------------------------------------");
        Console.WriteLine("|     Фамилия     |      Общество   |   Результаты первой и второй попыток  |");
        Console.WriteLine("-----------------------------------------------------------------------------");

        for (int i = 0; i < participants.Length; i++)
        {
            Console.WriteLine($"|    {participants[i].lastName,-12} |    {participants[i].society,-11} |   {participants[i].result1 + participants[i].result2,-14} |");
        }

        Console.WriteLine("-----------------------------------------------------------------------------");
    }

    static void Main(string[] args)
    {
        Participant[] participants = new Participant[]
        {
            new Participant("Чайкина", "МИСиС", 5.6, 6.2),
            new Participant("Чичинкова", "ВШЭ", 6.1, 5.8),
            new Participant("Лунин", "МГИМО", 5.9, 6.0),
            new Participant("Бычкова", "МГТУ", 5.7, 5.6),
            new Participant("Агапова", "МГУ", 6.2, 6.4)
        };

        CompetitionResult competition = new CompetitionResult();
        competition.DisplayResults(participants);
    }
}
*/

# region_2.7
/*
using System;
using System.Linq;

public class Player
{
    public string Name { get; }
    private double Score { get; set; }

    public Player(string name)
    {
        Name = name;
    }

    public void AddScore(double score)
    {
        Score += score;
    }

    public double GetScore()
    {
        return Score;
    }
}

public class Table
{
    private Player[] players;

    public Table()
    {
        players = new Player[]
        {
            new Player("Чичинкова"),
            new Player("Бычкова"),
            new Player("Куулар"),
            new Player("Агапова"),
            new Player("Чайкина")
        };
    }

    public void AddResult(string playerName, double score)
    {
        foreach (var player in players)
        {
            if (player.Name == playerName)
            {
                player.AddScore(score);
            }
        }
    }

    public void DisplayTable()
    {
        var sortedPlayers = players.OrderByDescending(p => p.GetScore());

        Console.WriteLine("Таблица результатов");
        foreach (var player in sortedPlayers)
        {
            Console.WriteLine($"{player.Name}: {player.GetScore()} points");
        }
    }
}

class Program
{
    static void Main()
    {
        Table table = new Table();

        table.AddResult("Чичинкова", 1);
        table.AddResult("Бычкова", 0.5);
        table.AddResult("Куулар", 0);
        table.AddResult("Агапова", 1);
        table.AddResult("Чайкина", 0.5);

        table.DisplayTable();
    }
}
*/

# region_3.4
/*
using System;
using System.Linq;

public struct Result
{
    public string LastName;
    public int FinishTime;

    public Result(string lastName, int finishTime)
    {
        LastName = lastName;
        FinishTime = finishTime;
    }
}

public class SkiRace
{
    private Result[] group1Results;
    private Result[] group2Results;

    public SkiRace()
    {
        group1Results = new Result[]
        {
            new Result("Чиченкова", 60),
            new Result("Агапова", 55),
            new Result("Чайкина", 58),
            new Result("Абраменкова", 57),
            new Result("Бычкова", 62)
        };

        group2Results = new Result[]
        {
            new Result("Куулар", 63),
            new Result("Лунин", 56),
            new Result("Щербаков", 59),
            new Result("Родина", 61),
            new Result("Лищенко", 58)
        };
    }

    private Result[] SortResults(Result[] results)
    {
        return results.OrderBy(r => r.FinishTime).ToArray();
    }

    public void MergeAndPrintResults()
    {
        Result[] mergedResults = group1Results.Concat(group2Results).ToArray();
        mergedResults = SortResults(mergedResults);
        
        Console.WriteLine("Результаты соревнований");
        Console.WriteLine("{0,-15} {1,-15} {2,-15}", "Фамилия", "Время", "Группа");
        foreach (var result in mergedResults)
        {
            string group = Array.IndexOf(group1Results, result) != -1 ? "1" : "2";
            Console.WriteLine("{0,-15} {1,-15} {2,-15}", result.LastName, result.FinishTime, group);
        }
    }
}

class Program
{
    static void Main()
    {
        SkiRace skiRace = new SkiRace();
        skiRace.MergeAndPrintResults();
    }
}
*/
