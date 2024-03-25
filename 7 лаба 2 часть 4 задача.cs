using System;

namespace ConsoleApp351
{
    class metres3 : Sportsmen
    {
        public metres3(string sername, Jumps[] jump) : base(sername, jump)
        {
            _Discipline = "3 metres";
        }
    }
    class metres5 : Sportsmen
    {
        public metres5(string sername, Jumps[] jump) : base(sername, jump)
        {
            _Discipline = "5 metres";
        }
    }
    abstract public class Sportsmen
    {
        protected string _Discipline;
        protected string _Sername;
        protected Jumps[] _Jump;
        protected double _Score;

        public Sportsmen(string sername, Jumps[] jump)
        {
            _Sername = sername;
            _Jump = jump;
            _Score = 0;
            for (int i = 0; i < jump.Length; i++)
            {
                _Score += jump[i].GetScore();
            }
        }
        public string discipline { get {  return _Discipline; } }
        public string sername { get { return _Sername; } }
        public double score { get { return _Score; } }
    }
    public class Jumps
    {
        private int[] _scores;
        private double _Coef;
        public Jumps(int[] scores, double Coef)
        {
            _scores = scores;
            _Coef = Coef;
        }
        public double GetScore()
        {
            double sum = 0;
            for (int i = 0; i < _scores.Length - 1; i++)
            {
                for (int j = 1; j < _scores.Length; j++)
                {
                    if (_scores[j - 1] > _scores[j])
                    {
                        int p = _scores[j];
                        _scores[j] = _scores[j - 1];
                        _scores[j - 1] = p;
                    }
                }
            }
            for (int i = 1; i < _scores.Length - 1; i++)
            {
                sum += _scores[i];
            }
            return sum * _Coef;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Sportsmen[] sportsmens = new Sportsmen[3];
            sportsmens[0] = new metres3("Tom", new Jumps[]
            {
            new Jumps(new int[]{0, 0, 0, 0, 0, 0, 0}, 2.5),
            new Jumps(new int[]{0, 0, 0, 0, 0, 0, 0}, 2.6),
            new Jumps(new int[]{1, 0, 0, 0, 0, 0, 0}, 2.7),
            new Jumps(new int[]{1, 1, 0, 0, 0, 0, 0}, 2.8)
            }
            );
            sportsmens[1] = new metres5("Chase", new Jumps[]
            {
            new Jumps(new int[]{0, 4, 1, 0, 5, 4, 3}, 2.9),
            new Jumps(new int[]{1, 5, 2, 1, 6, 3, 2}, 3.0),
            new Jumps(new int[]{2, 6, 3, 2, 5, 2, 1}, 3.1),
            new Jumps(new int[]{3, 5, 4, 3, 4, 1, 0}, 3.2)
            }
            );
            sportsmens[2] = new metres3("Clod", new Jumps[]
            {
            new Jumps(new int[]{6, 4, 2, 0, 2, 4, 6}, 3.3),
            new Jumps(new int[]{1, 3, 5, 3, 1, 3, 5}, 3.4),
            new Jumps(new int[]{4, 5, 4, 6, 4, 5, 4}, 3.5),
            new Jumps(new int[]{4, 4, 2, 1, 2, 4, 4}, 3.4)
            }
            );

            for (int i = 0; i < sportsmens.Length - 1; i++)
            {
                for (int j = 1; j < sportsmens.Length; j++)
                {
                    if (sportsmens[j - 1].score < sportsmens[j].score)
                    {
                        Sportsmen temp = sportsmens[j - 1];
                        sportsmens[j - 1] = sportsmens[j];
                        sportsmens[j] = temp;
                    }
                }
            }

            Console.WriteLine("дисциплина\tфамилия\tместо\t\tбалл");
            for (int i = 0; i < sportsmens.Length; i++)
            {
                Console.WriteLine($"{sportsmens[i].discipline}\t{sportsmens[i].sername}\t{i + 1}\t\t{sportsmens[i].score}");
            }
        }
    }
}
