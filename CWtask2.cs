/* Переделайте структуру в абстрактный класс и создайте наследников: Pupil и Student. У школьников добавьте поля: класс и специализация. У студентов: группа, должник и уникальный номер студ билета.
    Если студент получает за сессию хотя бы 1 двойку, он становится должником. В основной программе оценки школьников задать матрицей 3 на 5, у студентов 2 на 5. Вывести отдельныи таблицами
    всех учеников школы по убыванию среднего балла, всех студентов по убыванию среднего балла. Объединить учащихся в один массив и вевысти всех краснодипломников в одной таблице: и школьников, и студентов.*/
using System;
abstract class Disciple
{
    public string Name;
    public int Age;
    protected int[][] Marks;
    protected double AverageMark;

    public Disciple(string name, int age, int[][] marks)
    {
        Name = name;
        Age = age;
        Marks = marks;
        CalculateAverageMark();
    }

    protected abstract void CalculateAverageMark();

    public virtual void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Average Mark: {AverageMark}");
    }
}

class Pupil : Disciple
{
    public string ClassName;
    public string Specialization;

    public Pupil(string name, int age, int[][] marks, string className, string specialization) : base(name, age, marks)
    {
        ClassName = className;
        Specialization = specialization;
    }

    protected override void CalculateAverageMark()
    {
        double sum = 0;
        int count = 0;
        foreach (int[] row in Marks)
        {
            foreach (int mark in row)
            {
                sum += mark;
                count++;
            }
        }
        AverageMark = count > 0 ? sum / count : 0;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Pupil: {Name}, Age: {Age}, Class: {ClassName}, Specialization: {Specialization}, Average Mark: {AverageMark}");
    }
}

class Student : Disciple
{
    public string Group;

    public Student(string name, int age, int[][] marks, string group) : base(name, age, marks)
    {
        Group = group;
    }

    protected override void CalculateAverageMark()
    {
        double sum = 0;
        int count = 0;
        foreach (int[] row in Marks)
        {
            foreach (int mark in row)
            {
                sum += mark;
                count++;
            }
        }
        AverageMark = count > 0 ? sum / count : 0;
    }

    class Program
    {
        static void Main()
        {
            int[][] pupilMarks = new int[][]
            {
            new int[] {4, 5, 5, 3, 4},
            new int[] {3, 4, 5, 5, 4},
            new int[] {5, 5, 5, 4, 5}
            };

            int[][] studentMarks = new int[][]
            {
            new int[] {4, 5, 4, 3, 4},
            new int[] {3, 3, 2, 5, 4}
            };

            Pupil pupil1 = new Pupil("Карина", 15, pupilMarks, "9A");
            Pupil pupil2 = new Pupil("Елизавета", 14, pupilMarks, "8B");

            Student student1 = new Student("Владимир", 20, studentMarks, "IT-101");
            Student student2 = new Student("Егор", 21, studentMarks, "Biology-202");

            Pupil[] pupils = new Pupil[] { pupil1, pupil2 };
            Student[] students = new Student[] { student1, student2 };
        }
    }
}