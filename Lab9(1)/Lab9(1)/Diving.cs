using ProtoBuf;
using System;
using System.Xml.Serialization;
[XmlInclude(typeof(DivingWith3M))]
[XmlInclude(typeof(DivingWith5M))]
[ProtoInclude(999, typeof(DivingWith3M))]
[ProtoInclude(998, typeof(DivingWith5M))]


// Создание абстрактного класса Diving
[Serializable]
[ProtoContract]
public abstract class Diving
{
    // Защищенное поле disciplineName
    protected string disciplineName;

    // Абстрактное свойство DisciplineName
    [XmlElement(ElementName = "DisciplineName")]
    [ProtoMember(1)]
    public abstract string DisciplineName { get;  set; }

    // Конструктор класса Diving
    public Diving() { }
    public Diving(string disciplineName)
    {
        this.disciplineName = disciplineName;
    }

    // Абстрактный метод PrintDisciplineInfo
    public abstract void PrintDisciplineInfo();
}

// Класс DivingWith3M наследует класс Diving
[Serializable]
[ProtoContract]
public class DivingWith3M : Diving
{
    // Переопределенное свойство DisciplineName
    public override string DisciplineName { get { return disciplineName; }  set { disciplineName = "Прыжки в воду с 3 метровой вышки"; } }

    // Конструктор класса DivingWith3M
    public DivingWith3M() { }
    public DivingWith3M(string disciplineName) : base(disciplineName) { }

    // Переопределенный метод PrintDisciplineInfo
    public override void PrintDisciplineInfo()
    {
        Console.WriteLine($"Дисциплина: {DisciplineName}");
    }
}

// Класс DivingWith5M наследует класс Diving
[Serializable]
[ProtoContract]
public class DivingWith5M : Diving
{
    // Переопределенное свойство DisciplineName
    public override string DisciplineName { get { return disciplineName; }  set { disciplineName = "Прыжки в воду с 5 метровой вышки"; } }

    // Конструктор класса DivingWith5M
    public DivingWith5M() { }
    public DivingWith5M(string disciplineName) : base(disciplineName) { }

    // Переопределенный метод PrintDisciplineInfo
    public override void PrintDisciplineInfo()
    {
        Console.WriteLine($"Дисциплина: {DisciplineName}");
    }
}

// Структура Person
[Serializable]
[ProtoContract]
public struct Person
{
    // Приватные поля surname, refs и diving
    private string surname;
    private int[] refs;
    private Diving diving;
    private int finalResult = 0;

    // Публичные свойства Surname, Refs и Diving
    [XmlElement(ElementName = "SurName")]
    [ProtoMember(1)]
    public string Surname { get { return surname; } set { surname = value; } }

    [XmlElement(ElementName = "Refs")]
    [ProtoMember(2)]
    public int[] Refs { get { return refs; } set { refs = value; } }

    [XmlElement(ElementName = "Diving")]
    [ProtoMember(3)]
    public Diving Diving { get { return diving; } set { diving = value; } }

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

// Основной класс программы
class Program
{
    // Главный метод программы
    static void Main()
    {
        // Создание объектов для спортсменов с присвоением атрибутов прыжков в воду
        Diving diving1 = new DivingWith3M("Дисциплина 1");
        Diving diving2 = new DivingWith5M("Дисциплина 2");
        Diving diving3 = new DivingWith3M("Дисциплина 3");
        Diving diving4 = new DivingWith5M("Дисциплина 4");
        Diving diving5 = new DivingWith3M("Дисциплина 5");

        // Создание списка спортсменов
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

        List<Person> sportikList = sportik.ToList();

        Stream file = File.Create(@"data\sportik.json");
        Stream data = JSONProcessing<Person>.Write(sportikList);
        data.CopyTo(file);
        file.Dispose();

        file = File.Create(@"data\sportik.xml");
        data = XMLProcessing<Person>.Write(sportikList);
        data.CopyTo(file);
        file.Dispose();

        file = File.Create(@"data\sportik.bin");
        data = BinProcessing<Person>.Write(sportikList);
        data.CopyTo(file);
        file.Dispose();

        sportikList = JSONProcessing<Person>.Read(new FileStream(@"data\sportik.json", FileMode.Open));
        Console.WriteLine("JSON файл:");
        for (int i = 0; i < sportikList.Count; i++)
        {
            sportikList[i].PrintInfo();
        }

        sportikList = XMLProcessing<Person>.Read(new FileStream(@"data\sportik.xml", FileMode.Open));
        Console.WriteLine("XML файл:");
        for (int i = 0; i < sportikList.Count; i++)
        {
            sportikList[i].PrintInfo();
        }

        sportikList = BinProcessing<Person>.Read(new FileStream(@"data\sportik.bin", FileMode.Open));
        Console.WriteLine("Bin файл:");
        for (int i = 0; i < sportikList.Count; i++)
        {
            sportikList[i].PrintInfo();
        }
    }
}
