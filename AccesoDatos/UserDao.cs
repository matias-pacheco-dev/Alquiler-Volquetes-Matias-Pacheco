using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entidades;
using MySql.Data.MySqlClient;

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

                        if (tipoUsuario == 1)
                        {
                            return new Cliente(reader["Nombre"].ToString(), reader["Contraseña"].ToString());
                        }
                        else if (tipoUsuario == 2)
                        {
                            return new Administrador(reader["Nombre"].ToString(), reader["Contraseña"].ToString());
                        }
                    }

                    // Si no se encontró el usuario o el tipo de usuario no es válido
                    return null;
                }
            }
        }
    }
}
