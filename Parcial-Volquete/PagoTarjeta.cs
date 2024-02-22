using AccesoDatos;
using Dominio;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Parcial_Volquete
{
    public partial class PagoTarjeta : Form
    {
        decimal precio;
        Alquiler AlquilerActual;
        List<Volquete> VolquetesActuales;
        AlquilerDao alquilerDao;
        public PagoTarjeta(decimal precioElegido, Alquiler alquilerElegido, List<Volquete> VolquetesElegidos)
        {
            InitializeComponent();
            this.precio = precioElegido;
            this.AlquilerActual = alquilerElegido;
            this.VolquetesActuales = VolquetesElegidos;
            this.alquilerDao = new AlquilerDao();
        }

        private void PagoTarjeta_Load(object sender, EventArgs e)
        {
            lblPrecio.Text = this.precio.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnPagar_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtNumTarjeta.Text != "xxxx xxxx xxxx xxxx" &&
                    txtExpiration.Text != "MM/YY" &&
                    txtCVV.Text != "***" &&
                    txtName.Text != "John Doe")
                {
                    lblProgreso.Text = new TarjetaCredito().ProcesarPago(AlquilerActual.Precio);

                    // Ejecutar el proceso de generación de factura de manera asíncrona
                    await GenerarFacturaAsync();

                    lblProgreso.Text = "Pago procesado con éxito.";

                    // Resto del código después de generar la factura 
                    GestionUsuarios.UsuarioActual.AgregarAlquiler(this.AlquilerActual);
                    alquilerDao.AgregarAlquilerEnBD(this.AlquilerActual, GestionUsuarios.UsuarioActual.idDB);

                    VolqueteDao volqueteDao = new VolqueteDao();
                    volqueteDao.ActualizarVolquetesEnBD(this.AlquilerActual.IdAlquiler, VolquetesActuales);

                    VentanaEmergente ve = new VentanaEmergente("Reserva", "Reservado con éxito");
                    ve.ShowDialog();
                    if (ve.DialogResult == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, complete todos los campos de la tarjeta antes de realizar el pago.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                ManejarError(ex, "Error al procesar el pago y/o generar la factura.");
            }

        }

        private async Task GenerarFacturaAsync()
        {
            // Ejecutar la generación de factura de manera asíncrona
            await Task.Run(() => new TarjetaCredito().GenerarFactura(this.AlquilerActual));
        }

        private void ManejarError(Exception ex, string mensaje)
        {
            // Manejar la excepción y generar el log de error
            MessageBox.Show($"{mensaje}\n\nDetalles del error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            LogEntry logError = new LogEntry(ex.Message);

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string logFilePath = Path.Combine(desktopPath, "error_log.xml");

            var serializarXML = new SerializadorXML<LogEntry>(logFilePath);

            serializarXML.Serializar(logError);
        }

        private void txtNumTarjeta_Enter(object sender, EventArgs e)
        {
            if (txtNumTarjeta.Text == "xxxx xxxx xxxx xxxx")
            {
                txtNumTarjeta.Text = "";
            }
        }

        private void txtNumTarjeta_Leave(object sender, EventArgs e)
        {
            if (txtNumTarjeta.Text == "")
            {
                txtNumTarjeta.Text = "xxxx xxxx xxxx xxxx";
            }
        }

        private void txtExpiration_Enter(object sender, EventArgs e)
        {
            if (txtExpiration.Text == "MM/YY")
            {
                txtExpiration.Text = "";
            }
        }

        private void txtExpiration_Leave(object sender, EventArgs e)
        {
            if (txtExpiration.Text == "")
            {
                txtExpiration.Text = "MM/YY";
            }
        }

        private void txtCVV_Enter(object sender, EventArgs e)
        {
            if (txtCVV.Text == "***")
            {
                txtCVV.Text = "";
            }

        }

        private void txtCVV_Leave(object sender, EventArgs e)
        {
            if (txtCVV.Text == "")
            {
                txtCVV.Text = "***";
            }
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            if (txtName.Text == "John Doe")
            {
                txtName.Text = "";
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.Text = "John Doe";
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            // Generar un número de tarjeta de crédito aleatorio de 16 dígitos con guiones cada cuatro dígitos
            string numTarjeta = "";
            for (int i = 0; i < 16; i++)
            {
                if (i > 0 && i % 4 == 0) // Agrega un guión ("-") cada cuatro dígitos
                {
                    numTarjeta += "-";
                }
                numTarjeta += random.Next(0, 10); // Genera un número aleatorio entre 0 y 9
            }
            txtNumTarjeta.Text = numTarjeta;

            // Generar una fecha de expiración aleatoria en el formato "MM/YY"
            int month = random.Next(1, 13); // Genera un número aleatorio entre 1 y 12 para el mes
            int year = random.Next(DateTime.Now.Year, DateTime.Now.Year + 6); // Genera un año aleatorio entre el actual y los próximos 5 años
            txtExpiration.Text = $"{month.ToString("00")}/{(year % 100).ToString("00")}"; // Formatea el mes y el año en el formato deseado

            // Generar un CVV aleatorio de 3 dígitos
            string cvv = random.Next(100, 1000).ToString(); // Genera un número aleatorio entre 100 y 999
            txtCVV.Text = cvv;

            // Generar un nombre aleatorio
            string[] nombres = { "John Doe", "Jane Smith", "Michael Johnson", "Emily Brown", "David Wilson", "Sarah Martinez" }; // Lista de nombres aleatorios
            txtName.Text = nombres[random.Next(nombres.Length)]; // Elige un nombre aleatorio de la lista
        }

        private void txtNumTarjeta_TextChanged(object sender, EventArgs e)
        {
            // Eliminar los guiones actuales para poder volver a formatear el número
            string numTarjetaSinGuiones = txtNumTarjeta.Text.Replace("-", "");

            // Formatear el número de tarjeta agregando guiones cada cuatro dígitos
            string numTarjetaFormateado = "";
            for (int i = 0; i < numTarjetaSinGuiones.Length; i++)
            {
                if (i > 0 && i % 4 == 0) // Agrega un guión ("-") cada cuatro dígitos
                {
                    numTarjetaFormateado += "-";
                }
                numTarjetaFormateado += numTarjetaSinGuiones[i];
            }

            // Mostrar el número de tarjeta formateado en el campo de texto
            txtNumTarjeta.Text = numTarjetaFormateado;
            // Mover el cursor al final del texto para mantener la posición correcta
            txtNumTarjeta.SelectionStart = txtNumTarjeta.Text.Length;
        }

        private void txtNumTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo la entrada de números y la tecla de retroceso (backspace)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
