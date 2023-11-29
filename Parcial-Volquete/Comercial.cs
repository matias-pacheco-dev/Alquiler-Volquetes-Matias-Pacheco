using Entidades;
using Dominio;
using MySql.Data.MySqlClient;
using System.Data;
using AccesoDatos;

namespace Parcial_Volquete
{
    public partial class Comercial : Form
    {
        private List<Volquete> listaVolquetes = new List<Volquete>();
        CarritoDeCompras Carrito;
        Action<Volquete> InformarVolquete;

        bool carritoVisible = false;



        public Comercial()
        {
            InitializeComponent();
            this.FormClosed += Comercial_FormClosed;
            Carrito = new CarritoDeCompras();
        }

        private void btnChico_Click(object sender, EventArgs e)
        {
            VerificarYAgregarVolquete(1.75, TipoDeVolquete.Pequeño);
        }

        private void btnMediano_Click(object sender, EventArgs e)
        {
            VerificarYAgregarVolquete(2.5, TipoDeVolquete.Mediano);
        }

        private void btnGrande_Click(object sender, EventArgs e)
        {
            VerificarYAgregarVolquete(5.0, TipoDeVolquete.Grande);
        }


        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (listaVolquetes.Count > 0)
            {
                Reserva rv = new Reserva(listaVolquetes);
                rv.ShowDialog();
                rv.Dispose();
                Carrito.Reset();
                listaVolquetes.Clear();
            }
        }

        private void btnCarrito_Click(object sender, EventArgs e)
        {
            if (carritoVisible == false)
            {
                Carrito.Show();
                carritoVisible = true;
            }
            else
            {
                Carrito.Visible = false;
                carritoVisible = false;
            }

        }

        private void Comercial_Load(object sender, EventArgs e)
        {
            this.InformarVolquete += Carrito.RecibirVolquete;

        }

        private void Comercial_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Carrito != null)
            {
                Carrito.Close();
                Carrito.Dispose();
            }
        }
        private void VerificarYAgregarVolquete(double capacidad, TipoDeVolquete tipo)
        {
            Volquete nuevoVolquete = new Volquete(capacidad, tipo);

            // Verificar si hay stock del tipo de volquete
            if (VerificarStock(nuevoVolquete.Tipo))
            {
                listaVolquetes.Add(nuevoVolquete);
                this.InformarVolquete.Invoke(nuevoVolquete);
            }
            else
            {
                VentanaEmergente ve = new VentanaEmergente("Error!", "No hay stock de ese volquete");
                ve.ShowDialog();
            }
        }

        private bool VerificarStock(TipoDeVolquete tipo)
        {
            VolqueteDao volqueteDao = new VolqueteDao();
            Dictionary<TipoDeVolquete, int> contadores = volqueteDao.ContabilizarVolquetesPorTipoEnBD();

            if (contadores.ContainsKey(tipo) && contadores[tipo] > 0)
            {
                return true;
            }

            return false;
        }
       

    }
}