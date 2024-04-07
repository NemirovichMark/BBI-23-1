using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba6new
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region level 1 ex 4
            //Результаты соревнований по прыжкам в высоту определяются по лучшей из двух
            //попыток.Вывести список участников в порядке занятых мест

            Console.WriteLine("Level 1 Ex 4: \n");

            List<Participant> initialParticipants = new List<Participant>();
            Competition competition = new Competition(initialParticipants);

            //adding participants  
            competition.AddParticipant("Ivan");
            competition.AddParticipant("Alex");
            competition.AddParticipant("Maria");

            //creating jumps 
            competition.MakeJump("Ivan", 0.6);
            competition.MakeJump("Alex", 0.87);
            competition.MakeJump("Maria", 0.59);

            competition.MakeJump("Ivan", 0.72);
            competition.MakeJump("Alex", 0.66);
            competition.MakeJump("Maria", 0.68);

            //displaying results
            competition.DisplayResults();
            #endregion

            #region level 2 ex 1
            //Студенты одной группы в сессию сдают четыре экзамена. Составить список
            //студентов, средний балл которых по всем экзаменам не менее «4». Результаты
            //вывести в виде таблицы с заголовком в порядке убывания среднего балла

            Console.WriteLine("\nLevel 2 Ex 1: \n");

            //creating list of students with grades
            List<Student> students = new List<Student>
            {
            new Student("Ivanov", new int[] {5, 4, 4, 5}),
            new Student("Petrov", new int[] {4, 3, 4, 5}),
            new Student("Kalashnikov", new int[] {3, 4, 5, 4}),
            new Student("Greene", new int[] {4, 4, 4, 4})
            };

            //students with average >4.0 ordered by descending
            var selectedStudents = students.Where(s => s.CalculateAverageScore() >= 4).OrderByDescending(s => s.CalculateAverageScore());

            //displaying results in a form of the table
            Console.WriteLine("Students with average grade more than 4.0:");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("|    Student name    |  Average grade   |");
            Console.WriteLine("-----------------------------------------");
            foreach (var student in selectedStudents)
            {
                Console.WriteLine($"| {student.Name,-18} | {student.CalculateAverageScore(),-16:N2} |");
            }
            Console.WriteLine("-----------------------------------------");
            #endregion

            #region level 3 ex 1
            //Результаты сессии содержат оценки 5 экзаменов по каждой группе. Определить
            //средний балл для трех групп студентов одного потока и выдать список групп в
            //порядке убывания среднего бала. Результаты вывести в виде таблицы с
            //заголовком

            Console.WriteLine("\nLevel 3 Ex 1: \n");

            //creating an array of object of class ExamResults
            ExamResults[] results = new ExamResults[]
            {
            new ExamResults { GroupName = "Group 1", ExamScores = new int[] {80, 85, 90, 75, 88} },
            new ExamResults { GroupName = "Group 2", ExamScores = new int[] {70, 75, 85, 80, 78} },
            new ExamResults { GroupName = "Group 3", ExamScores = new int[] {90, 95, 92, 88, 87} }
            };

            //sorting average grades by descending
            var sortedResults = results.OrderByDescending(r => r.GetAverageScore());

            //displaying results in a form of the table
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("|Group\t\t        |Average grade  |");
            Console.WriteLine("-----------------------------------------");
            foreach (var result in sortedResults)
            {
                Console.WriteLine($"|{result.GroupName}\t\t|{result.GetAverageScore()}           |");
            }
            Console.WriteLine("-----------------------------------------");
            #endregion
            Console.ReadKey();
        }
    }
    //level 1 ex4
    public struct Participant
    {
        public string Name { get; private set; }
        public double BestHeight { get; private set; }

        public Participant(string name)
        {
            Name = name;
            BestHeight = 0;
        }

        public void MakeJump(double height) //method to configure best jump of a name 
        {
            if (height > BestHeight)
            {
                BestHeight = height;
            }
        }
    }

    public struct Competition
    {
        public List<Participant> Participants;

        public Competition(List<Participant> participants)
        {
            Participants = participants;
        }

        public void AddParticipant(string name) //method to add new participants to the initial list of participants
        {
            Participants.Add(new Participant(name));
        }

        public void MakeJump(string name, double height) //method to create jumps linked to a name
        {
            Participant participant = Participants.Find(p => p.Name == name);

            participant.MakeJump(height);


        }

        public void DisplayResults() //method to display results of participants in console
        {
            Participants.Sort((p1, p2) => p2.BestHeight.CompareTo(p1.BestHeight));
            Console.WriteLine("Results of a high jumps competition:");
            foreach (Participant participant in Participants)
            {
                Console.WriteLine($"Participants: {participant.Name}, Best height: {participant.BestHeight}");
            }
        }
    }
    //level 2 ex 1
    public struct Student
    {
        public string Name;
        public int[] ExamResults;

        public Student(string name, int[] examResults)
        {
            Name = name;
            ExamResults = examResults;
        }

        public double CalculateAverageScore() //method to calculate average grade of a student
        {
            return ExamResults.Average();
        }
    }
    //level 3 ex 1
    public struct ExamResults
    {
        public string GroupName;
        public int[] ExamScores;

        public double GetAverageScore() //method to calculate average grade of a group
        {
            return ExamScores.Average();
        }
    }
}
