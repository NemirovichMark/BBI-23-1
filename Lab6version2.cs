# region 1.1
/
using System;

public struct JumpResult
{
    private string lastName;
    private string society;
    private double Result1;
    private double Result2;
    private double totalResult;

    public JumpResult(string lastName, string society, double Result1, double Result2)
    {
        this.lastName = lastName;
        this.society = society;
        this.Result1 = Result1;
        this.Result2 = Result2;
        this.totalResult = Result1 + Result2;
    }

    public string LastName { get { return lastName; } }
    public string Society { get { return society; } }
    public double TotalResult { get { return totalResult; } }

    public override string ToString()
    {
        return string.Format("{0,-15} {1,-15} {2,10} {3,10} {4,10}", lastName, society, Result1, Result2, totalResult);
    }
}

class JumpCompetition
{
    static void Main()
    {
        JumpResult[] results = new JumpResult[]
        {
            new JumpResult("Чайкина", "МИСиС", 5.6, 6.2),
            new JumpResult("Чичинкова", "ВШЭ", 5.5, 6.0),
            new JumpResult("Лунин", "МГИМО", 5.8, 6.1),
            new JumpResult("Бычкова", "МГТУ", 5.7, 6.3),
            new JumpResult("Агапова", "МГУ", 5.9, 6.2)
        };

        Array.Sort(results, (x, y) => y.TotalResult.CompareTo(x.TotalResult));

        Console.WriteLine("{0,-15} {1,-15} {2,10} {3,10} {4,10}", "Фамилия", "Общество", "1-ая попытка", "2-ая попытка", "Итого");
        Console.WriteLine(new string('-', 60));

        foreach (var result in results) // перебор элементов резалта
        {
            Console.WriteLine(result);
        }
    }
}
*/

#region 1.1 защита
/
using System;

public struct JumpResult
{
    private string lastName;
    private double totalResult;

    public JumpResult(string lastName, double Result1, double Result2)
    {
        this.lastName = lastName;
        this.totalResult = Result1 + Result2;
    }

    public string LastName { get { return lastName; } }
    public double TotalResult { get { return totalResult; } }

    public override string ToString()
    {
        return string.Format("{0,-15} {1,10}", lastName, totalResult);
    }
}

class JumpCompetition
{
    static void Main()
    {
        JumpResult[] results = new JumpResult[]
        {
            new JumpResult("Чайкина", 5.6, 6.2),
            new JumpResult("Чичинкова", 5.5, 6.0),
            new JumpResult("Лунин", 5.8, 6.1),
            new JumpResult("Бычкова", 5.7, 6.3),
            new JumpResult("Агапова", 5.9, 6.2)
        };

        ShellSort(results);

        Console.WriteLine("{0,-15} {1,10}", "Фамилия", "Итого");
        Console.WriteLine(new string('-', 25));

        foreach (var result in results)
        {
            Console.WriteLine(result);
        }
    }

    static void ShellSort(JumpResult[] arr)
    {
        int gap = arr.Length / 2;  // устанавливаю начальное значение переменной gap как половина длины массива arr
        while (gap > 0)
        {
            //Прохожу по элементам массива arr начиная с индекса gap
            for (int i = gap; i < arr.Length; i++)
            {
                //Сохраняю текущий элемент массива во временной переменной temp
                JumpResult temp = arr[i];

              // устанавливаю индекс j равным текущему индексу i
                int j = i;
                //Пока j >= gap и значение TotalResult элемента массива arr[j - gap] меньше значения TotalResult временной переменной temp
                //Перемещаю элемент arr[j - gap] на позицию j
                while (j >= gap && arr[j - gap].TotalResult < temp.TotalResult)
                {
                    arr[j] = arr[j - gap];
                    //Уменьшаю j на величину gap
                 j -= gap;
                }
                //Помещаю временную переменную temp на позицию j
                arr[j] = temp;
            }
            //Уменьшаю значение переменной gap вдвое
            gap /= 2;
        }
    }
}
*/

# region 2.7
/*
using System;

class Program
{
    static void Main()
    {
        Player[] players = new Player[5];

        players[0] = new Player("Чичинкова", 1);
        players[1] = new Player("Бычкова", 0.5);
        players[2] = new Player("Куулар", 0);
        players[3] = new Player("Агапова", 1);
        players[4] = new Player("Чайкина", 0.5);

        Array.Sort(players, (x, y) => y.Score.CompareTo(x.Score));

        Console.WriteLine("Турнирная таблица:");
        foreach (var player in players)
        {
            Console.WriteLine($"{player.Name} - {player.Score} очка");
        }
    }
} 

public struct Player
{
    private string _name;
    private double _score;

    public Player(string name, double score)
    {
        _name = name;
        _score = score;
    }

    public string Name { get { return _name; } }
    public double Score { get { return _score; } }
}
*/

# region 3.4
/*
using System;

public struct Result
{
    private string lastName;
    private int finishTime;

    public Result(string lastName, int finishTime)
    {
        this.lastName = lastName;
        this.finishTime = finishTime;
    }

    public string GetLastName()
    {
        return lastName;
    }

    public int GetFinishTime()
    {
        return finishTime;
    }
}

public class SkiRace
{
    private Result[] group1Results;
    private Result[] group2Results;

    public SkiRace()
    {
        group1Results = new Result[]
        {
            new Result("Чиченкова", 60),
            new Result("Агапова", 55),
            new Result("Чайкина", 58),
            new Result("Абраменкова", 57),
            new Result("Бычкова", 62)
        };

        group2Results = new Result[]
        {
            new Result("Куулар", 63),
            new Result("Лунин", 56),
            new Result("Щербаков", 59),
            new Result("Родина", 61),
            new Result("Лищенко", 58)
        };
    }

    private void SortResults(ref Result[] results)
    {
        Array.Sort(results, (r1, r2) => r1.GetFinishTime().CompareTo(r2.GetFinishTime()));
    }

    public void MergeAndPrintResults()
    {
        SortResults(ref group1Results);
        SortResults(ref group2Results);

        Result[] mergedResults = new Result[group1Results.Length + group2Results.Length];
        Array.Copy(group1Results, mergedResults, group1Results.Length);
        Array.Copy(group2Results, 0, mergedResults, group1Results.Length, group2Results.Length);
        SortResults(ref mergedResults);

        Console.WriteLine("Результаты соревнований");
        Console.WriteLine("{0,-15} {1,-15} {2,-15}", "Фамилия", "Время", "Группа");
        foreach (var result in mergedResults)
        {
            string group = Array.IndexOf(group1Results, result) != -1 ? "1" : "2";   //для нахождения индекса элемента в массиве
            Console.WriteLine("{0,-15} {1,-15} {2,-15}", result.GetLastName(), result.GetFinishTime(), group);
        }
    }
}

class Program
{
    static void Main()
    {
        SkiRace skiRace = new SkiRace();
        skiRace.MergeAndPrintResults();
    }
}
*/
