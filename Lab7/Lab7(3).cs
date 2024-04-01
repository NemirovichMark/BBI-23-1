using System;
using System.Linq;

struct Participant
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
}
class Team
{
    protected string name;
    protected Participant[,] participants;

    public string Name => name;
    public Participant[,] Participants => participants;

    public Team(string name, Participant[,] participants)
    {
        this.name = name;
        this.participants = participants;
    }

    public virtual int CalculateScore()
    {
        int score = 0;
        for (int i = 0; i < participants.GetLength(0); i++)
        {
            for (int j = 0; j < participants.GetLength(1); j++)
            {
                int place = participants[i, j].Place;
                score += (place == 1) ? 5 : (place == 2) ? 4 : (place == 3) ? 3 : (place == 4) ? 2 : (place == 5) ? 1 : 0;
            }
        }
        return score;
    }
}

class WomenTeam : Team
{
    public WomenTeam(string name, Participant[,] participants) : base(name, participants)
    {
    }
}

class MenTeam : Team
{
    public MenTeam(string name, Participant[,] participants) : base(name, participants)
    {
    }
}
class Program
{
    static void Main()
    {
        Participant[,] womenResults = new Participant[1, 6];
        Participant[,] menResults = new Participant[1, 6];

        Console.WriteLine("Введите результаты соревнований для женской команды (числа от 1 до 18):");
        for (int j = 0; j < 6; j++)
        {
            Console.Write($"Участница {j + 1}: ");
            int place = int.Parse(Console.ReadLine());
            womenResults[0, j] = new Participant($"Участница {j + 1}", place);
        }

        Console.WriteLine("Введите результаты соревнований для мужской команды (числа от 1 до 18):");
        for (int j = 0; j < 6; j++)
        {
            Console.Write($"Участник {j + 1}: ");
            int place = int.Parse(Console.ReadLine());
            menResults[0, j] = new Participant($"Участник {j + 1}", place);
        }

        WomenTeam womenTeam = new WomenTeam("Женская команда", womenResults);
        MenTeam menTeam = new MenTeam("Мужская команда", menResults);

        int womenScore = womenTeam.CalculateScore();
        int menScore = menTeam.CalculateScore();

        Team winner;

        if (womenScore > menScore)
        {
            Console.WriteLine($"Победила женская команда '{womenTeam.Name}' с {womenScore} баллами!");
            SortTeamsByScore(womenResults);
            dynamic winner = womenTeam;
        }
        else if (menScore > womenScore)
        {
            Console.WriteLine($"Победила мужская команда '{menTeam.Name}' с {menScore} баллами!");
            SortTeamsByScore(menResults);
            dynamic winner = menTeam;
        }
        else
        {
            Console.WriteLine("Ничья!");
            return;
        }

        Console.WriteLine("Таблица результатов:");
        Console.WriteLine("Команда\t\tУчастники\t\tОчки");

        DisplayTeamResults(winner);
    }

    static void DisplayTeamResults(Team team)
    {
        foreach (var participant in team.Participants)
        {
            Console.Write($"{team.Name}\t\t{participant.Name}\t\t{participant.Place}\n");
        }
    }

    static void SortTeamsByScore(Participant[,] teamResults)
    {
        int rowCount = teamResults.GetLength(0);
        int colCount = teamResults.GetLength(1);
        Participant[] tempArray = new Participant[rowCount * colCount];

        int index = 0;
        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < colCount; j++)
            {
                tempArray[index++] = teamResults[i, j];
            }
        }

        Array.Sort(tempArray, (x, y) => y.Place.CompareTo(x.Place));

        index = 0;
        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < colCount; j++)
            {
                teamResults[i, j] = tempArray[index++];
            }
        }
    }

    static void DisplaySortedResults(Participant[,] teamResults, string teamName)
    {
        foreach (var participant in teamResults)
        {
            Console.Write($"{teamName}\t\t{participant.Name}\t\t{participant.Place}\n");
        }
    }
}
