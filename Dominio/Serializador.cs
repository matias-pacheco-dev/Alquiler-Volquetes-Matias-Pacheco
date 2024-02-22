using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public abstract class Serializador
    {
        public string Path { get; set; }
        public string NombreArchivo { get; set; }

        public Serializador()
        {
            
        }
        public Serializador(string path)
        {
            Path = path;

        }



    }
}
