using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Dominio
{
    public class SerializadorXML<T>: Serializador, ISerializable<T> 
    {
        public SerializadorXML(string path) : base(path)
        {
            
        }

        public bool Serializar(T datos)
        {
            using (var stream = new StreamWriter(Path))
            {
                if (stream != null)
                {
                    var xml = new XmlSerializer(typeof(T));

                    xml.Serialize(stream, datos);
                }
            }
            return true;
        }

        public T Deserializar()
        {
            T objetoDeserializado = default(T);

            using (var stream = new StreamReader(Path))
            {
                if (stream != null)
                {
                    var xml = new XmlSerializer(typeof(T));

                    objetoDeserializado = (T)xml.Deserialize(stream);
                }
            }
            return objetoDeserializado;
        }


    }
}
