using System;
using System.Text.RegularExpressions;
using System.Text;

abstract class Task
{
    public abstract string Process(string input);
}

class EncryptionTask : Task
{
    // Переопределяем метод Process для обработки входной строки
    public override string Process(string input)
    {
        // Разделяем строку на части (слова и знаки препинания) с помощью регулярного выражения
        string[] parts = Regex.Split(input, @"(\W)");

        // Создаем объект StringBuilder для хранения зашифрованного и расшифрованного сообщений
        StringBuilder encryptedMessage = new StringBuilder();
        StringBuilder decryptedMessage = new StringBuilder();

        // Обрабатываем каждую часть (слово или знак препинания) отдельно
        foreach (string part in parts)
        {
            // Если текущая часть - слово, шифруем его и расшифровываем
            if (!string.IsNullOrWhiteSpace(part))
            {
                char[] chars = part.ToCharArray(); // Преобразуем слово в массив символов
                Array.Reverse(chars); // Инвертируем порядок символов для шифрования
                encryptedMessage.Append(chars); // Добавляем зашифрованное слово к строке зашифрованного сообщения
                Array.Reverse(chars); // Обратная операция для расшифровки
                decryptedMessage.Append(chars); // Добавляем расшифрованное слово к строке расшифрованного сообщения
            }
            else // Если текущая часть - знак препинания, добавляем его без изменений
            {
                encryptedMessage.Append(part); // Добавляем знак препинания к строке зашифрованного сообщения
                decryptedMessage.Append(part); // Добавляем знак препинания к строке расшифрованного сообщения
            }
        }

        // Возвращаем результат в виде строки, содержащей зашифрованное и расшифрованное сообщения
        return $"Зашифрованное сообщение: {encryptedMessage.ToString()}\nРасшифрованное сообщение: {decryptedMessage.ToString()}";
    }

    // Переопределяем метод ToString для возврата описания задачи
    public override string ToString()
    {
        return "Шифрование сообщения";
    }
}



class ComplexityTask : Task
{
    // Переопределяем метод Process для обработки входной строки
    public override string Process(string input)
    {
        // Вычисляем количество слов во входной строке
        int wordCount = CountWords(input);

        // Вычисляем количество знаков препинания во входной строке
        int punctuationCount = CountPunctuation(input);

        // Вычисляем общую сложность предложения как сумму количества слов и знаков препинания
        int complexity = wordCount + punctuationCount;

        // Возвращаем результат в виде строки, содержащей сложность предложения
        return $"Сложность предложения: {complexity}";
    }

    // Метод для подсчета количества слов в строке
    private int CountWords(string sentence)
    {
        // Ищем все слова с помощью регулярного выражения
        System.Text.RegularExpressions.MatchCollection matches =
            System.Text.RegularExpressions.Regex.Matches(sentence, @"\b\w+\b");
        // Возвращаем количество найденных слов
        return matches.Count;
    }

    // Метод для подсчета количества знаков препинания в строке
    private int CountPunctuation(string sentence)
    {
        // Ищем все знаки препинания с помощью регулярного выражения
        System.Text.RegularExpressions.MatchCollection matches =
            System.Text.RegularExpressions.Regex.Matches(sentence, @"[.,\/#!$%\^&\*;:{}=\-_`~()""']");
        // Возвращаем количество найденных знаков препинания
        return matches.Count;
    }
}


class SyllableCountTask : Task
{
    // Переопределяем метод Process для обработки входной строки
    public override string Process(string input)
    {
        // Задаем шаблон регулярного выражения для поиска слов
        string pattern = @"[\p{L}-[\p{M}]]+";

        // Создаем объект регулярного выражения с заданным шаблоном
        Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);

        // Находим все слова во входной строке
        MatchCollection matches = regex.Matches(input);

        // Создаем массив для хранения количества слов с определенным количеством слогов
        int[] syllableCounts = new int[10];

        // Перебираем найденные слова
        foreach (Match match in matches)
        {
            string word = match.Value; // Получаем текущее слово
            int syllableCount = CountSyllables(word); // Вычисляем количество слогов в слове

            // Если количество слогов находится в диапазоне от 1 до 9, увеличиваем соответствующий счетчик
            if (syllableCount > 0 && syllableCount <= 9)
            {
                syllableCounts[syllableCount - 1]++;
            }
        }

        // Создаем объект StringBuilder для формирования результирующей строки
        StringBuilder result = new StringBuilder();

        // Перебираем массив с количеством слов по слогам и добавляем информацию в результат
        for (int i = 0; i < syllableCounts.Length; i++)
        {
            if (syllableCounts[i] > 0)
            {
                result.AppendLine($"Слов с {i + 1} слогом: {syllableCounts[i]}");
            }
        }

        // Возвращаем результат в виде строки
        return result.ToString();
    }

    // Метод для подсчета количества слогов в слове
    private int CountSyllables(string word)
    {
        word = word.ToLower(); // Приводим слово к нижнему регистру для удобства обработки
        int count = 0; // Инициализируем счетчик слогов
        bool isPrevVowel = false; // Флаг, указывающий на то, что предыдущая буква - гласная

        // Перебираем все буквы в слове
        foreach (char c in word)
        {
            // Если текущая буква - гласная, а предыдущая не была гласной, увеличиваем счетчик слогов
            if ("ауоиэы".IndexOf(c) >= 0)
            {
                if (!isPrevVowel)
                {
                    count++;
                }
                isPrevVowel = true;
            }
            if("яюеё".IndexOf(c) >= 0)
            {
                count++;
                isPrevVowel = true;
            }
            else
            {
                isPrevVowel = false;
            }
        }

        // Возвращаем общее количество слогов в слове
        return count;
    }
}


class FormatTextTask : Task
{
    // Переопределяем метод Process для обработки входной строки
    public override string Process(string input)
    {
        int pageWidth = 50; // Ширина страницы

        // Разбиваем входную строку на слова
        string[] words = input.Split(' ');

        // Создаем объект StringBuilder для построения отформатированных строк
        StringBuilder lineBuilder = new StringBuilder();

        // Перебираем слова из входной строки
        foreach (string word in words)
        {
            // Если добавление текущего слова превышает ширину страницы, выводим строку и очищаем буфер
            if (lineBuilder.Length + word.Length >= pageWidth)
            {
                Console.WriteLine(AlignText(lineBuilder.ToString(), pageWidth));
                lineBuilder.Clear();
            }
            lineBuilder.Append(word); // Добавляем текущее слово к текущей строке без пробела
            lineBuilder.Append(' '); // Добавляем пробел между словами
        }

        // Выводим последнюю строку, если она не пустая
        if (lineBuilder.Length > 0)
        {
            Console.WriteLine(AlignText(lineBuilder.ToString(), pageWidth));
        }

        // Возвращаем сообщение об успешном форматировании текста
        return "Текст успешно отформатирован.";
    }

    // Метод для выравнивания текста по ширине страницы
    static string AlignText(string text, int width)
    {
        // Вычисляем количество пробелов, которые нужно добавить между словами
        int spacesToAdd = width - text.Replace(" ", "").Length;
        int wordCount = text.Split(' ').Length;
        int regularSpaces = spacesToAdd / (wordCount - 1);
        int extraSpaces = spacesToAdd % (wordCount - 1);

        // Разбиваем текст на слова
        string[] words = text.Split(' ');

        // Создаем объект StringBuilder для формирования выровненного текста
        StringBuilder alignedText = new StringBuilder();

        // Перебираем слова
        for (int i = 0; i < words.Length; i++)
        {
            alignedText.Append(words[i]); // Добавляем текущее слово
            // Если это не последнее слово, добавляем пробелы
            if (i < words.Length - 1)
            {
                // Вычисляем количество пробелов для текущего слова
                int spaces = i < extraSpaces ? regularSpaces + 1 : regularSpaces;
                // Добавляем нужное количество пробелов к текущему слову
                alignedText.Append(new string(' ', spaces));
            }
        }
        return alignedText.ToString(); // Возвращаем выровненный текст
    }
}




class TextCompressionTask : Task
{
    // Переопределяем метод Process для обработки оригинального текста
    public override string Process(string originalText)
    {
        Console.WriteLine("Оригинальный текст:");
        Console.WriteLine(originalText);

        Dictionary<string, char> codeTable; // Создаем таблицу кодов
        string compressedText = CompressText(originalText, out codeTable); // Сжимаем текст и получаем таблицу кодов
        Console.WriteLine("\nСжатый текст:");
        Console.WriteLine(compressedText); // Выводим сжатый текст

        Console.WriteLine("\nТаблица кодов:");
        foreach (var pair in codeTable) // Выводим таблицу кодов
        {
            Console.WriteLine($"{pair.Key} : {pair.Value}");
        }

        string decompressedText = DecompressText(compressedText, codeTable); // Декомпрессируем текст
        Console.WriteLine("\nДекомпрессированный текст:");
        Console.WriteLine(decompressedText); // Выводим декомпрессированный текст

        return "Текст успешно сжат и затем декомпрессирован.";
    }

    // Метод для сжатия текста
    static string CompressText(string text, out Dictionary<string, char> codeTable)
    {
        codeTable = new Dictionary<string, char>(); // Инициализируем таблицу кодов
        Dictionary<string, int> pairCount = new Dictionary<string, int>(); // Создаем словарь для подсчета пар

        char code = '1'; // Начинаем с кода '1'

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
            codeTable.Add(pair.Key, code++); // Добавляем пару и соответствующий ей код в таблицу кодов
        }

        // Сжатие текста
        StringBuilder compressedText = new StringBuilder();
        int index = 0;

        while (index < text.Length - 1)
        {
            string pair = text.Substring(index, 2);
            if (codeTable.ContainsKey(pair))
            {
                compressedText.Append(codeTable[pair]); // Добавляем код пары, если она есть в таблице кодов
            }
            else
            {
                compressedText.Append(pair); // Иначе добавляем саму пару
            }
            index += 2;
        }

        return compressedText.ToString(); // Возвращаем сжатый текст
    }

    // Метод для декомпрессии текста
    static string DecompressText(string compressedText, Dictionary<string, char> codeTable)
    {
        StringBuilder decompressedText = new StringBuilder(); // Создаем объект StringBuilder для декомпрессированного текста
        int index = 0;

        while (index < compressedText.Length)
        {
            char code = compressedText[index]; // Получаем текущий код
            string pair = codeTable.FirstOrDefault(x => x.Value == code).Key; // Находим соответствующую пару по коду
            if (pair != null)
            {
                decompressedText.Append(pair); // Добавляем пару в декомпрессированный текст
            }
            else
            {
                decompressedText.Append(code); // Если пары нет в таблице кодов, добавляем сам код
            }
            index++;
        }

        return decompressedText.ToString(); // Возвращаем декомпрессированный текст
    }
}


class Program
{
    static void Main(string[] args)
    {
        // Выводим пользователю список доступных заданий и запрашиваем выбор
        Console.WriteLine("Выберите задание: 1 - Шифрование сообщения(№2), 2 - Подсчёт сложности предложения(№4), 3 - Подсчет количества слогов(№6), 4 - Разделение текста на строки(№8), 5 - Кодирование текста(№9, №10)");
        int choice = int.Parse(Console.ReadLine());

        Task task; // Создаем объект задачи

        // В зависимости от выбора пользователя создаем соответствующий объект задачи
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
            Console.WriteLine("Выбрано недопустимое задание."); // В случае недопустимого выбора выводим сообщение и завершаем программу
            return;
        }

        string input = ""; // Переменная для хранения входных данных

        // Если выбрано задание №5, вводим тестовый текст по умолчанию
        if (choice == 5)
        {
            input = "После многолетних исследований ученые обнаружили тревожную тенденцию в вырубке лесов Амазонии. Анализ данных показал, что основной участник разрушения лесного покрова – человеческая деятельность. За последние десятилетия рост объема вырубки достиг критических показателей. Главными факторами, способствующими этому, являются промышленные рубки, производство древесины, расширение сельскохозяйственных угодий и незаконная добыча древесины. Это приводит к серьезным экологическим последствиям, таким как потеря биоразнообразия, ухудшение климата и угроза вымирания многих видов животных и растений.";
        }
        else
        {
            input = Console.ReadLine(); // Вводим данные с консоли
        }

        string result = task.Process(input); // Обрабатываем входные данные и получаем результат выполнения задачи
        Console.WriteLine($"Результат:");
        Console.WriteLine(result); // Выводим результат на консоль
    }
}
