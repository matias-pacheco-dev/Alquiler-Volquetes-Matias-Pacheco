using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum TipoDeVolquete
    {
        Pequeño,
        Mediano,
        Grande
    }
    [Serializable]
    public class Volquete
    {
        
        public double Tamaño { get; set; }

        public TipoDeVolquete Tipo { get; set; }

        public int Stock { get; set; }


        public Volquete(double tamaño, TipoDeVolquete tipo)
        {
            this.Tamaño = tamaño;
            this.Tipo = tipo;
            
        }
        public Volquete(double tamaño, TipoDeVolquete tipo, int stock)
        {
            this.Tamaño = tamaño;
            this.Tipo = tipo;
            this.Stock = stock;
        }
        public override string ToString()
        {
            return $"{Tipo}";
        }


    }
}
