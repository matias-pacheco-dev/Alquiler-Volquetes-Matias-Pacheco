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
    public partial class UsersAdminView : Form
    {
        public UsersAdminView()
        {
            InitializeComponent();
        }



        private void UsersAdminView_Load(object sender, EventArgs e)
        {
            dtgListaUsuarios.DataSource = GestionUsuarios.Usuarios;

        }


        private void dtgListaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
