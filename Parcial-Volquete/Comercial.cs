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
        private List<Volquete> listaVolquetes = new List<Volquete>();
        public Comercial()
        {
            InitializeComponent();
        }

        private void btnChico_Click(object sender, EventArgs e)
        {
            AgregarVolquete(1.75, TipoDeVolquete.Pequeño);
        }

        private void btnMediano_Click(object sender, EventArgs e)
        {
            AgregarVolquete(2.5, TipoDeVolquete.Mediano);
        }

        private void btnGrande_Click(object sender, EventArgs e)
        {
            AgregarVolquete(5.0, TipoDeVolquete.Grande);
        }

        private void AgregarVolquete(double capacidad, TipoDeVolquete tipo)
        {
            Volquete nuevoVolquete = new Volquete(capacidad, tipo);
            listaVolquetes.Add(nuevoVolquete);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (listaVolquetes.Count > 0)
            {
                Reserva rv = new Reserva(listaVolquetes);
                rv.ShowDialog();
            }
        }
    }
}