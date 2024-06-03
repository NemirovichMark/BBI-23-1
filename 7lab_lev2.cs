//using System;
//using System.Collections.Generic;
//using System.Text;

//public struct Sportsman
//{
//    private string name;
//    private int[,] golos_jumps;
//    public int[,] Golosa { get { return golos_jumps; } }
//    public string Name { get { return name; } }

//    public Sportsman(string name, int[,] jumps_)
//    {
//        this.name = name;
//        golos_jumps = jumps_;
//    }

//}

//public abstract class JumpWater
//{
//    protected string dist;
//    protected Sportsman[] sportsmen;
//    protected double[] indexx;

//    public JumpWater(Sportsman[] sportsmen, string dist, double[] indexx)
//    {
//        this.sportsmen = sportsmen;
//        this.dist = dist;
//        this.indexx = indexx;
//    }

//    protected double RezultForPerson(int[,] list)
//    {
//        for (int number = 0; number < 4; number++)
//        {
//            for (int i = 1; i < 7; i++)
//            {
//                int k = list[number, i];
//                int j = i - 1;

//                while (j >= 0 && list[number, j] < k)
//                {
//                    list[number, j + 1] = list[number, j];
//                    j--;
//                }
//                list[number, j + 1] = k;
//            }
//        }
//        int[] res_jumps = new int[4] { 0, 0, 0, 0 };
//        for (int i = 0; i < 4; i++)
//        {
//            for (int j = 1; j < 6; j++)
//            {
//                res_jumps[i] += list[i, j];
//            }
//        }
//        double s = 0;
//        for (int i = 0; i < 4; i++)
//        {
//            s += res_jumps[i] * indexx[i];
//        }
//        return s;
//    }

//    protected Sportsman[] Sort(Sportsman[] list)
//    {
//        for (int i = 0; i < list.Length; i++)
//        {
//            for (int j = i; j < list.Length; j++)
//                if (RezultForPerson(list[i].Golosa) < RezultForPerson(list[j].Golosa))
//                {
//                    Sportsman person_now = list[j]; // меняем
//                    list[j] = list[i]; // местами
//                    list[i] = person_now; // игроков
//                }
//        }
//        return list;
//    }

//    protected void Sorevnovan(Sportsman[] sportsmen)
//    {
//        Sportsman[] list_sort = Sort(sportsmen);
//        Print_table(list_sort);
//    }

//    protected abstract void Print_table(Sportsman[] sort_list);
//}

//class Jump3 : JumpWater
//{
//    public Jump3(string dist, Sportsman[] sportsmen, double[] indexx) : base(sportsmen, dist, indexx)
//    {
//        this.sportsmen = sportsmen;
//        this.dist = dist;
//        Sorevnovan(sportsmen);
//    }

//    protected override void Print_table(Sportsman[] sort_list)
//    {
//        Console.WriteLine(dist);
//        for (int i = 0; i < sort_list.Length; i++)
//        {
//            Console.Write($"{i + 1} место:");
//            Console.Write($"имя: {sort_list[i].Name} результат: {RezultForPerson(sort_list[i].Golosa)}");
//            Console.WriteLine();
//        }
//        Console.WriteLine();
//    }
//}

//class Jump5 : JumpWater
//{
//    public Jump5(string dist, Sportsman[] sportsmen, double[] indexx) : base(sportsmen, dist, indexx)
//    {
//        this.sportsmen = sportsmen;
//        this.dist = dist;
//        Sorevnovan(sportsmen);
//    }
//    protected override void Print_table(Sportsman[] sort_list)
//    {
//        Console.WriteLine(dist);
//        for (int i = 0; i < sort_list.Length; i++)
//        {
//            Console.Write($"{i + 1} место:");
//            Console.Write($"имя: {sort_list[i].Name} результат: {RezultForPerson(sort_list[i].Golosa)}");
//            Console.WriteLine();
//        }
//        Console.WriteLine();
//    }
//}


//public class Program
//{
//    public static void Main(string[] args)
//    {
//        string dist = Console.ReadLine();
//        int n = int.Parse(Console.ReadLine());
//        Sportsman[] peoplelist = new Sportsman[n];

//        double[] Indexx = new double[4];
//        for (int i = 0; i < 4; i++)
//        {
//            Indexx[i] = double.Parse(Console.ReadLine());
//        }

//        for (int i = 0; i < n; i++) //каждый спортсмен
//        {
//            string name_people = Console.ReadLine();
//            int[,] golosa_jumps = new int[4, 7];
//            for (int j = 0; j < 4; j++) //для каждого прыжка
//            {
//                for (int s = 0; s < 7; s++)
//                {
//                    int golos = int.Parse(Console.ReadLine());
//                    golosa_jumps[j, s] = golos;
//                }
//            }
//            Sportsman person = new Sportsman(name_people, golosa_jumps);
//            peoplelist[i] = person;
//        }

//        Jump3 Sorev = new Jump3(dist, peoplelist, Indexx);

//        string dist2 = Console.ReadLine();
//        int n2 = int.Parse(Console.ReadLine());
//        Sportsman[] peoplelist2 = new Sportsman[n2];

//        double[] Indexx2 = new double[4];
//        for (int i = 0; i < 4; i++)
//        {
//            Indexx2[i] = double.Parse(Console.ReadLine());
//        }

//        for (int i = 0; i < n2; i++) //каждый спортсмен
//        {
//            string name_people2 = Console.ReadLine();
//            int[,] golosa_jumps2 = new int[4, 7];
//            for (int j = 0; j < 4; j++) //для каждого прыжка
//            {
//                for (int s = 0; s < 7; s++)
//                {
//                    int golos2 = int.Parse(Console.ReadLine());
//                    golosa_jumps2[j, s] = golos2;
//                }
//            }
//            Sportsman person = new Sportsman(name_people2, golosa_jumps2);
//            peoplelist2[i] = person;
//        }

//        Jump5 Sorev2 = new Jump5(dist2, peoplelist2, Indexx2);

//    }
//}

