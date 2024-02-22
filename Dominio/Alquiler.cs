namespace Dominio
{
    [Serializable]
    public enum MedioDePago
    {
        Efectivo,
        TarjetaDeCredito,
        Transferencia
    }
    public enum EstadosAlquiler
    {
        Pendiente,
        Aprobado,
        EnCurso,
        Completado,
        Cancelado,
    }

    
    public class Alquiler
    {
        public List<Volquete> VolquetesAlquiler { get; set; }

        public DateTime FechaEscogida { get; set; }
        public MedioDePago MedioDePago { get; set; }
        public EstadosAlquiler estado { get; set; }
        public string ubicacionDeEntrega { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string numeroDeTelefono { get; set; }
        public string Duracion { get; set; }
        public decimal Precio { get; set; }

        public int IdAlquiler { get; set; }


        public Alquiler()
        {
            
        }
        public Alquiler(List<Volquete> volquetes, DateTime dateTime, string ubicacionDeEntrega, string nombre, string email,
            string numeroDeTelefono, string duracion, decimal Precio, MedioDePago medioDePago, int IdAlquiler)
        {
            this.VolquetesAlquiler = volquetes;
            this.FechaEscogida = dateTime;
            this.ubicacionDeEntrega = ubicacionDeEntrega;
            this.Nombre = nombre;
            this.Email = email;
            this.numeroDeTelefono = numeroDeTelefono;
            this.Duracion = duracion;
            this.Precio = Precio;
            this.MedioDePago = medioDePago;
            this.estado = EstadosAlquiler.Pendiente;
            this.IdAlquiler = IdAlquiler;

        }
        public override string ToString()
        {
            return $"Alquiler de {VolquetesAlquiler} el {FechaEscogida}, ubicación de entrega: {ubicacionDeEntrega}, Nombre: {Nombre}, Email: {Email}, Teléfono: {numeroDeTelefono}, Duración: {Duracion}, Precio: {Precio:C}, Medio de Pago: {MedioDePago}";
        }

        public string VolquetesToString
        {
            get
            {
                return string.Join(", ", VolquetesAlquiler.Select(v => v.ToString()));
            }
        }

    }
}
