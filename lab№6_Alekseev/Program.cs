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
        public string Surname;
        public string Group;
        public string TeacherSurname;
        public double Result;
        public bool IsNormative;

        public Paticapant(string surname, string group, string teachersurname, double resoult)
        {
            Surname = surname;
            Group = group;
            TeacherSurname = teachersurname;
            Result = resoult;
            IsNormative = Result <= 110; // В секундах 


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
                Console.WriteLine("{0,15} | {1,10} | {2,15} | {3,10:F2} | {4,10}", participant.Surname, participant.Group, participant.TeacherSurname, participant.Result, participant.IsNormative ? "Да" : "Нет");
            }


            int normativeCount = paticapants.Count(p => p.IsNormative);
            Console.WriteLine($"\nКоличество участниц, выполнивших норматив: {normativeCount}");
            Console.ReadKey();


        }
    }
}

 

   
