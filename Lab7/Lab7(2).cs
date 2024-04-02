using System;

abstract class Diving
{
    protected string disciplineName;

    public abstract string DisciplineName { get; }

    public Diving(string disciplineName)
    {
        this.disciplineName = disciplineName;
    }

    public abstract void PrintDisciplineInfo();
}

class DivingWith3M : Diving
{
    public override string DisciplineName => "Прыжки в воду с 3 метровой вышки";

    public DivingWith3M(string disciplineName) : base(disciplineName) { }

    public override void PrintDisciplineInfo()
    {
        Console.WriteLine($"Дисциплина: {DisciplineName}");
    }
}

class DivingWith5M : Diving
{
    public override string DisciplineName => "Прыжки в воду с 5 метровой вышки";

    public DivingWith5M(string disciplineName) : base(disciplineName) { }

    public override void PrintDisciplineInfo()
    {
        Console.WriteLine($"Дисциплина: {DisciplineName}");
    }
}

class Program
{
    struct Person
    {
        private string surname;
        private int[] refs;
        private Diving diving;

        public string Surname => surname;
        public int[] Refs => refs;
        public Diving Diving => diving;

        public Person(string surname, int[] refs, Diving diving)
        {
            this.surname = surname;
            this.refs = refs;
            this.diving = diving;
        }

        public int CalculateFinalResult()
        {
            int sum = 0;
            foreach (int reference in refs)
            {
                sum += reference;
            }
            return sum;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Фамилия: {Surname} Результат: {CalculateFinalResult()}");
            diving.PrintDisciplineInfo();
        }
    }

    static void Main()
    {
        // Создание объектов для спортсменов с присвоением атрибутов прыжков в воду
        Diving diving1 = new DivingWith3M("Дисциплина 1");
        Diving diving2 = new DivingWith5M("Дисциплина 2");
        Diving diving3 = new DivingWith3M("Дисциплина 3");
        Diving diving4 = new DivingWith5M("Дисциплина 4");
        Diving diving5 = new DivingWith3M("Дисциплина 5");

        Person[] sportik = new Person[5];
        sportik[0] = new Person("Oganezov", new int[] { 4, 5, 2, 3, 4, 3, 4, 4, 5, 5 }, diving1);
        sportik[1] = new Person("Popov", new int[] { 3, 5, 1, 4, 2, 5, 3, 3, 2, 2 }, diving2);
        sportik[2] = new Person("Machkalyan", new int[] { 1, 2, 1, 1, 3, 3, 4, 4, 2, 4 }, diving3);
        sportik[3] = new Person("Gubeeva", new int[] { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 }, diving4);
        sportik[4] = new Person("Kapelina", new int[] { 4, 5, 5, 4, 4, 5, 5, 4, 4, 5 }, diving5);

        Array.Sort(sportik, (x, y) => y.CalculateFinalResult().CompareTo(x.CalculateFinalResult()));
        for (int i = 0; i < sportik.Length; i++)
        {
            sportik[i].PrintInfo();
        }
    }
}
