using AccesoDatos;
using Dominio;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_Volquete
{
    public partial class BuzonAdmin : Form
    {
        public BuzonAdmin()
        {
            InitializeComponent();
            listViewMensajes.View = View.Details;
            listViewMensajes.Columns.Add("Remitente");
            listViewMensajes.Columns.Add("Contenido");
            listViewMensajes.Columns[0].Width = 100;  // Ancho para la columna "Remitente"
            listViewMensajes.Columns[1].Width = 200;  // Ancho para la columna "Contenido"
        }

        private void BuzonAdmin_Load(object sender, EventArgs e)
        {
            int idAdmin = GestionUsuarios.AdminActual.idDB;

            // Crear una instancia de MensajesDao
            MensajesDao mensajesDao = new MensajesDao();

            // Obtener la cola de mensajes utilizando el método ObtenerMensajesPorIdUsuario
            Queue<Mensaje> mensajes = mensajesDao.ObtenerMensajesPorIdUsuario(idAdmin);

            // Llenar el ListView con la información de los mensajes
            foreach (Mensaje mensaje in mensajes)
            {
                ListViewItem item = new ListViewItem(mensaje.Remitente);
                item.SubItems.Add(mensaje.Contenido);
                listViewMensajes.Items.Add(item);
            }
            foreach (ColumnHeader column in listViewMensajes.Columns)
            {
                column.Width = -1; // Ajustar automáticamente al contenido completo
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region MoverForm
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void BuzonAdmin_MouseDown(object sender, MouseEventArgs e)
        {
            // Permitir el movimiento del formulario al hacer clic y arrastrar
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion


    }
}
