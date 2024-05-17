
using System.IO;
using System.Text.Json;

namespace Lab9_3_4.Serializers
{
    class JsonMySerializer : MySerializer
    {
        public override void Write<T>(T obj, string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                JsonSerializer.Serialize(fs, obj);
            }
        }
        public override T Read<T>(string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                return JsonSerializer.Deserialize<T>(fs);
            }
        }
    }
}


