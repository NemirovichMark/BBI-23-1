using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System;
using System.Linq;
//Задача 1 Левел 1
/*class Program
{
    class Participant
    {
        private string lastName;
        private string society;
        private double firstAttempt; 
        private double secondAttempt; 
        private bool disqualified;

        public Participant(string lastName, string society, double firstAttempt, double secondAttempt)
        {
            this.lastName = lastName;
            this.society = society;
            this.firstAttempt = firstAttempt;
            this.secondAttempt = secondAttempt;
        }

        public double TotalScore => firstAttempt + secondAttempt;

        public void Disqualify()
        {
            disqualified = true;
        }

        public void Display()
        {
            if (!disqualified)
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
        Participant[] participants = new Participant[]
        {
            new Participant("Smith", "Alpha", 5.2, 5.5),
            new Participant("Johnson", "Beta", 5.6, 5.4),
            new Participant("Williams", "Gamma", 5.1, 5.3),
            new Participant("Brown", "Delta", 5.3, 5.2),
            new Participant("Jones", "Epsilon", 5.4, 5.6)
        };

        participants[2].Disqualify(); // Дисквалифицируем Williams

        return participants;
    }
}
*/
/*
// Задача 6 Левел 2 

using System;

abstract class Diving
{
    public abstract string Discipline { get; }

    protected string lastName;
    protected double firstJumpScore;
    protected double secondJumpScore;

    public Diving(string lastName, double firstJumpScore, double secondJumpScore)
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

class ThreeMeterDiving : Diving
{
    public override string Discipline => "Прыжки с 3 м";

    public ThreeMeterDiving(string lastName, double firstJumpScore, double secondJumpScore) : base(lastName, firstJumpScore, secondJumpScore)
    {
    }
}

class FiveMeterDiving : Diving
{
    public override string Discipline => "Прыжки с 5 м";

    public FiveMeterDiving(string lastName, double firstJumpScore, double secondJumpScore) : base(lastName, firstJumpScore, secondJumpScore)
    {
    }
}

class Program
{
    static void Main(string[] args)
    {
        Diving[] divers = GetDiversData();

        Array.Sort(divers, (x, y) => y.TotalScore.CompareTo(x.TotalScore));

        Console.WriteLine("Итоговый протокол:");
        Console.WriteLine("{0,-15} {1,-10} {2,-10} {3,-10}", "Дисциплина", "Фамилия", "1-й прыжок", "2-й прыжок", "Итоговый балл");
        foreach (var diver in divers)
        {
            Console.WriteLine("{0,-15} {1,-10} {2,-10} {3,-10}", diver.Discipline, diver.LastName, diver.FirstJumpScore, diver.SecondJumpScore, diver.TotalScore);
        }
    }

    static Diving[] GetDiversData()
    {
        Diving[] divers = new Diving[]
        {
            new ThreeMeterDiving("Иванов", 5.5, 6.0),
            new ThreeMeterDiving("Петров", 6.0, 5.8),
            new ThreeMeterDiving("Сидоров", 5.8, 5.7),
            new FiveMeterDiving("Смирнов", 6.2, 6.5),
            new FiveMeterDiving("Кузнецов", 5.9, 5.6)
        };

        return divers;
    }
}
*/

using System;

class Group
{
    public int GroupNumber;
    public int[] ExamScores;

    public Group(int groupNumber, int[] examScores)
    {
        GroupNumber = groupNumber;
        ExamScores = examScores;
    }

    public virtual double CalculateAverageScore()
    {
        double sum = 0;
        foreach (int score in ExamScores)
        {
            sum += score;
        }
        return sum / ExamScores.Length;
    }
}

class GroupA : Group
{
    public int AdditionalSubject1;
    public int AdditionalSubject2;

    public GroupA(int groupNumber, int[] examScores, int additionalSubject1, int additionalSubject2)
        : base(groupNumber, examScores)
    {
        AdditionalSubject1 = additionalSubject1;
        AdditionalSubject2 = additionalSubject2;
    }

    public override double CalculateAverageScore()
    {
        double baseAverage = base.CalculateAverageScore();
        return (baseAverage + AdditionalSubject1 + AdditionalSubject2) / 5;
    }
}

class GroupB : Group
{
    public int AdditionalSubject1;
    public int AdditionalSubject2;

    public GroupB(int groupNumber, int[] examScores, int additionalSubject1, int additionalSubject2)
        : base(groupNumber, examScores)
    {
        AdditionalSubject1 = additionalSubject1;
        AdditionalSubject2 = additionalSubject2;
    }

    public override double CalculateAverageScore()
    {
        double baseAverage = base.CalculateAverageScore();
        return (baseAverage + AdditionalSubject1 + AdditionalSubject2) / 5;
    }
}

class GroupC : Group
{
    public int AdditionalSubject1;
    public int AdditionalSubject2;

    public GroupC(int groupNumber, int[] examScores, int additionalSubject1, int additionalSubject2)
        : base(groupNumber, examScores)
    {
        AdditionalSubject1 = additionalSubject1;
        AdditionalSubject2 = additionalSubject2;
    }

    public override double CalculateAverageScore()
    {
        double baseAverage = base.CalculateAverageScore();
        return (baseAverage + AdditionalSubject1 + AdditionalSubject2) / 5;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Group[] groups = GetGroupsData();

        SortGroupsByAverageScore(groups);

        Console.WriteLine("Средний балл по группам (в порядке убывания):");
        Console.WriteLine("{0,-10} {1}", "Группа", "Средний балл");
        foreach (var group in groups)
        {
            Console.WriteLine("{0,-10} {1:F2}", group.GroupNumber, group.CalculateAverageScore());
        }
    }

    static Group[] GetGroupsData()
    {
        Group[] groups = new Group[]
        {
            new GroupA(101, new int[] { 85, 90, 92, 88, 87 }, 95, 93),
            new GroupB(102, new int[] { 78, 82, 80, 79, 81 }, 85, 88),
            new GroupC(103, new int[] { 95, 94, 97, 92, 93 }, 90, 91)
        };

        return groups;
    }

    static void SortGroupsByAverageScore(Group[] groups)
    {
        for (int i = 0; i < groups.Length - 1; i++)
        {
            for (int j = i + 1; j < groups.Length; j++)
            {
                if (groups[j].CalculateAverageScore() > groups[i].CalculateAverageScore())
                {
                    (groups[i], groups[j]) = (groups[j], groups[i]);
                }
            }
        }
    }
}
