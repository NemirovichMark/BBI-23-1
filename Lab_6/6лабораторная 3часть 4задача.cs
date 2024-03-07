using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Lifetime;

/*Лыжные гонки проводятся отдельно для двух групп участников. 
Результаты соревнований заданы в виде фамилий участников и их результатов в каждой группе. 
Расположить результаты соревнований в каждой группе в порядке занятых мест. 
Объединить результаты обеих групп с сохранением упорядоченности 
и вывести в виде таблицы с заголовком.*/

namespace Structures
{
    public struct Person
    {
        private string _surname;
        private string _group;
        private int _result;
        public Person(string surname, string group, int result)
        {
            _surname = surname;
            _group = group;
            _result = result;
        }
        public int result { get { return _result; } }
        public string group { get { return _group; } }

        public void Print()
        {
            Console.WriteLine($"surname: {_surname} group: {_group} result: {_result}\n");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] customersA = new Person[3];
            customersA[0] = new Person("John", "A", 5);
            customersA[1] = new Person("Bob", "A", 6);
            customersA[2] = new Person("Mickle", "A", 8);

            Person[] customersB = new Person[3];
            customersB[0] = new Person("Luc", "B", 2);
            customersB[1] = new Person("Derec", "B", 9);
            customersB[2] = new Person("Aron", "B", 4);

            Console.WriteLine("команда А");
            Sort(customersA);
            for (int i = 0; i < customersA.Length; i++)
            {
                customersA[i].Print();
            }
            Console.WriteLine();
            Console.WriteLine("команда В");
            Sort(customersB);
            for (int i = 0; i < customersB.Length; i++)
            {
                customersB[i].Print();
            }



            Person[] customers = new Person[customersA.Length + customersB.Length];
            int theNumbweOfA = 0, theNumbweOfB = 0;
            for (int i = 0; i < customers.Length; i++)
            {
                if (theNumbweOfA == customersA.Length)
                {
                    for (int j = i; j < customers.Length; j++)
                    {
                        customers[j] = customersB[theNumbweOfB];
                        theNumbweOfB++;
                    }
                    break;
                }
                else if (theNumbweOfB == customersB.Length)
                {
                    for (int j = i; j < customers.Length; j++)
                    {
                        customers[j] = customersB[theNumbweOfB];
                        theNumbweOfA++;
                    }
                    break;
                }
                else if (customersA[theNumbweOfA].result >= customersB[theNumbweOfB].result)
                {
                    customers[i] = customersA[theNumbweOfA];
                    theNumbweOfA++;
                }
                else if (customersA[theNumbweOfA].result < customersB[theNumbweOfB].result)
                {
                    customers[i] = customersB[theNumbweOfB];
                    theNumbweOfB++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("команды А и В");
            for (int i = 0; i < customers.Length; i++)
            {
                customers[i].Print();
            }
            Console.WriteLine();
        }
        static void Sort(Person[] customers)
        {
            for (int i = 1; i < customers.Length; i++)
            {
                for (int j = 1; j < customers.Length; j++)
                {
                    if (customers[j].result > customers[j - 1].result)
                    {
                        Person test = customers[j];
                        customers[j] = customers[j - 1];
                        customers[j - 1] = test;
                    }
                }
            }
        }
    }
}
