//Вариант 6  
/* код первого задания
 
 using System;

public struct Book
{
    public string Title;
    static int ISBN;
    public string Author;
    public int Year;
    private static int nextISBN = 1;

    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
        ISBN = nextISBN++;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Title: {Title}, ISBN: {ISBN}, Author: {Author}, Year: {Year}");
    }
}

public class Program
{
    public static void Main()
    {
        Book[] books = new Book[10];
        books[0] = new Book("Book1", "Author1", 1990);
        books[1] = new Book("Book2", "Author2", 2000);
        books[2] = new Book("Book3", "Author1", 2010);
        books[3] = new Book("Book4", "Author3", 1980);
        books[4] = new Book("Book5", "Author2", 2005);
        books[5] = new Book("Book6", "Author1", 2015);
        books[6] = new Book("Book7", "Author4", 1995);
        books[7] = new Book("Book8", "Author3", 2003);
        books[8] = new Book("Book9", "Author2", 2011);
        books[9] = new Book("Book10", "Author1", 1998);

        Console.WriteLine("Книги Author1:");
        foreach (var book in books)
        {
            if (book.Author == "Author1")
            {
                book.PrintInfo();
            }
        }

        Console.WriteLine("\nКниги 20-го века:");
        foreach (var book in books)
        {
            if (book.Year < 2001)
            {
                book.PrintInfo();
            }
        }
    }
}


*/



using System;
using System.Collections.Generic;

public abstract class Book
{
    public string Title;
    public static int ISBN;
    public string Author;
    public int Year;
    private static int nextISBN = 1;
    public decimal Price;

    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
        ISBN = nextISBN++;
    }

    public abstract decimal CalculatePrice();

    public void PrintInfo()
    {
        Console.WriteLine($"Title: {Title}, ISBN: {ISBN}, Author: {Author}, Year: {Year}, Price: {Price}");
    }
}

public class PaperBook : Book
{
    public PaperBook(string title, string author, int year) : base(title, author, year) { }

    public override decimal CalculatePrice()
    {
        return 10m; 
    }
}

public class ElectronicBook : Book
{
    public string Format;

    public ElectronicBook(string title, string author, int year, string format) : base(title, author, year)
    {
        Format = format;
    }

    public override decimal CalculatePrice()
    {
        return 5m; 
    }
}

public class AudioBook : Book
{
    public bool Hardcover;
    public bool StudioRecording;

    public AudioBook(string title, string author, int year, bool hardcover, bool studioRecording) : base(title, author, year)
    {
        Hardcover = hardcover;
        StudioRecording = studioRecording;
    }

    public override decimal CalculatePrice()
    {
        return Hardcover ? 20m : 15m; 
    }
}

public class Program
{
    public static void Main()
    {
        List<Book> books = new List<Book>();
        books.Add(new PaperBook("Book1", "Author1", 1990) { Price = new PaperBook("Book1", "Author1", 1990).CalculatePrice() });
        books.Add(new PaperBook("Book2", "Author2", 2000) { Price = new PaperBook("Book2", "Author2", 2000).CalculatePrice() });
        books.Add(new ElectronicBook("Book3", "Author1", 2010, "pdf") { Price = new ElectronicBook("Book3", "Author1", 2010, "pdf").CalculatePrice() });
        books.Add(new ElectronicBook("Book4", "Author3", 1980, "fb2") { Price = new ElectronicBook("Book4", "Author3", 1980, "fb2").CalculatePrice() });
        books.Add(new AudioBook("Book5", "Author2", 2005, true, true) { Price = new AudioBook("Book5", "Author2", 2005, true, true).CalculatePrice() });

        
        books.Sort((x, y) => y.Price.CompareTo(x.Price));

        Console.WriteLine("All Books:");
        foreach (var book in books)
        {
            book.PrintInfo();
        }
    }
}




