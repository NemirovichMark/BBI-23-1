using System;
using System.Text.RegularExpressions;
using System.Text;
using System.Collections.Generic;
using System.Linq;

abstract class Task
{
    public abstract string Process(string input);
}

class EncryptionTask : Task
{
    public override string Process(string input)
    {
        string[] fragments = Regex.Split(input, @"(\W)");

        StringBuilder encryptedText = new StringBuilder();
        StringBuilder decryptedText = new StringBuilder();
        foreach (string fragment in fragments)
        {
            if (!string.IsNullOrWhiteSpace(fragment))
            {
                char[] characters = fragment.ToCharArray();
                Array.Reverse(characters);
                encryptedText.Append(characters);
                Array.Reverse(characters); 
                decryptedText.Append(characters);
            }
            else 
            {
                encryptedText.Append(fragment);
                decryptedText.Append(fragment);
            }
        }

        return $"Зашифрованный текст: {encryptedText.ToString()}\nРасшифрованный текст: {decryptedText.ToString()}";
    }

    public override string ToString()
    {
        return "Шифрование текста";
    }
}

class ComplexityTask : Task
{
    public override string Process(string input)
    {
        int wordCount = CountWords(input);
        int punctuationCount = CountPunctuation(input);
        int complexity = wordCount + punctuationCount;
        return $"Сложность текста: {complexity}";
    }

    private int CountWords(string sentence)
    {
        MatchCollection matches =
            Regex.Matches(sentence, @"\b\w+\b");
        return matches.Count;
    }

    private int CountPunctuation(string sentence)
    {
        MatchCollection matches =
            Regex.Matches(sentence, @"[.,\/#!$%\^&\*;:{}=\-_`~()""']");
        return matches.Count;
    }
}

class SyllableCountTask : Task
{
    public override string Process(string input)
    {
        string pattern = @"[\p{L}-[\p{M}]]+";
        Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
        MatchCollection matches = regex.Matches(input);

        int[] syllableCounts = new int[10];

        foreach (Match match in matches)
        {
            string word = match.Value;
            int syllableCount = CountSyllables(word);
            if (syllableCount > 0 && syllableCount <= 9)
            {
                syllableCounts[syllableCount - 1]++;
            }
        }

        StringBuilder result = new StringBuilder();
        for (int i = 0; i < syllableCounts.Length; i++)
        {
            if (syllableCounts[i] > 0)
            {
                result.AppendLine($"Слов с {i + 1} слогом: {syllableCounts[i]}");
            }
        }

        return result.ToString();
    }

    private int CountSyllables(string word)
    {
        word = word.ToLower();
        int count = 0;
        bool isPrevVowel = false;

        foreach (char c in word)
        {
            if ("aeiouyаеёиоуыэюя".IndexOf(c) >= 0)
            {
                if (!isPrevVowel)
                {
                    count++;
                }
                isPrevVowel = true;
            }
            else
            {
                isPrevVowel = false;
            }
        }

        if (word.EndsWith("e") && count > 1)
        {
            count--;
        }

        return count;
    }
}

class FormatTextTask : Task
{
    public override string Process(string input)
    {
        int pageWidth = 80;

        string[] sentences = input.Split('.');
        StringBuilder lineBuilder = new StringBuilder();
        for (int i = 0; i < sentences.Length; i++)
        {
            string sentence = sentences[i].Trim();
            if (i == 7) 
            {
                Console.WriteLine(sentence);
                continue;
            }

            string[] words = sentence.Split(' ');
            foreach (string word in words)
            {
                if (lineBuilder.Length + word.Length + 1 > pageWidth)
                {
                    Console.WriteLine(AlignText(lineBuilder.ToString().TrimEnd(), pageWidth));
                    lineBuilder.Clear();
                }
                lineBuilder.Append(word + " ");
            }
        }

        return "Текст успешно отформатирован.";
    }

    static string AlignText(string text, int width)
    {
        int spacesToAdd = width - text.Replace(" ", "").Length;
        int wordCount = text.Split(' ').Length;
        int regularSpaces = spacesToAdd / (wordCount - 1);
        int extraSpaces = spacesToAdd % (wordCount - 1);

        string[] words = text.Split(' ');
        StringBuilder alignedText = new StringBuilder();
        for (int i = 0; i < words.Length; i++)
        {
            alignedText.Append(words[i]);
            if (i < words.Length - 1)
            {
                int spaces = i < extraSpaces ? regularSpaces + 1 : regularSpaces;
                alignedText.Append(new string(' ', spaces));
            }
        }
        return alignedText.ToString();
    }
}


class TextCompressionTask : Task
{
    public override string Process(string originalText)
    {
        Console.WriteLine("Оригинальный текст:");
        Console.WriteLine(originalText);

        Dictionary<string, char> codeTable;
        string compressedText = CompressText(originalText, out codeTable);
        Console.WriteLine("\nСжатый текст:");
        Console.WriteLine(compressedText);

        Console.WriteLine("\nТаблица кодов:");
        foreach (var pair in codeTable)
        {
            Console.WriteLine($"{pair.Key} : {pair.Value}");
        }

        string decompressedText = DecompressText(compressedText, codeTable);
        Console.WriteLine("\nДекомпрессированный текст:");
        Console.WriteLine(decompressedText);

        return "Текст успешно сжат и затем декомпрессирован.";
    }

    static string CompressText(string text, out Dictionary<string, char> codeTable)
    {
        codeTable = new Dictionary<string, char>();
        Dictionary<string, int> pairCount = new Dictionary<string, int>();
        char code = 'A';

        for (int i = 0; i < text.Length - 1; i++)
        {
            string pair = text.Substring(i, 2);
            if (!pairCount.ContainsKey(pair))
            {
                pairCount.Add(pair, 1);
            }
            else
            {
                pairCount[pair]++;
            }
        }

        var topPairs = pairCount.OrderByDescending(pair => pair.Value).Take(5);

        foreach (var pair in topPairs)
        {
            codeTable.Add(pair.Key, code++);
        }

        StringBuilder compressedText = new StringBuilder();
        int index = 0;

        while (index < text.Length - 1)
        {
            string pair = text.Substring(index, 2);
            if (codeTable.ContainsKey(pair))
            {
                compressedText.Append(codeTable[pair]);
            }
            else
            {
                compressedText.Append(pair);
            }
            index += 2;
        }

        return compressedText.ToString();
    }

    static string DecompressText(string compressedText, Dictionary<string, char> codeTable)
    {
        StringBuilder decompressedText = new StringBuilder();
        int index = 0;

        while (index < compressedText.Length)
        {
            char code = compressedText[index];
            string pair = codeTable.FirstOrDefault(x => x.Value == code).Key;
            if (pair != null)
            {
                decompressedText.Append(pair);
            }
            else
            {
                decompressedText.Append(code);
            }
            index++;
        }

        return decompressedText.ToString();
    }
}


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Выберите задание: 1 - Шифрование сообщения(№2), 2 - Подсчёт сложности предложения(№4), 3 - Подсчет количества слогов(№6), 4 - Разделение текста на строки(№8), 5 - Кодирование текста(№9, №10)");
        int choice = int.Parse(Console.ReadLine());

        Task task;
        switch (choice)
        {
            case 1:
                task = new EncryptionTask();
                Console.WriteLine("Введите сообщение для шифрования:");
                break;
            case 2:
                task = new ComplexityTask();
                Console.WriteLine("Введите предложение:");
                break;
            case 3:
                task = new SyllableCountTask();
                Console.WriteLine("Введите предложение:");
                break;
            case 4:
                task = new FormatTextTask();
                Console.WriteLine("Введите текст:");
                break;
            case 5:
                task = new TextCompressionTask();
                break;
            default:
                Console.WriteLine("Выбрано недопустимое задание.");
                return;
        }

        string input = "";
        if (choice == 5)
        {
            input = "После многолетних исследований ученые обнаружили тревожную тенденцию в вырубке лесов Амазонии. Анализ данных показал, что основной участник разрушения лесного покрова – человеческая деятельность. За последние десятилетия рост объема вырубки достиг критических показателей. Главными факторами, способствующими этому, являются промышленные рубки, производство древесины, расширение сельскохозяйственных угодий и незаконная добыча древесины. Это приводит к серьезным экологическим последствиям, таким как потеря биоразнообразия, ухудшение климата и угроза вымирания многих видов животных и растений.";
        }
        else
        {
            input = Console.ReadLine();
        }

        string result = task.Process(input);
        Console.WriteLine($"Результат:");
        Console.WriteLine(result);
    }
}
