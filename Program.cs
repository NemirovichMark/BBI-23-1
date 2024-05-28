// Создайте структуру Profession с полями для сферы (медицина макетинг IT и тд), уникального УИД, размер заработной платы, описание(не менее 20 и не более 50 символов).Реализуйте метод вывода информации о профессии.Реализуйте метод для изменения описания професии. В конструктор передавать все поля крое УИД, В основной программе создайте имассив из 5 профессий Измините описание самой прибыльной професии. Отсортируйте их по убыванию размера зп и выведите их в консоль
class Profession
{
    protected string _sphere;
    protected Guid _uid;
    protected decimal _salary;
    public string Description;

    public Profession(string sphere, decimal salary, string description)
    {
        _salary= salary;
        _sphere= sphere;
        _uid= Guid.NewGuid();

        if (description.Length >= 20 && description.Length <= 50)
            Description = description;
        else
            Console.WriteLine("Описание должно быть от 20 до 50 символов"); 
    }


    public string Sphere { get { return _sphere;} }
    public decimal Salary { get { return _salary;} }
    public void ChangeDescription(string newDescription)
    {
        if (newDescription.Length >= 20 && newDescription.Length <= 50)
            
            Description = newDescription;
        else
            Console.WriteLine("Описание должно быть от 20 до 50 символов"); 
    }
    public  void Print()
    {
        Console.WriteLine($"Sphere: {_sphere}, UUID: {_uid}, Salary: {_salary}, Description: {Description}"); 
    }
}

class Program
{
    static void Main(string[] args)
    {
        var professions = new Profession[]
        {
            new Profession("Медицина",  1000000, "Врач уйу ао фыв  ыфв  ше  фыдыф вжд "),
            new Profession("Макетинг", 800000, "Дизайнер вф qweeqывф ыфцйу кйцу йw"),
            new Profession("IT", 1200000, "Программист eeeeeзщфызвщфзыщвфывлwada"),
            new Profession("Финансы", 1500000, "Аналитик яeчсииавп awdwa dad wad ad "),
            new Profession("Право", 900000, "Юрист 7912739187329218390 dawda w wadwa")
        };

        
        
        Sort(professions);
        professions[0].ChangeDescription("Эксперт в своей области просто класс 1");
    
        foreach (var profession in professions)
        {
            profession.Print();
        }
        static void Sort(Profession[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j].Salary < array[j + 1].Salary)
                    {
                        
                        Profession temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }
}