using System;
/*Соревнования по прыжкам в воду оценивают 7 судей.  
Каждый спортсмен выполняет 4 прыжка.  
Каждый прыжок имеет одну из шести категорий сложности, оцениваемую коэффициентом (от 2,5 до 3,5).  
Качество прыжка оценивается судьями по 6-балльной шкале.  
Далее лучшая и худшая оценки отбрасываются, остальные складываются,  
и сумма умножается на коэффициент сложности.  
Получить итоговую таблицу, содержащую фамилии спортсменов,  
и итоговую оценку (сумму оценок по 4 прыжкам) в порядке занятых мест.*/

struct Jumps
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
        for(int i=0;i< _scores.Length-1;i++)
        {
            for(int j=1;j<_scores.Length;j++)
            {
                if(_scores[j-1] > _scores[j])
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

struct Sportsmen
{
    private string _Sername;
    private Jumps[] _Jump;
    private double _Score;

    public Sportsmen(string Sername, Jumps[] jump)
    {
        _Sername = Sername;
        _Jump = jump;
        _Score = 0;
        for (int i = 0; i < jump.Length; i++)
        {
            _Score += jump[i].GetScore();
        }
    }
    public string Sername { get { return _Sername; } }
    public double Score { get { return _Score; } }


}

class Program
{
    static void Main()
    {
        Sportsmen[] sportsmens = new Sportsmen[3];
        sportsmens[0] = new Sportsmen("Tom", new Jumps[]
        {
            new Jumps(new int[]{0, 0, 0, 0, 0, 0, 0}, 2.5),
            new Jumps(new int[]{0, 0, 0, 0, 0, 0, 0}, 2.6),
            new Jumps(new int[]{1, 0, 0, 0, 0, 0, 0}, 2.7),
            new Jumps(new int[]{1, 1, 0, 0, 0, 0, 0}, 2.8)
        }
        );
        sportsmens[1] = new Sportsmen("Chase", new Jumps[]
        {
            new Jumps(new int[]{0, 4, 1, 0, 5, 4, 3}, 2.9),
            new Jumps(new int[]{1, 5, 2, 1, 6, 3, 2}, 3.0),
            new Jumps(new int[]{2, 6, 3, 2, 5, 2, 1}, 3.1),
            new Jumps(new int[]{3, 5, 4, 3, 4, 1, 0}, 3.2)
        }
        );
        sportsmens[2] = new Sportsmen("Clod", new Jumps[]
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
                if (sportsmens[j - 1].Score < sportsmens[j].Score)
                {
                    Sportsmen temp = sportsmens[j - 1];
                    sportsmens[j - 1] = sportsmens[j];
                    sportsmens[j] = temp;
                }
            }
        }

        Console.WriteLine("фамилия\tместо\t\tбалл");
        for (int i = 0; i < sportsmens.Length; i++)
        {
            Console.WriteLine($"{sportsmens[i].Sername}\t{i + 1}\t\t{sportsmens[i].Score}");
        }
    }
}
