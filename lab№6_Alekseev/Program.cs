using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab_6_Alekseev
{
    
        public struct Paticapant
    {
        private string _surname;
        private string _group;
        private string _teacherSurname;
        private double _result;
        private bool _isNormative;

        public Paticapant(string surname, string group, string teacherSurname, double result)
        {
            _surname = surname;
            _group = group;
            _teacherSurname = teacherSurname;
            _result = result;
            _isNormative = _result <= 110; // В секундах
        }

        public string Surname { get { return _surname; } }

        public string Group { get { return _group; } }

        public string TeacherSurname { get { return _teacherSurname; } }

        public double Result { get { return _result; } }

        public bool IsNormative { get { return _isNormative; } }

        public void Print()
        {
            Console.WriteLine($"{Surname,15} | {Group,10} | {TeacherSurname,15} | {Result,10:F2} | {(IsNormative ? "Да" : "Нет"),10}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Paticapant[] paticapants = new Paticapant[]
            {
                new Paticapant("Jenn","1","Kenn",96),
                new Paticapant("Zutdly", "2", "Jhnn", 109),
                new Paticapant("Pory", "3", "Proxy", 101),
                new Paticapant("Yorn", "4", "Bolly", 190),
                new Paticapant("Ioen", "5", "Denzly", 140)

            };
            Array.Sort(paticapants, (p1, p2) => p1.Result.CompareTo(p2.Result));

            Console.WriteLine("{0,15} | {1,10} | {2,15} | {3,10} | {4,10}", "Фамилия", "Группа", "Фамилия преподавателя", "Результат", "Норматив");

            foreach (var participant in paticapants)
            {
                participant.Print();
            }


            int normativeCount = paticapants.Count(p => p.IsNormative);
            Console.WriteLine($"\nКоличество участниц, выполнивших норматив: {normativeCount}");
            Console.ReadKey();


        }
    }
}


 

   
