using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

namespace MrDevise.Helper
{
    public class SerializationHelper
    {
        public static object XmlDeserialize(Type t, string path)
        {
            TextReader reader = null;
            try
            {
                XmlSerializer deserializer = new XmlSerializer(t);
                reader = new StreamReader(path);
                return deserializer.Deserialize(reader);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }
    }
}
