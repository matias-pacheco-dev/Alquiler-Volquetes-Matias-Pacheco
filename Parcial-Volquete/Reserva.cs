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

namespace Parcial_Volquete
{
    public partial class Reserva : Form
    {
        Volquete volqueteElegido;
        public Reserva(Volquete volqueteElegido)
        {
            InitializeComponent();
            this.volqueteElegido = volqueteElegido;
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);




        private void Reserva_Load(object sender, EventArgs e)
        {


        }

        private void Reserva_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = dateTimePicker1.Value;
            string plazo = comboBoxPlazo.Text;
            decimal precio = 0m;

            switch (plazo)
            {
                case "24hs":
                    if (this.volqueteElegido.Tamaño.Equals("Pequeño"))
                    {
                        precio = 96.00m;
                    }
                    else if (this.volqueteElegido.Tamaño.Equals("Mediano"))
                    {
                        precio = 300.00m;
                    }
                    else
                    {
                        precio = 500.00m;
                    }

                    break;
                case "48hs":
                    if (this.volqueteElegido.Tamaño.Equals("Pequeño"))
                    {
                        precio = 192.00m;
                    }
                    else if (this.volqueteElegido.Tamaño.Equals("Mediano"))
                    {
                        precio = 600.00m;
                    }
                    else
                    {
                        precio = 1000.00m;
                    }
                    break;
                case "72hs":
                    if (this.volqueteElegido.Tamaño.Equals("Pequeño"))
                    {
                        precio = 288.00m;
                    }
                    else if (this.volqueteElegido.Tamaño.Equals("Mediano"))
                    {
                        precio = 900.00m;
                    }
                    else
                    {
                        precio = 1500.00m;
                    }
                    break;
                case "1 semana":
                    if (this.volqueteElegido.Tamaño.Equals("Pequeño"))
                    {
                        precio = 672.00m;
                    }
                    else if (this.volqueteElegido.Tamaño.Equals("Mediano"))
                    {
                        precio = 2100.00m;
                    }
                    else
                    {
                        precio = 3500.00m;
                    }
                    break;
                case "2 semanas":
                    if (this.volqueteElegido.Tamaño.Equals("Pequeño"))
                    {
                        precio = 1344.00m;
                    }
                    else if (this.volqueteElegido.Tamaño.Equals("Mediano"))
                    {
                        precio = 4200.00m;
                    }
                    else
                    {
                        precio = 7000.00m;
                    }
                    break;
                case "1 mes":
                    if (this.volqueteElegido.Tamaño.Equals("Pequeño"))
                    {
                        precio = 2880.00m;
                    }
                    else if (this.volqueteElegido.Tamaño.Equals("Mediano"))
                    {
                        precio = 9000.00m;
                    }
                    else
                    {
                        precio = 15000.00m;
                    }
                    break;
            }


            Alquiler alquilerActual = new Alquiler(this.volqueteElegido, fechaSeleccionada, txtDireccion.Text, txtNombre.Text, txtEmail.Text,
                txtTelefono.Text, plazo, precio, comboBoxPago.Text);

            GestionUsuarios.UsuarioActual.AgregarAlquiler(alquilerActual);

            VentanaEmergente ve = new VentanaEmergente("Reserva", "Reservado con éxito");
            ve.ShowDialog();
            if (ve.DialogResult == DialogResult.OK)
            {
                this.Close();
            }



        }
    }
}
