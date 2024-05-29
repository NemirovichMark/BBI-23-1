using lab10.books;
using lab10.library;
using lab10.serializers;

namespace lab10;

public class Program
{
    public static void Main(string[] args)
    {
        Book[] books =
        {
            new FictionBook("F1", "A1", 98, "G1"),
            new FictionBook("F2", "A2", 1010, "G2"),
            new FictionBook("F3", "A3", 1874, "G3"),
            new FictionBook("F4", "A4", 10, "G4"),
            new FictionBook("F5", "A5", 190, "G1"),
            new FictionBook("F6", "A6", 1009, "G6"),
            new FictionBook("F7", "A7", 189, "G1"),
            new FictionBook("F8", "A8", 1234, "G4"),
            new FictionBook("F9", "A9", 45, "G5"),
            new FictionBook("F10", "A10", 69, "G4"),
            new FictionBook("F11", "A11", 178, "G1"),
            new FictionBook("F12", "A12", 472, "G2"),
            new FictionBook("F13", "A13", 427, "G5"),
            new FictionBook("F14", "A14", 785, "G4"),
            new FictionBook("F15", "A15", 893, "G6"),
            new NonFictionBook("N1", "NA1", 1093, "Old"),
            new NonFictionBook("N2", "NA2", 10, "young"),
            new NonFictionBook("N3", "NA3", 102, "medium"),
            new NonFictionBook("N4", "NA4", 103, "Old"),
            new NonFictionBook("N5", "NA5", 104, "Old"),
            new NonFictionBook("N6", "NA6", 1000, "medium"),
            new NonFictionBook("N7", "NA7", 19, "young"),
            new NonFictionBook("N8", "NA8", 99, "Old"),
            new NonFictionBook("N9", "NA9", 80, "medium"),
            new NonFictionBook("N10", "NA10", 109, "young"),
            new NonFictionBook("N11", "NA11", 18, "young"),
            new NonFictionBook("N12", "NA12", 34, "medium"),
            new NonFictionBook("N13", "NA13", 1543, "Old"),
            new NonFictionBook("N14", "NA14", 198, "Old"),
            new NonFictionBook("N15", "NA15", 204, "medium")
        };
        Book[] books2 =
        {
            new FictionBook("F16", "A16", 980, "G6"),
            new FictionBook("F17", "A17", 101, "G7"),
            new FictionBook("F18", "A18", 184, "G1"),
            new FictionBook("F19", "A19", 109, "G1"),
            new FictionBook("F20", "A20", 170, "G2"),
            new FictionBook("F21", "A21", 893, "G4"),
            new FictionBook("F22", "A22", 666, "G3"),
            new NonFictionBook("N16", "NA16", 119, "Old"),
            new NonFictionBook("N17", "NA17", 193, "young"),
            new NonFictionBook("N18", "NA18", 199, "medium"),
            new NonFictionBook("N19", "NA19", 66, "Old"),
            new NonFictionBook("N20", "NA20", 666, "Old"),
            new NonFictionBook("N21", "NA21", 777, "medium"),
            new NonFictionBook("N22", "NA22", 88, "young"),
            new NonFictionBook("N23", "NA23", 999, "Old")
        };
        Library[] libraries =
        {
            new Library("L1", "10-22"),
            new Library("L2", "11-20"),
            new Library("L3", "8-19")
        };

        // закидываем в библитеки книги из общего массива книг
        // (по принципу каждая 3 книга, чтобы в разных библиотеках были разные книги)
        for (int i = 0; i < libraries.Length; i++)
        {
            for (int j = i; j < books.Length; j += libraries.Length)
            {
                libraries[i].Add(books[j]);
            }
        }

        // пути к файликам
        string[] files =
        {
            "C:/Users/tuuure/project/lab10/lab10/files/raw_data.json",
            "C:/Users/tuuure/project/lab10/lab10/files/data.json",
            "C:/Users/tuuure/project/lab10/lab10/files/new_data.json",
            "C:/Users/tuuure/project/lab10/lab10/files/update_data.json",
            "C:/Users/tuuure/project/lab10/lab10/files/last_data.json"
        };
        // удаляем существующий файлики
        // json поверх старых записей файла почему-то записывает и иногда вылетает ошибка из-за этого
        foreach (string file in files)
        {
            if (File.Exists(file))
            {
                File.Delete(file);
            }
        }


        // создали объект для сериализации
        MyJsonSerializer myJsonSerializer = new MyJsonSerializer();
        // записали в файлик1 массив с библиотеками, заполненых книгами 
        myJsonSerializer.Write(libraries, files[0]);

        // добавили еще книг из 2 списка книг по такому же принципу
        for (int i = 0; i < libraries.Length; i++)
        {
            for (int j = i; j < books2.Length; j += libraries.Length)
            {
                libraries[i].Add(books2[j]);
            }
        }

        // забронировали по 5 книг из каждой библиотеки
        // в реализации метода Borrow есть проверка на то, что книга доступна для бронирования
        for (int i = 0; i < libraries.Length; i++)
        {
            int cnt = 0;
            // будем пытаться забронировать книги, пока не заьронируем ровно 5
            while (cnt < 5)
            {
                // Borrow вернет true, если книгу удалось забронировать
                // выбираем рандомную книгу из списка книг в этой библиотеке
                if (libraries[i].Borrow(libraries[i].Books[Random.Shared.Next(0, libraries[i].Books.Count)].Title))
                {
                    cnt++;
                }
            }
        }

        // сериализуем массив с измененными библиотеками
        myJsonSerializer.Write(libraries, files[1]);


        // удаляем книги (по 5 из каждой библиотеке)
        // remove удалит книгу только если она есть в наличии
        for (int i = 0; i < libraries.Length; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                libraries[i].Remove(libraries[i].Books[j]);
            }
        }

        // сериализуем массив с измененными библиотеками
        myJsonSerializer.Write(libraries, files[2]);

        // выводим на экран массивы библиотек сохраненные в файлах
        Print(myJsonSerializer, files[0]);
        Print(myJsonSerializer, files[1]);
        Print(myJsonSerializer, files[2]);


        // сортируем книги в каждой библиотеке сначала по статусу потом по автору
        for (int i = 0; i < libraries.Length; i++)
        {
            libraries[i].SortedByStatusThenAuthor();
        }

        // сериализуем массив с измененными библиотеками
        myJsonSerializer.Write(libraries, files[3]);


        // создаем общую библиотеку, в которую поместим все книги из других библиотек   
        Library[] allLibrary =
        {
            new Library("All", "always")
        };
        foreach (Library library in libraries)
        {
            foreach (Book libraryBook in library.Books)
            {
                allLibrary[0].Add(libraryBook);
            }
        }

        // сортируем нашу общуюю библиотеку по автору
        allLibrary[0].SortedByTitle();

        // сериализуем массив с общей библиотекой
        myJsonSerializer.Write(allLibrary, files[4]);

        // выводим на экран массивы библиотек сохраненные в файлах
        Print(myJsonSerializer, files[3]);
        Print(myJsonSerializer, files[4]);
    }

    private static void Print(MyJsonSerializer myJsonSerializer, string filename)
    {
        Console.WriteLine(filename);
        foreach (Library library in myJsonSerializer.Read(filename))
        {
            Console.WriteLine(library.Name);
            foreach (Book book in library.Books)
            {
                Console.WriteLine(book);
            }
        }
    }
}