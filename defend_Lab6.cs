//
using System;

struct WomenRunner
{
    private string surname;
    private string group;
    private string surnameTeacher;
    private double rez;
    public string standart;


    public double Rez => rez;

    public WomenRunner(string surname, string surnameTeacher, string group, double rez, string standart)
    {
        this.surname = surname;
        this.surnameTeacher = surnameTeacher;
        this.group = group;
        this.rez = rez;
        this.standart = standart;
    }

    public void PrintInfo()
    {
        Console.WriteLine("Фамилия: {0} \t Группа: {1} \t Тренер: {2} \t Результат: {3} \t Норматив (1.5 секунды): {4}",
            this.surname, this.group, this.surnameTeacher, this.rez, this.standart);
    }
}

class Program
{
    static void InsertionSort(WomenRunner[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            WomenRunner key = array[i]; // для индекса переменных 
            int j = i - 1; // индекс предыдущего элемента 
            while (j >= 0 && array[j].Rez < key.Rez)// если индекс рез меньше кей то сдвигаем элемет array[j] вправа 
            {
                array[j + 1] = array[j];
                // уменьшаем значение j и продолжаем сдвигать и проверять 
                j = j - 1;
            }
            array[j + 1] = key;// послеи  завершения элемент кей встает на правильную позицию
        }
    }

    static void Main()
    {
        int passedCount = 0;

        WomenRunner[] womenRunners = new WomenRunner[5];
        womenRunners[0] = new WomenRunner("Губеева", "Тренеровна", "234", 1.50, "Не сдан");
        womenRunners[1] = new WomenRunner("Капелина", "Гасанов", "666", 1.55, "Не сдан");
        womenRunners[2] = new WomenRunner("Попова", "Кужель", "777", 1.47, "Не сдан");
        womenRunners[3] = new WomenRunner("Орлова", "Лушина", "889", 1.46, "Не сдан");
        womenRunners[4] = new WomenRunner("Коцарь", "Пушина", "995", 1.54, "Не сдан");

        InsertionSort(womenRunners);

        for (int i = 0; i < womenRunners.Length; i++)
        {
            var runner = womenRunners[i];
            if (runner.Rez <= 1.5)
            {
                passedCount++;
                runner.standart = "Сдан";
            }
            runner.PrintInfo();
        }

        Console.WriteLine("Человек сдало норматив: " + passedCount);
    }
}

//using System;

//// Определение структуры People
//struct People
//{
//    private string surname; // Фамилия
//    private string name;    // Имя
//    private int time;       // Время

//    // Свойство только для чтения, возвращает время
//    public int Time => time;

//    // Конструктор, инициализирующий поля структуры
//    public People(string surname, string name, int time)
//    {
//        this.surname = surname;
//        this.name = name;
//        this.time = time;
//    }

//    // Метод для печати информации о человеке
//    public void PrintInfo()
//    {
//        Console.WriteLine("Фамилия: {0} \t Имя: {1} \t Время: {2}", this.surname, this.name, this.time);
//    }
//}

//// Определение класса Program
//class Program
//{
//    // Метод сортировки вставками
//    static void InsertionSort(People[] array)
//    {
//        for (int i = 1; i < array.Length; i++)
//        {
//            People key = array[i];
//            int j = i - 1;
//            // Пока не достигнут конец массива и текущий элемент больше ключа,
//            // сдвигаем элементы вправо
//            while (j >= 0 && array[j].Time > key.Time)
//            {
//                array[j + 1] = array[j];
//                j = j - 1;
//            }
//            array[j + 1] = key; // Вставляем ключ в правильную позицию
//        }
//    }

//    // Главный метод программы
//    static void Main()
//    {
//        // Создание массива объектов типа People
//        People[] set = new People[30];

//        // Инициализация объектов типа People с данными
//        // Фамилия, Имя, Время
//        set[0] = new People("Акинов", "Ваня", 2);
//        set[1] = new People("Кольцов", "Даня", 5);
//        set[2] = new People("Носов", "Миша", 10);
//        set[3] = new People("Осипов", "Паша", 5);
//        set[4] = new People("Кузьмин", "Саша", 2);
//        set[5] = new People("Пугачев", "Ваня", 10);
//        set[6] = new People("Киркоров", "Даня", 2);
//        set[7] = new People("Эминем", "Миша", 5);
//        set[8] = new People("Иванов", "Паша", 2);
//        set[9] = new People("Петров", "Саша", 2);
//        set[10] = new People("Сидаров", "Ваня", 2);
//        set[11] = new People("Михайлов", "Даня", 2);
//        set[12] = new People("Козлов", "Ваня", 2);
//        set[13] = new People("Воробьев", "Паша", 2);
//        set[14] = new People("Таранов", "Миша", 2);
//        set[15] = new People("Огнезов", "Саша", 2);
//        set[16] = new People("Попов", "Ваня", 2);
//        set[17] = new People("Третьяков", "Даня", 10);
//        set[18] = new People("Черкасов", "Миша", 2);
//        set[19] = new People("Князев", "Паша", 2);
//        set[20] = new People("Ногинов", "Саша", 2);
//        set[21] = new People("Казанцев", "Ваня", 10);
//        set[22] = new People("Лунин", "Ван", 2);
//        set[23] = new People("Стоценко", "Даня", 10);
//        set[24] = new People("Глазков", "Паша", 10);
//        set[25] = new People("Подвальников", "Ваня", 5);
//        set[26] = new People("Ежков", "Сережа", 10);
//        set[27] = new People("Туренко", "Даня", 2);
//        set[28] = new People("Мухин", "Ваня", 2);
//        set[29] = new People("Григорян", "Даня", 10);

//        // Вызов метода сортировки вставками
//        InsertionSort(set);

//        // Перебор всех элементов массива
//        foreach (var person in set)
//        {
//            // Если время меньше 10, печатаем информацию о человеке
//            if (person.Time < 10)
//            {
//                person.PrintInfo();
//            }
//        }
//    }
//}

//using System.Collections.Generic;

//// Создание структуры Teams для представления команды с ее названием и результатом
//struct Teams
//{
//    private string team; // Название команды
//    private int result; // Результат

//    // Публичное свойство для доступа к названию команды
//    public string Team => team;

//    // Публичное свойство для доступа к результату
//    public int Result => result;

//    // Конструктор для инициализации названия команды и результата
//    public Teams(string team, int result)
//    {
//        this.team = team; // Присваивание значения названию команды
//        this.result = result; // Присваивание значения результату
//    }
//}

//class Program
//{
//    // Метод сортировки массива объектов Teams методом вставок
//    static void InsertionSort(Teams[] teams)
//    {
//        for (int i = 1; i < teams.Length; i++)
//        {
//            Teams key = teams[i];
//            int j = i - 1;

//            // Сдвигаем элементы массива, большие чем key, на одну позицию вперед
//            while (j >= 0 && teams[j].Result < key.Result)
//            {
//                teams[j + 1] = teams[j];
//                j = j - 1;
//            }
//            teams[j + 1] = key;
//        }
//    }
//    static void Main()
//    {
//        // Создание массива для хранения названий команд, которые прошли
//        string[] array = new string[12];

//        // Создание массива объектов Teams для первой группы команд
//        Teams[] first = new Teams[12];
//        // Инициализация объектов Teams для первой группы команд
//        first[0] = new Teams("A", 88);
//        first[1] = new Teams("D", 77);
//        first[2] = new Teams("C", 90);
//        first[3] = new Teams("V", 89);
//        first[4] = new Teams("N", 20);
//        first[5] = new Teams("F", 66);
//        first[6] = new Teams("Y", 10);
//        first[7] = new Teams("B", 35);
//        first[8] = new Teams("z", 26);
//        first[9] = new Teams("W", 57);
//        first[10] = new Teams("X", 71);
//        first[11] = new Teams("Q", 16);

//        // Сортировка первого массива по убыванию результатов
//        InsertionSort(first);

//        // Запись названий топ-6 команд первой группы в массив array
//        for (int i = 0; i < 6; i++)
//        {
//            array[i] = first[i].Team;
//        }

//        // Создание массива объектов Teams для второй группы команд
//        Teams[] second = new Teams[12];
//        // Инициализация объектов Teams для второй группы команд
//        second[0] = new Teams("A1", 56);
//        second[1] = new Teams("D1", 66);
//        second[2] = new Teams("C1", 11);
//        second[3] = new Teams("V1", 12);
//        second[4] = new Teams("N1", 13);
//        second[5] = new Teams("F1", 41);
//        second[6] = new Teams("Y1", 51);
//        second[7] = new Teams("B1", 61);
//        second[8] = new Teams("Z1", 81);
//        second[9] = new Teams("W1", 80);
//        second[10] = new Teams("X1", 19);
//        second[11] = new Teams("Q1", 15);

//        // Сортировка второго массива по убыванию результатов
//        InsertionSort(second);

//        // Запись названий топ-6 команд второй группы в массив array, начиная с индекса 6
//        for (int i = 0; i < 6; i++)
//        {
//            array[i + 6] = second[i].Team;
//        }

//        // Вывод названий команд, которые прошли, на экран
//        foreach (var elem in array)
//        {
//            Console.WriteLine($"Название команды, которая прошла: {elem}");
//        }
//    }
//}
