using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Volquete
    {
        public double Tamaño { get; set; }
        public string Tipo { get; set; }
        

        public Volquete(double tamaño, string tipo)
        {
            this.Tamaño = tamaño;
            this.Tipo = tipo;
           
        }
    }
}
