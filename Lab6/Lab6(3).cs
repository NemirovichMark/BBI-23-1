using System;

struct Participant
{
    private string name;
    private int place;

    public string Name => name;
    public int Place => place;

    public Participant(string name, int place)
    {
        this.name = name;
        if (place >= 1 && place <= 18)
        {
            this.place = place;
        }
        else
        {
            this.place = -1;
        }
    }
}

class Program
{
    static void Main()
    {
        Participant[,] results = new Participant[3, 6];

        Console.WriteLine("Введите результаты соревнований для каждой команды (числа от 1 до 18):");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Команда {i + 1}:");
            for (int j = 0; j < 6; j++)
            {
                Console.Write($"Участник {j + 1}: ");
                int place = int.Parse(Console.ReadLine());
                results[i, j] = new Participant($"Участник {j + 1}", place);
            }
        }

        int[] scores = new int[3];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                int place = results[i, j].Place;
                switch (place)
                {
                    case 1:
                        scores[i] += 5;
                        break;
                    case 2:
                        scores[i] += 4;
                        break;
                    case 3:
                        scores[i] += 3;
                        break;
                    case 4:
                        scores[i] += 2;
                        break;
                    case 5:
                        scores[i] += 1;
                        break;
                    default:
                        break;
                }
            }
        }

        int maxScore = scores[0];
        int winningTeam = 1;
        for (int i = 1; i < 3; i++)
        {
            if (scores[i] > maxScore)
            {
                maxScore = scores[i];
                winningTeam = i + 1;
            }
        }

        Console.WriteLine($"Количество баллов для каждой команды:");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Команда {i + 1}: {scores[i]} баллов");
        }
        Console.WriteLine($"Победила команда {winningTeam} с {maxScore} баллами!");
    }
}