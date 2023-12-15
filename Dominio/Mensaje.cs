using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Mensaje
    {
        public string Remitente { get; set; }
        public int Destinatario { get; set; }
        public string Contenido { get; set; }

        public Mensaje(string remitente, int destinatario, string contenido)
        {
            Remitente = remitente;
            Destinatario = destinatario;
            Contenido = contenido;
        }
    }
}
