/*using System;

abstract class Runner
{
    protected string surname;
    protected string coachSurname;
    protected string group;
    protected double result;

    public string Surname => surname;
    public string CoachSurname => coachSurname;
    public string Group => group;
    public double Result => result;

    public Runner(string surname, string coachSurname, string group, double result)
    {
        this.surname = surname;
        this.coachSurname = coachSurname;
        this.group = group;
        this.result = result;
    }

    public abstract string Standard { get; }

    public virtual void PrintInfo()
    {
        Console.WriteLine("Фамилия: {0} \t Группа: {1} \t Тренер: {2} \t Результат: {3} \t Норматив: {4}",
            Surname, Group, CoachSurname, Result, Standard);
    }
}

class Runner100m : Runner
{
    public override string Standard => "1.5 секунды";

    public Runner100m(string surname, string coachSurname, string group, double result)
        : base(surname, coachSurname, group, result)
    {
    }
}

class Runner500m : Runner
{
    public override string Standard => "3 минуты";

    public Runner500m(string surname, string coachSurname, string group, double result)
        : base(surname, coachSurname, group, result)
    {
    }
}

class Program
{
    static void Main()
    {
        int passedCount100m = 0;
        int passedCount500m = 0;

        Runner[] runners = new Runner[5];
        runners[0] = new Runner100m("Губеева", "Тренеровна", "234", 1.50);
        runners[1] = new Runner100m("Капелина", "Гасанов", "666", 1.55);
        runners[2] = new Runner100m("Попова", "Кужель", "777", 1.47);
        runners[3] = new Runner100m("Орлова", "Лушина", "889", 1.46);
        runners[4] = new Runner100m("Коцарь", "Пушина", "995", 1.54);

        Array.Sort(runners, (x, y) => y.Result.CompareTo(x.Result));

        Console.WriteLine("Таблица результатов бега на 100 м:");
        for (int i = 0; i < runners.Length; i++)
        {
            var runner = runners[i] as Runner100m;
            if (runner != null)
            {
                if (runner.Result <= 1.5)
                {
                    passedCount100m++;
                }
                runner.PrintInfo();
            }
        }

        runners[0] = new Runner500m("Иванова", "Тренеровна", "234", 2.50);
        runners[1] = new Runner500m("Петрова", "Гасанов", "666", 3.05);
        runners[2] = new Runner500m("Сидорова", "Кужель", "777", 2.57);
        runners[3] = new Runner500m("Кузнецова", "Лушина", "889", 2.46);
        runners[4] = new Runner500m("Смирнова", "Пушина", "995", 3.04);

        Array.Sort(runners, (x, y) => y.Result.CompareTo(x.Result));

        Console.WriteLine("\nТаблица результатов бега на 500 м:");
        for (int i = 0; i < runners.Length; i++)
        {
            var runner = runners[i] as Runner500m;
            if (runner != null)
            {
                if (runner.Result <= 3.0)
                {
                    passedCount500m++;
                }
                runner.PrintInfo();
            }
        }

        Console.WriteLine("\nЛюди, сдавшие норматив на 100 м: " + passedCount100m);
        Console.WriteLine("Люди, сдавшие норматив на 500 м: " + passedCount500m);
    }
}*/


/*using System;

abstract class SportPlayer
{
    protected string surname;
    protected string name;
    protected int passedNorms;

    public string Surname => surname;
    public string Name => name;

    public abstract bool IsExcluded();
    public abstract void PrintInfo();

    public void IncrementPassedNorms()
    {
        passedNorms++;
    }
}

class HockeyPlayer : SportPlayer
{
    private int penaltyTime;

    public HockeyPlayer(string surname, string name, int penaltyTime)
    {
        this.surname = surname;
        this.name = name;
        this.penaltyTime = penaltyTime;
    }

    public void AddPenalty()
    {
        penaltyTime += 2; // Пример: за каждый штраф 2 минуты
    }

    public override bool IsExcluded()
    {
        return false; // В хоккее нет исключений
    }

    public override void PrintInfo()
    {
        Console.WriteLine("Хоккеист - Фамилия: {0} \t Имя: {1} \t Штрафное время: {2} мин \t Прошел нормативов: {3}", Surname, Name, penaltyTime, passedNorms);
    }
}

class BasketballPlayer : SportPlayer
{
    private int fouls;

    public BasketballPlayer(string surname, string name, int fouls)
    {
        this.surname = surname;
        this.name = name;
        this.fouls = fouls;
    }

    public void AddPenalty()
    {
        fouls++;
    }

    public override bool IsExcluded()
    {
        return fouls >= 4; // Игрок будет исключен, если у него 4 или более фолов
    }

    public override void PrintInfo()
    {
        Console.WriteLine("Баскетболист - Фамилия: {0} \t Имя: {1} \t Количество фолов: {2} \t Прошел нормативов: {3}", Surname, Name, fouls, passedNorms);
    }
}

class Program
{
    static void Main()
    {
        SportPlayer[] players = new SportPlayer[5];
        players[0] = new HockeyPlayer("Иванов", "Вася", 2);
        players[1] = new HockeyPlayer("Петров", "Петя", 3);
        players[2] = new BasketballPlayer("Сидоров", "Дима", 4);
        players[3] = new BasketballPlayer("Козлов", "Саша", 5);
        players[4] = new BasketballPlayer("Николаев", "Андрей", 3);

        foreach (var player in players)
        {
            player.IncrementPassedNorms();
            //player.AddPenalty(); // Убрали вызов метода AddPenalty
            if (!player.IsExcluded())
                player.PrintInfo();
        }
    }
}*/



using System;
using System.Linq;

abstract class FootballTeam
{
    protected string teamName;
    protected int points;

    public FootballTeam(string teamName, int points)
    {
        this.teamName = teamName;
        this.points = points;
    }

    public abstract string GetTeamType();

    public int Points => points;

    public override string ToString()
    {
        return $"{teamName} {GetTeamType()} {points} points";
    }
}

class WomenFootballTeam : FootballTeam
{
    public WomenFootballTeam(string teamName, int points) : base(teamName, points) { }

    public override string GetTeamType()
    {
        return "women's team";
    }
}

class MenFootballTeam : FootballTeam
{
    public MenFootballTeam(string teamName, int points) : base(teamName, points) { }

    public override string GetTeamType()
    {
        return "men's team";
    }
}

class Program
{
    static void Main()
    {
        FootballTeam[] womenTeams = new FootballTeam[12];
        FootballTeam[] menTeams = new FootballTeam[12];

        womenTeams[0] = new WomenFootballTeam("A", 88);
        womenTeams[1] = new WomenFootballTeam("B2", 78);
        womenTeams[2] = new WomenFootballTeam("C2", 65);
        womenTeams[3] = new WomenFootballTeam("A2", 36);
        womenTeams[4] = new WomenFootballTeam("D2", 55);
        womenTeams[5] = new WomenFootballTeam("F", 47);
        womenTeams[6] = new WomenFootballTeam("W", 57);
        womenTeams[7] = new WomenFootballTeam("X", 71);
        womenTeams[8] = new WomenFootballTeam("F1", 41);
        womenTeams[9] = new WomenFootballTeam("Y1", 51);
        womenTeams[10] = new WomenFootballTeam("W1", 80);
        womenTeams[11] = new WomenFootballTeam("X1", 19);

        menTeams[0] = new MenFootballTeam("D", 77);
        menTeams[1] = new MenFootballTeam("C", 90);
        menTeams[2] = new MenFootballTeam("V", 89);
        menTeams[3] = new MenFootballTeam("N", 20);
        menTeams[4] = new MenFootballTeam("Y", 10);
        menTeams[5] = new MenFootballTeam("B", 35);
        menTeams[6] = new MenFootballTeam("Z", 26);
        menTeams[7] = new MenFootballTeam("Q", 16);
        menTeams[8] = new MenFootballTeam("A1", 56);
        menTeams[9] = new MenFootballTeam("D1", 66);
        menTeams[10] = new MenFootballTeam("B1", 61);
        menTeams[11] = new MenFootballTeam("Z1", 81);

        Array.Sort(womenTeams, (x, y) => y.Points.CompareTo(x.Points));
        Array.Sort(menTeams, (x, y) => y.Points.CompareTo(x.Points));

        FootballTeam[] topTeams = womenTeams.Take(6).Concat(menTeams.Take(6)).ToArray();

        Console.WriteLine("Top 6 Football Teams:");
        for (int i = 0; i < topTeams.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {topTeams[i]}");
        }
    }
}



