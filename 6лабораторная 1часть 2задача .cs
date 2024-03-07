using System;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Lifetime;
using System.Text.RegularExpressions;

/*Составить программу для обработки результатов кросса на 500 м для женщин. 
Для каждой участницы ввести фамилию, группу,фамилию преподавателя, результат. 
Получить результирующую таблицу, упорядоченную по результатам, в которой содержится также

информация о выполнении норматива. 
Определить суммарное количество участниц, выполнивших норматив.*/

namespace Structures
{
    public struct Person
    {
        private string _surname;
        private string _group;
        private string _teachersSurname;
        private int _result;

        public Person(string surname, string group, string teachersSurname, int result)
        {
            _surname = surname;
            _group = group;
            _teachersSurname = teachersSurname;
            _result = result;
        }

        public int result => _result;


        public void Print()
        {
            Console.WriteLine($"surname: {_surname} group: {_group} " +
                    $"teachersSurname: {_teachersSurname} _result: {_result}\n");
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] woman = new Person[5]
            {
                new Person("Аникина", "1A", "Зайцева", 256),
                new Person("Бородако", "2B", "Зайцева", 240),
                new Person("Петрова", "1A", "Зайцева", 264),
                new Person("Думова", "2B", "Баранова", 280),
                new Person("Перевезенцева", "1A", "Баранова", 276)
            };

            Sort(woman);
            for (int i = 0; i < woman.Length; i++)
            {
                woman[i].Print();
            }
            Console.WriteLine($"колличество прошедших норматив: {theNumberOf(woman)}, при нормативе 260");
        }

        static int theNumberOf(Person[] woman)
        {
            int quality = 0;
            for (int j = 0; j < woman.Length; j++)
            {
                if (woman[j].result > 260)
                {
                    quality++;
                }
            }
            return quality;
        }

        static void Sort(Person[] woman)
        {
            for (int i = 0; i < woman.Length - 1; i++)
            {
                for (int j = 1; j < woman.Length; j++)
                {
                    if (woman[j].result > woman[j - 1].result)
                    {
                        Person p = woman[j];
                        woman[j] = woman[j - 1];
                        woman[j - 1] = p;
                    }
                }
            }
        }
    }
}
