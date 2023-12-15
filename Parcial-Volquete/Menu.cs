using Entidades;
using Dominio;

namespace Parcial_Volquete
{
    public partial class Menu : Form
    {
        Form comercial;
        Form Contactanos;
        Form CuentaReservas;
        Form VistaAdmin;


        Form formularioActivo;

        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            if (GestionUsuarios.UsuarioActual != null)
            {
                administradorPanelToolStripMenuItem.Visible = false;

                // Verifica si el usuario actual es un cliente
                if (GestionUsuarios.UsuarioActual.TipoUsuario == TipoDeUsuario.Cliente)
                {
                    reservasToolStripMenuItem.Visible = true;
                    cuentaToolStripMenuItem.Visible = true;
                }
                else
                {
                    reservasToolStripMenuItem.Visible = false;
                    cuentaToolStripMenuItem.Visible = false;
                }
            }
            else
            {
                administradorPanelToolStripMenuItem.Visible = true;
                reservasToolStripMenuItem.Visible = false;
                cuentaToolStripMenuItem.Visible = false;
            }
        }


        private void CerrarFormularioActivo()
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
                formularioActivo = null;
            }
        }

        private void comercialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarFormularioActivo();

            comercial = new Comercial();
            comercial.MdiParent = this;
            comercial.FormClosed += Comercial_FormClosed;
            comercial.StartPosition = FormStartPosition.CenterScreen;
            pictureBox1.Visible = false;
            comercial.Show();


            formularioActivo = comercial;
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarFormularioActivo();
            pictureBox1.Visible = true;
        }

        private void contáctanosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarFormularioActivo();

            Contactanos = new Contactanos();
            Contactanos.MdiParent = this;
            Contactanos.FormClosed += Contactanos_FormClosed;
            Contactanos.StartPosition = FormStartPosition.CenterScreen;
            pictureBox1.Visible = false;
            Contactanos.Show();

            formularioActivo = Contactanos;
        }

        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarFormularioActivo();

            CuentaReservas = new Cuenta_Reservas();
            CuentaReservas.MdiParent = this;
            CuentaReservas.FormClosed += CuentaReservas_FormClosed;
            CuentaReservas.StartPosition = FormStartPosition.CenterScreen;
            pictureBox1.Visible = false;
            CuentaReservas.Show();

            formularioActivo = CuentaReservas;
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            GestionUsuarios.CerrarSesion();
            Login login = new Login();
            login.Show();
        }

        private void administradorPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarFormularioActivo();

            VistaAdmin = new UsersAdminView();
            VistaAdmin.MdiParent = this;
            VistaAdmin.FormClosed += UsersAdminView_FormClosed;
            VistaAdmin.StartPosition = FormStartPosition.CenterScreen;
            pictureBox1.Visible = false;
            VistaAdmin.Show();

            formularioActivo = VistaAdmin;
        }

        private void Comercial_FormClosed(object sender, FormClosedEventArgs e)
        {
            comercial = null;
        }

        private void Contactanos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Contactanos = null;
        }

        private void CuentaReservas_FormClosed(object sender, FormClosedEventArgs e)
        {
            CuentaReservas = null;
        }

        private void UsersAdminView_FormClosed(object sender, FormClosedEventArgs e)
        {
            VistaAdmin = null;
        }

        private void miPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}