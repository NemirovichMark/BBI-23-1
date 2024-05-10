using System;
using System.Text.Json.Serialization;
using Lab7_1.SerializeHelper;
using ProtoBuf;
using System.IO;

namespace Lab7_1
{
    [ProtoContract]
    public class Sportwoman
    {
        [JsonIgnore]
        [NonSerialized]
        private string _surname;
        [JsonIgnore]
        [NonSerialized]
        private int _group;
        [JsonIgnore]
        [NonSerialized]
        private string _trainerName;
        [JsonIgnore]
        [NonSerialized]
        private int _sec;
        [ProtoMember(1)]
        [JsonInclude]
        public string Surname
        {
            get { return _surname; }
            set { _surname = value ?? string.Empty; }
        }
        [ProtoMember(2)]
        [JsonInclude]
        public int Group
        {
            get { return _group; }
            set {if (value>0) _group = value; }
        }
        [ProtoMember(3)]
        [JsonInclude]
        public string TrainerName
        {
            get { return _trainerName; }
            set { _trainerName = value ?? string.Empty; }
        }
        [ProtoMember(4)]
        [JsonInclude]
        public int Sec
        {
            get { return _sec; }
            set { if (value>0) _sec = value; }
        }
        public Sportwoman() { }
        public Sportwoman(string surname, int group, string trainerName, int sec)
        {
            _surname = surname;
            _group = group;
            _trainerName = trainerName;
            _sec = sec;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Фамилия: {_surname}, группа: {_group}, имя тренера: {_trainerName}, результат: {_sec} секунд");
        }

    }
    abstract class Competition
    {
        protected readonly string _competitionName;
        protected Sportwoman[] _sportwomen;
        protected static int _norma;
        public Competition(string competitionName, Sportwoman[] sportwomen)
        {
            _competitionName = competitionName;
            _sportwomen = sportwomen;
        }

        private static void quickSort(Sportwoman[] table, int left, int right)
        {
            if (left >= right) return;
            int p = table[(left + right) / 2].Sec;
            int i = left;
            int j = right;
            while (i <= j)
            {
                while (table[i].Sec < p) i++;
                while (table[j].Sec > p) j--;
                if (i <= j)
                {
                    Sportwoman a = table[i];
                    table[i] = table[j];
                    table[j] = a;
                    i++;
                    j--;
                }
            }
            quickSort(table, left, j);
            quickSort(table, i, right);
        }
        protected void Sort()
        {
            quickSort(_sportwomen, 0, _sportwomen.Length - 1);
        }
        protected virtual void Print()
        {; }
        protected virtual void PrintCounter() {; }
        public void HoldCompetition()
        {
            Console.WriteLine($"Название соревнования:{_competitionName}");
            Console.WriteLine();
            Sort();
            Print();
            Console.WriteLine();
            PrintCounter();
            Console.WriteLine();
        }
    }
    class Distance100 : Competition
    {
        private static int _counter;
        public Distance100(string competitionName, Sportwoman[] sportwomen) : base(competitionName, sportwomen)
        {

        }
        static Distance100()
        {
            _norma = 25;
        }
        protected override void Print()
        {
            foreach (var sportwoman in _sportwomen)
            {
                if (sportwoman.Sec <= _norma) _counter++;
                sportwoman.ShowInfo();
            }
        }
        protected override void PrintCounter() => Console.WriteLine($"Количество спортсменок, сдавших норматив({_norma} секунд): {_counter}");
    }
    class Distance500 : Competition
    {

        private static int _counter;
        static Distance500()
        {
            _norma = 110;
        }
        public Distance500(string competitionName, Sportwoman[] sportwomen) : base(competitionName, sportwomen)
        {

        }
        protected override void Print()
        {
            foreach (var sportwoman in _sportwomen)
            {
                if (sportwoman.Sec <= _norma) _counter++;
                sportwoman.ShowInfo();
            }
        }
        protected override void PrintCounter() => Console.WriteLine($"Количество спортсменок, сдавших норматив({_norma} секунд): {_counter}");
    }
    class Program
    {
        static void Main()
        {
            Sportwoman[] sportwomen1 = {
                new Sportwoman("Кукушкина", 1, "Овечкин", 111),
                new Sportwoman("Соловьёва", 1, "Зверев", 107),
                new Sportwoman("Воробьёва", 2, "Козлов", 112),
                new Sportwoman("Синицына", 2, "Зайцев", 109),
                new Sportwoman("Орлова", 1, "Волков", 110)
            };
            Sportwoman[] sportwomen2 = {
                new Sportwoman("Кукушкина", 1, "Овечкин", 25),
                new Sportwoman("Соловьёва", 1, "Зверев", 27),
                new Sportwoman("Воробьёва", 2, "Козлов",24),
                new Sportwoman("Синицына", 2, "Зайцев", 26)
            };
            SerializerHelper[] serializer = new SerializerHelper[3] { new JsonSerializerHelper(), new XmlSerializerHelper(), new BinSerializerHelper()};
            string[] files = new string[6] {"women1.json", "women1.xml", "women1.bin", "women2.json", "women2.xml", "women2.bin", };
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            
            string folder = "Lab9-1";
            for (int i = 0; i < serializer.Length; i++)
            {
                serializer[i].SerializeTo(sportwomen1,Path.Combine(path,folder,files[i]));
                serializer[i].SerializeTo(sportwomen2, Path.Combine(path,folder, files[i + 3]));
            }
            Console.WriteLine("Прочитано из файла:");
            for (int i = 0; i < serializer.Length; i++)
            {
                
                Sportwoman[] readwomen1 = serializer[i].DeserializeFrom<Sportwoman[]>(Path.Combine(path, folder, files[i]));
                Sportwoman[] readwomen2 = serializer[i].DeserializeFrom<Sportwoman[]>(Path.Combine(path, folder, files[i+3]));
                Console.WriteLine($"From {files[i]}");
                foreach (Sportwoman var in readwomen1)
                {
                    var.ShowInfo();
                }
                Console.WriteLine($"From {files[i+3]}");
                foreach (Sportwoman var in readwomen2)
                {
                    var.ShowInfo();
                }
                
            }
            Distance100 competition1 = new Distance100("Международные соревнования на 100 метров", sportwomen2);
            competition1.HoldCompetition();

            Distance500 competition2 = new Distance500("Всероссийские соревнования на 500 метров", sportwomen1);
            competition2.HoldCompetition();

            Console.ReadKey();
        }
    }
}
