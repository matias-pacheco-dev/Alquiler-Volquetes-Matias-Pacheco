using Entidades;
using Dominio;
using System.Runtime.InteropServices;

namespace Parcial_Volquete
{
    public partial class CarritoDeCompras : Form
    {
        private int contadorGrande = 0;
        private int contadorMediano = 0;
        private int contadorPequeno = 0;

        public CarritoDeCompras()
        {
            InitializeComponent();
        }

        public void RecibirVolquete(Volquete NuevoVolquete)
        {

            if (NuevoVolquete.Tipo == TipoDeVolquete.Grande)
            {
                contadorGrande++;
            }
            else if (NuevoVolquete.Tipo == TipoDeVolquete.Mediano)
            {
                contadorMediano++;
            }
            else if (NuevoVolquete.Tipo == TipoDeVolquete.Pequeño)
            {
                contadorPequeno++;
            }


            ActualizarListBoxText();
        }

        private void ActualizarListBoxText()
        {
            listBox1.Items.Clear();
            listBox1.Items.Add($"Grande x{contadorGrande}");
            listBox1.Items.Add($"Mediano x{contadorMediano}");
            listBox1.Items.Add($"Pequeño x{contadorPequeno}");
        }
        private void CarritoDeCompras_Load(object sender, EventArgs e)
        {
            ActualizarListBoxText();
        }

        public void Reset()
        {
            listBox1.Items.Clear();
            contadorGrande = 0;
            contadorMediano = 0;
            contadorPequeno = 0;
    }


        #region MoverForm
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void CarritoDeCompras_MouseDown(object sender, MouseEventArgs e)
        {
            // Permitir el movimiento del formulario al hacer clic y arrastrar
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion



    }
}
