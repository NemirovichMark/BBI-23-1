// See https://aka.ms/new-console-template for more information

//using System;
//using System.Collections.Generic;
//using System.Diagnostics.Metrics;
//using System.Xml.Linq;
//struct Sportsmen
//{
//    private string _famile;
//    private double _rez;
//    private string _prep;
//    public string Famile => _famile;
//    public double Rez => _rez;

//    public string Prep => _prep;
//    private int _group;
//    public int Group => _group;
//    public Sportsmen(string famile, double rez, string prep, int group)
//    {
//        _famile = famile;
//        _rez = rez;
//        _prep = prep;
//        _group = group;
//    }

//}
//class Program
//{
//    static void Main()
//    {
//        Sportsmen[] sp = new Sportsmen[5];
//        string[] s = new string[] {
// "Иванова", "Петрова", "Сидорова",
// "Кузнецова", "Макарова"};
//        double[] r = new double[] {15,
// 155, 99, 85, 10};
//        int ss = 0;
//        int[] n = new int[] { 1, 2, 3, 4, 5 };
//        string[] re = new string[] { "Фетодов", "Болт", "Неймар", "Месси", "Роналду" };
//        for (int i = 0; i < sp.Length; i++)
//        {

//            sp[i] = new Sportsmen(s[i], r[i], re[i], n[i]);
//            Console.WriteLine(
//            "Фамилия {0} \t Результат {1:f2} \t преподаватель {2:f3} \t группа {3:f4}",
//            s[i], r[i], re[i], n[i]);
//        }


//        for (int i = 0; i < sp.Length - 1; i++)
//        {
//            Sportsmen amax = sp[i];
//            int imax = i;
//            for (int j = i + 1; j < sp.Length; j++)
//            {
//                if (sp[j].Rez > amax.Rez)
//                {
//                    amax = sp[j];
//                    imax = j;
//                }
//            }

//            Sportsmen temp;
//            temp = sp[imax];
//            sp[imax] = sp[i];
//            sp[i] = temp;


//        }
//        Console.WriteLine();
//        for (int i = 0; i < sp.Length; i++)
//        {

//            int nn = 0;
//            int norma = 100;
//            if (sp[i].Rez < norma)
//            {
//                nn++;
//                Console.WriteLine("Фамилия {0} \t Результат {1:f2} \t преподаватель {2:f3} \t группа {3:f4} \t норматив выполнен",
//                sp[i].Famile, sp[i].Rez, sp[i].Prep, sp[i].Group);


//            }
//            else
//                Console.WriteLine("Фамилия {0} \t Результат {1:f2} \t преподаватель {2:f3} \t группа {3:f4} \t ",
//                 sp[i].Famile, sp[i].Rez, sp[i].Prep, sp[i].Group);



//        }
//        for (int i = 0; i < sp.Length; i++)
//        {

//            int nn = 0;
//            int norma = 100;
//            if (r[i] < norma)
//            {
//                nn++;
//            }
//            ss = ss + nn;



//        }
//        Console.WriteLine(($"\nСуммарное количество участниц, выполнивших норматив:{ss}"));


//    }
//}

////второй уровень номер 1
//using System;

//class Program
//{
//    struct Struct1
//    {
//        private string _famile;
//        public string Famile => _famile;

//        private double[] _x;
//        public double[] X => _x;
//        private double _sred;
//        public double Sred => _sred;

//        public Struct1(string famile1, double[] x1)

//        {
//            _sred = 0;
//            _famile = famile1;
//            _x = x1;
//            for (int i = 0; i < 4; i++)
//                _sred += _x[i];

//            _sred /= 4;
//        }

//    }

//    static void Main(string[] args)
//    {

//        Struct1[] cl = new Struct1[5];
//        cl[0] = new Struct1("Иванов",
//        new double[] { 3.0, 5.0, 2.0, 3.0 });
//        cl[1] = new Struct1("Петров",
//        new double[] { 5.0, 4.0, 5.0, 3.0 });
//        cl[2] = new Struct1("Сидоров",
//        new double[] { 5.0, 4.0, 5.0, 5.0 });
//        cl[3] = new Struct1("Сидоров2",
//        new double[] { 5.0, 5.0, 5.0, 5.0 });
//        cl[4] = new Struct1("Сидоров3",
//        new double[] { 5.0, 3.0, 5.0, 5.0 });
//        for (int i = 0; i < cl.Length; i++)
//        {

//            Console.WriteLine(
//            "Фамилия {0}\t Средний балл {1,4:f2}",
//            cl[i].Famile, cl[i].Sred);
//        }
//        for (int i = 0; i < cl.Length - 1; i++)
//        {
//            double amax = cl[i].Sred;
//            int imax = i;
//            for (int j = i + 1; j < cl.Length; j++)
//            {
//                if (cl[j].Sred > amax)
//                {
//                    amax = cl[j].Sred;
//                    imax = j;
//                }
//            }

//            Struct1 temp;
//            temp = cl[imax];
//            cl[imax] = cl[i];
//            cl[i] = temp;
//        }
//        Console.WriteLine();
//        for (int i = 0; i < cl.Length; i++)
//        {
//            if (cl[i].Sred >= 4)
//                Console.WriteLine("Фамилия {0}\t " + "Средний балл {1,4:f2}", cl[i].Famile, cl[i].Sred);
//        }
//    }
//}
////третий уровень номер 2
//using System;
//struct Team
//{
//    private string _name;
//    public string Name => _name;

//    public Team(string name)
//    {
//        _name = name;
//    }


//}

//class Program
//{
//    static void Main()
//    {
//        Team[] teams = new Team[24];


//        for (int i = 0; i < 24; i++)
//        {
//            teams[i] = new Team("Команда " + (i + 1).ToString());
//        }


//        Team[] group1 = new Team[12];
//        Team[] group2 = new Team[12];


//        for (int i = 0; i < 12; i++)
//        {
//            group1[i] = teams[i];
//        }

//        for (int i = 0; i < 12; i++)
//        {
//            group2[i] = teams[i + 12];
//        }


//        Team[] topTeamsG1 = new Team[6];
//        Team[] topTeamsG2 = new Team[6];

//        // Предположим, что лучшие команды - это первые 6 команд в каждой группе
//        for (int i = 0; i < 6; i++)
//        {
//            topTeamsG1[i] = group1[i];
//            topTeamsG2[i] = group2[i];
//        }


//        Console.WriteLine("Список команд участников второго этапа:");
//        Console.WriteLine("Группа 1:");

//        for (int i = 0; i < 6; i++)
//        {
//            Console.WriteLine(topTeamsG1[i].Name);
//        }

//        Console.WriteLine("Группа 2:");
//        for (int i = 0; i < 6; i++)
//        {
//            Console.WriteLine(topTeamsG2[i].Name);
//        }


//        Team[] C = new Team[12];

//        int hi = 0, j = 0, k = 0;

//        while (hi < 6 && j < 6)
//        {
//            if (String.Compare(topTeamsG1[hi].Name, topTeamsG2[j].Name) >= 0)
//            {
//                C[k] = topTeamsG1[hi];
//                hi++;
//            }
//            else
//            {
//                C[k] = topTeamsG2[j];
//                j++;
//            }
//            k++;
//        }


//        while (hi < 6)
//        {
//            C[k] = topTeamsG1[hi];
//            hi++;
//            k++;
//        }
//        while (j < 6)
//        {
//            C[k] = topTeamsG2[j];
//            j++;
//            k++;
//        }

//        Console.WriteLine("Результат объединения:");
//        foreach (Team team in C)
//        {
//            Console.WriteLine(team.Name);
//        }
//    }
//}