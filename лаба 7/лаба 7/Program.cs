#region 1_4

/*Результаты соревнований по прыжкам в высоту определяются 
по лучшей из двух попыток. 
Вывести список участников в порядке занятых мест.

Добавить поле «дисквалификация» и метод, 
который позволяет дисквалифицировать участника. 
В итоговую таблицу такие участники входить не должны.
*/

//using System;

//public struct Sportsman
//{
//    private string _surname;
//    private double _attempt1;
//    private double _attempt2;
//    private double _bestResult;
//    private bool _disqualified;

//    public Sportsman(string S, double a1, double a2, double bestResult)
//    {
//        _surname = S;
//        _attempt1 = a1;
//        _attempt2 = a2;

//        if (a1 > a2)
//        {
//            _bestResult = a1;
//        }
//        else
//        {
//            _bestResult = a2;
//        }

//        if (_bestResult < 1.60)
//        {
//            _disqualified = true;
//        }
//        else
//        {
//            _disqualified = false;
//        }
//    }

//    public void Disqualify()
//    {
//        _disqualified = true;
//    }

//    public double BestResult => _bestResult;

//    public bool Disqualified => _disqualified;

//    public void PrintInfo()
//    {
//        Console.WriteLine($"Фамилия: {_surname}\tПопытка№1: {_attempt1}\tПопытка №2: {_attempt2}");
//    }

//    public static void PrintTableHeader()
//    {
//        Console.WriteLine($"{"Фамилия",10} {"Попытка №1",10} {"Попытка №2",10}");
//    }

//    public static void PrintTableRow(Sportsman data)
//    {
//        if (!data.Disqualified)
//        {
//            Console.WriteLine($"{data._surname,10} {data._attempt1,10} {data._attempt2,10}");

//        }
//    }
//    public static void Sort(Sportsman[] sportsmen)
//    {
//        for (int i = 0; i < sportsmen.Length - 1; i++)
//        {
//            for (int j = i + 1; j < sportsmen.Length; j++)
//            {
//                if (sportsmen[i].BestResult < sportsmen[j].BestResult)
//                {
//                    Sportsman best = sportsmen[i];
//                    sportsmen[i] = sportsmen[j];
//                    sportsmen[j] = best;
//                }
//            }
//        }
//    }
//}
//class program
//{
//    static void Main()
//    {
//        Sportsman[] sportsmen = new Sportsman[4];
//        {
//            sportsmen[0] = new Sportsman("Abramov", 1.5, 1.57, 0);
//            sportsmen[1] = new Sportsman("Baranov", 1.26, 1.4, 0);
//            sportsmen[2] = new Sportsman("Voronov", 1.75, 1.87, 0);
//            sportsmen[3] = new Sportsman("Gyrov", 1.4, 1.8, 0);
//        };
//        Sportsman.PrintTableHeader();
//        foreach (var sportsman in sportsmen)
//        {
//            Sportsman.PrintTableRow(sportsman);
//        }
//    }
//}

#endregion

#region 2_9

/*Результаты соревнований фигуристов по одному из 
видов многоборья представлены оценками 7 судей 
в баллах (от 0,0 до 6,0). 
По результатам оценок судьи определяется место 
каждого участника у этого судьи. 
Места участников определяются далее по сумме мест,
которые каждый участник занял у всех судей. 
Составить программу, определяющую по исходной 
таблице оценок фамилии и сумму мест участников 
в порядке занятых ими мест.

Сделать абстрактный класс «Зимние виды спорта»
с обязательным полем «Название дисциплины»,
и от него наследников: 
«Фигурное катание» и «Конькобежный спорт». 
В каждом из классов переопределить 
название дисциплины (и выводить в начале таблицы).*/

//using System;
//public struct Competitor
//{
//    private string surname;
//    private double[] scores;
//    private int totalPlace;
//    public Competitor(string surname, double[] scores)
//    {
//        this.surname = surname;
//        this.scores = scores;
//        this.totalPlace = 0;
//    }
//    public string Surname
//    {
//        get { return surname; }
//    }

//    public double[] Scores
//    {
//        get { return scores; }
//    }

//    public int TotalPlace
//    {
//        get { return totalPlace; }
//        private set { totalPlace = value; }
//    }

//    public void PrintInfo()
//    {
//        Console.WriteLine($"Фамилия: {surname}\tМесто: {TotalPlace}");
//    }

//    public static void PrintTableHeader()
//    {
//        Console.WriteLine($"{"Фамилия",10} {"Место",10}");
//    }

//    public static void PrintTableRow(Competitor sportsman)
//    {
//        Console.WriteLine($"{sportsman.surname,10} {sportsman.TotalPlace,10}");
//    }


//    public static void CalculateTotalPlaces(Competitor[] competitors)
//    {
//        for (int i = 0; i < competitors.Length; i++)
//        {
//            int totalPlace = 0;
//            for (int j = 0; j < competitors.Length; j++)
//            {
//                if (i != j && CalculatePoints(competitors[i].Scores) > CalculatePoints(competitors[j].Scores))
//                {
//                    totalPlace++;
//                }
//            }
//            competitors[i].TotalPlace = totalPlace + 1;
//        }
//    }
//    public static double CalculatePoints(double[] scores)
//    {
//        double sum = 0;
//        foreach (double score in scores)
//        {
//            sum += score;
//        }
//        return sum;
//    }
//}
//public abstract class Athlete
//{
//    public abstract void DisplayInfo(Competitor competitor);
//}

//public class SkatingAthlete : Athlete
//{
//    public override void DisplayInfo(Competitor competitor)
//    {
//        Console.WriteLine($"Конькобежец: {competitor.Surname}\tМесто: {competitor.TotalPlace}");
//    }
//}
//public class GymnasticsAthlete : Athlete
//{
//    public override void DisplayInfo(Competitor competitor)
//    {
//        Console.WriteLine($"Гимнаст: {competitor.Surname}\tМесто: {competitor.TotalPlace}");
//    }
//}
//class Program
//{
//    static void Main()
//    {
//        Competitor[] competitors = new Competitor[3]
//        {
//            new Competitor("Smith", new double[] {5.6, 6.0, 5.5, 5.8, 5.9, 5.7, 5.8}),
//            new Competitor("Johnson", new double[] {5.8, 5.9, 5.7, 6.0, 5.5, 5.6, 5.8}),
//            new Competitor("Williams", new double[] {5.7, 5.5, 5.9, 5.7, 5.8, 5.9, 5.6})
//        };


//        Competitor.PrintTableHeader();
//        Competitor.CalculateTotalPlaces(competitors);
//        foreach (var competitor in competitors)
//        {
//            Competitor.PrintTableRow(competitor);
//        }
//    }
//}
#endregion


#region 3_3

///*В соревнованиях участвуют три команды по 6 человек.
//Результаты соревнований представлены в виде мест участников каждой команды (1 – 18).
//Определить команду-победителя, вычислив количество баллов, набранное каждой командой.
//Участнику, занявшему 1-е место, начисляется 5 баллов,
//2-е – 4, 3-е – 3, 4-е – 2, 5-е – 1, остальным – 0 баллов.
//При равенстве баллов победителем считается команда,
//за которую выступает участник, занявший 1-е место.*/

///*Создать класс «Команда» с 2 классами-наследниками: 
// «Женская команда» и «Мужская команда».
//Соревнования среди команд независимые. 
//Вывести 1 команду победителя (она может быть как мужская, так и женская). 
//Использовать динамическую связку: преобразование классов.*/

using System;
public struct Participant
{
    private int place;
    public Participant(int place)
    {
        this.place = place;
    }
    public int GetPlace()
    {
        return place;
    }
}
public class Team
{
    private Participant[] participants;
    public string name;
    public Team(int[] places, string name)
    {
        participants = new Participant[6];
        for (int i = 0; i < 6; i++)
        {
            participants[i] = new Participant(places[i]);
        }
        this.name = name;
    }
    public virtual int CalculateScore()
    {
        int score = 0;
        for (int i = 0; i < participants.Length; i++)
        {
            int place = participants[i].GetPlace();
            if (place == 1)
            {
                score += 5;
            }
            else if (place == 2)
            {
                score += 4;
            }
            else if (place == 3)
            {
                score += 3;
            }
            else if (place == 4)
            {
                score += 2;
            }
            else if (place == 5)
            {
                score += 1;
            }
        }
        return score;
    }
    public virtual string GetTeamType()
    {
        return "команда";
    }
    public string GetName()
    {
        return name;
    }
}

public class MenTeam : Team
{
    public MenTeam(int[] places, string name) : base(places, name) { }
    public override string GetTeamType()
    {
        return "мужская";
    }
}
public class WomenTeam : Team
{
    public WomenTeam(int[] places, string name) : base(places, name) { }
    public override string GetTeamType()
    {
        return "женская";
    }
}
class Program
{
    static void Main(string[] args)
    {
        MenTeam menTeam1 = new MenTeam(new int[] { 1, 2, 3, 4, 5, 6 }, "Men team 1");
        MenTeam menTeam2 = new MenTeam(new int[] { 7, 8, 9, 10, 11, 12 }, "Men team 2");
        MenTeam menTeam3 = new MenTeam(new int[] { 13, 14, 15, 16, 17, 18 }, "Men team 3");

        WomenTeam womenTeam1 = new WomenTeam(new int[] { 19, 20, 21, 22, 23, 24 }, "Women team 1");
        WomenTeam womenTeam2 = new WomenTeam(new int[] { 25, 26, 27, 28, 29, 30 }, "Women team 2");
        WomenTeam womenTeam3 = new WomenTeam(new int[] { 31, 32, 33, 34, 35, 36 }, "Women team 3");

        Team[] teams = new Team[] { menTeam1, menTeam2, menTeam3, womenTeam1, womenTeam2, womenTeam3 };
        
        Team bestTeam = teams[0];
        int bestScore = teams[0].CalculateScore();
        for (int i = 1; i < teams.Length; i++)
        {
            int score = teams[i].CalculateScore();
            if (score > bestScore)
            {
                bestTeam = teams[i];
                bestScore = score;
            }
        }

        Console.WriteLine($"Победила {bestTeam.GetTeamType()} команда {bestTeam.GetName()} со счетом {bestScore}");
    }
}
#endregion