#region 1.5
using System;
struct student
{
    public string famile; public int pass; public int grade;
}
class Program
{
    static void Main()
    {
        student[] students = new student[] 
        {
            new student { famile = "Шерстобитова", pass = 5, grade = 4 },            
            new student { famile = "Клименко", pass = 10, grade = 2 },
            new student { famile = "Крамер  ", pass = 13, grade = 2 },            
            new student { famile = "Рудь    ", pass = 9, grade = 2 }
        };
        for (int i = 0; i < students.Length - 1; i++)
        {
            for (int j = 0; j < students.Length - 1 - i; j++)
            {
                if (students[j].pass < students[j + 1].pass)
                {
                    student temp = students[j]; students[j] = students[j + 1]; students[j + 1] = temp;
                }
            }
        }
        Console.WriteLine("Список неуспевающих студентов в порядке убывания их пропусков:");
        Console.WriteLine("Фамилия \t" + "Пропуски \t"); Console.WriteLine();
        for (int i = 0; i < students.Length; i++)
        {
            if (students[i].grade == 2)
            {
                Console.WriteLine("{0} \t" + "{1} \t ", students[i].famile, students[i].pass);
            }
        }
    }
}
#endregion

#region 2.5
struct competitions
{
    public string name; public int meters;
    public int[] score;
    public int CanculateScore()
    {
        for (int i = 0; i < score.Length - 1; i++)
        {
            if (score[i] < score[i + 1])
            {
                int t = score[i]; score[i] = score[i + 1];
                score[i + 1] = t;
            }
        };
        int totalscore = 0;
        for (int i = 1; i < score.Length - 1; i++)
        {
            totalscore += score[i];
        }
        int dastancepoint = 60 + (meters - 120) * 2; totalscore += dastancepoint;
        return totalscore;
    }
}
class program
{
    static void Main()
    {
        competitions[] competition = new competitions[]
        {
            new competitions {name = "Шерстобитова", meters = 126, score = new int[] {18, 17, 16, 19, 20} },            
            new competitions {name = "Рудь        ", meters = 132, score = new int[] {16, 20, 15, 17, 16} },
            new competitions {name = "Букин       ", meters = 115, score = new int [] {15, 16, 14, 17, 18} },            
            new competitions {name = "Крамер      ", meters = 133, score = new int[] {12, 16, 17, 19, 16 } },
            new competitions {name = "Клименко    ", meters = 125, score = new int[] { 13, 15, 13, 17, 20} }        
        };
        for (int i = 0; i < competition.Length - 1; i++)
        {
            for (int j = 0; j < competition.Length - 1 - i; j++)
            {
                if (competition[j].CanculateScore() < competition[j + 1].CanculateScore())
                {
                    competitions temp = competition[j]; competition[j] = competition[j + 1];
                    competition[j + 1] = temp;
                }
            }
        }
        Console.WriteLine("Результаты совевнований: "); Console.WriteLine("Имя и Фамилия\t" + "Очки\t");
        for (int i = 0; i < competition.Length; i++)
        {
            Console.WriteLine($"{i + 1}." + "{0}\t" + "{1}\t", competition[i].name, competition[i].CanculateScore());
        }
    }
}
#endregion

#region 3.5
using System;
public struct Team
{
    public string Name;
    public int GoalsFor;
    public int GoalsAgainst;
    public int Wins;
    public int Draws;
    public int Losses;

    public int CalculatePoints()
    {
        int points = Wins * 3 + Draws;
        return points;
    }

    public int GoalDifference()
    {
        int goals = Math.Abs(GoalsFor - GoalsAgainst);
        return goals;
    }
}

class Program
{
    static void Main()
    {
        Team[] teams = new Team[]
        {
            new Team { Name = "Сморчи", GoalsFor = 10, GoalsAgainst = 5, Wins = 3, Draws = 1, Losses = 1 },
            new Team { Name = "КардиБишники", GoalsFor = 8, GoalsAgainst = 7, Wins = 2, Draws = 3, Losses = 0 },
            new Team { Name = "Генералы", GoalsFor = 12, GoalsAgainst = 4, Wins = 4, Draws = 0, Losses = 1 }
        };

        for (int i = 0; i < teams.Length - 1; i++)
        {
            for (int j = 0; j < teams.Length - 1 - i; j++)
            {
                if (teams[j].CalculatePoints() < teams[j + 1].CalculatePoints())
                {
                    Team temp = teams[j];
                    teams[j] = teams[j + 1];
                    teams[j + 1] = temp;
                }
                if (teams[j].CalculatePoints() == teams[j + 1].CalculatePoints())
                {
                    if (teams[j].GoalDifference() < teams[j + 1].GoalDifference())
                    {
                        Team temp = teams[j];
                        teams[j] = teams[j + 1];
                        teams[j + 1] = temp;
                    }
                }
            }
        }
        Console.WriteLine("Таблица результатов:");
        Console.WriteLine("Команда   \t" + "Очки\t");
        Console.WriteLine();
        for (int i = 0; i < teams.Length; i++)
        {
            Console.WriteLine($"{i + 1} " + "{0}\t" + "{1}\t", teams[i].Name, teams[i].CalculatePoints());
        }
    }
}
#endregion
