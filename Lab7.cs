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
        FootballTeam[] teams = new FootballTeam[24];

        teams[0] = new WomenFootballTeam("A", 88);
        teams[1] = new MenFootballTeam("D", 77);
        teams[2] = new MenFootballTeam("C", 90);
        teams[3] = new MenFootballTeam("V", 89);
        teams[4] = new MenFootballTeam("N", 20);
        teams[5] = new WomenFootballTeam("F", 66);
        teams[6] = new MenFootballTeam("Y", 10);
        teams[7] = new MenFootballTeam("B", 35);
        teams[8] = new MenFootballTeam("Z", 26);
        teams[9] = new WomenFootballTeam("W", 57);
        teams[10] = new WomenFootballTeam("X", 71);
        teams[11] = new MenFootballTeam("Q", 16);
        teams[12] = new MenFootballTeam("A1", 56);
        teams[13] = new MenFootballTeam("D1", 66);
        teams[14] = new MenFootballTeam("C1", 11);
        teams[15] = new MenFootballTeam("V1", 12);
        teams[16] = new MenFootballTeam("N1", 13);
        teams[17] = new WomenFootballTeam("F1", 41);
        teams[18] = new WomenFootballTeam("Y1", 51);
        teams[19] = new MenFootballTeam("B1", 61);
        teams[20] = new MenFootballTeam("Z1", 81);
        teams[21] = new WomenFootballTeam("W1", 80);
        teams[22] = new WomenFootballTeam("X1", 19);
        teams[23] = new MenFootballTeam("Q1", 15);

        Array.Sort(teams, (x, y) => y.Points.CompareTo(x.Points));

        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine($"{i + 1}. {teams[i]}");
        }
    }
}


