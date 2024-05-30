using ProtoBuf;
using System;
using System.Xml.Serialization;
public class Program
{
    [XmlInclude(typeof(WomanTeam))]
    [XmlInclude(typeof(ManTeam))]
    [ProtoInclude(69, typeof(WomanTeam))]
    [ProtoInclude(96, typeof(ManTeam))]
    [Serializable]
    [ProtoContract]
    public abstract class FootballTeam
    {
        protected string _name;
        protected int _totalScore;
        protected int _goals;

        [XmlElement(ElementName = "Name")]
        [ProtoMember(1)]
        public string Name { get { return _name; } set { _name = value; } }

        [XmlElement(ElementName = "TotalScore")]
        [ProtoMember(2)]
        public int TotalScore { get { return _totalScore; } set { _totalScore = value; } }

        [XmlElement(ElementName = "Goals")]
        [ProtoMember(3)]
        public int Goals { get { return _goals; } set { _goals = value; } }

        public FootballTeam() { }
        public FootballTeam(string name)
        {
            _name = name;
            _totalScore = 0;
            _goals = 0;
        }

        public void Print()
        {
            Console.WriteLine(_name + ", " + _totalScore + " очков");
        }
        public void Win(int goals)
        {
            _totalScore += 3;
            _goals += goals;
        }
        public void Lose(int goals)
        {
            _goals -= goals;
        }
        public void Сounter()
        {
            _totalScore += 1;
        }

    }
    public class WomanTeam : FootballTeam
    {
        public WomanTeam() { }
        public WomanTeam(string name) : base(name)
        {
            _name = name + " женская";
        }
    }
    public class ManTeam : FootballTeam
    {
        public ManTeam() { }
        public ManTeam(string name) : base(name)
        {
            _name = name + " мужская";
        }
    }
    static void Match(ref FootballTeam team1, ref FootballTeam team2, int score1, int score2)
    {
        Console.WriteLine(team1.Name + " - " + team2.Name + " " + score1 + ":" + score2);
        int goals = Math.Abs(score1 - score2);
        if (score1 > score2)
        {
            team1.Win(goals);
            team2.Lose(goals);
        }
        else if (score1 < score2)
        {
            team2.Win(goals);
            team1.Lose(goals);
        }
        else
        {
            team1.Сounter();
            team2.Сounter();
        }
    }
    static void Sort(FootballTeam[] teams)
    {
        FootballTeam tmp;
        for (int i = 1; i < teams.Length; i++)
        {
            for (int j = i; j > 0 && ((teams[j].TotalScore > teams[j - 1].TotalScore) || (teams[j].TotalScore == teams[j - 1].TotalScore && teams[j].Goals > teams[j - 1].Goals)); j--)
            {
                tmp = teams[j];
                teams[j] = teams[j - 1];
                teams[j - 1] = tmp;
            }
        }
    }
    static void Main()
    {

        FootballTeam[] teams = new FootballTeam[10];
        FootballTeam[] manteams = new FootballTeam[5];
        FootballTeam[] womanteams = new FootballTeam[5];
        Random random = new Random();
        for (int i = 0; i < 5; i++)
        {
            manteams[i] = new ManTeam("Команда " + (i + 1));
        }
        for (int i = 0; i < 5; i++)
        {
            for (int j = i + 1; j < 5; j++)
            {
                int score1 = random.Next(0, 5);
                int score2 = random.Next(0, 5);
                Match(ref manteams[i], ref manteams[j], score1, score2);
            }
        }
        Console.WriteLine();
        for (int i = 0; i < 5; i++)
        {
            womanteams[i] = new WomanTeam("Команда " + (i + 1));
        }

        for (int i = 0; i < 5; i++)
        {
            for (int j = i + 1; j < 5; j++)
            {
                int score1 = random.Next(0, 5);
                int score2 = random.Next(0, 5);

                Match(ref womanteams[i], ref womanteams[j], score1, score2);
            }
        }
        Console.WriteLine();

        for (int i = 0; i < 5; i++)
        {
            teams[i] = manteams[i];
        }
        for (int i = 0; i < 5; i++)
        {
            teams[i + 5] = womanteams[i];
        }
        Sort(teams);
        Console.WriteLine();
        for (int i = 0; i < 10; i++)
        {
            Console.Write((i + 1) + " место - ");
            teams[i].Print();
        }

        List<FootballTeam> footballTeamList = new();
        footballTeamList.AddRange(manteams);
        footballTeamList.AddRange(womanteams);


        Stream file = File.Create(@"data\footballTeam.json");
        Stream data = JSONProcessing<FootballTeam>.Write(footballTeamList);
        data.CopyTo(file);
        file.Dispose();

        file = File.Create(@"data\footballTeam.xml");
        data = XMLProcessing<FootballTeam>.Write(footballTeamList);
        data.CopyTo(file);
        file.Dispose();

        file = File.Create(@"data\footballTeam.bin");
        data = BinProcessing<FootballTeam>.Write(footballTeamList);
        data.CopyTo(file);
        file.Dispose();

        footballTeamList = JSONProcessing<FootballTeam>.Read(new FileStream(@"data\footballTeam.json", FileMode.Open));
        Console.WriteLine("JSON файл:");
        for (int i = 0; i < footballTeamList.Count; i++)
        {
            footballTeamList[i].Print();
        }

        footballTeamList = XMLProcessing<FootballTeam>.Read(new FileStream(@"data\footballTeam.xml", FileMode.Open));
        Console.WriteLine("XML файл:");
        for (int i = 0; i < footballTeamList.Count; i++)
        {
            footballTeamList[i].Print();
        }

        footballTeamList = BinProcessing<FootballTeam>.Read(new FileStream(@"data\footballTeam.bin", FileMode.Open));
        Console.WriteLine("Bin файл:");
        for (int i = 0; i < footballTeamList.Count; i++)
        {
            footballTeamList[i].Print();
        }
    }
}
