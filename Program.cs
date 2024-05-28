using System;

public class Program
{
    struct Ychastnik
    {
        private string name;
        private int id;
        private int _bestres;

        public int Result { get { return _bestres; } }

        public Ychastnik(string name, int i, int bestres)
        {
            this.name = name;
            id = i;
            _bestres = bestres;
        }

        public int ressec
        {
            get { return _bestres; }
            set
            {
                if (value > _bestres) _bestres = value;
            }
        }

        public void Info()
        {
            Console.WriteLine($"результат: {_bestres} имя участника: {name} ");
        }

    }

    static Ychastnik[] GnomeSort(Ychastnik[] list)
    {
        int i = 1;
        int j = 2;

        while (i < list.Length)
        {
            if (list[i - 1].Result <= list[i].Result)
            {
                i = j;
                j++;
            }
            else
            {
                Ychastnik tmp = list[i - 1];
                list[i - 1] = list[i];
                list[i] = tmp;
                i--;
                if (i == 0)
                {
                    i = j;
                    j++;
                }
            }
        }
        return list;
    }

    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Ychastnik[] peoplelist = new Ychastnik[n];

        for (int i = 0; i < n; i++)
        {
            string name_people = Console.ReadLine();
            int firstres = int.Parse(Console.ReadLine());
            int secondres = int.Parse(Console.ReadLine());

            Ychastnik Person = new Ychastnik(name_people, i + 1, firstres);
            Person.ressec = secondres;

            peoplelist[i] = Person;
        }

        peoplelist = GnomeSort(peoplelist);

        for (int i = 0; i < n; i++)
        {
            Console.Write($"{i + 1} занятое место: ");
            peoplelist[i].Info();
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.ReadLine();
    }
}


