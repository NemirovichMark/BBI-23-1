#region 1_1
/*
using System;
class Programm 
{
    public struct JumpResult
    {
        private string lastName;
        private string society;
        private double Result1;
        private double Result2;
        private double totalResult;
        public JumpResult(string lastName, string society, double Result1, double Result2)
        {
            this.lastName = lastName;
            this.society = society;
            this.Result1 = Result1;
            this.Result2 = Result2;
            this.totalResult = Result1 + Result2;
        }
        public string LastName { get { return lastName; } }
        public string Society { get { return society; } }
        public double TotalResult { get { return totalResult; } }
        public override string ToString()
        {
            return string.Format("{0,-10} {1,11} {2,17} {3,14} {4,15}", lastName, society, Result1, Result2, totalResult);
        }
    }
    class JumpCompetition
    {
        static void Main()
        {
            JumpResult[] results = new JumpResult[]
            {
            new JumpResult("Хрищанович", "МИСиС", 2, 1.9),
            new JumpResult("Щерба", "БГЭУ", 2, 1.8),
            new JumpResult("Джурабоев", "МЭИ", 2.1, 1.7),
            new JumpResult("Мисюк", "БГУ", 2.1, 1.9),
            new JumpResult("Васечкин", "МИРЭА", 2.0, 1.85)
            };
            Array.Sort(results, (x, y) => y.TotalResult.CompareTo(x.TotalResult));
            Console.WriteLine("{0,-15} {1,-15} {2,5} {3,15} {4,11}", "Фамилия", "Общество", "1-ая попытка", "2-ая попытка", "Итого");
            Console.WriteLine(new string('-', 60));
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }
    }
}
*/
#endregion
#region 2_1
/*
using System;

class Program
{
    struct Student
    {
        private string famile;
        private double mark;

        public Student(string f, int mark1, int mark2, int mark3, int mark4)
        {
            famile = f;
            mark = (double)(mark1 + mark2 + mark3 + mark4) / 4;
        }

        public string Famile
        {
            get { return famile; }
            set { famile = value; }
        }

        public double Mark
        {
            get { return mark; }
            set { mark = value; }
        }
    }

    static void Main()
    {
        Student[] st = new Student[5];
        st[0] = new Student("студент1", 5, 5, 2, 5);
        st[1] = new Student("студент2", 5, 4, 5, 5);
        st[2] = new Student("студент3", 3, 2, 3, 4);
        st[3] = new Student("студент4", 4, 2, 5, 5);
        st[4] = new Student("студент5", 3, 5, 4, 3);

        for (int i = 0; i < st.Length; i++)
        {
            Console.WriteLine($" {st[i].Famile}\tбалл {st[i].Mark}");
        }

        for (int i = 0; i < st.Length; i++)
        {
            for (int j = 0; j < st.Length - 1; j++)
            {
                if (st[j].Mark < st[j + 1].Mark)
                {
                    (st[j], st[j + 1]) = (st[j + 1], st[j]);
                }
            }
        }

        Console.WriteLine();

        for (int i = 0; i < st.Length; i++)
        {
            if (st[i].Mark >= 4)
            {
                Console.WriteLine($" {st[i].Famile}\t балл {st[i].Mark}");
            }
            else break;
        }
    }
}
*/
#endregion
#region 3_5
using System;
class FootballTeam
{
    private string teamName;
    private int goalsScored;
    private int goalsConceded;
    private int points;

    public FootballTeam(string name)
    {
        teamName = name;
        goalsScored = 0;
        goalsConceded = 0;
        points = 0;
    }

    public void PlayMatch(int scored, int conceded)
    {
        goalsScored += scored;
        goalsConceded += conceded;
        if (scored > conceded)
            points += 3;
        else if (scored == conceded)
            points += 1;
    }

    public string GetTeamName()
    {
        return teamName;
    }

    public int GetPoints()
    {
        return points;
    }

    public int GetGoalDifference()
    {
        return goalsScored - goalsConceded;
    }
}

class Program
{
    static void Main()
    {
        List<FootballTeam> teams = new List<FootballTeam>();
        teams.Add(new FootballTeam("Барселона"));
        teams.Add(new FootballTeam("Манчестер Юнайтед"));
        teams.Add(new FootballTeam("Реал Мадрид"));
        teams.Add(new FootballTeam("Пари Сен-Жермен"));

        teams[0].PlayMatch(2, 1);
        teams[1].PlayMatch(1, 3);
        teams[2].PlayMatch(3, 2);
        teams[3].PlayMatch(2, 2);

        teams.Sort((x, y) =>
        {
            if (x.GetPoints() != y.GetPoints())
                return y.GetPoints().CompareTo(x.GetPoints());
            else
                return y.GetGoalDifference().CompareTo(x.GetGoalDifference());
        });

        Console.WriteLine("Результаты турнира:");
        for (int i = 0; i < teams.Count; i++)
        {
            Console.WriteLine($"Место {i + 1}: {teams[i].GetTeamName()} - {teams[i].GetPoints()} очков");
        }
    }
}

#endregion 




