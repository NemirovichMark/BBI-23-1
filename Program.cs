//// See https://aka.ms/new-console-template for more information

//using System;
////Первый уровень номер 2
//struct Sportsmen
//{
//    public string famile;
//    public double rez;
//    public string prep;
//    public int group;
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
// 155, 99, 85, 101};
//        int ss = 0;
//        int[]n= new int[] {1,2,3,4,5};
//        string[] re = new string[] { "Фетодов", "Болт","Неймар","Месси","Роналду" };
//        for (int i = 0; i < sp.Length; i++)
//        {
//            sp[i].famile = s[i];
//            sp[i].rez = r[i];
//            sp[i].prep = re[i];
//            sp[i].group = n[i];
//            Console.WriteLine(
//            "Фамилия {0} \t Результат {1:f2} \t преподаватель {2:f3} \t группа {3:f4}",
//            sp[i].famile, sp[i].rez, sp[i].prep, sp[i].group);
//        }

       
//        for (int i = 0; i < sp.Length -1; i++)
//        {
//            double amax = sp[i].rez;
//            int imax = i;
//            for (int j = i + 1; j < sp.Length; j++)
//            {
//                if (sp[j].rez > amax)
//                {
//                    amax = sp[j].rez;
//                    imax = j;
//                }
//            }
            
//        Sportsmen temp;
//            temp = sp[imax];
//            sp[imax] = sp[i];
//            sp[i] = temp;
            
            
//        }
//        Console.WriteLine();
//        for (int i = 0; i < sp.Length; i++)
//        {
           
//            int nn = 0;
//            int norma = 100;
//            if (sp[i].rez <= norma)
//            {
//                nn++;
//                Console.WriteLine("Фамилия {0} \t Результат {1:f2} \t преподаватель {2:f3} \t группа {3:f4} \t норматив выполнен",
//                sp[i].famile, sp[i].rez, sp[i].prep, sp[i].group);
                
               
//            }
//            else
//                Console.WriteLine("Фамилия {0} \t Результат {1:f2} \t преподаватель {2:f3} \t группа {3:f4} \t ",
//                sp[i].famile, sp[i].rez, sp[i].prep, sp[i].group);
            


//        }
//        for (int i = 0; i < sp.Length; i++)
//        {
            
//            int nn = 0;
//            int norma = 100;
//            if (sp[i].rez < norma)
//            {
//                nn++;
//            }
//            ss = ss + nn;
        
           
        
//        }Console.WriteLine(($"\nСуммарное количество участниц, выполнивших норматив:{ss}"));


//}
//}

////второй уровень номер 1
//using System;

//class Program
//{
//    struct Struct1
//    {
//        public string famile;
//        public double[] x;
//        public double sred;
//        public Struct1(string famile1, double[] x1)

//        {
//            sred = 0;
//            famile = famile1;
//            x = x1;
//            for (int i = 0; i < 4; i++)
//                sred += x[i];
//            sred /= 4;
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
//            Console.WriteLine(
//            "Фамилия {0}\t Средний балл {1,4:f2}",
//            cl[i].famile, cl[i].sred);
//        for (int i = 0; i < cl.Length - 1; i++)
//        {
//            double amax = cl[i].sred;
//            int imax = i;
//            for (int j = i + 1; j < cl.Length; j++)
//            {
//                if (cl[j].sred > amax)
//                {
//                    amax = cl[j].sred;
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
//            if (cl[i].sred >= 4)
//                Console.WriteLine("Фамилия {0}\t " + "Средний балл {1,4:f2}", cl[i].famile, cl[i].sred);
//        }
//    }
//}
////третий уровень номер 2
//using System;

//public struct Team
//{
//    public string Name;

//}

//class Program
//{
//    static void Main()
//    {
//        Team[] teams = new Team[24];


//        for (int i = 0; i < 24; i++)
//        {
//            teams[i].Name = "Команда " + (i + 1).ToString();
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
//    }
//}