using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Женские команды
        Participant[] womenTeam1Results = GetTeamResults("Женская команда 1", 6);
        WomenTeam womenTeam1 = new WomenTeam("Женская команда 1", womenTeam1Results);

        Participant[] womenTeam2Results = GetTeamResults("Женская команда 2", 6);
        WomenTeam womenTeam2 = new WomenTeam("Женская команда 2", womenTeam2Results);

        Participant[] womenTeam3Results = GetTeamResults("Женская команда 3", 6);
        WomenTeam womenTeam3 = new WomenTeam("Женская команда 3", womenTeam3Results);

        // Мужские команды
        Participant[] menTeam1Results = GetTeamResults("Мужская команда 1", 6);
        MenTeam menTeam1 = new MenTeam("Мужская команда 1", menTeam1Results);

        Participant[] menTeam2Results = GetTeamResults("Мужская команда 2", 6);
        MenTeam menTeam2 = new MenTeam("Мужская команда 2", menTeam2Results);

        Participant[] menTeam3Results = GetTeamResults("Мужская команда 3", 6);
        MenTeam menTeam3 = new MenTeam("Мужская команда 3", menTeam3Results);

        // Соревнования внутри женских команд
        ConductCompetition(womenTeam1);
        ConductCompetition(womenTeam2);
        ConductCompetition(womenTeam3);

        // Соревнования внутри мужских команд
        ConductCompetition(menTeam1);
        ConductCompetition(menTeam2);
        ConductCompetition(menTeam3);

        // Определение победителей
        WomenTeam winner1 = DetermineWinner(womenTeam1, womenTeam2, womenTeam3);
        MenTeam winner2 = DetermineWinner(menTeam1, menTeam2, menTeam3);

        // Определение победителя между победителями женских и мужских команд
        Team winner3;
        if (winner1.CalculateScore() > winner2.CalculateScore())
        {
            winner3 = winner1;
        }
        else if (winner2.CalculateScore() > winner1.CalculateScore())
        {
            winner3 = winner2;
        }
        else
        {
            // Если ничья, можно выбрать любого победителя
            winner3 = winner1;
        }

        // Вывод результатов
        Console.WriteLine($"Победитель среди женских команд: {winner1.Name}");
        DisplayResults(winner1);
        Console.WriteLine($"Победитель среди мужских команд: {winner2.Name}");
        DisplayResults(winner2);
        Console.WriteLine($"Победитель между победителями женских и мужских команд: {winner3.Name}");
        DisplayResults(winner3);
    }

    static Participant[] GetTeamResults(string teamName, int participantsCount)
    {
        Console.WriteLine($"Введите результаты соревнований для {teamName} (числа от 1 до 18):");
        Participant[] results = new Participant[participantsCount];
        for (int j = 0; j < participantsCount; j++)
        {
            Console.Write($"Участник {j + 1}: ");
            int place = int.Parse(Console.ReadLine());
            results[j] = new Participant($"Участник {j + 1}", place);
        }
        return results;
    }

    static void ConductCompetition(Team team)
    {
        Array.Sort(team.Participants);
    }

    static T DetermineWinner<T>(params T[] teams) where T : Team
    {
        T winner = teams[0];
        foreach (var team in teams)
        {
            if (team.CalculateScore() > winner.CalculateScore())
            {
                winner = team;
            }
        }
        return winner;
    }

    static void DisplayResults(Team team)
    {
        Console.WriteLine($"Результаты для команды {team.Name}:");
        Console.WriteLine("Участник\tМесто");
        foreach (var participant in team.Participants)
        {
            Console.WriteLine($"{participant.Name}\t\t{participant.Place}");
        }
        Console.WriteLine();
    }
}

struct Participant : IComparable<Participant>
{
    private string name;
    private int place;

    public string Name => name;
    public int Place => place;

    public Participant(string name, int place)
    {
        this.name = name;
        if (place >= 1 && place <= 18)
        {
            this.place = place;
        }
        else
        {
            this.place = -1;
        }
    }

    public int CompareTo(Participant other)
    {
        return this.place.CompareTo(other.place);
    }
}

class Team
{
    protected string name;
    protected Participant[] participants;

    public string Name => name;
    public Participant[] Participants => participants;

    public Team(string name, Participant[] participants)
    {
        this.name = name;
        this.participants = participants;
    }

    public virtual int CalculateScore()
    {
        int score = 0;
        foreach (var participant in participants)
        {
            int place = participant.Place;
            score += (place == 1) ? 5 : (place == 2) ? 4 : (place == 3) ? 3 : (place == 4) ? 2 : (place == 5) ? 1 : 0;
        }
        return score;
    }
}

class WomenTeam : Team
{
    public WomenTeam(string name, Participant[] participants) : base(name, participants)
    {
    }
}

class MenTeam : Team
{
    public MenTeam(string name, Participant[] participants) : base(name, participants)
    {
    }
}
