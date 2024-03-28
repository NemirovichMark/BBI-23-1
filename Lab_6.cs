using System;
using System.Collections.Generic;
using System.Linq;
// Задача 1 Левел 1 
/*class Program
{
    struct Participant
    {
        public string LastName;
        public string Society;
        public double FirstAttempt;
        public double SecondAttempt;
        public double TotalScore => FirstAttempt + SecondAttempt;
    }

    static void Main(string[] args)
    {
        Participant[] participants = GetParticipantsData();

        Array.Sort(participants, (x, y) => y.TotalScore.CompareTo(x.TotalScore));

        Console.WriteLine("Results:");
        Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15} {4,-15}", "Last Name", "Society", "1st Attempt", "2nd Attempt", "Total Score");
        foreach (var participant in participants)
        {
            Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15} {4,-15}", participant.LastName, participant.Society, participant.FirstAttempt, participant.SecondAttempt, participant.TotalScore);
        }
    }

    static Participant[] GetParticipantsData()
    {
        // Здесь можно заменить на генерацию случайных данных
        Participant[] participants = new Participant[]
        {
            new Participant { LastName = "Smith", Society = "Alpha", FirstAttempt = 5.2, SecondAttempt = 5.5 },
            new Participant { LastName = "Johnson", Society = "Beta", FirstAttempt = 5.6, SecondAttempt = 5.4 },
            new Participant { LastName = "Williams", Society = "Gamma", FirstAttempt = 5.1, SecondAttempt = 5.3 },
            new Participant { LastName = "Brown", Society = "Delta", FirstAttempt = 5.3, SecondAttempt = 5.2 },
            new Participant { LastName = "Jones", Society = "Epsilon", FirstAttempt = 5.4, SecondAttempt = 5.6 }
        };

        return participants;
    }
}*/







// Задача 6 Левел 2 


/*class Program
{
    class DivingParticipant
    {
        public string LastName { get; set; }
        public List<double> Scores { get; set; } = new List<double>();

        public double TotalScore => Scores.Average();
    }

    static void Main(string[] args)
    {
        List<DivingParticipant> participants = GetParticipantsData();

        // Сортировка участников по их среднему баллу за два прыжка
        participants = participants.OrderByDescending(p => p.TotalScore).ToList();

        // Вывод итогового протокола
        Console.WriteLine("Final Protocol:");
        Console.WriteLine("{0,-15} {1,-15}", "Last Name", "Total Score");
        foreach (var participant in participants)
        {
            Console.WriteLine("{0,-15} {1,-15:F2}", participant.LastName, participant.TotalScore);
        }
    }

    static List<DivingParticipant> GetParticipantsData()
    {
        // В реальной программе здесь можно было бы получить данные из внешнего источника, такого как база данных или файл.
        List<DivingParticipant> participants = new List<DivingParticipant>
        {
            new DivingParticipant { LastName = "Smith", Scores = new List<double> { 8.5, 9.0 }},
            new DivingParticipant { LastName = "Johnson", Scores = new List<double> { 7.8, 8.3 }},
            new DivingParticipant { LastName = "Williams", Scores = new List<double> { 9.2, 8.9 }},
            new DivingParticipant { LastName = "Brown", Scores = new List<double> { 8.0, 8.5 }},
            new DivingParticipant { LastName = "Jones", Scores = new List<double> { 8.7, 9.1 }}
        };

        return participants;
    }
}*/

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, List<string>> answers = new Dictionary<string, List<string>>()
        {
            { "а", new List<string> { "кошка", "собака", "рыба", "кошка", "птица" } },
            { "б", new List<string> { "дружелюбие", "сдержанность", "дисциплинированность", "дружелюбие" } },
            { "в", new List<string> { "сакура", "самурай", "гейша", "сакура", "фудзияма" } }
        };

        foreach (var question in answers.Keys)
        {
            List<string> responses = answers[question];
            if (responses.Count > 0)
            {
                Console.WriteLine($"Наиболее частые ответы на вопрос '{question}':");
                var counts = responses.GroupBy(r => r)
                                       .Select(group => new { Answer = group.Key, Count = group.Count() })
                                       .OrderByDescending(item => item.Count)
                                       .Take(5);
                int totalResponses = responses.Count;
                foreach (var item in counts)
                {
                    double percentage = (item.Count / (double)totalResponses) * 100;
                    Console.WriteLine($"{item.Answer}: {percentage:F2}%");
                }
            }
            else
            {
                Console.WriteLine($"На вопрос '{question}' не получено ответов.");
            }
            Console.WriteLine();
        }
    }
}




