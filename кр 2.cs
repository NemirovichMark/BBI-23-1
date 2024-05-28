//вариант 15 Абраменкова Карина
//1 
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine();

        int count = CountConjunctionsAndPrepositions(input);

        Console.WriteLine("Количество предлогов и союзов без гласных букв: " + count);
    }

    static int CountConjunctionsAndPrepositions(string input)
    {
        string[] conjunctionsAndPrepositions = { "и", "так", "да", "но", "а", "что", "чтобы", "если", "либо", "поэтому", "потому" };

        string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        int count = words.Count(word => conjunctionsAndPrepositions.Contains(word.ToLower()) && !word.Any(c => "аеёиоуыэюя".Contains(c)));

        return count;
    }
}
