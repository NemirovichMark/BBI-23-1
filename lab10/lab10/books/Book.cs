using System.Text.Json.Serialization;

namespace lab10.books;

[Serializable]
[JsonDerivedType(typeof(FictionBook), typeDiscriminator:"fiction book")]
[JsonDerivedType(typeof(NonFictionBook), typeDiscriminator:"non-fiction book")]
public abstract class Book
{
    // публичные геттеры для json
    public string Title { get; private set; }
    public string Author { get; private set; }
    // публичный сеттер, тк мы меняем статус книги
    // true - доступна в библиотеке, false - нет в наличии
    public bool Status { get; set; }
    public int Pages { get; private set; }
    
    protected Book(){}

    protected Book(string title, string author, int pages, bool status)
    {
        Title = title;
        Author = author;
        Status = status;
        Pages = pages;
    }


    public override string ToString()
    {
        return $"Название: {Title}, Автор: {Author}, " +
               $"Статус: {(Status ? "Есть в наличии" : "Нет в наличии")}, " +
               $"Количество страниц: {Pages}";
    }
    
}