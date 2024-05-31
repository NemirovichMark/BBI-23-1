using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace serializer_library
{
    public class binary_serializer: abstact_serializer
    {
        public override void Serializetion<T>(T obj, string filePath)
        {
            using (var file = File.Create(filePath))
            {
                Serializer.Serialize<T>(file, obj);
            }
        }
        public override T Deserializetion<T>(string filePath)
        {
            using (var file = File.OpenRead(filePath))
            {
                return Serializer.Deserialize<T>(file);
            }
            return default(T);
        }
    }
}
