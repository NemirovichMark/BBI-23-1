#region 6.1.5
using System;

namespace StudentGrades
{
    class Program
    {
        private struct Student
        {
            private string name;
            private int grade;
            private int missedClasses;

            public Student(string name, int grade, int missedClasses)
            {
                this.name = name;
                this.grade = grade;
                this.missedClasses = missedClasses;
            }

            public string Name
            {
                get { return name; }
            }

            public int Grade
            {
                get { return grade; }
            }

            public int MissedClasses
            {
                get { return missedClasses; }
            }
        }

        static void Main(string[] args)
        {

            Student[] students = new Student[5];
            students[0] = new Student("Клименко", 2, 5);
            students[1] = new Student("Радченко", 4, 2);
            students[2] = new Student("Шерстобитова", 2, 7);
            students[3] = new Student("Крамер", 3, 1);
            students[4] = new Student("Рудь", 2, 3);

            Console.WriteLine("Неуспевающие студенты в порядке убывания количества пропущенных занятий:");
            PrintFailingStudents(students);
        }

        static void PrintFailingStudents(Student[] students)
        {

            Student[] failingStudents = new Student[students.Length];
            int count = 0;


            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Grade == 2)
                {
                    failingStudents[count] = students[i];
                    count++;
                }
            }


            for (int i = 0; i < count - 1; i++)
            {
                for (int j = 0; j < count - i - 1; j++)
                {
                    if (failingStudents[j].MissedClasses < failingStudents[j + 1].MissedClasses)
                    {
                        Student temp = failingStudents[j];
                        failingStudents[j] = failingStudents[j + 1];
                        failingStudents[j + 1] = temp;
                    }
                }
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Имя: {failingStudents[i].Name}, Пропущенные занятия: {failingStudents[i].MissedClasses}");
            }
        }
    }
}
#endregion


#region 6.2.2
using System;

namespace ExamResults
{
    class Program
    {
        private struct Student
        {
            private string name;
            private int math;
            private int physics;
            private int russian;

            public Student(string name, int math, int physics, int russian)
            {
                this.name = name;
                this.math = math;
                this.physics = physics;
                this.russian = russian;
            }

            public string Name
            {
                get { return name; }
            }

            public int Math
            {
                get { return math; }
            }

            public int Physics
            {
                get { return physics; }
            }

            public int Russian
            {
                get { return russian; }
            }

            public double Average
            {
                get { return (math + physics + russian) / 3.0; }
            }

            public bool IsPassed
            {
                get { return math > 2 && physics > 2 && russian > 2; }
            }
        }

        static void Main(string[] args)
        {

            Student[] students = new Student[5];
            students[0] = new Student("Шерстобитова", 5, 4, 3);
            students[1] = new Student("Клименко", 2, 4, 5);
            students[2] = new Student("Рудь", 3, 4, 4);
            students[3] = new Student("Крамер", 5, 5, 5);
            students[4] = new Student("Радченко", 3, 2, 3);


            Console.WriteLine("Учащиеся, успешно сдавшие экзамены, в порядке убывания среднего балла:");
            PrintPassedStudents(students);
        }

        static void PrintPassedStudents(Student[] students)
        {
            Student[] passedStudents = new Student[students.Length];
            int count = 0;

            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].IsPassed)
                {
                    passedStudents[count] = students[i];
                    count++;
                }
            }
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = 0; j < count - i - 1; j++)
                {
                    if (passedStudents[j].Average < passedStudents[j + 1].Average)
                    {
                        Student temp = passedStudents[j];
                        passedStudents[j] = passedStudents[j + 1];
                        passedStudents[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Имя: {passedStudents[i].Name}, Средний балл: {passedStudents[i].Average:F2}");
            }
        }
    }
}
#endregion


#region 6.3.2
using System;

namespace FootballChampionship
{
    struct Team
    {
        private string name;
        private int points;
        private int goalsFor;
        private int goalsAgainst;
        public Team(string name)
        {
            this.name = name;
            this.points = 0;
            this.goalsFor = 0;
            this.goalsAgainst = 0;
        }
        public string Name
        {
            get { return name; }
        }
        public int Points
        {
            get { return points; }
        }
        public void UpdateResults(int goalsFor, int goalsAgainst)
        {
            this.goalsFor += goalsFor;
            this.goalsAgainst += goalsAgainst;
            if (goalsFor > goalsAgainst)
            {
                points += 3; // Победа
            }
            else if (goalsFor == goalsAgainst)
            {
                points += 1; // Ничья
            }
        }

        public int GoalDifference()
        {
            return goalsFor - goalsAgainst;
        }
    }

    class Championship
    {
        private Team[] teams;

        public Championship(string[] teamNames)
        {
            teams = new Team[teamNames.Length];
            for (int i = 0; i < teamNames.Length; i++)
            {
                teams[i] = new Team(teamNames[i]);
            }
        }

        public void PlayMatch(int team1Index, int team2Index, int team1Goals, int team2Goals)
        {
            teams[team1Index].UpdateResults(team1Goals, team2Goals);
            teams[team2Index].UpdateResults(team2Goals, team1Goals);
        }

        public void SortTeams()
        {
            for (int i = 0; i < teams.Length - 1; i++)
            {
                for (int j = 0; j < teams.Length - i - 1; j++)
                {
                    if (teams[j].Points < teams[j + 1].Points ||
                        (teams[j].Points == teams[j + 1].Points && teams[j].GoalDifference() < teams[j + 1].GoalDifference()))
                    {
                        Team temp = teams[j];
                        teams[j] = teams[j + 1];
                        teams[j + 1] = temp;
                    }
                }
            }
        }
        public void PrintTable()
        {
            Console.WriteLine("Место\tКоманда\tОчки");
            for (int i = 0; i < teams.Length; i++)
            {
                Console.WriteLine($"{i + 1}\t{teams[i].Name}\t{teams[i].Points}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] teamNames = { "Сморчи", "БалБИсы", "Фанатки" };
            Championship championship = new Championship(teamNames);
            // Проведение матчей
            championship.PlayMatch(0, 1, 2, 1); // Сморчи vs БалБИсы
            championship.PlayMatch(0, 2, 1, 3); // Сморчи vs Фанатки
            championship.PlayMatch(1, 2, 0, 0); // БалБИсы vs Фанатки

            championship.SortTeams();
            championship.PrintTable();
        }
    }
}
#endregion
