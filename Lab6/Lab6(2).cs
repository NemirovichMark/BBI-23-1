/*Протокол соревнований по прыжкам в воду содержит список фамилий спортсменов
и баллы, выставленные 5 судьями по результатам 2 прыжков. Получить итоговый
протокол, содержащий фамилии и результаты, в порядке занятых спортсменами
мест по результатам 2 прыжков.*/
using System;

class Program
{
    struct Person
    {
        private string surname;
        private int result1, result2, result3, result4, result5;

        public string Surname => surname;
        public int Result1 => result1;
        public int Result2 => result2;
        public int Result3 => result3;
        public int Result4 => result4;
        public int Result5 => result5;
        public int Final_result => Result1 + Result2 + Result3 + Result4 + Result5;

        public Person(string surname, int result1, int result2, int result3, int result4, int result5)
        {
            this.surname = surname;
            this.result1 = result1;
            this.result2 = result2;
            this.result3 = result3;
            this.result4 = result4;
            this.result5 = result5;
        }
    }
    static void Main()
    {
        Person[] sportik = new Person[5];
        sportik[0] = new Person("Oganezov", 9, 5, 7, 8, 10);
        sportik[1] = new Person("Popov", 8, 5, 7, 6, 4);
        sportik[2] = new Person("Machkalyan", 3, 2, 6, 8, 6);
        sportik[3] = new Person("Gubeeva", 10, 10, 10, 10, 10);
        sportik[4] = new Person("Kapelina", 9, 9, 9, 9, 9);

        Array.Sort(sportik, (x, y) => y.Final_result.CompareTo(x.Final_result));
        for (int i = 0; i < sportik.Length; i++)
        {
            Console.WriteLine($"Фамилия: {sportik[i].Surname} Результат: {sportik[i].Final_result}");
        }
    }
}