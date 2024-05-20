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
            //lab6 task:
            //Результаты соревнований по прыжкам в высоту определяются по лучшей из двух
            //попыток.Вывести список участников в порядке занятых мест

            //lab7 task:
            //Добавить поле «дисквалификация» и метод, который позволяет дисквалифицировать участника.
            //В итоговую таблицу такие участники входить не должны. 

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

            //disqualify participant
            competition.DisqualifyParticipant("Alex");

            //displaying results
            competition.DisplayResults();
            #endregion

            #region level 2 ex 1
            //lab6 task:
            //Студенты одной группы в сессию сдают четыре экзамена. Составить список
            //студентов, средний балл которых по всем экзаменам не менее «4». Результаты
            //вывести в виде таблицы с заголовком в порядке убывания среднего балла

            //lab7 task:
            //Сделать класс «Человек». Класс студент должен наследоваться от него, и иметь дополнительное поле «N студ. билета».
            //При выводе в таблице должны быть ФИО, N студ. билета и средний балл.

            Console.WriteLine("\nLevel 2 Ex 1: \n");

            //creating list of students with grades
            List<Student> students = new List<Student>
            {
            new Student("Ivanov", new int[] {5, 4, 4, 5}, 228),
            new Student("Petrov", new int[] {4, 3, 4, 5}, 227),
            new Student("Kalashnikov", new int[] {3, 4, 5, 4}, 226),
            new Student("Greene", new int[] {4, 4, 4, 4}, 225)
            };

            //students with average >4.0 ordered by descending
            var selectedStudents = students.Where(s => s.CalculateAverageScore() >= 4).OrderByDescending(s => s.CalculateAverageScore());

            //displaying results in a form of the table
            // + new output in accordance with the lab7 task
            Console.WriteLine("Students with average grade more than 4.0:");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("|    Student name    |  Average grade   | Student ID number |");
            Console.WriteLine("-------------------------------------------------------------");
            foreach (var student in selectedStudents)
            {
                Console.WriteLine($"| {student.Name,-18} | {student.CalculateAverageScore(),-16:N2} | {student.ID,-18}|");
            }
            Console.WriteLine("-------------------------------------------------------------");
            #endregion

            #region level 3 ex 1
            //lab6 task:
            //Результаты сессии содержат оценки 5 экзаменов по каждой группе. Определить
            //средний балл для трех групп студентов одного потока и выдать список групп в
            //порядке убывания среднего бала. Результаты вывести в виде таблицы с
            //заголовком

            //lab7 task:
            //Создать класс «Группа» с набором общих для всех групп-наследников предметов (3-4) и от него 3 наследника
            //(названия групп) с дополнительными 2 различными предметами.
            //В наследниках переопределить метод расчета среднего балла за сессию.
            //Вывести студентов всех групп единым списком. Использовать динамическую связку: преобразование классов.

            Console.WriteLine("\nLevel 3 Ex 1: \n");

            //creating an array of Group objects
            Group[] groups = new Group[]
            {
            new Group1("Group1", new int[] {80, 85, 90}, new int[] {75, 88}),
            new Group2("Group2", new int[] {70, 75, 85}, new int[] {80, 78}),
            new Group3("Group3", new int[] {90, 95, 92}, new int[] {88, 87})
            };

            //sorting average grades by descending
            var sortedGroups = groups.OrderByDescending(r => r.CalculateAverageScore());

            //displaying results in a form of the table
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("|Group\t\t        |Average grade  |");
            Console.WriteLine("-----------------------------------------");
            foreach (var result in sortedGroups)
            {
                Console.WriteLine($"|{result.GroupName}\t\t|{result.CalculateAverageScore()}           |");
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
        public bool IsDisqualified { get; set; } //new field for lab7 task

        public Participant(string name)
        {
            Name = name;
            BestHeight = 0;
            IsDisqualified = false;
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
            int index = Participants.FindIndex(p => p.Name == name); //remembers index of an object in list if the name property same as name parameter 
            if (index != -1 && !Participants[index].IsDisqualified) //check if the name really is in the list and if it has disqualified property TRUE
            {
                Participant participant = Participants[index];
                participant.MakeJump(height);
                Participants[index] = participant;
            }
        }

        public void DisqualifyParticipant(string name) //method to disqualify a partisipant
        {
            int index = Participants.FindIndex(p => p.Name == name);
            if (index != -1) //checks: if index is -1 that means that name is not found in the list -> we can't disqualify nonexistent participant 
            {
                Participant participant = Participants[index];
                participant.IsDisqualified = true;
                Participants[index] = participant;
            }
        }

        public void DisplayResults() //method to display results of participants in console
        {
            var validParticipants = Participants.Where(p => !p.IsDisqualified).ToList(); // makes a new list only with participants with false IsDisqualified property
            validParticipants.Sort((p1, p2) => p2.BestHeight.CompareTo(p1.BestHeight)); // sorts that new "valid" list
            Console.WriteLine("Results of a high jumps competition:");
            foreach (Participant participant in Participants)
            {
                Console.WriteLine($"Participants: {participant.Name}, Best height: {participant.BestHeight}");
            }
        }
    }
    //level 2 ex 1
    public class Human //new class Human for lab7 task
    {
        public int ID { get; set; }
    }

    public class Student : Human //class student inherits class human
    {
        public string Name;
        public int[] ExamResults;

        public Student(string name, int[] examResults, int Id)
        {
            Name = name;
            ExamResults = examResults;
            ID = Id;
        }

        public double CalculateAverageScore() //method to calculate average grade of a student
        {
            return ExamResults.Average();
        }
    }
    //level 3 ex 1
    public abstract class Group //basic class for lab7 task
    {
        public string GroupName { get; set; }
        public int[] GeneralExamScores { get; set; } //property for basic subjects
        public int[] SpecializedExamScores { get; set; } //property for subjects special for every group 

        public Group(string groupName, int[] generalEx, int[] specialEx)
        {
            GroupName = groupName;
            GeneralExamScores = generalEx;
            SpecializedExamScores = specialEx;
        }

        public abstract double CalculateAverageScore(); //abstract method to override
    }

    public class Group1 : Group
    {
        public Group1(string GroupName, int[] GeneralExamScores, int[] SpecializedExamScores) : base(GroupName, GeneralExamScores, SpecializedExamScores)
        {

        }

        public override double CalculateAverageScore()
        {
            return (GeneralExamScores.Concat(SpecializedExamScores)).Average(); //concat is from linq and it combines two arrays into one array
        }
    }

    public class Group2 : Group
    {
        public Group2(string GroupName, int[] GeneralExamScores, int[] SpecializedExamScores) : base(GroupName, GeneralExamScores, SpecializedExamScores)
        {

        }

        public override double CalculateAverageScore()
        {
            return (GeneralExamScores.Concat(SpecializedExamScores)).Average();
        }
    }

    public class Group3 : Group
    {
        public Group3(string GroupName, int[] GeneralExamScores, int[] SpecializedExamScores) : base(GroupName, GeneralExamScores, SpecializedExamScores)
        {

        }

        public override double CalculateAverageScore()
        {
            return (GeneralExamScores.Concat(SpecializedExamScores)).Average();
        }
    }

    //public struct ExamResults
    //{
    //    public string GroupName;
    //    public int[] ExamScores;

    //    public double GetAverageScore() //method to calculate average grade of a group
    //    {
    //        return ExamScores.Average();
    //    }
    //}
}
