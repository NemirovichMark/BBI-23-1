/*оценки по информатике, а также определено количество пропущенных занятий.
Успеваемость каждого студента оценивается следующими баллами: «0»
(неаттестован), «2», «3», «4» или «5». Вывести список неуспевающих (оценка «2»)
студентов в порядке убывания количества пропущенных ими занятий.*/
using System;

struct Student
{
    private string name;
    private int mark;
    private int miss;

    public string Name => name;
    public int Mark => mark;
    public int Miss => miss;

    public Student(string name, int mark, int miss)
    {
        this.name = name;
        this.miss = miss;
        if (mark != 1 & mark >= 0 & mark <= 5)
        {
            this.mark = mark;
        }
    }
}

class Program
{
    
    static void Main()
    {
        Student[] human = new Student[5];
        human[0] = new Student("Misha", 2, 3);
        human[1] = new Student("Pasha", 2, 9);
        human[2] = new Student("Tigran", 2, 6);
        human[3] = new Student("Sofia", 5, 1);
        human[4] = new Student("Ivan", 0, 20);

        Array.Sort(human, (x, y) => y.Miss.CompareTo(x.Miss));
        for (int i = 0; i < human.Length; i++)
        {
            if (human[i].Mark == 2)
            {
                Console.WriteLine($"Имя: {human[i].Name} Кол-во пропусков: {human[i].Miss}");
            }
        }
    }
}