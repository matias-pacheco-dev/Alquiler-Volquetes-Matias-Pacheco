using AccesoDatos;
using Dominio;
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
    public partial class VentanaAgregarVolquete : Form
    {
        VolqueteDao volquetedao;
        public VentanaAgregarVolquete()
        {
            InitializeComponent();
            volquetedao = new VolqueteDao();
        }

        private void VentanaAgregarVolquete_Load(object sender, EventArgs e)
        {
            comboBoxTipo.DataSource = Enum.GetValues(typeof(TipoDeVolquete));
        }

        private void btnAgregarVolquete_Click(object sender, EventArgs e)
        {
            TipoDeVolquete tipo = (TipoDeVolquete)comboBoxTipo.SelectedValue;

            Volquete volquete = null;

            switch (tipo)
            {
                case TipoDeVolquete.Pequeño:
                    volquete = new Volquete(1.75, TipoDeVolquete.Pequeño);
                    break;
                case TipoDeVolquete.Mediano:
                    volquete = new Volquete(2.5, TipoDeVolquete.Mediano);
                    break;
                case TipoDeVolquete.Grande:
                    volquete = new Volquete(5.0, TipoDeVolquete.Grande);
                    break;
            }
            volquetedao.AgregarVolqueteADB(volquete);

            VentanaEmergente ve = new VentanaEmergente("Éxito", "Volquete agregado");
            ve.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region MoverForm
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void VentanaAgregarVolquete_MouseDown(object sender, MouseEventArgs e)
        {
            // Permitir el movimiento del formulario al hacer clic y arrastrar
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion





    }


}
