using System;
public struct Participant
{
    private int place;
    public Participant(int place)
    {
        this.place = place;
    }
    public int GetPlace()
    {
        return place;
    }
}
public class Team
{
    private Participant[] participants;
    public string name;
    public Team(int[] places, string name)
    {
        participants = new Participant[6];
        for (int i = 0; i < 6; i++)
        {
            participants[i] = new Participant(places[i]);
        }
        this.name = name;
    }
    public virtual int CalculateScore()
    {
        int score = 0;
        for (int i = 0; i < participants.Length; i++)
        {
            int place = participants[i].GetPlace();
            if (place == 1)
            {
                score += 5;
            }
            else if (place == 2)
            {
                score += 4;
            }
            else if (place == 3)
            {
                score += 3;
            }
            else if (place == 4)
            {
                score += 2;
            }
            else if (place == 5)
            {
                score += 1;
            }
        }
        return score;
    }
    public virtual string GetTeamType()
    {
        return "команда";
    }
    public string GetName()
    {
        return name;
    }
    public int[] GetPlaces()
    {
        int[] places = new int[participants.Length];
        for (int i = 0; i < participants.Length; i++)
        {
            places[i] = participants[i].GetPlace();
        }
        return places;
    }
}

public class MenTeam : Team
{
    public MenTeam(int[] places, string name) : base(places, name) { }
    public override string GetTeamType()
    {
        return "мужская";
    }
}
public class WomenTeam : Team
{
    public WomenTeam(int[] places, string name) : base(places, name) { }
    public override string GetTeamType()
    {
        return "женская";
    }
}
class Program
{
    static void Main(string[] args)
    {
        MenTeam[] menTeams = new MenTeam[]
        {
            new MenTeam(new int[] { 2, 5, 8, 3, 7, 1 }, "Men team 1"),
            new MenTeam(new int[] { 9, 4, 1, 8, 2, 7 }, "Men team 2"),
            new MenTeam(new int[] { 3, 9, 1, 5, 4, 6 }, "Men team 3")
        };
        WomenTeam[] womenTeams = new WomenTeam[]
        {
            new WomenTeam(new int[] { 6, 3, 1, 5, 2, 4 }, "Women team 1"),
            new WomenTeam(new int[] { 1, 7, 4, 2, 6, 3 }, "Women team 2"),
            new WomenTeam(new int[] { 3, 2, 5, 7, 1, 9 }, "Women team 3")
        };

        InsertionSort(menTeams);
        InsertionSort(womenTeams);

        Team bestMenTeam = menTeams[0];
        int bestMenScore = menTeams[0].CalculateScore();
        Console.WriteLine($"Лучшая мужская команда '{bestMenTeam.GetName()}' с местами: [{string.Join(", ", bestMenTeam.GetPlaces())}] и финальным счетом: {bestMenScore}");

        Team bestWomenTeam = womenTeams[0];
        int bestWomenScore = womenTeams[0].CalculateScore();
        Console.WriteLine($"Лучшая женская команда '{bestWomenTeam.GetName()}' с местами: [{string.Join(", ", bestWomenTeam.GetPlaces())}] и финальным счетом: {bestWomenScore}");

        Team[] allTeams = MergeTeams(menTeams, womenTeams);
        Console.WriteLine("Объединенный и упорядоченный массив команд:");
        foreach (Team team in allTeams)
        {
            Console.WriteLine($"{team.GetTeamType()} команда '{team.GetName()}' с финальным счетом: {team.CalculateScore()}");
        }
        Team bestTeam = allTeams[0];
        int bestScore = bestTeam.CalculateScore();
        Console.WriteLine($"Победила {bestTeam.GetTeamType()} команда '{bestTeam.GetName()}' со счетом {bestScore}");
    }
    static void InsertionSort(Team[] teams)
    {
        for (int i = 1; i < teams.Length; i++)
        {
            Team key = teams[i];
            int j = i - 1;
            while (j >= 0 && teams[j].CalculateScore() < key.CalculateScore())
            {
                teams[j + 1] = teams[j];
                j--;
            }
            teams[j + 1] = key;
        }
    }
    static Team[] MergeTeams(Team[] firstArray, Team[] secondArray)
    {
        Team[] mergedArray = new Team[firstArray.Length + secondArray.Length];

        int i = 0, j = 0, k = 0;

        while (i < firstArray.Length && j < secondArray.Length)
        {
            if (firstArray[i].CalculateScore() >= secondArray[j].CalculateScore())
            {
                mergedArray[k++] = firstArray[i++];
            }
            else
            {
                mergedArray[k++] = secondArray[j++];
            }
        }
        while (i < firstArray.Length)
        {
            mergedArray[k++] = firstArray[i++];
        }
        while (j < secondArray.Length)
        {
            mergedArray[k++] = secondArray[j++];
        }

        return mergedArray;
    }
}





