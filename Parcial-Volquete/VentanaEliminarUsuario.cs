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
    public partial class VentanaEliminarUsuario : Form
    {
        UserDao userdao = new UserDao();
        public event EventHandler UsuarioEliminado;
        public VentanaEliminarUsuario()
        {
            InitializeComponent();

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdDB.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtIdDB, "Ingrese un valor en la TextBox antes de confirmar.");
            }
            else
            {
                int idDB = Convert.ToInt32(txtIdDB.Text);
                userdao.DropUsuarioPorId(idDB);
                OnUsuarioEliminado();
            }
        }

        private void OnUsuarioEliminado()
        {
            UsuarioEliminado?.Invoke(this, EventArgs.Empty);
        }



        private void txtIdDB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void VentanaEliminarUsuario_Load(object sender, EventArgs e)
        {

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

        private void VentanaEliminarUsuario_MouseDown(object sender, MouseEventArgs e)
        {
            // Permitir el movimiento del formulario al hacer clic y arrastrar
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
    }
}
