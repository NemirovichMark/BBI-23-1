using Internal;
using System;

class Program
{
    struct Person
    {
        private string surname;
        private int[] refs;

        public string Surname => surname;

        public int[] Refs => refs;

        public Person(string surname, int[] refs)
        {
            this.surname = surname;
            this.refs = refs;
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
        }
    }

    static void Main()
    {
        Person[] sportik = new Person[5];
        sportik[0] = new Person("Oganezov", new int[] { 4, 5, 2, 3, 4, 3, 4, 4, 5, 5 });
        sportik[1] = new Person("Popov", new int[] { 3, 5, 1, 4, 2, 5, 3, 3, 2, 2 });
        sportik[2] = new Person("Machkalyan", new int[] { 1, 2, 1, 1, 3, 3, 4, 4, 2, 4 });
        sportik[3] = new Person("Gubeeva", new int[] { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 });
        sportik[4] = new Person("Kapelina", new int[] { 4, 5, 5, 4, 4, 5, 5, 4, 4, 5 });

        Array.Sort(sportik, (x, y) => y.CalculateFinalResult().CompareTo(x.CalculateFinalResult()));
        for (int i = 0; i < sportik.Length; i++)
        {
            sportik[i].PrintInfo();
        }
    }
}