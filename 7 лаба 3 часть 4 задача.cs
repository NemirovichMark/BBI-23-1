using System;

namespace ConsoleApp355
{
    public abstract class Sportsmen
    {
        protected string _surname;
        protected string _group;
        protected int _result;
        public Sportsmen(string surname, string group, int result)
        {
            _surname = surname;
            _group = group;
            _result = result;
        }
        public int result { get { return _result; } }
        public string group { get { return _group; } }

        public abstract void Print();
    }
    class Liznik : Sportsmen
    {
        public Liznik(string surname, string group, int result) : base(surname, group, result)
        {

        }
        public override void Print()
        {
            Console.WriteLine($"surname: {_surname} group: {_group} result: {_result}\n");
        }
    }
    class Liznitsa : Sportsmen
    {
        public Liznitsa(string surname, string group, int result) : base(surname, group, result)
        {

        }
        public override void Print()
        {
            Console.WriteLine($"surname: {_surname} group: {_group} result: {_result}\n");
        }
    }
    internal class Program
    {
        static void Sort(Sportsmen[] customers)
        {
            for (int i = 1; i < customers.Length; i++)
            {
                for (int j = 1; j < customers.Length; j++)
                {
                    if (customers[j].result > customers[j - 1].result)
                    {
                        Sportsmen test = customers[j];
                        customers[j] = customers[j - 1];
                        customers[j - 1] = test;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Sportsmen[] customers1 = new Sportsmen[3];
            customers1[0] = new Liznik("John", "A", 5);
            customers1[1] = new Liznik("Bob", "A", 6);
            customers1[2] = new Liznik("Mickle", "A", 8);

            Sportsmen[] customers2 = new Sportsmen[3];
            customers2[0] = new Liznitsa("Luc", "B", 2);
            customers2[1] = new Liznitsa("Derec", "B", 9);
            customers2[2] = new Liznitsa("Aron", "B", 4);

            Sort(customers1);
            Sort(customers2);

            Console.WriteLine("A");
            foreach (var c in customers1)
            {
                c.Print();
            }
            Console.WriteLine();
            Console.WriteLine("B");
            foreach (var m in customers2)
            {
                m.Print();
            }
            Console.WriteLine();

            Sportsmen[] sportsmen = new Sportsmen[customers1.Length + customers2.Length];

            int ind1 = 0, ind2 = 0;

            for (int i = 0; i < sportsmen.Length; i++)
            {
                if (ind1 == customers1.Length)
                {
                    for (int j = i; j < sportsmen.Length; j++)
                    {
                        sportsmen[j] = customers2[ind2];
                        ind2++;
                    }
                    break;
                }

                else if (ind2 == customers2.Length)
                {
                    for (int j = i; j < sportsmen.Length; j++)
                    {
                        sportsmen[j] = customers1[ind1];
                        ind1++;
                    }
                    break;
                }

                else if (customers1[ind1].result >= customers2[ind2].result)
                {
                    sportsmen[i] = customers1[ind1];
                    ind1++;
                }
                else if (customers1[ind1].result < customers2[ind2].result)
                {
                    sportsmen[i] = customers2[ind2];
                    ind2++;
                }
            }

            Console.WriteLine("A&B");
            foreach (var s in sportsmen)
            {
                s.Print();
            }
            Console.ReadKey();
        }
    }
}