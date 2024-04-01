using System;

class Programm
{
    
    struct Competition
    {
        public string lastName, club;
        public int[] results;
        public int sumRes;
    }

    // Для задания 2_1
    struct Student
    {
        public string famile;
        public double mark;
        public Student(string f, int mark1, int mark2, int mark3, int mark4)
        {
            famile = f;
            mark = (double)(mark1 + mark2 + mark3 + mark4) / 4;
        }
    }

    // Для задания 3_2
    struct Team
    {  
        private string name;
        private int _zabit;
        private int _propusk;
        private int _ochki;

        public string Name => name;
        public int Zabit => _zabit;
        public int Propusk => _propusk;
        public int Ochki => _ochki;

        public Team(string name, int Zabit, int Propusk)
        {
            this.name = name;
            this._zabit = Zabit;
            this._propusk = Propusk;
            if (Zabit > Propusk)
            {
                _ochki = 3;
            }
            else if (Zabit == Propusk)
            {
                _ochki = 1;
            }
            else
            {
                _ochki = 0;
            }
        }

        public string PrintTeamInfo()
        {
            return $"{Name}: {Ochki} очков";
        }
    }

    public void TaskOne()
    {
        Console.Write("Количество участников: ");
        int n = int.Parse(Console.ReadLine());
        Competition[] sh = new Competition[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Фамилия {i + 1} участника: ");
            sh[i].lastName = Console.ReadLine();
            Console.Write($"Клуб {i + 1} участника: ");
            sh[i].club = Console.ReadLine();
            sh[i].results = new int[2];
            for (int j = 0; j < 2; j++)
            {
                Console.Write($"{j + 1} результат {i + 1} участника: ");
                sh[i].results[j] = int.Parse(Console.ReadLine());
            }

            int tempSum = 0;
            for (int j = 0; i < sh[i].results.Length(); i++) {
                tempSum += sh[i].results[j]
            }

            sh[i].sumRes = tempSum;
        }

        Array.Sort(sh, (x, y) => x.sumRes.CompareTo(y.sumRes));

        Console.Clear();
        Console.WriteLine("Место\tФамилия\tКлуб\tСумма результатов");
        for (int i = 0; i < n; i++)
            Console.WriteLine($"{i + 1}\t{sh[i].lastName}\t{sh[i].club}\t{sh[i].sumRes}");
        Console.ReadLine();
    }

    public void TaskTwo()
    {
        Student[] st = new Student[5];
        st[0] = new Student("студент1", 5, 5, 2, 5);
        st[1] = new student("студент2", 5, 4, 5, 5);
        st[2] = new Student("студент3", 3, 2, 3, 4);
        st[3] = new Student("студент4", 4, 2, 5, 5);
        st[4] = new Student("студент5", 3, 5, 4, 3);
        for (int i = 0; i < st.Length; i++)
        {
            Console.WriteLine($"фамилия {st[i].famile}\t балл {st[i].mark}");
        }
        for (int i = 0; i < st.Length; i++)
        {
            for (int j = 0; j < st.Length - 1; j++)
            {
                if (st[j].mark < st[j + 1].mark)
                {
                    (st[j], st[j + 1]) = (st[j + 1], st[j]);
                }
            }
        }
        Console.WriteLine();
        for (int i = 0; i < st.Length; i++)
        {
            if (st[i].mark >= 4)
            {
                Console.WriteLine($"фамилия {st[i].famile}\t балл {st[i].mark}");
            }
            else break;
        }
    }

    public void TaskThree()
    {
        Team[] teams = new Team[5];
        teams[0] = new Team("Барселона", 1, 1);
        teams[1] = new Team("Дерби Каунти", 3, 1);
        teams[2] = new Team("Манчестер Юнайтед", 4, 0);
        teams[3] = new Team("Реал Мадрид", 2, 3);
        teams[4] = new Team("Пари Сен-Жермен", 2, 2);

        for (int i = 0; i < teams.Length - 1; i++)
        {
            for (int j = i + 1; j < teams.Length; j++)
            {

                if (teams[i].Ochki < teams[j].Ochki)
                {
                    Team temp = teams[i];
                    teams[i] = teams[j];
                    teams[j] = temp;
                }
                else if (teams[i].Ochki == teams[j].Ochki)
                {
                    int diff1 = teams[i].Zabit - teams[i].Propusk;
                    int diff2 = teams[j].Zabit - teams[j].Propusk;
                    if (diff1 < diff2)
                    {
                        Team temp = teams[i];
                        teams[i] = teams[j];
                        teams[j] = temp;
                    }
                }
            }
        }

        Console.WriteLine("Таблица результатов:");
        for (int i = 0; i < teams.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {teams[i].PrintTeamInfo()}");
        }
    }
    public static void Main(string[] args)
    {
        TaskOne();
        TaskTwo();
        TaskThree();
    }
}
