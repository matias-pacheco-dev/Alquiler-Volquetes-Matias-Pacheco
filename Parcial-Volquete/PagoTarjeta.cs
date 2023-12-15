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
            Serializadora.GenerarLogDeError(new Serializadora.LogEntry
            {
                Timestamp = DateTime.Now,
                Message = $"{mensaje}\n\nDetalles del error: {ex.Message}"
            });
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
    }
}
