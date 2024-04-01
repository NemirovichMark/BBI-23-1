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
        public void Print()
        {
            Console.WriteLine($" {famile}\tбалл  {mark}");
        }


        public string Famile
        {
            get { return famile; }
        }

        public double Mark
        {
            get { return mark; }
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
            for (int j = 0; j < st.Length - 1; j++)
            {
                if (st[j].Mark < st[j + 1].Mark)
                {
                    (st[j], st[j + 1]) = (st[j + 1], st[j]);
                }
            }
        }

        Console.WriteLine();
        Console.WriteLine(" Студенты ");
        for (int i = 0; i < st.Length; i++)
        {
            if (st[i].Mark >= 4)
            {
                st[i].Print();
            }
        }
    }
}
*/
#endregion

#region 3_5
/*
struct FootballTeam
{
    private string name;
    private int Scored;
    private int Failed; 
    private int points;
    public FootballTeam(string name)
    {
        this.name = name;
        Scored = 0; 
        Failed = 0;
        points = 0;
    }
    public string Name { get { return name; } set { name = value; } }
    public void Result(int scored, int conceded)
    {
        Scored += scored;
        Failed += conceded; 
        if (scored > conceded) points += 3;
        else if (scored == conceded) points += 1;
    }
    public int Points { get { return points; } }
    public int Difference { get { return Scored - Failed; } }
    public static void Print(FootballTeam[] teams)
    {
        Console.WriteLine("  Place      Team          Points");
        for (int i = 0; i < teams.Length; i++)
        {
            Console.WriteLine("{0,5}     {1,-6}      {2} ", i + 1, teams[i].Name, teams[i].Points);
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        FootballTeam[] teams = new FootballTeam[]        
        {
            new FootballTeam("Барселона"),            
            new FootballTeam("Реал Мадрид"),
            new FootballTeam("Дерби Каунти")        
        };
        Match(ref teams[0], ref teams[1]);
        Match(ref teams[0], ref teams[2]);
        Match(ref teams[1], ref teams[0]);
        Match(ref teams[1], ref teams[2]);
        Sort(teams); FootballTeam.Print(teams);
    }
    static void Match(ref FootballTeam team1, ref FootballTeam team2)
    {
        Random random = new Random(); 
        int scored = random.Next(0, 5);
        int conceded = random.Next(0, 5);
        team1.Result(scored, conceded);
        team2.Result(conceded, scored);
    }
    static void Sort(FootballTeam[] teams)
    {
        int n = teams.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (teams[j].Points < teams[j + 1].Points || (teams[j].Points == teams[j + 1].Points && teams[j].Difference < teams[j + 1].Difference))
                {
                    FootballTeam temp = teams[j];
                    teams[j] = teams[j + 1]; teams[j + 1] = temp;
                }
            }
        }
    }
}
*/
#endregion
