//Im so sorry i really dont know how to use json
#region 1_1
/*
using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите текст:");
        string text = Console.ReadLine();
        Dictionary<char, int> capitalLetterCount = new Dictionary<char, int>();
        foreach (char c in text)
        {
            if (Char.IsUpper(c))
            {
                if (capitalLetterCount.ContainsKey(c))
                {
                    capitalLetterCount[c]++;
                }
                else
                {
                    capitalLetterCount.Add(c, 1);
                }
            }
        }

        if (capitalLetterCount.Count == 0)
        {
            Console.WriteLine("В тексте нет заглавных букв.");
        }
        else
        {
            char mostFrequentCapitalLetter = ' ';
            int maxCount = 0;

            foreach (var entry in capitalLetterCount)
            {
                if (entry.Value > maxCount)
                {
                    mostFrequentCapitalLetter = entry.Key;
                    maxCount = entry.Value;
                }
            }

            Console.WriteLine($"Самая часто встречающаяся заглавная буква: {mostFrequentCapitalLetter}");

            Console.WriteLine("Слова, начинающиеся с этой буквы:");

            string[] words = text.Split(' ');

            foreach (string word in words)
            {
                if (word.Length > 0 && word[0] == mostFrequentCapitalLetter)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
*/
#endregion 
#region 1_2


using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст:");
        string text = Console.ReadLine();
         
        int count = CountSingleLetterWords(text);

        Console.WriteLine($"Количество предлогов и союзов в тексте: {count}");
    }
     

    static int CountSingleLetterWords(string text)
    {
        string[] words = text.Split(new char[] { ' ', ',', '.', ':', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        int count = 0;
        foreach (string word in words)
        {
            if (word.Length == 1 && IsSingleLetterPrepositionOrConjunction(word))
            {
                count++;
            }
        }

        return count;
    }

    static bool IsSingleLetterPrepositionOrConjunction(string word)
    {
        string[] singleLetterPrepositionsAndConjunctions = { "и", "в", "с", "а", "к", "о", "у", "я", "или", "но", "да", "же" };

        foreach (string prepositionOrConjunction in singleLetterPrepositionsAndConjunctions)
        {
            if (word == prepositionOrConjunction)
            {
                return true;
            }
        }

        return false;
    }
}

#endregion







