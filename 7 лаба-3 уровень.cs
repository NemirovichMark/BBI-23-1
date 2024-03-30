using System;

abstract class FootballTeam
{
    protected string _name;
    protected int _goalsFor;
    protected int _goalsAgainst;
    protected int _points;
    protected string _gender;

    public FootballTeam(string name, string gender)
    {
        _name = name;
        _gender = gender;
        _goalsFor = 0;
        _goalsAgainst = 0;
        _points = 0;
    }

    public void AddResult(int goalsFor, int goalsAgainst)
    {
        _goalsFor += goalsFor;
        _goalsAgainst += goalsAgainst;
        if (goalsFor > goalsAgainst)
        {
            _points += 3; // выигрыш
        }
        else if (goalsFor == goalsAgainst)
        {
            _points += 1; // ничья
        }
    }

    public string Name { get { return _name; } }
    public int GoalsFor { get { return _goalsFor; } }
    public int GoalsAgainst { get { return _goalsAgainst; } }
    public int Points { get { return _points; } }
    public string Gender { get { return _gender; } }
}

class FemaleFootballTeam : FootballTeam
{
    public FemaleFootballTeam(string name) : base(name, "женская") { }
}

class MaleFootballTeam : FootballTeam
{
    public MaleFootballTeam(string name) : base(name, "мужская") { }
}

class Program
{
    static void Main()
    {
        FootballTeam[] allTeams = new FootballTeam[]
        {
            new FemaleFootballTeam("ЦСКА"),
            new MaleFootballTeam("Динамо"),
            new MaleFootballTeam("Спартак")
        };

        Random random = new Random();

        foreach (var team in allTeams)
        {
            // Проведение отдельных соревнований для каждой команды
            for (int i = 0; i < 3; i++)
            {
                int goalsFor = random.Next(0, 5); // генерация случайного количества голов за команду
                int goalsAgainst = random.Next(0, 5); // генерация случайного количества голов противника
                team.AddResult(goalsFor, goalsAgainst);
            }
        }

        // Сортировка команд по общему количеству баллов
        Array.Sort(allTeams, (x, y) => y.Points.CompareTo(x.Points));

        Console.WriteLine("Место\tКоманда\t\tОчки\tПол");
        for (int i = 0; i < allTeams.Length; i++)
        {
            Console.WriteLine("{0}\t{1}\t\t{2}\t{3}", i + 1, allTeams[i].Name, allTeams[i].Points, allTeams[i].Gender);
        }
    }
}