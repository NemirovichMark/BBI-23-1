using System;
using System.Collections.Generic;
using System.Text.Json;

class Program
{
    static void Main()
    {
        Console.WriteLine("Task 1:\n");

        //text to work with
        string inputText = "example bla bla bla 1234565556..., hello world!";

        int digitCount = 0;
        int letterCount = 0;
        int punctuationCount = 0;
        int spaceCount = 0;

        //counting 1 - words, 2 - numbers, 3 - punctuation marks, 4 - spaces
        foreach (char c in inputText)
        {
            if (char.IsDigit(c))
            {
                digitCount++;
            }
            else if (char.IsLetter(c))
            {
                letterCount++;
            }
            else if (char.IsPunctuation(c))
            {
                punctuationCount++;
            }
            else if (char.IsWhiteSpace(c))
            {
                spaceCount++;
            }
        }

        //making a list to display result
        List<int> counts = new List<int> { letterCount, digitCount, punctuationCount, spaceCount };

        Console.WriteLine("words   numbers   punct marks   spaces");
        foreach (int count in counts)
        {
            Console.Write(count);
            if (count != counts[counts.Count - 1])
            {
                Console.Write(",         ");
            }
        }



        Console.WriteLine("\n\nTask 2:\n");

        string inputtedText = "Пример строки для сдвига букв на 15 символов влево";
        string resultText = ShiftLetters(inputtedText, -15); //shifting by 15 symbols to the left
        Console.WriteLine(resultText);



        //Console.WriteLine("\nTask 3:\n");

        //string downloadsPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";
        //string testFolderPath = Path.Combine(downloadsPath, "Test");

        //// creating folder "Test" in "Downloads"
        //Directory.CreateDirectory(testFolderPath);

        //// creating files "cw2_1.json" and "cw2_2.json" in the folder "Test"
        //File.Create(Path.Combine(testFolderPath, "cw2_1.json")).Close();
        //File.Create(Path.Combine(testFolderPath, "cw2_2.json")).Close();

        //Console.WriteLine("Folder Test and files cw2_1.json & cw2_2.json were succesfully created");



        Console.WriteLine("\nTask 4:");

        string downloadsPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads\\";

        // files for task 1
        File.WriteAllText(downloadsPath + "input_task1.json", "example bla bla bla 1234565556..., hello world!");
        File.WriteAllText(downloadsPath + "output_task1.json", "26,         10,         5,         6");

        // files for task 2
        File.WriteAllText(downloadsPath + "input_task2.json", "Пример строки для сдвига букв на 15 символов влево");
        File.WriteAllText(downloadsPath + "output_task2.json", "Бвъюцв гдваьъ хэр гхуъфс теьу яс 15 гъюуаэау уэцуа");

        Console.WriteLine("\nfiles were succesfully created");

        // task 1
        string input1 = "example bla bla bla 1234565556..., hello world!";
        string output1 = "26,         10,         5,         6";

        // path to the folder with task 1
        string filePath1 = "\\Downloads";

        // saving or reading from task 1
        SaveOrReadData(filePath1, input1, output1);

        // task 2
        string input2 = "Пример строки для сдвига букв на 15 символов влево";
        string output2 = "Бвъюцв гдваьъ хэр гхуъфс теьу яс 15 гъюуаэау уэцуа";

        // path to the folder with task 2
        string filePath2 = "\\Downloads";

        // saving or reading from task 2
        SaveOrReadData(filePath2, input2, output2);
    }

    //method to save or read data (task 4)
    static void SaveOrReadData(string filePath, string input, string output)
    {
        if (File.Exists(filePath))
        {
            // reading
            string jsonData = File.ReadAllText(filePath);

            // outputting
            Console.WriteLine($"\ndata from the file {filePath}:");
            Console.WriteLine(jsonData);
        }

        else
        {
            // creating object to save n json
            var data = new { Input = input, Output = output };

            // creating ing json
            string jsonData = JsonSerializer.Serialize(data);

            // Сохранение данных в файл
            File.WriteAllText(filePath, jsonData);

            Console.WriteLine($"data saved to the file: {filePath}.");
        }
    }

    //method to shift letters (task 2)
    static string ShiftLetters(string input, int shift)
    {
        string russianAlphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

        string result = string.Empty;

        //shifting letters
        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                bool isUpper = char.IsUpper(c);
                char letter = char.ToLower(c);
                int index = russianAlphabet.IndexOf(letter);

                if (index >= 0)
                {
                    index += shift;
                    if (index < 0)
                    {
                        index += russianAlphabet.Length;
                    }
                    else if (index >= russianAlphabet.Length)
                    {
                        index -= russianAlphabet.Length;
                    }

                    char shiftedChar = russianAlphabet[index];
                    if (isUpper)
                    {
                        shiftedChar = char.ToUpper(shiftedChar);
                    }

                    result += shiftedChar;
                }
                else
                {
                    result += c;
                }
            }
            else
            {
                result += c;
            }
        }

        return result;
    }
}