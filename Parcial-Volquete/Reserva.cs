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
using System.Runtime.InteropServices;
using System.Numerics;
using AccesoDatos;

namespace Parcial_Volquete
{
    public partial class Reserva : Form
    {
        List<Volquete> volquetesElegidos;
        List<Volquete> volquetesOriginales;
        public Reserva(List<Volquete> volqueteElegido)
        {
            InitializeComponent();
            volquetesElegidos = volqueteElegido;

        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);




        private void Reserva_Load(object sender, EventArgs e)
        {
            comboBoxPago.DataSource = Enum.GetValues(typeof(MedioDePago));
            VolqueteDao volqueteDao = new VolqueteDao();
            volquetesOriginales = volqueteDao.ObtenerVolquetes();

        }

        private void Reserva_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (GestionUsuarios.UsuarioActual != null)
            {
                DateTime fechaSeleccionada = dateTimePicker1.Value;
                MedioDePago medioPago = (MedioDePago)comboBoxPago.SelectedValue;
                string plazo = comboBoxPlazo.Text;
                decimal precio = 0m;

                precio = calcularPrecio(plazo, precio);


                Alquiler alquilerActual = new Alquiler(volquetesElegidos, fechaSeleccionada, txtDireccion.Text, txtNombre.Text, txtEmail.Text,
                    txtTelefono.Text, plazo, precio, medioPago);

                GestionUsuarios.UsuarioActual.AgregarAlquiler(alquilerActual);

                reducirStock();

                VentanaEmergente ve = new VentanaEmergente("Reserva", "Reservado con éxito");
                ve.ShowDialog();
                if (ve.DialogResult == DialogResult.OK)
                {
                    this.Close();
                }
            }




        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private decimal calcularPrecio(string plazo, decimal precio)
        {
            foreach (Volquete volqueteElegido in volquetesElegidos) {
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

        private void reducirStock()
        {
            VolqueteDao volqueteDao = new VolqueteDao();

            foreach (Volquete volqueteElegido in volquetesElegidos)
            {
                
                Volquete volqueteOriginal = volquetesOriginales.Find(v => v.Tipo == volqueteElegido.Tipo);

                if (volqueteOriginal != null)
                {
                    
                    int nuevoStock = volqueteOriginal.Stock - 1;

                    
                    volqueteDao.ActualizarStockEnBD(volqueteElegido.Tipo, nuevoStock);
                }
            }
        }

    } 
}
