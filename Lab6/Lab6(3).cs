/* В соревнованиях участвуют три команды по 6 человек. Результаты
соревнований представлены в виде мест участников каждой команды (1 - 18).
Определить команду – победителя, вычислив количество баллов, набранное
каждой командой. Участнику, занявшему 1-е место, начисляется 5 баллов, 2-е –
4, 3-е – 3, 4-е – 2, 5-е – 1, остальным – 0 баллов. При равенстве баллов
победительницей считается команда, за которую выступает участник, занявший
1-е место.*/
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