using System.Text.Json.Serialization;

namespace lab10.books;

public class FictionBook : Book
{
    public string Genre { get; private set; }
    
    public FictionBook(){}

    [JsonConstructor]
    public FictionBook(string title, string author, int pages, string genre, bool status = true) 
        : base(title, author, pages, status)
    {
        Genre = genre;
    }

    public override string ToString()
    {
        return "FictionBook: " + base.ToString() + $", Жанр: {Genre}";
    }
}