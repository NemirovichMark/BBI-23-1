using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace serializer_library
{
        public class xml_serializer : abstact_serializer
        {
            public override void Serializetion<T>(T obj, string filePath)
            {
                XmlSerializer x = new XmlSerializer(typeof(T));
                using (TextWriter writer = new StreamWriter(filePath))
                {
                    x.Serialize(writer, obj);
                }
            }

            public override T Deserializetion<T>(string filePath)
            {
                XmlSerializer x = new XmlSerializer(typeof(T));
                using (TextReader reader = new StreamReader(filePath))
                {
                    return (T)x.Deserialize(reader);
                }
            }
        }
}
