using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using ProtoBuf;
[XmlInclude(typeof(MathStudent))]
[XmlInclude(typeof(ComputerScienceStudent))]
[ProtoInclude(999, typeof(MathStudent))]
[ProtoInclude(998, typeof(ComputerScienceStudent))]

// Создание абстрактного класса Student
[Serializable]
[ProtoContract]
public abstract class Student
{
    // Объявление защищенных полей: имя студента, оценка, количество пропусков
    protected string name;
    protected int mark;
    protected int miss;

    // Определение свойств для доступа к полям
    [XmlElement(ElementName = "Name")]
    [ProtoMember(1)]
    public string Name { get { return name; } set { name = value; } }

    [XmlElement(ElementName = "Mark")]
    [ProtoMember(2)]
    public int Mark { get { return mark; } set { mark = value; } }

    [XmlElement(ElementName = "Miss")]
    [ProtoMember(3)]
    public int Miss { get { return miss; } set { miss = value; } }

    // Конструктор класса Student
    public Student() { }
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
[Serializable]
[ProtoContract]
public class ComputerScienceStudent : Student
{
    // Конструктор класса ComputerScienceStudent, вызывает конструктор базового класса
    public ComputerScienceStudent() { }
    public ComputerScienceStudent(string name, int mark, int miss) : base(name, mark, miss) { }

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
[Serializable]
[ProtoContract]
public class MathStudent : Student
{
    // Конструктор класса MathStudent, вызывает конструктор базового класса
    public MathStudent() { }
    public MathStudent(string name, int mark, int miss) : base(name, mark, miss) { }

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

        List<Student> students = computerScienceStudents;
        students = students.Concat(mathStudents).ToList();

        Stream file = File.Create(@"data\students.json");
        Stream data = JSONProcessing<Student>.Write(students);
        data.CopyTo(file);
        file.Dispose();

        file = File.Create(@"data\students.xml");
        data = XMLProcessing<Student>.Write(students);
        data.CopyTo(file);
        file.Dispose();

        file = File.Create(@"data\students.bin");
        data = BinProcessing<Student>.Write(students);
        data.CopyTo(file);
        file.Dispose();

        students = JSONProcessing<Student>.Read(new FileStream(@"data\students.json", FileMode.Open));
        Console.WriteLine("JSON файл:");
        for (int i = 0; i < students.Count; i++)
        {
            students[i].PrintInfo();
        }

        students = XMLProcessing<Student>.Read(new FileStream(@"data\students.xml", FileMode.Open));
        Console.WriteLine("XML файл:");
        for (int i = 0; i < students.Count; i++)
        {
            students[i].PrintInfo();
        }

        students = BinProcessing<Student>.Read(new FileStream(@"data\students.bin", FileMode.Open));
        Console.WriteLine("Bin файл:");
        for (int i = 0; i < students.Count; i++)
        {
            students[i].PrintInfo();
        }
    }
}
