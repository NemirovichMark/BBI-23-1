using System;
using System.Collections.Generic;

// Абстрактный класс "Задание"
public abstract class Zadanie
{
    protected string text;

    public Zadanie(string text)
    {
        this.text = text;
    }

    public abstract void Reshit();
    public override abstract string ToString();
}

// Первое задание (№1)
public class ChastotaBukv : Zadanie
{
    private int[] chastota = new int[33];

    public ChastotaBukv(string text) : base(text) { }

    public override void Reshit()
    {

        int totalBukv = 0;

        foreach (char c in text.ToLower())
        {
            if (char.IsLetter(c))
            {
                chastota[c - 'а']++;
                totalBukv++;
            }
        }

        for (int i = 0; i < chastota.Length; i++)
        {
            chastota[i] = (int)((double)chastota[i] / totalBukv * 100);
        }


    }

    public override string ToString()
    {
        string result = "";
        for (int i = 0; i < 33; i++)
        {
            char bukva = (char)('а' + i);
            result += $"{bukva}: {chastota[i]}% ";
        }
        return result;
    }

}



// Второе задание (№3)
public class RazbienieNaStroki : Zadanie
{
    private List<string> stroki = new List<string>();
    public RazbienieNaStroki(string text) : base(text) { }

    public override void Reshit()
    {
        string[] slova = text.Split(' ');
        string stroka = "";


        foreach (string slovo in slova)
        {
            if (stroka.Length + slovo.Length + 1 <= 50)
            {
                stroka += slovo + " ";
            }
            else
            {
                stroki.Add(stroka.Trim());
                stroka = slovo + " ";
            }
        }
        stroki.Add(stroka.Trim());


    }

    public override string ToString()
    {
        string result = "";
        foreach (string stroka in stroki)
        {
            result += stroka + "\n";
        }
        return result;
    }
}



// 3 задание (№5)
public struct BukvaChastota
{
    public char Bukva { get; set; }
    public int Chastota { get; set; }
}

public class ChastotaNachalnyhBukv : Zadanie
{
    private List<BukvaChastota> chastotaBukv = new List<BukvaChastota>();

    public ChastotaNachalnyhBukv(string text) : base(text) { }

    public override void Reshit()
    {
        string[] slova = text.Split(new char[] { ' ', '.', ',', '!', '?', ':', ';' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (string slovo in slova)
        {
            if (slovo.Length > 0)
            {
                char firstChar = char.ToLower(slovo[0]);
                if (char.IsLetter(firstChar))
                {
                    var existing = chastotaBukv.FindIndex(b => b.Bukva == firstChar);
                    if (existing != -1)
                    {
                        chastotaBukv[existing] = new BukvaChastota { Bukva = firstChar, Chastota = chastotaBukv[existing].Chastota + 1 };
                    }
                    else
                    {
                        chastotaBukv.Add(new BukvaChastota { Bukva = firstChar, Chastota = 1 });
                    }
                }
            }
        }

        chastotaBukv.Sort((x, y) => y.Chastota.CompareTo(x.Chastota));
    }

    public override string ToString()
    {
        string result = "";
        foreach (var bukvaChastota in chastotaBukv)
        {
            result += $"{bukvaChastota.Bukva} ({bukvaChastota.Chastota}) ";
        }
        return result;
    }
}
//4 задние(№7)
public class PoiskOdnokorennyhSlov : Zadanie
{
    private string koren;
    List<string> naĭdennyeSlova = new List<string>();
    public PoiskOdnokorennyhSlov(string text, string koren) : base(text)
    {
        this.koren = koren.ToLower();

    }
    public override void Reshit()
    {
        string[] slova = text.ToLower().Split(' ', '.', ',', '!', '?', ':', ';');


        foreach (string slovo in slova)
        {
            if (IsOdnokorennoe(slovo, koren))
            {
                naĭdennyeSlova.Add(slovo);
            }
        }


    }

    private bool IsOdnokorennoe(string slovo, string koren)
    {
        return slovo.Contains(koren); // Проверяем, содержит ли слово корень

    }


    public override string ToString()
    {
        string result = "Найденные однокоренные слова: ";
        foreach (string slovo in naĭdennyeSlova)
        {
            result += slovo + " ";
        }
        return result;
    }
}

//5 задание (№14)
public class SummaChisel : Zadanie
{
    private int summa;

    public SummaChisel(string text) : base(text) { }

    public override void Reshit()
    {
        summa = 0;


        foreach (char symbol in text)
        {

            if (symbol >= '0' && symbol <= '9')
            {

                summa += symbol - '0';
            }
        }
    }

    public override string ToString()
    {
        return $"Сумма цифр в тексте: {summa}";
    }
}

//6 задание (#11)
public class SortirovkaFamilij : Zadanie
{
    private string[] Items;

    public SortirovkaFamilij(string text) : base(text) { }

    public override void Reshit()
    {

        Items = text.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < Items.Length - 1; i++)
        {
            for (int j = 0; j < Items.Length - i - 1; j++)
            {
                if (string.Compare(Items[j], Items[j + 1], StringComparison.CurrentCultureIgnoreCase) > 0)
                {
                    string temp = Items[j];
                    Items[j] = Items[j + 1];
                    Items[j + 1] = temp;
                }
            }
        }
    }

    public override string ToString()
    {
        return string.Join(", ", Items);
    }
}

// Пример использования
public class Program
{
    static void Main(string[] args)
    {

        string text = "международных инвесторов и кредиторов. Последствия дефолта оказались глубокими и долгосрочными: сокращение кредитного рейтинга страны, увеличение затрат на заемный капитал, рост стоимости заимствований и утрата доверия со стороны международных инвесторов. ";
        string koren = "вод";
        Console.WriteLine("Первое");
        Zadanie zadanie1 = new ChastotaBukv(text);
        zadanie1.Reshit();
        Console.WriteLine(zadanie1);

        Console.WriteLine("Второе");
        Zadanie zadanie2 = new RazbienieNaStroki(text);
        zadanie2.Reshit();
        Console.WriteLine(zadanie2);

        Console.WriteLine("Третье");
        Zadanie zadanie3 = new ChastotaNachalnyhBukv(text);
        zadanie3.Reshit();
        Console.WriteLine(zadanie3);


        string text1 = "Водопад это вода.Водная гладь прекрасна.Подводная";
        Console.WriteLine("Четвертое");
        Zadanie zadanie4 = new PoiskOdnokorennyhSlov(text1, koren);
        zadanie4.Reshit();
        Console.WriteLine(zadanie4);



        Console.WriteLine("Пятое");


        string input = "Текст содержит 1 слово, 2015 числа и 3 знака препинания. Сумма: 999 !";
        Zadanie zadanie6 = new SummaChisel(input);
        zadanie6.Reshit();
        Console.WriteLine(zadanie6);

        Console.WriteLine("Шестое");
        string input5 = "Козлов\r\nНовиков\r\nИванова\r\nПетрова\r\nСмирнова\r\n\r\n\r\nIvanov\r\nPetrov\r\nSmirnov\r\nSokolov\r\n, Антонов Борисов";
        Zadanie task5 = new SortirovkaFamilij(input5);
        task5.Reshit();
        Console.WriteLine(task5.ToString());
    }
}