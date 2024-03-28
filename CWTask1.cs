using System;

// Создни структуры // Номер 1 // 
public struct Contact
{
    private int uniqueOrderNumber;
    private string name;
    private string surname;
    private string phoneNumber;
    private string email;

    public Contact(string name, string surname, string phoneNumber, string email)
    {
        this.name = name;
        this.surname = surname;
        this.phoneNumber = phoneNumber;
        this.email = email;
    }

    public void PrintContactInfo()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Surname: " + surname);
        Console.WriteLine("Phone number: " + phoneNumber);
        Console.WriteLine("Email: " + email);
    }
}



public class Program
{

    public static void Main()
    {
        Contact[] contacts = new Contact[5];

        // Заполнение массива контактами
        contacts[0] = new Contact("Иван", "Воробьев", "123-456-789", "ivan.ivanov@example.com");
        contacts[1] = new Contact("Анна", "Мягкова", "987-654-321", "anna.petrova@example.com");
        contacts[2] = new Contact("Сергей", "Сидоров", "012-345-678", "sergey.sidorov@example.com");
        contacts[3] = new Contact("Елена", "Иванова", "999-888-777", "elena.ivanova@example.com");
        contacts[4] = new Contact("Алексей", "Сидоров", "111-222-333", "alexey.smirnov@example.com");

        // Сортировка массива по фамилии и имени
        Array.Sort(contacts, (a, b) => string.Compare(a.surname, b.surname, StringComparison.Ordinal) != 0 ? string.Compare(a.surname, b.surname, StringComparison.Ordinal) : string.Compare(a.name, b.name, StringComparison.Ordinal));

        // Вывод таблицы контактов
        foreach (Contact contact in contacts)
        {
            contact.PrintContactInfo();
        }
    }
}







// Создайте струтуру Contact представлдяющую контакт человека с полями уникальный порядковый номер, имя, фамиия, номер телефона и адрес электронной почты. Реализуйте метод для вывода инфрмации о контакте. В конструктор передать все поля кроме порядкого номера. В основной программе сделать массив из 5 контактов отсортировать по фамилии и имени и вывести в виде таблици  