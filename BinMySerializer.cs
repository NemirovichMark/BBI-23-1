using System.IO;
using ProtoBuf;

namespace Lab9_3_4.Serializers
{
    class BinMySerializer : MySerializer
    {
        public override void Write<T>(T obj, string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                Serializer.Serialize(fs, obj);
            }
        }
        public override T Read<T>(string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                return Serializer.Deserialize<T>(fs);
            }
        }
    }
}

