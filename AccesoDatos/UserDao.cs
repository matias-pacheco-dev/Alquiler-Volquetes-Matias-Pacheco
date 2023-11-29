using MySql.Data.MySqlClient;
using System.Data;

namespace AccesoDatos
{
    public class UserDao : MyConnectionToSql
    {
        public Usuario Login(string user, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM usuarios WHERE Nombre=@user and Contraseña=@pass";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;

                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();

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
                    }

                    return null;
                }
            }
        }



        public List<Usuario> ObtenerTodosLosUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM usuarios";
                    command.CommandType = CommandType.Text;

                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int tipoUsuario = Convert.ToInt32(reader["TipoUsuario"]);
                        int id = Convert.ToInt32(reader["ID"]);

                        if (tipoUsuario == 1)
                        {
                            AlquilerDao alquilerDao = new AlquilerDao();
                            List<Alquiler> list = alquilerDao.ObtenerAlquileresSegunId(id);
                            usuarios.Add(new Cliente(id, reader["Nombre"].ToString(), reader["Contraseña"].ToString(), list, tipoUsuario));
                        }
                        else if (tipoUsuario == 2)
                        {
                            usuarios.Add(new Administrador(id, reader["Nombre"].ToString(), reader["Contraseña"].ToString(), tipoUsuario));
                        }
                    }
                }
            }

            return usuarios;
        }

        public void ModificarUsuariosEnDB(List<Usuario> NuevosUsuarios)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                foreach (Usuario nuevoUsuario in NuevosUsuarios)
                {
                    using (var command = new MySqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "UPDATE usuarios SET Nombre=@nombre, Contraseña=@contraseña, TipoUsuario=@tipoUsuario WHERE ID=@id";
                        command.Parameters.AddWithValue("@nombre", nuevoUsuario.id);
                        command.Parameters.AddWithValue("@contraseña", nuevoUsuario.contraseña);
                        command.Parameters.AddWithValue("@id", nuevoUsuario.idDB);
                        command.Parameters.AddWithValue("@tipoUsuario", nuevoUsuario.TipoUsuario);
                        command.CommandType = CommandType.Text;

                        command.ExecuteNonQuery();
                    }
                }
            }
        }
        public void DropUsuarioPorId(int IdDB)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM usuarios WHERE ID=@id";
                    command.Parameters.AddWithValue("@id", IdDB);
                    command.CommandType = CommandType.Text;

                    command.ExecuteNonQuery();
                }
            }
        }
    }

}




