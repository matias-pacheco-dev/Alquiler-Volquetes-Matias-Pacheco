using MySql.Data.MySqlClient;
using System.Data;

namespace AccesoDatos
{
    public class UserDao : BaseDao<Usuario>
    {
        public virtual Usuario Login(string user, string pass)
        {
            string query = "SELECT * FROM usuarios WHERE Nombre=@user and Contraseña=@pass";
            var parameters = new Dictionary<string, object>
        {
            { "@user", user },
            { "@pass", pass }
        };

            return ExecuteQuery(query, parameters, MapUsuario).FirstOrDefault();
        }

        public virtual List<Usuario> ObtenerTodosLosUsuarios()
        {
            string query = "SELECT * FROM usuarios";
            return ExecuteQuery(query, mapFunction: MapUsuario);
        }

        public void ModificarUsuariosEnDB(List<Usuario> NuevosUsuarios)
        {
            foreach (Usuario nuevoUsuario in NuevosUsuarios)
            {
                string query = "UPDATE usuarios SET Nombre=@nombre, Contraseña=@contraseña, TipoUsuario=@tipoUsuario WHERE ID=@id";
                var parameters = new Dictionary<string, object>
            {
                { "@nombre", nuevoUsuario.id },
                { "@contraseña", nuevoUsuario.contraseña },
                { "@id", nuevoUsuario.idDB },
                { "@tipoUsuario", nuevoUsuario.TipoUsuario }
            };

                ExecuteQuery(query, parameters);
            }
        }

        public void DropUsuarioPorId(int IdDB)
        {
            string query = "DELETE FROM usuarios WHERE ID=@id";
            var parameters = new Dictionary<string, object>
        {
            { "@id", IdDB }
        };

            ExecuteQuery(query, parameters);
        }

        private Usuario MapUsuario(MySqlDataReader reader)
        {
            int tipoUsuario = Convert.ToInt32(reader["TipoUsuario"]);
            int id = Convert.ToInt32(reader["ID"]);

            if (tipoUsuario == 1)
            {
                AlquilerDao alquilerDao = new AlquilerDao();
                List<Alquiler> list = alquilerDao.ObtenerAlquileresSegunId(id);
                return new Cliente(id, reader["Nombre"].ToString(), reader["Contraseña"].ToString(), list, tipoUsuario);
            }
            else if (tipoUsuario == 2)
            {
                return new Administrador(id, reader["Nombre"].ToString(), reader["Contraseña"].ToString(), tipoUsuario);
            }

            return null;
        }
        public virtual List<Usuario> ObtenerAdministradores()
        {
            string query = "SELECT * FROM usuarios WHERE TipoUsuario = 2";
            return ExecuteQuery(query, mapFunction: MapUsuario);
        }

    }

}




