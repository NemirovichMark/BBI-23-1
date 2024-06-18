using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
#region Выберите библиотеку(и) для сериализации

using System.Text.Json;
using System.Text.Json.Serialization;
#endregion
namespace Variant_2
{
    public interface IDataSerializer<T>
    {
        void Write(T obj, string path);
        T Read(string path);
    }

    public class DataSerializer : IDataSerializer<Grep>, ICreator
    {
        public void Write(Grep obj, string path)
        {
            string jsonString = JsonSerializer.Serialize(obj);
            File.WriteAllText(path, jsonString);
        }

        public Grep Read(string path)
        {
            string jsonString = File.ReadAllText(path);
            return JsonSerializer.Deserialize<Grep>(jsonString);
        }

        public void CreateFolder(string path, string folderName)
        {
            string fullPath = Path.Combine(path, folderName);
            Directory.CreateDirectory(fullPath);
        }

        public void CreateFolder(string path, string[] folderNames)
        {
            foreach (string folderName in folderNames)
            {
                CreateFolder(path, folderName);
            }
        }

        public void CreateFile(string path, string fileName)
        {
            string fullPath = Path.Combine(path, fileName);
            File.Create(fullPath).Dispose();
        }

        public void CreateFile(string path, string[] fileNames)
        {
            foreach (string fileName in fileNames)
            {
                CreateFile(path, fileName);
            }
        }
    }

    public interface ICreator
    {
        void CreateFolder(string path, string folderName);
        void CreateFolder(string path, string[] folderNames);
        void CreateFile(string path, string fileName);
        void CreateFile(string path, string[] fileNames);
    }

    public class Grep
    {
        public string Text { get; set; }

        public Grep(string text)
        {
            Text = text;
        }

        public override string ToString()
        {
            return Text;
        }
    }

    public class Task4
    {
        public static void Main(string[] args)
        {
            
            Grep grep = new Grep("This is a sample text to test the Grep class.");

            
            DataSerializer serializer = new DataSerializer();

            serializer.Write(grep, "grep.json");
           
            Grep deserializedGrep = serializer.Read("grep.json");
            
            Console.WriteLine(deserializedGrep.ToString());
            
            serializer.CreateFolder("C:\\Temp", "NewFolder");

           
            serializer.CreateFile("C:\\Temp\\NewFolder", "file1.txt");
            serializer.CreateFile("C:\\Temp\\NewFolder", new string[] { "file2.txt", "file3.txt" });

            Console.ReadKey();
        }
    }
}
