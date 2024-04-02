// See https://aka.ms/new-console-template for more information
using System;

struct Sportsmen
{
    private string _famile;
    private double _rez;
    private string _prep;
    private int _group;

    public string Famile => _famile;
    public double Rez => _rez;
    public string Prep => _prep;
    public int Group => _group;

    private const int Norma = 100;

    public Sportsmen(string famile, double rez, string prep, int group)
    {
        _famile = famile;
        _rez = rez;
        _prep = prep;
        _group = group;
    }

    public void DisplayInfo()
    {
        if (_rez < Norma)
        {
            Console.WriteLine("Фамилия {0} \t Результат {1:f2} \t Преподаватель {2:f3} \t Группа {3:f4} \t Норматив выполнен",
                Famile, Rez, Prep, Group);
        }
        else
        {
            Console.WriteLine("Фамилия {0} \t Результат {1:f2} \t Преподаватель {2:f3} \t Группа {3:f4}",
                Famile, Rez, Prep, Group);
        }
    }
}

class Program
{
    static void Main()
    {
        Sportsmen[] sp = new Sportsmen[5];
        string[] s = new string[] {
            "Иванова", "Петрова", "Сидорова",
            "Кузнецова", "Макарова"};
        double[] r = new double[] { 100, 155, 999, 85, 10 };
        int ss = 0;
        int[] n = new int[] { 1, 2, 3, 4, 5 };
        string[] re = new string[] { "Федотов", "Болт", "Неймар", "Месси", "Роналду" };

        for (int i = 0; i < sp.Length; i++)
        {
            sp[i] = new Sportsmen(s[i], r[i], re[i], n[i]);
            Console.WriteLine("Фамилия {0} \t Результат {1:f2} \t Преподаватель {2:f3} \t Группа {3:f4}",
                s[i], r[i], re[i], n[i]);
        }

        // Шелл
        int step = sp.Length / 2;
        while (step > 0)
        {
            for (int i = step; i < sp.Length; i++)
            {
                int j = i;
                Sportsmen current = sp[i];
                while (j >= step && sp[j - step].Rez < current.Rez)
                {
                    sp[j] = sp[j - step];
                    j -= step;
                }
                sp[j] = current;
            }
            step /= 2;
        }

        Console.WriteLine("-----------------------------------------------------------------------------------------");
        for (int i = 0; i < sp.Length; i++)
        {
            if (sp[i].Rez < 100)
            {
                sp[i].DisplayInfo();
                ss++;
            }
            else
            {
                sp[i].DisplayInfo();
            }
        }

        Console.WriteLine($"\nСуммарное количество участниц, выполнивших норматив: {ss}");
    }
}