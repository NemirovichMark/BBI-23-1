/*using System;
using System.Collections.Generic;

abstract class Runner
{
    protected string surname;
    protected string group;
    protected string surnameTeacher;
    protected double rez;
    public string standart;

    public string Surname => surname;
    public string Group => group;
    public string SurnameTeacher => surnameTeacher;
    public double Rez => rez;

    public abstract string GetTitle();
}

class PersonOfYear : Runner
{
    public override string GetTitle()
    {
        return "Человек Года";
    }

    public PersonOfYear(string surname, string surnameTeacher, string group, double rez)
    {
        this.surname = surname;
        this.surnameTeacher = surnameTeacher;
        this.group = group;
        this.rez = rez;
    }
}

class DiscoveryOfYear : Runner
{
    public override string GetTitle()
    {
        return "Открытие Года";
    }

    public DiscoveryOfYear(string surname, string surnameTeacher, string group, double rez)
    {
        this.surname = surname;
        this.surnameTeacher = surnameTeacher;
        this.group = group;
        this.rez = rez;
    }
}

class Program
{
    static void Main()
    {
        List<PersonOfYear> personsOfYear = new List<PersonOfYear>();
        List<DiscoveryOfYear> discoveriesOfYear = new List<DiscoveryOfYear>();

        int passedPersonCount = 0;
        int passedDiscoveryCount = 0;

        Runner[] runners = new Runner[5];
        runners[0] = new PersonOfYear("Губеева", "Тренеровна", "234", 1.50);
        runners[1] = new PersonOfYear("Капелина", "Гасанов", "666", 1.55);
        runners[2] = new PersonOfYear("Попова", "Кужель", "777", 1.47);
        runners[3] = new DiscoveryOfYear("Орлова", "Лушина", "889", 1.46);
        runners[4] = new DiscoveryOfYear("Коцарь", "Пушина", "995", 1.54);

        Array.Sort(runners, (x, y) => y.Rez.CompareTo(x.Rez));

        Console.WriteLine("Таблица 'Человек Года'");
        Console.WriteLine("Фамилия\tГруппа\tТренер\tРезультат\tНорматив (1.5 секунды)");

        foreach (var runner in runners)
        {
            if (runner is PersonOfYear person)
            {
                if (person.Rez <= 1.5)
                {
                    passedPersonCount++;
                    person.standart = "Сдан";
                }
                personsOfYear.Add(person);
            }
            else if (runner is DiscoveryOfYear discovery)
            {
                if (discovery.Rez <= 1.5)
                {
                    passedDiscoveryCount++;
                    discovery.standart = "Сдан";
                }
                discoveriesOfYear.Add(discovery);
            }
        }

        foreach (var person in personsOfYear)
        {
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}",
                person.Surname, person.Group, person.SurnameTeacher, person.Rez, person.standart);
        }

        Console.WriteLine("Человек сдало норматив: " + passedPersonCount);

        Console.WriteLine("\nТаблица 'Открытие Года'");
        Console.WriteLine("Фамилия\tГруппа\tТренер\tРезультат\tНорматив (1.5 секунды)");

        foreach (var discovery in discoveriesOfYear)
        {
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}",
                discovery.Surname, discovery.Group, discovery.SurnameTeacher, discovery.Rez, discovery.standart);
        }

        Console.WriteLine("Открытий сдало норматив: " + passedDiscoveryCount);
    }
}
*/

//using System;

//abstract class SportPlayer
//{
//    protected string surname;
//    protected string name;
//    protected int penalty;

//    public string Surname => surname;
//    public string Name => name;
//    public int Penalty => penalty;

//    public SportPlayer(string surname, string name, int penalty)
//    {
//        this.surname = surname;
//        this.name = name;
//        this.penalty = penalty;
//    }

//    public abstract void AddPenalty();
//}

//class HockeyPlayer : SportPlayer
//{
//    public HockeyPlayer(string surname, string name, int penalty) : base(surname, name, penalty) { }

//    public override void AddPenalty()
//    {
//        penalty++;
//    }
//}

//class BasketballPlayer : SportPlayer
//{
//    private int fouls;

//    public int Fouls => fouls;

//    public BasketballPlayer(string surname, string name, int fouls) : base(surname, name, 0)
//    {
//        this.fouls = fouls;
//    }

//    public override void AddPenalty()
//    {
//        fouls++;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        SportPlayer[] set = new SportPlayer[30];
//        set[0] = new HockeyPlayer("Акинов", "Ваня", 2);
//        set[1] = new HockeyPlayer("Кольцов", "Даня", 5);
//        set[2] = new HockeyPlayer("Носов", "Миша", 10);
//        set[3] = new HockeyPlayer("Осипов", "Паша", 5);
//        set[4] = new HockeyPlayer("Кузьмин", "Саша", 2);
//        set[5] = new HockeyPlayer("Пугачев", "Ваня", 10);
//        set[6] = new BasketballPlayer("Киркоров", "Даня", 2);
//        set[7] = new BasketballPlayer("Эминем", "Миша", 5);
//        set[8] = new HockeyPlayer("Иванов", "Паша", 2);
//        set[9] = new HockeyPlayer("Петров", "Саша", 2);
//        set[10] = new HockeyPlayer("Cидаров", "Ваня", 2);
//        set[11] = new HockeyPlayer("Михайлов", "Даня", 2);
//        set[12] = new HockeyPlayer("Козлов", "Ваня", 2);
//        set[13] = new HockeyPlayer("Воробьев", "Паша", 2);
//        set[14] = new HockeyPlayer("Таранов", "Миша", 2);
//        set[15] = new BasketballPlayer("Огнезов", "Саша", 2);
//        set[16] = new HockeyPlayer("Попов", "Ваня", 2);
//        set[17] = new HockeyPlayer("Третьяков", "Даня", 10);
//        set[18] = new HockeyPlayer("Черкасов", "Миша", 2);
//        set[19] = new HockeyPlayer("Князев", "Паша", 2);
//        set[20] = new HockeyPlayer("Ногинов", "Саша", 2);
//        set[21] = new HockeyPlayer("Казанцев", "Ваня", 10);
//        set[22] = new HockeyPlayer("Лунин", "Ваня", 2);
//        set[23] = new HockeyPlayer("Стоценко", "Даня", 10);
//        set[24] = new HockeyPlayer("Глазков", "Паша", 10);
//        set[25] = new HockeyPlayer("Подвальников", "Ваня", 5);
//        set[26] = new HockeyPlayer("Ежков", "Сережа", 10);
//        set[27] = new HockeyPlayer("Туренко", "Даня", 2);
//        set[28] = new HockeyPlayer("Мухин", "Ваня", 2);
//        set[29] = new HockeyPlayer("Григорян", "Даня", 10);

//        Array.Sort(set, (x, y) => x.Penalty.CompareTo(y.Penalty));

//        foreach (var player in set)
//        {
//            if (player.Penalty < 4)
//            {
//                Console.WriteLine($"Фамилия: {player.Surname} \t Имя: {player.Name} \t Штраф: {player.Penalty}");
//            }
//        }
//    }
//}


using System;

class FootballTeam
{
    protected string teamName;
    protected string gender;
    protected int totalPoints;

    public string TeamName => teamName;
    public string Gender => gender;
    public int TotalPoints => totalPoints;

    public FootballTeam(string teamName, string gender, int totalPoints)
    {
        this.teamName = teamName;
        this.gender = gender;
        this.totalPoints = totalPoints;
    }
}

class WomenFootballTeam : FootballTeam
{
    public WomenFootballTeam(string teamName, int totalPoints) : base(teamName, "Женская", totalPoints) { }
}

class MenFootballTeam : FootballTeam
{
    public MenFootballTeam(string teamName, int totalPoints) : base(teamName, "Мужская", totalPoints) { }
}

class Program
{
    static void Main()
    {
        FootballTeam[] teams = new FootballTeam[24];
        teams[0] = new MenFootballTeam("A", 88);
        teams[1] = new MenFootballTeam("D", 77);
        teams[2] = new MenFootballTeam("C", 90);
        teams[3] = new MenFootballTeam("V", 89);
        teams[4] = new MenFootballTeam("N", 20);
        teams[5] = new MenFootballTeam("F", 66);
        teams[6] = new MenFootballTeam("Y", 10);
        teams[7] = new MenFootballTeam("B", 35);
        teams[8] = new MenFootballTeam("z", 26);
        teams[9] = new MenFootballTeam("W", 57);
        teams[10] = new MenFootballTeam("X", 71);
        teams[11] = new MenFootballTeam("Q", 16);
        teams[12] = new WomenFootballTeam("A1", 56);
        teams[13] = new WomenFootballTeam("B1", 61);
        teams[14] = new WomenFootballTeam("D1", 66);
        teams[15] = new WomenFootballTeam("C1", 11);
        teams[16] = new WomenFootballTeam("V1", 12);
        teams[17] = new WomenFootballTeam("N1", 13);
        teams[18] = new WomenFootballTeam("F1", 41);
        teams[19] = new WomenFootballTeam("Y1", 51);
        teams[20] = new WomenFootballTeam("Z1", 81);
        teams[21] = new WomenFootballTeam("W1", 80);
        teams[22] = new WomenFootballTeam("X1", 19);
        teams[23] = new WomenFootballTeam("Q1", 15);


        Array.Sort(teams, (x, y) => y.TotalPoints.CompareTo(x.TotalPoints));

        Console.WriteLine("Таблица лучших команд:");
        int womenCount = 0;
        int menCount = 0;
        for (int i = 0; i < 23; i++)
        {
            if (teams[i] is MenFootballTeam && menCount < 6)
            {
                Console.WriteLine($"\tМужская команда: {teams[i].TeamName} (очки: {teams[i].TotalPoints})");
                menCount++;
            }
            if (teams[i] is WomenFootballTeam && womenCount < 6)
            {
                Console.WriteLine($"\tЖенская команда: {teams[i].TeamName} (очки: {teams[i].TotalPoints})");
                womenCount++;
            }
        }
    }
}
