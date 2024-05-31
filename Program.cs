using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

abstract class TaskBase
{
    public abstract string Execute(string input);
}

class MessageEncryptor : TaskBase
{
    public override string Execute(string input)
    {
        var words = input.Split(' ');
        var encryptedText = new StringBuilder();

        foreach (var word in words)
        {
            var characters = word.Reverse().ToArray();
            encryptedText.Append(new string(characters) + " ");
        }

        return encryptedText.ToString().Trim();
    }
}

class MessageDecryptor : TaskBase
{
    public override string Execute(string input)
    {
        var words = input.Split(' ');
        var decryptedText = new StringBuilder();

        foreach (var word in words)
        {
            var characters = word.Reverse().ToArray();
            decryptedText.Append(new string(characters) + " ");
        }

        return decryptedText.ToString().Trim();
    }
}

class SentenceComplexityAnalyzer : TaskBase
{
    public override string Execute(string input)
    {
        var elements = Regex.Split(input, @"(\W)");
        var wordCount = 0;
        var punctuationCount = 0;

        foreach (var element in elements)
        {
            if (!string.IsNullOrWhiteSpace(element))
            {
                if (char.IsLetterOrDigit(element[0]))
                    wordCount++;
                else
                    punctuationCount++;
            }
        }

        return $"Сложность предложения: {wordCount + punctuationCount}";
    }
}

class InitialLetterFrequencyAnalyzer : TaskBase
{
    public override string Execute(string input)
    {
        var letterFrequency = new Dictionary<char, int>();
        var words = input.Split(new[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (var word in words)
        {
            if (!string.IsNullOrEmpty(word))
            {
                var firstLetter = word[0];

                if (char.IsLetter(firstLetter))
                {
                    if (letterFrequency.ContainsKey(firstLetter))
                        letterFrequency[firstLetter]++;
                    else
                        letterFrequency[firstLetter] = 1;
                }
            }
        }

        var sortedFrequencies = letterFrequency.OrderByDescending(pair => pair.Value);
        var result = new StringBuilder();
        result.AppendLine("Буквы, с которых начинаются слова, в порядке убывания частоты:");

        foreach (var pair in sortedFrequencies)
        {
            result.AppendLine($"{pair.Key}: {pair.Value}");
        }

        return result.ToString();
    }
}

class WordSequenceFinder : TaskBase
{
    public override string Execute(string input)
    {
        Console.WriteLine("Введите последовательность букв:");
        var sequence = Console.ReadLine();
        var matchingWords = new List<string>();
        var words = Regex.Split(input, @"\W+");

        foreach (var word in words)
        {
            if (word.Contains(sequence, StringComparison.OrdinalIgnoreCase))
                matchingWords.Add(word);
        }

        return $"Слова, содержащие '{sequence}': {string.Join(", ", matchingWords)}";
    }
}

class SurnameAlphabetizer : TaskBase
{
    public override string Execute(string input)
    {
        var surnames = input.Split(',').Select(s => s.Trim()).OrderBy(s => s).ToArray();
        return string.Join(", ", surnames);
    }
}

class NumberSummarizer : TaskBase
{
    public override string Execute(string input)
    {
        var total = 0;
        var elements = input.Split(new[] { ' ', ',', '.', '!', '?', ':', ';', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (var element in elements)
        {
            if (int.TryParse(element, out var number) && number >= 1 && number <= 10)
                total += number;
        }

        return $"Сумма чисел от 1 до 10 в тексте: {total}";
    }
}

class Application
{
    static void Main(string[] args)
    {
        Console.WriteLine("Выберите задание: ");
        Console.WriteLine("1) Зашифровать сообщение.");
        Console.WriteLine("2) Расшифровать сообщение.");
        Console.WriteLine("3) Определить сложность предложения.");
        Console.WriteLine("4) Вывести частоту начальных букв слов.");
        Console.WriteLine("5) Найти слова, содержащие заданную последовательность.");
        Console.WriteLine("6) Упорядочить список фамилий.");
        Console.WriteLine("7) Найти сумму чисел от 1 до 10 в тексте.");
        Console.Write("Ваш выбор: ");

        var choice = int.Parse(Console.ReadLine());
        TaskBase task = choice switch
        {
            1 => new MessageEncryptor(),
            2 => new MessageDecryptor(),
            3 => new SentenceComplexityAnalyzer(),
            4 => new InitialLetterFrequencyAnalyzer(),
            5 => new WordSequenceFinder(),
            6 => new SurnameAlphabetizer(),
            7 => new NumberSummarizer(),
            _ => null,
        };

        if (task == null)
        {
            Console.WriteLine("Недопустимый выбор.");
            return;
        }

        Console.Write("Введите текст: ");
        var input = Console.ReadLine();

        var result = task.Execute(input);
        Console.WriteLine($"Результат:\n{result}");
    }
}
