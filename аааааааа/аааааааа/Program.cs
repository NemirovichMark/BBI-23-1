//#region вар20н1
//using system;

//class program
//{
//    static void main()
//    {
//        string input = "рпрпр1 дщлвл2 длаьы3 ьалвьл4 уцоьлоау5 длулкдул6 выраывгшр7";

//        string[] words = input.split(' ');

//        int middleindex = words.length / 2;
//        string centralword = words[middleindex];

//        console.writeline("центральное слово в тексте: " + centralword);
//    }
//}

//#endregion


//#region вар20н2
//using System;

//class program
//{
//    static void Main()
//    {
//        string input = "На вход подается Cтрока, на выход - массив строк. Выписать из текста все имена Cобственные (с большой буквы) построчно. Считать, что с них Предложения не начинаются.";

//        string[] words = input.Split(' ');

//        foreach (var word in words)
//        {
//            if (IsProperNoun(word))
//            {
//                Console.WriteLine(word);
//            }
//        }
//    }
//    static bool IsProperNoun(string word)
//    {
//        if (word.Length == 0)
//            return false;

//        if (!IsUpperCase(word[0]))
//            return false;

//        for (int i = 1; i < word.Length; i++)
//        {
//            if (IsUpperCase(word[i]))
//                return false;
//        }

//        return true;
//    }

//    static bool IsUpperCase(char c)
//    {
//        return c >= 'A' && c <= 'Z';

//    }
//}

//#endregion


//#region вар20н3
//using System;
//using System.IO;

//class Program
//{
//    static void Main()
//    {
//        string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Fourth Task");

//        // Проверяем существует ли папка "Fourth Task"
//        if (!Directory.Exists(folderPath))
//        {
//            Directory.CreateDirectory(folderPath);
//            Console.WriteLine("Папка 'Fourth Task' успешно создана.");
//        }
//        else
//        {
//            Console.WriteLine("Папка 'Fourth Task' уже существует.");
//        }

//        // Создаем файлы string_1.json и string_2.json в папке "Fourth Task"
//        CreateFile(Path.Combine(folderPath, "string_1.json"));
//        CreateFile(Path.Combine(folderPath, "string_2.json"));

//        Console.WriteLine("Файлы успешно созданы.");
//    }

//    static void CreateFile(string filePath)
//    {
//        if (!File.Exists(filePath))
//        {
//            using (File.Create(filePath)) { }
//            Console.WriteLine($"Файл '{Path.GetFileName(filePath)}' успешно создан.");
//        }
//        else
//        {
//            Console.WriteLine($"Файл '{Path.GetFileName(filePath)}' уже существует.");
//        }
//    }
//}
//#endregion