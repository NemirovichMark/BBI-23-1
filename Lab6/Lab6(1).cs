using System;

struct Student
{
    private string name;
    private int mark;
    private int miss;

    public string Name => name;
    public int Mark => mark;
    public int Miss => miss;

    public Student(string name, int mark, int miss)
    {
        this.name = name;
        this.miss = miss;
        if (mark != 1 & mark >= 0 & mark <= 5)
        {
            this.mark = mark;
        }
    }

    public void PrintInfo()
    {
        if (Mark == 2)
        {
            Console.WriteLine($"Имя: {Name} Кол-во пропусков: {Miss}");
        }
    }
}

class Program
{
    static void Main()
    {
        Student[] students = new Student[]
        {
            new Student("Misha", 2, 3),
            new Student("Pasha", 2, 9),
            new Student("Tigran", 2, 6),
            new Student("Sofia", 5, 1),
            new Student("Ivan", 0, 20)
        };

        Array.Sort(students, (x, y) => y.Miss.CompareTo(x.Miss));

        foreach (var student in students)
        {
            student.PrintInfo();
        }
    }
}