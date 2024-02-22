using MySql.Data.MySqlClient;
using System.Data;


namespace AccesoDatos
{
    public class AlquilerDao : BaseDao<Alquiler>
    {
        public List<Alquiler> ObtenerAlquileres()
        {
            string query = "SELECT * FROM alquiler";
            return ExecuteQuery(query, mapFunction: MapAlquiler);
        }
        public List<Alquiler> ObtenerAlquileresSegunId(int id)
        {
            List<Alquiler> alquileres = new List<Alquiler>();

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM alquiler WHERE Id_Usuario=@id";
                    command.Parameters.AddWithValue("@id", id);
                    command.CommandType = CommandType.Text;

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string valorMedioDePago = reader["Medio De Pago"].ToString();
                            string valorEstado = reader["Estado"].ToString();

                            int IdAlquiler = Convert.ToInt32(reader["Id"]);
                            DateTime fechaEscogida = Convert.ToDateTime(reader["FechaEscogida"]);
                            MedioDePago medioDePago = (MedioDePago)Enum.Parse(typeof(MedioDePago), valorMedioDePago);
                            EstadosAlquiler estado = (EstadosAlquiler)Enum.Parse(typeof(EstadosAlquiler), valorEstado);
                            string ubicacionDeEntrega = reader["UbicacionDeEntrega"].ToString();
                            string nombre = reader["Nombre"].ToString();
                            string email = reader["Email"].ToString();
                            string numeroDeTelefono = reader["NumeroDeTelefono"].ToString();
                            string duracion = reader["Plazo"].ToString();
                            decimal precio = Convert.ToDecimal(reader["Precio"]);

                            VolqueteDao volqueteDao = new VolqueteDao();

                            List<Volquete> volquetes = volqueteDao.ObtenerVolquetesAlquiladosEnBD(IdAlquiler);

                            Alquiler alquiler = new Alquiler(volquetes, fechaEscogida, ubicacionDeEntrega, nombre, email,
                                numeroDeTelefono, duracion, precio, medioDePago, IdAlquiler);
                            alquiler.estado = estado;

                            alquileres.Add(alquiler);
                        }
                    }
                }

            }

            return alquileres;
        }
        public int ContabilizarAlquileresEnBD()
        {

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT MAX(Id) FROM alquiler";
                    command.CommandType = CommandType.Text;

                    int? maxId = command.ExecuteScalar() as int?;

                    if (maxId.HasValue)
                    {
                        return maxId.Value + 1;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
        public void AgregarAlquilerEnBD(Alquiler alquiler, int idDB)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;


                    command.CommandText = @"INSERT INTO alquiler (Id, Id_Usuario, FechaEscogida, `Medio De Pago`, Estado, UbicacionDeEntrega, Nombre, Email, NumeroDeTelefono, Plazo, Precio) 
                    VALUES (@id, @idUsuario, @fechaEscogida, @medioDePago, @estado, @ubicacionDeEntrega, @nombre, @email, @numeroDeTelefono, @plazo, @precio)";

                    command.Parameters.AddWithValue("@id", alquiler.IdAlquiler);
                    command.Parameters.AddWithValue("@idUsuario", idDB);
                    command.Parameters.AddWithValue("@fechaEscogida", alquiler.FechaEscogida);
                    command.Parameters.AddWithValue("@medioDePago", alquiler.MedioDePago);
                    command.Parameters.AddWithValue("@estado", alquiler.estado);
                    command.Parameters.AddWithValue("@ubicacionDeEntrega", alquiler.ubicacionDeEntrega);
                    command.Parameters.AddWithValue("@nombre", alquiler.Nombre);
                    command.Parameters.AddWithValue("@email", alquiler.Email);
                    command.Parameters.AddWithValue("@numeroDeTelefono", alquiler.numeroDeTelefono);
                    command.Parameters.AddWithValue("@plazo", alquiler.Duracion);
                    command.Parameters.AddWithValue("@precio", alquiler.Precio);

                    command.ExecuteNonQuery();
                }
            }
        }
        public void EliminarAlquiler(int Id_Alquiler)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM alquiler WHERE Id = @idAlquiler";
                    command.Parameters.AddWithValue("@idAlquiler", Id_Alquiler);

                    command.ExecuteNonQuery();


                }

            }

        }
        private Alquiler MapAlquiler(MySqlDataReader reader)
        {
            string valorMedioDePago = reader["Medio De Pago"].ToString();
            string valorEstado = reader["Estado"].ToString();

            int IdAlquiler = Convert.ToInt32(reader["Id"]);
            DateTime fechaEscogida = Convert.ToDateTime(reader["FechaEscogida"]);
            MedioDePago medioDePago = (MedioDePago)Enum.Parse(typeof(MedioDePago), valorMedioDePago);
            EstadosAlquiler estado = (EstadosAlquiler)Enum.Parse(typeof(EstadosAlquiler), valorEstado);
            string ubicacionDeEntrega = reader["UbicacionDeEntrega"].ToString();
            string nombre = reader["Nombre"].ToString();
            string email = reader["Email"].ToString();
            string numeroDeTelefono = reader["NumeroDeTelefono"].ToString();
            string duracion = reader["Plazo"].ToString();
            decimal precio = Convert.ToDecimal(reader["Precio"]);

            VolqueteDao volqueteDao = new VolqueteDao();

            List<Volquete> volquetes = volqueteDao.ObtenerVolquetesAlquiladosEnBD(IdAlquiler);

            Alquiler alquiler = new Alquiler(volquetes, fechaEscogida, ubicacionDeEntrega, nombre, email,
                numeroDeTelefono, duracion, precio, medioDePago, IdAlquiler);
            alquiler.estado = estado;

            return alquiler;
        }


    }
}