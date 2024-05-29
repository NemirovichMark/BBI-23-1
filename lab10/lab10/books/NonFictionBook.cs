using System.Text.Json.Serialization;

namespace lab10.books;

public class NonFictionBook : Book
{
    public string AgeGroup { get; private set; }
    
    public NonFictionBook(){}

    [JsonConstructor]
    public NonFictionBook(string title, string author, int pages, string ageGroup, bool status = true)
        : base(title, author, pages, status)
    {
        AgeGroup = ageGroup;
    }
    
    public override string ToString()
    {
        return "NonFictionBook: " + base.ToString() + $", Возрастная группа: {AgeGroup}";
    }
}