
using System;
using System.Linq;

abstract class Task
{
    protected string text;

    public string Text
    {
        get => text;
        protected set => text = value;
    }

    public Task(string text)
    {
        this.text = text;
    }
}

class Task1 : Task
{
    public Task1(string text) : base(text) { }

    public override string ToString()
    {
        return text;
    }

    public void FindDuplicateWords()
    {
        Console.WriteLine("Повторяющиеся слова в тексте:");

        char[] separators = new char[] { ' ', ',', '.', ':', ';' };
        string[] words = text.Split(separators);

        for (int i = 0; i < words.Length; i++)
        {
            if (string.IsNullOrEmpty(words[i])) continue;

            for (int j = i + 1; j < words.Length; j++)
            {
                if (string.IsNullOrEmpty(words[j])) continue;

                if (string.Equals(words[i], words[j]))
                {
                    Console.WriteLine(words[i]);
                    words[j] = null; // Удаляем повторяющееся слово
                }
            }
        }
    }
}

class Task2 : Task
{
    public Task2(string text) : base(text) { }

    public string FindLongestWord()
    {
        string longestWord = "";
        string currentWord = "";
        bool inWord = false;

        foreach (char c in text)
        {
            if (char.IsLetter(c))
            {
                currentWord += c;
                inWord = true;
            }
            else if (inWord)
            {
                if (currentWord.Length > longestWord.Length)
                {
                    longestWord = currentWord;
                }
                currentWord = "";
                inWord = false;
            }
        }

        if (currentWord.Length > longestWord.Length)
        {
            longestWord = currentWord;
        }

        return longestWord;
    }

    public override string ToString()
    {
        return FindLongestWord();
    }
}
class Program
{
    static void Main()
    {
        Task1 task = new Task1("Программирование Студенты Программирование Слезы Студенты Учеба Программирование");
        task.FindDuplicateWords();
        string text = "Текст для задания по программированию разной длины";
        Task2 task2 = new Task2(text);
        Console.WriteLine("Longest word: " + task2);
    }
}