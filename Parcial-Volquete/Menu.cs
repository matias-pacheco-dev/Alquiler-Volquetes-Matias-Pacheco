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

namespace Parcial_Volquete
{
    public partial class Menu : Form
    {
        Form comercial;
        Form Contactanos;
        Form CuentaReservas;
        Form VistaAdmin;
        public Menu()
        {
            InitializeComponent();

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            if (GestionUsuarios.UsuarioActual != null)
            {
                administradorPanelToolStripMenuItem.Visible = false;
            }
            else
            {
                administradorPanelToolStripMenuItem.Visible = true;
            }
            
        }

        private void comercialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comercial == null)
            {
                this.comercial = new Comercial();

                this.comercial.MdiParent = this;
                this.comercial.FormClosed += Comercial_FormClosed;
                this.comercial.StartPosition = FormStartPosition.CenterScreen;
                this.pictureBox1.Visible = false;

                this.comercial.Show();
            }
            else
            {
                comercial.Activate();
            }


        }

        private void Comercial_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.comercial = null;
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.comercial != null)
            {
                this.comercial.Close();
            }
            else if (this.Contactanos != null)
            {
                this.Contactanos.Close();
            }
            else if (this.CuentaReservas != null)
            {
                this.CuentaReservas.Close();
            }
            else if (this.VistaAdmin != null)
            {
                this.VistaAdmin.Close();
            }

            this.pictureBox1.Visible = true;
        }

        private void contáctanosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Contactanos == null)
            {
                this.Contactanos = new Contactanos();

                this.Contactanos.MdiParent = this;
                this.Contactanos.FormClosed += Contactanos_FormClosed;
                this.Contactanos.StartPosition = FormStartPosition.CenterScreen;
                this.pictureBox1.Visible = false;
                this.Contactanos.Show();
            }
            else
            {
                this.Contactanos.Activate();
            }
        }

        private void Contactanos_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.Contactanos = null;
        }

        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CuentaReservas == null)
            {
                this.CuentaReservas = new Cuenta_Reservas();
                this.CuentaReservas.MdiParent = this;
                this.CuentaReservas.FormClosed += CuentaReservas_FormClosed;
                this.CuentaReservas.StartPosition = FormStartPosition.CenterScreen;
                this.pictureBox1.Visible = false;
                this.CuentaReservas.Show();
            }
        }

        private void CuentaReservas_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.CuentaReservas = null;
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            GestionUsuarios.CerrarSesion();
            Login login = new Login();
            login.Show();
        }

        private void listaDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(VistaAdmin == null)
            {
                this.VistaAdmin = new UsersAdminView();
                this.VistaAdmin.MdiParent = this;
                this.VistaAdmin.FormClosed += UsersAdminView_FormClosed;
                this.VistaAdmin.StartPosition = FormStartPosition.CenterScreen;
                this.pictureBox1.Visible = false;
                this.VistaAdmin.Show();
            }
        }

        private void UsersAdminView_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.VistaAdmin = null;
        }
    }
}
