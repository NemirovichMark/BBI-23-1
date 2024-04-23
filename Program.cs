using System;

abstract class Task
{
    protected string text;
    public Task(string text)
    {
        this.text = text;
    }
    protected abstract void ParseText(string text);
}

class Task_1 : Task
{
    public Task_1(string text) : base(text)
    {
        ParseText(text);
    }
    public override string ToString()
    {
        return text;
    }
    private string Find_long(string text)
    {
        string[] symb = new string[] { ".", "!", "?" };
        for (int i = 0; i < symb.Length; i++)
        {
            text = text.Replace(symb[i], "&&");
        }
        text += " ";
        string[] lines = text.Split("&& ");
        string line = "";
        int longline = 0;
        for (int j = 0; j < lines.Length; j++)
        {
            if (lines[j].Length > longline)
            {
                line = lines[j];
                longline = lines[j].Length;
            }
        }
        return line;

    }

    protected override void ParseText(string text)
    {
        this.text = Find_long(text);
    }
}

class Program
{
    public static void Main()
    {
        Task_1 task1 = new Task_1("Привет! я самое длинное предложение. а ты?");
        Console.WriteLine(task1);

    }
}
////
class Task_2 : Task
{
    public Task_2(string text) : base(text)
    {
        ParseText(text);
    }
    public override string ToString()
    {
        return text;
    }
    private char Find_word(string text)
    {
        string[] words = text.Split(" ");
        char[] best = new char[words.Length];
        int[] count = new int[words.Length];
        int idd = 0;
        for (int j = 0; j < words.Length; j++)
        {
            bool f = false;
            for (int i = 0; i < best.Length; i++)
            {
                if (words[j][0] == best[i])
                {
                    count[i] += 1;
                    f = true;
                    break;
                }
            }
            if (!f)
            {
                best[idd] = words[j][0];
                count[idd] = 1;
                idd++;
            }
        }

        int l = 0;
        char sym = '-';
        for (int j = 0; j <= count.Length; j++)
        {
            if (count[j] > l)
            {
                l = count[j];
                sym = best[j];
            }
        }
        return sym;

    }

    protected override void ParseText(string text)
    {
        char n = Find_word(text);
        string s = "";
        string[] m = text.Split(" ");
        for (int i = 0; i < m.Length
          ; i++)
        {
            if (m[i][0] == n)
            {
                s += m[i] + " ";
            }
        }
        this.text = s;
    }
}
