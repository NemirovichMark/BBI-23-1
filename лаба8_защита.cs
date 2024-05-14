using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
abstract class Task
{
    protected string print = "";
    public Task(string text)
    {
    }
    public override string ToString()
    {
        return print;

    }
    protected abstract void ParseText(string text); // все разные
    protected virtual int Count() // если несколько одинаковых, а один выбивается
    {
        return -1;
    }
    protected double CountPersent(double number, double total) // все одинаковые
    {
        return Math.Round(number / total * 100, 2);
    }
}
class Task_1 : Task
{
    public Task_1(string text) : base(text)
    {
        ParseText(text);
    }
    protected override void ParseText(string text)
    {
        Dictionary<char, double> RussianLetters = new Dictionary<char, double>();
        for (char i = 'а'; i <= 'я'; i++)
        {
            RussianLetters[i] = 0;
        }
        text = text.ToLower();
        double s = 0;
        foreach (char symbol in text)
        {
            if (char.IsLetter(symbol))
            {
                if ('а' <= symbol & symbol <= 'я')
                {
                    s++;
                    RussianLetters[symbol]++;
                }
            }
        }
        for (char i = 'а'; i <= 'я'; i++)
        {
            RussianLetters[i] = CountPersent(RussianLetters[i], s);
        }
        foreach (var i in RussianLetters)
        {
            print += i.Key + " " + i.Value + "\n";
        }
    }
}
class Task_3 : Task
{
    public Task_3(string text) : base(text)
    {
        ParseText(text);
    }
    protected override void ParseText(string text)
    {
        List<string> list = new List<string>();
        string[] Words = text.Split();
        string currentline = "";
        int length = 0;
        foreach (string word in Words)
        {
            if (length + word.Length > 50)
            {
                list.Add(currentline);
                currentline = "";
                length = 0;
            }
            currentline += word + " ";
            length += word.Length + 1;
        }
        list.Add(currentline);
        for (int i = 0; i < list.Count; i++)
        {
            list[i] = list[i].Remove(list[i].Length - 1);
            print += list[i] + "\n";
        }
    }
}
class Data5
{
    private char _symbol;
    public char Symbol { get { return _symbol; } set { _symbol = value; } }
    private int _number;
    public int Number { get { return _number; } }
    public Data5(char symbol)
    {
        _symbol = symbol;
        _number = 1;
    }

    public void Increase() { _number++; }
    public static void ArrayUpdate(ref Data5[] array, char newchar)
    {
        Data5[] newarray = new Data5[array.Length + 1];
        for (int i = 0; i < array.Length; i++)
        {
            newarray[i] = array[i];
        }
        newarray[newarray.Length - 1] = new Data5(newchar);
        array = newarray;
    }
    public void Print() { Console.WriteLine($"{_symbol}-{_number}"); }
}
class Task_5 : Task
{
    public Task_5(string text) : base(text)
    {
        ParseText(text);
    }
    protected override void ParseText(string text)
    {
        text = text.ToLower();
        Data5[] Russian = new Data5[0];
        string[] words = text.Split(new char[] { ' ', ',', ';', '.', '!', '?', ':', '(', ')', '"' });
        char first_letter;
        foreach (string word in words)
        {
            if (word.Length > 0 && char.IsLetter(word[0]))
            {
                first_letter = word[0];
                bool est = false;
                for (int i = 0; i < Russian.Length; i++)
                {
                    if (Russian[i].Symbol == first_letter) { Russian[i].Increase(); est = true; }
                }
                if (!est)
                {
                    Data5.ArrayUpdate(ref Russian, first_letter);
                }
            }
        }
        Sort(Russian);
        foreach (var data in Russian)
        {
            data.Print();
        }
    }
    static void Sort(Data5[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length - 1; j++)
            {
                if (array[j].Number < array[j + 1].Number)
                {
                    Data5 t = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = t;
                }
            }
        }
    }
}
class Task_7 : Task
{
    private string request;
    public Task_7(string text) : base(text)
    {
        Console.WriteLine("Введите свой запрос:");
        request = Console.ReadLine();
        ParseText(text);
    }
    protected override void ParseText(string text)
    {
        string[] Words = text.Split(new char[] { ' ', ',', ';', '.', '!', '?', ':', '(', ')', '"' });
        foreach (string word in Words)
        {
            if (word.Contains(request))
            {
                print += word + "\n";
            }
        }
        if (print == "")
        {
            print = "Не найден результат по запросу";
        }
    }
}
class Task_11 : Task
{
    public Task_11(string text) : base(text)
    {
        ParseText(text);
    }
    protected override void ParseText(string text)
    {
        string[] Words = text.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        Sort(Words);
        foreach (string i in Words)
        {
            print += i + "\n";
        }
    }
    static bool Check(string name1, string name2)
    {
        int length = Math.Min(name1.Length, name2.Length);
        int index = 0;
        while (index < length && name1[index] == name2[index])
        {
            index++;
        }
        if (index == length)
        {
            if (name1.Length > name2.Length)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        else
        {
            if (name1[index] > name2[index])
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
    static void Sort(string[] Words)
    {
        for (int i = 1; i < Words.Length; i++)
        {
            string val = Words[i];
            for (int j = i - 1; j >= 0;)
            {
                if (Check(val, Words[j]))
                {
                    Words[j + 1] = Words[j];
                    Words[j] = val;
                    j--;
                }
                else break;
            }
        }
    }
}
class Task_14 : Task
{
    private int s = 0;
    public Task_14(string text) : base(text)
    {
        ParseText(text);
        print = s + "";
    }
    protected override void ParseText(string text)
    {
        string[] Words = text.Split();
        foreach (string word in Words)
        {
            string line = "";
            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsDigit(word[i]))
                {
                    line += word[i];
                }
                else if (line != "")
                {
                    s += int.Parse(line);
                    line = "";
                }
            }
            if (line != "")
            {
                s += int.Parse(line);
            }
        }
    }

}
class Program
{
    static void Main(string[] args)
    {
        Task_1 task1 = new Task_1("William Shakespeare, widely regarded as one of the greatest writers in the English language, authored a total of 37 plays, along with numerous poems and sonnets. He was born in Stratford-upon-Avon, England, in 1564, and died in 1616. Shakespeare's most famous works, including \\\"Romeo and Juliet,\\\" \\\"Hamlet,\\\" \\\"Macbeth,\\\" and \\\"Othello,\\\" were written during the late 16th and early 17th centuries. \\\"Romeo and Juliet,\\\" a tragic tale of young love, was penned around 1595. \\\"Hamlet,\\\" one of his most celebrated tragedies, was written in the early 1600s, followed by \\\"Macbeth,\\\" a gripping drama exploring themes of ambition and power, around 1606. \\\"Othello,\\\" a tragedy revolving around jealousy and deceit, was also composed during this period, believed to be around 1603.\");\r\n");
        Console.WriteLine(task1);
        //Task_3 task3 = new Task_3("Двигатель самолета – это сложная инженерная конструкция, обеспечивающая подъем, управление и движение в воздухе. Он состоит из множества компонентов, каждый из которых играет важную роль в общей работе механизма. Внутреннее устройство двигателя включает в себя компрессор, камеру сгорания, турбину и системы управления и охлаждения. Принцип работы основан на воздушно-топливной смеси, которая подвергается сжатию, воспламенению и расширению, обеспечивая движение воздушного судна.");
        //Console.WriteLine(task3);
        Task_5 task5 = new Task_5("1 июля 2015 года Греция объявила о дефолте по государственному долгу, став первой развитой страной в истории, которая не смогла выплатить свои долговые обязательства в полном объеме. Сумма дефолта составила порядка 1,6 миллиарда евро. Этому предшествовали долгие переговоры с международными кредиторами, такими как Международный валютный фонд (МВФ), Европейский центральный банк (ЕЦБ) и Европейская комиссия (ЕК), о программах финансовой помощи и реструктуризации долга. Основными причинами дефолта стали недостаточная эффективность реформ, направленных на улучшение финансовой стабильности страны, а также политическая нестабильность, что вызвало потерю доверия со стороны международных инвесторов и кредиторов. Последствия дефолта оказались глубокими и долгосрочными: сокращение кредитного рейтинга страны, увеличение затрат на заемный капитал, рост стоимости заимствований и утрата доверия со стороны международных инвесторов.");
        Console.WriteLine(task5);
        //Task_7 task7 = new Task_7("Фьорды – это ущелья, формирующиеся ледниками и заполняющиеся морской водой. Название происходит от древнескандинавского слова \"fjǫrðr\". Эти глубокие заливы, окруженные высокими горами, представляют захватывающие виды и природную красоту. Они популярны среди туристов и известны под разными названиями: в Норвегии – \"фьорды\", в Шотландии – \"фьордс\", в Исландии – \"фьордар\". Фьорды играют важную роль в культуре и туризме региона, продолжая вдохновлять людей со всего мира.");
        //Console.WriteLine(task7);
        //Task_11 task11 = new Task_11("Иванов, Петров, Смирнов, Соколов, Кузнецов, Попов, Лебедев, Волков, Козлов, Новиков, Иванова, Петрова, Смирнова, Ivanov, Petrov,Smirnov,Sokolov,Kuznetsov,Popov,Lebedev,Volkov,Kozlov,Novikov,Ivanova,Petrova,Smirnova");
        //Console.WriteLine(task11);
        //Task_14 task14 = new Task_14("William Shakespeare, widely regarded as one of the greatest writers in the English language, authored a total of 37 plays, along with numerous poems and sonnets. He was born in Stratford-upon-Avon, England, in 1564, and died in 1616. Shakespeare's most famous works, including \"Romeo and Juliet,\" \"Hamlet,\" \"Macbeth,\" and \"Othello,\" were written during the late 16th and early 17th centuries. \"Romeo and Juliet,\" a tragic tale of young love, was penned around 1595. \"Hamlet,\" one of his most celebrated tragedies, was written in the early 1600s, followed by \"Macbeth,\" a gripping drama exploring themes of ambition and power, around 1606. \"Othello,\" a tragedy revolving around jealousy and deceit, was also composed during this period, believed to be around 1603.");
        // Console.WriteLine(task14);
    }
}
