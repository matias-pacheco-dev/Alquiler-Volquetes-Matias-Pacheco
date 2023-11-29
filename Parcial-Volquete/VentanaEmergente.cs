using Dominio;
namespace Parcial_Volquete
{
    public partial class VentanaEmergente : Form
    {
        private string titulo;
        private string mensaje;


        public VentanaEmergente(string titulo, string mensaje)
        {
            InitializeComponent();
            this.titulo = titulo;
            this.mensaje = mensaje;

        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void VentanaEmergente_Load(object sender, EventArgs e)
        {
            this.lblTitulo.Text = titulo;
            this.lblMensaje.Text = mensaje;
        }
    }
}
