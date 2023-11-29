
using MySql.Data.MySqlClient;
using System.Data;

namespace AccesoDatos
{
    public class VolqueteDao : MyConnectionToSql
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
                    command.CommandText = "SELECT ID, Tamaño, Tipo, id_alquiler FROM volquetes";
                    command.CommandType = CommandType.Text;

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            double tamaño = Convert.ToDouble(reader["Tamaño"]);
                            string valorTipo = reader["Tipo"].ToString();
                            int id = Convert.ToInt32(reader["ID"]);
                            int? idAlquiler = reader["id_alquiler"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["id_alquiler"]);

                            TipoDeVolquete tipo = (TipoDeVolquete)Enum.Parse(typeof(TipoDeVolquete), valorTipo);

                            Volquete volquete = new Volquete(id, tamaño, tipo)
                            {
                                IdAlquiler = idAlquiler
                            };

                            volquetes.Add(volquete);
                        }
                    }
                }
            }
            return volquetes;
        }

        public void ActualizarVolquetesEnBD(int idAlquiler, List<Volquete> VolquetesElegidos)
        {
            List<Volquete> InventarioVolquetes = ObtenerVolquetes();

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;

                    foreach (Volquete volqueteElegido in VolquetesElegidos)
                    {
                        Volquete volqueteOriginal = InventarioVolquetes.FirstOrDefault(v => v.Tipo == volqueteElegido.Tipo && v.IdAlquiler == null);

                        if (volqueteOriginal != null)
                        {
                            command.Parameters.Clear();

                            command.CommandText = "UPDATE volquetes SET id_alquiler = @id_alquiler WHERE ID = @id_volquete AND id_alquiler IS NULL";
                            command.Parameters.AddWithValue("@id_alquiler", idAlquiler);
                            command.Parameters.AddWithValue("@id_volquete", volqueteOriginal.Id);

                            command.ExecuteNonQuery();
                            InventarioVolquetes.Remove(volqueteOriginal);
                        }
                    }
                }
            }
        }



        public List<Volquete> ObtenerVolquetesAlquiladosEnBD(int idAlquiler)
        {
            List<Volquete> volquetes = new List<Volquete>();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM volquetes WHERE id_alquiler = @idAlquiler";
                    command.Parameters.AddWithValue("@idAlquiler", idAlquiler);
                    command.CommandType = CommandType.Text;

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            double tamaño = Convert.ToDouble(reader["Tamaño"]);
                            string valorTipo = reader["Tipo"].ToString();

                            TipoDeVolquete tipo = (TipoDeVolquete)Enum.Parse(typeof(TipoDeVolquete), valorTipo);

                            Volquete volquete = new Volquete(tamaño, tipo);

                            volquetes.Add(volquete);
                        }
                    }

                    return volquetes;
                }
            }
        }
        public void VaciarVolquetesEspecificosEnBD(int idAlquiler)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE volquetes SET id_alquiler = NULL WHERE id_alquiler = @id_alquiler";
                    command.Parameters.AddWithValue("@id_alquiler", idAlquiler);
                    command.ExecuteNonQuery();
                }
            }
        }

        public int ContabilizarVolquetesEnBD()
        {

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT MAX(ID) FROM volquetes";
                    command.CommandType = CommandType.Text;

                    int? maxId = command.ExecuteScalar() as int?;

                    if (maxId.HasValue)
                    {
                        return maxId.Value;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        public void AgregarVolqueteADB(Volquete NuevoVolquete)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"INSERT INTO volquetes(Tamaño, `Tipo`) VALUES (@tamaño, @tipo)";
                    command.Parameters.AddWithValue("@tamaño", NuevoVolquete.Tamaño);
                    command.Parameters.AddWithValue("@tipo", NuevoVolquete.Tipo.ToString());
                    command.ExecuteNonQuery();
                }
            }
        }

        public Dictionary<TipoDeVolquete, int> ContabilizarVolquetesPorTipoEnBD()
        {
            Dictionary<TipoDeVolquete, int> contadores = new Dictionary<TipoDeVolquete, int>();

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT Tipo, COUNT(*) as Cantidad FROM volquetes GROUP BY Tipo";
                    command.CommandType = CommandType.Text;

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string valorTipo = reader["Tipo"].ToString();
                            TipoDeVolquete tipo = (TipoDeVolquete)Enum.Parse(typeof(TipoDeVolquete), valorTipo);
                            int cantidad = Convert.ToInt32(reader["Cantidad"]);

                            contadores.Add(tipo, cantidad);
                        }
                    }
                }
            }

            return contadores;

        }


    }

}