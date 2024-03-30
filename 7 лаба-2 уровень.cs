using System;

class Person
{
    private string _fullName;

    public string FullName => _fullName;

    public Person(string fullName)
    {
        _fullName = fullName;
    }
}

class Student : Person
{
    private int _studentId;

    private double _mGrade;
    private double _pGrade;
    private double _rGrade;

    public int StudentId => _studentId;
    public double MGrade => _mGrade;
    public double PGrade => _pGrade;
    public double RGrade => _rGrade;
    public double AverageGrade => (_mGrade + _pGrade + _rGrade) / 3;

    public Student(string fullName, int studentId, double mGrade, double pGrade, double rGrade) : base(fullName)
    {
        _studentId = studentId;
        _mGrade = mGrade;
        _pGrade = pGrade;
        _rGrade = rGrade;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student[] students = new Student[5];

        students[0] = new Student("Иванов Иван Иванович", 12345, 4, 5, 4);
        students[1] = new Student("Губеев Виталий Денисович", 23456, 4, 5, 4);
        students[2] = new Student("Енукидзе Гиви Гивиевич", 34567, 3, 4, 5);
        students[3] = new Student("Жуков Андрей Александрович", 45678, 4, 3, 5);
        students[4] = new Student("Капелин Илья Викторович", 56789, 5, 5, 5);

        Array.Sort(students, (x, y) => y.AverageGrade.CompareTo(x.AverageGrade));

        Console.WriteLine("Список успешно сдавших экзамены студентов, отсортированный по убыванию среднего балла:");
        Console.WriteLine("|   ФИО               |  № студ. билета |  Средний балл |");
        Console.WriteLine("|---------------------|-----------------|----------------|");

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"| {students[i].FullName,-20} | {students[i].StudentId,-15} | {students[i].AverageGrade,-13:F2} |");
        }
    }
}