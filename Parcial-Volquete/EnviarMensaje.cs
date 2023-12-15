using AccesoDatos;
using Dominio;
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
            // Obtener el usuario seleccionado en el ComboBox
            Usuario administradorSeleccionado = comboBox.SelectedItem as Usuario;

            if (administradorSeleccionado != null)
            {
                // Obtener el ID del usuario seleccionado
                int idUsuario = administradorSeleccionado.idDB;

                // Obtener el mensaje del TextBox (asegúrate de tener el nombre correcto del TextBox)
                string mensaje = richTextBox.Text;

                // Validar que el mensaje no esté vacío antes de enviarlo a la base de datos
                if (!string.IsNullOrWhiteSpace(mensaje))
                {
                    // Enviar el mensaje a la base de datos
                    MensajesDao mensajesDao = new MensajesDao();
                    mensajesDao.InsertarMensaje(mensaje, idUsuario);

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
                    // Mostrar un mensaje de error si el mensaje está vacío
                    MessageBox.Show("Por favor, ingrese un mensaje antes de enviar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Mostrar un mensaje de error si no se selecciona ningún administrador
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
