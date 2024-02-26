/*Протокол соревнований по прыжкам в воду содержит список фамилий спортсменов
и баллы, выставленные 5 судьями по результатам 2 прыжков. Получить итоговый
протокол, содержащий фамилии и результаты, в порядке занятых спортсменами
мест по результатам 2 прыжков.*/
using System;
using Internal;

class Program
{
    struct Person
    {
        private string surname;
        private int ref1_1, ref1_2, ref2_1, ref2_2, ref3_1, ref3_2, ref4_1, ref4_2, ref5_1, ref5_2;

        public string Surname => surname;
        public int Ref1_1 => ref1_1;
        public int Ref1_2 => ref1_2;
        public int Ref2_1 => ref2_1;
        public int Ref2_2 => ref2_2;
        public int Ref3_1 => ref3_1;
        public int Ref3_2 => ref3_2;
        public int Ref4_1 => ref4_1;
        public int Ref4_2 => ref4_2;
        public int Ref5_1 => ref5_1;
        public int Ref5_2 => ref5_2;
        public int Final_result => ref1_1 + ref1_2 + ref2_1 + ref2_2 + ref3_1 + ref3_2 + ref4_1 + ref4_2 + ref5_1 + ref5_2;

        public Person(string surname, int ref1_1, int ref1_2, int ref2_1, int ref2_2, int ref3_1, int ref3_2, int ref4_1, int ref4_2, int ref5_1, int ref5_2)
        {
            this.surname = surname;
            this.ref1_1 = ref1_1;
            this.ref1_2 = ref1_2;
            this.ref2_1 = ref2_1;
            this.ref2_2 = ref2_2;
            this.ref3_1 = ref3_1;
            this.ref3_2 = ref3_2;
            this.ref4_1 = ref4_1;
            this.ref4_2 = ref4_2;
            this.ref5_1 = ref5_1;
            this.ref5_2 = ref5_2;
        }
    }
    static void Main()
    {
        Person[] sportik = new Person[5];
        sportik[0] = new Person("Oganezov", 4, 5, 2, 3, 4, 3, 4, 4, 5, 5);
        sportik[1] = new Person("Popov", 3, 5, 1, 4, 2, 5, 3, 3, 2, 2);
        sportik[2] = new Person("Machkalyan", 1, 2, 1, 1, 3, 3, 4, 4, 2, 4);
        sportik[3] = new Person("Gubeeva", 5, 5, 5, 5, 5, 5, 5, 5, 5, 5);
        sportik[4] = new Person("Kapelina", 4, 5, 5, 4, 4, 5, 5, 4, 4, 5);

        Array.Sort(sportik, (x, y) => y.Final_result.CompareTo(x.Final_result));
        for (int i = 0; i < sportik.Length; i++)
        {
            Console.WriteLine($"Фамилия: {sportik[i].Surname} Результат: {sportik[i].Final_result}");
        }
    }
}