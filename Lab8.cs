using System;
using System.Text.RegularExpressions;
using System.Text;

abstract class Task
{
    public abstract string Process(string input);
}

class EncryptionTask : Task
{
    public override string Process(string input)
    {
        // Разделяем слова и знаки препинания с помощью регулярного выражения
        string[] parts = Regex.Split(input, @"(\W)");

        // Обрабатываем каждую часть (слово или знак препинания) отдельно
        StringBuilder encryptedMessage = new StringBuilder();
        StringBuilder decryptedMessage = new StringBuilder();
        foreach (string part in parts)
        {
            // Если текущая часть - слово, шифруем его и расшифровываем
            if (!string.IsNullOrWhiteSpace(part))
            {
                char[] chars = part.ToCharArray();
                Array.Reverse(chars);
                encryptedMessage.Append(chars);
                Array.Reverse(chars); // Обратная операция для расшифровки
                decryptedMessage.Append(chars);
            }
            else // Если текущая часть - знак препинания, добавляем его без изменений
            {
                encryptedMessage.Append(part);
                decryptedMessage.Append(part);
            }
        }

        return $"Зашифрованное сообщение: {encryptedMessage.ToString()}\nРасшифрованное сообщение: {decryptedMessage.ToString()}";
    }

    public override string ToString()
    {
        return "Шифрование сообщения";
    }
}


class ComplexityTask : Task
{
    public override string Process(string input)
    {
        int wordCount = CountWords(input);
        int punctuationCount = CountPunctuation(input);
        int complexity = wordCount + punctuationCount;
        return $"Сложность предложения: {complexity}";
    }

    private int CountWords(string sentence)
    {
        System.Text.RegularExpressions.MatchCollection matches =
            System.Text.RegularExpressions.Regex.Matches(sentence, @"\b\w+\b");
        return matches.Count;
    }

    private int CountPunctuation(string sentence)
    {
        System.Text.RegularExpressions.MatchCollection matches =
            System.Text.RegularExpressions.Regex.Matches(sentence, @"[.,\/#!$%\^&\*;:{}=\-_`~()""']");
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
        int pageWidth = 80; // Ширина страницы

        string[] words = input.Split(' ');
        StringBuilder lineBuilder = new StringBuilder();
        foreach (string word in words)
        {
            if (lineBuilder.Length + word.Length >= pageWidth)
            {
                Console.WriteLine(AlignText(lineBuilder.ToString(), pageWidth));
                lineBuilder.Clear();
            }
            lineBuilder.Append(word + " ");
        }
        if (lineBuilder.Length > 0)
        {
            Console.WriteLine(AlignText(lineBuilder.ToString(), pageWidth));
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
        char code = 'a'; // начинаем с кода 'a'

        // Подсчет количества вхождений каждой пары букв
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

        // Выбор пяти самых часто встречающихся пар
        var topPairs = pairCount.OrderByDescending(pair => pair.Value).Take(5);

        // Создание кодов для выбранных пар
        foreach (var pair in topPairs)
        {
            codeTable.Add(pair.Key, code++);
        }

        // Сжатие текста
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
        if (choice == 1)
        {
            task = new EncryptionTask();
            Console.WriteLine("Введите сообщение для шифрования:");
        }
        else if (choice == 2)
        {
            task = new ComplexityTask();
            Console.WriteLine("Введите предложение:");
        }
        else if (choice == 3)
        {
            task = new SyllableCountTask();
            Console.WriteLine("Введите предложение:");
        }
        else if (choice == 4)
        {
            task = new FormatTextTask();
            Console.WriteLine("Введите текст:");
        }
        else if (choice == 5)
        {
            task = new TextCompressionTask();
        }
        else
        {
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
