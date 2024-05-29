using System.Text.Json.Serialization;
using lab10.books;

namespace lab10.library;

public partial class Library : ILendable
{
    // публичные геттеры для работы json
    public string Name { get; private set; }
    public string WorkHours { get; private set; }
    public List<Book> Books { get; private set; } = new List<Book>();
    
    public Library(){}

    public Library(string name, string workHours)
    {
        Name = name;
        WorkHours = workHours;
    }

    [JsonConstructor]
    public Library(string name, string workHours, List<Book> books)
    {
        Name = name;
        WorkHours = workHours;
        Books = books;
    }

    // добавляем книгу
    public void Add(Book book)
    {
        Books.Add(book);
    }
    
    // удаляем книгу
    public void Remove(Book book)
    {
        Books.Remove(book);
    }

    // метод для бронировния книги
    // возращаем true, если книга доступна для бронирования и была забронирована,
    // и false в противном случае
    public bool Borrow(string title)
    {
        // ищем книгу по имени с помощью соответсвующего метода
        Book book = FindByTitle(title);
        // проверяем, что книга была найдена
        if (book != null)
        {
            // если книга доступна, то бронируем ее (меняем статус) и выводим инфу об этом на экран
            if (book.Status)
            {
                book.Status = false;
                Console.WriteLine($"Книгу с названием {title} выдали");
                return true;
            }
            Console.WriteLine($"Книги с названием {title} нет в наличии");
        }

        return false;
    }

    // метод для возрата книги в библиотеку
    public void Return(string title)
    {
        // ищем книгу по имени с помощью соответсвующего метода
        Book book = FindByTitle(title);
        // проверяем, что книга была найдена
        if (book != null)
        {
            // помечаем, что книга есть в наличии и выводим инфу об этом на экран
            book.Status = true;
            Console.WriteLine($"Книгу с названием {title} вернули");
        }
    }

    // функция поиска книги по названию
    // возвращает найденную книгу, иначе null
    // помечена private тк используем только в этом классе
    private Book FindByTitle(string title)
    {
        foreach (Book book in Books)
        {
            if (book.Title.Equals(title))
            {
                return book;
            }
        }

        return null;
    }
}