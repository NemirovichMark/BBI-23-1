using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

abstract class Task
{
    public abstract string Process(string input);
}

class LetterFrequencyTask : Task
{
    public override string Process(string input)
    {
        Dictionary<char, double> letterFrequencies = new Dictionary<char, double>();
        int letterCount = 0;
        string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        string lowerInput = input.ToLower();

        foreach (char character in lowerInput)
        {
            if (alphabet.Contains(character))
            {
                letterCount++;
                if (letterFrequencies.ContainsKey(character))
                {
                    letterFrequencies[character]++;
                }
                else
                {
                    letterFrequencies[character] = 1;
                }
            }
        }

        foreach (char key in letterFrequencies.Keys.ToList())
        {
            letterFrequencies[key] /= letterCount;
        }

        var sortedFrequencies = letterFrequencies.OrderByDescending(entry => entry.Value);

        StringBuilder resultBuilder = new StringBuilder();
        foreach (var entry in sortedFrequencies)
        {
            resultBuilder.AppendLine($"Буква '{entry.Key}': {entry.Value:P2}");
        }

        return resultBuilder.ToString();
    }
}


class ReverseWordsTask : Task
{
    public override string Process(string input)
    {
        string[] words = input.Split(' ');
        List<string> reversedWords = new List<string>();

        foreach (string word in words)
        {
            StringBuilder finalWord = new StringBuilder();
            Stack<char> letters = new Stack<char>();

            foreach (char c in word)
            {
                if (char.IsLetterOrDigit(c))
                {
                    letters.Push(c);
                }
            }

            foreach (char c in word)
            {
                if (char.IsLetterOrDigit(c))
                {
                    finalWord.Append(letters.Pop());
                }
                else
                {
                    finalWord.Append(c);
                }
            }

            reversedWords.Add(finalWord.ToString());
        }

        return string.Join(" ", reversedWords);
    }
}

class LineBreakTask : Task
{
    public override string Process(string input)
    {
        const int MaxLength = 50;
        string[] wordsArray = input.Split(' ');
        StringBuilder outputText = new StringBuilder();
        int lineLength = 0;

        foreach (string word in wordsArray)
        {
            if (lineLength + word.Length + 1 > MaxLength)
            {
                outputText.AppendLine();
                lineLength = 0;
            }
            
            outputText.Append(word + " ");
            lineLength += word.Length + 1;
        }

        return outputText.ToString().TrimEnd();
    }
}


class SentenceComplexityTask : Task
{
    public override string Process(string input)
    {
        char[] punctuationMarks = { '.', ',', ';', ':', '!', '?' };
        int wordCount = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
        int punctuationCount = input.Count(c => punctuationMarks.Contains(c));
        int complexity = wordCount + punctuationCount;

        return $"Сложность предложения: {complexity}";
    }
}

class StartingLettersTask : Task
{
    public override string Process(string input)
    {
        Dictionary<char, int> startingLetterCounts = new Dictionary<char, int>();
        string[] wordsArray = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in wordsArray)
        {
            char initialChar = char.ToLower(word[0]);
            if (char.IsLetter(initialChar) && initialChar >= 'а' && initialChar <= 'я')
            {
                if (startingLetterCounts.ContainsKey(initialChar))
                {
                    startingLetterCounts[initialChar]++;
                }
                else
                {
                    startingLetterCounts[initialChar] = 1;
                }
            }
        }

        var sortedLetters = startingLetterCounts.OrderByDescending(entry => entry.Value);

        StringBuilder output = new StringBuilder();
        foreach (var entry in sortedLetters)
        {
            output.AppendLine($"Буква '{entry.Key}': {entry.Value}");
        }

        return output.ToString();
    }
}


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Выберите задание: ");
        Console.WriteLine("1) Определить частоту букв в тексте.");
        Console.WriteLine("2) Зашифровать/расшифровать сообщение (слова наоборот).");
        Console.WriteLine("3) Разбить исходный текст на строки длиной не более 50 символов.");
        Console.WriteLine("4) Определить сложность предложения.");
        Console.WriteLine("5) Частота начальных букв слов в русском тексте.");
        Console.Write("Ваш выбор: ");

        int choice = int.Parse(Console.ReadLine());

        Task task;
        switch (choice)
        {
            case 1:
                task = new LetterFrequencyTask();
                break;
            case 2:
                task = new ReverseWordsTask();
                break;
            case 3:
                task = new LineBreakTask();
                break;
            case 4:
                task = new SentenceComplexityTask();
                break;
            case 5:
                task = new StartingLettersTask();
                break;
            default:
                Console.WriteLine("Недопустимый выбор.");
                return;
        }

        Console.Write("Введите текст: ");
        string input = Console.ReadLine();

        string result = task.Process(input);
        Console.WriteLine($"Результат:\n{result}");
    }
}
