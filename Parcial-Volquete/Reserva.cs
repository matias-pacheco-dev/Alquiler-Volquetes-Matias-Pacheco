using AccesoDatos;
using Entidades;
using Dominio;
using System.Runtime.InteropServices;

namespace Parcial_Volquete
{
    public partial class Reserva : Form
    {
        List<Volquete> volquetesElegidos;

        public Reserva(List<Volquete> volqueteElegido)
        {
            InitializeComponent();
            volquetesElegidos = volqueteElegido;

        }

        #region MoverForm
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Reserva_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }
        #endregion

        private void Reserva_Load(object sender, EventArgs e)
        {
            comboBoxPago.DataSource = Enum.GetValues(typeof(MedioDePago));

        }



        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (GestionUsuarios.UsuarioActual != null)
                {
                    if (!string.IsNullOrWhiteSpace(txtDireccion.Text) &&
                        !string.IsNullOrWhiteSpace(txtNombre.Text) &&
                        !string.IsNullOrWhiteSpace(txtEmail.Text) &&
                        !string.IsNullOrWhiteSpace(txtTelefono.Text))
                    {

                        DateTime fechaSeleccionada = dateTimePicker1.Value;
                        MedioDePago medioPago = (MedioDePago)comboBoxPago.SelectedValue;
                        string plazo = comboBoxPlazo.Text;
                        decimal precio = 0m;

                        precio = calcularPrecio(plazo, precio);

                        AlquilerDao alquilerDao = new AlquilerDao();
                        int idAlquiler = alquilerDao.ContabilizarAlquileresEnBD();

                        Alquiler alquilerActual = new Alquiler(volquetesElegidos, fechaSeleccionada, txtDireccion.Text, txtNombre.Text,
                            txtEmail.Text, txtTelefono.Text, plazo, precio, medioPago, idAlquiler);

                        if (medioPago == MedioDePago.TarjetaDeCredito)
                        {
                            PagoTarjeta vePagoTarjeta = new PagoTarjeta(precio, alquilerActual, volquetesElegidos);
                            vePagoTarjeta.ShowDialog();
                        }
                        else if (medioPago == MedioDePago.Transferencia)
                        {
                            Transferencia pagoTransferencia = new Transferencia();

                            pagoTransferencia.ProcesarPago(precio);
                            pagoTransferencia.GenerarFactura(alquilerActual);

                            GestionUsuarios.UsuarioActual.AgregarAlquiler(alquilerActual);
                            alquilerDao.AgregarAlquilerEnBD(alquilerActual, GestionUsuarios.UsuarioActual.idDB);

                            VolqueteDao volqueteDao = new VolqueteDao();
                            volqueteDao.ActualizarVolquetesEnBD(alquilerActual.IdAlquiler, volquetesElegidos);

                            VentanaEmergente ve = new VentanaEmergente("Reserva", "Reservado con éxito");
                            ve.ShowDialog();
                            if (ve.DialogResult == DialogResult.OK)
                            {
                                this.Close();
                            }
                        }
                        else
                        {
                            GestionUsuarios.UsuarioActual.AgregarAlquiler(alquilerActual);
                            alquilerDao.AgregarAlquilerEnBD(alquilerActual, GestionUsuarios.UsuarioActual.idDB);

                            VolqueteDao volqueteDao = new VolqueteDao();
                            volqueteDao.ActualizarVolquetesEnBD(alquilerActual.IdAlquiler, volquetesElegidos);

                            VentanaEmergente ve = new VentanaEmergente("Reserva", "Reservado con éxito");
                            ve.ShowDialog();
                            if (ve.DialogResult == DialogResult.OK)
                            {
                                this.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ManejarError(ex, "Error al confirmar la reserva.");
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private decimal calcularPrecio(string plazo, decimal precio)
        {
            foreach (Volquete volqueteElegido in volquetesElegidos)
            {
                switch (plazo)
                {
                    case "24hs":
                        if (volqueteElegido.Tipo == TipoDeVolquete.Pequeño)
                        {
                            precio += 96.00m;
                        }
                        else if (volqueteElegido.Tipo == TipoDeVolquete.Mediano)
                        {
                            precio += 300.00m;
                        }
                        else
                        {
                            precio += 500.00m;
                        }

                        break;
                    case "48hs":
                        if (volqueteElegido.Tipo == TipoDeVolquete.Pequeño)
                        {
                            precio += 192.00m;
                        }
                        else if (volqueteElegido.Tipo == TipoDeVolquete.Mediano)
                        {
                            precio += 600.00m;
                        }
                        else
                        {
                            precio += 1000.00m;
                        }
                        break;
                    case "72hs":
                        if (volqueteElegido.Tipo == TipoDeVolquete.Pequeño)
                        {
                            precio += 288.00m;
                        }
                        else if (volqueteElegido.Tipo == TipoDeVolquete.Mediano)
                        {
                            precio += 900.00m;
                        }
                        else
                        {
                            precio += 1500.00m;
                        }
                        break;
                    case "1 semana":
                        if (volqueteElegido.Tipo == TipoDeVolquete.Pequeño)
                        {
                            precio += 672.00m;
                        }
                        else if (volqueteElegido.Tipo == TipoDeVolquete.Mediano)
                        {
                            precio += 2100.00m;
                        }
                        else
                        {
                            precio += 3500.00m;
                        }
                        break;
                    case "2 semanas":
                        if (volqueteElegido.Tipo == TipoDeVolquete.Pequeño)
                        {
                            precio += 1344.00m;
                        }
                        else if (volqueteElegido.Tipo == TipoDeVolquete.Mediano)
                        {
                            precio += 4200.00m;
                        }
                        else
                        {
                            precio += 7000.00m;
                        }
                        break;
                    case "1 mes":
                        if (volqueteElegido.Tipo == TipoDeVolquete.Pequeño)
                        {
                            precio += 2880.00m;
                        }
                        else if (volqueteElegido.Tipo == TipoDeVolquete.Mediano)
                        {
                            precio += 9000.00m;
                        }
                        else
                        {
                            precio += 15000.00m;
                        }
                        break;
                }
            }
            return precio;


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

    }
}
