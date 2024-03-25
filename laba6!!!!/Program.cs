using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace laba6____
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region level1 ex4
            //Результаты соревнований по прыжкам в высоту определяются по лучшей из двух
            //попыток.Вывести список участников в порядке занятых мест

            Console.WriteLine("Level 1 Ex 4: ");

            Competition competition = new Competition();

            //Adding participants
            competition.AddParticipant("Mathew");
            competition.AddParticipant("Andrew");
            competition.AddParticipant("Lisa");

            //Configuring results of the jumps of each participant
            Random rand = new Random();

            competition.MakeJump("Andrew", Math.Round(rand.NextDouble(), 1)); //random can be replaced with values typed in by user
            competition.MakeJump("Andrew", Math.Round(rand.NextDouble(), 1));

            competition.MakeJump("Mathew", Math.Round(rand.NextDouble(), 1));
            competition.MakeJump("Mathew", Math.Round(rand.NextDouble(), 1));

            competition.MakeJump("Lisa", Math.Round(rand.NextDouble(), 1));
            competition.MakeJump("Lisa", Math.Round(rand.NextDouble(), 1));

            //Displaying results
            Console.WriteLine("\nCompetition  results:\n");
            competition.CompetitionResultsSort();
            #endregion

            #region level2 ex1
            //Студенты одной группы в сессию сдают четыре экзамена. Составить список
            //студентов, средний балл которых по всем экзаменам не менее «4». Результаты
            //вывести в виде таблицы с заголовком в порядке убывания среднего балла

            Console.WriteLine("\nLevel 2 Ex 1: ");

            List<Student> students = new List<Student> //creating list of objects of class Student with grades to later sort the list with interbal collections method
            {
            new Student("Mathew", new List<int> {2,3,4,5}),
            new Student("Andrew", new List<int>{4,4,4,5}),
            new Student("Lisa", new List<int>{4,5,5,5})
            };

            List<Student> passedStudents = students.Where(student => student.AverageGrade >= 4).ToList(); //creating a list with students with
                                                                                                          //average grade >4 and sorting it
                                                                                                          //.Where - googled linq method
            passedStudents.Sort((student1, student2) => student2.AverageGrade.CompareTo(student1.AverageGrade)); //descending sorting

            Console.WriteLine("\nStudent:     |" + "Exams result:"); //displaying a table with students and their grades 
            Console.WriteLine(new string('-', 27));
            foreach (var student in passedStudents)
            {
                Console.WriteLine("Name: {0, -7}|Grade: {1, -10}", student.Name, student.AverageGrade);
            }
            #endregion

            #region level3 ex1
            //Результаты сессии содержат оценки 5 экзаменов по каждой группе. Определить
            //средний балл для трех групп студентов одного потока и выдать список групп в
            //порядке убывания среднего бала. Результаты вывести в виде таблицы с
            //заголовком

            Console.WriteLine("\nLevel 3 Ex 1: ");

            var results = new List<ExamsResults> //creating list of objects of class ExamsResults 
        {
            new ExamsResults { Group = "Group: 1", Marks = new List<double> { 4.5, 3.7, 4.9, 5.0, 4.2 } },
            new ExamsResults { Group = "Group: 2", Marks = new List<double> { 3.8, 4.0, 4.1, 3.9, 4.3 } },
            new ExamsResults { Group = "Group: 3", Marks = new List<double> { 4.2, 4.6, 4.7, 4.5, 4.8 } }
        };

            var sortedExamsResults = results.OrderByDescending(result => result.GetAverageMark()); //sorting the list 

            Console.WriteLine("{0,-7} {1,20}", "Group", "Average mark"); //displaying results
            foreach (var result in sortedExamsResults)
            {
                Console.WriteLine("{0,-7} {1,11:F2}", result.Group, result.GetAverageMark());
            }
            #endregion
            Console.ReadKey();
        }
    }

    public class Human //class for a human(basic parent class just to show inheritance)
    {
        public string Name { get; set; }
    }
    //classes for level1 ex4
    public class Participant : Human
    {
        public double BestJump { get; set; }

        public Participant(string name)
        {
            Name = name;
            BestJump = 0;
        }

        public void MakeJump(double jump)
        {
            if (jump > BestJump)
            {
                BestJump = jump;
            }
        }
    }
    public class Competition
    {
        public List<Participant> Participants { get; set; }

        public Competition()
        {
            Participants = new List<Participant>();
        }

        public void AddParticipant(string name)
        {
            Participants.Add(new Participant(name));
        }

        public void MakeJump(string name, double jump)
        {
            Participant participant = Participants.Find(p => p.Name == name); //find object from class Participant in list Participants 
                                                                              //by name and updating BestJump form 0 to new value
            participant.MakeJump(jump);
        }
        public void ListSort()
        {
            Participants.Sort((jump1, jump2) => jump2.BestJump.CompareTo(jump1.BestJump)); //ascending sort of the list
        }

        public void CompetitionResultsSort()
        {
            foreach (Participant participant in Participants)
            {
                Console.WriteLine($"Participant: {participant.Name}, Best jump: {participant.BestJump} metres");
            }
        }
    }
    //classes for level2 ex1
    class Student : Human
    {
        public double AverageGrade { get; private set; }
        public List<int> Exams { get; set; }

        public Student(string name, List<int> exams)
        {
            Name = name;
            Exams = exams;
            AverageGrade = exams.Average(); //average value of list of grades that we create when adding a student
        }

    }
    //classes for level3 ex1
    class ExamsResults
    {
        public string Group { get; set; }
        public List<double> Marks { get; set; }

        public double GetAverageMark()
        {
            return Marks.Average();
        }
    }
}