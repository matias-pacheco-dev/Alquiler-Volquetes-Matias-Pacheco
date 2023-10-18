using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Alquiler
    {
        public Volquete VolqueteAlquiler { get; set; }

        public DateTime FechaEscogida { get; set; }
        public string ubicacionDeEntrega { get; set; }
        
        public string Nombre { get; set; }
        public string Email { get; set;}
        public string numeroDeTelefono { get; set; }

        public string MedioDePago { get; set; }

        public string Duracion { get; set; } 
        public decimal Precio { get; set; }

        public Alquiler(Volquete volquete, DateTime dateTime, string ubicacionDeEntrega, string nombre, string email, string numeroDeTelefono, string duracion, decimal Precio, string medioDePago)
        {
            this.VolqueteAlquiler = volquete;
            this.FechaEscogida = dateTime;
            this.ubicacionDeEntrega = ubicacionDeEntrega;
            this.Nombre = nombre;
            this.Email = email;
            this.numeroDeTelefono = numeroDeTelefono;
            this.Duracion = duracion;
            this.Precio = Precio;
            this.MedioDePago = medioDePago;
          
        }
        public override string ToString()
        {
            return $"Alquiler de {VolqueteAlquiler} el {FechaEscogida}, ubicación de entrega: {ubicacionDeEntrega}, Nombre: {Nombre}, Email: {Email}, Teléfono: {numeroDeTelefono}, Duración: {Duracion}, Precio: {Precio:C}, Medio de Pago: {MedioDePago}";
        }


    }
}
