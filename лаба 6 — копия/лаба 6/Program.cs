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

//        Sort(sportsmen);
//        foreach (var sportsman in sportsmen)
//        {
//            sportsman.Print();
//        }
//        Console.ReadKey();
//    }

//    static void Sort(Sportsman[] sportsmen)
//    {
//        for (int i = 0; i < sportsmen.Length - 1; i++)
//        {
//            for (int j = i + 1; j < sportsmen.Length; j++)
//            {
//                if (sportsmen[i].bestrezult < sportsmen[j].bestrezult)
//                {
//                    Sportsman best = sportsmen[i];
//                    sportsmen[i] = sportsmen[j];
//                    sportsmen[j] = best;
//                }
//            }
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

//using System;
//class Competitor
//{
//    private string surname;
//    private double[] scores;
//    private int totalPlace;

//    public Competitor(string surname, double[] scores)
//    {
//        this.surname = surname;
//        this.scores = scores;
//        this.totalPlace = 0;
//    }

//    public string Surname
//    {
//        get { return surname; }
//    }

//    public double[] Scores
//    {
//        get { return scores; }
//    }

//    public int TotalPlace
//    {
//        get { return totalPlace; }
//        set { totalPlace = value; }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Competitor[] competitors = new Competitor[]
//        {
//            new Competitor("Smith", new double[] {5.6, 6.0, 5.5, 5.8, 5.9, 5.7, 5.8}),
//            new Competitor("Johnson", new double[] {5.8, 5.9, 5.7, 6.0, 5.5, 5.6, 5.8}),
//            new Competitor("Williams", new double[] {5.7, 5.5, 5.9, 5.7, 5.8, 5.9, 5.6})
//        };

//        CalculateTotalPlaces(competitors);
//        Array.Sort(competitors, (x, y) => x.TotalPlace.CompareTo(y.TotalPlace));

//        foreach (Competitor competitor in competitors)
//        {
//            Console.WriteLine($"{competitor.Surname}: {competitor.TotalPlace}");
//        }
//    }

//    static void CalculateTotalPlaces(Competitor[] competitors)
//    {
//        for (int i = 0; i < competitors.Length; i++)
//        {
//            int totalPlace = 0;
//            for (int j = 0; j < competitors.Length; j++)
//            {
//                if (i != j && CalculatePoints(competitors[i].Scores) > CalculatePoints(competitors[j].Scores))
//                {
//                    totalPlace++;
//                }
//            }
//            competitors[i].TotalPlace = totalPlace + 1;
//        }
//    }

//    static double CalculatePoints(double[] scores)
//    {
//        double sum = 0;
//        foreach (double score in scores)
//        {
//            sum += score;
//        }
//        return sum;
//    }
//}

#endregion

#region 3_3

/*В соревнованиях участвуют три команды по 6 человек.
Результаты соревнований представлены в виде мест участников каждой команды (1 – 18).
Определить команду-победителя, вычислив количество баллов, набранное каждой командой.
Участнику, занявшему 1-е место, начисляется 5 баллов,
2-е – 4, 3-е – 3, 4-е – 2, 5-е – 1, остальным – 0 баллов.
При равенстве баллов победителем считается команда,
за которую выступает участник, занявший 1-е место.*/

//using System;

//public class Program
//{
//    private struct Participant
//    {
//        private int place;

//        public Participant(int place)
//        {
//            this.place = place;
//        }

//        public int GetPlace()
//        {
//            return place;
//        }
//    }

//    private struct Team
//    {
//        private Participant[] participants;

//        public Team(int[] places)
//        {
//            participants = new Participant[6];
//            for (int i = 0; i < 6; i++)
//            {
//                participants[i] = new Participant(places[i]);
//            }
//        }

//        public int CalculateScore()
//        {
//            int score = 0;
//            for (int i = 0; i < participants.Length; i++)
//            {
//                int place = participants[i].GetPlace();
//                if (place == 1)
//                {
//                    score += 5;
//                }
//                else if (place == 2)
//                {
//                    score += 4;
//                }
//                else if (place == 3)
//                {
//                    score += 3;
//                }
//                else if (place == 4)
//                {
//                    score += 2;
//                }
//                else if (place == 5)
//                {
//                    score += 1;
//                }
//            }
//            return score;
//        }
//    }

//    static void Main(string[] args)
//    {
//        int[] team1Places = { 1, 4, 7, 10, 13, 16 };
//        int[] team2Places = { 2, 5, 8, 11, 14, 17 };
//        int[] team3Places = { 3, 6, 9, 12, 15, 18 };

//        Team team1 = new Team(team1Places);
//        Team team2 = new Team(team2Places);
//        Team team3 = new Team(team3Places);

//        int scoreTeam1 = team1.CalculateScore();
//        int scoreTeam2 = team2.CalculateScore();
//        int scoreTeam3 = team3.CalculateScore();

//        int winnerTeam = scoreTeam1 >= scoreTeam2 && scoreTeam1 >= scoreTeam3 ? 1 : (scoreTeam2 >= scoreTeam3 ? 2 : 3);

//        Console.WriteLine($"Победила команда {winnerTeam}");
//    }
//}

#endregion