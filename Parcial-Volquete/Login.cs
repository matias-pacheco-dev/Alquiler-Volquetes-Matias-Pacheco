using System.Runtime.InteropServices;
using Entidades;

namespace Parcial_Volquete
{
    public partial class Login : Form
    {
        List<Usuario> usuarios;
        public Login()
        {
            InitializeComponent();
            usuarios = GestionUsuarios.CargarUsuariosDesdeJSON();

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);



        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            foreach (Usuario usuario in usuarios)
            {
                if (txtUser.Text == usuario.Id && txtPassword.Text == usuario.Contraseña)
                {
                    VentanaEmergente ve = new VentanaEmergente("Log In", "Usuario logueado con exito");
                    ve.ShowDialog();
                    if (ve.DialogResult == DialogResult.OK)
                    {
                        GestionUsuarios.IniciarSesion(usuario);
                        Menu mp = new Menu();
                        mp.Show();
                        this.Hide();
                    }
                }
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
            GestionUsuarios.GuardarUsuariosEnJSON();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.Id == "user")
                {
                    VentanaEmergente ve = new VentanaEmergente("Log In", "Usuario logueado con exito");
                    ve.ShowDialog();
                    if (ve.DialogResult == DialogResult.OK)
                    {
                        GestionUsuarios.IniciarSesion(usuario);
                        Menu mp = new Menu();
                        mp.Show();
                        this.Hide();
                    }
                }
            }

        }
    }
}