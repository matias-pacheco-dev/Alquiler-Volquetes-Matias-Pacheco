using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Parcial_Volquete
{
    public partial class Comercial : Form
    {
        public Comercial()
        {
            InitializeComponent();
        }

        private void btnChico_Click(object sender, EventArgs e)
        {
            Volquete volqueteChico = new Volquete(1.75, TipoDeVolquete.Pequeño);
            Reserva rv = new Reserva(volqueteChico);
            rv.ShowDialog();
        }

        private void btnMediano_Click(object sender, EventArgs e)
        {
            Volquete volqueteMediano = new Volquete(2.5, TipoDeVolquete.Mediano);
            Reserva rv = new Reserva(volqueteMediano);
            rv.ShowDialog();
        }

        private void btnGrande_Click(object sender, EventArgs e)
        {
            Volquete volqueteGrande = new Volquete(5.0, TipoDeVolquete.Grande);
            Reserva rv = new Reserva(volqueteGrande);
            rv.ShowDialog();
        }
      
    }
}
