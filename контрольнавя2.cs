using ConsoleApp2;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    abstract class Task
    {
        protected string text = "No text here yet";
        public string Text
        {
            get => text;
            protected set => text = value;
        }
        public Task(string text)
        {
            this.text = text;
        }
    }
    class Task1 : Task
    {

        public Task1(string text) : base(text)
        {
            Counter(text);
        }
        private void Counter(string text)
        {
            int sum = 0, maximum = 0, maximumFirstInd = 0, maximumSecondInd = 0;

            int[] array = new int[3] { '.', '?', '!' };

            int firstIndex = 0;
            for (int i = firstIndex; i < text.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (Convert.ToInt32(text[i]) == array[j])
                    {
                        break;
                    }
                    else
                    {
                        sum++;
                    }
                }
                if (sum > maximum)
                {
                    maximum = sum;
                    maximumSecondInd = i;
                    maximumFirstInd = i - maximum;
                }
                sum = 0;
            }
            char[] myarray=new char[100];
            for(int i=0;i< myarray.Length;i++)
            {
                for(int j = maximumFirstInd; j <= maximumSecondInd; j++)
                {
                    myarray[i] = text[j];
                }
            }
        }
        public override string ToString()
        {
            return text;
        }
    }
    class Task3 : Task
    {

        public Task3(string text) : base(text)
        {
            //
        }
        public override string ToString()
        {
            return text;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Task[] tasks = {
            new Task1("Example")       
        };

            Console.WriteLine(tasks[0]);

            Task one = new Task3("dfgghhjk");
            string text = JsonConvert.SerializeObject(one);
            File.WriteAllText(@"C:C:\Users\m2302499\Documents\Solution\File.json", text);

            string path = @"C:C:\Users\m2302499\Documents\File.json"; 
            string NameOfTheFolder = "Solution"; 

            path = Path.Combine(path, NameOfTheFolder);
            if (!Directory.Exists(path))    
            {
                Directory.CreateDirectory(path);
            }
            string file1 = "task_1.json"; 
            string file2 = "task_2.json";

            file1 = Path.Combine(path, file1);
            file2 = Path.Combine(path, file2);

            if (!File.Exists(file1))
            {
                File.Create(file1);
            }
        }
    }
}
class JsonIO

{
    public static void Write<T>(T objects, string filePath)
    {
        using (FileStream file = new FileStream(file, FileMode.OpenOrCreate))
        {
            JsonSerializer.Serialize(file, objects);
        }
    }
    public static T Read<T>(string filePath)
    {
        using (FileStream file = new FileStream(file, FileMode.OpenOrCreate))
        {
            return JsonSerializer.Deserialize<T>(file);
        }
        return default(T);
    }
    public static void wrighting1(Task1 obj, string filePath)
    {
        using (FileStream file = new FileStream(filePath, FileMode.OpenOrCreate))
        {
            JsonSerializer.Serialize(file, obj);
        }
    }
    public static Task1 reading1(string filePath)
    {
        using (FileStream file = new FileStream(filePath, FileMode.OpenOrCreate))
        {
            return JsonSerializer.Deserialize<Task1>(file);
        }
        return null;
    }
}
