using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class TarjetaCredito : IMetodoPago
    {
        public string ProcesarPago(decimal monto)
        {
            return $"Procesando pago de {monto} mediante tarjeta de crédito.";
        }

        public void GenerarFactura(Alquiler alquiler)
        {
            try
            {
                // Obtener la ruta del escritorio del usuario
                string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                // Nombre del archivo basado en el ID del alquiler
                string nombreArchivo = Path.Combine(escritorio, $"Factura_Alquiler_{alquiler.IdAlquiler}.txt");

                // Crear la factura en el escritorio del usuario
                using (StreamWriter sw = new StreamWriter(nombreArchivo))
                {
                    // Encabezado de la factura
                    sw.WriteLine($"Factura de Alquiler (ID: {alquiler.IdAlquiler})");
                    sw.WriteLine($"Fecha: {DateTime.Now}");
                    sw.WriteLine($"Nombre: {alquiler.Nombre}");
                    sw.WriteLine($"Email: {alquiler.Email}");
                    sw.WriteLine($"Teléfono: {alquiler.numeroDeTelefono}");
                    sw.WriteLine();

                    // Detalles del alquiler
                    sw.WriteLine("Detalles del Alquiler:");
                    sw.WriteLine($"Fecha de Alquiler: {alquiler.FechaEscogida}");
                    sw.WriteLine($"Ubicación de Entrega: {alquiler.ubicacionDeEntrega}");
                    sw.WriteLine($"Duración: {alquiler.Duracion}");
                    sw.WriteLine($"Volquetes: {alquiler.VolquetesToString}");
                    sw.WriteLine($"Precio: {alquiler.Precio:C}");
                    sw.WriteLine($"Medio de Pago: {alquiler.MedioDePago}");
                    sw.WriteLine();

                    // Resumen
                    sw.WriteLine($"Total: {alquiler.Precio:C}");
                    Task.Delay(3000).Wait();
                }

            }
            catch (Exception ex)
            {
                
            }
        }

    }
}

