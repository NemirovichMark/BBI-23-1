using System;
using System.Collections.Generic;
using System.Linq;
using System;

using System;
// Задача 1 Левел 1 
/*class Program
{
    struct Participant
    {
        private string lastName;
        private string society;
        private double firstAttempt;
        private double secondAttempt;

        public Participant(string lastName, string society, double firstAttempt, double secondAttempt)
        {
            this.lastName = lastName;
            this.society = society;
            this.firstAttempt = firstAttempt;
            this.secondAttempt = secondAttempt;
        }

        public double TotalScore => firstAttempt + secondAttempt;

        public void Display()
        {
            Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15} {4,-15}", lastName, society, firstAttempt, secondAttempt, TotalScore);
        }
    }

    static void Main(string[] args)
    {
        Participant[] participants = GetParticipantsData();

        Array.Sort(participants, (x, y) => y.TotalScore.CompareTo(x.TotalScore));

        Console.WriteLine("Results:");
        Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15} {4,-15}", "Last Name", "Society", "1st Attempt", "2nd Attempt", "Total Score");
        foreach (var participant in participants)
        {
            participant.Display();
        }
    }

    static Participant[] GetParticipantsData()
    {
        // Здесь можно заменить на генерацию случайных данных
        Participant[] participants = new Participant[]
        {
            new Participant("Smith", "Alpha", 5.2, 5.5),
            new Participant("Johnson", "Beta", 5.6, 5.4),
            new Participant("Williams", "Gamma", 5.1, 5.3),
            new Participant("Brown", "Delta", 5.3, 5.2),
            new Participant("Jones", "Epsilon", 5.4, 5.6)
        };

        return participants;
    }
}
*/






// Задача 6 Левел 2 

/*using System;

class Program
{
    struct Diver
    {
        private string lastName;
        private double firstJumpScore;
        private double secondJumpScore;

        public Diver(string lastName, double firstJumpScore, double secondJumpScore)
        {
            this.lastName = lastName;
            this.firstJumpScore = firstJumpScore;
            this.secondJumpScore = secondJumpScore;
        }

        public string LastName => lastName;
        public double FirstJumpScore => firstJumpScore;
        public double SecondJumpScore => secondJumpScore;

        public double TotalScore => FirstJumpScore + SecondJumpScore;
    }

    static void Main(string[] args)
    {
        Diver[] divers = GetDiversData();

        Array.Sort(divers, (x, y) => y.TotalScore.CompareTo(x.TotalScore));

        Console.WriteLine("Итоговый протокол:");
        Console.WriteLine("{0,-15} {1,-10} {2,-10} {3,-10}", "Фамилия", "1-й прыжок", "2-й прыжок", "Итоговый балл");
        foreach (var diver in divers)
        {
            Console.WriteLine("{0,-15} {1,-10} {2,-10} {3,-10}", diver.LastName, diver.FirstJumpScore, diver.SecondJumpScore, diver.TotalScore);
        }
    }

    static Diver[] GetDiversData()
    {
        Diver[] divers = new Diver[]
        {
            new Diver("Иванов", 5.5, 6.0),
            new Diver("Петров", 6.0, 5.8),
            new Diver("Сидоров", 5.8, 5.7),
            new Diver("Смирнов", 6.2, 6.5),
            new Diver("Кузнецов", 5.9, 5.6)
        };

        return divers;
    }
}*/


/*using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    struct Group
    {
        public int GroupNumber;
        public int[] ExamScores;

        public Group(int groupNumber, int[] examScores)
        {
            GroupNumber = groupNumber;
            ExamScores = examScores;
        }

        public double AverageScore => ExamScores.Average();
    }

    static void Main(string[] args)
    {
        Group[] groups = GetGroupsData();

        // Сортируем массив групп по среднему баллу в убывающем порядке
        Array.Sort(groups, (x, y) => y.AverageScore.CompareTo(x.AverageScore));

        Console.WriteLine("Средний балл по группам (в порядке убывания):");
        Console.WriteLine("{0,-10} {1}", "Группа", "Средний балл");
        foreach (var group in groups)
        {
            Console.WriteLine("{0,-10} {1:F2}", group.GroupNumber, group.AverageScore);
        }
    }

    static Group[] GetGroupsData()
    {
        Group[] groups = new Group[]
        {
            new Group(101, new int[] { 85, 90, 92, 88, 87 }),
            new Group(102, new int[] { 78, 82, 80, 79, 81 }),
            new Group(103, new int[] { 95, 94, 97, 92, 93 })
        };

        return groups;
    }
}*/






