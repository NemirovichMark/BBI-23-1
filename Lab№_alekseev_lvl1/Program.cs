using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab__alekseev_lvl1
{
    public abstract class Paticapant
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
            _isNormative = CheckNormative();
        }

        protected abstract bool CheckNormative();

        public string Surname{get { return _surname; }}

        public string Group{get { return _group; }}

        public string TeacherSurname{ get { return _teacherSurname; }}

        public double Result{get { return _result; }}

        public bool IsNormative{get { return _isNormative; }}

        public void Print()
        {
            Console.WriteLine($"{Surname,15} | {Group,10} | {TeacherSurname,15} | {Result,10:F2} | {(IsNormative ? "Да" : "Нет"),10}");
        }
    }

    public class HunderedRace : Paticapant  // Норматив для бега на 500м 165 сек 
    {
        private const double NormativeTime = 110.0; 
        public HunderedRace ( string Surname , string Group, string TeacherSurname, double Result) : base(Surname ,Group ,TeacherSurname, Result)
        {

        }

        protected override bool CheckNormative()
        {
            return Result <= NormativeTime; 
        }
    }

    public class FiveHunderedRace : Paticapant
    {
        private const double NormativeTime = 165.0; 

        public FiveHunderedRace(string Surname ,string Group , string TeacherSurname, double Result) : base (Surname , Group , TeacherSurname , Result)
        {

        }

        protected override bool CheckNormative()
        {
            return Result <= NormativeTime;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Paticapant[] hundered = new Paticapant[]
            {
                new HunderedRace ("Jenn","1","Kenn",96),
                new HunderedRace("Zutdly", "2", "Jhnn", 109),
                new HunderedRace("Pory", "3", "Proxy", 101),
                new HunderedRace("Yorn", "4", "Bolly", 190),
                new HunderedRace("Ioen", "5", "Denzly", 140)
            };
            Paticapant[] fivehundered = new Paticapant[]
            {
                new FiveHunderedRace("Ionn", "6", "Leo",190),
                new FiveHunderedRace("Lina", "7", "Dennis",132),
                new FiveHunderedRace("Pudge", "8", "Player",154),
                new FiveHunderedRace("Sven", "9", "Admin",180),
                new FiveHunderedRace("Lion", "10", "Ceo",173),
            };


            //Array.Sort(hundered, (p1, p2) => p1.Result.CompareTo(p2.Result));
            //Array.Sort(fivehundered, (p1, p2) => p1.Result.CompareTo(p2.Result));

            InsertionSort(hundered);
            InsertionSort(fivehundered); 


            Console.WriteLine("\n100 метров:");
            Console.WriteLine("{0,15} | {1,10} | {2,15} | {3,10} | {4,10}", "Фамилия", "Группа", "Фамилия преподавателя", "Результат", "Норматив");

            foreach (var pat in hundered)
            {
                pat.Print();
            }

            Console.WriteLine("\n500 метров");
            Console.WriteLine("{0,15} | {1,10} | {2,15} | {3,10} | {4,10}", "Фамилия", "Группа", "Фамилия преподавателя", "Результат", "Норматив");

            foreach (var pat in fivehundered)
            {
                pat.Print();
            }



            int hunderednormativecounter = hundered.Count(p => p.IsNormative);
            int fivehunderedNormativeCounter = fivehundered.Count(p => p.IsNormative);
            Console.WriteLine($"\nКоличество участниц, выполнивших норматив на 100м: {hunderednormativecounter}");
            Console.WriteLine($"\nКоличество участниц, выполнивших норматив на 500м: {fivehunderedNormativeCounter}");
            Console.ReadKey();




        }
        
        static void InsertionSort(Paticapant[] parts)
        {
            for(int i = 1; i  < parts.Length; i++)
            {
                Paticapant key = parts[i];
                int j = i - 1;

                while (j >= 0 && parts[j].Result > key.Result)
                {
                    parts[j+1] = parts[j];
                    j = j - 1;
                }
                parts[j+1] = key;
            }
        }
    }

    
}