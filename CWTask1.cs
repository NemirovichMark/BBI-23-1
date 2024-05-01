//   Создать структуру Disciple с полями для имени, возраста, массива оценок, среднего балла и статускраснодипломника.Сделайте метод для определени\, является ли студент краснодипломником: (средний балл выше выше 4.5).)
//  Сделайте метод для вывода информации об учащемся: имя, возраст, средний балли статус краснодипломник (для тех, у кого он есть. В конструктор передавать матрицу оценок 1 на 5. В основной программе создайте массив из 5 учащихся
//  отсортируйте по фамилии и выведите в виде таблицы. 3 ВАРИАНТ.

   using System;
struct Disciple
{
   public string Name;
   private int Age;
   private int[] Marks;
   private double AverageMark;
   private bool StatusRed;

   public Disciple(string name, int age, int[] marks)
   {
       Name = name;
       Age = age;
       Marks = marks;
       AverageMark = CalculateAverageMark(marks);
       StatusRed = AverageMark > 4.5;
   }

   private double CalculateAverageMark(int[] marks)
   {
       if (marks.Length == 0)
           return 0;

       double sum = 0;
       foreach (int grade in marks)
       {
           sum += grade;
       }

       return sum / marks.Length;
   }

   public void PrintInfo()
   {
       Console.WriteLine($"Имя: {Name}");
       Console.WriteLine($"Возраст: {Age}");
       Console.WriteLine($"Средний балл: {AverageMark}");

       if (StatusRed)
       {
           Console.WriteLine("Статус краснодипломника: Да");
       }
       else
       {
           Console.WriteLine("Статус краснодипломника: Нет");
       }
   }
}

class Program
{
   static void Main()
   {
       Disciple[] students = new Disciple[5];
       students[0] = new Disciple("Чиченкова", 20, new int[] { 5, 4, 5, 5, 4 });
       students[1] = new Disciple("Родина", 22, new int[] { 4, 3, 4, 5, 4 });
       students[2] = new Disciple("Словогородская", 21, new int[] { 5, 5, 5, 5, 5 });
       students[3] = new Disciple("Бычкова", 19, new int[] { 3, 4, 3, 4, 5 });
       students[4] = new Disciple("Виноградов", 23, new int[] { 4, 5, 4, 5, 4 });

       for (int i = 0; i < students.Length - 1; i++)
       {
           for (int j = 0; j < students.Length - i - 1; j++)
           {
               if (string.Compare(students[j].Name, students[j + 1].Name) > 0)
               {
                   Disciple temp = students[j];
                   students[j] = students[j + 1];
                   students[j + 1] = temp;
               }
           }
       }

       Console.WriteLine("Имя\tВозраст\tСредний балл\tКраснодипломник");
       foreach (Disciple student in students)
       {
           student.PrintInfo();
           Console.WriteLine("--------------------------------------");
       }

       Console.ReadLine();
   }
} 
