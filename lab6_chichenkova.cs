////1 уровень 4 задача
//using System;
//struct Participant
//{
//    private string surname;
//    private double result1, result2, result;
//    public Double Result { get { return result; } }
//    public String Surname { get { return surname; } }
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
//    public Participant(string surname1, double Result1, double Result2)
//    {
//        surname = surname1;
//        result1 = Result1;
//        result2 = Result2;
//        result = Max(result1, result2);
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        Participant [] pt = new Participant[4];
//        pt[0] = new Participant("Чиченкова", 1.49, 1.52);
//        pt[1] = new Participant("Виноградов", 1.61, 1.54);
//        pt[2] = new Participant("Голубин", 1.38, 1.36);
//        pt[3] = new Participant("Словогородская", 1.53, 1.40);
//        for (int i = 0; i < pt.Length; i++)
//        {
//            Console.WriteLine("Фамилия {0}\t Результат {1:f2}", pt[i].Surname, pt[i].Result);
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
//        for (int i = 0; i < pt.Length; i++)
//        {
//            Console.WriteLine("Фамилия {0}\t  Результат  {1:f2}", pt[i].Surname,pt[i].Result);
//        }
//    }
//}


// 2 уровень 5 задача
//using System;

//struct Participant
//{
//    private string name;
//    private double jump1;
//    private double jump2;
//    private double jump3;
//    private double jump4;
//    public Participant(string name, double first, double second, double third, double fourth)
//    {
//        this.name = name;
//        jump1 = first;
//        jump2 = second;
//        jump3 = third;
//        jump4 = fourth;
//    }


//    public double End_result()
//    {
//        return jump1 + jump2 + jump3 + jump4;
//    }

//    public void PrintInfo()
//    {
//        Console.WriteLine($"Итоговый результат: {jump1 + jump2 + jump3 + jump4}  {name} ");
//    }
//}

//public class Program
//{

//    public static int[] SortedGolosa(int[] list, int n)
//    {
//        for (int i = 1; i < n; i++)
//        {
//            for (int j = 0; j < n - i; j++)
//            {
//                if (list[j + 1] > list[j])
//                {
//                    int now = list[j];
//                    list[j] = list[j + 1];
//                    list[j + 1] = now;
//                }
//            }
//        }
//        return list;
//    }

//    static Participant[] Sort(Participant[] list)
//    {
//        for (int i = 0; i < list.Length; i++)
//        {
//            for (int j = i; j < list.Length; j++)
//                if (list[i].End_result() < list[j].End_result())
//                {
//                    Participant person_now = list[j];
//                    list[j] = list[i];
//                    list[i] = person_now;
//                }
//        }
//        return list;
//    }


//    public static void Main(string[] args)
//    {
//        int n = int.Parse(Console.ReadLine());
//        Participant[] peoplelist = new Participant[n];

//        for (int i = 0; i < n; i++)
//        {
//            string nam_pep = Console.ReadLine();
//            double[] result_jumps = new double[4];
//            for (int j = 0; j < 4; j++)
//            {
//                double index = double.Parse(Console.ReadLine());
//                int[] voices = new int[7];
//                for (int s = 0; s < 7; s++)
//                {
//                    int voise = int.Parse(Console.ReadLine());
//                    voices[s] = voise;
//                }

//                voices = SortedGolosa(voices, 7);
//                int sum_gol = 0;
//                for (int k = 1; k < 6; k++)
//                {
//                    sum_gol += voices[k];
//                }

//                result_jumps[j] = sum_gol * index;
//            }

//            Participant person = new Participant(nam_pep, result_jumps[0], result_jumps[1], result_jumps[2], result_jumps[3]);
//            peoplelist[i] = person;
//        }

//        peoplelist = Sort(peoplelist);

//        for (int i = 0; i < n; i++)
//        {
//            Console.Write($"{i + 1} место:"); ;
//            peoplelist[i].PrintInfo();
//            Console.WriteLine();
//        }
//        Console.WriteLine();
//    }
//}

// 3 уровень 5 задача
//using System;

//class Program
//{
//    private struct Team
//    {
//        public string team;
//        public int score;
//        public int misses;
//        public int points;
//        public void Printinfo(int place)
//        {
//            Console.WriteLine($"{place}\t{team}\t{points}");
//        }
//    }

//    static void Main(string[] args)
//    {
//        Team[] teams = {
//            new Team { team = "Команда 1", score = 2, misses = 1 },
//            new Team { team = "Команда 2", score = 1, misses = 1 },
//            new Team { team = "Команда 3", score = 0, misses = 3 },
//            new Team { team = "Команда 4", score = 3, misses = 0 }
//        };

//        scores(teams);
//        sort(teams);
//        result(teams);
//    }

//    private static void scores(Team[] teams)
//    {
//        for (int i = 0; i < teams.Length; i++)
//        {
//            teams[i].points = teams[i].score > teams[i].misses ? 3 : teams[i].score == teams[i].misses ? 1 : 0;
//        }
//    }
//    private static void sort(Team[] teams)
//    {
//        for (int i = 0; i < teams.Length - 1; i++)
//        {
//            for (int j = 0; j < teams.Length - i - 1; j++)
//            {
//                if (teams[j].points < teams[j + 1].points || (teams[j].points == teams[j + 1].points && (teams[j].score - teams[j].misses) < (teams[j + 1].score - teams[j + 1].misses)))
//                {
//                    Team t = teams[j];
//                    teams[j] = teams[j + 1];
//                    teams[j + 1] = t;
//                }
//            }
//        }
//    }
//    private static void result(Team[] teams)
//    {

//        Console.WriteLine("Итоговая таблица:");
//        Console.WriteLine("Место\tКоманда\tОчки");
//        for (int i = 0; i < teams.Length; i++)
//        {
//            teams[i].Printinfo(i + 1);
//        }
//    }
//}