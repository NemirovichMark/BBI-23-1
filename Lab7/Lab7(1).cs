using System;
using System.Collections.Generic;

abstract class Student
{
    protected string name;
    protected int mark;
    protected int miss;

    public string Name => name;
    public int Mark => mark;
    public int Miss => miss;

    public Student(string name, int mark, int miss)
    {
        this.name = name;
        this.miss = miss;
        if (mark >= 0 && mark <= 5)
        {
            this.mark = mark;
        }
    }

    public abstract void PrintInfo();
}

class ComputerScienceStudent : Student
{
    public ComputerScienceStudent(string name, int mark, int miss) : base(name, mark, miss)
    {
    }

    public override void PrintInfo()
    {
        if (Mark == 2)
        {
            Console.WriteLine($"Computer Science Student: Имя: {Name} Кол-во пропусков: {Miss}");
        }
    }
}

class MathStudent : Student
{
    public MathStudent(string name, int mark, int miss) : base(name, mark, miss)
    {
    }

    public override void PrintInfo()
    {
        if (Mark == 2)
        {
            Console.WriteLine($"Math Student: Имя: {Name} Кол-во пропусков: {Miss}");
        }
    }
}

class Program
{
    static void Main()
    {
        List<Student> computerScienceStudents = new List<Student>
        {
            new ComputerScienceStudent("Misha", 2, 3),
            new ComputerScienceStudent("Pasha", 2, 9),
            new ComputerScienceStudent("Tigran", 2, 6),
            new ComputerScienceStudent("Sofia", 5, 1),
            new ComputerScienceStudent("Ivan", 0, 20)
        };

        List<Student> mathStudents = new List<Student>
        {
            new MathStudent("Alex", 2, 5),
            new MathStudent("Anna", 2, 2),
            new MathStudent("Viktor", 3, 3),
            new MathStudent("Maria", 4, 4),
            new MathStudent("Nikolai", 2, 7)
        };

        Console.WriteLine("Computer Science Students:");
        foreach (var student in computerScienceStudents)
        {
            student.PrintInfo();
        }

        Console.WriteLine("\nMath Students:");
        foreach (var student in mathStudents)
        {
            student.PrintInfo();
        }
    }
}
