using AccesoDatos;
using Dominio;
using Entidades;

namespace Parcial_Volquete
{
    public partial class UsersAdminView : Form
    {
        UserDao userdao;
        AlquilerDao alquilerdao;
        List<Usuario> NuevosUsuarios;
        private bool edicionHabilitada = false;

        public UsersAdminView()
        {
            InitializeComponent();
            userdao = new UserDao();
            alquilerdao = new AlquilerDao();
        }

        private void UsersAdminView_Load(object sender, EventArgs e)
        {
            try
            {
                #region Iniciar dtgListaUsuarios
                dtgListaUsuarios.Refresh();
                dtgListaUsuarios.AutoGenerateColumns = false;

                dtgListaUsuarios.Columns.Add("IdDB", "IdDB");
                dtgListaUsuarios.Columns.Add("Usuario", "Usuario");
                dtgListaUsuarios.Columns.Add("Contraseña", "Contraseña");


                dtgListaUsuarios.Columns["IdDB"].DataPropertyName = "IdDB";
                dtgListaUsuarios.Columns["Usuario"].DataPropertyName = "id";
                dtgListaUsuarios.Columns["Contraseña"].DataPropertyName = "Contraseña";


                DataGridViewComboBoxColumn tipoUsuarioColumn = new DataGridViewComboBoxColumn();
                tipoUsuarioColumn.HeaderText = "TipoUsuario";
                tipoUsuarioColumn.Name = "TipoUsuario";
                tipoUsuarioColumn.DataPropertyName = "TipoUsuario"; // Ajusta según tus necesidades

                // Agrega las opciones al combo box
                tipoUsuarioColumn.Items.Add(1);
                tipoUsuarioColumn.Items.Add(2);

                dtgListaUsuarios.Columns.Add(tipoUsuarioColumn);


                dtgListaUsuarios.DataSource = userdao.ObtenerTodosLosUsuarios();
                #endregion
            }
            catch (Exception ex)
            {
                // Manejar la excepción
                MessageBox.Show($"Error al intentar cargar usuarios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Generar el log de error utilizando la Serializadora
                LogEntry logError = new LogEntry(ex.Message);

                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string logFilePath = Path.Combine(desktopPath, "error_log.xml");

                var serializarXML = new SerializadorXML<LogEntry>(logFilePath);

                serializarXML.Serializar(logError);
            }

            #region Iniciar dtgAlquileres

            try
            {
                dtgAlquileres.Refresh();
                dtgAlquileres.AutoGenerateColumns = false;

                // Configura las columnas según las propiedades de tu clase Alquiler
                dtgAlquileres.Columns.Add("IdAlquiler", "Id");
                dtgAlquileres.Columns.Add("VolquetesAlquiler", "Volquetes");
                dtgAlquileres.Columns.Add("FechaEscogida", "Fecha");
                dtgAlquileres.Columns.Add("ubicacionDeEntrega", "Ubicación de entrega");
                dtgAlquileres.Columns.Add("Nombre", "Nombre");
                dtgAlquileres.Columns.Add("Email", "Email");
                dtgAlquileres.Columns.Add("numeroDeTelefono", "Teléfono");
                dtgAlquileres.Columns.Add("Duracion", "Duración");
                dtgAlquileres.Columns.Add("Precio", "Precio");
                dtgAlquileres.Columns.Add("MedioDePago", "Medio de Pago");
                dtgAlquileres.Columns.Add("estado", "Estado");


                // Configura las propiedades de las columnas según el tipo de datos
                dtgAlquileres.Columns["IdAlquiler"].DataPropertyName = "IdAlquiler";
                dtgAlquileres.Columns["VolquetesAlquiler"].DataPropertyName = "VolquetesToString";
                dtgAlquileres.Columns["FechaEscogida"].DataPropertyName = "FechaEscogida";
                dtgAlquileres.Columns["ubicacionDeEntrega"].DataPropertyName = "ubicacionDeEntrega";
                dtgAlquileres.Columns["Nombre"].DataPropertyName = "Nombre";
                dtgAlquileres.Columns["Email"].DataPropertyName = "Email";
                dtgAlquileres.Columns["numeroDeTelefono"].DataPropertyName = "numeroDeTelefono";
                dtgAlquileres.Columns["Duracion"].DataPropertyName = "Duracion";
                dtgAlquileres.Columns["Precio"].DataPropertyName = "Precio";
                dtgAlquileres.Columns["MedioDePago"].DataPropertyName = "MedioDePago";
                dtgAlquileres.Columns["estado"].DataPropertyName = "estado";

                dtgAlquileres.DataSource = alquilerdao.ObtenerAlquileres();
            }
            catch (Exception ex)
            {
                // Manejar la excepción
                MessageBox.Show($"Error al intentar cargar alquileres: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Generar el log de error utilizando la Serializadora
                LogEntry logError = new LogEntry(ex.Message);

                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string logFilePath = Path.Combine(desktopPath, "error_log.xml");

                var serializarXML = new SerializadorXML<LogEntry>(logFilePath);

                serializarXML.Serializar(logError);
            }


            #endregion

            SetearSiLee();
        }

        private void btnEdicion_Click(object sender, EventArgs e)
        {
            edicionHabilitada = !edicionHabilitada;

            SetearSiLee();


            if (edicionHabilitada)
            {
                btnEdicion.Text = "Deshabilitar Edición Usuario";
            }
            else
            {
                btnEdicion.Text = "Habilitar Edición Usuario";
            }
        }


        private void SetearSiLee()
        {
            foreach (DataGridViewColumn column in dtgListaUsuarios.Columns)
            {
                column.ReadOnly = !edicionHabilitada;
                dtgListaUsuarios.Columns["IdDB"].ReadOnly = true;
            }

            List<string> columnasEditables = new List<string>
            {
                "IdAlquiler",
                "FechaEscogida",
                "ubicacionDeEntrega",
                "Nombre",
                "Email",
                "numeroDeTelefono",
                "Duracion",
                "Precio",
                "MedioDePago",
                "estado"
            };

            foreach (DataGridViewColumn column in dtgAlquileres.Columns)
            {
                column.ReadOnly = !edicionHabilitada || !columnasEditables.Contains(column.Name);
            }

        }

        private void ObtenerModificaciones()
        {
            try
            {
                foreach (DataGridViewRow row in dtgListaUsuarios.Rows)
                {
                    if (row.IsNewRow)
                        continue;

                    int idDB = Convert.ToInt32(row.Cells["IdDB"].Value);
                    string id = row.Cells["Usuario"].Value.ToString();
                    string contraseña = row.Cells["Contraseña"].Value.ToString();
                    int tipoUsuario = Convert.ToInt32(row.Cells["TipoUsuario"].Value);

                    if (tipoUsuario == 1)
                    {
                        NuevosUsuarios.Add(new Cliente(idDB, id, contraseña, tipoUsuario));
                    }
                    else if (tipoUsuario == 2)
                    {
                        NuevosUsuarios.Add(new Administrador(idDB, id, contraseña, tipoUsuario));
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción
                MessageBox.Show($"Error al intentar obtener modificaciones: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Generar el log de error utilizando la Serializadora
                LogEntry logError = new LogEntry(ex.Message);

                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string logFilePath = Path.Combine(desktopPath, "error_log.xml");

                var serializarXML = new SerializadorXML<LogEntry>(logFilePath);

                serializarXML.Serializar(logError);
            }
        }


        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                NuevosUsuarios = new List<Usuario>();
                ObtenerModificaciones();
                userdao.ModificarUsuariosEnDB(NuevosUsuarios);

                VentanaEmergente ve = new VentanaEmergente("Éxito", "Cambios realizados");
                ve.ShowDialog();

            }
            catch (Exception ex)
            {
                // Manejar la excepción
                MessageBox.Show($"Error al intentar guardar cambios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Generar el log de error utilizando la Serializadora
                LogEntry logError = new LogEntry(ex.Message);

                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string logFilePath = Path.Combine(desktopPath, "error_log.xml");

                var serializarXML = new SerializadorXML<LogEntry>(logFilePath);

                serializarXML.Serializar(logError);
            }
        }


        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            VentanaEliminarUsuario ViewEliminarUsuario = new VentanaEliminarUsuario();
            ViewEliminarUsuario.UsuarioEliminado += ViewEliminarUsuario_UsuarioEliminado;
            ViewEliminarUsuario.ShowDialog();
        }
        private void ViewEliminarUsuario_UsuarioEliminado(object sender, EventArgs e)
        {
            dtgListaUsuarios.DataSource = userdao.ObtenerTodosLosUsuarios();
        }
        public void ActualizarDataGridViewAlquileres(object sender, EventArgs e)
        {
            dtgAlquileres.DataSource = alquilerdao.ObtenerAlquileres();
        }



        private void btnAdministrarAlquileres_Click(object sender, EventArgs e)
        {
            VentanaAdministrarAlquileres ViewAdministrarAlquileres = new VentanaAdministrarAlquileres();
            ViewAdministrarAlquileres.Changed += ActualizarDataGridViewAlquileres;
            ViewAdministrarAlquileres.ShowDialog();
        }

        private void btnAgregarVolquete_Click(object sender, EventArgs e)
        {
            VentanaAgregarVolquete ViewAgregarVolquete = new VentanaAgregarVolquete();
            ViewAgregarVolquete.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuzonAdmin buzon = new BuzonAdmin();
            buzon.ShowDialog();
        }
    }
}
