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
    public partial class Cuenta_Reservas : Form
    {
        public Cuenta_Reservas()
        {
            InitializeComponent();
        }

        private void Cuenta_Reservas_Load(object sender, EventArgs e)
        {
            lblNombreCuenta.Text = GestionUsuarios.UsuarioActual.id;

            dtgAlquileres.DataSource = GestionUsuarios.UsuarioActual.alquileres;


        }

        private void dtgAlquileres_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
