using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Dominio
{
    public class SerializadorJson<T> : Serializador, ISerializable<T> where T : new()
    {
        public SerializadorJson(string path) : base(path)
        {

        }

        public bool Serializar(T datos)
        {
            using (var stream = new StreamWriter(Path))
            {
                if (stream != null)
                {
                    var options = new JsonSerializerOptions();
                    options.WriteIndented = true;

                    var json = JsonSerializer.Serialize(datos, options);
                    stream.Write(json);
                }
            }
            return true;
        }

        public T Deserializar()
        {
            T datosDeserializados = default(T);

            using (var stream = new StreamReader(Path))
            {
                if (stream != null)
                {
                    var json = stream.ReadToEnd();
                    datosDeserializados = JsonSerializer.Deserialize<T>(json);
                }
            }

            return datosDeserializados;
        }
    }
}
