using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class VolqueteDao: MyConnectionToSql
    {
        public List<Volquete> ObtenerVolquetes()
        {
            List<Volquete> volquetes = new List<Volquete>();

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM volquetes";
                    command.CommandType = CommandType.Text;

                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int stock = Convert.ToInt32(reader["Stock"]);
                        double tamaño = Convert.ToDouble(reader["Tamaño"]);
                        string valorTipo = reader["Tipo"].ToString();

                        TipoDeVolquete tipo = (TipoDeVolquete)Enum.Parse(typeof(TipoDeVolquete), valorTipo);

                        Volquete volquete = new Volquete(tamaño, tipo, stock);

                        volquetes.Add(volquete);
                    }
                }
            }

            return volquetes;
        }
        public void ActualizarStockEnBD(TipoDeVolquete tipo, int nuevoStock)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE volquetes SET Stock = @nuevoStock WHERE Tipo = @tipo";
                    command.Parameters.AddWithValue("@nuevoStock", nuevoStock);
                    command.Parameters.AddWithValue("@tipo", tipo.ToString());
                    command.ExecuteNonQuery();
                }
            }
        }



    }


}

