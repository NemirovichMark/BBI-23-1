﻿//1уровень 4задача
//using System;
//class Participant
//{
//    private string surname;
//    private double result1, result2, result;
//    private bool disqualification = false;
//    public void Dissqualification()
//    {
//        disqualification = true;
//    }
//    public Double Result { get { return result; } }
//    private double Max(double x, double y)
//    {
//        if (x > y)
//        {
//            return x;
//        }
//        else
//        {
//            return y;
//        }
//    }
//    public Participant(string surname1, double resultt1, double resultt2)
//    {
//        surname = surname1;
//        result1 = resultt1;
//        result2 = resultt2;
//        result = Max(result1, result2);
//    }
//    public void PrintInfo()
//    {
//        if (disqualification == false)
//        {
//            Console.WriteLine("Фамилия {0}\t  Результат  {1:f2}", surname, result);
//        }
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        Participant[] pt = new Participant[4];
//        pt[0] = new Participant("Чиченкова", 1.49, 1.52);
//        pt[1] = new Participant("Виноградов", 1.61, 1.54);
//        pt[2] = new Participant("Голубин", 1.38, 1.36);
//        pt[3] = new Participant("Словогородская", 1.53, 1.40);
//        for (int i = 0; i < pt.Length; i++)
//        {
//            pt[i].PrintInfo();
//        }
//        for (int i = 0; i < pt.Length - 1; i++)
//        {
//            double amax = pt[i].Result;
//            int imax = i;
//            for (int j = i + 1; j < pt.Length; j++)
//            {
//                if (pt[j].Result > amax)
//                {
//                    amax = pt[j].Result;
//                    imax = j;
//                }
//            }
//            Participant temp;
//            temp = pt[imax];
//            pt[imax] = pt[i];
//            pt[i] = temp;
//        }
//        Console.WriteLine();
//        pt[0].Dissqualification();
//        for (int i = 0; i < pt.Length; i++)
//        {
//            pt[i].PrintInfo();

//        }
//        Console.ReadKey();
//    }
//}
// 2 уровень 4 задача
//using System;

//public struct Participant
//{
//    private string name;
//    private double jump1;
//    private double jump2;
//    private double jump3;
//    private double jump4;
//    private double result;
//    public double Result { get { return result; } } //public, т.к. используется в классе Diving в методе Sort
//    private static double JumpResult(double[] list, double index)
//    {
//        int n = list.Length;
//        int imin = 0;
//        int imax = 0;
//        double sum = 0;
//        for (int i = 0; i < n; i++)
//        {
//            if (list[i] > list[imax]) imax = i;
//            if (list[i] < list[imin]) imin = i;
//            sum += list[i];
//        }
//        return (sum - list[imin] - list[imax]) * index;
//    }
//    public void PrintInfo()//используется в классе Diving в методе Print
//    {
//        Console.WriteLine($"{name}, итоговый результат: {result}");
//    }
//    public Participant(string name, double[,] points) //конструктор всегда public 
//    // в массиве 4*8 в каждой строке, соотвествующей каждому из 4-х прыжков,
//    // содержится индекс прыжка и 7 оценок судей от 0 до 6 баллов каждая
//    {
//        this.name = name;
//        double[] result_jumps = new double[4];
//        for (int i = 0; i < 4; i++)
//        {
//            double index = points[i, 0];
//            double[] voices = new double[7];
//            for (int k = 0; k < 7; k++) voices[k] = points[i, k + 1];
//            result_jumps[i] = JumpResult(voices, index);
//        }
//        jump1 = result_jumps[0];
//        jump2 = result_jumps[1];
//        jump3 = result_jumps[2];
//        jump4 = result_jumps[3];
//        result = jump1 + jump2 + jump3 + jump4;
//    }
//}
//public abstract class Diving
//{
//    protected string discipline_name;
//    private Participant[] peoplelist;
//    public Diving(Participant[] peoplelist)
//    {
//        this.peoplelist = peoplelist;
//        discipline_name = "прыжки в воду";
//    }
//    private void Sort()
//    {
//        for (int i = 0; i < peoplelist.Length - 1; i++)
//        {
//            double amax = peoplelist[i].Result;
//            int imax = i;
//            for (int j = i + 1; j < peoplelist.Length; j++)
//            {
//                if (peoplelist[j].Result > amax)
//                {
//                    amax = peoplelist[j].Result;
//                    imax = j;
//                }
//                Participant term = peoplelist[imax];
//                peoplelist[imax] = peoplelist[i];
//                peoplelist[i] = term;
//            }
//        }
//    }
//    private void Print()
//    {
//        Console.WriteLine($"Результаты соревнования по дисциплине {discipline_name}:");
//        for (int i = 0; i < peoplelist.Length; i++)
//        {
//            Console.Write($"{i + 1} место:"); ;
//            peoplelist[i].PrintInfo();
//        }
//    }
//    public void Hold_Competition()//используется в Main
//    {
//        Sort();
//        Print();
//        Console.WriteLine();
//    }
//}
//public class Diving_from_3 : Diving
//{
//    public Diving_from_3(Participant[] peoplelist) : base(peoplelist)
//    {
//        discipline_name = "прыжки в воду с 3-х метров";
//    }
//}
//public class Diving_from_5 : Diving
//{
//    public Diving_from_5(Participant[] peoplelist) : base(peoplelist)
//    {
//        discipline_name = "прыжки в воду с 5-и метров";
//    }
//}
//public class Program
//{
//    public static void Main(string[] args)
//    {
//        // Данные в коде, количество участников 5
//        double[,] sportsman1 = new double[4, 8] { { 2.5,0,5,2,2,2,2,2},
//            {2.7,1,6,3,3,3,3,3 },
//            {3.2,2,6,4,4,4,4,4 },
//            {3.5,1,1,1,1,1,1,1 } };
//        double[,] sportsman2 = new double[4, 8] { { 3,1,1,1,1,1,1,1},
//            {3,2,2,2,2,2,2,2},
//            {3,4,4,4,4,4,6,1},
//            {3,0,5,2,2,2,2,2}};
//        double[,] sportsman3 = new double[4, 8] { { 2.5, 5, 5, 5, 5, 6, 1, 5 }, { 3, 0, 2, 3, 4, 5, 1, 2 }, { 3, 3, 4, 5, 2, 5, 5, 1 }, { 3, 2, 1, 2, 2, 2, 6, 2 } };
//        double[,] sportsman4 = new double[4, 8] { { 2.8, 1, 1, 1, 1, 1, 1, 1 }, { 3.1, 2, 2, 2, 2, 2, 2, 2 }, { 3.3, 4, 4, 4, 4, 4, 6, 1 }, { 3.5, 0, 5, 2, 2, 2, 2, 2 } };
//        double[,] sportsman5 = new double[4, 8] { { 2.9, 5, 5, 5, 5, 6, 1, 5 }, { 3.3, 0, 2, 3, 4, 5, 1, 2 }, { 3.5, 3, 4, 0, 2, 5, 5, 1 }, { 3, 2, 1, 2, 2, 2, 6, 2 } };
//        double[,] sportsman6 = new double[4, 8] { { 2.6,0,5,2,2,2,2,2},
//            {2.7,1,6,3,3,3,3,3 },
//            {3.2,2,6,4,4,4,4,4 },
//            {3.5,1,1,1,1,1,1,1 } };
//        double[,] sportsman7 = new double[4, 8] { { 2.7,1,1,1,1,1,1,1},
//            {3,2,2,2,2,2,2,2},
//            {3,4,4,4,4,4,6,1},
//            {3,0,5,2,2,2,2,2}};
//        double[,] sportsman8 = new double[4, 8] { { 3.1,0,5,2,2,2,2,2},
//            {2.7,1,6,3,3,3,3,3 },
//            {3.2,2,6,4,4,4,4,4 },
//            {3.5,1,1,1,1,1,1,1 } };
//        double[,] sportsman9 = new double[4, 8] { { 3.2,1,1,1,1,1,1,1},
//            {3,2,2,2,2,2,2,2},
//            {3,4,4,4,4,4,6,1},
//            {3,0,5,2,2,2,2,2}};
//        double[,] sportsman10 = new double[4, 8] { { 3.3,6,5,1,1,1,1,1},
//            {3,2,2,2,2,2,2,2},
//            {3,4,4,4,4,4,6,1},
//            {3,0,5,2,2,2,2,2}};
//        Participant[] peoplelist1 = { new Participant("name1",sportsman1),
//            new Participant("name2", sportsman2),
//            new Participant("name3", sportsman3),
//            new Participant("name4",sportsman4),
//            new Participant("name5", sportsman5)
//        }; //массив учатников, прыгающих с 3 метров
//        Participant[] peoplelist2 = { new Participant("name6",sportsman6),
//            new Participant("name7", sportsman7),
//            new Participant("name8", sportsman8),
//            new Participant("name9",sportsman9),
//            new Participant("name10", sportsman10)
//        };//массив участников, прыгающих с 5 метров
//        Diving_from_3 competition1 = new Diving_from_3(peoplelist1);
//        Diving_from_5 competition2 = new Diving_from_5(peoplelist2);
//        competition1.Hold_Competition();
//        competition2.Hold_Competition();
//        Console.ReadKey();
//    }
//}
// 3 уровень 5 задача
//using System;

//class FootballTeam
//{
//    protected string TeamName { get; private set; }
//    public int GoalsFor { get; set; }
//    public int GoalsAgainst { get; set; }
//    public int Points { get; set; }

//    protected static int _counter = 0;

//    public FootballTeam(string teamName, int goalsFor, int goalsAgainst)
//    {
//        TeamName = teamName;
//        GoalsFor = goalsFor;
//        GoalsAgainst = goalsAgainst;
//        Points = 0;
//    }

//    public int GoalDifference()
//    {
//        return GoalsFor - GoalsAgainst;
//    }
//    public virtual void Show()
//    {
//        _counter++;
//        Console.WriteLine($"{_counter} место - Команда: {TeamName}, сумма очков: {Points}");
//    }
//}

//class WomenFootballTeam : FootballTeam
//{
//    public WomenFootballTeam(string teamName, int goalsFor, int goalsAgainst) : base(teamName, goalsFor, goalsAgainst)
//    {
//    }
//    public override void Show()
//    {
//        _counter++;
//        Console.WriteLine($"{_counter} место -  женская команда {TeamName}, сумма очков: {Points}");
//    }
//}

//class MenFootballTeam : FootballTeam
//{
//    public MenFootballTeam(string teamName, int goalsFor, int goalsAgainst) : base(teamName, goalsFor, goalsAgainst)
//    {
//    }
//    public override void Show()
//    {
//        _counter++;
//        Console.WriteLine($"{_counter} место -  мужская команда {TeamName}, сумма очков: {Points}");
//    }
//}

//class FootballLeague
//{
//    public static void Main(string[] args)
//    {
//        List<FootballTeam> teams = new List<FootballTeam>();
//        teams.Add(new WomenFootballTeam("Команда 1", 5, 3));
//        teams.Add(new WomenFootballTeam("Команда 2", 4, 4));
//        teams.Add(new MenFootballTeam("Команда 3", 6, 2));
//        teams.Add(new MenFootballTeam("Команда 4", 3, 5));


//        foreach (var team in teams)
//        {
//            if (team.GoalsFor > team.GoalsAgainst)
//            {
//                team.Points += 3;
//            }
//            else if (team.GoalsFor == team.GoalsAgainst)
//            {
//                team.Points += 1;
//            }
//        } 
//        for (int i = 0; i < teams.Count - 1; i++)
//        {
//            for (int j = i + 1; j < teams.Count; j++)
//            {
//                if (teams[j].Points > teams[i].Points || ((teams[j].Points == teams[i].Points) && (teams[j].GoalDifference()) > (teams[i].GoalDifference())))
//                {
//                    FootballTeam a = teams[i];
//                    teams[i] = teams[j];
//                    teams[j] = a;
//                }
//            }
//        }
//        foreach (var team in teams)
//        {
//            team.Show();
//        }
//        Console.ReadKey();
//    }
//}

