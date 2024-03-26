using System;

struct Student
{
    private string name1;
    private int mathGrade1;
    private int physicGrade1;
    private int russianGrade1;

    public string Name => name1;
    public int MathGrade => mathGrade1;
    public int PhysicGrade => physicGrade1;
    public int RussianGrade => russianGrade1;

    public Student(string name, int mathGrade, int physicGrade, int russianGrade)
    {
        name1 = name;
        mathGrade1 = mathGrade;
        physicGrade1 = physicGrade;
        russianGrade1 = russianGrade;
    }

    public double AverageGrade()
    {
        return (mathGrade1 + physicGrade1 + russianGrade1) / 3.0;
    }

    public void Print()
    {
        Console.WriteLine(" {0:d} \t Средняя оценка: {1:f2}", name1, AverageGrade());
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student[] stu = new Student[8];
        stu[0] = new Student("Amina", 5, 4, 5);
        stu[1] = new Student("Sasha", 4, 5, 4);
        stu[2] = new Student("Kirill", 3, 4, 4);
        stu[3] = new Student("Daria", 4, 3, 4);
        stu[4] = new Student("Rosa", 3, 5, 4);
        stu[5] = new Student("Egor", 5, 4, 5);
        stu[6] = new Student("Nikita", 4, 2, 3);
        stu[7] = new Student("Roma", 4, 2, 4);
        

        for (int i = 0; i < stu.Length - 1; i++)
        {
            double maxAvgGrade = stu[i].AverageGrade();
            int maxIndex = i;
            for (int j = i + 1; j < stu.Length; j++)
            {
                if (stu[j].AverageGrade() > maxAvgGrade &&
                    stu[j].MathGrade != 2 && stu[j].PhysicGrade != 2 && stu[j].RussianGrade != 2)
                {
                    maxAvgGrade = stu[j].AverageGrade();
                    maxIndex = j;
                }
            }
            Student temp = stu[maxIndex];
            stu[maxIndex] = stu[i];
            stu[i] = temp;
        }

        Console.WriteLine("Успешно сдавшие экзамены:");
        for (int i = 0; i < stu.Length; i++)
        {
            if (stu[i].MathGrade != 2 && stu[i].PhysicGrade != 2 && stu[i].RussianGrade != 2)
            {
                stu[i].Print();
            }
        }

        Console.ReadKey();
    }
}