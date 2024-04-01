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

    public string Surname => surname;
    public string Name => name;

    public abstract bool IsExcluded();
    public abstract void PrintInfo();
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
        Console.WriteLine("Хоккеист - Фамилия: {0} \t Имя: {1} \t Штрафное время: {2} мин", Surname, Name, penaltyTime);
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
        Console.WriteLine("Баскетболист - Фамилия: {0} \t Имя: {1} \t Количество фолов: {2}", Surname, Name, fouls);
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
            //player.AddPenalty(); // Убрали вызов метода AddPenalty
            if (!player.IsExcluded())
                player.PrintInfo();
        }
    }
}
*/


using System;
using System.Collections.Generic;

class FootballTeam
{
    protected string teamName;
    protected int points;

    public int Points => points;

    public FootballTeam(string teamName, int points)
    {
        this.teamName = teamName;
        this.points = points;
    }

    public virtual string GetTeamInfo()
    {
        return $"{teamName} - {points} баллов";
    }
}

class WomenFootballTeam : FootballTeam
{
    public WomenFootballTeam(string teamName, int points) : base(teamName, points)
    {
    }

    public override string GetTeamInfo()
    {
        return $"Женская команда {base.GetTeamInfo()}";
    }
}

class MenFootballTeam : FootballTeam
{
    public MenFootballTeam(string teamName, int points) : base(teamName, points)
    {
    }

    public override string GetTeamInfo()
    {
        return $"Мужская команда {base.GetTeamInfo()}";
    }
}

class Program
{
    static void Main()
    {
        List<FootballTeam> teams = new List<FootballTeam>();

        // Создаем женские команды
        WomenFootballTeam women1 = new WomenFootballTeam("A", 88);
        WomenFootballTeam women2 = new WomenFootballTeam("V", 89);
        WomenFootballTeam women3 = new WomenFootballTeam("C", 90);
        WomenFootballTeam women4 = new WomenFootballTeam("N", 20);
        WomenFootballTeam women5 = new WomenFootballTeam("F", 66);
        WomenFootballTeam women6 = new WomenFootballTeam("Y", 10);
        WomenFootballTeam women7 = new WomenFootballTeam("Z", 26);
        WomenFootballTeam women8 = new WomenFootballTeam("W", 57);
        WomenFootballTeam women9 = new WomenFootballTeam("X", 71);
        WomenFootballTeam women10 = new WomenFootballTeam("Q", 16);
        teams.Add(women1);
        teams.Add(women2);
        teams.Add(women3);
        teams.Add(women4);
        teams.Add(women5);
        teams.Add(women6);
        teams.Add(women7);
        teams.Add(women8);
        teams.Add(women9);
        teams.Add(women10);

        // Создаем мужские команды
        MenFootballTeam men1 = new MenFootballTeam("D", 77);
        MenFootballTeam men2 = new MenFootballTeam("B", 35);
        MenFootballTeam men3 = new MenFootballTeam("Z", 26);
        MenFootballTeam men4 = new MenFootballTeam("W", 57);
        MenFootballTeam men5 = new MenFootballTeam("X", 71);
        MenFootballTeam men6 = new MenFootballTeam("Q", 16);
        MenFootballTeam men7 = new MenFootballTeam("L", 32);
        MenFootballTeam men8 = new MenFootballTeam("E", 48);
        MenFootballTeam men9 = new MenFootballTeam("M", 25);
        MenFootballTeam men10 = new MenFootballTeam("T", 63);
        teams.Add(men1);
        teams.Add(men2);
        teams.Add(men3);
        teams.Add(men4);
        teams.Add(men5);
        teams.Add(men6);
        teams.Add(men7);
        teams.Add(men8);
        teams.Add(men9);
        teams.Add(men10);

        // Сортируем команды по очкам
        teams.Sort((x, y) => y.Points.CompareTo(x.Points));

        // Выводим 12 лучших команд
        Console.WriteLine("Таблица результатов:");
        for (int i = 0; i < 12; i++)
        {
            Console.WriteLine($"{i + 1}. {teams[i].GetTeamInfo()}");
        }
    }
}

