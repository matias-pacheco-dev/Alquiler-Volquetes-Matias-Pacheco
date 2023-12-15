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
    public partial class EnviarMensaje : Form
    {
        public EnviarMensaje()
        {
            InitializeComponent();
        }
        private void EnviarMensaje_Load(object sender, EventArgs e)
        {
            UserDao userDao = new UserDao();

            List<Usuario> administradores = userDao.ObtenerAdministradores();

            // Asignar la lista de administradores como fuente de datos del ComboBox
            comboBox.DataSource = administradores;

            // Establecer la propiedad de Visualización y Valor del ComboBox
            comboBox.DisplayMember = "Nombre"; // Nombre es la propiedad que se mostrará en el ComboBox
            comboBox.ValueMember = "ID"; // ID es la propiedad que se usará como valor seleccionado
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Usuario administradorSeleccionado = comboBox.SelectedItem as Usuario;

            if (administradorSeleccionado != null)
            {
                int idUsuario = administradorSeleccionado.idDB;
                string mensajeContenido = richTextBox.Text;
                string remitente = GestionUsuarios.UsuarioActual.id;

                if (!string.IsNullOrWhiteSpace(mensajeContenido))
                {
                    Mensaje mensaje = new Mensaje(remitente, idUsuario, mensajeContenido);

                    MensajesDao mensajesDao = new MensajesDao();
                    mensajesDao.InsertarMensaje(mensaje);

                    // Opcional: Mostrar un mensaje de éxito
                    VentanaEmergente ve = new VentanaEmergente("Mensaje Enviado", "Devuelto a Reservas");
                    ve.ShowDialog();
                    if (ve.DialogResult == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un mensaje antes de enviar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un administrador antes de enviar el mensaje.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        #region MoverForm
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void EnviarMensaje_MouseDown(object sender, MouseEventArgs e)
        {
            // Permitir el movimiento del formulario al hacer clic y arrastrar
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion


    }
}
