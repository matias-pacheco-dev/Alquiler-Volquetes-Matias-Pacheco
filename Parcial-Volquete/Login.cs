using AccesoDatos;
using Entidades;
using System.Runtime.InteropServices;
using Dominio;

namespace Parcial_Volquete
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();

        }
        // Importación de funciones desde user32.dll para permitir el movimiento del formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void btnAcceder_Click(object sender, EventArgs e)
        {
            try
            {
                // Intentar realizar la conexión a la base de datos
                UserDao userDao = new UserDao();
                Usuario usuario = userDao.Login(txtUser.Text, txtPassword.Text);

                if (usuario != null)
                {
                    if (usuario is Cliente)
                    {
                        VentanaEmergente ve = new VentanaEmergente("Log In", "Cliente logueado con éxito");
                        ve.ShowDialog();

                        if (ve.DialogResult == DialogResult.OK)
                        {
                            GestionUsuarios.IniciarSesion((Cliente)usuario);
                            Menu mp = new Menu();
                            mp.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        VentanaEmergente ve = new VentanaEmergente("Log In", "Admin logueado con éxito");
                        ve.ShowDialog();

                        if (ve.DialogResult == DialogResult.OK)
                        {
                            GestionUsuarios.IniciarSesionAdmin((Administrador)usuario);
                            Menu mp = new Menu();
                            mp.Show();
                            this.Hide();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al intentar acceder: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Generar el log de error utilizando la Serializadora
                Serializadora.GenerarLogDeError(new Serializadora.LogEntry
                {
                    Timestamp = DateTime.Now,
                    Message = $"Error en el login: {ex.Message}"
                });
            }
        }
        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Usuario")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.LightGray;

            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Usuario";
                txtUser.ForeColor = Color.DimGray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Contraseña")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.LightGray;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Contraseña";
                txtPassword.ForeColor = Color.DimGray;
                txtPassword.UseSystemPasswordChar = false;
            }
        }


        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void btnUserAutomatico_Click(object sender, EventArgs e)
        {
            txtUser.Text = "User";
            txtPassword.Text = "Pass";

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            txtUser.Text = "Admin";
            txtPassword.Text = "Pass";
        }
    }
}