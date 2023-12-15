using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class MensajesDao: BaseDao<Alquiler>
    {
        // Agrega un método para insertar un mensaje en la base de datos
        public void InsertarMensaje(string mensaje, int IdUsuario)
        {
            string query = "INSERT INTO mensajes (ID_usuario, Mensaje) VALUES (@id_usuario, @Mensaje)";

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@Mensaje", mensaje},
                { "@id_usuario", IdUsuario}
            };

            ExecuteScalar(query, parameters);
        }

        public List<string> ObtenerMensajesPorIdUsuario(int IdUsuario)
        {
            List<string> mensajes = new List<string>();
            string query = "SELECT Mensaje FROM mensajes WHERE ID_usuario = @id_usuario";

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@id_usuario", IdUsuario }
            };

            ExecuteReader(query, parameters, reader =>
            {
                while (reader.Read())
                {
                    mensajes.Add(Convert.ToString(reader["Mensaje"]));
                }
            });

            return mensajes;
        }
    }
}


