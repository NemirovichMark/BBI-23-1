//using System;

//struct WomenRunners
//{
//    private string surname;
//    private string group;
//    private string surnameTeacher;
//    private double rez;
//    public string standart;

//    public string Surname => surname;
//    public string Group => group;
//    public string SurnameTeacher => surnameTeacher;
//    public double Rez => rez;
//    public string Standart => standart;

//    public WomenRunners(string surname, string surnameTeacher, string group, double rez, string standart)
//    {
//        this.surname = surname;
//        this.surnameTeacher = surnameTeacher;
//        this.group = group;
//        this.rez = rez;
//        this.standart = standart;
//    }

//}

//class Program1
//{
//    static void Main()
//    {
//        int c = 0;
//        WomenRunners[] wr = new WomenRunners[5];
//        wr[0] = new WomenRunners("Губеева", "Тренеровна ", "234", 1.50, "Не сдан");
//        wr[1] = new WomenRunners("Капелина","Гасанов", "666", 1.55, "Не сдан");
//        wr[2] = new WomenRunners("Попова", "Кужель", "777", 1.47, "Не сдан");
//        wr[3] = new WomenRunners("Орлова", "Лушина", "889", 1.46, "Не сдан");
//        wr[4] = new WomenRunners("Коцарь", "Пушина", "995", 1.54, "Не сдан");


//        for (int i = 0; i < wr.Length - 1; i++)
//        {
//            double amax = wr[i].Rez;
//            int imax = i;
//            for (int j = i + 1; j < wr.Length; j++)
//            {
//                if (wr[j].Rez > amax)
//                {
//                    amax = wr[j].Rez;
//                    imax = j;
//                }
//            }
//            WomenRunners temp;
//            temp = wr[imax];
//            wr[imax] = wr[i];
//            wr[i] = temp;
//        }
//        for (int i = 0; i < wr.Length; i++)
//        {
//            if (wr[i].Rez <= 1.5)
//            {
//                wr[i].standart = "Сдан";
//                c++;
//            }
//        }
//        Console.WriteLine();
//        for (int i = 0; i < wr.Length; i++)
//        {
//            Console.WriteLine("Фамилия: {0} \t Группа: {1} \t Тренер: {2} \t Результат: {3} \t Норматив (1.5 секунды): {4}", wr[i].Surname, wr[i].Group, wr[i].SurnameTeacher, wr[i].Rez, wr[i].standart);
//        }
//        Console.WriteLine("Человек сдало норматив: " + c);
//    }
//}







/*using System;

class Program
{
    struct People
    {
        private string surname;
        private string name;
        private int time;

        public string Surname => surname;
        public string Name => name;

        public int Time => time;

        public People(string surname, string name, int time)
        {

            this.surname = surname;
            this.name = name;
            this.time = time;
        }
    }
    static void Main()
    {
        int c = 0;
        People[] set = new People[30];
        set[0] = new People("Акинов", "Ваня", 2);
        set[1] = new People("Кольцов", "Даня", 5);
        set[2] = new People("Носов", "Миша", 10);
        set[3] = new People("Осипов", "Паша", 5);
        set[4] = new People("Кузьмин", "Саша", 2);
        set[5] = new People("Пугачев", "Ваня", 10);
        set[6] = new People("Киркоров", "Даня", 2);
        set[7] = new People("Эминем", "Миша", 5);
        set[8] = new People("Иванов", "Паша", 2);
        set[9] = new People(" Петров", "Саша", 2);
        set[10] = new People("Cидаров", "Ваня", 2);
        set[11] = new People("Михайлов", "Даня", 2);
        set[12] = new People("Козлов", "Ваня", 2);
        set[15] = new People("Огнезов", "Саша", 2);
        set[16] = new People("Попов", "Ваня", 2);
        set[17] = new People("Третьяков", "Даня", 10);
        set[18] = new People("Черкасов", "Миша", 2);
        set[13] = new People("Воробьев", "Паша", 2);
        set[14] = new People("Таранов", "Миша", 2);
        set[19] = new People("Князев", "Паша", 2);
        set[20] = new People("Ногинов", "Саша", 2);
        set[21] = new People("Казанцев", "Ваня", 10);
        set[22] = new People("Лунин", "Ван", 2);
        set[23] = new People("Стоценко", "Даня", 10);
        set[24] = new People("Глазков", "Паша", 10);
        set[25] = new People("Подвальников", "Ваня", 5);
        set[26] = new People("Ежков", "Сережа", 10);
        set[27] = new People("Туренко", "Даня", 2);
        set[28] = new People("Мухин", "Ваня", 2);
        set[29] = new People("Григорян", "Даня", 10);

        Array.Sort(set, (x, y) => x.Time.CompareTo(y.Time));

        for (int i = 0; i < set.Length; i++)
        {
            if (set[i].Time < 10)


            {
                Console.WriteLine("Фамилия: {0} \t  Имя: {1} \t Время: {2}", set[i].Surname, set[i].Name, set[i].Time);
            }
        }
    }

}*/


//проведения первого этапа участники разбиваются на две группы по 12 команд.
//Для проведения второго этапа выбирается 6 лучших команд каждой группы по
//результатам первого этапа. Составить список команд участников второго этапа.
/*using System;

struct Teams
{
    private string team;
    private int result;

    public string Team => team;
    public int Result => result;

    public Teams(string team, int result)
    {
        this.team = team;
        this.result = result;
    }
}
class Program
{
    static void Main()
    {
        string[] array = new string[12];
        int c = 0;
        Teams[] first = new Teams[12];
        first[0] = new Teams("A", 88);
        first[1] = new Teams("D", 77);
        first[2] = new Teams("C", 90);
        first[3] = new Teams("V", 89);
        first[4] = new Teams("N", 20);
        first[5] = new Teams("F", 66);
        first[6] = new Teams("Y", 10);
        first[7] = new Teams("B", 35);
        first[8] = new Teams("z", 26);
        first[9] = new Teams("W", 57);
        first[10] = new Teams("X", 71);
        first[11] = new Teams("Q", 16);

        Array.Sort(first, (x, y) => y.Result.CompareTo(x.Result));
        for (int i = 0; i < 6; i++)
        {
            array[i] = first[i].Team;
        }
        Teams[] second = new Teams[12];
        second[0] = new Teams("A1", 56);
        second[1] = new Teams("D1", 66);
        second[2] = new Teams("C1", 11);
        second[3] = new Teams("V1", 12);
        second[4] = new Teams("N1", 13);
        second[5] = new Teams("F1", 41);
        second[6] = new Teams("Y1", 51);
        second[7] = new Teams("B1", 61);
        second[8] = new Teams("Z1", 81);
        second[9] = new Teams("W1", 80);
        second[10] = new Teams("X1", 19);
        second[11] = new Teams("Q1", 15);

        Array.Sort(second, (x, y) => y.Result.CompareTo(x.Result));
        for (int i = 0; i < 6; i++)
        {
            array[i + 6] = second[i].Team;
        }
        foreach (var elem in array)
        {
            Console.WriteLine($" Название команды, которая прошла:{elem}");
        }
    }
}*/
