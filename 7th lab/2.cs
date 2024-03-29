using System;
/*2.  Составить программу для обработки результатов кросса на
500 м для женщин. Для каждой участницы ввести фамилию, группу, результат. 
Получить результирующую таблицу, упорядоченную по результатам, в которой содержится также информация о выполнении норматива. 
Определить суммарное количество участниц, выполнивших норматив.
 * 
 * 
 * 
Сделать абстрактный класс, и от него создать 2-х наследников: бег на 100м и 500м.
Провести соревнования по забегу на эти 2 дистанции и вывести 2 таблицы с результатами.*/
namespace ConsoleApp325
{
    class Cross
    {
        protected string _LastName;
        protected string _Group;
        protected int _score;

        public Cross(string LastName, string Group, int score)
        {
            this._LastName = LastName;
            this._Group = Group;
            this._score = score;
        }
        public string LastName { get { return this._LastName; } }
        public string Group { get { return this._Group; } }
        public int score { get { return this._score; } }
        public void Print()
        {
            Console.WriteLine($"Name:{LastName} Group:{Group} Score:{score}");
        }
    }

    abstract class Winers
    {
        public abstract void Winer(Cross[] array);
    }
    class Run100 : Winers
    {
        public override void Winer(Cross[] array)
        {
            int res = 0;
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = 1; j < array.Length; j++)
                {
                    if (array[j - 1].score < array[j].score)
                    {
                        Cross p = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = p;
                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].score >= 100)
                {
                    res = i;
                }
            }
            Console.WriteLine("Результаты забега на 100 метров");
            for (int i = 0; i <= res; i++)
            {
                Console.Write($"Place: {i+1}\t\t");
                array[i].Print();
            }
        }
    }
    class Run500 : Winers
    {
        public override void Winer(Cross[] array)
        {
            int res = 0;
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = 1; j < array.Length; j++)
                {
                    if (array[j - 1].score < array[j].score)
                    {
                        Cross p = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = p;
                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].score >= 500)
                {
                    res = i;
                }
            }
            Console.WriteLine("Результаты забега на 500 метров");
            for (int i = 0; i <= res; i++)
            {
                Console.Write($"Place: {i + 1}\t\t");
                array[i].Print();
            }
        }
    }
    internal class Program
    {
        Run100 r = new Run100();

        static void Main(string[] args)
        {
            Cross[] ARRAY = new Cross[3];

            ARRAY[0] = new Cross("Sidney", "a2", 521);
            ARRAY[1] = new Cross("Rosa", "a1", 523);
            ARRAY[2] = new Cross("Adrian", "a3", 128);
            Sort(ARRAY);
            Run100 array1 = new Run100();
            array1.Winer(ARRAY);
            Console.WriteLine();
            Run500 array2 = new Run500();
            array2.Winer(ARRAY);
        }
        static void Sort(Cross[] array)
        {
            for (int j = 0; j < array.Length - 1; j++)
            {
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i - 1].score < array[i].score)
                    {
                        Cross p = array[i - 1];
                        array[i - 1] = array[i];
                        array[i] = p;
                    }
                }
            }
        }
    }
}
