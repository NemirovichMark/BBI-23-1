using lab10.books;

namespace lab10.library;

public partial class Library
{
    // сортирвка по названию книги
    // используем сортировку позырьком
    public void SortedByTitle()
    {
        for (int i = 0; i < Books.Count; i++)
        {
            for (int j = i + 1; j < Books.Count; j++)
            {
                // используем CompareTo для сравнения строк
                if (Books[i].Title.CompareTo(Books[j].Title) > 0)
                {
                    SwapBooks(i, j);
                }                   
            }            
        }
    }
    
    // сортирвка сначала по статусу, затем по автору
    // используем сортировку позырьком
    public void SortedByStatusThenAuthor()
    {
        for (int i = 0; i < Books.Count; i++)
        {
            for (int j = i + 1; j < Books.Count; j++)
            {
                if (!Books[i].Status && Books[j].Status 
                    || Books[i].Status == Books[j].Status 
                    && Books[i].Author.CompareTo(Books[j].Author) > 0)
                {
                    SwapBooks(i, j);
                }                
            }            
        }
    }
    
    // функции для обмена значеними (нужно в сортировке пузырьком)
    private void SwapBooks(int i, int j)
    {
        Book tempBook = Books[i];
        Books[i] = Books[j];
        Books[j] = tempBook;
    }
}