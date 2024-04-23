
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string solutionPath = Path.Combine(desktopPath, "Solution");

        // Создаю папки "Solution"
        if (!Directory.Exists(solutionPath))
        {
            Directory.CreateDirectory(solutionPath);

            // Задаю создание файлов "task_1.json" и "task_2.json" в папке "Solution"
            File.Create(Path.Combine(solutionPath, "task_1.json")).Close();
            File.Create(Path.Combine(solutionPath, "task_2.json")).Close();

            Console.WriteLine("Папка 'Solution' и файлы 'task_1.json' и 'task_2.json' успешно созданы.");
        }
        else
        {
            Console.WriteLine("Папка 'Solution' уже существует.");
        }

        string text = "На столе лежат книги, ручка, карандаш и цветные маркеры. За окном светит яркое солнце.";

        string[] tasks = { Task1(text), Task2(text) };

        Console.WriteLine(tasks[0]);
        foreach (var word in tasks[1].Split(' '))
        {
            Console.WriteLine(word);
        }
    }

    static string Task1(string text)
    {
        string[] sentences = text.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        string shortestSentence = null;
        int minSentenceLength = int.MaxValue;

        foreach (var sentence in sentences)
        {
            int sentenceLength = CountWords(sentence);

            if (sentenceLength < minSentenceLength)
            {
                shortestSentence = sentence.Trim();
                minSentenceLength = sentenceLength;
            }
        }

        return shortestSentence;
    }

    static string Task2(string text)
    {
        string[] words = text.Split(new char[] { ' ', '.', ',', '!', '?', ':', ';', '-' }, StringSplitOptions.RemoveEmptyEntries);
        string result = "";

        foreach (var word in words)
        {
            if (word.Length > 1 && UniqCharacters(word))
            {
                result += word + " ";
            }
        }

        return result;
    }

    static int CountWords(string sentence)
    {
        int count = 0;
        string[] words = sentence.Split(new char[] { ' ', '.', ',', '!', '?', ':', ';', '-' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (var word in words)
        {
            if (word.Length > 0)
            {
                count++;
            }
        }

        return count;
    }

    static bool UniqCharacters(string word)
    {
        for (int i = 0; i < word.Length; i++)
        {
            for (int j = i + 1; j < word.Length; j++)
            {
                if (word[i] == word[j])
                {
                    return false;
                }
            }
        }

        return true;
    }
}
