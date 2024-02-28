# region 1_4
//using System;
//using System.Collections.Generic;
//using System.Text;

//public class Program
//{
//    struct Ychastnik
//    {
//        private string name;
//        private int id;
//        private int _bestres;

//        public int Result { get { return _bestres; } }

//        public Ychastnik(string name, int i, int bestres)
//        {
//            this.name = name;
//            id = i;
//            _bestres = bestres;
//        }

//        public int ressec
//        {
//            get { return _bestres; }
//            set
//            {
//                if (value > _bestres) _bestres = value;
//            }
//        }

//        public void Info()
//        {
//            Console.WriteLine($"результат: {_bestres} имя участника: {name} ");
//        }

//    }

//    static Ychastnik[] Sort(Ychastnik[] list)
//    {
//        for (int i = 0; i < list.Length; i++)
//        {
//            for (int j = i; j < list.Length; j++)
//                if (list[i].Result < list[j].Result)
//                {
//                    Ychastnik person_now = list[j];
//                    list[j] = list[i]; 
//                    list[i] = person_now; 
//                }
//        }
//        return list;
//    }


//    public static void Main(string[] args)
//    {
//        int n = int.Parse(Console.ReadLine());
//        Ychastnik[] peoplelist = new Ychastnik[n];

//        for (int i = 0; i < n; i++)
//        {
//            string name_people = Console.ReadLine();
//            int firstres = int.Parse(Console.ReadLine());
//            int secondres = int.Parse(Console.ReadLine());

//            Ychastnik Person = new Ychastnik(name_people, i + 1, firstres);
//            Person.ressec = secondres;

//            peoplelist[i] = Person;
//        }

//        peoplelist = Sort(peoplelist);

//        for (int i = 0; i < n; i++)
//        {
//            Console.Write($"{i + 1} занятое место:"); ;
//            peoplelist[i].Info();
//            Console.WriteLine();
//        }
//        Console.WriteLine();
//        Console.ReadLine();
//    }
//}
#endregion

# region 2_4
//using System;
//using System.Collections.Generic;
//using System.Text;

//struct Sportsman
//{
//    private string name;
//    private double jump1;
//    private double jump2;
//    private double jump3;
//    private double jump4;

//    public Sportsman(string name, double one, double two, double three, double four)
//    {
//        this.name = name;
//        jump1 = one;
//        jump2 = two;
//        jump3 = three;
//        jump4 = four;
//    }


//    public double endresult()
//    {
//        return jump1 + jump2 + jump3 + jump4;
//    }

//    public void Info()
//    {
//        Console.WriteLine($"результат: {jump1 + jump2 + jump3 + jump4} имя: {name} ");
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

//    static Sportsman[] Sort(Sportsman[] list)
//    {
//        for (int i = 0; i < list.Length; i++)
//        {
//            for (int j = i; j < list.Length; j++)
//                if (list[i].endresult() < list[j].endresult())
//                {
//                    Sportsman pers = list[j]; 
//                    list[j] = list[i]; 
//                    list[i] = pers; 
//                }
//        }
//        return list;
//    }


//    public static void Main(string[] args)
//    {
//        int n = int.Parse(Console.ReadLine());
//        Sportsman[] peoplelist = new Sportsman[n];

//        for (int i = 0; i < n; i++)
//        {
//            string name_people = Console.ReadLine();
//            double[] resjumps = new double[4];
//            for (int j = 0; j < 4; j++) 
//            {
//                double koef = double.Parse(Console.ReadLine()); 
//                int[] golosa = new int[7]; 
//                for (int s = 0; s < 7; s++)
//                {
//                    int golos = int.Parse(Console.ReadLine());
//                    golosa[s] = golos;
//                }

//                golosa = SortedGolosa(golosa, 7); 
//                int sum_golos = 0;
//                for (int k = 1; k < 6; k++)
//                {
//                    sum_golos += golosa[k];
//                }

//                resjumps[j] = sum_golos * koef; 
//            }

//            Sportsman pers = new Sportsman(name_people, resjumps[0], resjumps[1], resjumps[2], resjumps[3]);
//            peoplelist[i] = pers;
//        }

//        peoplelist = Sort(peoplelist);

//        for (int i = 0; i < n; i++)
//        {
//            Console.Write($"{i + 1} место:"); ;
//            peoplelist[i].Info();
//            Console.WriteLine();
//        }
//        Console.WriteLine();
//        Console.ReadLine();
//    }
//}
#endregion

#region 3_4
using System;
using System.Collections.Generic;
using System.Text;

public class Program
{
    struct Ychastnik
    {
        private string name;
        private int result;

        public int Result { get { return result; } }

        public Ychastnik(string name, int res)
        {
            this.name = name;
            result = res;
        }

        public void Info()
        {
            Console.WriteLine($"результат: {result} имя: {name} ");
        }

    }

    static Ychastnik[] Sort(Ychastnik[] list)
    {
        for (int i = 0; i < list.Length; i++)
        {
            for (int j = i; j < list.Length; j++)
                if (list[i].Result < list[j].Result)
                {
                    Ychastnik person_now = list[j]; 
                    list[j] = list[i]; 
                    list[i] = person_now;
                }
        }
        return list;
    }


    public static void Main(string[] args)
    {
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        Ychastnik[] onegr = new Ychastnik[n1];
        Ychastnik[] twogr = new Ychastnik[n2];
        Ychastnik[] allgr = new Ychastnik[n2 + n1];

        for (int i = 0; i < n1; i++)
        {
            string name_ = Console.ReadLine();
            int result_ = int.Parse(Console.ReadLine());

            Ychastnik Person = new Ychastnik(name_, result_);

            onegr[i] = Person;
            allgr[i] = Person;
        }

        for (int i = 0; i < n2; i++)
        {
            string name_ = Console.ReadLine();
            int result_ = int.Parse(Console.ReadLine());

            Ychastnik Person = new Ychastnik(name_, result_);

            twogr[i] = Person;
            allgr[i + n1] = Person;
        }

        onegr = Sort(onegr);
        twogr = Sort(twogr);
        allgr = Sort(allgr);

        Console.WriteLine("1 группа:");
        for (int i = 0; i < n1; i++)
        {
            Console.Write($"{i + 1} место:"); ;
            onegr[i].Info();
            Console.WriteLine();
        }
        Console.WriteLine();

        Console.WriteLine("2 группа:");
        for (int i = 0; i < n2; i++)
        {
            Console.Write($"{i + 1} место:"); ;
            twogr[i].Info();
            Console.WriteLine();
        }
        Console.WriteLine();

        Console.WriteLine("все участники:");
        for (int i = 0; i < n1 + n2; i++)
        {
            Console.Write($"{i + 1} место:"); ;
            allgr[i].Info();
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.ReadLine();
    }
}
#endregion
















