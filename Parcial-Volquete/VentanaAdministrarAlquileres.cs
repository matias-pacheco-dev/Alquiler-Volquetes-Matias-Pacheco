using AccesoDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_Volquete
{
    public partial class VentanaAdministrarAlquileres : Form
    {
        VolqueteDao volquetedao;
        AlquilerDao alquilerdao;
        public event EventHandler Changed;

        public VentanaAdministrarAlquileres()
        {
            InitializeComponent();

            volquetedao = new VolqueteDao();
            alquilerdao = new AlquilerDao();
        }

        private void OnChanged()
        {
            Changed?.Invoke(this, EventArgs.Empty);
        }

        private void VentanaAdministrarAlquileres_Load(object sender, EventArgs e)
        {

        }


        private void btnVaciarVolquetes_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtVaciarVolquetes.Text))
            {
                errorVaciarVolquetes.Clear();
                errorVaciarVolquetes.SetError(txtVaciarVolquetes, "Ingrese un valor en la TextBox antes de confirmar.");
            }
            else
            {
                int idAlquiler = Convert.ToInt32(txtVaciarVolquetes.Text);
                volquetedao.VaciarVolquetesEspecificosEnBD(idAlquiler);
                OnChanged();

            }
        }

        private void btnEliminarAlquiler_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEliminarAlquiler.Text))
            {
                errorEliminarAlquiler.Clear();
                errorEliminarAlquiler.SetError(txtEliminarAlquiler, "Ingrese un valor en la TextBox antes de confirmar");
            }
            else
            {
                int idAlquiler = Convert.ToInt32(txtEliminarAlquiler.Text);
                alquilerdao.EliminarAlquiler(idAlquiler);
                OnChanged();
            }

        }

        private void txtVaciarVolquetes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEliminarAlquiler_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        #region MoverForm
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void VentanaAdministrarAlquileres_MouseDown(object sender, MouseEventArgs e)
        {
            // Permitir el movimiento del formulario al hacer clic y arrastrar
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion


        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
