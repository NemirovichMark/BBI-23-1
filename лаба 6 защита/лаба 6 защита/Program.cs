#region 1_4

/*Результаты соревнований по прыжкам в высоту определяются 
 по лучшей из двух попыток. 
 Вывести список участников в порядке занятых мест.*/

//using System.Drawing;
//public struct Sportsman
//{
//    private string _surname;
//    private double _attempt1;
//    private double _attempt2;
//    private double _bestrezult;
//    private static int _counter = 4;
//    public double bestrezult => _bestrezult;

//    public Sportsman(string S, double a1, double a2, double rezult)
//    {
//        _surname = S;
//        _attempt1 = a1;
//        _attempt2 = a2;

//        if (a1 > a2)
//        {
//            _bestrezult = a1;
//        }
//        else
//        {
//            _bestrezult = a2;
//        }
//    }
//    public void Print()
//    {
//        _counter++;
//        Console.WriteLine($"SURNAME: {_surname}, ATTEMPT№1: {_attempt1}, ATTEMPT№2: {_attempt2}, BEST REZULT: {_bestrezult}\n");
//    }
//    public static void PrintCounter() => Console.WriteLine(_counter);
//}
//class Program
//{
//    static void Main()
//    {
//        Sportsman[] sportsmen = new Sportsman[4];
//        {
//            sportsmen[0] = new Sportsman("Abramov", 1.5, 1.57, 0);
//            sportsmen[1] = new Sportsman("Baranov", 1.26, 1.4, 0);
//            sportsmen[2] = new Sportsman("Voronov", 1.75, 1.87, 0);
//            sportsmen[3] = new Sportsman("Gyrov", 1.4, 1.8, 0);
//        };
//        foreach (var sportsman in sportsmen)
//        {
//            sportsman.Print();
//        }

//        InsertionSort(sportsmen);
//        foreach (var sportsman in sportsmen)
//        {
//            sportsman.Print();
//        }
//        Console.ReadKey();
//    }

//    static void InsertionSort(Sportsman[] sportsmen)
//    {
//        for (int i = 1; i < sportsmen.Length; i++)
//        {
//            Sportsman key = sportsmen[i];
//            int j = i - 1;

//            while (j >= 0 && sportsmen[j].bestrezult < key.bestrezult)
//            {
//                sportsmen[j + 1] = sportsmen[j];
//                j = j - 1;
//            }
//            sportsmen[j + 1] = key;
//        }
//    }

//}

#endregion

#region 2_9

/*Результаты соревнований фигуристов по одному из 
видов многоборья представлены оценками 7 судей 
в баллах (от 0,0 до 6,0). 
По результатам оценок судьи определяется место 
каждого участника у этого судьи. 
Места участников определяются далее по сумме мест,
которые каждый участник занял у всех судей. 
Составить программу, определяющую по исходной 
таблице оценок фамилии и сумму мест участников 
в порядке занятых ими мест.*/

using System;
class Competitor
{
    private string surname;
    private double[] scores;
    private int totalPlace;

    public Competitor(string surname, double[] scores)
    {
        this.surname = surname;
        this.scores = scores;
        this.totalPlace = 0;
    }

    public string Surname
    {
        get { return surname; }
    }

    public double[] Scores
    {
        get { return scores; }
    }

    public int TotalPlace
    {
        get { return totalPlace; }
    }
    public void SetTotalPlace(int value)
    {
        totalPlace = value;
    }

}

class Program
{
    static void Main()
    {
        Competitor[] competitors = new Competitor[]
        {
            new Competitor("Smith", new double[] {5.6, 6.0, 5.5, 5.8, 5.9, 5.7, 5.8}),
            new Competitor("Johnson", new double[] {5.8, 5.9, 5.7, 6.0, 5.5, 5.6, 5.8}),
            new Competitor("Williams", new double[] {5.7, 5.5, 5.9, 5.7, 5.8, 5.9, 5.6})
        };

        CalculateTotalPlaces(competitors);
        Array.Sort(competitors, (x, y) => x.TotalPlace.CompareTo(y.TotalPlace));

        foreach (Competitor competitor in competitors)
        {
            Console.WriteLine($"{competitor.Surname}: {competitor.TotalPlace}");
        }
    }

    static void CalculateTotalPlaces(Competitor[] competitors)
    {
        for (int i = 0; i < competitors.Length; i++)
        {
            int totalPlace = 0;
            for (int j = 0; j < competitors.Length; j++)
            {
                if (i != j && CalculatePoints(competitors[i].Scores) > CalculatePoints(competitors[j].Scores))
                {
                    totalPlace++;
                }
            }
            competitors[i].SetTotalPlace(totalPlace + 1);
        }
    }

    static double CalculatePoints(double[] scores)
    {
        double sum = 0;
        foreach (double score in scores)
        {
            sum += score;
        }
        return sum;
    }
}

#endregion