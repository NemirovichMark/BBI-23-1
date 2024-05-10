using System;
using System.Text.Json.Serialization;
using Lab9_2.SerializeHelper;
using ProtoBuf;
using System.IO;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;

namespace Lab9_2
{
    [Serializable]
    [ProtoContract]
    
    public class Program
    {
        [Serializable]
        [ProtoContract]
        public class Player
        {
            [JsonIgnore]
            [NonSerialized]
            private string _surname;
            [JsonIgnore]
            [NonSerialized]
            private int _score;
            [JsonInclude]
            [ProtoMember(6)]
            
            public int Score
            {
                get { return _score; }
                set
                {
                    if (value >= 0) _score = value;
                }
            }
            [JsonInclude]
            [ProtoMember(7)]
            public string Surname { get { return _surname; } set { _surname = value ?? string.Empty; } }
            public Player(string surname)
            {
                _surname = surname;
                _score = 0;
            }
            public Player() { }
        }
        [Serializable]
        [ProtoContract]
        [ProtoInclude(4, typeof(Hockey))]
        [ProtoInclude(5, typeof(Basketball))]
        public abstract class Game
        {
            [JsonIgnore]
            [NonSerialized]
            protected Random _rand;
            [JsonIgnore]
            [NonSerialized]
            protected string _gameName;
            [JsonIgnore]
            [NonSerialized]
            protected Player[] _players;
            [JsonIgnore]
            [NonSerialized]
            protected List<Player> _result;
            [ProtoMember(1)]
            [JsonInclude]
            public string GameName
            {
                get { return _gameName; }
                set
                {
                    _gameName = value ?? string.Empty;
                }
            }
            [ProtoMember(2)]
            [JsonInclude]
            public Player[] Players
            {
                get { return _players; }
                set { _players = value; }
            
            }
            [ProtoMember(3)]
            [JsonInclude]
            public List<Player> Result
            {
                get { return _result; }
                set { _result = value; }
            }
            public Game(Random rand, string gameName, Player[] players)
            {
                _rand = rand;
                _gameName = gameName;
                _players = players;
                _result = new List<Player>();
            }
            public Game() { }

            public abstract void ShowInfo();
            protected abstract void AddScore(Player player);

            protected abstract void Clean();
            protected void UpdateResult(Player player)
            {
                _result.Add(player);
            }
            protected void Sort()
            {
                bool swap;
                int n = _result.Count;

                do
                {
                    swap = false;
                    for (int i = 1; i < n; i++)
                    {
                        if (_result[i - 1].Score > _result[i].Score)
                        {
                            Player temp = _result[i - 1];
                            _result[i - 1] = _result[i];
                            _result[i] = temp;
                            swap = true;
                        }
                    }
                    n--;
                } while (swap);
            }
            public void HoldGame()
            {
                Console.WriteLine("Новая игра:");
                Clean();
                Sort();
                ShowInfo();
            }
        }
        [Serializable]
        [ProtoContract]
        public class Hockey : Game
        {
            [JsonIgnore]
            [NonSerialized]
            readonly int n = 2; //количество игр 
            [JsonIgnore]
            [NonSerialized]
            readonly int fail = 10;
            public Hockey(Random rand, string gameName, Player[] players) : base(rand, gameName, players)
            {

            }
            public Hockey(): base() { }
            protected override void AddScore(Player player)
            {
                int[] list = new int[3] { 2, 5, 10 };
                player.Score += list[_rand.Next(list.Length)];
            }
            protected override void Clean()
            {
                for (int i = 0; i < _players.Length; i++)
                {
                    bool ok = true;
                    for (int j = 0; j < n; j++)
                    {
                        int a = _players[i].Score;
                        AddScore(_players[i]);
                        if ((_players[i].Score - a) == fail)
                        {
                            ok = false;
                            break;
                        }
                    }
                    if (ok == true)
                    {
                        UpdateResult(_players[i]);
                    }

                }
            }
            public override void ShowInfo()
            {
                Console.WriteLine("Хоккейный матч:");
                foreach (var player in _result)
                {
                    Console.WriteLine($"Фамилия: {player.Surname}, суммарное штрафное время: {player.Score} сек");
                }
            }
        }
        [Serializable]
        [ProtoContract]
        public class Basketball : Game
        {
            [JsonIgnore]
            [NonSerialized]
            readonly int n = 3;//количество игр
            [JsonIgnore]
            [NonSerialized]
            readonly int maxFouls = 3;
            public Basketball(Random rand, string gameName, Player[] players) : base(rand, gameName, players)
            {

            }
            public Basketball() : base() { }
            protected override void AddScore(Player player)
            {
                player.Score += _rand.Next(6);
            }
            protected override void Clean()
            {
                for (int i = 0; i < _players.Length; i++)
                {
                    bool ok = true;
                    for (int j = 0; j < n; j++)
                    {
                        int a = _players[i].Score;

                        AddScore(_players[i]);
                        if ((_players[i].Score - a) > maxFouls)
                        {
                            ok = false;
                            break;
                        }
                    }
                    if (ok == true)
                    {
                        UpdateResult(_players[i]);
                    }

                }
            }
            public override void ShowInfo()
            {
                Console.WriteLine("Баскетбольный матч:");
                foreach (var player in _result)
                {
                    Console.WriteLine($"Фамилия: {player.Surname}, суммарное количество фолов: {player.Score} шт");
                }
            }
        }

        static void Main()
        {
            Random rand = new Random();
            Player[] players1 = {new Player("Иванов"),
                            new Player("Петров"),
                            new Player("Семёнов"),
                            new Player("Сидоров"),
                            new Player("Чернов")
            };
            Basketball game1 = new Basketball(rand, "Basketball match", players1);
            game1.HoldGame();
            Player[] players2 = {new Player("Зайцев"),
                            new Player("Медведев"),
                            new Player("Волков"),
                            new Player("Козлов"),
                            new Player("Жабов")
            };
            Hockey game2 = new Hockey(rand, "Hockey match", players2);
            game2.HoldGame();
            SerializerHelper[] serializer = new SerializerHelper[3] { new JsonSerializerHelper(), new XmlSerializerHelper(), new BinSerializerHelper() };
            string[] files = new string[6] { "game1.json", "game1.xml", "game1.bin", "game2.json", "game2.xml", "game2.bin", };
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string folder = "Lab9-2";
            for (int i = 0; i < serializer.Length; i++)
            {
                serializer[i].SerializeTo(game1, Path.Combine(path, folder, files[i]));
                serializer[i].SerializeTo(game2, Path.Combine(path, folder, files[i + 3]));
            }
            Console.WriteLine("Прочитано из файла:");
            for (int i = 0; i < serializer.Length; i++)
            {

                Basketball readgame1 = serializer[i].DeserializeFrom<Basketball>(Path.Combine(path, folder, files[i]));
                Hockey readgame2 = serializer[i].DeserializeFrom<Hockey>(Path.Combine(path, folder, files[i + 3]));
                Console.WriteLine($"From {files[i]}");
                readgame1.ShowInfo();
                Console.WriteLine($"From {files[i + 3]}");
                readgame2.ShowInfo();
            }
            Console.ReadKey();
        }
    }
}