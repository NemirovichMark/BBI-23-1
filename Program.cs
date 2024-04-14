
////1уровень 2н
//using System;
//using System.Collections.Generic;

//abstract class Runner
//{
//    protected string _surname;
//    protected internal double _result;
//    protected string _coach;
//    protected int _group;

//    public Runner(string surname, double result, string coach, int group)
//    {
//        _surname = surname;
//        _result = result;
//        _coach = coach;
//        _group = group;
//    }

//    public abstract void DisplayInfo();
//}

//class Runner100m : Runner
//{
//    public Runner100m(string surname, double result, string coach, int group) : base(surname, result, coach, group) { }

//    public override void DisplayInfo()
//    {
//        if (_result < 100)
//        {
//            Console.WriteLine($"Фамилия {_surname} \t Результат {_result:f2} \t Преподаватель {_coach} \t Группа {_group} \t Норматив выполнен");
//        }
//        else
//        {
//            Console.WriteLine($"Фамилия {_surname} \t Результат {_result:f2} \t Преподаватель {_coach} \t Группа {_group}");
//        }
//    }
//}

//class Runner500m : Runner
//{
//    public Runner500m(string surname, double result, string coach, int group) : base(surname, result, coach, group) { }

//    public override void DisplayInfo()
//    {
//        if (_result < 500)
//        {
//            Console.WriteLine($"Фамилия {_surname} \t Результат {_result:f2} \t Преподаватель {_coach} \t Группа {_group} \t Норматив выполнен");
//        }
//        else
//        {
//            Console.WriteLine($"Фамилия {_surname} \t Результат {_result:f2} \t Преподаватель {_coach} \t Группа {_group}");
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        List<Runner> runners = new List<Runner>
//        {
//            new Runner100m("Иванова", 100, "Федотов", 1),
//            new Runner500m("Иванова", 100, "Федотов", 1),
//            new Runner100m("Петрова", 155, "Болт", 2),
//            new Runner500m("Петрова", 155, "Болт", 2),
//            new Runner100m("Сидорова", 999, "Неймар", 3),
//            new Runner500m("Сидорова", 999, "Неймар", 3),
//            new Runner100m("Кузнецова", 85, "Месси", 4),
//            new Runner500m("Кузнецова", 85, "Месси", 4),
//            new Runner100m("Макарова", 10, "Роналду", 5),
//            new Runner500m("Макарова", 10, "Роналду", 5)
//        };

//        Console.WriteLine("\nРезультаты забега на 100 м:");
//        foreach (var runner in runners)
//        {
//            if (runner is Runner100m)
//            {
//                runner.DisplayInfo();
//            }
//        }

//        Console.WriteLine("\nРезультаты забега на 500 м:");
//        foreach (var runner in runners)
//        {
//            if (runner is Runner500m)
//            {
//                runner.DisplayInfo();
//            }
//        }

//        int sr100 = 0;
//        int sr500 = 0;
//        foreach (var runner in runners)
//        {
//            if (runner is Runner100m && runner._result < 100)
//            {
//                sr100++;
//            }

//            if (runner is Runner500m && runner._result < 500)
//            {
//                sr500++;
//            }
//        }

//        Console.WriteLine($"\nСуммарное количество участников, выполнивших норматив на 100 м: {sr100}");
//        Console.WriteLine($"Суммарное количество участников, выполнивших норматив на 500 м: {sr500}");
//    }
//}










////2уровень 1номер
//class Person
//{
//    private string Name;

//    public Person(string name)
//    {
//        Name = name;
//    }

//    public string GetName()
//    {
//        return Name;
//    }
//}

//class Student : Person
//{
//    private string StudentId;
//    private double[] Grades;
//    private double SrGrade;

//    public Student(string fullName, string studentId, double[] grades) : base(fullName)
//    {
//        StudentId = studentId;
//        Grades = grades;

//        double sum = 0;
//        foreach (double grade in grades)
//        {
//            sum += grade;
//        }

//        SrGrade = sum / grades.Length;
//    }

//    public double GetsrGrade()
//    {
//        return SrGrade;
//    }

//    public void DisplayInfo()
//    {
//        Console.WriteLine("ФИО: {0}\t № студ. билета: {1}\t Средний балл: {2}", GetName(), StudentId, GetsrGrade());
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Student[] students = new Student[5];
//        students[0] = new Student("Иванов", "001", new double[] { 3.0, 5.0, 2.0, 3.0 });
//        students[1] = new Student("Петров", "002", new double[] { 5.0, 4.0, 5.0, 3.0 });
//        students[2] = new Student("Сидоров", "003", new double[] { 5.0, 4.0, 5.0, 5.0 });
//        students[3] = new Student("Сидоров2", "004", new double[] { 5.0, 5.0, 5.0, 5.0 });
//        students[4] = new Student("Сидоров3", "005", new double[] { 5.0, 3.0, 5.0, 5.0 });

//        foreach (Student student in students)
//        {
//            student.DisplayInfo();
//        }

//        for (int i = 0; i < students.Length - 1; i++)
//        {
//            for (int j = 0; j < students.Length - 1 - i; j++)
//            {
//                if (students[j].GetsrGrade() < students[j + 1].GetsrGrade())
//                {
//                    Student temp = students[j];
//                    students[j] = students[j + 1];
//                    students[j + 1] = temp;
//                }
//            }
//        }

//        Console.WriteLine();

//        foreach (Student student in students)
//        {
//            if (student.GetsrGrade() >= 4)
//            {
//                student.DisplayInfo();
//            }
//        }
//    }
//}









////3 уровень н2
//using System;

//class FootballTeam
//{
//    public string ClubName { get; protected set; }
//    public int Ball { get; protected set; }

//    public FootballTeam(string clubName, int points)
//    {
//        ClubName = clubName;
//        Ball = points;
//    }

//    public virtual void DisplayInfo()
//    {
//        Console.WriteLine($"{ClubName} {this.GetType().Name}: {Ball} баллов");
//    }
//}

//class WomenFootballTeam : FootballTeam
//{
//    public WomenFootballTeam(string clubName, int points) : base(clubName, points)
//    {
//    }
//}

//class MenFootballTeam : FootballTeam
//{
//    public MenFootballTeam(string clubName, int points) : base(clubName, points)
//    {
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        FootballTeam[] womenClubs = new FootballTeam[]
//        {
//            new WomenFootballTeam("Spartak", 15),
//            new WomenFootballTeam("Zenit", 12),
//            new WomenFootballTeam("Loko", 18),
//            new WomenFootballTeam("CSKA", 20),
//            new WomenFootballTeam("Dynamo", 16),
//            new WomenFootballTeam("Torpedo", 14)
//        };

//        FootballTeam[] menClubs = new FootballTeam[]
//        {
//            new MenFootballTeam("Anzhi", 22),
//            new MenFootballTeam("Ural", 19),
//            new MenFootballTeam("Rubin", 17),
//            new MenFootballTeam("Arsenal", 21),
//            new MenFootballTeam("Fakel", 16),
//            new MenFootballTeam("Krasnodar", 18)
//        };

//        FootballTeam[] combClubs = new FootballTeam[12];
//        int i = 0;
//        foreach (FootballTeam club in womenClubs)
//        {
//            combClubs[i] = club;
//            i++;
//        }
//        foreach (FootballTeam club in menClubs)
//        {
//            combClubs[i] = club;
//            i++;
//        }

//        Console.WriteLine("Топ команд):");
//        Sort(combClubs);

//        for (int j = 0; j < combClubs.Length; j++)
//        {
//            Console.WriteLine($"{j + 1}. ");
//            combClubs[j].DisplayInfo();
//        }
//    }

//    static void Sort(FootballTeam[] a)
//    {
//        int n = a.Length;
//        for (int i = 0; i < n - 1; i++)
//        {
//            for (int j = 0; j < n - i - 1; j++)
//            {
//                if (a[j].Ball < a[j + 1].Ball)
//                {
//                    FootballTeam temp = a[j];
//                    a[j] = a[j + 1];
//                    a[j + 1] = temp;
//                }
//            }
//        }
//    }
//}