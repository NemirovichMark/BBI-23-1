using System;
/*1, 3, 6, 12, 13, 15*/
abstract class Task
{
    protected string TEXT = " ";
    public Task(string text) { TEXT = text; }


}

class Task_1 : Task
{
    public Task_1(string text) : base(text)
    {
        TEXT = text;
    }
    public override string ToString()
    {
        return lettersPercent();
    }
    public string lettersPercent()
    {
        char[] arrayRussianLittle = new char[32]
            {
            'а', 'б', 'в', 'г', 'д', 'е', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч',
            'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я'
            };
        char[] arrayRussianBig = new char[32]
            {
            'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П',
            'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я'
            };
        double[] res = new double[32];

        for (int i = 0; i < TEXT.Length; i++)
        {
            for (int j = 0; j < res.Length; j++)
            {
                if (TEXT[i] == arrayRussianBig[j] || TEXT[i] == arrayRussianLittle[j])
                {
                    res[j]++;
                }
            }
        }
        double sum = 0;
        for (int i = 0; i < res.Length; i++)
        {
            sum += res[i];
        }
        string result = "";
        for (int i = 0; i < arrayRussianLittle.Length; i++)
        {
            result += $"{arrayRussianLittle[i]} буква: {Convert.ToString(Math.Round(res[i] / (sum / 100), 2))}%\n";
        }
        return result;
    }
}


class Task_3 : Task
{
    public Task_3(string text) : base(text)
    {
        TEXT = text;
    }
    public override string ToString()
    {
        return textLines();
    }
    public string textLines()
    {
        string result = "";

        int spaceInd = 0;
        string[] finalArray = new string[20];

        int Ind = 0;

        while (TEXT.Length > 50)
        {
            for (int i = 0; i < 50; i++)
            {
                if (TEXT[i] == ' ')
                {
                    spaceInd = i;
                }
            }
            finalArray[Ind] = TEXT.Substring(0, spaceInd);
            Ind++;
            TEXT = TEXT.Substring(spaceInd + 1);
        }
        finalArray[Ind] = TEXT;

        for (int i = 0; i < finalArray.Length; i++)
        {
            result += finalArray[i] + "\n";
        }

        return result;
    }
}

class Task_6 : Task
{

    public Task_6(string text) : base(text)
    {
    }

    public string Slogs()
    {
        int[] allSlogs = new int[10];
        int slog = 0; 

        char[] array = new char[26] { 'А', 'О', 'У', 'Ы', 'Э', 'Е', 'Ё', 'И', 'Ю', 'Я', 'а', 'о', 'у', 'ы', 'э', 'е', 'ё',
            'и', 'ю', 'я', 'a', 'o', 'e', 'i', 'u', 'y' };


        int firstIndex = 0;
        for (int i = firstIndex; i < TEXT.Length; i++)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if (TEXT[i] == array[j])
                {
                    slog++;
                }
                else if (TEXT[i] == ' ' || i == TEXT.Length - 1)
                {
                    firstIndex = i + 1;
                    allSlogs[slog]++;
                    slog = 0;
                    break;
                }
            }
        }

        string result = "";
        for (int i = 1; i < allSlogs.Length; i++)
        {
            result += $"{i} слогов: {Convert.ToString(allSlogs[i])}\n";
        }

        return result;
    }
    public override string ToString()
    {
        string result = "Частота встречаемости слогов в тексте:\n";

        return Slogs();
    }
}

class Task_13 : Task
{

    public Task_13(string text) : base(text)
    {
        TEXT = text;
    }
    public override string ToString()
    {
        return lettersPercent();
    }
    public string lettersPercent()
    {
        char[] arrayRussianLittle = new char[32]
             {
            'а', 'б', 'в', 'г', 'д', 'е', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч',
            'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я'
             };
        char[] arrayRussianBig = new char[32]
            {
            'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П',
            'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я'
            };
        double[] res = new double[32];
 
        for (int i = 0; i < TEXT.Length; i++)
        {
            for (int j = 0; j < res.Length; j++)
            {
                if ((TEXT[i] == arrayRussianBig[j] || TEXT[i] == arrayRussianLittle[j]) && (TEXT[i - 1] == ' ' || i == 0))//
                {
                    res[j]++;
                }
            }
        }

        double sum = 0;
        for (int i = 0; i < res.Length; i++)
        {
            sum += res[i];
        }
        string result = "";
        for (int i = 0; i < arrayRussianLittle.Length; i++)
        {
            if ((res[i] / (sum / 100)) != 0)
            {
                result += $"{arrayRussianLittle[i]} буква: {Convert.ToString(Math.Round(res[i] / (sum / 100), 2))}%\n";
            }
        }
        return result;
    }

}

public struct FamousWords
{
    private string _word;
    private string _code;
    public FamousWords(string word, string code)
    {
        _word = word;
        _code = code;
    }
    public string Word { get { return _word; } }
    public string Code { get { return _code; } }
}
class Task_12 : Task
{

    public Task_12(string text) : base(text) { }
    public override string ToString()
    {
        return mainWords();
    }
    public string mainWords()
    {
        FamousWords[] array = new FamousWords[3];
        array[0] = new FamousWords("в", ":(");
        array[1] = new FamousWords("и", ":)");
        array[2] = new FamousWords("не", "*");


        string TEXT = "1 июля 2015 года Греция объявила о дефолте по государственному долгу, став первой развитой страной в истории, которая не смогла выплатить свои долговые обязательства в полном объеме. Сумма дефолта составила порядка 1,6 миллиарда евро.";
        string[] wordsArray = TEXT.Split(new char[] { ' ', ',', '.', '!', '?', '-', '(', ')' });

        foreach (var word in wordsArray)
        {
            Console.WriteLine(word);
        }


        for (int i = 0; i < wordsArray.Length; i++)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if (wordsArray[i] == array[j].Word)
                {
                    wordsArray[i] = array[j].Code;
                }
            }
        }


        string result = "";
        for (int i = 0; i < wordsArray.Length; i++)
        {
            result += (wordsArray[i] + ' ');
        }
        return result;
    }
}
class Task_15 : Task
{
    private int[] allSlogs = new int[10];

    public Task_15(string text) : base(text)
    {
    }
    public override string ToString()
    {
        return $"Сумма чисел равна: {countNumbers()}";
    }
    private string countNumbers()
    {
        string[] numbers = new string[TEXT.Length];
        int Ind = 0;

        string finalResult = "";

        for (int i = 0; i < TEXT.Length; i++)
        {
            if ((TEXT[i] > 47) && TEXT[i] < 58)
            {
                finalResult += TEXT[i].ToString();
                numbers[Ind] = finalResult;
            }
            else
            {
                finalResult = "";
                Ind++;
            }
        }
        Ind = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if ((numbers[i] != null) && (numbers[i] != ""))
            {
                Ind += int.Parse(numbers[i]);
            }
        }

        TEXT = Ind.ToString();
        return TEXT;
    }
}

class Program
{
    public static void Main()
    {

        Console.WriteLine("1");
        Task_1 task1 = new Task_1("1 июля 2015 года Греция объявила о дефолте по государственному долгу, став первой развитой страной в истории, которая не смогла выплатить свои долговые обязательства в полном объеме. Сумма дефолта составила порядка 1,6 миллиарда евро. Этому предшествовали долгие переговоры с международными кредиторами, такими как Международный валютный фонд (МВФ), Европейский центральный банк (ЕЦБ) и Европейская комиссия (ЕК), о программах финансовой помощи и реструктуризации долга. Основными причинами дефолта стали недостаточная эффективность реформ, направленных на улучшение финансовой стабильности страны, а также политическая нестабильность, что вызвало потерю доверия со стороны международных инвесторов и кредиторов. Последст");
        Console.WriteLine(task1);

        Console.WriteLine();

        Console.WriteLine("3");

        Task_3 task3 = new Task_3("1 июля 2015 года Греция объявила о дефолте по государственному долгу, став первой развитой страной в истории, которая не смогла выплатить свои долговые обязательства в полном объеме. Сумма дефолта составила порядка 1,6 миллиарда евро. Этому предшествовали долгие переговоры с международными кредиторами, такими как Международный валютный фонд (МВФ), Европейский центральный банк (ЕЦБ) и Европейская комиссия (ЕК), о программах финансовой помощи и реструктуризации долга. Основными причинами дефолта стали недостаточная эффективность реформ, направленных на улучшение финансовой стабильности страны, а также политическая нестабильность, что вызвало потерю доверия со стороны международных инвесторов и кредиторов. Последст");
        Console.WriteLine(task3);

        Console.WriteLine();

        Console.WriteLine("6");
        Task_6 task6 = new Task_6("1 июля 2015 года Греция объявила о дефолте по государственному долгу, став первой развитой страной в истории, которая не смогла выплатить свои долговые обязательства в полном объеме. Сумма дефолта составила порядка 1,6 миллиарда евро. Этому предшествовали долгие переговоры с международными кредиторами, такими как Международный валютный фонд (МВФ), Европейский центральный банк (ЕЦБ) и Европейская комиссия (ЕК), о программах финансовой помощи и реструктуризации долга. Основными причинами дефолта стали недостаточная эффективность реформ, направленных на улучшение финансовой стабильности страны, а также политическая нестабильность, что вызвало потерю доверия со стороны международных инвесторов и кредиторов. Последст");
        Console.WriteLine(task6);

        Console.WriteLine();

        Console.WriteLine("12");
        Task_12 task12 = new Task_12("1 июля 2015 года Греция объявила о дефолте по государственному долгу, став первой развитой страной в истории, которая не смогла выплатить свои долговые обязательства в полном объеме. Сумма дефолта составила порядка 1,6 миллиарда евро. Этому предшествовали долгие переговоры с международными кредиторами, такими как Международный валютный фонд (МВФ), Европейский центральный банк (ЕЦБ) и Европейская комиссия (ЕК), о программах финансовой помощи и реструктуризации долга. Основными причинами дефолта стали недостаточная эффективность реформ, направленных на улучшение финансовой стабильности страны, а также политическая нестабильность, что вызвало потерю доверия со стороны международных инвесторов и кредиторов. Последст");
        Console.WriteLine(task12);

        Console.WriteLine();

        Console.WriteLine("13");
        Task_13 task13 = new Task_13("1 июля 2015 года Греция объявила о дефолте по государственному долгу, став первой развитой страной в истории, которая не смогла выплатить свои долговые обязательства в полном объеме. Сумма дефолта составила порядка 1,6 миллиарда евро. Этому предшествовали долгие переговоры с международными кредиторами, такими как Международный валютный фонд (МВФ), Европейский центральный банк (ЕЦБ) и Европейская комиссия (ЕК), о программах финансовой помощи и реструктуризации долга. Основными причинами дефолта стали недостаточная эффективность реформ, направленных на улучшение финансовой стабильности страны, а также политическая нестабильность, что вызвало потерю доверия со стороны международных инвесторов и кредиторов. Последст");
        Console.WriteLine(task13);

        Console.WriteLine();

        Console.WriteLine("15");
        Task_15 task15 = new Task_15("1 июля 2015 года Греция объявила о дефолте по государственному долгу, став первой развитой страной в истории, которая не смогла выплатить свои долговые обязательства в полном объеме. Сумма дефолта составила порядка 1,6 миллиарда евро. Этому предшествовали долгие переговоры с международными кредиторами, такими как Международный валютный фонд (МВФ), Европейский центральный банк (ЕЦБ) и Европейская комиссия (ЕК), о программах финансовой помощи и реструктуризации долга. Основными причинами дефолта стали недостаточная эффективность реформ, направленных на улучшение финансовой стабильности страны, а также политическая нестабильность, что вызвало потерю доверия со стороны международных инвесторов и кредиторов. Последст");
        Console.WriteLine(task15);

        Console.WriteLine();
    }
}