using System;
using ProtoBuf;
using System.IO;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using Lab9_3.SerializeHelper;
using System.Xml.Serialization;
using System.Net.Sockets;
using System.Text.Json.Serialization;

namespace Lab9_3
{
    [Serializable]
    [ProtoContract]
    [ProtoInclude(1, typeof(MensTeam))]
    [ProtoInclude(2, typeof(WomensTeam))]
    public class Team
    {
        [JsonIgnore]
        [NonSerialized]
        protected string _name;
        [JsonIgnore]
        [NonSerialized]
        protected int _goalsWon;
        [JsonIgnore]
        [NonSerialized]
        protected int _goalsLost;
        [JsonIgnore]
        [NonSerialized]
        protected int _point;
        
        [JsonInclude]
        [ProtoMember(3)]
        [XmlElement("Name")]
        public string Name { get { return _name; } set { _name = value ?? string.Empty; } }
        //[JsonIgnore]
        //[NonSerialized]
        //public int GoalsWon
        //{
        //    get { return _goalsWon; }
        //    set
        //    {
        //        if (value >= 0) _goalsWon = value;
        //    }
        //}
        //[JsonIgnore]
        //[NonSerialized]
        //public int GoalsLost
        //{
        //    get { return _goalsLost; }
        //    set
        //    {
        //        if (value >= 0) _goalsLost = value;
        //    }
        //}
        [JsonInclude]
        [ProtoMember(4)]
        [XmlElement("Point")]
        public int Point
        {
            get { return _point; }
            set
            {
                if (value >= 0) _point = value;
            }
        }
        protected int Difference()
        {
            return (_goalsWon - _goalsLost);
        }
        public Team(string name, int goalsWon, int goalsLost , int point)
        {
            _name = name;
            _goalsWon = goalsWon;
            _goalsLost = goalsLost;
            _point = point;
        }
        public Team(string name)
        {
            _name = name;
            _goalsWon = 0;
            _goalsLost = 0;
            _point = 0;
        }
        //public Team(WomensTeam team)
        //{
        //    _name=team._name;
        //    _goalsWon = team._goalsWon;
        //    _goalsLost=team._goalsLost;
        //    _point = team.Point;
        //}
        public Team(Team team)
        {
            _name=team._name;
            _goalsWon = team._goalsWon;
            _goalsLost=team._goalsLost;
            _point = team.Point;
        }

        public Team() { }
        
        public virtual void Show()
        {
            
            Console.WriteLine($"Команда: {_name}, общий счёт: {_point}");
        }
        protected void PlusN(int n)
        {
            _point += n;
        }
        protected void Up(int score1, int score2)
        {
            _goalsWon += score1;
            _goalsLost += score2;
            if (score1 > score2)
            {
                PlusN(3);
            }
            else if (score1 == score2)
            {
                PlusN(1);
            }
        }
        protected void SetName(string name)
        {
            _name = name;
        }
        public static void ShowList(Team[] teams)
        {
            for (int i1 = 0; i1 < teams.Length; i1++)
            {
                teams[i1].Show();
            }
        }
        protected static void Update1(Team[] teams, string name, int score1, int score2)
        {
            bool ok = false;
            for (int i = 0; i < teams.Length; i++)
            {
                if (teams[i]._name == name)
                {
                    ok = true;
                    teams[i].Up(score1, score2);
                    break;
                }
            }
            if (ok == false)
            {
                for (int i = 0; i < teams.Length; i++)
                {
                    if (teams[i]._name == " ")
                    {
                        teams[i].SetName(name);
                        teams[i].Up(score1, score2);
                        break;
                    }
                }
            }
        }
        public static void Update(Team[] teams, string name1,string name2,int score1, int score2)
        {
            Update1(teams,  name1,  score1,  score2);
            Update1(teams,  name2, score2, score1);
        }
        public static void Sort(Team[] teams)
        {
            for (int i = 0; i < teams.Length - 1; i++)
            {
                for (int j = i + 1; j < teams.Length; j++)
                {
                    if (teams[j]._point > teams[i]._point || ((teams[j]._point == teams[i]._point) && (teams[j].Difference()) > (teams[i].Difference())))
                    {
                        Team a = teams[i];
                        teams[i] = teams[j];
                        teams[j] = a;
                    }
                }
            }
        }
    }
    [Serializable]
    [ProtoContract]
    public class WomensTeam : Team
    {
        public override void Show()
        {
            
            Console.WriteLine($"{_name}, женская команда, общий счёт: {_point}");
        }
        public WomensTeam() : base()
        {
        }
        public WomensTeam(string name) : base(name)
        {
        }
        public WomensTeam(string name, int goalsWon, int goalsLost, int point) : base(name, goalsWon, goalsLost, point)
        {
        }
    }
    [Serializable]
    [ProtoContract]
    public class MensTeam : Team
    {
        public override void Show()
        {
            
            Console.WriteLine($"{_name}, мужская команда, общий счёт: {_point}");
        }
        public MensTeam(string name, int goalsWon, int goalsLost, int point) : base(name, goalsWon, goalsLost, point)
        {
        }
        public MensTeam(string name) : base(name)
        {
        }
        public MensTeam() : base()
        {
        }
    }
    class Program
    {
        static void Main()
        {
            MensTeam[] menteams = new MensTeam[] { new MensTeam("team F"),
                new MensTeam("team B"),
                new MensTeam("team C"),
                new MensTeam("team D"),
                new MensTeam("team G") 
            };
            WomensTeam[] womenteams = new WomensTeam[] { new WomensTeam("team A"),
                new WomensTeam("team U"),
                new WomensTeam("team O"),
                new WomensTeam("Women"),
                new WomensTeam("Mummy") 
            };
            Team.Update(menteams, "team F", "team B", 4, 7);
            Team.Update(menteams, "team B", "team C", 5, 5);
            Team.Update(menteams, "team D", "team G", 5, 5);
            Team.Update(womenteams, "team A", "team U", 3, 6);
            Team.Update(womenteams, "team O", "team A", 2, 9);
            Team.Update(womenteams, "Women", "Mummy", 2, 9);
            Team[] teams = new Team[menteams.Length + womenteams.Length];
            for (int i = 0; i < menteams.Length; i++)
            {
                teams[i] = new Team(menteams[i]);
            }
            for (int i = 0; i < womenteams.Length; i++)
            {
                teams[menteams.Length + i] = new Team(womenteams[i]);
            }
            Console.WriteLine(teams.Length);
            Team.Sort(teams);
            Console.WriteLine("Таблица результатов:");
            Team.ShowList(teams);

            SerializerHelper[] serializer = new SerializerHelper[3] { new JsonSerializerHelper(), new XmlSerializerHelper(), new BinSerializerHelper() };
            string[] files = new string[3] {"first.json", "second.xml", "third.bin"};
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string folder = "Lab9-3";
            for (int i = 0; i < serializer.Length; i++)
            {
                serializer[i].SerializeTo(teams, Path.Combine(path, folder, files[i]));
            }
            Console.WriteLine("Прочитано из файла:");
            for (int i = 0; i < serializer.Length; i++)
            {

                Team[] teamsread= serializer[i].DeserializeFrom<Team[]>(Path.Combine(path, folder, files[i]));
                Console.WriteLine($"From {files[i]}");
                foreach (Team var in teamsread)
                {
                    var.Show();
                }
            }
            Console.ReadKey();
        }
    }
}