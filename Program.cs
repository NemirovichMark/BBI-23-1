using System;

class Team
{
    public string Name { get; private set; }
    public int Win { get; private set; }
    public int Lose { get; private set; }
    public int Draw { get; private set; }
    public int Goal { get; private set; }
    public int Miss { get; private set; }
    public int Score { get; private set; }

    public Team(string Name)
    {
        this.Name = Name;
        this.Win = 0;
        this.Lose = 0;
        this.Draw = 0;
        this.Goal = 0;
        this.Miss = 0;
        this.Score = 0;
    }

    public static bool operator ==(Team A, Team B)
    {
        return A.Name == B.Name;
    }

    public static bool operator !=(Team A, Team B)
    {
        return A.Name != B.Name;
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        Team other = (Team)obj;
        return Name == other.Name;
    }

    public override int GetHashCode()
    {
        return Name.GetHashCode();
    }

    public void SetScore(int a, int b)
    {
        int A = 0, B = 0, C = 0;
        if (a > b) A++;
        if (a < b) B++;
        if (a == b) C++;

        this.Win += A;
        this.Lose += B;
        this.Draw += C;
        this.Goal += a;
        this.Miss += b;
        this.Score += A * 3 + C * 1;
    }
}

class Match
{
    public Team[] T { get; private set; }
    public int n { get; private set; }

    public Match()
    {
        this.T = new Team[100];
        this.n = 0;
    }

    public void Add(string NameA, string NameB, int a, int b)
    {
        bool f = false;
        for (int i = 0; i < n; i++)
        {
            if (T[i].Name == NameA)
            {
                T[i].SetScore(a, b);
                f = true;
                break;
            }
        }
        if (!f)
        {
            T[n] = new Team(NameA);
            T[n].SetScore(a, b);
            n++;
        }

        f = false;
        for (int i = 0; i < n; i++)
        {
            if (T[i].Name == NameB)
            {
                T[i].SetScore(b, a);
                f = true;
                break;
            }
        }
        if (!f)
        {
            T[n] = new Team(NameB);
            T[n].SetScore(b, a);
            n++;
        }
    }

    public void Sort()
    {
        GnomeSort(T, n);
    }

    private void GnomeSort(Team[] arr, int length)
    {
        int index = 0;

        while (index < length)
        {
            if (index == 0 || arr[index].Score <= arr[index - 1].Score)
            {
                index++;
            }
            else
            {
                Team temp = arr[index];
                arr[index] = arr[index - 1];
                arr[index - 1] = temp;
                index--;
            }
        }
    }
}

class MainClass
{
    public static void Main(string[] args)
    {
        Match M = new Match();
        M.Add("Медведи", "Динамо", 3, 0);
        M.Add("Зенит", "Море", 4, 1);
        M.Add("Восход", "Алмаз", 0, 2);
        M.Add("Медведи", "Алмаз", 2, 3);
        M.Add("Зенит", "Динамо", 5, 1);
        M.Add("Море", "Восход", 2, 1);
        M.Add("Зенит", "Восход", 2, 3);

        M.Sort();

        for (int i = 0; i < M.n; i++)
        {
            Console.WriteLine(i + 1 + ". " + M.T[i].Name + ": " + M.T[i].Score);
        }
    }
}