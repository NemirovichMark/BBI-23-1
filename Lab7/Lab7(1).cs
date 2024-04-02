using System;
using System.Collections.Generic;

// Создание абстрактного класса Student
abstract class Student
{
    // Объявление защищенных полей: имя студента, оценка, количество пропусков
    protected string name;
    protected int mark;
    protected int miss;

    // Определение свойств для доступа к полям
    public string Name => name;
    public int Mark => mark;
    public int Miss => miss;

    // Конструктор класса Student
    public Student(string name, int mark, int miss)
    {
        // Инициализация полей
        this.name = name;
        this.miss = miss;
        // Проверка на допустимость оценки (0-5)
        if (mark >= 0 && mark <= 5)
        {
            this.mark = mark;
        }
    }

    // Абстрактный метод для печати информации о студенте
    public abstract void PrintInfo();
}

// Создание производного класса ComputerScienceStudent от Student
class ComputerScienceStudent : Student
{
    // Конструктор класса ComputerScienceStudent, вызывает конструктор базового класса
    public ComputerScienceStudent(string name, int mark, int miss) : base(name, mark, miss)
    {
    }

    // Переопределение метода PrintInfo() для ComputerScienceStudent
    public override void PrintInfo()
    {
        // Печать информации о студенте, если его оценка равна 2
        if (Mark == 2)
        {
            Console.WriteLine($"Computer Science Student: Имя: {Name} Кол-во пропусков: {Miss}");
        }
    }
}

// Создание производного класса MathStudent от Student
class MathStudent : Student
{
    // Конструктор класса MathStudent, вызывает конструктор базового класса
    public MathStudent(string name, int mark, int miss) : base(name, mark, miss)
    {
    }

    // Переопределение метода PrintInfo() для MathStudent
    public override void PrintInfo()
    {
        // Печать информации о студенте, если его оценка равна 2
        if (Mark == 2)
        {
            Console.WriteLine($"Math Student: Имя: {Name} Кол-во пропусков: {Miss}");
        }
    }
}

class Program
{
    // Основной метод программы
    static void Main()
    {
        // Создание списка студентов по информатике
        List<Student> computerScienceStudents = new List<Student>
        {
            // Инициализация объектов ComputerScienceStudent с различными данными
            new ComputerScienceStudent("Misha", 2, 3),
            new ComputerScienceStudent("Pasha", 2, 9),
            new ComputerScienceStudent("Tigran", 2, 6),
            new ComputerScienceStudent("Sofia", 5, 1),
            new ComputerScienceStudent("Ivan", 0, 20)
        };

        // Создание списка студентов по математике
        List<Student> mathStudents = new List<Student>
        {
            // Инициализация объектов MathStudent с различными данными
            new MathStudent("Alex", 2, 5),
            new MathStudent("Anna", 2, 2),
            new MathStudent("Viktor", 3, 3),
            new MathStudent("Maria", 4, 4),
            new MathStudent("Nikolai", 2, 7)
        };

        // Печать заголовка раздела "Студенты по информатике"
        Console.WriteLine("Computer Science Students:");
        // Перебор студентов по информатике и вызов метода PrintInfo() для каждого
        foreach (var student in computerScienceStudents)
        {
            student.PrintInfo();
        }

        // Печать заголовка раздела "Студенты по математике"
        Console.WriteLine("\nMath Students:");
        // Перебор студентов по математике и вызов метода PrintInfo() для каждого
        foreach (var student in mathStudents)
        {
            student.PrintInfo();
        }
    }
}
