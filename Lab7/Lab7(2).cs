using System;
// Создание абстрактного класса Diving
abstract class Diving
{
    // Защищенное поле disciplineName
    protected string disciplineName;

    // Абстрактное свойство DisciplineName
    public abstract string DisciplineName { get; }

    // Конструктор класса Diving
    public Diving(string disciplineName)
    {
        this.disciplineName = disciplineName;
    }

    // Абстрактный метод PrintDisciplineInfo
    public abstract void PrintDisciplineInfo();
}

// Класс DivingWith3M наследует класс Diving
class DivingWith3M : Diving
{
    // Переопределенное свойство DisciplineName
    public override string DisciplineName => "Прыжки в воду с 3 метровой вышки";

    // Конструктор класса DivingWith3M
    public DivingWith3M(string disciplineName) : base(disciplineName) { }

    // Переопределенный метод PrintDisciplineInfo
    public override void PrintDisciplineInfo()
    {
        Console.WriteLine($"Дисциплина: {DisciplineName}");
    }
}

// Класс DivingWith5M наследует класс Diving
class DivingWith5M : Diving
{
    // Переопределенное свойство DisciplineName
    public override string DisciplineName => "Прыжки в воду с 5 метровой вышки";

    // Конструктор класса DivingWith5M
    public DivingWith5M(string disciplineName) : base(disciplineName) { }

    // Переопределенный метод PrintDisciplineInfo
    public override void PrintDisciplineInfo()
    {
        Console.WriteLine($"Дисциплина: {DisciplineName}");
    }
}

// Основной класс программы
class Program
{
    // Структура Person
    struct Person
    {
        // Приватные поля surname, refs и diving
        private string surname;
        private int[] refs;
        private Diving diving;
        private int finalResult;

        // Публичные свойства Surname, Refs и Diving
        public string Surname => surname;
        public int[] Refs => refs;
        public Diving Diving => diving;

        // Конструктор структуры Person
        public Person(string surname, int[] refs, Diving diving)
        {
            this.surname = surname;
            this.refs = refs;
            this.diving = diving;
        }

        // Метод CalculateFinalResult для вычисления суммарного результата
        public int CalculateFinalResult()
        {
            int sum = 0;
            foreach (int reference in refs)
            {
                sum += reference;
            }
            return sum;
        }
        public void CalculateAndSaveFinalResult()
        {
            finalResult = CalculateFinalResult();
        }
        public int GetFinalResult()
        {
            return finalResult;
        }

        // Метод PrintInfo для вывода информации о спортсмене
        public void PrintInfo()
        {
            Console.WriteLine($"Фамилия: {Surname} Результат: {CalculateFinalResult()}");
            diving.PrintDisciplineInfo();
        }

        // Сортировка слиянием массива результатов спортсменов
        public static void MergeSort(Person[] arr, int left, int right)
        {
            // Проверяем базовый случай: если левая граница меньше правой, то массив еще не отсортирован
            if (left < right)
            {
                // Находим средний индекс массива
                int middle = (left + right) / 2;

                // Рекурсивно вызываем MergeSort для левой половины массива
                MergeSort(arr, left, middle);
                // Рекурсивно вызываем MergeSort для правой половины массива
                MergeSort(arr, middle + 1, right);

                // Объединяем отсортированные левую и правую половины массива
                Merge(arr, left, middle, right);
            }
        }

        // Объединение двух сортированных частей массива
        private static void Merge(Person[] arr, int left, int middle, int right)
        {
            // Определяем размеры временных массивов для левой и правой частей
            int n1 = middle - left + 1;
            int n2 = right - middle;

            // Создаем временные массивы для левой и правой частей
            Person[] L = new Person[n1];
            Person[] R = new Person[n2];

            // Копируем элементы из основного массива во временные массивы
            for (int i = 0; i < n1; ++i)
            {
                L[i] = arr[left + i];
            }
            for (int j = 0; j < n2; ++j)
            {
                R[j] = arr[middle + 1 + j];
            }

            // Индексы временных массивов и основного массива
            int iLeft = 0, iRight = 0;
            int k = left;

            // Слияние временных массивов обратно в основной массив
            while (iLeft < n1 && iRight < n2)
            {
                // Сравниваем результаты спортсменов и помещаем их в основной массив в правильном порядке
                if (L[iLeft].CalculateFinalResult() >= R[iRight].CalculateFinalResult())
                {
                    arr[k] = L[iLeft];
                    iLeft++;
                }
                else
                {
                    arr[k] = R[iRight];
                    iRight++;
                }
                k++;
            }

            // Копируем оставшиеся элементы из временного массива L (если они есть)
            while (iLeft < n1)
            {
                arr[k] = L[iLeft];
                iLeft++;
                k++;
            }

            // Копируем оставшиеся элементы из временного массива R (если они есть)
            while (iRight < n2)
            {
                arr[k] = R[iRight];
                iRight++;
                k++;
            }
        }
    }
    // Главный метод программы
    static void Main()
    {
        // Создание объектов для спортсменов с присвоением атрибутов прыжков в воду
        Diving diving1 = new DivingWith3M("Дисциплина 1");
        Diving diving2 = new DivingWith5M("Дисциплина 2");
        Diving diving3 = new DivingWith3M("Дисциплина 3");
        Diving diving4 = new DivingWith5M("Дисциплина 4");
        Diving diving5 = new DivingWith3M("Дисциплина 5");

        // Создание массива спортсменов
        Person[] sportik = new Person[5];
        sportik[0] = new Person("Oganezov", new int[] { 4, 5, 2, 3, 4, 3, 4, 4, 5, 5 }, diving1);
        sportik[1] = new Person("Popov", new int[] { 3, 5, 1, 4, 2, 5, 3, 3, 2, 2 }, diving2);
        sportik[2] = new Person("Machkalyan", new int[] { 1, 2, 1, 1, 3, 3, 4, 4, 2, 4 }, diving3);
        sportik[3] = new Person("Gubeeva", new int[] { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 }, diving4);
        sportik[4] = new Person("Kapelina", new int[] { 4, 5, 5, 4, 4, 5, 5, 4, 4, 5 }, diving5);

        foreach (var person in sportik)
        {
            person.CalculateAndSaveFinalResult();
        }

        // Сортировка массива спортсменов по убыванию результатов
        Person.MergeSort(sportik, 0, sportik.Length - 1);

        // Вывод информации о спортсменах
        for (int i = 0; i < sportik.Length; i++)
        {
            sportik[i].PrintInfo();
        }
    }
}
