
// Вариант 6

 
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




